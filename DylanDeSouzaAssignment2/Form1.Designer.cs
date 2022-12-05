namespace DylanDeSouzaAssignment2
{
    partial class FrmRoomBookingApplicationWestCoastHotel
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
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.lblNumberOfAllocatedRoom = new System.Windows.Forms.Label();
            this.lblNumberOfDaysOfStay = new System.Windows.Forms.Label();
            this.lblRequiredRoomSize = new System.Windows.Forms.Label();
            this.txt_customer_name = new System.Windows.Forms.TextBox();
            this.txt_room_num = new System.Windows.Forms.TextBox();
            this.txt_duration_stay = new System.Windows.Forms.TextBox();
            this.txt_room_size = new System.Windows.Forms.TextBox();
            this.btn_confirm_booking = new System.Windows.Forms.Button();
            this.btn_display_bookings = new System.Windows.Forms.Button();
            this.rdo_single = new System.Windows.Forms.RadioButton();
            this.rdo_dble = new System.Windows.Forms.RadioButton();
            this.rdo_triple = new System.Windows.Forms.RadioButton();
            this.lst_bookings = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lst_room_size = new System.Windows.Forms.ListBox();
            this.lblRoomSize = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.AutoSize = true;
            this.lblCustomerFullName.Location = new System.Drawing.Point(268, 157);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(96, 13);
            this.lblCustomerFullName.TabIndex = 0;
            this.lblCustomerFullName.Text = "Customer full name";
            // 
            // lblNumberOfAllocatedRoom
            // 
            this.lblNumberOfAllocatedRoom.AutoSize = true;
            this.lblNumberOfAllocatedRoom.Location = new System.Drawing.Point(230, 183);
            this.lblNumberOfAllocatedRoom.Name = "lblNumberOfAllocatedRoom";
            this.lblNumberOfAllocatedRoom.Size = new System.Drawing.Size(134, 13);
            this.lblNumberOfAllocatedRoom.TabIndex = 1;
            this.lblNumberOfAllocatedRoom.Text = "Number of Allocated Room";
            // 
            // lblNumberOfDaysOfStay
            // 
            this.lblNumberOfDaysOfStay.AutoSize = true;
            this.lblNumberOfDaysOfStay.Location = new System.Drawing.Point(245, 209);
            this.lblNumberOfDaysOfStay.Name = "lblNumberOfDaysOfStay";
            this.lblNumberOfDaysOfStay.Size = new System.Drawing.Size(119, 13);
            this.lblNumberOfDaysOfStay.TabIndex = 2;
            this.lblNumberOfDaysOfStay.Text = "Number of Days of Stay";
            // 
            // lblRequiredRoomSize
            // 
            this.lblRequiredRoomSize.AutoSize = true;
            this.lblRequiredRoomSize.Location = new System.Drawing.Point(260, 264);
            this.lblRequiredRoomSize.Name = "lblRequiredRoomSize";
            this.lblRequiredRoomSize.Size = new System.Drawing.Size(104, 13);
            this.lblRequiredRoomSize.TabIndex = 3;
            this.lblRequiredRoomSize.Text = "Required Room Size";
            // 
            // txt_customer_name
            // 
            this.txt_customer_name.Location = new System.Drawing.Point(370, 150);
            this.txt_customer_name.Name = "txt_customer_name";
            this.txt_customer_name.Size = new System.Drawing.Size(100, 20);
            this.txt_customer_name.TabIndex = 4;
            // 
            // txt_room_num
            // 
            this.txt_room_num.Location = new System.Drawing.Point(370, 176);
            this.txt_room_num.Name = "txt_room_num";
            this.txt_room_num.Size = new System.Drawing.Size(100, 20);
            this.txt_room_num.TabIndex = 5;
            // 
            // txt_duration_stay
            // 
            this.txt_duration_stay.Location = new System.Drawing.Point(370, 202);
            this.txt_duration_stay.Name = "txt_duration_stay";
            this.txt_duration_stay.Size = new System.Drawing.Size(100, 20);
            this.txt_duration_stay.TabIndex = 6;
            // 
            // txt_room_size
            // 
            this.txt_room_size.Location = new System.Drawing.Point(370, 257);
            this.txt_room_size.Name = "txt_room_size";
            this.txt_room_size.Size = new System.Drawing.Size(100, 20);
            this.txt_room_size.TabIndex = 7;
            // 
            // btn_confirm_booking
            // 
            this.btn_confirm_booking.AutoSize = true;
            this.btn_confirm_booking.Location = new System.Drawing.Point(370, 228);
            this.btn_confirm_booking.Name = "btn_confirm_booking";
            this.btn_confirm_booking.Size = new System.Drawing.Size(94, 23);
            this.btn_confirm_booking.TabIndex = 8;
            this.btn_confirm_booking.Text = "Confirm Booking";
            this.btn_confirm_booking.UseVisualStyleBackColor = true;
            this.btn_confirm_booking.Click += new System.EventHandler(this.btn_confirm_booking_Click);
            // 
            // btn_display_bookings
            // 
            this.btn_display_bookings.AutoSize = true;
            this.btn_display_bookings.Location = new System.Drawing.Point(531, 254);
            this.btn_display_bookings.Name = "btn_display_bookings";
            this.btn_display_bookings.Size = new System.Drawing.Size(152, 23);
            this.btn_display_bookings.TabIndex = 9;
            this.btn_display_bookings.Text = "Display Room Size Bookings";
            this.btn_display_bookings.UseVisualStyleBackColor = true;
            this.btn_display_bookings.Click += new System.EventHandler(this.btn_display_bookings_Click);
            // 
            // rdo_single
            // 
            this.rdo_single.AutoSize = true;
            this.rdo_single.Checked = true;
            this.rdo_single.Location = new System.Drawing.Point(606, 63);
            this.rdo_single.Name = "rdo_single";
            this.rdo_single.Size = new System.Drawing.Size(54, 17);
            this.rdo_single.TabIndex = 11;
            this.rdo_single.TabStop = true;
            this.rdo_single.Text = "Single";
            this.rdo_single.UseVisualStyleBackColor = true;
            // 
            // rdo_dble
            // 
            this.rdo_dble.AutoSize = true;
            this.rdo_dble.Location = new System.Drawing.Point(606, 86);
            this.rdo_dble.Name = "rdo_dble";
            this.rdo_dble.Size = new System.Drawing.Size(59, 17);
            this.rdo_dble.TabIndex = 12;
            this.rdo_dble.Text = "Double";
            this.rdo_dble.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_dble.UseVisualStyleBackColor = true;
            // 
            // rdo_triple
            // 
            this.rdo_triple.AutoSize = true;
            this.rdo_triple.Location = new System.Drawing.Point(606, 109);
            this.rdo_triple.Name = "rdo_triple";
            this.rdo_triple.Size = new System.Drawing.Size(51, 17);
            this.rdo_triple.TabIndex = 13;
            this.rdo_triple.Text = "Triple";
            this.rdo_triple.UseVisualStyleBackColor = true;
            // 
            // lst_bookings
            // 
            this.lst_bookings.FormattingEnabled = true;
            this.lst_bookings.Items.AddRange(new object[] {
            "",
            "Name\tRoom No"});
            this.lst_bookings.Location = new System.Drawing.Point(370, 283);
            this.lst_bookings.MultiColumn = true;
            this.lst_bookings.Name = "lst_bookings";
            this.lst_bookings.Size = new System.Drawing.Size(418, 95);
            this.lst_bookings.TabIndex = 14;
            // 
            // lst_room_size
            // 
            this.lst_room_size.BackColor = System.Drawing.SystemColors.Control;
            this.lst_room_size.FormattingEnabled = true;
            this.lst_room_size.Location = new System.Drawing.Point(587, 45);
            this.lst_room_size.Name = "lst_room_size";
            this.lst_room_size.Size = new System.Drawing.Size(120, 95);
            this.lst_room_size.TabIndex = 15;
            // 
            // lblRoomSize
            // 
            this.lblRoomSize.AutoSize = true;
            this.lblRoomSize.Location = new System.Drawing.Point(584, 29);
            this.lblRoomSize.Name = "lblRoomSize";
            this.lblRoomSize.Size = new System.Drawing.Size(58, 13);
            this.lblRoomSize.TabIndex = 16;
            this.lblRoomSize.Text = "Room Size";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // FrmRoomBookingApplicationWestCoastHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRoomSize);
            this.Controls.Add(this.rdo_triple);
            this.Controls.Add(this.rdo_dble);
            this.Controls.Add(this.rdo_single);
            this.Controls.Add(this.lst_bookings);
            this.Controls.Add(this.btn_display_bookings);
            this.Controls.Add(this.btn_confirm_booking);
            this.Controls.Add(this.txt_room_size);
            this.Controls.Add(this.txt_duration_stay);
            this.Controls.Add(this.txt_room_num);
            this.Controls.Add(this.txt_customer_name);
            this.Controls.Add(this.lblRequiredRoomSize);
            this.Controls.Add(this.lblNumberOfDaysOfStay);
            this.Controls.Add(this.lblNumberOfAllocatedRoom);
            this.Controls.Add(this.lblCustomerFullName);
            this.Controls.Add(this.lst_room_size);
            this.Name = "FrmRoomBookingApplicationWestCoastHotel";
            this.Text = "Room Booking Application - West Coast Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.Label lblNumberOfAllocatedRoom;
        private System.Windows.Forms.Label lblNumberOfDaysOfStay;
        private System.Windows.Forms.Label lblRequiredRoomSize;
        private System.Windows.Forms.TextBox txt_customer_name;
        private System.Windows.Forms.TextBox txt_room_num;
        private System.Windows.Forms.TextBox txt_duration_stay;
        private System.Windows.Forms.TextBox txt_room_size;
        private System.Windows.Forms.Button btn_confirm_booking;
        private System.Windows.Forms.Button btn_display_bookings;
        private System.Windows.Forms.RadioButton rdo_single;
        private System.Windows.Forms.RadioButton rdo_dble;
        private System.Windows.Forms.RadioButton rdo_triple;
        private System.Windows.Forms.ListBox lst_bookings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lst_room_size;
        private System.Windows.Forms.Label lblRoomSize;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}

