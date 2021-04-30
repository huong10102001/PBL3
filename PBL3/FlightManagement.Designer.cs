using System.Windows.Forms;

namespace PBL3
{
    partial class FlightManagement
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
            this.pn1 = new System.Windows.Forms.Panel();
            this.lbAdd = new System.Windows.Forms.Label();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.pn2 = new System.Windows.Forms.Panel();
            this.labelEdit = new System.Windows.Forms.Label();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pn3 = new System.Windows.Forms.Panel();
            this.labelDelete = new System.Windows.Forms.Label();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pn4 = new System.Windows.Forms.Panel();
            this.labelView = new System.Windows.Forms.Label();
            this.pictureBoxView = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ckbxID = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbDeparture = new System.Windows.Forms.ComboBox();
            this.ckbxDepart = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDestination = new System.Windows.Forms.ComboBox();
            this.ckbxDesti = new System.Windows.Forms.CheckBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbxDay = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbAirline = new System.Windows.Forms.ComboBox();
            this.ckbxAirline = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            this.pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.pn4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.lbAdd);
            this.pn1.Controls.Add(this.pictureBoxAdd);
            this.pn1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pn1.Location = new System.Drawing.Point(13, 4);
            this.pn1.Margin = new System.Windows.Forms.Padding(4);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(89, 36);
            this.pn1.TabIndex = 1;
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbAdd.Location = new System.Drawing.Point(38, 3);
            this.lbAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(70, 40);
            this.lbAdd.TabIndex = 2;
            this.lbAdd.Text = "Add";
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAdd.Image = global::PBL3.Properties.Resources.icon;
            this.pictureBoxAdd.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 2;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.BtnAdd);
            // 
            // pn2
            // 
            this.pn2.Controls.Add(this.labelEdit);
            this.pn2.Controls.Add(this.pictureBoxEdit);
            this.pn2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pn2.Location = new System.Drawing.Point(110, 4);
            this.pn2.Margin = new System.Windows.Forms.Padding(4);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(87, 36);
            this.pn2.TabIndex = 3;
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelEdit.Location = new System.Drawing.Point(38, 3);
            this.labelEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(66, 40);
            this.labelEdit.TabIndex = 2;
            this.labelEdit.Text = "Edit";
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::PBL3.Properties.Resources.iconfinder_icon_136_document_edit_314724;
            this.pictureBoxEdit.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdit.TabIndex = 2;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.BtnEdit);
            // 
            // pn3
            // 
            this.pn3.Controls.Add(this.labelDelete);
            this.pn3.Controls.Add(this.pictureBoxDelete);
            this.pn3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pn3.Location = new System.Drawing.Point(205, 4);
            this.pn3.Margin = new System.Windows.Forms.Padding(4);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(113, 36);
            this.pn3.TabIndex = 4;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.ForeColor = System.Drawing.Color.Tomato;
            this.labelDelete.Location = new System.Drawing.Point(38, 3);
            this.labelDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(99, 40);
            this.labelDelete.TabIndex = 2;
            this.labelDelete.Text = "Delete";
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::PBL3.Properties.Resources.remove;
            this.pictureBoxDelete.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDelete.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelete.TabIndex = 2;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.BtnDelete);
            // 
            // pn4
            // 
            this.pn4.Controls.Add(this.labelView);
            this.pn4.Controls.Add(this.pictureBoxView);
            this.pn4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pn4.Location = new System.Drawing.Point(326, 4);
            this.pn4.Margin = new System.Windows.Forms.Padding(4);
            this.pn4.Name = "pn4";
            this.pn4.Size = new System.Drawing.Size(94, 36);
            this.pn4.TabIndex = 3;
            // 
            // labelView
            // 
            this.labelView.AutoSize = true;
            this.labelView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelView.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelView.Location = new System.Drawing.Point(38, 3);
            this.labelView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelView.Name = "labelView";
            this.labelView.Size = new System.Drawing.Size(78, 40);
            this.labelView.TabIndex = 2;
            this.labelView.Text = "View";
            // 
            // pictureBoxView
            // 
            this.pictureBoxView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxView.Image = global::PBL3.Properties.Resources.clipart1797699;
            this.pictureBoxView.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxView.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxView.Name = "pictureBoxView";
            this.pictureBoxView.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxView.TabIndex = 2;
            this.pictureBoxView.TabStop = false;
            this.pictureBoxView.Click += new System.EventHandler(this.BtnView);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.pn1);
            this.panel5.Controls.Add(this.pn4);
            this.panel5.Controls.Add(this.pn2);
            this.panel5.Controls.Add(this.pn3);
            this.panel5.Location = new System.Drawing.Point(236, 16);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(424, 40);
            this.panel5.TabIndex = 5;
            // 
            // ckbxID
            // 
            this.ckbxID.AutoSize = true;
            this.ckbxID.Location = new System.Drawing.Point(4, 23);
            this.ckbxID.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxID.Name = "ckbxID";
            this.ckbxID.Size = new System.Drawing.Size(22, 21);
            this.ckbxID.TabIndex = 7;
            this.ckbxID.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ckbxID);
            this.panel1.Location = new System.Drawing.Point(17, 159);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 85);
            this.panel1.TabIndex = 9;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(0, 44);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(199, 33);
            this.txbID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 45);
            this.label6.TabIndex = 9;
            this.label6.Text = "Flight ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbbDeparture);
            this.panel2.Controls.Add(this.ckbxDepart);
            this.panel2.Location = new System.Drawing.Point(17, 345);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 94);
            this.panel2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 45);
            this.label7.TabIndex = 9;
            this.label7.Text = "Departure";
            // 
            // cbbDeparture
            // 
            this.cbbDeparture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeparture.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDeparture.FormattingEnabled = true;
            this.cbbDeparture.Location = new System.Drawing.Point(4, 48);
            this.cbbDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDeparture.Name = "cbbDeparture";
            this.cbbDeparture.Size = new System.Drawing.Size(199, 36);
            this.cbbDeparture.TabIndex = 8;
            // 
            // ckbxDepart
            // 
            this.ckbxDepart.AutoSize = true;
            this.ckbxDepart.Location = new System.Drawing.Point(4, 23);
            this.ckbxDepart.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxDepart.Name = "ckbxDepart";
            this.ckbxDepart.Size = new System.Drawing.Size(22, 21);
            this.ckbxDepart.TabIndex = 7;
            this.ckbxDepart.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbbDestination);
            this.panel3.Controls.Add(this.ckbxDesti);
            this.panel3.Location = new System.Drawing.Point(17, 447);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 89);
            this.panel3.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 45);
            this.label8.TabIndex = 9;
            this.label8.Text = "Destination";
            // 
            // cbbDestination
            // 
            this.cbbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDestination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDestination.FormattingEnabled = true;
            this.cbbDestination.Location = new System.Drawing.Point(4, 48);
            this.cbbDestination.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDestination.Name = "cbbDestination";
            this.cbbDestination.Size = new System.Drawing.Size(199, 36);
            this.cbbDestination.TabIndex = 8;
            // 
            // ckbxDesti
            // 
            this.ckbxDesti.AutoSize = true;
            this.ckbxDesti.Location = new System.Drawing.Point(4, 23);
            this.ckbxDesti.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxDesti.Name = "ckbxDesti";
            this.ckbxDesti.Size = new System.Drawing.Size(22, 21);
            this.ckbxDesti.TabIndex = 7;
            this.ckbxDesti.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.SteelBlue;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(26, 16);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(114, 32);
            this.lblText.TabIndex = 11;
            this.lblText.Text = "Welcome";
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(17, 41);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(199, 51);
            this.btnProfile.TabIndex = 13;
            this.btnProfile.Text = "Do Thanh Tuan";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1262, 12);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 36);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Search Flight";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader8,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(236, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1160, 689);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Flight";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Airline";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "From";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "To";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Day";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Takeoff time";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Landing Time";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Status";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Base Economic Price";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Main Cabin Price";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Delta Comfort Price";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "First Class Price";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Trip Type";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Capacity";
            this.columnHeader14.Width = 120;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.ckbxDay);
            this.panel4.Location = new System.Drawing.Point(17, 544);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 89);
            this.panel4.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 33);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Take off day";
            // 
            // ckbxDay
            // 
            this.ckbxDay.AutoSize = true;
            this.ckbxDay.Location = new System.Drawing.Point(4, 23);
            this.ckbxDay.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxDay.Name = "ckbxDay";
            this.ckbxDay.Size = new System.Drawing.Size(22, 21);
            this.ckbxDay.TabIndex = 7;
            this.ckbxDay.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.cbbAirline);
            this.panel6.Controls.Add(this.ckbxAirline);
            this.panel6.Location = new System.Drawing.Point(17, 252);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 85);
            this.panel6.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Airlines";
            // 
            // cbbAirline
            // 
            this.cbbAirline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAirline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAirline.FormattingEnabled = true;
            this.cbbAirline.Location = new System.Drawing.Point(0, 45);
            this.cbbAirline.Margin = new System.Windows.Forms.Padding(4);
            this.cbbAirline.Name = "cbbAirline";
            this.cbbAirline.Size = new System.Drawing.Size(199, 36);
            this.cbbAirline.TabIndex = 8;
            // 
            // ckbxAirline
            // 
            this.ckbxAirline.AutoSize = true;
            this.ckbxAirline.Location = new System.Drawing.Point(4, 23);
            this.ckbxAirline.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxAirline.Name = "ckbxAirline";
            this.ckbxAirline.Size = new System.Drawing.Size(22, 21);
            this.ckbxAirline.TabIndex = 7;
            this.ckbxAirline.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.panel7.Location = new System.Drawing.Point(236, 51);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1161, 5);
            this.panel7.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1123, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "Feedback";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FlightManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1421, 782);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FlightManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.pn2.ResumeLayout(false);
            this.pn2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            this.pn3.ResumeLayout(false);
            this.pn3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.pn4.ResumeLayout(false);
            this.pn4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.Panel pn4;
        private System.Windows.Forms.Label labelView;
        private System.Windows.Forms.PictureBox pictureBoxView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox ckbxID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbDeparture;
        private System.Windows.Forms.CheckBox ckbxDepart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbDestination;
        private System.Windows.Forms.CheckBox ckbxDesti;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private TextBox txbID;
        private Panel panel4;
        private Label label1;
        private CheckBox ckbxDay;
        private Panel panel6;
        private Label label2;
        private ComboBox cbbAirline;
        private CheckBox ckbxAirline;
        private DateTimePicker dateTimePicker1;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Panel panel7;
        private Button button2;
    }
}

