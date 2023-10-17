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
            this.pokemonListBox1 = new CustomPokemonControl.PokemonListBox();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.selectedPage = new System.Windows.Forms.TextBox();
            this.pagesLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel2.Controls.Add(this.pokemonListBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.prevPageButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nextPageButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.selectedPage, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pagesLabel, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(167, 276);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pokemonListBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pokemonListBox1, 4);
            this.pokemonListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.pokemonListBox1.FormattingEnabled = true;
            this.pokemonListBox1.ItemHeight = 15;
            this.pokemonListBox1.Location = new System.Drawing.Point(0, 0);
            this.pokemonListBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pokemonListBox1.Name = "pokemonListBox1";
            this.pokemonListBox1.Size = new System.Drawing.Size(167, 253);
            this.pokemonListBox1.TabIndex = 0;
            // 
            // prevPageButton
            // 
            this.prevPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevPageButton.Enabled = false;
            this.prevPageButton.Location = new System.Drawing.Point(0, 253);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(25, 23);
            this.prevPageButton.TabIndex = 1;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextPageButton.Enabled = false;
            this.nextPageButton.Location = new System.Drawing.Point(141, 253);
            this.nextPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(26, 23);
            this.nextPageButton.TabIndex = 2;
            this.nextPageButton.Text = ">";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // selectedPage
            // 
            this.selectedPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedPage.Location = new System.Drawing.Point(25, 253);
            this.selectedPage.Margin = new System.Windows.Forms.Padding(0);
            this.selectedPage.Name = "selectedPage";
            this.selectedPage.Size = new System.Drawing.Size(58, 23);
            this.selectedPage.TabIndex = 3;
            this.selectedPage.Text = "1";
            this.selectedPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.selectedPage.TextChanged += new System.EventHandler(this.selectedPage_TextChanged);
            this.selectedPage.Leave += new System.EventHandler(this.selectedPage_Leave);
            // 
            // pagesLabel
            // 
            this.pagesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesLabel.Location = new System.Drawing.Point(86, 253);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(52, 23);
            this.pagesLabel.TabIndex = 4;
            this.pagesLabel.Text = "/ 0";
            this.pagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pokemonInfo
            // 
            this.pokemonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonInfo.Location = new System.Drawing.Point(0, 0);
            this.pokemonInfo.Name = "pokemonInfo";
            this.pokemonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.pokemonInfo.Size = new System.Drawing.Size(334, 276);
            this.pokemonInfo.TabIndex = 0;
            // 
            // statusStrip1
            // 
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
        private PokemonInfo pokemonInfo;
        private TableLayoutPanel tableLayoutPanel2;
        private PokemonListBox pokemonListBox1;
        private Button prevPageButton;
        private Button nextPageButton;
        private TextBox selectedPage;
        private Label pagesLabel;
        private ToolStripStatusLabel status;
    }
}