namespace Car_Racing
{
    partial class HighScore
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScore));
            this.title = new System.Windows.Forms.Label();
            this.titleHighScore = new System.Windows.Forms.Label();
            this.dgvHighScore = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Car_RacingDataSet = new Car_Racing.DB_Car_RacingDataSet();
            this.playerTableAdapter = new Car_Racing.DB_Car_RacingDataSetTableAdapters.PlayerTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Car_RacingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(103, 53);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(219, 36);
            this.title.TabIndex = 0;
            this.title.Text = "CAR RACING";
            // 
            // titleHighScore
            // 
            this.titleHighScore.AutoSize = true;
            this.titleHighScore.BackColor = System.Drawing.SystemColors.Control;
            this.titleHighScore.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.titleHighScore.ForeColor = System.Drawing.Color.Red;
            this.titleHighScore.Location = new System.Drawing.Point(168, 121);
            this.titleHighScore.Name = "titleHighScore";
            this.titleHighScore.Size = new System.Drawing.Size(100, 25);
            this.titleHighScore.TabIndex = 1;
            this.titleHighScore.Text = "Điểm cao";
            // 
            // dgvHighScore
            // 
            this.dgvHighScore.AllowUserToAddRows = false;
            this.dgvHighScore.AllowUserToDeleteRows = false;
            this.dgvHighScore.AutoGenerateColumns = false;
            this.dgvHighScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dgvHighScore.DataSource = this.playerBindingSource;
            this.dgvHighScore.Location = new System.Drawing.Point(92, 166);
            this.dgvHighScore.Name = "dgvHighScore";
            this.dgvHighScore.ReadOnly = true;
            this.dgvHighScore.Size = new System.Drawing.Size(244, 135);
            this.dgvHighScore.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.dB_Car_RacingDataSet;
            // 
            // dB_Car_RacingDataSet
            // 
            this.dB_Car_RacingDataSet.DataSetName = "DB_Car_RacingDataSet";
            this.dB_Car_RacingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(183, 323);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvHighScore);
            this.Controls.Add(this.titleHighScore);
            this.Controls.Add(this.title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing";
            this.Load += new System.EventHandler(this.HighScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Car_RacingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label titleHighScore;
        private System.Windows.Forms.DataGridView dgvHighScore;
        private DB_Car_RacingDataSet dB_Car_RacingDataSet;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private DB_Car_RacingDataSetTableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
    }
}