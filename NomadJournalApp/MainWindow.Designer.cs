namespace NomadJournalApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.enteredLoginLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.subscriptionMontsLabel = new System.Windows.Forms.Label();
            this.addIssueButton = new System.Windows.Forms.Button();
            this.sendIssueButton = new System.Windows.Forms.Button();
            this.loadReport = new System.Windows.Forms.Button();
            this.issueNameTextBox = new System.Windows.Forms.TextBox();
            this.issueDescription = new System.Windows.Forms.Label();
            this.issueName = new System.Windows.Forms.Label();
            this.issueDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.issuePageAmount = new System.Windows.Forms.Label();
            this.issuePageAmountTextBox = new System.Windows.Forms.TextBox();
            this.addIsue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.enterLabel.Location = new System.Drawing.Point(372, 162);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(76, 31);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Вход";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginLabel.Location = new System.Drawing.Point(323, 227);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(47, 17);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordLabel.Location = new System.Drawing.Point(313, 270);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 17);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(378, 270);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(378, 226);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 3;
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registrationButton.Location = new System.Drawing.Point(663, 528);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(157, 28);
            this.registrationButton.TabIndex = 4;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registrationLabel.Location = new System.Drawing.Point(695, 508);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(97, 17);
            this.registrationLabel.TabIndex = 5;
            this.registrationLabel.Text = "Нет аккаута?";
            // 
            // authorizationButton
            // 
            this.authorizationButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.authorizationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.authorizationButton.Location = new System.Drawing.Point(357, 321);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(91, 27);
            this.authorizationButton.TabIndex = 6;
            this.authorizationButton.Text = "Войти";
            this.authorizationButton.UseVisualStyleBackColor = false;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // enteredLoginLabel
            // 
            this.enteredLoginLabel.AutoSize = true;
            this.enteredLoginLabel.Location = new System.Drawing.Point(706, 9);
            this.enteredLoginLabel.Name = "enteredLoginLabel";
            this.enteredLoginLabel.Size = new System.Drawing.Size(0, 13);
            this.enteredLoginLabel.TabIndex = 7;
            this.enteredLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Enabled = false;
            this.fullNameLabel.Location = new System.Drawing.Point(709, 35);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(0, 13);
            this.fullNameLabel.TabIndex = 7;
            this.fullNameLabel.Visible = false;
            // 
            // subscriptionMontsLabel
            // 
            this.subscriptionMontsLabel.AutoSize = true;
            this.subscriptionMontsLabel.Enabled = false;
            this.subscriptionMontsLabel.Location = new System.Drawing.Point(709, 61);
            this.subscriptionMontsLabel.Name = "subscriptionMontsLabel";
            this.subscriptionMontsLabel.Size = new System.Drawing.Size(0, 13);
            this.subscriptionMontsLabel.TabIndex = 8;
            this.subscriptionMontsLabel.Visible = false;
            // 
            // addIssueButton
            // 
            this.addIssueButton.Enabled = false;
            this.addIssueButton.Location = new System.Drawing.Point(366, 166);
            this.addIssueButton.Name = "addIssueButton";
            this.addIssueButton.Size = new System.Drawing.Size(112, 35);
            this.addIssueButton.TabIndex = 9;
            this.addIssueButton.Text = "Добавить выпуск";
            this.addIssueButton.UseVisualStyleBackColor = true;
            this.addIssueButton.Visible = false;
            this.addIssueButton.Click += new System.EventHandler(this.addIssueButton_Click);
            // 
            // sendIssueButton
            // 
            this.sendIssueButton.Enabled = false;
            this.sendIssueButton.Location = new System.Drawing.Point(366, 207);
            this.sendIssueButton.Name = "sendIssueButton";
            this.sendIssueButton.Size = new System.Drawing.Size(112, 37);
            this.sendIssueButton.TabIndex = 10;
            this.sendIssueButton.Text = "Доставить";
            this.sendIssueButton.UseVisualStyleBackColor = true;
            this.sendIssueButton.Visible = false;
            this.sendIssueButton.Click += new System.EventHandler(this.sendIssueButton_Click);
            // 
            // loadReport
            // 
            this.loadReport.Enabled = false;
            this.loadReport.Location = new System.Drawing.Point(366, 250);
            this.loadReport.Name = "loadReport";
            this.loadReport.Size = new System.Drawing.Size(112, 37);
            this.loadReport.TabIndex = 10;
            this.loadReport.Text = "Выгрузить отчет";
            this.loadReport.UseVisualStyleBackColor = true;
            this.loadReport.Visible = false;
            this.loadReport.Click += new System.EventHandler(this.loadReport_Click);
            // 
            // issueNameTextBox
            // 
            this.issueNameTextBox.Enabled = false;
            this.issueNameTextBox.Location = new System.Drawing.Point(357, 162);
            this.issueNameTextBox.Name = "issueNameTextBox";
            this.issueNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.issueNameTextBox.TabIndex = 11;
            this.issueNameTextBox.Visible = false;
            // 
            // issueDescription
            // 
            this.issueDescription.AutoSize = true;
            this.issueDescription.Enabled = false;
            this.issueDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.issueDescription.Location = new System.Drawing.Point(268, 191);
            this.issueDescription.Name = "issueDescription";
            this.issueDescription.Size = new System.Drawing.Size(74, 17);
            this.issueDescription.TabIndex = 13;
            this.issueDescription.Text = "Описание";
            this.issueDescription.Visible = false;
            // 
            // issueName
            // 
            this.issueName.AutoSize = true;
            this.issueName.Enabled = false;
            this.issueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.issueName.Location = new System.Drawing.Point(270, 163);
            this.issueName.Name = "issueName";
            this.issueName.Size = new System.Drawing.Size(72, 17);
            this.issueName.TabIndex = 13;
            this.issueName.Text = "Название";
            this.issueName.Visible = false;
            // 
            // issueDescriptionTextBox
            // 
            this.issueDescriptionTextBox.Enabled = false;
            this.issueDescriptionTextBox.Location = new System.Drawing.Point(357, 190);
            this.issueDescriptionTextBox.Name = "issueDescriptionTextBox";
            this.issueDescriptionTextBox.Size = new System.Drawing.Size(173, 89);
            this.issueDescriptionTextBox.TabIndex = 14;
            this.issueDescriptionTextBox.Text = "";
            this.issueDescriptionTextBox.Visible = false;
            // 
            // issuePageAmount
            // 
            this.issuePageAmount.AutoSize = true;
            this.issuePageAmount.Enabled = false;
            this.issuePageAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.issuePageAmount.Location = new System.Drawing.Point(198, 295);
            this.issuePageAmount.Name = "issuePageAmount";
            this.issuePageAmount.Size = new System.Drawing.Size(144, 17);
            this.issuePageAmount.TabIndex = 15;
            this.issuePageAmount.Text = "Количество страниц";
            this.issuePageAmount.Visible = false;
            // 
            // issuePageAmountTextBox
            // 
            this.issuePageAmountTextBox.Enabled = false;
            this.issuePageAmountTextBox.Location = new System.Drawing.Point(357, 295);
            this.issuePageAmountTextBox.Name = "issuePageAmountTextBox";
            this.issuePageAmountTextBox.Size = new System.Drawing.Size(49, 20);
            this.issuePageAmountTextBox.TabIndex = 16;
            this.issuePageAmountTextBox.Visible = false;
            // 
            // addIsue
            // 
            this.addIsue.Enabled = false;
            this.addIsue.Location = new System.Drawing.Point(357, 335);
            this.addIsue.Name = "addIsue";
            this.addIsue.Size = new System.Drawing.Size(75, 23);
            this.addIsue.TabIndex = 17;
            this.addIsue.Text = "Добавить";
            this.addIsue.UseVisualStyleBackColor = true;
            this.addIsue.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 568);
            this.Controls.Add(this.addIsue);
            this.Controls.Add(this.issuePageAmountTextBox);
            this.Controls.Add(this.issuePageAmount);
            this.Controls.Add(this.issueDescriptionTextBox);
            this.Controls.Add(this.issueName);
            this.Controls.Add(this.issueDescription);
            this.Controls.Add(this.issueNameTextBox);
            this.Controls.Add(this.loadReport);
            this.Controls.Add(this.sendIssueButton);
            this.Controls.Add(this.addIssueButton);
            this.Controls.Add(this.subscriptionMontsLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.enteredLoginLabel);
            this.Controls.Add(this.authorizationButton);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.enterLabel);
            this.Name = "MainWindow";
            this.Text = "Nomad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.Label enteredLoginLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label subscriptionMontsLabel;
        private System.Windows.Forms.Button addIssueButton;
        private System.Windows.Forms.Button sendIssueButton;
        private System.Windows.Forms.Button loadReport;
        private System.Windows.Forms.TextBox issueNameTextBox;
        private System.Windows.Forms.Label issueDescription;
        private System.Windows.Forms.Label issueName;
        private System.Windows.Forms.RichTextBox issueDescriptionTextBox;
        private System.Windows.Forms.Label issuePageAmount;
        private System.Windows.Forms.TextBox issuePageAmountTextBox;
        private System.Windows.Forms.Button addIsue;
    }
}

