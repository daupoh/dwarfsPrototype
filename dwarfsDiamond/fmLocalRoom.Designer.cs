namespace dwarfsDiamond
{
    partial class fmLocalRoom
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
            this.lblCountOfPlayers = new System.Windows.Forms.Label();
            this.numCountOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCountOfPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountOfPlayers
            // 
            this.lblCountOfPlayers.AutoSize = true;
            this.lblCountOfPlayers.Location = new System.Drawing.Point(12, 34);
            this.lblCountOfPlayers.Name = "lblCountOfPlayers";
            this.lblCountOfPlayers.Size = new System.Drawing.Size(110, 13);
            this.lblCountOfPlayers.TabIndex = 0;
            this.lblCountOfPlayers.Text = "Количество игроков";
            // 
            // numCountOfPlayers
            // 
            this.numCountOfPlayers.Location = new System.Drawing.Point(152, 32);
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
            this.numCountOfPlayers.TabIndex = 1;
            this.numCountOfPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(85, 58);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 42);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Начать игру";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // fmLocalRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numCountOfPlayers);
            this.Controls.Add(this.lblCountOfPlayers);
            this.Name = "fmLocalRoom";
            this.Text = "fmLocalRoom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmLocalRoom_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numCountOfPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountOfPlayers;
        private System.Windows.Forms.NumericUpDown numCountOfPlayers;
        private System.Windows.Forms.Button btnStart;
    }
}