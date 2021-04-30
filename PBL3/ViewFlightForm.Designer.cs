namespace PBL3
{
    partial class ViewFlightForm
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
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBooking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSeat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbText = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pn1 = new System.Windows.Forms.Panel();
            this.lbAdd = new System.Windows.Forms.Label();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.pn2 = new System.Windows.Forms.Panel();
            this.labelEdit = new System.Windows.Forms.Label();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pn3 = new System.Windows.Forms.Panel();
            this.labelDelete = new System.Windows.Forms.Label();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            this.pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clBooking,
            this.clName,
            this.clGender,
            this.clPhone,
            this.clAddress,
            this.clSeat});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(308, 66);
            this.listView1.Margin = new System.Windows.Forms.Padding(22, 2, 22, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(611, 483);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clID
            // 
            this.clID.Text = "ID";
            this.clID.Width = 100;
            // 
            // clBooking
            // 
            this.clBooking.Text = "Booking User";
            this.clBooking.Width = 100;
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.Width = 150;
            // 
            // clGender
            // 
            this.clGender.Text = "Gender";
            // 
            // clPhone
            // 
            this.clPhone.Text = "Phone";
            this.clPhone.Width = 100;
            // 
            // clAddress
            // 
            this.clAddress.Text = "Address";
            this.clAddress.Width = 100;
            // 
            // clSeat
            // 
            this.clSeat.Text = "Seat";
            this.clSeat.Width = 100;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.SteelBlue;
            this.lbText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lbText.Location = new System.Drawing.Point(22, 16);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(167, 37);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "PASSENGER";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.pn1);
            this.panel5.Controls.Add(this.pn2);
            this.panel5.Controls.Add(this.pn3);
            this.panel5.Location = new System.Drawing.Point(669, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 32);
            this.panel5.TabIndex = 17;
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.lbAdd);
            this.pn1.Controls.Add(this.pictureBoxAdd);
            this.pn1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pn1.Location = new System.Drawing.Point(10, 3);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(67, 29);
            this.pn1.TabIndex = 1;
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbAdd.Location = new System.Drawing.Point(23, -2);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(46, 25);
            this.lbAdd.TabIndex = 2;
            this.lbAdd.Text = "Add";
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAdd.Image = global::PBL3.Properties.Resources.icon;
            this.pictureBoxAdd.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(22, 24);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 2;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            // 
            // pn2
            // 
            this.pn2.Controls.Add(this.labelEdit);
            this.pn2.Controls.Add(this.pictureBoxEdit);
            this.pn2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pn2.Location = new System.Drawing.Point(82, 3);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(65, 29);
            this.pn2.TabIndex = 3;
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelEdit.Location = new System.Drawing.Point(24, -2);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(44, 25);
            this.labelEdit.TabIndex = 2;
            this.labelEdit.Text = "Edit";
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::PBL3.Properties.Resources.iconfinder_icon_136_document_edit_314724;
            this.pictureBoxEdit.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(22, 24);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdit.TabIndex = 2;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            // 
            // pn3
            // 
            this.pn3.Controls.Add(this.labelDelete);
            this.pn3.Controls.Add(this.pictureBoxDelete);
            this.pn3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pn3.Location = new System.Drawing.Point(154, 3);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(92, 29);
            this.pn3.TabIndex = 4;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.ForeColor = System.Drawing.Color.Tomato;
            this.labelDelete.Location = new System.Drawing.Point(28, -2);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(66, 25);
            this.labelDelete.TabIndex = 2;
            this.labelDelete.Text = "Delete";
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::PBL3.Properties.Resources.remove;
            this.pictureBoxDelete.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(22, 24);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelete.TabIndex = 2;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.panel4.Location = new System.Drawing.Point(29, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(890, 5);
            this.panel4.TabIndex = 18;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(89, 78);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(192, 26);
            this.txbName.TabIndex = 19;
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.Location = new System.Drawing.Point(89, 190);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(192, 26);
            this.txbPhone.TabIndex = 21;
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(89, 249);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(192, 26);
            this.txbAddress.TabIndex = 22;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(21, 76);
            this.Username.Margin = new System.Windows.Forms.Padding(10, 24, 20, 10);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(62, 25);
            this.Username.TabIndex = 23;
            this.Username.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 24, 20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 24, 20, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 24, 20, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Address";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbbGender);
            this.panel.Controls.Add(this.btnAddEdit);
            this.panel.Controls.Add(this.lblMode);
            this.panel.Controls.Add(this.txbName);
            this.panel.Controls.Add(this.txbAddress);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txbPhone);
            this.panel.Controls.Add(this.Username);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(3, 89);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(297, 439);
            this.panel.TabIndex = 27;
            // 
            // cbbGender
            // 
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Location = new System.Drawing.Point(89, 132);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(192, 25);
            this.cbbGender.TabIndex = 29;
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddEdit.FlatAppearance.BorderSize = 2;
            this.btnAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddEdit.Location = new System.Drawing.Point(213, 308);
            this.btnAddEdit.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(68, 30);
            this.btnAddEdit.TabIndex = 28;
            this.btnAddEdit.Text = "ADD";
            this.btnAddEdit.UseVisualStyleBackColor = false;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point(19, 5);
            this.lblMode.Margin = new System.Windows.Forms.Padding(10, 24, 20, 10);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(220, 37);
            this.lblMode.TabIndex = 27;
            this.lblMode.Text = "Add New Ticket";
            // 
            // ViewFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(942, 574);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewFlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewFlightForm";
            this.Load += new System.EventHandler(this.ShowFlightForm_Load);
            this.panel5.ResumeLayout(false);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.pn2.ResumeLayout(false);
            this.pn2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            this.pn3.ResumeLayout(false);
            this.pn3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clGender;
        private System.Windows.Forms.ColumnHeader clPhone;
        private System.Windows.Forms.ColumnHeader clAddress;
        private System.Windows.Forms.ColumnHeader clSeat;
        private System.Windows.Forms.ColumnHeader clBooking;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox cbbGender;
    }
}