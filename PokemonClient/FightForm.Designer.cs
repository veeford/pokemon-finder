namespace pokemon
{
    partial class FightForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pokemonCpuAttackLabel = new System.Windows.Forms.Label();
            this.pokemonCpuImage = new System.Windows.Forms.PictureBox();
            this.pokemonCpuNameLabel = new System.Windows.Forms.Label();
            this.pokemonCpuHpLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pokemonPlayerTable = new System.Windows.Forms.TableLayoutPanel();
            this.pokemonPlayerAttackLabel = new System.Windows.Forms.Label();
            this.pokemonPlayerImage = new System.Windows.Forms.PictureBox();
            this.pokemonPlayerNameLabel = new System.Windows.Forms.Label();
            this.pokemonPlayerHpLabel = new System.Windows.Forms.Label();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.stepButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonCpuImage)).BeginInit();
            this.pokemonPlayerTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPlayerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pokemonPlayerTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.logListBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stepButton, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 346);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pokemonCpuAttackLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.pokemonCpuImage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pokemonCpuNameLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pokemonCpuHpLabel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(259, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 145);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // pokemonCpuAttackLabel
            // 
            this.pokemonCpuAttackLabel.AutoSize = true;
            this.pokemonCpuAttackLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonCpuAttackLabel.Location = new System.Drawing.Point(133, 125);
            this.pokemonCpuAttackLabel.Name = "pokemonCpuAttackLabel";
            this.pokemonCpuAttackLabel.Size = new System.Drawing.Size(124, 20);
            this.pokemonCpuAttackLabel.TabIndex = 3;
            this.pokemonCpuAttackLabel.Text = "Attack: --";
            this.pokemonCpuAttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokemonCpuImage
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pokemonCpuImage, 2);
            this.pokemonCpuImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonCpuImage.Location = new System.Drawing.Point(3, 3);
            this.pokemonCpuImage.Name = "pokemonCpuImage";
            this.pokemonCpuImage.Size = new System.Drawing.Size(254, 79);
            this.pokemonCpuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pokemonCpuImage.TabIndex = 0;
            this.pokemonCpuImage.TabStop = false;
            // 
            // pokemonCpuNameLabel
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pokemonCpuNameLabel, 2);
            this.pokemonCpuNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonCpuNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pokemonCpuNameLabel.Location = new System.Drawing.Point(3, 85);
            this.pokemonCpuNameLabel.Name = "pokemonCpuNameLabel";
            this.pokemonCpuNameLabel.Size = new System.Drawing.Size(254, 40);
            this.pokemonCpuNameLabel.TabIndex = 1;
            this.pokemonCpuNameLabel.Text = "-";
            this.pokemonCpuNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokemonCpuHpLabel
            // 
            this.pokemonCpuHpLabel.AutoSize = true;
            this.pokemonCpuHpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonCpuHpLabel.Location = new System.Drawing.Point(3, 125);
            this.pokemonCpuHpLabel.Name = "pokemonCpuHpLabel";
            this.pokemonCpuHpLabel.Size = new System.Drawing.Size(124, 20);
            this.pokemonCpuHpLabel.TabIndex = 2;
            this.pokemonCpuHpLabel.Text = "HP: --";
            this.pokemonCpuHpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(262, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "You";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokemonPlayerTable
            // 
            this.pokemonPlayerTable.ColumnCount = 2;
            this.pokemonPlayerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pokemonPlayerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pokemonPlayerTable.Controls.Add(this.pokemonPlayerAttackLabel, 1, 2);
            this.pokemonPlayerTable.Controls.Add(this.pokemonPlayerImage, 0, 0);
            this.pokemonPlayerTable.Controls.Add(this.pokemonPlayerNameLabel, 0, 1);
            this.pokemonPlayerTable.Controls.Add(this.pokemonPlayerHpLabel, 0, 2);
            this.pokemonPlayerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonPlayerTable.Location = new System.Drawing.Point(0, 25);
            this.pokemonPlayerTable.Margin = new System.Windows.Forms.Padding(0);
            this.pokemonPlayerTable.Name = "pokemonPlayerTable";
            this.pokemonPlayerTable.RowCount = 3;
            this.pokemonPlayerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pokemonPlayerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pokemonPlayerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pokemonPlayerTable.Size = new System.Drawing.Size(259, 145);
            this.pokemonPlayerTable.TabIndex = 2;
            // 
            // pokemonPlayerAttackLabel
            // 
            this.pokemonPlayerAttackLabel.AutoSize = true;
            this.pokemonPlayerAttackLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonPlayerAttackLabel.Location = new System.Drawing.Point(132, 125);
            this.pokemonPlayerAttackLabel.Name = "pokemonPlayerAttackLabel";
            this.pokemonPlayerAttackLabel.Size = new System.Drawing.Size(124, 20);
            this.pokemonPlayerAttackLabel.TabIndex = 3;
            this.pokemonPlayerAttackLabel.Text = "Attack: --";
            this.pokemonPlayerAttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokemonPlayerImage
            // 
            this.pokemonPlayerTable.SetColumnSpan(this.pokemonPlayerImage, 2);
            this.pokemonPlayerImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonPlayerImage.Location = new System.Drawing.Point(3, 3);
            this.pokemonPlayerImage.Name = "pokemonPlayerImage";
            this.pokemonPlayerImage.Size = new System.Drawing.Size(253, 79);
            this.pokemonPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pokemonPlayerImage.TabIndex = 0;
            this.pokemonPlayerImage.TabStop = false;
            // 
            // pokemonPlayerNameLabel
            // 
            this.pokemonPlayerTable.SetColumnSpan(this.pokemonPlayerNameLabel, 2);
            this.pokemonPlayerNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonPlayerNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pokemonPlayerNameLabel.Location = new System.Drawing.Point(3, 85);
            this.pokemonPlayerNameLabel.Name = "pokemonPlayerNameLabel";
            this.pokemonPlayerNameLabel.Size = new System.Drawing.Size(253, 40);
            this.pokemonPlayerNameLabel.TabIndex = 1;
            this.pokemonPlayerNameLabel.Text = "-";
            this.pokemonPlayerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokemonPlayerHpLabel
            // 
            this.pokemonPlayerHpLabel.AutoSize = true;
            this.pokemonPlayerHpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonPlayerHpLabel.Location = new System.Drawing.Point(3, 125);
            this.pokemonPlayerHpLabel.Name = "pokemonPlayerHpLabel";
            this.pokemonPlayerHpLabel.Size = new System.Drawing.Size(123, 20);
            this.pokemonPlayerHpLabel.TabIndex = 2;
            this.pokemonPlayerHpLabel.Text = "HP: --";
            this.pokemonPlayerHpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.logListBox, 2);
            this.logListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 15;
            this.logListBox.Location = new System.Drawing.Point(3, 173);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(513, 139);
            this.logListBox.TabIndex = 4;
            // 
            // stepButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.stepButton, 2);
            this.stepButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepButton.Location = new System.Drawing.Point(3, 318);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(513, 25);
            this.stepButton.TabIndex = 5;
            this.stepButton.Text = "Attack";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // FightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 346);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FightForm";
            this.Text = "FightForm";
            this.Load += new System.EventHandler(this.FightForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonCpuImage)).EndInit();
            this.pokemonPlayerTable.ResumeLayout(false);
            this.pokemonPlayerTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPlayerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label pokemonCpuAttackLabel;
        private PictureBox pokemonCpuImage;
        private Label pokemonCpuNameLabel;
        private Label pokemonCpuHpLabel;
        private Label label2;
        private Label label1;
        private TableLayoutPanel pokemonPlayerTable;
        private Label pokemonPlayerAttackLabel;
        private PictureBox pokemonPlayerImage;
        private Label pokemonPlayerNameLabel;
        private Label pokemonPlayerHpLabel;
        private ListBox logListBox;
        private Button stepButton;
    }
}