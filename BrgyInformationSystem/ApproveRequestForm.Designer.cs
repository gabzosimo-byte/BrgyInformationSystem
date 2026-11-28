namespace BrgyInformationSystem
{
    partial class ApproveRequestForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRequestInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRequestIDTitle = new System.Windows.Forms.Label();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.lblResidentNameTitle = new System.Windows.Forms.Label();
            this.lblResidentName = new System.Windows.Forms.Label();
            this.lblDocumentTitle = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblDateRequested = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnApprove = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.pnlRequestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(584, 85);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Approve Request";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Review and approve the selected document request";
            // 
            // pnlRequestInfo
            // 
            this.pnlRequestInfo.Controls.Add(this.lblStatus);
            this.pnlRequestInfo.Controls.Add(this.lblDateRequested);
            this.pnlRequestInfo.Controls.Add(this.lblStatusTitle);
            this.pnlRequestInfo.Controls.Add(this.lblDocument);
            this.pnlRequestInfo.Controls.Add(this.lblResidentName);
            this.pnlRequestInfo.Controls.Add(this.lblDocumentTitle);
            this.pnlRequestInfo.Controls.Add(this.lblDateTitle);
            this.pnlRequestInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRequestInfo.Location = new System.Drawing.Point(0, 85);
            this.pnlRequestInfo.Name = "pnlRequestInfo";
            this.pnlRequestInfo.Size = new System.Drawing.Size(584, 220);
            this.pnlRequestInfo.TabIndex = 2;
            // 
            // lblRequestIDTitle
            // 
            this.lblRequestIDTitle.AutoSize = true;
            this.lblRequestIDTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestIDTitle.Location = new System.Drawing.Point(30, 113);
            this.lblRequestIDTitle.Name = "lblRequestIDTitle";
            this.lblRequestIDTitle.Size = new System.Drawing.Size(79, 17);
            this.lblRequestIDTitle.TabIndex = 3;
            this.lblRequestIDTitle.Text = "Request ID:";
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.Location = new System.Drawing.Point(160, 114);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(98, 17);
            this.lblRequestID.TabIndex = 4;
            this.lblRequestID.Text = "RequestIDValue";
            // 
            // lblResidentNameTitle
            // 
            this.lblResidentNameTitle.AutoSize = true;
            this.lblResidentNameTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentNameTitle.Location = new System.Drawing.Point(30, 150);
            this.lblResidentNameTitle.Name = "lblResidentNameTitle";
            this.lblResidentNameTitle.Size = new System.Drawing.Size(105, 17);
            this.lblResidentNameTitle.TabIndex = 5;
            this.lblResidentNameTitle.Text = "Resident Name:";
            // 
            // lblResidentName
            // 
            this.lblResidentName.AutoSize = true;
            this.lblResidentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentName.Location = new System.Drawing.Point(160, 65);
            this.lblResidentName.Name = "lblResidentName";
            this.lblResidentName.Size = new System.Drawing.Size(124, 17);
            this.lblResidentName.TabIndex = 6;
            this.lblResidentName.Text = "ResidentNameValue";
            // 
            // lblDocumentTitle
            // 
            this.lblDocumentTitle.AutoSize = true;
            this.lblDocumentTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentTitle.Location = new System.Drawing.Point(30, 105);
            this.lblDocumentTitle.Name = "lblDocumentTitle";
            this.lblDocumentTitle.Size = new System.Drawing.Size(76, 17);
            this.lblDocumentTitle.TabIndex = 6;
            this.lblDocumentTitle.Text = "Document:";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTitle.Location = new System.Drawing.Point(30, 145);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(109, 17);
            this.lblDateTitle.TabIndex = 7;
            this.lblDateTitle.Text = "Date Requested:";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.Location = new System.Drawing.Point(30, 186);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(100, 17);
            this.lblStatusTitle.TabIndex = 8;
            this.lblStatusTitle.Text = "Current Status:";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocument.Location = new System.Drawing.Point(160, 105);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(98, 17);
            this.lblDocument.TabIndex = 7;
            this.lblDocument.Text = "DocumentValue";
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.AutoSize = true;
            this.lblDateRequested.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRequested.Location = new System.Drawing.Point(160, 145);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Size = new System.Drawing.Size(101, 17);
            this.lblDateRequested.TabIndex = 8;
            this.lblDateRequested.Text = "RequestedValue";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(160, 186);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 17);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "StatusValue";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(30, 325);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(60, 17);
            this.lblRemarks.TabIndex = 10;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemarks.DefaultText = "";
            this.txtRemarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRemarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRemarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRemarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRemarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRemarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRemarks.Location = new System.Drawing.Point(30, 350);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtRemarks.PlaceholderText = "Enter remarks (optional)";
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.Size = new System.Drawing.Size(540, 70);
            this.txtRemarks.TabIndex = 11;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(185)))));
            this.btnApprove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApprove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApprove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApprove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(30, 450);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(220, 45);
            this.btnApprove.TabIndex = 12;
            this.btnApprove.Text = "Approve Request";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(185)))));
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.btnCancel.Location = new System.Drawing.Point(270, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            // 
            // ApproveRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblResidentNameTitle);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.lblRequestIDTitle);
            this.Controls.Add(this.pnlRequestInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApproveRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApproveRequestForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlRequestInfo.ResumeLayout(false);
            this.pnlRequestInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnlRequestInfo;
        private System.Windows.Forms.Label lblResidentName;
        private System.Windows.Forms.Label lblRequestIDTitle;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Label lblResidentNameTitle;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Label lblDocumentTitle;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblDateRequested;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRemarks;
        private Guna.UI2.WinForms.Guna2TextBox txtRemarks;
        private Guna.UI2.WinForms.Guna2Button btnApprove;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}