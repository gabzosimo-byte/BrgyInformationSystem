namespace BrgyInformationSystem
{
    partial class MarkReleasedForm
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
            this.lblReleaseInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblReleasedTo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtReleasedTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblReleaseNotes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtReleaseNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlRequestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(584, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Release Document Request";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(28, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(265, 17);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Confirm the release of the completed document.";
            // 
            // pnlRequestInfo
            // 
            this.pnlRequestInfo.Controls.Add(this.lblStatus);
            this.pnlRequestInfo.Controls.Add(this.lblStatusTitle);
            this.pnlRequestInfo.Controls.Add(this.lblDateRequested);
            this.pnlRequestInfo.Controls.Add(this.lblDateTitle);
            this.pnlRequestInfo.Controls.Add(this.lblDocument);
            this.pnlRequestInfo.Controls.Add(this.lblDocumentTitle);
            this.pnlRequestInfo.Controls.Add(this.lblResidentName);
            this.pnlRequestInfo.Controls.Add(this.lblResidentNameTitle);
            this.pnlRequestInfo.Controls.Add(this.lblRequestID);
            this.pnlRequestInfo.Controls.Add(this.lblRequestIDTitle);
            this.pnlRequestInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRequestInfo.Location = new System.Drawing.Point(0, 85);
            this.pnlRequestInfo.Name = "pnlRequestInfo";
            this.pnlRequestInfo.Size = new System.Drawing.Size(584, 220);
            this.pnlRequestInfo.TabIndex = 3;
            // 
            // lblRequestIDTitle
            // 
            this.lblRequestIDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestIDTitle.Location = new System.Drawing.Point(30, 20);
            this.lblRequestIDTitle.Name = "lblRequestIDTitle";
            this.lblRequestIDTitle.Size = new System.Drawing.Size(74, 17);
            this.lblRequestIDTitle.TabIndex = 0;
            this.lblRequestIDTitle.Text = "Request ID";
            // 
            // lblRequestID
            // 
            this.lblRequestID.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.Location = new System.Drawing.Point(180, 20);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(92, 17);
            this.lblRequestID.TabIndex = 1;
            this.lblRequestID.Text = "RequestIDValue";
            // 
            // lblResidentNameTitle
            // 
            this.lblResidentNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblResidentNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentNameTitle.Location = new System.Drawing.Point(30, 55);
            this.lblResidentNameTitle.Name = "lblResidentNameTitle";
            this.lblResidentNameTitle.Size = new System.Drawing.Size(102, 17);
            this.lblResidentNameTitle.TabIndex = 2;
            this.lblResidentNameTitle.Text = "Resident Name";
            // 
            // lblResidentName
            // 
            this.lblResidentName.BackColor = System.Drawing.Color.Transparent;
            this.lblResidentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentName.Location = new System.Drawing.Point(180, 55);
            this.lblResidentName.Name = "lblResidentName";
            this.lblResidentName.Size = new System.Drawing.Size(117, 17);
            this.lblResidentName.TabIndex = 3;
            this.lblResidentName.Text = "ResidentNameValue";
            // 
            // lblDocumentTitle
            // 
            this.lblDocumentTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentTitle.Location = new System.Drawing.Point(30, 90);
            this.lblDocumentTitle.Name = "lblDocumentTitle";
            this.lblDocumentTitle.Size = new System.Drawing.Size(68, 17);
            this.lblDocumentTitle.TabIndex = 4;
            this.lblDocumentTitle.Text = "Document";
            // 
            // lblDocument
            // 
            this.lblDocument.BackColor = System.Drawing.Color.Transparent;
            this.lblDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocument.Location = new System.Drawing.Point(180, 90);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(91, 17);
            this.lblDocument.TabIndex = 5;
            this.lblDocument.Text = "DocumentValue";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTitle.Location = new System.Drawing.Point(30, 125);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(106, 17);
            this.lblDateTitle.TabIndex = 6;
            this.lblDateTitle.Text = "Date Requested";
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.BackColor = System.Drawing.Color.Transparent;
            this.lblDateRequested.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRequested.Location = new System.Drawing.Point(180, 125);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Size = new System.Drawing.Size(60, 17);
            this.lblDateRequested.TabIndex = 7;
            this.lblDateRequested.Text = "DateValue";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.Location = new System.Drawing.Point(30, 160);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(94, 17);
            this.lblStatusTitle.TabIndex = 8;
            this.lblStatusTitle.Text = "Current Status";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.lblStatus.Location = new System.Drawing.Point(180, 160);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 17);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "StatusValue";
            // 
            // lblReleaseInfo
            // 
            this.lblReleaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblReleaseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseInfo.Location = new System.Drawing.Point(30, 325);
            this.lblReleaseInfo.Name = "lblReleaseInfo";
            this.lblReleaseInfo.Size = new System.Drawing.Size(142, 18);
            this.lblReleaseInfo.TabIndex = 10;
            this.lblReleaseInfo.Text = "Release Information";
            // 
            // lblReleasedTo
            // 
            this.lblReleasedTo.BackColor = System.Drawing.Color.Transparent;
            this.lblReleasedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleasedTo.Location = new System.Drawing.Point(30, 360);
            this.lblReleasedTo.Name = "lblReleasedTo";
            this.lblReleasedTo.Size = new System.Drawing.Size(94, 18);
            this.lblReleasedTo.TabIndex = 11;
            this.lblReleasedTo.Text = "Released To";
            // 
            // txtReleasedTo
            // 
            this.txtReleasedTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReleasedTo.DefaultText = "";
            this.txtReleasedTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReleasedTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReleasedTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReleasedTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReleasedTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReleasedTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReleasedTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReleasedTo.Location = new System.Drawing.Point(180, 355);
            this.txtReleasedTo.Name = "txtReleasedTo";
            this.txtReleasedTo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtReleasedTo.PlaceholderText = "Enter recipient name";
            this.txtReleasedTo.SelectedText = "";
            this.txtReleasedTo.Size = new System.Drawing.Size(390, 30);
            this.txtReleasedTo.TabIndex = 12;
            // 
            // lblReleaseNotes
            // 
            this.lblReleaseNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblReleaseNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseNotes.Location = new System.Drawing.Point(30, 405);
            this.lblReleaseNotes.Name = "lblReleaseNotes";
            this.lblReleaseNotes.Size = new System.Drawing.Size(107, 18);
            this.lblReleaseNotes.TabIndex = 13;
            this.lblReleaseNotes.Text = "Release Notes";
            // 
            // txtReleaseNotes
            // 
            this.txtReleaseNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReleaseNotes.DefaultText = "";
            this.txtReleaseNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReleaseNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReleaseNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReleaseNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReleaseNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReleaseNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReleaseNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReleaseNotes.Location = new System.Drawing.Point(30, 435);
            this.txtReleaseNotes.Multiline = true;
            this.txtReleaseNotes.Name = "txtReleaseNotes";
            this.txtReleaseNotes.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtReleaseNotes.PlaceholderText = "Enter release notes (optional)";
            this.txtReleaseNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReleaseNotes.SelectedText = "";
            this.txtReleaseNotes.Size = new System.Drawing.Size(540, 65);
            this.txtReleaseNotes.TabIndex = 14;
            // 
            // MarkReleasedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.txtReleaseNotes);
            this.Controls.Add(this.lblReleaseNotes);
            this.Controls.Add(this.txtReleasedTo);
            this.Controls.Add(this.lblReleasedTo);
            this.Controls.Add(this.lblReleaseInfo);
            this.Controls.Add(this.pnlRequestInfo);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarkReleasedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkReleasedForm";
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResidentName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResidentNameTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRequestID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRequestIDTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDocumentTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateRequested;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDocument;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatusTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReleaseInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReleasedTo;
        private Guna.UI2.WinForms.Guna2TextBox txtReleasedTo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReleaseNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtReleaseNotes;
    }
}