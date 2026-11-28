namespace BrgyInformationSystem
{
    partial class ProcessRequestForm
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
            this.lblProcessingNotes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtProcessingNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnStartProcessing = new Guna.UI2.WinForms.Guna2Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(584, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Process Request";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(28, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(226, 17);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Process the approved document request.";
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
            this.lblRequestIDTitle.Location = new System.Drawing.Point(30, 103);
            this.lblRequestIDTitle.Name = "lblRequestIDTitle";
            this.lblRequestIDTitle.Size = new System.Drawing.Size(74, 17);
            this.lblRequestIDTitle.TabIndex = 4;
            this.lblRequestIDTitle.Text = "Request ID";
            // 
            // lblRequestID
            // 
            this.lblRequestID.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.Location = new System.Drawing.Point(180, 103);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(75, 17);
            this.lblRequestID.TabIndex = 5;
            this.lblRequestID.Text = "requestValue";
            // 
            // lblResidentNameTitle
            // 
            this.lblResidentNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblResidentNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentNameTitle.Location = new System.Drawing.Point(30, 55);
            this.lblResidentNameTitle.Name = "lblResidentNameTitle";
            this.lblResidentNameTitle.Size = new System.Drawing.Size(102, 17);
            this.lblResidentNameTitle.TabIndex = 6;
            this.lblResidentNameTitle.Text = "Resident Name";
            // 
            // lblResidentName
            // 
            this.lblResidentName.BackColor = System.Drawing.Color.Transparent;
            this.lblResidentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentName.Location = new System.Drawing.Point(179, 55);
            this.lblResidentName.Name = "lblResidentName";
            this.lblResidentName.Size = new System.Drawing.Size(78, 17);
            this.lblResidentName.TabIndex = 6;
            this.lblResidentName.Text = "residentValue";
            // 
            // lblDocumentTitle
            // 
            this.lblDocumentTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentTitle.Location = new System.Drawing.Point(30, 90);
            this.lblDocumentTitle.Name = "lblDocumentTitle";
            this.lblDocumentTitle.Size = new System.Drawing.Size(68, 17);
            this.lblDocumentTitle.TabIndex = 7;
            this.lblDocumentTitle.Text = "Document";
            // 
            // lblDocument
            // 
            this.lblDocument.BackColor = System.Drawing.Color.Transparent;
            this.lblDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocument.Location = new System.Drawing.Point(180, 90);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(89, 17);
            this.lblDocument.TabIndex = 8;
            this.lblDocument.Text = "documentValue";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTitle.Location = new System.Drawing.Point(30, 125);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(106, 17);
            this.lblDateTitle.TabIndex = 9;
            this.lblDateTitle.Text = "Date Requested";
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.BackColor = System.Drawing.Color.Transparent;
            this.lblDateRequested.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRequested.Location = new System.Drawing.Point(180, 125);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Size = new System.Drawing.Size(58, 17);
            this.lblDateRequested.TabIndex = 10;
            this.lblDateRequested.Text = "dateValue";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.Location = new System.Drawing.Point(30, 160);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(94, 17);
            this.lblStatusTitle.TabIndex = 11;
            this.lblStatusTitle.Text = "Current Status";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(180, 160);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 17);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "statusValue";
            // 
            // lblProcessingNotes
            // 
            this.lblProcessingNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessingNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessingNotes.Location = new System.Drawing.Point(30, 325);
            this.lblProcessingNotes.Name = "lblProcessingNotes";
            this.lblProcessingNotes.Size = new System.Drawing.Size(126, 18);
            this.lblProcessingNotes.TabIndex = 13;
            this.lblProcessingNotes.Text = "Processing Notes";
            // 
            // txtProcessingNotes
            // 
            this.txtProcessingNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcessingNotes.DefaultText = "";
            this.txtProcessingNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProcessingNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProcessingNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcessingNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcessingNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcessingNotes.Font = new System.Drawing.Font("Webdings", 8.25F);
            this.txtProcessingNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcessingNotes.Location = new System.Drawing.Point(30, 355);
            this.txtProcessingNotes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtProcessingNotes.Multiline = true;
            this.txtProcessingNotes.Name = "txtProcessingNotes";
            this.txtProcessingNotes.PlaceholderText = "";
            this.txtProcessingNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcessingNotes.SelectedText = "";
            this.txtProcessingNotes.Size = new System.Drawing.Size(540, 80);
            this.txtProcessingNotes.TabIndex = 14;
            // 
            // btnStartProcessing
            // 
            this.btnStartProcessing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.btnStartProcessing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartProcessing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartProcessing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartProcessing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartProcessing.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartProcessing.ForeColor = System.Drawing.Color.White;
            this.btnStartProcessing.Location = new System.Drawing.Point(30, 465);
            this.btnStartProcessing.Name = "btnStartProcessing";
            this.btnStartProcessing.Size = new System.Drawing.Size(220, 45);
            this.btnStartProcessing.TabIndex = 15;
            this.btnStartProcessing.Text = "Start Processing";
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.btnCancel.Location = new System.Drawing.Point(270, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            // 
            // ProcessRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 541);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStartProcessing);
            this.Controls.Add(this.txtProcessingNotes);
            this.Controls.Add(this.lblProcessingNotes);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.lblRequestIDTitle);
            this.Controls.Add(this.pnlRequestInfo);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "w";
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDocument;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDocumentTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResidentName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResidentNameTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRequestID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatusTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateRequested;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProcessingNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtProcessingNotes;
        private Guna.UI2.WinForms.Guna2Button btnStartProcessing;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}