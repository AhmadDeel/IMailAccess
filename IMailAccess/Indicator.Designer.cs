namespace IMailAccess
{
    partial class Indicator
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
            this.ListDataGridView = new System.Windows.Forms.DataGridView();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MailNoLabel = new System.Windows.Forms.Label();
            this.MailNoTextBox = new System.Windows.Forms.TextBox();
            this.MailDateLabel = new System.Windows.Forms.Label();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.OrganizationTextbox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DetailsTextBox = new System.Windows.Forms.TextBox();
            this.IsInCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.FirstPageButton = new System.Windows.Forms.Button();
            this.LastPageButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.dateTimeSelector1 = new Atf.UI.DateTimeSelector();
            this.ShowResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListDataGridView
            // 
            this.ListDataGridView.AllowUserToAddRows = false;
            this.ListDataGridView.AllowUserToDeleteRows = false;
            this.ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.ListDataGridView.Location = new System.Drawing.Point(34, 286);
            this.ListDataGridView.MultiSelect = false;
            this.ListDataGridView.Name = "ListDataGridView";
            this.ListDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListDataGridView.RowTemplate.Height = 24;
            this.ListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListDataGridView.Size = new System.Drawing.Size(1050, 373);
            this.ListDataGridView.TabIndex = 16;
            this.ListDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListDataGridView_MouseClick);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SubmitButton.Location = new System.Drawing.Point(1015, 174);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(98, 40);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "ثبت";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UpdateButton.Location = new System.Drawing.Point(862, 174);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(131, 40);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "به روز رسانی";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DeleteButton.Location = new System.Drawing.Point(733, 174);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 40);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MailNoLabel
            // 
            this.MailNoLabel.AutoSize = true;
            this.MailNoLabel.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MailNoLabel.Location = new System.Drawing.Point(1026, 32);
            this.MailNoLabel.Name = "MailNoLabel";
            this.MailNoLabel.Size = new System.Drawing.Size(94, 35);
            this.MailNoLabel.TabIndex = 17;
            this.MailNoLabel.Text = "شماره نامه";
            // 
            // MailNoTextBox
            // 
            this.MailNoTextBox.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MailNoTextBox.Location = new System.Drawing.Point(862, 34);
            this.MailNoTextBox.Name = "MailNoTextBox";
            this.MailNoTextBox.Size = new System.Drawing.Size(158, 33);
            this.MailNoTextBox.TabIndex = 0;
            // 
            // MailDateLabel
            // 
            this.MailDateLabel.AutoSize = true;
            this.MailDateLabel.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MailDateLabel.Location = new System.Drawing.Point(758, 32);
            this.MailDateLabel.Name = "MailDateLabel";
            this.MailDateLabel.Size = new System.Drawing.Size(86, 35);
            this.MailDateLabel.TabIndex = 18;
            this.MailDateLabel.Text = "تاریخ نامه";
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OrganizationLabel.Location = new System.Drawing.Point(1045, 106);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(68, 35);
            this.OrganizationLabel.TabIndex = 20;
            this.OrganizationLabel.Text = "سازمان";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TitleLabel.Location = new System.Drawing.Point(476, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(56, 35);
            this.TitleLabel.TabIndex = 19;
            this.TitleLabel.Text = "عنوان";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DetailsLabel.Location = new System.Drawing.Point(441, 106);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(103, 35);
            this.DetailsLabel.TabIndex = 21;
            this.DetailsLabel.Text = "جزئیات نامه";
            // 
            // OrganizationTextbox
            // 
            this.OrganizationTextbox.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OrganizationTextbox.Location = new System.Drawing.Point(786, 108);
            this.OrganizationTextbox.Name = "OrganizationTextbox";
            this.OrganizationTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrganizationTextbox.Size = new System.Drawing.Size(234, 33);
            this.OrganizationTextbox.TabIndex = 3;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TitleTextBox.Location = new System.Drawing.Point(34, 34);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TitleTextBox.Size = new System.Drawing.Size(436, 33);
            this.TitleTextBox.TabIndex = 2;
            // 
            // DetailsTextBox
            // 
            this.DetailsTextBox.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DetailsTextBox.Location = new System.Drawing.Point(34, 108);
            this.DetailsTextBox.Multiline = true;
            this.DetailsTextBox.Name = "DetailsTextBox";
            this.DetailsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DetailsTextBox.Size = new System.Drawing.Size(401, 111);
            this.DetailsTextBox.TabIndex = 5;
            // 
            // IsInCheckBox
            // 
            this.IsInCheckBox.AutoSize = true;
            this.IsInCheckBox.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.IsInCheckBox.Location = new System.Drawing.Point(562, 105);
            this.IsInCheckBox.Name = "IsInCheckBox";
            this.IsInCheckBox.Size = new System.Drawing.Size(190, 39);
            this.IsInCheckBox.TabIndex = 4;
            this.IsInCheckBox.Text = "آیا نامه دریافتی است";
            this.IsInCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ClearButton.Location = new System.Drawing.Point(482, 174);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(200, 40);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "پاک کردن فیلد ها";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchTextBox.Location = new System.Drawing.Point(706, 241);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(158, 33);
            this.SearchTextBox.TabIndex = 10;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchButton.Location = new System.Drawing.Point(549, 236);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(116, 40);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchLabel.Location = new System.Drawing.Point(890, 239);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(223, 35);
            this.SearchLabel.TabIndex = 22;
            this.SearchLabel.Text = "جستجو بر اساس شماره نامه";
            // 
            // FirstPageButton
            // 
            this.FirstPageButton.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FirstPageButton.Location = new System.Drawing.Point(71, 668);
            this.FirstPageButton.Name = "FirstPageButton";
            this.FirstPageButton.Size = new System.Drawing.Size(116, 40);
            this.FirstPageButton.TabIndex = 12;
            this.FirstPageButton.Text = "صفحه اول";
            this.FirstPageButton.UseVisualStyleBackColor = true;
            this.FirstPageButton.Click += new System.EventHandler(this.FirstPageButton_Click);
            // 
            // LastPageButton
            // 
            this.LastPageButton.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastPageButton.Location = new System.Drawing.Point(921, 668);
            this.LastPageButton.Name = "LastPageButton";
            this.LastPageButton.Size = new System.Drawing.Size(116, 40);
            this.LastPageButton.TabIndex = 15;
            this.LastPageButton.Text = "صفحه آخر";
            this.LastPageButton.UseVisualStyleBackColor = true;
            this.LastPageButton.Click += new System.EventHandler(this.LastPageButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NextPageButton.Location = new System.Drawing.Point(782, 668);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(93, 40);
            this.NextPageButton.TabIndex = 14;
            this.NextPageButton.Text = ">";
            this.NextPageButton.UseVisualStyleBackColor = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PreviousPageButton.Location = new System.Drawing.Point(238, 668);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(93, 40);
            this.PreviousPageButton.TabIndex = 13;
            this.PreviousPageButton.Text = "<";
            this.PreviousPageButton.UseVisualStyleBackColor = true;
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PageLabel.Location = new System.Drawing.Point(556, 669);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(0, 35);
            this.PageLabel.TabIndex = 24;
            // 
            // dateTimeSelector1
            // 
            this.dateTimeSelector1.Location = new System.Drawing.Point(595, 34);
            this.dateTimeSelector1.Name = "dateTimeSelector1";
            this.dateTimeSelector1.Size = new System.Drawing.Size(157, 28);
            this.dateTimeSelector1.TabIndex = 1;
            // 
            // ShowResultLabel
            // 
            this.ShowResultLabel.AutoSize = true;
            this.ShowResultLabel.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowResultLabel.Location = new System.Drawing.Point(244, 242);
            this.ShowResultLabel.Name = "ShowResultLabel";
            this.ShowResultLabel.Size = new System.Drawing.Size(0, 35);
            this.ShowResultLabel.TabIndex = 23;
            // 
            // Indicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 713);
            this.Controls.Add(this.ShowResultLabel);
            this.Controls.Add(this.dateTimeSelector1);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.PreviousPageButton);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.LastPageButton);
            this.Controls.Add(this.FirstPageButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.IsInCheckBox);
            this.Controls.Add(this.DetailsTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.OrganizationTextbox);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.OrganizationLabel);
            this.Controls.Add(this.MailDateLabel);
            this.Controls.Add(this.MailNoTextBox);
            this.Controls.Add(this.MailNoLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ListDataGridView);
            this.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Indicator";
            this.Text = "برنامه ثبت نامه";
            this.Load += new System.EventHandler(this.Indicator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListDataGridView;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label MailNoLabel;
        private System.Windows.Forms.TextBox MailNoTextBox;
        private System.Windows.Forms.Label MailDateLabel;
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.TextBox OrganizationTextbox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DetailsTextBox;
        private System.Windows.Forms.CheckBox IsInCheckBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button FirstPageButton;
        private System.Windows.Forms.Button LastPageButton;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.Label PageLabel;
        private Atf.UI.DateTimeSelector dateTimeSelector1;
        private System.Windows.Forms.Label ShowResultLabel;
    }
}