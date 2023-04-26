namespace WindowsFormsApp9
{
    partial class MainForm
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
            this.AdditionalInformation = new System.Windows.Forms.Label();
            this.FamilyStatus = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UserAdditionalInformation = new System.Windows.Forms.ComboBox();
            this.UserFamilyStatus = new System.Windows.Forms.ComboBox();
            this.UserYear = new System.Windows.Forms.ComboBox();
            this.UserMonth = new System.Windows.Forms.ComboBox();
            this.UserDay = new System.Windows.Forms.ComboBox();
            this.YearAndDateLabel = new System.Windows.Forms.Label();
            this.UserGender = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.UserPatronymic = new System.Windows.Forms.TextBox();
            this.UserSurname = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AdditionalInformation
            // 
            this.AdditionalInformation.AutoSize = true;
            this.AdditionalInformation.Location = new System.Drawing.Point(30, 315);
            this.AdditionalInformation.Name = "AdditionalInformation";
            this.AdditionalInformation.Size = new System.Drawing.Size(160, 13);
            this.AdditionalInformation.TabIndex = 29;
            this.AdditionalInformation.Text = "Дополнительная информация";
            // 
            // FamilyStatus
            // 
            this.FamilyStatus.AutoSize = true;
            this.FamilyStatus.Location = new System.Drawing.Point(30, 244);
            this.FamilyStatus.Name = "FamilyStatus";
            this.FamilyStatus.Size = new System.Drawing.Size(96, 13);
            this.FamilyStatus.TabIndex = 28;
            this.FamilyStatus.Text = "Семейный статус";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(165, 383);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(88, 23);
            this.LoadButton.TabIndex = 27;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(33, 383);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 23);
            this.SaveButton.TabIndex = 26;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UserAdditionalInformation
            // 
            this.UserAdditionalInformation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.UserAdditionalInformation.FormattingEnabled = true;
            this.UserAdditionalInformation.Location = new System.Drawing.Point(32, 330);
            this.UserAdditionalInformation.Name = "UserAdditionalInformation";
            this.UserAdditionalInformation.Size = new System.Drawing.Size(221, 21);
            this.UserAdditionalInformation.TabIndex = 25;
            // 
            // UserFamilyStatus
            // 
            this.UserFamilyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserFamilyStatus.FormattingEnabled = true;
            this.UserFamilyStatus.Location = new System.Drawing.Point(32, 271);
            this.UserFamilyStatus.Name = "UserFamilyStatus";
            this.UserFamilyStatus.Size = new System.Drawing.Size(221, 21);
            this.UserFamilyStatus.TabIndex = 24;
            // 
            // UserYear
            // 
            this.UserYear.FormattingEnabled = true;
            this.UserYear.Location = new System.Drawing.Point(200, 206);
            this.UserYear.Name = "UserYear";
            this.UserYear.Size = new System.Drawing.Size(53, 21);
            this.UserYear.TabIndex = 23;
            this.UserYear.Click += new System.EventHandler(this.UserYear_Click);
            // 
            // UserMonth
            // 
            this.UserMonth.FormattingEnabled = true;
            this.UserMonth.Location = new System.Drawing.Point(95, 206);
            this.UserMonth.Name = "UserMonth";
            this.UserMonth.Size = new System.Drawing.Size(99, 21);
            this.UserMonth.TabIndex = 22;
            this.UserMonth.SelectedIndexChanged += new System.EventHandler(this.UserMonth_SelectedIndexChanged);
            this.UserMonth.Click += new System.EventHandler(this.UserMonth_Click);
            this.UserMonth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserMonth_MouseDown);
            // 
            // UserDay
            // 
            this.UserDay.FormattingEnabled = true;
            this.UserDay.Location = new System.Drawing.Point(33, 206);
            this.UserDay.Name = "UserDay";
            this.UserDay.Size = new System.Drawing.Size(56, 21);
            this.UserDay.TabIndex = 21;
            this.UserDay.Click += new System.EventHandler(this.UserDay_Click);
            this.UserDay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserDay_MouseDown);
            // 
            // YearAndDateLabel
            // 
            this.YearAndDateLabel.Location = new System.Drawing.Point(30, 180);
            this.YearAndDateLabel.Name = "YearAndDateLabel";
            this.YearAndDateLabel.Size = new System.Drawing.Size(140, 23);
            this.YearAndDateLabel.TabIndex = 20;
            this.YearAndDateLabel.Text = "Год и дата рождения";
            // 
            // UserGender
            // 
            this.UserGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserGender.FormattingEnabled = true;
            this.UserGender.Location = new System.Drawing.Point(66, 145);
            this.UserGender.Name = "UserGender";
            this.UserGender.Size = new System.Drawing.Size(187, 21);
            this.UserGender.TabIndex = 19;
            // 
            // GenderLabel
            // 
            this.GenderLabel.Location = new System.Drawing.Point(30, 148);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 23);
            this.GenderLabel.TabIndex = 18;
            this.GenderLabel.Text = "Пол: ";
            // 
            // UserPatronymic
            // 
            this.UserPatronymic.Location = new System.Drawing.Point(33, 112);
            this.UserPatronymic.Name = "UserPatronymic";
            this.UserPatronymic.Size = new System.Drawing.Size(220, 20);
            this.UserPatronymic.TabIndex = 17;
            this.UserPatronymic.Text = "Введите Отчество";
            // 
            // UserSurname
            // 
            this.UserSurname.Location = new System.Drawing.Point(33, 69);
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.Size = new System.Drawing.Size(220, 20);
            this.UserSurname.TabIndex = 16;
            this.UserSurname.Text = "Введите Фамилию";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(33, 25);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(220, 20);
            this.UserName.TabIndex = 15;
            this.UserName.Text = "Введите Имя";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.AdditionalInformation);
            this.Controls.Add(this.FamilyStatus);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.UserAdditionalInformation);
            this.Controls.Add(this.UserFamilyStatus);
            this.Controls.Add(this.UserYear);
            this.Controls.Add(this.UserMonth);
            this.Controls.Add(this.UserDay);
            this.Controls.Add(this.YearAndDateLabel);
            this.Controls.Add(this.UserGender);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.UserPatronymic);
            this.Controls.Add(this.UserSurname);
            this.Controls.Add(this.UserName);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdditionalInformation;
        private System.Windows.Forms.Label FamilyStatus;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox UserAdditionalInformation;
        private System.Windows.Forms.ComboBox UserFamilyStatus;
        private System.Windows.Forms.ComboBox UserYear;
        private System.Windows.Forms.ComboBox UserMonth;
        private System.Windows.Forms.ComboBox UserDay;
        private System.Windows.Forms.Label YearAndDateLabel;
        private System.Windows.Forms.ComboBox UserGender;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox UserPatronymic;
        private System.Windows.Forms.TextBox UserSurname;
        private System.Windows.Forms.TextBox UserName;
    }
}

