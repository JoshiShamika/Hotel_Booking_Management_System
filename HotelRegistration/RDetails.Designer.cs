namespace HotelRegistration
{
    partial class RDetails
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
            this.lbl_HotelId = new System.Windows.Forms.Label();
            this.lbl_RoomId = new System.Windows.Forms.Label();
            this.lbl_RoomType = new System.Windows.Forms.Label();
            this.lbl_PerNightRate = new System.Windows.Forms.Label();
            this.lbl_Availability = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_HotelID = new System.Windows.Forms.TextBox();
            this.txt_RoomId = new System.Windows.Forms.TextBox();
            this.txt_RoomType = new System.Windows.Forms.TextBox();
            this.txt_PerNightRate = new System.Windows.Forms.TextBox();
            this.txt_Availability = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RoomNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_HotelId
            // 
            this.lbl_HotelId.AutoSize = true;
            this.lbl_HotelId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HotelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HotelId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_HotelId.Location = new System.Drawing.Point(40, 97);
            this.lbl_HotelId.Name = "lbl_HotelId";
            this.lbl_HotelId.Size = new System.Drawing.Size(62, 16);
            this.lbl_HotelId.TabIndex = 1;
            this.lbl_HotelId.Text = "Hotel Id";
            // 
            // lbl_RoomId
            // 
            this.lbl_RoomId.AutoSize = true;
            this.lbl_RoomId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_RoomId.Location = new System.Drawing.Point(40, 138);
            this.lbl_RoomId.Name = "lbl_RoomId";
            this.lbl_RoomId.Size = new System.Drawing.Size(70, 16);
            this.lbl_RoomId.TabIndex = 2;
            this.lbl_RoomId.Text = "Room_Id";
            // 
            // lbl_RoomType
            // 
            this.lbl_RoomType.AutoSize = true;
            this.lbl_RoomType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_RoomType.Location = new System.Drawing.Point(40, 180);
            this.lbl_RoomType.Name = "lbl_RoomType";
            this.lbl_RoomType.Size = new System.Drawing.Size(89, 16);
            this.lbl_RoomType.TabIndex = 3;
            this.lbl_RoomType.Text = "Room Type";
            // 
            // lbl_PerNightRate
            // 
            this.lbl_PerNightRate.AutoSize = true;
            this.lbl_PerNightRate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PerNightRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PerNightRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_PerNightRate.Location = new System.Drawing.Point(40, 214);
            this.lbl_PerNightRate.Name = "lbl_PerNightRate";
            this.lbl_PerNightRate.Size = new System.Drawing.Size(109, 16);
            this.lbl_PerNightRate.TabIndex = 4;
            this.lbl_PerNightRate.Text = "Per Night Rate";
            // 
            // lbl_Availability
            // 
            this.lbl_Availability.AutoSize = true;
            this.lbl_Availability.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Availability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Availability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_Availability.Location = new System.Drawing.Point(40, 253);
            this.lbl_Availability.Name = "lbl_Availability";
            this.lbl_Availability.Size = new System.Drawing.Size(85, 16);
            this.lbl_Availability.TabIndex = 5;
            this.lbl_Availability.Text = "Availability";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(149, 352);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_HotelID
            // 
            this.txt_HotelID.BackColor = System.Drawing.SystemColors.Info;
            this.txt_HotelID.Location = new System.Drawing.Point(222, 93);
            this.txt_HotelID.Name = "txt_HotelID";
            this.txt_HotelID.Size = new System.Drawing.Size(100, 20);
            this.txt_HotelID.TabIndex = 8;
            // 
            // txt_RoomId
            // 
            this.txt_RoomId.BackColor = System.Drawing.SystemColors.Info;
            this.txt_RoomId.Location = new System.Drawing.Point(222, 138);
            this.txt_RoomId.Name = "txt_RoomId";
            this.txt_RoomId.Size = new System.Drawing.Size(100, 20);
            this.txt_RoomId.TabIndex = 9;
            // 
            // txt_RoomType
            // 
            this.txt_RoomType.BackColor = System.Drawing.SystemColors.Info;
            this.txt_RoomType.Location = new System.Drawing.Point(222, 176);
            this.txt_RoomType.Name = "txt_RoomType";
            this.txt_RoomType.Size = new System.Drawing.Size(100, 20);
            this.txt_RoomType.TabIndex = 10;
            // 
            // txt_PerNightRate
            // 
            this.txt_PerNightRate.BackColor = System.Drawing.SystemColors.Info;
            this.txt_PerNightRate.Location = new System.Drawing.Point(222, 214);
            this.txt_PerNightRate.Name = "txt_PerNightRate";
            this.txt_PerNightRate.Size = new System.Drawing.Size(100, 20);
            this.txt_PerNightRate.TabIndex = 11;
            // 
            // txt_Availability
            // 
            this.txt_Availability.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Availability.Location = new System.Drawing.Point(222, 253);
            this.txt_Availability.Name = "txt_Availability";
            this.txt_Availability.Size = new System.Drawing.Size(100, 20);
            this.txt_Availability.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(40, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Room No.";
            // 
            // txt_RoomNo
            // 
            this.txt_RoomNo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_RoomNo.Location = new System.Drawing.Point(222, 292);
            this.txt_RoomNo.Name = "txt_RoomNo";
            this.txt_RoomNo.Size = new System.Drawing.Size(100, 20);
            this.txt_RoomNo.TabIndex = 15;
            // 
            // RDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelRegistration.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 381);
            this.Controls.Add(this.txt_RoomNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Availability);
            this.Controls.Add(this.txt_PerNightRate);
            this.Controls.Add(this.txt_RoomType);
            this.Controls.Add(this.txt_RoomId);
            this.Controls.Add(this.txt_HotelID);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Availability);
            this.Controls.Add(this.lbl_PerNightRate);
            this.Controls.Add(this.lbl_RoomType);
            this.Controls.Add(this.lbl_RoomId);
            this.Controls.Add(this.lbl_HotelId);
            this.Controls.Add(this.label1);
            this.Name = "RDetails";
            this.Text = "RoomDetails";
            this.Load += new System.EventHandler(this.RDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_HotelId;
        private System.Windows.Forms.Label lbl_RoomId;
        private System.Windows.Forms.Label lbl_RoomType;
        private System.Windows.Forms.Label lbl_PerNightRate;
        private System.Windows.Forms.Label lbl_Availability;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_HotelID;
        private System.Windows.Forms.TextBox txt_RoomId;
        private System.Windows.Forms.TextBox txt_RoomType;
        private System.Windows.Forms.TextBox txt_PerNightRate;
        private System.Windows.Forms.TextBox txt_Availability;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RoomNo;
    }
}