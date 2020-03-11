namespace WinGAI
{
    partial class Autorization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelGreating = new System.Windows.Forms.Label();
            this.LabLog = new System.Windows.Forms.Label();
            this.LabPass = new System.Windows.Forms.Label();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.ButInput = new System.Windows.Forms.Button();
            this.ButOutput = new System.Windows.Forms.Button();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LabelGreating
            // 
            this.LabelGreating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelGreating.Location = new System.Drawing.Point(162, 48);
            this.LabelGreating.Name = "LabelGreating";
            this.LabelGreating.Size = new System.Drawing.Size(405, 33);
            this.LabelGreating.TabIndex = 1;
            this.LabelGreating.Text = "Добро пожаловать в систему для госавтоинспекции.                                 " +
    "                           Для ввохода введите логин и пароль.";
            // 
            // LabLog
            // 
            this.LabLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabLog.AutoSize = true;
            this.LabLog.Location = new System.Drawing.Point(162, 132);
            this.LabLog.Name = "LabLog";
            this.LabLog.Size = new System.Drawing.Size(38, 13);
            this.LabLog.TabIndex = 2;
            this.LabLog.Text = "Логин";
            // 
            // LabPass
            // 
            this.LabPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabPass.AutoSize = true;
            this.LabPass.Location = new System.Drawing.Point(162, 180);
            this.LabPass.Name = "LabPass";
            this.LabPass.Size = new System.Drawing.Size(45, 13);
            this.LabPass.TabIndex = 3;
            this.LabPass.Text = "Пароль";
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxLog.Location = new System.Drawing.Point(299, 125);
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLog.TabIndex = 4;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxPass.Location = new System.Drawing.Point(299, 173);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPass.TabIndex = 5;
            // 
            // ButInput
            // 
            this.ButInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButInput.Location = new System.Drawing.Point(125, 251);
            this.ButInput.Name = "ButInput";
            this.ButInput.Size = new System.Drawing.Size(75, 23);
            this.ButInput.TabIndex = 6;
            this.ButInput.Text = "Войти";
            this.ButInput.UseVisualStyleBackColor = true;
            this.ButInput.Click += new System.EventHandler(this.ButInput_Click);
            // 
            // ButOutput
            // 
            this.ButOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButOutput.Location = new System.Drawing.Point(324, 251);
            this.ButOutput.Name = "ButOutput";
            this.ButOutput.Size = new System.Drawing.Size(75, 23);
            this.ButOutput.TabIndex = 7;
            this.ButOutput.Text = "Выйти";
            this.ButOutput.UseVisualStyleBackColor = true;
            this.ButOutput.Click += new System.EventHandler(this.ButOutput_Click);
            // 
            // LabelMessage
            // 
            this.LabelMessage.Location = new System.Drawing.Point(12, 214);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(371, 23);
            this.LabelMessage.TabIndex = 8;
            this.LabelMessage.Text = "Здесь будет сообщение о блокировке";
            this.LabelMessage.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(498, 312);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.ButOutput);
            this.Controls.Add(this.ButInput);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLog);
            this.Controls.Add(this.LabPass);
            this.Controls.Add(this.LabLog);
            this.Controls.Add(this.LabelGreating);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Autorization";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelGreating;
        private System.Windows.Forms.Label LabLog;
        private System.Windows.Forms.Label LabPass;
        private System.Windows.Forms.TextBox TextBoxLog;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Button ButInput;
        private System.Windows.Forms.Button ButOutput;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Timer timer1;
    }
}

