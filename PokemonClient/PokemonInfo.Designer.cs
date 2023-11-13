namespace CustomPokemonControl
{
    partial class PokemonInfo
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pokemonName = new System.Windows.Forms.Label();
            this.healthInfo = new System.Windows.Forms.Label();
            this.attackInfo = new System.Windows.Forms.Label();
            this.abilitiesText = new System.Windows.Forms.Label();
            this.abilitiesTextBox = new System.Windows.Forms.RichTextBox();
            this.fightButton = new System.Windows.Forms.Button();
            this.fastFightButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pokemonName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.healthInfo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.attackInfo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.abilitiesText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.abilitiesTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.fightButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.fastFightButton, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 318);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pokemonName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pokemonName, 3);
            this.pokemonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pokemonName.Location = new System.Drawing.Point(103, 0);
            this.pokemonName.Name = "pokemonName";
            this.pokemonName.Size = new System.Drawing.Size(244, 50);
            this.pokemonName.TabIndex = 1;
            this.pokemonName.Text = "Pokemon Name";
            // 
            // healthInfo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.healthInfo, 3);
            this.healthInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthInfo.Location = new System.Drawing.Point(103, 50);
            this.healthInfo.Name = "healthInfo";
            this.healthInfo.Size = new System.Drawing.Size(244, 25);
            this.healthInfo.TabIndex = 2;
            this.healthInfo.Text = "Health: XX";
            this.healthInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // attackInfo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.attackInfo, 3);
            this.attackInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attackInfo.Location = new System.Drawing.Point(103, 75);
            this.attackInfo.Name = "attackInfo";
            this.attackInfo.Size = new System.Drawing.Size(244, 25);
            this.attackInfo.TabIndex = 3;
            this.attackInfo.Text = "Attack: XX";
            this.attackInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // abilitiesText
            // 
            this.abilitiesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abilitiesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.abilitiesText.Location = new System.Drawing.Point(2, 102);
            this.abilitiesText.Margin = new System.Windows.Forms.Padding(2);
            this.abilitiesText.Name = "abilitiesText";
            this.abilitiesText.Size = new System.Drawing.Size(96, 26);
            this.abilitiesText.TabIndex = 4;
            this.abilitiesText.Text = "Abilities:";
            this.abilitiesText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // abilitiesTextBox
            // 
            this.abilitiesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.abilitiesTextBox, 4);
            this.abilitiesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abilitiesTextBox.Location = new System.Drawing.Point(2, 132);
            this.abilitiesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.abilitiesTextBox.Name = "abilitiesTextBox";
            this.abilitiesTextBox.ReadOnly = true;
            this.abilitiesTextBox.Size = new System.Drawing.Size(346, 189);
            this.abilitiesTextBox.TabIndex = 5;
            this.abilitiesTextBox.Text = "";
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(193, 103);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(74, 23);
            this.fightButton.TabIndex = 6;
            this.fightButton.Text = "Fight!";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fastFightButton
            // 
            this.fastFightButton.Location = new System.Drawing.Point(273, 103);
            this.fastFightButton.Name = "fastFightButton";
            this.fastFightButton.Size = new System.Drawing.Size(74, 23);
            this.fastFightButton.TabIndex = 8;
            this.fastFightButton.Text = "Fast fight";
            this.fastFightButton.UseVisualStyleBackColor = true;
            this.fastFightButton.Click += new System.EventHandler(this.fastFightButton_Click);
            // 
            // PokemonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PokemonInfo";
            this.Size = new System.Drawing.Size(350, 318);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label pokemonName;
        private Label healthInfo;
        private Label attackInfo;
        private Label abilitiesText;
        private RichTextBox abilitiesTextBox;
        private Button fightButton;
        private Button fastFightButton;
    }
}
