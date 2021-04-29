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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label5 = new System.Windows.Forms.Label();
            this.ckbxAirline = new System.Windows.Forms.CheckBox();
            this.cbbAirline = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbDeparture = new System.Windows.Forms.ComboBox();
            this.ckbxDepart = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDestination = new System.Windows.Forms.ComboBox();
            this.ckbxDesti = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbSortPrice = new System.Windows.Forms.ComboBox();
            this.ckbxPrice = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureboxFind = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFind)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(324, 66);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1168, 703);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Flight";
            this.columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Airline";
            this.columnHeader2.Width = 202;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "From";
            this.columnHeader3.Width = 184;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "To";
            this.columnHeader4.Width = 177;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Day";
            this.columnHeader5.Width = 161;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Takeoff time";
            this.columnHeader6.Width = 183;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price";
            this.columnHeader7.Width = 182;
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.lbAdd);
            this.pn1.Controls.Add(this.pictureBoxAdd);
            this.pn1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pn1.Location = new System.Drawing.Point(19, 2);
            this.pn1.Margin = new System.Windows.Forms.Padding(4);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(132, 54);
            this.pn1.TabIndex = 1;
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbAdd.Location = new System.Drawing.Point(57, 8);
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
            this.pictureBoxAdd.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(45, 46);
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
            this.pn2.Location = new System.Drawing.Point(140, 2);
            this.pn2.Margin = new System.Windows.Forms.Padding(4);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(132, 54);
            this.pn2.TabIndex = 3;
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelEdit.Location = new System.Drawing.Point(57, 8);
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
            this.pictureBoxEdit.Location = new System.Drawing.Point(7, 4);
            this.pictureBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(45, 46);
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
            this.pn3.Location = new System.Drawing.Point(261, 2);
            this.pn3.Margin = new System.Windows.Forms.Padding(4);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(166, 54);
            this.pn3.TabIndex = 4;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.ForeColor = System.Drawing.Color.Tomato;
            this.labelDelete.Location = new System.Drawing.Point(57, 8);
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
            this.pictureBoxDelete.Location = new System.Drawing.Point(11, 3);
            this.pictureBoxDelete.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(38, 46);
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
            this.pn4.Location = new System.Drawing.Point(412, 2);
            this.pn4.Margin = new System.Windows.Forms.Padding(4);
            this.pn4.Name = "pn4";
            this.pn4.Size = new System.Drawing.Size(145, 54);
            this.pn4.TabIndex = 3;
            // 
            // labelView
            // 
            this.labelView.AutoSize = true;
            this.labelView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelView.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelView.Location = new System.Drawing.Point(58, 8);
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
            this.pictureBoxView.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxView.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxView.Name = "pictureBoxView";
            this.pictureBoxView.Size = new System.Drawing.Size(46, 46);
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
            this.panel5.Location = new System.Drawing.Point(327, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(590, 61);
            this.panel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 55);
            this.label5.TabIndex = 6;
            this.label5.Text = "Find Flight";
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
            // cbbAirline
            // 
            this.cbbAirline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAirline.FormattingEnabled = true;
            this.cbbAirline.Location = new System.Drawing.Point(4, 48);
            this.cbbAirline.Margin = new System.Windows.Forms.Padding(4);
            this.cbbAirline.Name = "cbbAirline";
            this.cbbAirline.Size = new System.Drawing.Size(247, 48);
            this.cbbAirline.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbbAirline);
            this.panel1.Controls.Add(this.ckbxAirline);
            this.panel1.Location = new System.Drawing.Point(5, 209);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 129);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 45);
            this.label6.TabIndex = 9;
            this.label6.Text = "Airlines";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbbDeparture);
            this.panel2.Controls.Add(this.ckbxDepart);
            this.panel2.Location = new System.Drawing.Point(5, 319);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 129);
            this.panel2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 45);
            this.label7.TabIndex = 9;
            this.label7.Text = "Departure";
            // 
            // cbbDeparture
            // 
            this.cbbDeparture.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDeparture.FormattingEnabled = true;
            this.cbbDeparture.Location = new System.Drawing.Point(4, 48);
            this.cbbDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDeparture.Name = "cbbDeparture";
            this.cbbDeparture.Size = new System.Drawing.Size(247, 48);
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
            this.panel3.Location = new System.Drawing.Point(5, 430);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 129);
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
            this.cbbDestination.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDestination.FormattingEnabled = true;
            this.cbbDestination.Location = new System.Drawing.Point(4, 48);
            this.cbbDestination.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDestination.Name = "cbbDestination";
            this.cbbDestination.Size = new System.Drawing.Size(247, 48);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cbbSortPrice);
            this.panel4.Controls.Add(this.ckbxPrice);
            this.panel4.Location = new System.Drawing.Point(5, 541);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 129);
            this.panel4.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(36, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 45);
            this.label9.TabIndex = 9;
            this.label9.Text = "Prices";
            // 
            // cbbSortPrice
            // 
            this.cbbSortPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortPrice.FormattingEnabled = true;
            this.cbbSortPrice.Location = new System.Drawing.Point(4, 48);
            this.cbbSortPrice.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSortPrice.Name = "cbbSortPrice";
            this.cbbSortPrice.Size = new System.Drawing.Size(247, 48);
            this.cbbSortPrice.TabIndex = 8;
            // 
            // ckbxPrice
            // 
            this.ckbxPrice.AutoSize = true;
            this.ckbxPrice.Location = new System.Drawing.Point(4, 23);
            this.ckbxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxPrice.Name = "ckbxPrice";
            this.ckbxPrice.Size = new System.Drawing.Size(22, 21);
            this.ckbxPrice.TabIndex = 7;
            this.ckbxPrice.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "Welcome";
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(16, 46);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(303, 51);
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
            this.btnLogout.Location = new System.Drawing.Point(1373, 8);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 59);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pictureboxFind
            // 
            this.pictureboxFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxFind.Image = global::PBL3.Properties.Resources.findicon;
            this.pictureboxFind.Location = new System.Drawing.Point(236, 108);
            this.pictureboxFind.Margin = new System.Windows.Forms.Padding(4);
            this.pictureboxFind.Name = "pictureboxFind";
            this.pictureboxFind.Size = new System.Drawing.Size(45, 46);
            this.pictureboxFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxFind.TabIndex = 15;
            this.pictureboxFind.TabStop = false;
            // 
            // FlightManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1505, 782);
            this.Controls.Add(this.pictureboxFind);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbxAirline;
        private System.Windows.Forms.ComboBox cbbAirline;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbSortPrice;
        private System.Windows.Forms.CheckBox ckbxPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private PictureBox pictureboxFind;
    }
}

