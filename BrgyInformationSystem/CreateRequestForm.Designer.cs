namespace BrgyInformationSystem
{
    partial class CreateRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRequestForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlResidentInfo = new System.Windows.Forms.Panel();
            this.lblResidentInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.pnlRequestDetails = new System.Windows.Forms.Panel();
            this.lblRequestDetails = new System.Windows.Forms.Label();
            this.pnlRequestHeader = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoxResidentID = new System.Windows.Forms.TextBox();
            this.txtBoxResidentName = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlResidentInfo.SuspendLayout();
            this.pnlRequestDetails.SuspendLayout();
            this.pnlRequestHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(884, 140);
            this.pnlHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.DarkBlue;
            this.picLogo.FillColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(25, 20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.Location = new System.Drawing.Point(145, 25);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(2, 90);
            this.pnlSeparator.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(175, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(408, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Create Document Request";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.DarkBlue;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(175, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(409, 17);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Select the document you need and provide the required information.";
            // 
            // pnlResidentInfo
            // 
            this.pnlResidentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlResidentInfo.Controls.Add(this.txtBoxAddress);
            this.pnlResidentInfo.Controls.Add(this.txtBoxResidentName);
            this.pnlResidentInfo.Controls.Add(this.txtBoxResidentID);
            this.pnlResidentInfo.Location = new System.Drawing.Point(25, 160);
            this.pnlResidentInfo.Name = "pnlResidentInfo";
            this.pnlResidentInfo.Size = new System.Drawing.Size(850, 120);
            this.pnlResidentInfo.TabIndex = 6;
            // 
            // lblResidentInfo
            // 
            this.lblResidentInfo.AutoSize = true;
            this.lblResidentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblResidentInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentInfo.Location = new System.Drawing.Point(60, 175);
            this.lblResidentInfo.Name = "lblResidentInfo";
            this.lblResidentInfo.Size = new System.Drawing.Size(222, 30);
            this.lblResidentInfo.TabIndex = 7;
            this.lblResidentInfo.Text = "Resident Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resident ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resident Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Document Type:";
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Items.AddRange(new object[] {
            "Barangay Clearance",
            "Certificate of Residency",
            "Certificate of Indigency",
            "Certificate of Scholarship",
            "Certificate of No Pending Case"});
            this.cmbDocumentType.Location = new System.Drawing.Point(250, 295);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(500, 21);
            this.cmbDocumentType.TabIndex = 15;
            // 
            // pnlRequestDetails
            // 
            this.pnlRequestDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlRequestDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRequestDetails.Controls.Add(this.lblInstruction);
            this.pnlRequestDetails.Controls.Add(this.txtPurpose);
            this.pnlRequestDetails.Controls.Add(this.label5);
            this.pnlRequestDetails.Controls.Add(this.pnlRequestHeader);
            this.pnlRequestDetails.Location = new System.Drawing.Point(25, 360);
            this.pnlRequestDetails.Name = "pnlRequestDetails";
            this.pnlRequestDetails.Size = new System.Drawing.Size(850, 210);
            this.pnlRequestDetails.TabIndex = 16;
            // 
            // lblRequestDetails
            // 
            this.lblRequestDetails.AutoSize = true;
            this.lblRequestDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDetails.ForeColor = System.Drawing.Color.White;
            this.lblRequestDetails.Location = new System.Drawing.Point(50, 12);
            this.lblRequestDetails.Name = "lblRequestDetails";
            this.lblRequestDetails.Size = new System.Drawing.Size(163, 30);
            this.lblRequestDetails.TabIndex = 0;
            this.lblRequestDetails.Text = "Request Details";
            // 
            // pnlRequestHeader
            // 
            this.pnlRequestHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.pnlRequestHeader.Controls.Add(this.lblRequestDetails);
            this.pnlRequestHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlRequestHeader.Name = "pnlRequestHeader";
            this.pnlRequestHeader.Size = new System.Drawing.Size(850, 55);
            this.pnlRequestHeader.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Purpose:";
            // 
            // txtPurpose
            // 
            this.txtPurpose.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPurpose.Location = new System.Drawing.Point(200, 75);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(570, 70);
            this.txtPurpose.TabIndex = 2;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.lblInstruction.Location = new System.Drawing.Point(41, 155);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(256, 15);
            this.lblInstruction.TabIndex = 17;
            this.lblInstruction.Text = "Please provide a clear purpose for your request.";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(570, 600);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 45);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(760, 600);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtBoxResidentID
            // 
            this.txtBoxResidentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtBoxResidentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxResidentID.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.txtBoxResidentID.Location = new System.Drawing.Point(38, 80);
            this.txtBoxResidentID.Name = "txtBoxResidentID";
            this.txtBoxResidentID.Size = new System.Drawing.Size(80, 20);
            this.txtBoxResidentID.TabIndex = 26;
            this.txtBoxResidentID.Text = "-";
            // 
            // txtBoxResidentName
            // 
            this.txtBoxResidentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtBoxResidentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxResidentName.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.txtBoxResidentName.Location = new System.Drawing.Point(328, 81);
            this.txtBoxResidentName.Name = "txtBoxResidentName";
            this.txtBoxResidentName.Size = new System.Drawing.Size(102, 20);
            this.txtBoxResidentName.TabIndex = 27;
            this.txtBoxResidentName.Text = "-";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAddress.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.txtBoxAddress.Location = new System.Drawing.Point(618, 81);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(173, 20);
            this.txtBoxAddress.TabIndex = 28;
            this.txtBoxAddress.Text = "-";
            // 
            // CreateRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlRequestDetails);
            this.Controls.Add(this.cmbDocumentType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResidentInfo);
            this.Controls.Add(this.pnlResidentInfo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlHeader);
            this.Name = "CreateRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateRequestForm";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlResidentInfo.ResumeLayout(false);
            this.pnlResidentInfo.PerformLayout();
            this.pnlRequestDetails.ResumeLayout(false);
            this.pnlRequestDetails.PerformLayout();
            this.pnlRequestHeader.ResumeLayout(false);
            this.pnlRequestHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlResidentInfo;
        private System.Windows.Forms.Label lblResidentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.Panel pnlRequestDetails;
        private System.Windows.Forms.Panel pnlRequestHeader;
        private System.Windows.Forms.Label lblRequestDetails;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBoxResidentID;
        private System.Windows.Forms.TextBox txtBoxResidentName;
        private System.Windows.Forms.TextBox txtBoxAddress;
    }
}