using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;

namespace Quasonix_TX_controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormClosing += this.onExit;
            InitializeComponent();
            freqfile = new System.IO.StreamReader("freqs.conf");
            freqs = freqfile.ReadLine().Split().ToList();
            freqfile.Close();
            foreach (string item in freqs) {
                this.comboBox1.Items.Add(item);
            }
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            var COM = new ToolStripMenuItem() { Name = "COM", Text = "COM Port" };
            foreach (string port in ports)
            {
                COM.DropDownItems.Add(port);
            }

            try
            {
                this.serialPort1 = new SerialPort(ports[0], 57600);
                this.serialPort1.Open();
                this.serialPort1.ReadTimeout= 500;
                this.serialPort1.ReadExisting();
                this.serialPort1.Write("RF 0\r\n");
            }
            catch
            {
                this.comstatus.Text = "Disconnected";
            }
            this.textBox2.Text = ports[0];
            foreach ( ToolStripMenuItem item in COM.DropDownItems)
            {
                item.Click += (sender, e) => this.COMToolStripMenuItem_Click(sender, e, item);
            }
            menuStrip1.Items.Add(COM);
            var helper = new ToolStripMenuItem() { Name = "HELP", Text = "Help" };
            helper.DropDownItems.Add("About");
            helper.DropDownItems[0].Click += new System.EventHandler(this.about_click);
            menuStrip1.Items.Add(helper);
            this.comboBox1.SelectedIndex = 0;
            this.rf_status = "";
            this.frequency = "XXXX.X MHz";
            initialize_dicts();
            this.timer1.Start();
            this.logger = new System.IO.StreamWriter("log.txt");
            this.temperature = "XX.X °C";
            this.RF_status_tooltip.SetToolTip(this.rf_stat_led, "Green: Transmitting\nYellow: Not transmitting. RF output is enabled via software but disabled via hardware.\nRed: Not transmitting; RF output disabled by software");
        }


        private void about_click(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            about.Visible = true;

        }
        private void dontclosepasswdbox(object sender, CancelEventArgs e)
        {
            this.passwdbox.Opacity = 0;
            this.passwdbox.Visible = false;
            e.Cancel = true;
        }

        private void initialize_dicts()
        {
            this.command_names = new Dictionary<string,string>();
            this.command_names.Add("RF", "      RF Power");
            this.command_names.Add("FR", "     Frequency");
            this.command_names.Add("MO", "    Modulation");
            this.command_names.Add("DE", "      Encoding");
            this.command_names.Add("RA", "    Randomizer");
            this.command_names.Add("DP", " Data Polarity");
            this.command_names.Add("DS", "   Data Source");
            this.command_names.Add("CS", "  Clock Source");
            //this.command_names.Add("PL", "Power Level");
            this.command_names.Add("LP", "     Low Power");
            this.command_names.Add("HP", "    High Power");
            this.command_names.Add("SE", "  STC Encoding");
            this.command_names.Add("TE", "   Temperature");
            System.Collections.Generic.Dictionary<int,string> temp_dict 
                = new System.Collections.Generic.Dictionary<int,string>();
            this.translator = 
                new System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, string>>();
            temp_dict  = new System.Collections.Generic.Dictionary<int, string>();
            temp_dict.Add(0, "PCM-FM");
            temp_dict.Add(1, "SOQPSK");
            temp_dict.Add(6, "CARRIER");
            this.translator.Add("MO", temp_dict);
            temp_dict = new System.Collections.Generic.Dictionary<int, string>();
            temp_dict.Add(0, "Off");
            temp_dict.Add(1, "On");
            this.translator.Add("RF", temp_dict);
            this.translator.Add("RA", temp_dict);
            this.translator.Add("SE", temp_dict);
            temp_dict = new System.Collections.Generic.Dictionary<int, string>();
            temp_dict.Add(0, "Normal");
            temp_dict.Add(1, "Differential");
            this.translator.Add("DE", temp_dict);
            temp_dict = new System.Collections.Generic.Dictionary<int, string>();
            temp_dict.Add(0, "Normal");
            temp_dict.Add(1, "Inverted");
            this.translator.Add("DP", temp_dict);
            temp_dict = new System.Collections.Generic.Dictionary<int, string>();
            temp_dict.Add(0, "External");
            temp_dict.Add(1, "Internal");
            this.translator.Add("CS", temp_dict);
            this.translator.Add("DS", temp_dict);
        }

        private void COMToolStripMenuItem_Click(object sender, EventArgs e, ToolStripMenuItem item)
        {
            if (item.Checked == false)
            {
                this.comstatus.Text = "Disconnected";
                this.comstatus.ForeColor = Color.Red;
                this.rf_toggle.Checked = false;
                var x = (ToolStripMenuItem)this.menuStrip1.Items[2];
                foreach (ToolStripMenuItem thing in x.DropDownItems)
                {
                    thing.Checked = false;
                }
                item.Checked = true;
                this.serialPort1.Close();
                this.textBox2.Text = sender.ToString();

                try
                {
                    this.serialPort1 = new SerialPort(sender.ToString(), 57600);
                    this.serialPort1.Open();
                    this.serialPort1.ReadTimeout = 500;
                    if (this.serialPort1.IsOpen)
                    {
                        this.serialPort1.Write("RF 0\r\n");
                        this.rf_toggle.BackColor = Color.Red;
                        this.rf_toggle.ForeColor = Color.White;
                        this.rf_toggle.Text = "RF Disabled (Software)";
                    }
                    else
                    {
                        this.comstatus.Text = "Disconnected";
                        this.comstatus.ForeColor = Color.Red;
                    }
                }
                catch
                {
                    this.comstatus.Text = "Disconnected";
                    this.comstatus.ForeColor = Color.Red;
                }
            }
        }

        private void serialworker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.tx_status = this.frequency = this.temperature = this.rf_status= "";
            int counter = 0;
            if (this.serialPort1.IsOpen)
            {
                try
                {
                    //Clear the serial port input buffer
                    //i.e. any messages received from the transmitter
                    this.serialPort1.DiscardInBuffer();
                    this.serialPort1.DiscardOutBuffer();
                    this.serialPort1.Write("RF \r\n");
                    this.serialPort1.WriteLine("SS \r");
                    System.Threading.Thread.Sleep(500);
                    this.serialPort1.ReadLine();
                    this.rf_status = this.serialPort1.ReadLine();
                    this.rf_status += this.serialPort1.ReadLine();
                    this.rf_status = this.rf_status.Replace("\n", " ");

                    //string comtext = this.comstatus.Text = this.serialPort1.ReadExisting();
                    string comtext = this.serialPort1.ReadExisting();
                    string[] temp = comtext.Split();
                    this.stc_status = false;

                    for (int i = 0; i < temp.Length; i++)
                    {
                        int zzz;
                        if (temp[i] == "FR")
                        {
                            counter++;
                            i++;
                            this.frequency = temp[i] + " MHz";
                        }
                        //else if (temp[i] == "TE")
                        //{
                        //    this.tx_status += this.command_names[temp[i]] + ": ";
                        //    i++;
                        //    this.tx_status += temp[i] + "°C\n";
                        //}
                        else if (temp[i] == "LP") 
                        {
                            counter++;
                            int x = i + 1;
                            this.lp_stat_str = decimal.Parse(temp[x]);
                            i++;
                        }
                        else if (temp[i] == "HP")
                        {
                            counter++;
                            int x = i + 1;
                            this.hp_stat_str = decimal.Parse(temp[x]);
                            i++;
                        }
                        else if (temp[i] == "MO")
                        {
                            counter++;
                            int x = i + 1;
                            switch (Convert.ToInt32(temp[x]))
                            {
                                case 0:
                                    this.soqpsk_led.On = this.carrier_led.On = false;
                                    this.pcmfm_led.On = true;
                                    break;
                                case 1:
                                    this.pcmfm_led.On = this.carrier_led.On = false;
                                    this.soqpsk_led.On = true;
                                    break;
                                case 6:
                                    this.pcmfm_led.On = this.soqpsk_led.On = false;
                                    this.carrier_led.On = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (temp[i] == "DE")
                        {
                            counter++;
                            int x = i + 1;
                            switch (Convert.ToInt32(temp[x]))
                            {
                                case 1:
                                    this.enc_diff_led.On = true;
                                    this.enc_norm_led.On = false;
                                    break;
                                case 0:
                                    this.enc_diff_led.On = false;
                                    this.enc_norm_led.On = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (temp[i] == "RA")
                        {
                            counter++;
                            int x = i + 1;
                            switch (Convert.ToInt32(temp[x]))
                            {
                                case 0:
                                    this.rnz_dis_led.On = true;
                                    this.rnz_en_led.On = false;
                                    break;
                                case 1:
                                    this.rnz_dis_led.On = false;
                                    this.rnz_en_led.On = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (temp[i] == "DP")
                        {
                            counter++;
                            int x = i + 1;
                            switch (Convert.ToInt32(temp[x]))
                            {
                                case 1:
                                    this.dp_inv_led.On = true;
                                    this.dp_norm_led.On = false;
                                    break;
                                case 0:
                                    this.dp_inv_led.On = false;
                                    this.dp_norm_led.On = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (temp[i] == "SE")
                        {
                            this.stc_status = true;
                            counter++;
                            int x = i + 1;
                            switch (Convert.ToInt32(temp[x]))
                            {
                                case 0:
                                    this.stc_off_led.On = true;
                                    this.stc_on_led.On = false;
                                    break;
                                case 1:
                                    this.stc_off_led.On = false;
                                    this.stc_on_led.On = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (temp[i] == "DS")
                        {
                            counter++;
                            int x = i + 1;
                            switch (Convert.ToInt32(temp[x]))
                            {
                                case 0:
                                    this.ds_ext_led.On = true;
                                    this.ds_int_led.On = false;
                                    break;
                                case 1:
                                    this.ds_ext_led.On = false;
                                    this.ds_int_led.On = true;
                                    break;
                                default:
                                    break;
                            }

                        }
                        else if (temp[i] == "CS")
                        {
                            counter++;
                            int x = i + 1;
                            switch (Convert.ToInt32(temp[x]))
                            {
                                case 0:
                                    this.cs_ext_led.On = true;
                                    this.cs_int_led.On = false;
                                    break;
                                case 1:
                                    this.cs_ext_led.On = false;
                                    this.cs_int_led.On = true;
                                    break;
                                default:
                                    break;
                            }

                        }
                        else if (temp[i] == "TE")
                        {
                            counter++;
                            int x = i + 1;
                            this.temperature = temp[x];
                        }
                        else if (this.command_names.ContainsKey(temp[i])
                             && int.TryParse(temp[(i + 1)], out zzz))
                        {
                            counter++;
                            this.tx_status += this.command_names[temp[i]] + ": ";
                            int x = i + 1;
                            this.logger.WriteLine(temp[i]);
                            this.logger.WriteLine(temp[x]);
                            this.tx_status += this.translator[temp[i]][Convert.ToInt32(temp[x])] + "\n";
                            i++;
                        }

                    }
                }
                catch (Exception ex)
                {
                    this.tx_status = ex.ToString();
                    this.comstatus.Text = "Disconnected";
                    
                }
            }
            else
            {
                var x = (ToolStripMenuItem)this.menuStrip1.Items[2];
                foreach (ToolStripMenuItem thing in x.DropDownItems)
                {
                    if (thing.Checked)
                    {
                        this.serialPort1 = new SerialPort(thing.Text, 57600);
                        this.serialPort1.Open();
                        break;
                    }

                }
                this.comstatus.ForeColor = Color.Red;
                this.comstatus.Text = "Disconnected";
            }
            if (counter > 0)
            {
                this.comstatus.Text = "Connected";
                this.comstatus.ForeColor = Color.Lime;
            }
            else
            {
                this.comstatus.ForeColor = Color.Red;
                this.comstatus.Text = "Disconnected";
            }
        }

        private void serialworker1_completed(object sender, RunWorkerCompletedEventArgs e)
        {
            // = this.tx_status;
            this.stc_box.Visible = this.stc_status;
            if (this.rf_status.Contains("RF currently 1")
                && this.rf_status.Contains("Actual RF output is ON"))
            {
                this.rf_toggle.BackColor = Color.Lime;
                this.rf_toggle.ForeColor = Color.Black;
                this.rf_toggle.Text = "RF Enabled (Software)";
                this.rf_toggle.Checked = true;
                this.rf_stat_led.Color = Color.Lime;
                this.rf_stat_led.On = true;
            }
            else if (this.rf_status.Contains("RF currently 1")
                && this.rf_status.Contains("Actual RF output is OFF"))
            {
                this.rf_toggle.BackColor = Color.Lime;
                this.rf_toggle.ForeColor = Color.Black;
                this.rf_toggle.Text = "RF Enabled (Software)";
                this.rf_toggle.Checked = true;
                this.rf_stat_led.Color = Color.FromArgb(255, 255, 128);
                this.rf_stat_led.On = true;

            }
            else if (this.rf_status.Contains("RF currently 0")
                     && this.rf_status.Contains("Actual RF output is OFF"))
            {
                this.rf_stat_led.Color = Color.Red;
                this.rf_stat_led.On = true;
                this.rf_toggle.BackColor = Color.Red;
                this.rf_toggle.ForeColor = Color.White;
                this.rf_toggle.Text = "RF Disabled (Software)";
                this.rf_toggle.Checked = false;

            }
            else
            {
                this.rf_stat_led.On = false;
            }
            if (! this.admin_panel.Visible)
            {
                try
                {
                    this.lowpwr.Value = this.lp_stat_str;
                    this.highpwr.Value = this.hp_stat_str;
                }
                catch
                {
                    this.lowpwr.Value = this.highpwr.Value = (decimal) 0.0;
                }
            }
            this.lp_status.Text = this.lp_stat_str.ToString();
            this.hp_status.Text = this.hp_stat_str.ToString();
            Single y;
            System.Globalization.NumberStyles style;
            style = NumberStyles.Float;
            System.Globalization.CultureInfo culture;
            culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            if (Single.TryParse(this.temperature, style,culture, out y) )
            {
                //float y = float.Parse(this.temperature, CultureInfo.InvariantCulture.NumberFormat);

                if (y < 70)
                {
                    this.te_status.ForeColor = Color.Lime;
                }
                else if (y < 80)
                {
                    this.te_status.ForeColor = Color.Yellow;
                }
                else
                {
                    this.rf_toggle.BackColor = Color.Red;
                    this.rf_toggle.ForeColor = Color.White;
                    this.rf_toggle.Text = "RF Disabled (Software)";
                    this.te_status.ForeColor = Color.Red;
                    this.run_worker2("RF 0\r");
                }
            }
            this.freq_status.Text = this.frequency;
            if (this.temperature != "")
                this.te_status.Text = this.temperature + " °C";
            this.logger.Write(System.DateTime.Now.ToString() + ": " + this.tx_status + "\r\n");
        }

        private void passwd_click(object sender, EventArgs e)
        {
            if (this.passwdbox.textBox1.Text == "globalex")
            {
                this.Height = 475;
                this.freq_select.Height = 86;
                this.admin_panel.Visible = true;
                this.passwdbox.textBox1.Text = "";
                this.passwdbox.Visible = false;
                this.passwdbox.Opacity = 0;
                this.freq_delete.Visible = true;
            }
        }
        private void passwd_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.passwdbox.button1.PerformClick();
            }
        }
        private void lowpwr_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string powlvl = this.lowpwr.Value.ToString();
                string cmnd = "LP " + powlvl + "\r";
                this.run_worker2(cmnd);
            }
        }
        private void highpwr_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string powlvl = this.highpwr.Value.ToString();
                string cmnd = "HP " + powlvl + "\r";
                this.run_worker2(cmnd);
            }
        }

        private void rf_toggle_CheckedChanged(object sender, EventArgs e)
        {
            string cmnd;
            if (rf_toggle.Checked)
            {
                rf_toggle.BackColor = Color.Lime;
                rf_toggle.ForeColor = Color.Black;
                rf_toggle.Text = "RF Enabled (Software)";
                cmnd = "RF 1\r";
            }
            else
            {
                rf_toggle.BackColor = Color.Red;
                rf_toggle.ForeColor = Color.White;
                rf_toggle.Text = "RF Disabled (Software)";
                cmnd = "RF 0\r";
            }
            this.run_worker2(cmnd);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex != 0)
            {
                var item = comboBox1.SelectedItem;
                string cmnd = "FR " + item.ToString() + "\r";
                this.run_worker2(cmnd);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void onExit(object sender, EventArgs e)
        {
            this.logger.Close();
            var temp = new System.IO.StreamWriter("freqs.conf");
            temp.WriteLine(String.Join(" ", this.freqs));
            temp.Close();
        }

        private void modulation_changed(object sender, EventArgs e)
        {
            string cmnd = "";
            if (this.mod1.Checked)
            {
                // = mod1.Text;
                cmnd = "MO 0\r";
            }
            else if (this.mod2.Checked)
            {
                // = mod2.Text;
                cmnd = "MO 1\r";
            }
            else if (this.mod3.Checked)
            {
                // = mod3.Text;
                cmnd = "MO 6\r";
            }
            this.run_worker2(cmnd);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.admin_panel.Visible == true)
            {
                return;
            }

            this.passwdbox.Visible = true;
            this.passwdbox.Opacity = 100;
            this.passwdbox.button1.Click += new System.EventHandler(this.passwd_click);
            this.passwdbox.textBox1.KeyDown += new KeyEventHandler(this.passwd_enter);
            this.passwdbox.Show();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 186;
            this.admin_panel.Visible = false;
            this.freq_delete.Visible = false;
            this.freq_select.Height = 46;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.comstatus.Text == "Disconnected")
            {
                this.freq_status.Text = this.te_status.Text = "";
                this.rf_stat_led.On = false;
            }
            if (this.serialPort1.IsOpen && !(this.serialworker1.IsBusy))
            {
                this.serialworker1.RunWorkerAsync();
            }
        }

        private void serialworker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string cmnd = e.Argument.ToString();
            if (cmnd != "")
            {
                try
                {
                    this.serialPort1.WriteLine(cmnd);
                    this.error_msg = "";
                }
                catch
                {
                    this.error_msg = "Error sending command to transmitter!";
                }

            }
        }
        private void serialworker2_completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this.error_msg != "")
            {
                this.textBox3.Visible = true;
            }
            else
            {
                this.textBox3.Visible = false;
            }

            this.admin_panel.Enabled = true;

            this.textBox3.Text = this.error_msg;
        }

        private void encoding_changed(object sender, EventArgs e)
        {
            string cmnd = "";
            if (this.enc1.Checked)
            {
                cmnd = "DE 0\r";
            }
            else if (this.enc2.Checked)
            {
                cmnd = "DE 1\r";
            }
            this.run_worker2(cmnd);

        }

        private void run_worker2(string cmnd)
        {
            this.admin_panel.Enabled = false;
            BackgroundWorker serialworker = new BackgroundWorker();
            serialworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.serialworker2_DoWork);
            serialworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.serialworker2_completed);
            serialworker.RunWorkerAsync(cmnd);
        }
        private void randomizer_changed(object sender, EventArgs e)
        {
            string cmnd = "";
            if (this.rand1.Checked)
            {
                cmnd = "RA 0\r";
            }
            else if (this.rand2.Checked)
            {
                cmnd = "RA 1\r";
            }
            this.run_worker2(cmnd);
        }

        private void polarity_changed(object sender, EventArgs e)
        {
            string cmnd = "";
            if (this.dp1.Checked)
            {
                cmnd = "DP 0\r";
            }
            else if (this.dp2.Checked)
            {
                cmnd = "DP 1\r";
            }
            this.run_worker2(cmnd);
        }

        private void stc_encoding_changed(object sender, EventArgs e)
        {
            string cmnd = "";
            if (this.stc1.Checked)
            {
                cmnd = "SE 0\r";
            }
            else if (this.stc2.Checked)
            {
                cmnd = "SE 1\r";
            }
            this.run_worker2(cmnd);
        }

        private void data_source_changed(object sender, EventArgs e)
        {
            string cmnd = "";
            if (this.ds1.Checked)
            {
                cmnd = "DS 0\r";
            }
            else if (this.ds2.Checked)
            {
                cmnd = "DS 1\r";
            }
            this.run_worker2(cmnd);
        }

        private void clock_source_changed(object sender, EventArgs e)
        {
            string cmnd = "";
            if (this.cs1.Checked)
            {
                cmnd = "CS 0\r";
            }
            else if (this.cs2.Checked)
            {
                cmnd = "CS 1\r";
            }
            this.run_worker2(cmnd);
        }

        private void freq_changed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string temp = this.numericUpDown3.Value.ToString();
                if (!freqs.Contains(temp))
                {
                    this.comboBox1.Items.Add(temp);
                    this.freqs.Add(this.numericUpDown3.Value.ToString());
                    this.comboBox1.SelectedIndex = this.freqs.Count;
                    string cmnd = "FR " + temp + "\r";
                    this.run_worker2(cmnd);
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cmnd = "PW\r";
            this.run_worker2(cmnd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex > 0)
            {
                var temp = this.comboBox1.Items[this.comboBox1.SelectedIndex];
                this.comboBox1.Items.Remove(this.comboBox1.Items[this.comboBox1.SelectedIndex]);
                this.freqs.Remove(temp.ToString());
            }
        }

        private void lp_button_Click(object sender, EventArgs e)
        {
            string powlvl = this.lowpwr.Value.ToString();
            string cmnd = "LP " + powlvl + "\r";
            this.run_worker2(cmnd);
        }

        private void hp_button_Click(object sender, EventArgs e)
        {
            string powlvl = this.highpwr.Value.ToString();
            string cmnd = "HP " + powlvl + "\r";
            this.run_worker2(cmnd);
        }

        private void freq_add_button_Click(object sender, EventArgs e)
        {
            string temp = this.numericUpDown3.Value.ToString();
            if (!freqs.Contains(temp))
            {
                this.comboBox1.Items.Add(temp);
                this.freqs.Add(this.numericUpDown3.Value.ToString());
                this.comboBox1.SelectedIndex = this.freqs.Count;
                string cmnd = "FR " + temp + "\r";
                this.run_worker2(cmnd);
            }
        }

        private void dontclosepasswdbox(object sender, FormClosingEventArgs e)
        {

        }
    }
}
