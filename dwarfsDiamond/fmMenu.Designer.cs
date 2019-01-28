namespace dwarfsDiamond
{
    partial class fmMenu
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
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnCreateNet = new System.Windows.Forms.Button();
            this.btnCreateLocal = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(99, 72);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(174, 20);
            this.tbxLogin.TabIndex = 0;
            this.tbxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxLogin_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(148, 98);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Location = new System.Drawing.Point(96, 33);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(177, 36);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Введите имя, под которым вас будут видеть другие игроки";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateNet
            // 
            this.btnCreateNet.Location = new System.Drawing.Point(12, 201);
            this.btnCreateNet.Name = "btnCreateNet";
            this.btnCreateNet.Size = new System.Drawing.Size(134, 41);
            this.btnCreateNet.TabIndex = 4;
            this.btnCreateNet.Text = "Создать сетевую игру";
            this.btnCreateNet.UseVisualStyleBackColor = true;
            this.btnCreateNet.Click += new System.EventHandler(this.btnCreateNet_Click);
            // 
            // btnCreateLocal
            // 
            this.btnCreateLocal.Location = new System.Drawing.Point(12, 154);
            this.btnCreateLocal.Name = "btnCreateLocal";
            this.btnCreateLocal.Size = new System.Drawing.Size(134, 41);
            this.btnCreateLocal.TabIndex = 5;
            this.btnCreateLocal.Text = "Создать локальную игру";
            this.btnCreateLocal.UseVisualStyleBackColor = true;
            this.btnCreateLocal.Click += new System.EventHandler(this.btnCreateLocal_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 248);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(134, 41);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Присоединиться к игре";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(12, 115);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(134, 36);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Вы вошли как: ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 297);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCreateLocal);
            this.Controls.Add(this.btnCreateNet);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMenu";
            this.Text = "Алмазная лихорадка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnCreateNet;
        private System.Windows.Forms.Button btnCreateLocal;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblWelcome;
    }
}

