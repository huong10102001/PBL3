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
            this.panel5.SuspendLayout();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            this.pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
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
            this.listView1.Location = new System.Drawing.Point(37, 81);
            this.listView1.Margin = new System.Windows.Forms.Padding(29, 2, 29, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(813, 594);
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
            this.lbText.Location = new System.Drawing.Point(29, 20);
            this.lbText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(210, 46);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "PASSENGER";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.pn1);
            this.panel5.Controls.Add(this.pn2);
            this.panel5.Controls.Add(this.pn3);
            this.panel5.Location = new System.Drawing.Point(517, 32);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 39);
            this.panel5.TabIndex = 17;
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.lbAdd);
            this.pn1.Controls.Add(this.pictureBoxAdd);
            this.pn1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pn1.Location = new System.Drawing.Point(13, 4);
            this.pn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(89, 36);
            this.pn1.TabIndex = 1;
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbAdd.Location = new System.Drawing.Point(31, -2);
            this.lbAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(58, 32);
            this.lbAdd.TabIndex = 2;
            this.lbAdd.Text = "Add";
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAdd.Image = global::PBL3.Properties.Resources.icon;
            this.pictureBoxAdd.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(29, 30);
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
            this.pn2.Location = new System.Drawing.Point(109, 4);
            this.pn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(87, 36);
            this.pn2.TabIndex = 3;
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelEdit.Location = new System.Drawing.Point(32, -2);
            this.labelEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(55, 32);
            this.labelEdit.TabIndex = 2;
            this.labelEdit.Text = "Edit";
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::PBL3.Properties.Resources.iconfinder_icon_136_document_edit_314724;
            this.pictureBoxEdit.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(29, 30);
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
            this.pn3.Location = new System.Drawing.Point(205, 4);
            this.pn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(123, 36);
            this.pn3.TabIndex = 4;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.ForeColor = System.Drawing.Color.Tomato;
            this.labelDelete.Location = new System.Drawing.Point(37, -2);
            this.labelDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(85, 32);
            this.labelDelete.TabIndex = 2;
            this.labelDelete.Text = "Delete";
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::PBL3.Properties.Resources.remove;
            this.pictureBoxDelete.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(29, 30);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelete.TabIndex = 2;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.panel4.Location = new System.Drawing.Point(39, 67);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(811, 5);
            this.panel4.TabIndex = 18;
            // 
            // ViewFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(887, 706);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ColumnHeader clID;
    }
}