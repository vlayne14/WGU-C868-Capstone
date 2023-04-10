namespace SimpleBook
{
    partial class Main
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
			this.mainApptLabel = new System.Windows.Forms.Label();
			this.apptPanel = new System.Windows.Forms.Panel();
			this.mainApptDeleteButton = new System.Windows.Forms.Button();
			this.mainApptModifyButton = new System.Windows.Forms.Button();
			this.mainApptAddButton = new System.Windows.Forms.Button();
			this.mainApptDGV = new System.Windows.Forms.DataGridView();
			this.controlPanel = new System.Windows.Forms.Panel();
			this.apptCustomerButton = new System.Windows.Forms.Button();
			this.controlsLabel = new System.Windows.Forms.Label();
			this.customersButton = new System.Windows.Forms.Button();
			this.viewApptButton = new System.Windows.Forms.Button();
			this.apptTypesButton = new System.Windows.Forms.Button();
			this.consultantScheButton = new System.Windows.Forms.Button();
			this.mainLogOffButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.customerIDRadio = new System.Windows.Forms.RadioButton();
			this.typeRadioButton = new System.Windows.Forms.RadioButton();
			this.dateRadioButton = new System.Windows.Forms.RadioButton();
			this.customerIDLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.startLabel = new System.Windows.Forms.Label();
			this.endLabel = new System.Windows.Forms.Label();
			this.customerIDText = new System.Windows.Forms.TextBox();
			this.typeCombo = new System.Windows.Forms.ComboBox();
			this.startDTP = new System.Windows.Forms.DateTimePicker();
			this.endDTP = new System.Windows.Forms.DateTimePicker();
			this.searchButton = new System.Windows.Forms.Button();
			this.apptPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainApptDGV)).BeginInit();
			this.controlPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(269, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tennnessee Family Medical Care";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// mainApptLabel
			// 
			this.mainApptLabel.AutoSize = true;
			this.mainApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainApptLabel.Location = new System.Drawing.Point(313, 12);
			this.mainApptLabel.Name = "mainApptLabel";
			this.mainApptLabel.Size = new System.Drawing.Size(108, 20);
			this.mainApptLabel.TabIndex = 1;
			this.mainApptLabel.Text = "Appointments";
			// 
			// apptPanel
			// 
			this.apptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.apptPanel.Controls.Add(this.mainApptDeleteButton);
			this.apptPanel.Controls.Add(this.mainApptModifyButton);
			this.apptPanel.Controls.Add(this.mainApptAddButton);
			this.apptPanel.Controls.Add(this.mainApptDGV);
			this.apptPanel.Controls.Add(this.mainApptLabel);
			this.apptPanel.Location = new System.Drawing.Point(31, 55);
			this.apptPanel.Name = "apptPanel";
			this.apptPanel.Size = new System.Drawing.Size(761, 208);
			this.apptPanel.TabIndex = 2;
			// 
			// mainApptDeleteButton
			// 
			this.mainApptDeleteButton.Location = new System.Drawing.Point(663, 162);
			this.mainApptDeleteButton.Name = "mainApptDeleteButton";
			this.mainApptDeleteButton.Size = new System.Drawing.Size(75, 23);
			this.mainApptDeleteButton.TabIndex = 5;
			this.mainApptDeleteButton.Text = "Delete";
			this.mainApptDeleteButton.UseVisualStyleBackColor = true;
			this.mainApptDeleteButton.Click += new System.EventHandler(this.mainApptDeleteButton_Click);
			// 
			// mainApptModifyButton
			// 
			this.mainApptModifyButton.Location = new System.Drawing.Point(582, 162);
			this.mainApptModifyButton.Name = "mainApptModifyButton";
			this.mainApptModifyButton.Size = new System.Drawing.Size(75, 23);
			this.mainApptModifyButton.TabIndex = 4;
			this.mainApptModifyButton.Text = "Modify";
			this.mainApptModifyButton.UseVisualStyleBackColor = true;
			this.mainApptModifyButton.Click += new System.EventHandler(this.mainApptModifyButton_Click);
			// 
			// mainApptAddButton
			// 
			this.mainApptAddButton.Location = new System.Drawing.Point(501, 162);
			this.mainApptAddButton.Name = "mainApptAddButton";
			this.mainApptAddButton.Size = new System.Drawing.Size(75, 23);
			this.mainApptAddButton.TabIndex = 3;
			this.mainApptAddButton.Text = "Add";
			this.mainApptAddButton.UseVisualStyleBackColor = true;
			this.mainApptAddButton.Click += new System.EventHandler(this.mainApptAddButton_Click);
			// 
			// mainApptDGV
			// 
			this.mainApptDGV.AllowUserToAddRows = false;
			this.mainApptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mainApptDGV.Location = new System.Drawing.Point(19, 44);
			this.mainApptDGV.Name = "mainApptDGV";
			this.mainApptDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.mainApptDGV.Size = new System.Drawing.Size(719, 112);
			this.mainApptDGV.TabIndex = 2;
			// 
			// controlPanel
			// 
			this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.controlPanel.Controls.Add(this.apptCustomerButton);
			this.controlPanel.Controls.Add(this.controlsLabel);
			this.controlPanel.Controls.Add(this.customersButton);
			this.controlPanel.Controls.Add(this.viewApptButton);
			this.controlPanel.Controls.Add(this.apptTypesButton);
			this.controlPanel.Controls.Add(this.consultantScheButton);
			this.controlPanel.Location = new System.Drawing.Point(531, 280);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(261, 296);
			this.controlPanel.TabIndex = 4;
			// 
			// apptCustomerButton
			// 
			this.apptCustomerButton.Location = new System.Drawing.Point(19, 246);
			this.apptCustomerButton.Name = "apptCustomerButton";
			this.apptCustomerButton.Size = new System.Drawing.Size(219, 34);
			this.apptCustomerButton.TabIndex = 12;
			this.apptCustomerButton.Text = "Appointments by Patient";
			this.apptCustomerButton.UseVisualStyleBackColor = true;
			this.apptCustomerButton.Click += new System.EventHandler(this.apptCustomerButton_Click);
			// 
			// controlsLabel
			// 
			this.controlsLabel.AutoSize = true;
			this.controlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controlsLabel.Location = new System.Drawing.Point(94, 11);
			this.controlsLabel.Name = "controlsLabel";
			this.controlsLabel.Size = new System.Drawing.Size(68, 20);
			this.controlsLabel.TabIndex = 8;
			this.controlsLabel.Text = "Controls";
			// 
			// customersButton
			// 
			this.customersButton.Location = new System.Drawing.Point(19, 196);
			this.customersButton.Name = "customersButton";
			this.customersButton.Size = new System.Drawing.Size(219, 34);
			this.customersButton.TabIndex = 13;
			this.customersButton.Text = "Patients";
			this.customersButton.UseVisualStyleBackColor = true;
			this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
			// 
			// viewApptButton
			// 
			this.viewApptButton.Location = new System.Drawing.Point(19, 45);
			this.viewApptButton.Name = "viewApptButton";
			this.viewApptButton.Size = new System.Drawing.Size(219, 34);
			this.viewApptButton.TabIndex = 9;
			this.viewApptButton.Text = "View Appointments";
			this.viewApptButton.UseVisualStyleBackColor = true;
			this.viewApptButton.Click += new System.EventHandler(this.viewApptButton_Click);
			// 
			// apptTypesButton
			// 
			this.apptTypesButton.Location = new System.Drawing.Point(19, 96);
			this.apptTypesButton.Name = "apptTypesButton";
			this.apptTypesButton.Size = new System.Drawing.Size(219, 34);
			this.apptTypesButton.TabIndex = 11;
			this.apptTypesButton.Text = "Appointment Types Report";
			this.apptTypesButton.UseVisualStyleBackColor = true;
			this.apptTypesButton.Click += new System.EventHandler(this.apptTypesButton_Click);
			// 
			// consultantScheButton
			// 
			this.consultantScheButton.Location = new System.Drawing.Point(19, 147);
			this.consultantScheButton.Name = "consultantScheButton";
			this.consultantScheButton.Size = new System.Drawing.Size(219, 34);
			this.consultantScheButton.TabIndex = 10;
			this.consultantScheButton.Text = "Consultant Schedule Report";
			this.consultantScheButton.UseVisualStyleBackColor = true;
			this.consultantScheButton.Click += new System.EventHandler(this.consultantScheButton_Click);
			// 
			// mainLogOffButton
			// 
			this.mainLogOffButton.Location = new System.Drawing.Point(630, 594);
			this.mainLogOffButton.Name = "mainLogOffButton";
			this.mainLogOffButton.Size = new System.Drawing.Size(162, 34);
			this.mainLogOffButton.TabIndex = 10;
			this.mainLogOffButton.Text = "Log Off";
			this.mainLogOffButton.UseVisualStyleBackColor = true;
			this.mainLogOffButton.Click += new System.EventHandler(this.mainLogOffButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 308);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "Search Criteria";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(184, 280);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(186, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Search for Appointments";
			// 
			// customerIDRadio
			// 
			this.customerIDRadio.AutoSize = true;
			this.customerIDRadio.Location = new System.Drawing.Point(31, 335);
			this.customerIDRadio.Name = "customerIDRadio";
			this.customerIDRadio.Size = new System.Drawing.Size(83, 17);
			this.customerIDRadio.TabIndex = 13;
			this.customerIDRadio.TabStop = true;
			this.customerIDRadio.Text = "Customer ID";
			this.customerIDRadio.UseVisualStyleBackColor = true;
			this.customerIDRadio.CheckedChanged += new System.EventHandler(this.customerIDRadio_CheckedChanged);
			// 
			// typeRadioButton
			// 
			this.typeRadioButton.AutoSize = true;
			this.typeRadioButton.Location = new System.Drawing.Point(31, 386);
			this.typeRadioButton.Name = "typeRadioButton";
			this.typeRadioButton.Size = new System.Drawing.Size(111, 17);
			this.typeRadioButton.TabIndex = 14;
			this.typeRadioButton.TabStop = true;
			this.typeRadioButton.Text = "Appointment Type";
			this.typeRadioButton.UseVisualStyleBackColor = true;
			this.typeRadioButton.CheckedChanged += new System.EventHandler(this.typeRadioButton_CheckedChanged);
			// 
			// dateRadioButton
			// 
			this.dateRadioButton.AutoSize = true;
			this.dateRadioButton.Location = new System.Drawing.Point(31, 437);
			this.dateRadioButton.Name = "dateRadioButton";
			this.dateRadioButton.Size = new System.Drawing.Size(83, 17);
			this.dateRadioButton.TabIndex = 15;
			this.dateRadioButton.TabStop = true;
			this.dateRadioButton.Text = "Date Range";
			this.dateRadioButton.UseVisualStyleBackColor = true;
			this.dateRadioButton.CheckedChanged += new System.EventHandler(this.dateRadioButton_CheckedChanged);
			// 
			// customerIDLabel
			// 
			this.customerIDLabel.AutoSize = true;
			this.customerIDLabel.Location = new System.Drawing.Point(185, 337);
			this.customerIDLabel.Name = "customerIDLabel";
			this.customerIDLabel.Size = new System.Drawing.Size(65, 13);
			this.customerIDLabel.TabIndex = 16;
			this.customerIDLabel.Text = "Customer ID";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(185, 388);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(93, 13);
			this.typeLabel.TabIndex = 17;
			this.typeLabel.Text = "Appointment Type";
			// 
			// startLabel
			// 
			this.startLabel.AutoSize = true;
			this.startLabel.Location = new System.Drawing.Point(185, 439);
			this.startLabel.Name = "startLabel";
			this.startLabel.Size = new System.Drawing.Size(55, 13);
			this.startLabel.TabIndex = 18;
			this.startLabel.Text = "Start Date";
			// 
			// endLabel
			// 
			this.endLabel.AutoSize = true;
			this.endLabel.Location = new System.Drawing.Point(185, 477);
			this.endLabel.Name = "endLabel";
			this.endLabel.Size = new System.Drawing.Size(52, 13);
			this.endLabel.TabIndex = 19;
			this.endLabel.Text = "End Date";
			// 
			// customerIDText
			// 
			this.customerIDText.Location = new System.Drawing.Point(301, 334);
			this.customerIDText.Name = "customerIDText";
			this.customerIDText.Size = new System.Drawing.Size(100, 20);
			this.customerIDText.TabIndex = 20;
			// 
			// typeCombo
			// 
			this.typeCombo.FormattingEnabled = true;
			this.typeCombo.Location = new System.Drawing.Point(301, 385);
			this.typeCombo.Name = "typeCombo";
			this.typeCombo.Size = new System.Drawing.Size(136, 21);
			this.typeCombo.TabIndex = 21;
			// 
			// startDTP
			// 
			this.startDTP.CustomFormat = "d-MMM-yyy HH:mm:ss tt";
			this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.startDTP.Location = new System.Drawing.Point(301, 437);
			this.startDTP.Name = "startDTP";
			this.startDTP.Size = new System.Drawing.Size(200, 20);
			this.startDTP.TabIndex = 22;
			// 
			// endDTP
			// 
			this.endDTP.CustomFormat = "d-MMM-yyy HH:mm:ss tt";
			this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.endDTP.Location = new System.Drawing.Point(301, 471);
			this.endDTP.Name = "endDTP";
			this.endDTP.Size = new System.Drawing.Size(200, 20);
			this.endDTP.TabIndex = 23;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(198, 542);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(162, 34);
			this.searchButton.TabIndex = 24;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 640);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.endDTP);
			this.Controls.Add(this.startDTP);
			this.Controls.Add(this.typeCombo);
			this.Controls.Add(this.customerIDText);
			this.Controls.Add(this.endLabel);
			this.Controls.Add(this.startLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.customerIDLabel);
			this.Controls.Add(this.dateRadioButton);
			this.Controls.Add(this.typeRadioButton);
			this.Controls.Add(this.customerIDRadio);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mainLogOffButton);
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.apptPanel);
			this.Controls.Add(this.label1);
			this.Name = "Main";
			this.Text = "main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.apptPanel.ResumeLayout(false);
			this.apptPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainApptDGV)).EndInit();
			this.controlPanel.ResumeLayout(false);
			this.controlPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainApptLabel;
        private System.Windows.Forms.Panel apptPanel;
        private System.Windows.Forms.DataGridView mainApptDGV;
        private System.Windows.Forms.Button mainApptDeleteButton;
        private System.Windows.Forms.Button mainApptModifyButton;
        private System.Windows.Forms.Button mainApptAddButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button apptCustomerButton;
        private System.Windows.Forms.Button apptTypesButton;
        private System.Windows.Forms.Button consultantScheButton;
        private System.Windows.Forms.Button viewApptButton;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.Button mainLogOffButton;
		private System.Windows.Forms.Button customersButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton customerIDRadio;
		private System.Windows.Forms.RadioButton typeRadioButton;
		private System.Windows.Forms.RadioButton dateRadioButton;
		private System.Windows.Forms.Label customerIDLabel;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Label startLabel;
		private System.Windows.Forms.Label endLabel;
		private System.Windows.Forms.TextBox customerIDText;
		private System.Windows.Forms.ComboBox typeCombo;
		private System.Windows.Forms.DateTimePicker startDTP;
		private System.Windows.Forms.DateTimePicker endDTP;
		private System.Windows.Forms.Button searchButton;
	}
}