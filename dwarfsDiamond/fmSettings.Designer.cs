namespace dwarfsDiamond
{
    partial class fmSettings
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
            this.numCountOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblCountOfPlayers = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCountOfPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // numCountOfPlayers
            // 
            this.numCountOfPlayers.Location = new System.Drawing.Point(138, 12);
            this.numCountOfPlayers.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numCountOfPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCountOfPlayers.Name = "numCountOfPlayers";
            this.numCountOfPlayers.Size = new System.Drawing.Size(120, 20);
            this.numCountOfPlayers.TabIndex = 0;
            this.numCountOfPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCountOfPlayers
            // 
            this.lblCountOfPlayers.AutoSize = true;
            this.lblCountOfPlayers.Location = new System.Drawing.Point(12, 14);
            this.lblCountOfPlayers.Name = "lblCountOfPlayers";
            this.lblCountOfPlayers.Size = new System.Drawing.Size(110, 13);
            this.lblCountOfPlayers.TabIndex = 1;
            this.lblCountOfPlayers.Text = "Количество игроков";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(71, 62);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(128, 23);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Начать игру";
            this.btnStartGame.UseVisualStyleBackColor = true;
            // 
            // fmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 97);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblCountOfPlayers);
            this.Controls.Add(this.numCountOfPlayers);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(286, 135);
            this.MinimumSize = new System.Drawing.Size(286, 135);
            this.Name = "fmSettings";
            this.Text = "Алмазы гномов";
            ((System.ComponentModel.ISupportInitialize)(this.numCountOfPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numCountOfPlayers;
        private System.Windows.Forms.Label lblCountOfPlayers;
        private System.Windows.Forms.Button btnStartGame;
    }
}

