namespace storage
{
    partial class Login
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
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.Pass_label = new System.Windows.Forms.Label();
            this.dbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(164, 128);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(102, 20);
            this.LoginBox.TabIndex = 0;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(164, 170);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '●';
            this.PassBox.Size = new System.Drawing.Size(102, 20);
            this.PassBox.TabIndex = 1;
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.CausesValidation = false;
            this.Login_label.Location = new System.Drawing.Point(101, 131);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(41, 13);
            this.Login_label.TabIndex = 2;
            this.Login_label.Text = "Логин:";
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.CausesValidation = false;
            this.Pass_label.Location = new System.Drawing.Point(94, 173);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(48, 13);
            this.Pass_label.TabIndex = 3;
            this.Pass_label.Text = "Пароль:";


            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 294);
            this.Controls.Add(this.Pass_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LoginBox);
            this.Name = "Login";
            this.Text = "Окно авторизации";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Pass_label;
        private System.Windows.Forms.BindingSource dbDataSetBindingSource;
    }
}

