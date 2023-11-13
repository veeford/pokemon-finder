namespace CustomPokemonControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.pokemonListBox = new CustomPokemonControl.PokemonListBox();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.pageNumberTextBox = new System.Windows.Forms.TextBox();
            this.totalPagesLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.pokemonInfo = new CustomPokemonControl.PokemonInfo();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 296);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pokemonInfo);
            this.splitContainer1.Size = new System.Drawing.Size(505, 276);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Controls.Add(this.searchTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pokemonListBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.prevPageButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nextPageButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.pageNumberTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.totalPagesLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(167, 276);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.searchTextBox, 3);
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(135, 23);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // pokemonListBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pokemonListBox, 4);
            this.pokemonListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.pokemonListBox.FormattingEnabled = true;
            this.pokemonListBox.ItemHeight = 15;
            this.pokemonListBox.Location = new System.Drawing.Point(3, 33);
            this.pokemonListBox.Name = "pokemonListBox";
            this.pokemonListBox.Size = new System.Drawing.Size(161, 217);
            this.pokemonListBox.TabIndex = 1;
            this.pokemonListBox.SelectedIndexChanged += new System.EventHandler(this.pokemonListBox_SelectedIndexChanged);
            // 
            // prevPageButton
            // 
            this.prevPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevPageButton.Location = new System.Drawing.Point(0, 253);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(25, 23);
            this.prevPageButton.TabIndex = 2;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextPageButton.Location = new System.Drawing.Point(141, 253);
            this.nextPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(26, 23);
            this.nextPageButton.TabIndex = 3;
            this.nextPageButton.Text = ">";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // pageNumberTextBox
            // 
            this.pageNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageNumberTextBox.Location = new System.Drawing.Point(25, 253);
            this.pageNumberTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.pageNumberTextBox.Name = "pageNumberTextBox";
            this.pageNumberTextBox.Size = new System.Drawing.Size(58, 23);
            this.pageNumberTextBox.TabIndex = 4;
            this.pageNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pageNumberTextBox.Leave += new System.EventHandler(this.pageNumberTextBox_Leave);
            // 
            // totalPagesLabel
            // 
            this.totalPagesLabel.AutoSize = true;
            this.totalPagesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPagesLabel.Location = new System.Drawing.Point(83, 253);
            this.totalPagesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPagesLabel.Name = "totalPagesLabel";
            this.totalPagesLabel.Size = new System.Drawing.Size(58, 23);
            this.totalPagesLabel.TabIndex = 5;
            this.totalPagesLabel.Text = "/ 0";
            this.totalPagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(144, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(20, 24);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "S";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pokemonInfo
            // 
            this.pokemonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonInfo.Location = new System.Drawing.Point(0, 0);
            this.pokemonInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pokemonInfo.Name = "pokemonInfo";
            this.pokemonInfo.Pokemon = null;
            this.pokemonInfo.Size = new System.Drawing.Size(334, 276);
            this.pokemonInfo.TabIndex = 0;
            this.pokemonInfo.Load += new System.EventHandler(this.pokemonInfo_Load);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(505, 20);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(118, 15);
            this.status.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 296);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolStripStatusLabel status;
        private TextBox searchTextBox;
        private PokemonListBox pokemonListBox;
        private Button prevPageButton;
        private Button nextPageButton;
        private TextBox pageNumberTextBox;
        private Label totalPagesLabel;
        private PokemonInfo pokemonInfo;
        private Button searchButton;
    }
}