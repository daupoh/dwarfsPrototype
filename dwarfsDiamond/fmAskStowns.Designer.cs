namespace dwarfsDiamond
{
    partial class fmAskStowns
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
            this.tbxDialog = new System.Windows.Forms.TextBox();
            this.gbxNumbersOfStown = new System.Windows.Forms.GroupBox();
            this.numCounter = new System.Windows.Forms.NumericUpDown();
            this.gbxTypeOfStowns = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxNumbersOfStown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCounter)).BeginInit();
            this.gbxTypeOfStowns.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxDialog
            // 
            this.tbxDialog.Location = new System.Drawing.Point(12, 12);
            this.tbxDialog.Multiline = true;
            this.tbxDialog.Name = "tbxDialog";
            this.tbxDialog.ReadOnly = true;
            this.tbxDialog.Size = new System.Drawing.Size(280, 100);
            this.tbxDialog.TabIndex = 0;
            // 
            // gbxNumbersOfStown
            // 
            this.gbxNumbersOfStown.Controls.Add(this.numCounter);
            this.gbxNumbersOfStown.Location = new System.Drawing.Point(12, 118);
            this.gbxNumbersOfStown.Name = "gbxNumbersOfStown";
            this.gbxNumbersOfStown.Size = new System.Drawing.Size(129, 76);
            this.gbxNumbersOfStown.TabIndex = 1;
            this.gbxNumbersOfStown.TabStop = false;
            this.gbxNumbersOfStown.Text = "Количество камней";
            // 
            // numCounter
            // 
            this.numCounter.Location = new System.Drawing.Point(6, 39);
            this.numCounter.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCounter.Name = "numCounter";
            this.numCounter.Size = new System.Drawing.Size(110, 20);
            this.numCounter.TabIndex = 0;
            this.numCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbxTypeOfStowns
            // 
            this.gbxTypeOfStowns.Controls.Add(this.checkBox4);
            this.gbxTypeOfStowns.Controls.Add(this.checkBox3);
            this.gbxTypeOfStowns.Controls.Add(this.checkBox2);
            this.gbxTypeOfStowns.Controls.Add(this.checkBox1);
            this.gbxTypeOfStowns.Enabled = false;
            this.gbxTypeOfStowns.Location = new System.Drawing.Point(147, 118);
            this.gbxTypeOfStowns.Name = "gbxTypeOfStowns";
            this.gbxTypeOfStowns.Size = new System.Drawing.Size(145, 123);
            this.gbxTypeOfStowns.TabIndex = 2;
            this.gbxTypeOfStowns.TabStop = false;
            this.gbxTypeOfStowns.Text = "Типы камней";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(93, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Треугольный";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Граненный";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Каплевидный";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Круглый";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Спросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmAskStowns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxTypeOfStowns);
            this.Controls.Add(this.gbxNumbersOfStown);
            this.Controls.Add(this.tbxDialog);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(316, 300);
            this.Name = "fmAskStowns";
            this.Text = "Спросить драгоценность";
            this.gbxNumbersOfStown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCounter)).EndInit();
            this.gbxTypeOfStowns.ResumeLayout(false);
            this.gbxTypeOfStowns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDialog;
        private System.Windows.Forms.GroupBox gbxNumbersOfStown;
        private System.Windows.Forms.NumericUpDown numCounter;
        private System.Windows.Forms.GroupBox gbxTypeOfStowns;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}