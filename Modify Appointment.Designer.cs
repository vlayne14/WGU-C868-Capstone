
namespace SimpleBook
{
	partial class Modify_Appointment
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
			this.addApptIDLabel = new System.Windows.Forms.Label();
			this.customerIDComboBox = new System.Windows.Forms.ComboBox();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.endDatePicker = new System.Windows.Forms.DateTimePicker();
			this.startDatePicker = new System.Windows.Forms.DateTimePicker();
			this.modifyApptCloseButton = new System.Windows.Forms.Button();
			this.modifyApptSaveButton = new System.Windows.Forms.Button();
			this.endTimeLabel = new System.Windows.Forms.Label();
			this.startTimeLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.titleText = new System.Windows.Forms.TextBox();
			this.titleLabel = new System.Windows.Forms.Label();
			this.customerIDLabel = new System.Windows.Forms.Label();
			this.apptIDLabel = new System.Windows.Forms.Label();
			this.modifyApptLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addApptIDLabel
			// 
			this.addApptIDLabel.AutoSize = true;
			this.addApptIDLabel.Location = new System.Drawing.Point(150, 72);
			this.addApptIDLabel.Name = "addApptIDLabel";
			this.addApptIDLabel.Size = new System.Drawing.Size(0, 13);
			this.addApptIDLabel.TabIndex = 54;
			// 
			// customerIDComboBox
			// 
			this.customerIDComboBox.FormattingEnabled = true;
			this.customerIDComboBox.Location = new System.Drawing.Point(153, 103);
			this.customerIDComboBox.Name = "customerIDComboBox";
			this.customerIDComboBox.Size = new System.Drawing.Size(194, 21);
			this.customerIDComboBox.TabIndex = 53;
			// 
			// typeComboBox
			// 
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Location = new System.Drawing.Point(153, 171);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(194, 21);
			this.typeComboBox.TabIndex = 52;
			// 
			// endDatePicker
			// 
			this.endDatePicker.CustomFormat = "d-MMM-yyy HH:mm:ss tt";
			this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.endDatePicker.Location = new System.Drawing.Point(153, 243);
			this.endDatePicker.Name = "endDatePicker";
			this.endDatePicker.ShowUpDown = true;
			this.endDatePicker.Size = new System.Drawing.Size(194, 20);
			this.endDatePicker.TabIndex = 51;
			this.endDatePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.endDatePicker_KeyPress);
			// 
			// startDatePicker
			// 
			this.startDatePicker.AllowDrop = true;
			this.startDatePicker.CustomFormat = "d-MMM-yyy HH:mm:ss tt";
			this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.startDatePicker.Location = new System.Drawing.Point(153, 208);
			this.startDatePicker.Name = "startDatePicker";
			this.startDatePicker.ShowUpDown = true;
			this.startDatePicker.Size = new System.Drawing.Size(194, 20);
			this.startDatePicker.TabIndex = 50;
			this.startDatePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startDatePicker_KeyPress);
			// 
			// modifyApptCloseButton
			// 
			this.modifyApptCloseButton.Location = new System.Drawing.Point(258, 287);
			this.modifyApptCloseButton.Name = "modifyApptCloseButton";
			this.modifyApptCloseButton.Size = new System.Drawing.Size(89, 26);
			this.modifyApptCloseButton.TabIndex = 49;
			this.modifyApptCloseButton.Text = "Close";
			this.modifyApptCloseButton.UseVisualStyleBackColor = true;
			this.modifyApptCloseButton.Click += new System.EventHandler(this.modifyApptCloseButton_Click);
			// 
			// modifyApptSaveButton
			// 
			this.modifyApptSaveButton.Location = new System.Drawing.Point(153, 287);
			this.modifyApptSaveButton.Name = "modifyApptSaveButton";
			this.modifyApptSaveButton.Size = new System.Drawing.Size(99, 26);
			this.modifyApptSaveButton.TabIndex = 48;
			this.modifyApptSaveButton.Text = "Save";
			this.modifyApptSaveButton.UseVisualStyleBackColor = true;
			this.modifyApptSaveButton.Click += new System.EventHandler(this.modifyApptSaveButton_Click);
			// 
			// endTimeLabel
			// 
			this.endTimeLabel.AutoSize = true;
			this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.endTimeLabel.Location = new System.Drawing.Point(27, 247);
			this.endTimeLabel.Name = "endTimeLabel";
			this.endTimeLabel.Size = new System.Drawing.Size(66, 16);
			this.endTimeLabel.TabIndex = 47;
			this.endTimeLabel.Text = "End Time";
			// 
			// startTimeLabel
			// 
			this.startTimeLabel.AutoSize = true;
			this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startTimeLabel.Location = new System.Drawing.Point(27, 212);
			this.startTimeLabel.Name = "startTimeLabel";
			this.startTimeLabel.Size = new System.Drawing.Size(69, 16);
			this.startTimeLabel.TabIndex = 46;
			this.startTimeLabel.Text = "Start Time";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.typeLabel.Location = new System.Drawing.Point(27, 176);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(40, 16);
			this.typeLabel.TabIndex = 45;
			this.typeLabel.Text = "Type";
			// 
			// titleText
			// 
			this.titleText.Location = new System.Drawing.Point(153, 138);
			this.titleText.Name = "titleText";
			this.titleText.Size = new System.Drawing.Size(194, 20);
			this.titleText.TabIndex = 44;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(27, 142);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(34, 16);
			this.titleLabel.TabIndex = 43;
			this.titleLabel.Text = "Title";
			// 
			// customerIDLabel
			// 
			this.customerIDLabel.AutoSize = true;
			this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerIDLabel.Location = new System.Drawing.Point(27, 108);
			this.customerIDLabel.Name = "customerIDLabel";
			this.customerIDLabel.Size = new System.Drawing.Size(68, 16);
			this.customerIDLabel.TabIndex = 42;
			this.customerIDLabel.Text = "Customer ";
			// 
			// apptIDLabel
			// 
			this.apptIDLabel.AutoSize = true;
			this.apptIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apptIDLabel.Location = new System.Drawing.Point(27, 69);
			this.apptIDLabel.Name = "apptIDLabel";
			this.apptIDLabel.Size = new System.Drawing.Size(99, 16);
			this.apptIDLabel.TabIndex = 41;
			this.apptIDLabel.Text = "Appointment ID";
			// 
			// modifyApptLabel
			// 
			this.modifyApptLabel.AutoSize = true;
			this.modifyApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifyApptLabel.Location = new System.Drawing.Point(131, 13);
			this.modifyApptLabel.Name = "modifyApptLabel";
			this.modifyApptLabel.Size = new System.Drawing.Size(168, 20);
			this.modifyApptLabel.TabIndex = 40;
			this.modifyApptLabel.Text = "Modify Appointment";
			// 
			// Modify_Appointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 326);
			this.Controls.Add(this.addApptIDLabel);
			this.Controls.Add(this.customerIDComboBox);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.endDatePicker);
			this.Controls.Add(this.startDatePicker);
			this.Controls.Add(this.modifyApptCloseButton);
			this.Controls.Add(this.modifyApptSaveButton);
			this.Controls.Add(this.endTimeLabel);
			this.Controls.Add(this.startTimeLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.titleText);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.customerIDLabel);
			this.Controls.Add(this.apptIDLabel);
			this.Controls.Add(this.modifyApptLabel);
			this.Name = "Modify_Appointment";
			this.Text = "Modify_Appointment";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Modify_Appointment_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label addApptIDLabel;
		public System.Windows.Forms.ComboBox customerIDComboBox;
		public System.Windows.Forms.ComboBox typeComboBox;
		public System.Windows.Forms.DateTimePicker endDatePicker;
		public System.Windows.Forms.DateTimePicker startDatePicker;
		private System.Windows.Forms.Button modifyApptCloseButton;
		private System.Windows.Forms.Button modifyApptSaveButton;
		private System.Windows.Forms.Label endTimeLabel;
		private System.Windows.Forms.Label startTimeLabel;
		private System.Windows.Forms.Label typeLabel;
		public System.Windows.Forms.TextBox titleText;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label customerIDLabel;
		private System.Windows.Forms.Label apptIDLabel;
		public System.Windows.Forms.Label modifyApptLabel;
	}
}