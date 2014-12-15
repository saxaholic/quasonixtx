namespace Quasonix_TX_controller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialworker1 = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.freq_select = new System.Windows.Forms.GroupBox();
            this.freq_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rf_toggle = new System.Windows.Forms.CheckBox();
            this.admin_panel = new System.Windows.Forms.GroupBox();
            this.freq_add = new System.Windows.Forms.GroupBox();
            this.freq_add_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.hp_button = new System.Windows.Forms.Button();
            this.lp_button = new System.Windows.Forms.Button();
            this.hp_status = new System.Windows.Forms.TextBox();
            this.lp_status = new System.Windows.Forms.TextBox();
            this.highpwr = new System.Windows.Forms.NumericUpDown();
            this.lowpwr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cs_int_led = new Bulb.LedBulb();
            this.cs_ext_led = new Bulb.LedBulb();
            this.cs1 = new System.Windows.Forms.RadioButton();
            this.cs2 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ds_int_led = new Bulb.LedBulb();
            this.ds1 = new System.Windows.Forms.RadioButton();
            this.ds_ext_led = new Bulb.LedBulb();
            this.ds2 = new System.Windows.Forms.RadioButton();
            this.stc_box = new System.Windows.Forms.GroupBox();
            this.stc_on_led = new Bulb.LedBulb();
            this.stc1 = new System.Windows.Forms.RadioButton();
            this.stc_off_led = new Bulb.LedBulb();
            this.stc2 = new System.Windows.Forms.RadioButton();
            this.polarity = new System.Windows.Forms.GroupBox();
            this.dp_inv_led = new Bulb.LedBulb();
            this.dp1 = new System.Windows.Forms.RadioButton();
            this.dp_norm_led = new Bulb.LedBulb();
            this.dp2 = new System.Windows.Forms.RadioButton();
            this.randomizer = new System.Windows.Forms.GroupBox();
            this.rnz_en_led = new Bulb.LedBulb();
            this.rand1 = new System.Windows.Forms.RadioButton();
            this.rnz_dis_led = new Bulb.LedBulb();
            this.rand2 = new System.Windows.Forms.RadioButton();
            this.encoding = new System.Windows.Forms.GroupBox();
            this.enc_diff_led = new Bulb.LedBulb();
            this.enc1 = new System.Windows.Forms.RadioButton();
            this.enc_norm_led = new Bulb.LedBulb();
            this.enc2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.carrier_led = new Bulb.LedBulb();
            this.soqpsk_led = new Bulb.LedBulb();
            this.pcmfm_led = new Bulb.LedBulb();
            this.mod1 = new System.Windows.Forms.RadioButton();
            this.mod3 = new System.Windows.Forms.RadioButton();
            this.mod2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comstatus = new System.Windows.Forms.TextBox();
            this.RF_status_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.te_status = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.freq_status = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rf_stat_led = new Bulb.LedBulb();
            this.passwdbox = new Quasonix_TX_controller.passwd();
            this.freq_select.SuspendLayout();
            this.admin_panel.SuspendLayout();
            this.freq_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highpwr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowpwr)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.stc_box.SuspendLayout();
            this.polarity.SuspendLayout();
            this.randomizer.SuspendLayout();
            this.encoding.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialworker1
            // 
            this.serialworker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.serialworker1_DoWork);
            this.serialworker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.serialworker1_completed);
            // 
            // freq_select
            // 
            this.freq_select.Controls.Add(this.freq_delete);
            this.freq_select.Controls.Add(this.label4);
            this.freq_select.Controls.Add(this.comboBox1);
            this.freq_select.Location = new System.Drawing.Point(439, 75);
            this.freq_select.Name = "freq_select";
            this.freq_select.Size = new System.Drawing.Size(156, 46);
            this.freq_select.TabIndex = 1;
            this.freq_select.TabStop = false;
            this.freq_select.Text = "Frequency Preset Select";
            // 
            // freq_delete
            // 
            this.freq_delete.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freq_delete.Location = new System.Drawing.Point(7, 46);
            this.freq_delete.Name = "freq_delete";
            this.freq_delete.Size = new System.Drawing.Size(130, 36);
            this.freq_delete.TabIndex = 11;
            this.freq_delete.TabStop = false;
            this.freq_delete.Text = "Delete Selected Frequency Preset";
            this.freq_delete.UseVisualStyleBackColor = true;
            this.freq_delete.Visible = false;
            this.freq_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MHz";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select Frequency"});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rf_toggle
            // 
            this.rf_toggle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rf_toggle.BackColor = System.Drawing.Color.Red;
            this.rf_toggle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rf_toggle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rf_toggle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rf_toggle.ForeColor = System.Drawing.Color.White;
            this.rf_toggle.Location = new System.Drawing.Point(60, 16);
            this.rf_toggle.Name = "rf_toggle";
            this.rf_toggle.Size = new System.Drawing.Size(93, 40);
            this.rf_toggle.TabIndex = 2;
            this.rf_toggle.Text = "RF Disabled (Software)";
            this.rf_toggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rf_toggle.UseVisualStyleBackColor = false;
            this.rf_toggle.Click += new System.EventHandler(this.rf_toggle_CheckedChanged);
            // 
            // admin_panel
            // 
            this.admin_panel.Controls.Add(this.freq_add);
            this.admin_panel.Controls.Add(this.groupBox6);
            this.admin_panel.Controls.Add(this.groupBox5);
            this.admin_panel.Controls.Add(this.groupBox4);
            this.admin_panel.Controls.Add(this.stc_box);
            this.admin_panel.Controls.Add(this.polarity);
            this.admin_panel.Controls.Add(this.randomizer);
            this.admin_panel.Controls.Add(this.encoding);
            this.admin_panel.Controls.Add(this.groupBox2);
            this.admin_panel.Location = new System.Drawing.Point(12, 163);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(599, 255);
            this.admin_panel.TabIndex = 3;
            this.admin_panel.TabStop = false;
            this.admin_panel.Text = "Admin Panel";
            this.admin_panel.Visible = false;
            // 
            // freq_add
            // 
            this.freq_add.Controls.Add(this.freq_add_button);
            this.freq_add.Controls.Add(this.label3);
            this.freq_add.Controls.Add(this.numericUpDown3);
            this.freq_add.Location = new System.Drawing.Point(450, 115);
            this.freq_add.Name = "freq_add";
            this.freq_add.Size = new System.Drawing.Size(139, 77);
            this.freq_add.TabIndex = 10;
            this.freq_add.TabStop = false;
            this.freq_add.Text = "Add Frequency Preset";
            // 
            // freq_add_button
            // 
            this.freq_add_button.Location = new System.Drawing.Point(34, 46);
            this.freq_add_button.Name = "freq_add_button";
            this.freq_add_button.Size = new System.Drawing.Size(75, 23);
            this.freq_add_button.TabIndex = 2;
            this.freq_add_button.Text = "Add";
            this.freq_add_button.UseVisualStyleBackColor = true;
            this.freq_add_button.Click += new System.EventHandler(this.freq_add_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "MHz";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 1;
            this.numericUpDown3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown3.Location = new System.Drawing.Point(26, 20);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown3.TabIndex = 0;
            this.numericUpDown3.Value = new decimal(new int[] {
            23855,
            0,
            0,
            65536});
            this.numericUpDown3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.freq_changed);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.hp_button);
            this.groupBox6.Controls.Add(this.lp_button);
            this.groupBox6.Controls.Add(this.hp_status);
            this.groupBox6.Controls.Add(this.lp_status);
            this.groupBox6.Controls.Add(this.highpwr);
            this.groupBox6.Controls.Add(this.lowpwr);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(279, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(163, 134);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Power Levels";
            // 
            // hp_button
            // 
            this.hp_button.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp_button.Location = new System.Drawing.Point(40, 106);
            this.hp_button.Name = "hp_button";
            this.hp_button.Size = new System.Drawing.Size(77, 22);
            this.hp_button.TabIndex = 20;
            this.hp_button.Text = "Apply";
            this.hp_button.UseVisualStyleBackColor = true;
            this.hp_button.Click += new System.EventHandler(this.hp_button_Click);
            // 
            // lp_button
            // 
            this.lp_button.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp_button.Location = new System.Drawing.Point(42, 44);
            this.lp_button.Name = "lp_button";
            this.lp_button.Size = new System.Drawing.Size(75, 22);
            this.lp_button.TabIndex = 19;
            this.lp_button.Text = "Apply";
            this.lp_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lp_button.UseVisualStyleBackColor = true;
            this.lp_button.Click += new System.EventHandler(this.lp_button_Click);
            // 
            // hp_status
            // 
            this.hp_status.BackColor = System.Drawing.Color.Black;
            this.hp_status.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp_status.ForeColor = System.Drawing.Color.Lime;
            this.hp_status.Location = new System.Drawing.Point(101, 79);
            this.hp_status.Name = "hp_status";
            this.hp_status.ReadOnly = true;
            this.hp_status.Size = new System.Drawing.Size(46, 20);
            this.hp_status.TabIndex = 18;
            this.hp_status.TabStop = false;
            this.hp_status.Text = "0.0";
            this.hp_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lp_status
            // 
            this.lp_status.BackColor = System.Drawing.Color.Black;
            this.lp_status.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp_status.ForeColor = System.Drawing.Color.Lime;
            this.lp_status.Location = new System.Drawing.Point(103, 18);
            this.lp_status.Name = "lp_status";
            this.lp_status.ReadOnly = true;
            this.lp_status.Size = new System.Drawing.Size(46, 20);
            this.lp_status.TabIndex = 17;
            this.lp_status.TabStop = false;
            this.lp_status.Text = "0.0";
            this.lp_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // highpwr
            // 
            this.highpwr.DecimalPlaces = 1;
            this.highpwr.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.highpwr.Location = new System.Drawing.Point(40, 80);
            this.highpwr.Maximum = new decimal(new int[] {
            315,
            0,
            0,
            65536});
            this.highpwr.Name = "highpwr";
            this.highpwr.Size = new System.Drawing.Size(49, 20);
            this.highpwr.TabIndex = 3;
            this.highpwr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.highpwr_enter);
            // 
            // lowpwr
            // 
            this.lowpwr.DecimalPlaces = 1;
            this.lowpwr.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.lowpwr.Location = new System.Drawing.Point(42, 18);
            this.lowpwr.Maximum = new decimal(new int[] {
            315,
            0,
            0,
            65536});
            this.lowpwr.Name = "lowpwr";
            this.lowpwr.Size = new System.Drawing.Size(49, 20);
            this.lowpwr.TabIndex = 2;
            this.lowpwr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lowpwr_enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "High";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cs_int_led);
            this.groupBox5.Controls.Add(this.cs_ext_led);
            this.groupBox5.Controls.Add(this.cs1);
            this.groupBox5.Controls.Add(this.cs2);
            this.groupBox5.Location = new System.Drawing.Point(135, 115);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(105, 69);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Clock Source";
            // 
            // cs_int_led
            // 
            this.cs_int_led.Location = new System.Drawing.Point(80, 42);
            this.cs_int_led.Name = "cs_int_led";
            this.cs_int_led.On = false;
            this.cs_int_led.Size = new System.Drawing.Size(19, 17);
            this.cs_int_led.TabIndex = 17;
            this.cs_int_led.Text = "cs_int_led";
            // 
            // cs_ext_led
            // 
            this.cs_ext_led.Location = new System.Drawing.Point(80, 19);
            this.cs_ext_led.Name = "cs_ext_led";
            this.cs_ext_led.On = false;
            this.cs_ext_led.Size = new System.Drawing.Size(19, 17);
            this.cs_ext_led.TabIndex = 16;
            this.cs_ext_led.Text = "cs_ext_led";
            // 
            // cs1
            // 
            this.cs1.AutoSize = true;
            this.cs1.Location = new System.Drawing.Point(6, 19);
            this.cs1.Name = "cs1";
            this.cs1.Size = new System.Drawing.Size(63, 17);
            this.cs1.TabIndex = 0;
            this.cs1.TabStop = true;
            this.cs1.Text = "External";
            this.cs1.UseVisualStyleBackColor = true;
            this.cs1.CheckedChanged += new System.EventHandler(this.clock_source_changed);
            // 
            // cs2
            // 
            this.cs2.AutoSize = true;
            this.cs2.Location = new System.Drawing.Point(6, 42);
            this.cs2.Name = "cs2";
            this.cs2.Size = new System.Drawing.Size(60, 17);
            this.cs2.TabIndex = 1;
            this.cs2.TabStop = true;
            this.cs2.Text = "Internal";
            this.cs2.UseVisualStyleBackColor = true;
            this.cs2.CheckedChanged += new System.EventHandler(this.clock_source_changed);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ds_int_led);
            this.groupBox4.Controls.Add(this.ds1);
            this.groupBox4.Controls.Add(this.ds_ext_led);
            this.groupBox4.Controls.Add(this.ds2);
            this.groupBox4.Location = new System.Drawing.Point(6, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 69);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Source";
            // 
            // ds_int_led
            // 
            this.ds_int_led.Location = new System.Drawing.Point(98, 42);
            this.ds_int_led.Name = "ds_int_led";
            this.ds_int_led.On = false;
            this.ds_int_led.Size = new System.Drawing.Size(19, 17);
            this.ds_int_led.TabIndex = 17;
            this.ds_int_led.Text = "ds_int_led";
            // 
            // ds1
            // 
            this.ds1.AutoSize = true;
            this.ds1.Location = new System.Drawing.Point(6, 19);
            this.ds1.Name = "ds1";
            this.ds1.Size = new System.Drawing.Size(63, 17);
            this.ds1.TabIndex = 0;
            this.ds1.TabStop = true;
            this.ds1.Text = "External";
            this.ds1.UseVisualStyleBackColor = true;
            this.ds1.CheckedChanged += new System.EventHandler(this.data_source_changed);
            // 
            // ds_ext_led
            // 
            this.ds_ext_led.Location = new System.Drawing.Point(98, 19);
            this.ds_ext_led.Name = "ds_ext_led";
            this.ds_ext_led.On = false;
            this.ds_ext_led.Size = new System.Drawing.Size(19, 17);
            this.ds_ext_led.TabIndex = 16;
            this.ds_ext_led.Text = "ds_ext_led";
            // 
            // ds2
            // 
            this.ds2.AutoSize = true;
            this.ds2.Location = new System.Drawing.Point(6, 42);
            this.ds2.Name = "ds2";
            this.ds2.Size = new System.Drawing.Size(60, 17);
            this.ds2.TabIndex = 1;
            this.ds2.TabStop = true;
            this.ds2.Text = "Internal";
            this.ds2.UseVisualStyleBackColor = true;
            this.ds2.CheckedChanged += new System.EventHandler(this.data_source_changed);
            // 
            // stc_box
            // 
            this.stc_box.Controls.Add(this.stc_on_led);
            this.stc_box.Controls.Add(this.stc1);
            this.stc_box.Controls.Add(this.stc_off_led);
            this.stc_box.Controls.Add(this.stc2);
            this.stc_box.Location = new System.Drawing.Point(497, 32);
            this.stc_box.Name = "stc_box";
            this.stc_box.Size = new System.Drawing.Size(92, 69);
            this.stc_box.TabIndex = 5;
            this.stc_box.TabStop = false;
            this.stc_box.Text = "STC Encoding";
            this.stc_box.Visible = false;
            // 
            // stc_on_led
            // 
            this.stc_on_led.Location = new System.Drawing.Point(67, 42);
            this.stc_on_led.Name = "stc_on_led";
            this.stc_on_led.On = false;
            this.stc_on_led.Size = new System.Drawing.Size(19, 17);
            this.stc_on_led.TabIndex = 13;
            this.stc_on_led.Text = "stc_on_led";
            // 
            // stc1
            // 
            this.stc1.AutoSize = true;
            this.stc1.Location = new System.Drawing.Point(6, 19);
            this.stc1.Name = "stc1";
            this.stc1.Size = new System.Drawing.Size(39, 17);
            this.stc1.TabIndex = 0;
            this.stc1.TabStop = true;
            this.stc1.Text = "Off";
            this.stc1.UseVisualStyleBackColor = true;
            this.stc1.CheckedChanged += new System.EventHandler(this.stc_encoding_changed);
            // 
            // stc_off_led
            // 
            this.stc_off_led.Location = new System.Drawing.Point(67, 19);
            this.stc_off_led.Name = "stc_off_led";
            this.stc_off_led.On = false;
            this.stc_off_led.Size = new System.Drawing.Size(19, 17);
            this.stc_off_led.TabIndex = 12;
            this.stc_off_led.Text = "stc_off_led";
            // 
            // stc2
            // 
            this.stc2.AutoSize = true;
            this.stc2.Location = new System.Drawing.Point(6, 42);
            this.stc2.Name = "stc2";
            this.stc2.Size = new System.Drawing.Size(39, 17);
            this.stc2.TabIndex = 1;
            this.stc2.TabStop = true;
            this.stc2.Text = "On";
            this.stc2.UseVisualStyleBackColor = true;
            this.stc2.CheckedChanged += new System.EventHandler(this.stc_encoding_changed);
            // 
            // polarity
            // 
            this.polarity.Controls.Add(this.dp_inv_led);
            this.polarity.Controls.Add(this.dp1);
            this.polarity.Controls.Add(this.dp_norm_led);
            this.polarity.Controls.Add(this.dp2);
            this.polarity.Location = new System.Drawing.Point(376, 32);
            this.polarity.Name = "polarity";
            this.polarity.Size = new System.Drawing.Size(115, 69);
            this.polarity.TabIndex = 6;
            this.polarity.TabStop = false;
            this.polarity.Text = "Data Polarity";
            // 
            // dp_inv_led
            // 
            this.dp_inv_led.Location = new System.Drawing.Point(90, 42);
            this.dp_inv_led.Name = "dp_inv_led";
            this.dp_inv_led.On = false;
            this.dp_inv_led.Size = new System.Drawing.Size(19, 17);
            this.dp_inv_led.TabIndex = 11;
            this.dp_inv_led.Text = "dp_inv_led";
            // 
            // dp1
            // 
            this.dp1.AutoSize = true;
            this.dp1.Location = new System.Drawing.Point(6, 19);
            this.dp1.Name = "dp1";
            this.dp1.Size = new System.Drawing.Size(58, 17);
            this.dp1.TabIndex = 0;
            this.dp1.TabStop = true;
            this.dp1.Text = "Normal";
            this.dp1.UseVisualStyleBackColor = true;
            this.dp1.CheckedChanged += new System.EventHandler(this.polarity_changed);
            // 
            // dp_norm_led
            // 
            this.dp_norm_led.Location = new System.Drawing.Point(90, 19);
            this.dp_norm_led.Name = "dp_norm_led";
            this.dp_norm_led.On = false;
            this.dp_norm_led.Size = new System.Drawing.Size(19, 17);
            this.dp_norm_led.TabIndex = 10;
            this.dp_norm_led.Text = "dp_norm_led";
            // 
            // dp2
            // 
            this.dp2.AutoSize = true;
            this.dp2.Location = new System.Drawing.Point(6, 42);
            this.dp2.Name = "dp2";
            this.dp2.Size = new System.Drawing.Size(64, 17);
            this.dp2.TabIndex = 1;
            this.dp2.TabStop = true;
            this.dp2.Text = "Inverted";
            this.dp2.UseVisualStyleBackColor = true;
            this.dp2.CheckedChanged += new System.EventHandler(this.polarity_changed);
            // 
            // randomizer
            // 
            this.randomizer.Controls.Add(this.rnz_en_led);
            this.randomizer.Controls.Add(this.rand1);
            this.randomizer.Controls.Add(this.rnz_dis_led);
            this.randomizer.Controls.Add(this.rand2);
            this.randomizer.Location = new System.Drawing.Point(252, 32);
            this.randomizer.Name = "randomizer";
            this.randomizer.Size = new System.Drawing.Size(118, 69);
            this.randomizer.TabIndex = 5;
            this.randomizer.TabStop = false;
            this.randomizer.Text = "Randomizer";
            // 
            // rnz_en_led
            // 
            this.rnz_en_led.Location = new System.Drawing.Point(93, 42);
            this.rnz_en_led.Name = "rnz_en_led";
            this.rnz_en_led.On = false;
            this.rnz_en_led.Size = new System.Drawing.Size(19, 17);
            this.rnz_en_led.TabIndex = 9;
            this.rnz_en_led.Text = "rnz_en_led";
            // 
            // rand1
            // 
            this.rand1.AutoSize = true;
            this.rand1.Location = new System.Drawing.Point(6, 19);
            this.rand1.Name = "rand1";
            this.rand1.Size = new System.Drawing.Size(66, 17);
            this.rand1.TabIndex = 0;
            this.rand1.TabStop = true;
            this.rand1.Text = "Disabled";
            this.rand1.UseVisualStyleBackColor = true;
            this.rand1.CheckedChanged += new System.EventHandler(this.randomizer_changed);
            // 
            // rnz_dis_led
            // 
            this.rnz_dis_led.Location = new System.Drawing.Point(93, 19);
            this.rnz_dis_led.Name = "rnz_dis_led";
            this.rnz_dis_led.On = false;
            this.rnz_dis_led.Size = new System.Drawing.Size(19, 17);
            this.rnz_dis_led.TabIndex = 8;
            this.rnz_dis_led.Text = "rnz_dis_led";
            // 
            // rand2
            // 
            this.rand2.AutoSize = true;
            this.rand2.Location = new System.Drawing.Point(6, 42);
            this.rand2.Name = "rand2";
            this.rand2.Size = new System.Drawing.Size(64, 17);
            this.rand2.TabIndex = 1;
            this.rand2.TabStop = true;
            this.rand2.Text = "Enabled";
            this.rand2.UseVisualStyleBackColor = true;
            this.rand2.CheckedChanged += new System.EventHandler(this.randomizer_changed);
            // 
            // encoding
            // 
            this.encoding.Controls.Add(this.enc_diff_led);
            this.encoding.Controls.Add(this.enc1);
            this.encoding.Controls.Add(this.enc_norm_led);
            this.encoding.Controls.Add(this.enc2);
            this.encoding.Location = new System.Drawing.Point(135, 32);
            this.encoding.Name = "encoding";
            this.encoding.Size = new System.Drawing.Size(111, 69);
            this.encoding.TabIndex = 4;
            this.encoding.TabStop = false;
            this.encoding.Text = "Encoding";
            // 
            // enc_diff_led
            // 
            this.enc_diff_led.Location = new System.Drawing.Point(86, 42);
            this.enc_diff_led.Name = "enc_diff_led";
            this.enc_diff_led.On = false;
            this.enc_diff_led.Size = new System.Drawing.Size(19, 17);
            this.enc_diff_led.TabIndex = 7;
            this.enc_diff_led.Text = "enc_diff_led";
            // 
            // enc1
            // 
            this.enc1.AutoSize = true;
            this.enc1.Location = new System.Drawing.Point(6, 19);
            this.enc1.Name = "enc1";
            this.enc1.Size = new System.Drawing.Size(58, 17);
            this.enc1.TabIndex = 0;
            this.enc1.TabStop = true;
            this.enc1.Text = "Normal";
            this.enc1.UseVisualStyleBackColor = true;
            this.enc1.CheckedChanged += new System.EventHandler(this.encoding_changed);
            // 
            // enc_norm_led
            // 
            this.enc_norm_led.Location = new System.Drawing.Point(86, 19);
            this.enc_norm_led.Name = "enc_norm_led";
            this.enc_norm_led.On = false;
            this.enc_norm_led.Size = new System.Drawing.Size(19, 17);
            this.enc_norm_led.TabIndex = 6;
            this.enc_norm_led.Text = "enc_norm_led";
            // 
            // enc2
            // 
            this.enc2.AutoSize = true;
            this.enc2.Location = new System.Drawing.Point(6, 42);
            this.enc2.Name = "enc2";
            this.enc2.Size = new System.Drawing.Size(75, 17);
            this.enc2.TabIndex = 1;
            this.enc2.TabStop = true;
            this.enc2.Text = "Differential";
            this.enc2.UseVisualStyleBackColor = true;
            this.enc2.CheckedChanged += new System.EventHandler(this.encoding_changed);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.carrier_led);
            this.groupBox2.Controls.Add(this.soqpsk_led);
            this.groupBox2.Controls.Add(this.pcmfm_led);
            this.groupBox2.Controls.Add(this.mod1);
            this.groupBox2.Controls.Add(this.mod3);
            this.groupBox2.Controls.Add(this.mod2);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modulation";
            // 
            // carrier_led
            // 
            this.carrier_led.Location = new System.Drawing.Point(98, 65);
            this.carrier_led.Name = "carrier_led";
            this.carrier_led.On = false;
            this.carrier_led.Size = new System.Drawing.Size(19, 17);
            this.carrier_led.TabIndex = 5;
            this.carrier_led.Text = "ledBulb3";
            // 
            // soqpsk_led
            // 
            this.soqpsk_led.Location = new System.Drawing.Point(98, 42);
            this.soqpsk_led.Name = "soqpsk_led";
            this.soqpsk_led.On = false;
            this.soqpsk_led.Size = new System.Drawing.Size(19, 17);
            this.soqpsk_led.TabIndex = 4;
            this.soqpsk_led.Text = "ledBulb2";
            // 
            // pcmfm_led
            // 
            this.pcmfm_led.Location = new System.Drawing.Point(98, 19);
            this.pcmfm_led.Name = "pcmfm_led";
            this.pcmfm_led.On = false;
            this.pcmfm_led.Size = new System.Drawing.Size(19, 17);
            this.pcmfm_led.TabIndex = 3;
            this.pcmfm_led.Text = "ledBulb1";
            // 
            // mod1
            // 
            this.mod1.AutoSize = true;
            this.mod1.Location = new System.Drawing.Point(6, 19);
            this.mod1.Name = "mod1";
            this.mod1.Size = new System.Drawing.Size(66, 17);
            this.mod1.TabIndex = 0;
            this.mod1.TabStop = true;
            this.mod1.Text = "PCM-FM";
            this.mod1.UseVisualStyleBackColor = true;
            this.mod1.CheckedChanged += new System.EventHandler(this.modulation_changed);
            // 
            // mod3
            // 
            this.mod3.AutoSize = true;
            this.mod3.Location = new System.Drawing.Point(6, 65);
            this.mod3.Name = "mod3";
            this.mod3.Size = new System.Drawing.Size(73, 17);
            this.mod3.TabIndex = 2;
            this.mod3.TabStop = true;
            this.mod3.Text = "CARRIER";
            this.mod3.UseVisualStyleBackColor = true;
            this.mod3.CheckedChanged += new System.EventHandler(this.modulation_changed);
            // 
            // mod2
            // 
            this.mod2.AutoSize = true;
            this.mod2.Location = new System.Drawing.Point(6, 42);
            this.mod2.Name = "mod2";
            this.mod2.Size = new System.Drawing.Size(69, 17);
            this.mod2.TabIndex = 1;
            this.mod2.TabStop = true;
            this.mod2.Text = "SOQPSK";
            this.mod2.UseVisualStyleBackColor = true;
            this.mod2.CheckedChanged += new System.EventHandler(this.modulation_changed);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save transmitter\'s current settings as power-on defaults.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(22, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(87, 29);
            this.textBox2.TabIndex = 6;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "XXX";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Red;
            this.textBox3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Yellow;
            this.textBox3.Location = new System.Drawing.Point(97, 424);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(427, 29);
            this.textBox3.TabIndex = 7;
            this.textBox3.TabStop = false;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current COM Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Connection Status";
            // 
            // comstatus
            // 
            this.comstatus.BackColor = System.Drawing.Color.Black;
            this.comstatus.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comstatus.ForeColor = System.Drawing.Color.Red;
            this.comstatus.Location = new System.Drawing.Point(125, 40);
            this.comstatus.Name = "comstatus";
            this.comstatus.ReadOnly = true;
            this.comstatus.Size = new System.Drawing.Size(155, 29);
            this.comstatus.TabIndex = 11;
            this.comstatus.TabStop = false;
            this.comstatus.Text = "Disconnected";
            this.comstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RF_status_tooltip
            // 
            this.RF_status_tooltip.AutomaticDelay = 100;
            this.RF_status_tooltip.AutoPopDelay = 5000;
            this.RF_status_tooltip.InitialDelay = 100;
            this.RF_status_tooltip.ReshowDelay = 20;
            // 
            // te_status
            // 
            this.te_status.BackColor = System.Drawing.Color.Black;
            this.te_status.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.te_status.ForeColor = System.Drawing.Color.Lime;
            this.te_status.Location = new System.Drawing.Point(296, 40);
            this.te_status.Name = "te_status";
            this.te_status.ReadOnly = true;
            this.te_status.Size = new System.Drawing.Size(107, 29);
            this.te_status.TabIndex = 12;
            this.te_status.TabStop = false;
            this.te_status.Text = "XX.X °C";
            this.te_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Temperature";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Frequency";
            // 
            // freq_status
            // 
            this.freq_status.BackColor = System.Drawing.Color.Black;
            this.freq_status.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freq_status.ForeColor = System.Drawing.Color.Lime;
            this.freq_status.Location = new System.Drawing.Point(439, 40);
            this.freq_status.Name = "freq_status";
            this.freq_status.ReadOnly = true;
            this.freq_status.Size = new System.Drawing.Size(137, 29);
            this.freq_status.TabIndex = 14;
            this.freq_status.TabStop = false;
            this.freq_status.Text = "XXXX.X MHz";
            this.freq_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rf_stat_led);
            this.groupBox7.Controls.Add(this.rf_toggle);
            this.groupBox7.Location = new System.Drawing.Point(264, 75);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 62);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "RF Status";
            // 
            // rf_stat_led
            // 
            this.rf_stat_led.Color = System.Drawing.Color.Red;
            this.rf_stat_led.Location = new System.Drawing.Point(6, 16);
            this.rf_stat_led.Name = "rf_stat_led";
            this.rf_stat_led.On = false;
            this.rf_stat_led.Size = new System.Drawing.Size(40, 40);
            this.rf_stat_led.TabIndex = 6;
            this.rf_stat_led.Text = "rf_stat_led";
            // 
            // passwdbox
            // 
            this.passwdbox.ClientSize = new System.Drawing.Size(276, 73);
            this.passwdbox.Icon = ((System.Drawing.Icon)(resources.GetObject("passwdbox.Icon")));
            this.passwdbox.Location = new System.Drawing.Point(233, 233);
            this.passwdbox.MaximizeBox = false;
            this.passwdbox.MaximumSize = new System.Drawing.Size(292, 111);
            this.passwdbox.MinimizeBox = false;
            this.passwdbox.MinimumSize = new System.Drawing.Size(292, 111);
            this.passwdbox.Name = "passwdbox";
            this.passwdbox.Opacity = 0D;
            this.passwdbox.ShowInTaskbar = false;
            this.passwdbox.Text = "Enter Password";
            this.passwdbox.TopMost = true;
            this.passwdbox.Visible = false;
            this.passwdbox.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dontclosepasswdbox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 148);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.freq_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.te_status);
            this.Controls.Add(this.comstatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.freq_select);
            this.Controls.Add(this.admin_panel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(941, 503);
            this.Name = "Form1";
            this.Text = "Quasonix TX Controller";
            this.freq_select.ResumeLayout(false);
            this.freq_select.PerformLayout();
            this.admin_panel.ResumeLayout(false);
            this.freq_add.ResumeLayout(false);
            this.freq_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highpwr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowpwr)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.stc_box.ResumeLayout(false);
            this.stc_box.PerformLayout();
            this.polarity.ResumeLayout(false);
            this.polarity.PerformLayout();
            this.randomizer.ResumeLayout(false);
            this.randomizer.PerformLayout();
            this.encoding.ResumeLayout(false);
            this.encoding.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Collections.Generic.Dictionary<string, string> command_names;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, string>> translator;
        private System.ComponentModel.BackgroundWorker serialworker1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox freq_select;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox rf_toggle;
        private System.Windows.Forms.GroupBox admin_panel;
        private System.Windows.Forms.RadioButton mod1;
        private System.Windows.Forms.RadioButton mod2;
        private System.Windows.Forms.RadioButton mod3;
        private System.Windows.Forms.GroupBox polarity;
        private System.Windows.Forms.RadioButton dp1;
        private System.Windows.Forms.RadioButton dp2;
        private System.IO.StreamWriter logger;
        private System.Windows.Forms.GroupBox randomizer;
        private System.Windows.Forms.RadioButton rand1;
        private System.Windows.Forms.RadioButton rand2;
        private System.Windows.Forms.GroupBox encoding;
        private System.Windows.Forms.RadioButton enc1;
        private System.Windows.Forms.RadioButton enc2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox freq_add;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown highpwr;
        private System.Windows.Forms.NumericUpDown lowpwr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton cs1;
        private System.Windows.Forms.RadioButton cs2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton ds1;
        private System.Windows.Forms.RadioButton ds2;
        private System.Windows.Forms.GroupBox stc_box;
        private System.Windows.Forms.RadioButton stc1;
        private System.Windows.Forms.RadioButton stc2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private string tx_status;
        private string rf_status;
        private decimal lp_stat_str;
        private decimal hp_stat_str;
        private string temperature;
        private string frequency;
        private string command, error_msg, com_status;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox comstatus;
        private Bulb.LedBulb carrier_led;
        private Bulb.LedBulb soqpsk_led;
        private Bulb.LedBulb pcmfm_led;
        private Bulb.LedBulb cs_int_led;
        private Bulb.LedBulb cs_ext_led;
        private Bulb.LedBulb ds_int_led;
        private Bulb.LedBulb ds_ext_led;
        private Bulb.LedBulb stc_on_led;
        private Bulb.LedBulb stc_off_led;
        private Bulb.LedBulb dp_inv_led;
        private Bulb.LedBulb dp_norm_led;
        private Bulb.LedBulb rnz_en_led;
        private Bulb.LedBulb rnz_dis_led;
        private Bulb.LedBulb enc_diff_led;
        private Bulb.LedBulb enc_norm_led;
        private Bulb.LedBulb rf_stat_led;
        private System.Windows.Forms.ToolTip RF_status_tooltip;
        private System.Windows.Forms.TextBox te_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox freq_status;
        private passwd passwdbox;
        private System.Collections.Generic.List<string> freqs;
        private System.IO.StreamReader freqfile;
        private System.Windows.Forms.Button freq_delete;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox hp_status;
        private System.Windows.Forms.TextBox lp_status;
        private bool stc_status = false;
        private System.Windows.Forms.Button freq_add_button;
        private System.Windows.Forms.Button hp_button;
        private System.Windows.Forms.Button lp_button;


    }
}

