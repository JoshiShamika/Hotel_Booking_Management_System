namespace hotel_form
{
    partial class RoomDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_hotelID = new System.Windows.Forms.Label();
            this.txt_hotelID = new System.Windows.Forms.TextBox();
            this.lbl_roomID = new System.Windows.Forms.Label();
            this.txt_roomID = new System.Windows.Forms.TextBox();
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.txt_roomNo = new System.Windows.Forms.TextBox();
            this.lbl_roomtype = new System.Windows.Forms.Label();
            this.cmb_roomtype = new System.Windows.Forms.ComboBox();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.lbl_Availability = new System.Windows.Forms.Label();
            this.txt_availability = new System.Windows.Forms.TextBox();
            this.pbx_image = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Details";
            // 
            // lbl_hotelID
            // 
            this.lbl_hotelID.AutoSize = true;
            this.lbl_hotelID.Location = new System.Drawing.Point(39, 75);
            this.lbl_hotelID.Name = "lbl_hotelID";
            this.lbl_hotelID.Size = new System.Drawing.Size(46, 13);
            this.lbl_hotelID.TabIndex = 1;
            this.lbl_hotelID.Text = "Hotel ID";
            // 
            // txt_hotelID
            // 
            this.txt_hotelID.Location = new System.Drawing.Point(207, 67);
            this.txt_hotelID.Name = "txt_hotelID";
            this.txt_hotelID.Size = new System.Drawing.Size(164, 20);
            this.txt_hotelID.TabIndex = 2;
            // 
            // lbl_roomID
            // 
            this.lbl_roomID.AutoSize = true;
            this.lbl_roomID.Location = new System.Drawing.Point(39, 117);
            this.lbl_roomID.Name = "lbl_roomID";
            this.lbl_roomID.Size = new System.Drawing.Size(49, 13);
            this.lbl_roomID.TabIndex = 3;
            this.lbl_roomID.Text = "Room ID";
            // 
            // txt_roomID
            // 
            this.txt_roomID.Location = new System.Drawing.Point(207, 110);
            this.txt_roomID.Name = "txt_roomID";
            this.txt_roomID.Size = new System.Drawing.Size(164, 20);
            this.txt_roomID.TabIndex = 4;
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.Location = new System.Drawing.Point(39, 160);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(52, 13);
            this.lbl_roomNo.TabIndex = 5;
            this.lbl_roomNo.Text = "Room No";
            // 
            // txt_roomNo
            // 
            this.txt_roomNo.Location = new System.Drawing.Point(207, 153);
            this.txt_roomNo.Name = "txt_roomNo";
            this.txt_roomNo.Size = new System.Drawing.Size(164, 20);
            this.txt_roomNo.TabIndex = 6;
            // 
            // lbl_roomtype
            // 
            this.lbl_roomtype.AutoSize = true;
            this.lbl_roomtype.Location = new System.Drawing.Point(39, 206);
            this.lbl_roomtype.Name = "lbl_roomtype";
            this.lbl_roomtype.Size = new System.Drawing.Size(62, 13);
            this.lbl_roomtype.TabIndex = 7;
            this.lbl_roomtype.Text = "Room Type";
            // 
            // cmb_roomtype
            // 
            this.cmb_roomtype.FormattingEnabled = true;
            this.cmb_roomtype.Items.AddRange(new object[] {
            "Select Room Type",
            "AC ",
            "Non AC"});
            this.cmb_roomtype.Location = new System.Drawing.Point(207, 197);
            this.cmb_roomtype.Name = "cmb_roomtype";
            this.cmb_roomtype.Size = new System.Drawing.Size(164, 21);
            this.cmb_roomtype.TabIndex = 8;
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Location = new System.Drawing.Point(39, 245);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(77, 13);
            this.lbl_rate.TabIndex = 9;
            this.lbl_rate.Text = "Per Night Rate";
            // 
            // txt_rate
            // 
            this.txt_rate.Location = new System.Drawing.Point(207, 238);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(164, 20);
            this.txt_rate.TabIndex = 10;
            // 
            // lbl_Availability
            // 
            this.lbl_Availability.AutoSize = true;
            this.lbl_Availability.Location = new System.Drawing.Point(42, 286);
            this.lbl_Availability.Name = "lbl_Availability";
            this.lbl_Availability.Size = new System.Drawing.Size(56, 13);
            this.lbl_Availability.TabIndex = 11;
            this.lbl_Availability.Text = "Availability";
            // 
            // txt_availability
            // 
            this.txt_availability.Location = new System.Drawing.Point(207, 278);
            this.txt_availability.Name = "txt_availability";
            this.txt_availability.Size = new System.Drawing.Size(164, 20);
            this.txt_availability.TabIndex = 12;
            // 
            // pbx_image
            // 
            this.pbx_image.Location = new System.Drawing.Point(42, 323);
            this.pbx_image.Name = "pbx_image";
            this.pbx_image.Size = new System.Drawing.Size(100, 50);
            this.pbx_image.TabIndex = 13;
            this.pbx_image.TabStop = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(192, 403);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 14;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // RoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(616, 442);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.pbx_image);
            this.Controls.Add(this.txt_availability);
            this.Controls.Add(this.lbl_Availability);
            this.Controls.Add(this.txt_rate);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.cmb_roomtype);
            this.Controls.Add(this.lbl_roomtype);
            this.Controls.Add(this.txt_roomNo);
            this.Controls.Add(this.lbl_roomNo);
            this.Controls.Add(this.txt_roomID);
            this.Controls.Add(this.lbl_roomID);
            this.Controls.Add(this.txt_hotelID);
            this.Controls.Add(this.lbl_hotelID);
            this.Controls.Add(this.label1);
            this.Name = "RoomDetails";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hotelID;
        private System.Windows.Forms.TextBox txt_hotelID;
        private System.Windows.Forms.Label lbl_roomID;
        private System.Windows.Forms.TextBox txt_roomID;
        private System.Windows.Forms.Label lbl_roomNo;
        private System.Windows.Forms.TextBox txt_roomNo;
        private System.Windows.Forms.Label lbl_roomtype;
        private System.Windows.Forms.ComboBox cmb_roomtype;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.TextBox txt_rate;
        private System.Windows.Forms.Label lbl_Availability;
        private System.Windows.Forms.TextBox txt_availability;
        private System.Windows.Forms.PictureBox pbx_image;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_Submit;
    }
}