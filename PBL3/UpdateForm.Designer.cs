namespace PBL3
{
    partial class UpdateForm
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
            this.lbText = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dpkLanding = new System.Windows.Forms.DateTimePicker();
            this.numLandingMin = new System.Windows.Forms.NumericUpDown();
            this.numTakeoffMin = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.cbbTriptype = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numLandingHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDescrip = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numTakeoffHour = new System.Windows.Forms.NumericUpDown();
            this.dpkTakeoff = new System.Windows.Forms.DateTimePicker();
            this.cbbTo = new System.Windows.Forms.ComboBox();
            this.cbbFrom = new System.Windows.Forms.ComboBox();
            this.cbbAirline = new System.Windows.Forms.ComboBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbRoundtrip = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLandingMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTakeoffMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLandingHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTakeoffHour)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbText.Location = new System.Drawing.Point(20, 4);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(220, 37);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "ADD/EDIT TEXT";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(26, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 4);
            this.panel4.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbbRoundtrip);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dpkLanding);
            this.panel2.Controls.Add(this.numLandingMin);
            this.panel2.Controls.Add(this.numTakeoffMin);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cbbStatus);
            this.panel2.Controls.Add(this.cbbTriptype);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.numLandingHour);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbDescrip);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.numTakeoffHour);
            this.panel2.Controls.Add(this.dpkTakeoff);
            this.panel2.Controls.Add(this.cbbTo);
            this.panel2.Controls.Add(this.cbbFrom);
            this.panel2.Controls.Add(this.cbbAirline);
            this.panel2.Controls.Add(this.txbID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(26, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 465);
            this.panel2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(454, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Day";
            // 
            // dpkLanding
            // 
            this.dpkLanding.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dpkLanding.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkLanding.Location = new System.Drawing.Point(518, 148);
            this.dpkLanding.Margin = new System.Windows.Forms.Padding(2);
            this.dpkLanding.Name = "dpkLanding";
            this.dpkLanding.Size = new System.Drawing.Size(248, 27);
            this.dpkLanding.TabIndex = 41;
            // 
            // numLandingMin
            // 
            this.numLandingMin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numLandingMin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLandingMin.Location = new System.Drawing.Point(608, 192);
            this.numLandingMin.Margin = new System.Windows.Forms.Padding(2);
            this.numLandingMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLandingMin.Name = "numLandingMin";
            this.numLandingMin.Size = new System.Drawing.Size(75, 27);
            this.numLandingMin.TabIndex = 40;
            // 
            // numTakeoffMin
            // 
            this.numTakeoffMin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numTakeoffMin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTakeoffMin.Location = new System.Drawing.Point(252, 197);
            this.numTakeoffMin.Margin = new System.Windows.Forms.Padding(2);
            this.numTakeoffMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTakeoffMin.Name = "numTakeoffMin";
            this.numTakeoffMin.Size = new System.Drawing.Size(75, 27);
            this.numTakeoffMin.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(436, 103);
            this.label15.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "Status";
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(518, 105);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(248, 28);
            this.cbbStatus.TabIndex = 35;
            // 
            // cbbTriptype
            // 
            this.cbbTriptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTriptype.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTriptype.FormattingEnabled = true;
            this.cbbTriptype.Location = new System.Drawing.Point(159, 105);
            this.cbbTriptype.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTriptype.Name = "cbbTriptype";
            this.cbbTriptype.Size = new System.Drawing.Size(248, 28);
            this.cbbTriptype.TabIndex = 34;
            this.cbbTriptype.SelectedIndexChanged += new System.EventHandler(this.cbbTriptype_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(53, 103);
            this.label14.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Trip Type";
            // 
            // numLandingHour
            // 
            this.numLandingHour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numLandingHour.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLandingHour.Location = new System.Drawing.Point(517, 192);
            this.numLandingHour.Margin = new System.Windows.Forms.Padding(2);
            this.numLandingHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numLandingHour.Name = "numLandingHour";
            this.numLandingHour.Size = new System.Drawing.Size(75, 27);
            this.numLandingHour.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(382, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Landing time";
            // 
            // txbDescrip
            // 
            this.txbDescrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbDescrip.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescrip.Location = new System.Drawing.Point(159, 299);
            this.txbDescrip.Margin = new System.Windows.Forms.Padding(2);
            this.txbDescrip.Multiline = true;
            this.txbDescrip.Name = "txbDescrip";
            this.txbDescrip.Size = new System.Drawing.Size(606, 106);
            this.txbDescrip.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(34, 288);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(159, 427);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 35);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numTakeoffHour
            // 
            this.numTakeoffHour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numTakeoffHour.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTakeoffHour.Location = new System.Drawing.Point(159, 197);
            this.numTakeoffHour.Margin = new System.Windows.Forms.Padding(2);
            this.numTakeoffHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numTakeoffHour.Name = "numTakeoffHour";
            this.numTakeoffHour.Size = new System.Drawing.Size(75, 27);
            this.numTakeoffHour.TabIndex = 20;
            // 
            // dpkTakeoff
            // 
            this.dpkTakeoff.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dpkTakeoff.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkTakeoff.Location = new System.Drawing.Point(159, 148);
            this.dpkTakeoff.Margin = new System.Windows.Forms.Padding(2);
            this.dpkTakeoff.Name = "dpkTakeoff";
            this.dpkTakeoff.Size = new System.Drawing.Size(248, 27);
            this.dpkTakeoff.TabIndex = 19;
            // 
            // cbbTo
            // 
            this.cbbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTo.FormattingEnabled = true;
            this.cbbTo.Location = new System.Drawing.Point(518, 58);
            this.cbbTo.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTo.Name = "cbbTo";
            this.cbbTo.Size = new System.Drawing.Size(248, 28);
            this.cbbTo.TabIndex = 18;
            // 
            // cbbFrom
            // 
            this.cbbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFrom.FormattingEnabled = true;
            this.cbbFrom.Location = new System.Drawing.Point(518, 18);
            this.cbbFrom.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFrom.Name = "cbbFrom";
            this.cbbFrom.Size = new System.Drawing.Size(248, 28);
            this.cbbFrom.TabIndex = 17;
            // 
            // cbbAirline
            // 
            this.cbbAirline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAirline.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAirline.FormattingEnabled = true;
            this.cbbAirline.Location = new System.Drawing.Point(160, 58);
            this.cbbAirline.Margin = new System.Windows.Forms.Padding(2);
            this.cbbAirline.Name = "cbbAirline";
            this.cbbAirline.Size = new System.Drawing.Size(248, 28);
            this.cbbAirline.TabIndex = 16;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.ForeColor = System.Drawing.Color.Black;
            this.txbID.Location = new System.Drawing.Point(160, 16);
            this.txbID.Margin = new System.Windows.Forms.Padding(2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(248, 27);
            this.txbID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(21, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Take off time";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOK.Location = new System.Drawing.Point(518, 427);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(466, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(443, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(96, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(75, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Airline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(58, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Flight ID";
            // 
            // cbbRoundtrip
            // 
            this.cbbRoundtrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoundtrip.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRoundtrip.FormattingEnabled = true;
            this.cbbRoundtrip.Location = new System.Drawing.Point(159, 244);
            this.cbbRoundtrip.Margin = new System.Windows.Forms.Padding(2);
            this.cbbRoundtrip.Name = "cbbRoundtrip";
            this.cbbRoundtrip.Size = new System.Drawing.Size(248, 28);
            this.cbbRoundtrip.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(24, 243);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "Roundtrip ID";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(826, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLandingMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTakeoffMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLandingHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTakeoffHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numLandingMin;
        private System.Windows.Forms.NumericUpDown numTakeoffMin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.ComboBox cbbTriptype;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numLandingHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDescrip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numTakeoffHour;
        private System.Windows.Forms.DateTimePicker dpkTakeoff;
        private System.Windows.Forms.ComboBox cbbTo;
        private System.Windows.Forms.ComboBox cbbFrom;
        private System.Windows.Forms.ComboBox cbbAirline;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpkLanding;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbRoundtrip;
    }
}