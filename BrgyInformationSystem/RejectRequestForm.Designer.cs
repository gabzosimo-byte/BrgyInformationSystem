namespace BrgyInformationSystem
{
    partial class RejectRequestForm
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlRequestInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRequestIDTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRequestID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblResidentNameTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblResidentName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDocumentTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDocument = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDateTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDateRequested = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblStatusTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblReason = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtRejectionReason = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReject = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRequestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(584, 108);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 39);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Reject Request";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(32, 61);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(285, 17);
            this.lblSubtitle.TabIndex = 3;
            this.lblSubtitle.Text = "Review the request and provide a reason for rejection.";
            // 
            // pnlRequestInfo
            // 
            this.pnlRequestInfo.Controls.Add(this.lblStatus);
            this.pnlRequestInfo.Controls.Add(this.lblStatusTitle);
            this.pnlRequestInfo.Controls.Add(this.lblDateRequested);
            this.pnlRequestInfo.Controls.Add(this.lblDateTitle);
            this.pnlRequestInfo.Controls.Add(this.lblDocumentTitle);
            this.pnlRequestInfo.Controls.Add(this.lblDocument);
            this.pnlRequestInfo.Controls.Add(this.lblResidentNameTitle);
            this.pnlRequestInfo.Controls.Add(this.lblResidentName);
            this.pnlRequestInfo.Controls.Add(this.lblRequestID);
            this.pnlRequestInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRequestInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRequestInfo.Location = new System.Drawing.Point(0, 108);
            this.pnlRequestInfo.Name = "pnlRequestInfo";
            this.pnlRequestInfo.Size = new System.Drawing.Size(584, 220);
            this.pnlRequestInfo.TabIndex = 4;
            // 
            // lblRequestIDTitle
            // 
            this.lblRequestIDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestIDTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestIDTitle.Location = new System.Drawing.Point(30, 136);
            this.lblRequestIDTitle.Name = "lblRequestIDTitle";
            this.lblRequestIDTitle.Size = new System.Drawing.Size(74, 19);
            this.lblRequestIDTitle.TabIndex = 5;
            this.lblRequestIDTitle.Text = "Request ID:";
            // 
            // lblRequestID
            // 
            this.lblRequestID.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.Location = new System.Drawing.Point(160, 25);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(91, 19);
            this.lblRequestID.TabIndex = 0;
            this.lblRequestID.Text = "requestIDValue";
            // 
            // lblResidentNameTitle
            // 
            this.lblResidentNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblResidentNameTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentNameTitle.Location = new System.Drawing.Point(30, 67);
            this.lblResidentNameTitle.Name = "lblResidentNameTitle";
            this.lblResidentNameTitle.Size = new System.Drawing.Size(100, 19);
            this.lblResidentNameTitle.TabIndex = 6;
            this.lblResidentNameTitle.Text = "Resident Name:";
            // 
            // lblResidentName
            // 
            this.lblResidentName.BackColor = System.Drawing.Color.Transparent;
            this.lblResidentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentName.Location = new System.Drawing.Point(160, 65);
            this.lblResidentName.Name = "lblResidentName";
            this.lblResidentName.Size = new System.Drawing.Size(82, 19);
            this.lblResidentName.TabIndex = 1;
            this.lblResidentName.Text = "residentValue";
            // 
            // lblDocumentTitle
            // 
            this.lblDocumentTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumentTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentTitle.Location = new System.Drawing.Point(30, 105);
            this.lblDocumentTitle.Name = "lblDocumentTitle";
            this.lblDocumentTitle.Size = new System.Drawing.Size(71, 19);
            this.lblDocumentTitle.TabIndex = 7;
            this.lblDocumentTitle.Text = "Document:";
            // 
            // lblDocument
            // 
            this.lblDocument.BackColor = System.Drawing.Color.Transparent;
            this.lblDocument.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocument.Location = new System.Drawing.Point(160, 105);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(93, 19);
            this.lblDocument.TabIndex = 2;
            this.lblDocument.Text = "documentValue";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTitle.Location = new System.Drawing.Point(30, 144);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(104, 19);
            this.lblDateTitle.TabIndex = 8;
            this.lblDateTitle.Text = "Date Requested:";
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.BackColor = System.Drawing.Color.Transparent;
            this.lblDateRequested.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRequested.Location = new System.Drawing.Point(160, 145);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Size = new System.Drawing.Size(94, 19);
            this.lblDateRequested.TabIndex = 9;
            this.lblDateRequested.Text = "requestedValue";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.Location = new System.Drawing.Point(32, 186);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(95, 19);
            this.lblStatusTitle.TabIndex = 10;
            this.lblStatusTitle.Text = "Current Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(164, 186);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 19);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "statusValue";
            // 
            // lblReason
            // 
            this.lblReason.BackColor = System.Drawing.Color.Transparent;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(30, 339);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(130, 19);
            this.lblReason.TabIndex = 12;
            this.lblReason.Text = "Reason for Rejection";
            // 
            // txtRejectionReason
            // 
            this.txtRejectionReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRejectionReason.DefaultText = "";
            this.txtRejectionReason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRejectionReason.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRejectionReason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRejectionReason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRejectionReason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRejectionReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRejectionReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRejectionReason.Location = new System.Drawing.Point(30, 360);
            this.txtRejectionReason.Multiline = true;
            this.txtRejectionReason.Name = "txtRejectionReason";
            this.txtRejectionReason.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtRejectionReason.PlaceholderText = "Enter the reason for rejecting this request.";
            this.txtRejectionReason.SelectedText = "";
            this.txtRejectionReason.Size = new System.Drawing.Size(540, 90);
            this.txtRejectionReason.TabIndex = 14;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnReject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(30, 470);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(220, 45);
            this.btnReject.TabIndex = 15;
            this.btnReject.Text = "Reject Request";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.btnCancel.Location = new System.Drawing.Point(270, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            // 
            // RejectRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 541);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.txtRejectionReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblRequestIDTitle);
            this.Controls.Add(this.pnlRequestInfo);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RejectRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RejectRequestForm";
            this.pnlRequestInfo.ResumeLayout(false);
            this.pnlRequestInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2Panel pnlRequestInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRequestIDTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResidentName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRequestID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResidentNameTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateRequested;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDocumentTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDocument;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatusTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReason;
        private Guna.UI2.WinForms.Guna2TextBox txtRejectionReason;
        private Guna.UI2.WinForms.Guna2Button btnReject;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}