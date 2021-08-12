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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5.SuspendLayout();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            this.pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
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
            this.tableLayoutPanel1.SetColumnSpan(this.listView1, 7);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 60);
            this.listView1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(722, 611);
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
            this.lbText.Location = new System.Drawing.Point(-7, 12);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(167, 37);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "PASSENGER";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.pn1);
            this.panel5.Controls.Add(this.pn2);
            this.panel5.Controls.Add(this.pn3);
            this.panel5.Location = new System.Drawing.Point(469, 17);
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
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.panel4.Location = new System.Drawing.Point(-3, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 5);
            this.panel4.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.559201F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.4408F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 701);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lbText);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 54);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(809, 707);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // ViewFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(809, 707);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}