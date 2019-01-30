namespace dwarfsDiamond
{
    partial class fmGameField
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
        /// 
        void initiate()
        {
            initiateArm();
            initiateEnemies();
            initiateHint();
            tbxSetsCount.Text = "0";
            tbxHeap.Text = m_pStartGameSettings.Settings.CountOfHeap.ToString();
        }
        void initiateArm()
        {
            int nStowns = m_pStartGameSettings.Settings.CountOfStowns,
                nForms = m_pStartGameSettings.Settings.CountOfStownForms;

            dgvArm.ColumnCount = nStowns;
            dgvArm.RowCount = nForms;


            for (int i = 0; i < nForms; i++)
            {
                dgvArm.Rows[i].HeaderCell.Value = m_pStartGameSettings.Settings
                    .getFormName(i);
            }

            dgvArm.ColumnHeadersVisible = false;
        }
        void initiateHint()
        {
            tbxHint.Text = m_pStartGameSettings.Settings.Hint;
        }
        void initiateEnemies()
        {
            int nEnemies = m_pStartGameSettings.Settings.CountOfEnemies,
                nFields = m_pStartGameSettings.Settings.CountOfFields;
            dgvEnemies.RowCount = nEnemies;
            dgvEnemies.ColumnCount = nFields;
            for (int i = 0; i < nEnemies; i++)
            {
                dgvEnemies.Rows[i].HeaderCell.Value = m_pStartGameSettings.Settings
                    .getEnemiesName(i);
            }
            for (int i = 0; i < nFields; i++)
            {
                dgvEnemies.Columns[i].HeaderCell.Value = m_pStartGameSettings.Settings
                    .getFieldName(i);
            }
        }
        private void InitializeComponent()
        {
            this.gbxArm = new System.Windows.Forms.GroupBox();
            this.dgvArm = new System.Windows.Forms.DataGridView();
            this.gbxSets = new System.Windows.Forms.GroupBox();
            this.tbxSetsCount = new System.Windows.Forms.TextBox();
            this.gbxEnemies = new System.Windows.Forms.GroupBox();
            this.dgvEnemies = new System.Windows.Forms.DataGridView();
            this.gmxGameLog = new System.Windows.Forms.GroupBox();
            this.gbxHeap = new System.Windows.Forms.GroupBox();
            this.tbxHeap = new System.Windows.Forms.TextBox();
            this.gbxActions = new System.Windows.Forms.GroupBox();
            this.gbxHint = new System.Windows.Forms.GroupBox();
            this.tbxHint = new System.Windows.Forms.TextBox();
            this.btnAsk = new System.Windows.Forms.Button();
            this.gbxArm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArm)).BeginInit();
            this.gbxSets.SuspendLayout();
            this.gbxEnemies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnemies)).BeginInit();
            this.gbxHeap.SuspendLayout();
            this.gbxActions.SuspendLayout();
            this.gbxHint.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxArm
            // 
            this.gbxArm.Controls.Add(this.dgvArm);
            this.gbxArm.Location = new System.Drawing.Point(148, 305);
            this.gbxArm.Name = "gbxArm";
            this.gbxArm.Size = new System.Drawing.Size(485, 109);
            this.gbxArm.TabIndex = 0;
            this.gbxArm.TabStop = false;
            this.gbxArm.Text = "Ваша \"рука\"";
            // 
            // dgvArm
            // 
            this.dgvArm.AllowUserToAddRows = false;
            this.dgvArm.AllowUserToDeleteRows = false;
            this.dgvArm.AllowUserToResizeColumns = false;
            this.dgvArm.AllowUserToResizeRows = false;
            this.dgvArm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArm.Location = new System.Drawing.Point(6, 19);
            this.dgvArm.MultiSelect = false;
            this.dgvArm.Name = "dgvArm";
            this.dgvArm.ReadOnly = true;
            this.dgvArm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvArm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArm.Size = new System.Drawing.Size(473, 83);
            this.dgvArm.TabIndex = 1;
            // 
            // gbxSets
            // 
            this.gbxSets.Controls.Add(this.tbxSetsCount);
            this.gbxSets.Location = new System.Drawing.Point(12, 420);
            this.gbxSets.Name = "gbxSets";
            this.gbxSets.Size = new System.Drawing.Size(130, 97);
            this.gbxSets.TabIndex = 1;
            this.gbxSets.TabStop = false;
            this.gbxSets.Text = "Ваши мешки";
            // 
            // tbxSetsCount
            // 
            this.tbxSetsCount.Location = new System.Drawing.Point(9, 19);
            this.tbxSetsCount.Name = "tbxSetsCount";
            this.tbxSetsCount.ReadOnly = true;
            this.tbxSetsCount.Size = new System.Drawing.Size(115, 20);
            this.tbxSetsCount.TabIndex = 1;
            this.tbxSetsCount.Text = "0";
            // 
            // gbxEnemies
            // 
            this.gbxEnemies.Controls.Add(this.dgvEnemies);
            this.gbxEnemies.Location = new System.Drawing.Point(12, 12);
            this.gbxEnemies.Name = "gbxEnemies";
            this.gbxEnemies.Size = new System.Drawing.Size(267, 224);
            this.gbxEnemies.TabIndex = 2;
            this.gbxEnemies.TabStop = false;
            this.gbxEnemies.Text = "Ваши соперники";
            // 
            // dgvEnemies
            // 
            this.dgvEnemies.AllowUserToAddRows = false;
            this.dgvEnemies.AllowUserToDeleteRows = false;
            this.dgvEnemies.AllowUserToResizeColumns = false;
            this.dgvEnemies.AllowUserToResizeRows = false;
            this.dgvEnemies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnemies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnemies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnemies.Location = new System.Drawing.Point(6, 19);
            this.dgvEnemies.MultiSelect = false;
            this.dgvEnemies.Name = "dgvEnemies";
            this.dgvEnemies.ReadOnly = true;
            this.dgvEnemies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEnemies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEnemies.Size = new System.Drawing.Size(255, 197);
            this.dgvEnemies.TabIndex = 2;
            // 
            // gmxGameLog
            // 
            this.gmxGameLog.Location = new System.Drawing.Point(285, 12);
            this.gmxGameLog.Name = "gmxGameLog";
            this.gmxGameLog.Size = new System.Drawing.Size(348, 224);
            this.gmxGameLog.TabIndex = 3;
            this.gmxGameLog.TabStop = false;
            this.gmxGameLog.Text = "Ход игры";
            // 
            // gbxHeap
            // 
            this.gbxHeap.Controls.Add(this.tbxHeap);
            this.gbxHeap.Location = new System.Drawing.Point(12, 305);
            this.gbxHeap.Name = "gbxHeap";
            this.gbxHeap.Size = new System.Drawing.Size(130, 109);
            this.gbxHeap.TabIndex = 4;
            this.gbxHeap.TabStop = false;
            this.gbxHeap.Text = "Общий мешок";
            // 
            // tbxHeap
            // 
            this.tbxHeap.Location = new System.Drawing.Point(6, 19);
            this.tbxHeap.Name = "tbxHeap";
            this.tbxHeap.ReadOnly = true;
            this.tbxHeap.Size = new System.Drawing.Size(118, 20);
            this.tbxHeap.TabIndex = 2;
            // 
            // gbxActions
            // 
            this.gbxActions.Controls.Add(this.btnAsk);
            this.gbxActions.Location = new System.Drawing.Point(148, 420);
            this.gbxActions.Name = "gbxActions";
            this.gbxActions.Size = new System.Drawing.Size(485, 97);
            this.gbxActions.TabIndex = 5;
            this.gbxActions.TabStop = false;
            this.gbxActions.Text = "Действия";
            // 
            // gbxHint
            // 
            this.gbxHint.Controls.Add(this.tbxHint);
            this.gbxHint.Location = new System.Drawing.Point(12, 242);
            this.gbxHint.Name = "gbxHint";
            this.gbxHint.Size = new System.Drawing.Size(621, 57);
            this.gbxHint.TabIndex = 5;
            this.gbxHint.TabStop = false;
            this.gbxHint.Text = "Обозначение драгоценностей";
            // 
            // tbxHint
            // 
            this.tbxHint.Location = new System.Drawing.Point(6, 19);
            this.tbxHint.Multiline = true;
            this.tbxHint.Name = "tbxHint";
            this.tbxHint.ReadOnly = true;
            this.tbxHint.Size = new System.Drawing.Size(609, 32);
            this.tbxHint.TabIndex = 2;
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(6, 19);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(119, 38);
            this.btnAsk.TabIndex = 0;
            this.btnAsk.Text = "Спросить драгоценность";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // fmGameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 529);
            this.Controls.Add(this.gbxHint);
            this.Controls.Add(this.gbxActions);
            this.Controls.Add(this.gbxHeap);
            this.Controls.Add(this.gmxGameLog);
            this.Controls.Add(this.gbxEnemies);
            this.Controls.Add(this.gbxSets);
            this.Controls.Add(this.gbxArm);
            this.MaximumSize = new System.Drawing.Size(661, 567);
            this.MinimumSize = new System.Drawing.Size(661, 567);
            this.Name = "fmGameField";
            this.Text = "Гноккер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmGameField_FormClosed);
            this.gbxArm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArm)).EndInit();
            this.gbxSets.ResumeLayout(false);
            this.gbxSets.PerformLayout();
            this.gbxEnemies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnemies)).EndInit();
            this.gbxHeap.ResumeLayout(false);
            this.gbxHeap.PerformLayout();
            this.gbxActions.ResumeLayout(false);
            this.gbxHint.ResumeLayout(false);
            this.gbxHint.PerformLayout();
            this.ResumeLayout(false);

            initiate();

        }
      
        #endregion

        private System.Windows.Forms.GroupBox gbxArm;
        private System.Windows.Forms.GroupBox gbxSets;
        private System.Windows.Forms.GroupBox gbxEnemies;
        private System.Windows.Forms.GroupBox gmxGameLog;
        private System.Windows.Forms.GroupBox gbxHeap;
        private System.Windows.Forms.GroupBox gbxActions;
        private System.Windows.Forms.DataGridView dgvArm;
        private System.Windows.Forms.TextBox tbxSetsCount;
        private System.Windows.Forms.DataGridView dgvEnemies;
        private System.Windows.Forms.TextBox tbxHeap;
        private System.Windows.Forms.GroupBox gbxHint;
        private System.Windows.Forms.TextBox tbxHint;
        private System.Windows.Forms.Button btnAsk;
    }
}