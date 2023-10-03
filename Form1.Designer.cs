namespace pokemon
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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.currentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pokemonsListView = new System.Windows.Forms.ListView();
            this.pokemonName = new System.Windows.Forms.ColumnHeader();
            this.mainLayout.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainLayout.Controls.Add(this.searchTextBox, 0, 0);
            this.mainLayout.Controls.Add(this.searchButton, 1, 0);
            this.mainLayout.Controls.Add(this.statusStrip, 0, 2);
            this.mainLayout.Controls.Add(this.pokemonsListView, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(344, 211);
            this.mainLayout.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Location = new System.Drawing.Point(4, 4);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Type here a pokemon name, e.g. \'Bulbasaur\'";
            this.searchTextBox.Size = new System.Drawing.Size(258, 23);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(266, 4);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 4, 4, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 24);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search!";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // statusStrip
            // 
            this.mainLayout.SetColumnSpan(this.statusStrip, 2);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 191);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(344, 20);
            this.statusStrip.TabIndex = 3;
            // 
            // currentStatus
            // 
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(0, 15);
            // 
            // pokemonsListView
            // 
            this.pokemonsListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.pokemonsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pokemonName});
            this.mainLayout.SetColumnSpan(this.pokemonsListView, 2);
            this.pokemonsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.pokemonsListView.Location = new System.Drawing.Point(3, 33);
            this.pokemonsListView.Name = "pokemonsListView";
            this.pokemonsListView.ShowItemToolTips = true;
            this.pokemonsListView.Size = new System.Drawing.Size(338, 155);
            this.pokemonsListView.TabIndex = 4;
            this.pokemonsListView.UseCompatibleStateImageBehavior = false;
            this.pokemonsListView.View = System.Windows.Forms.View.Tile;
            // 
            // pokemonName
            // 
            this.pokemonName.Text = "Pokemon name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 211);
            this.Controls.Add(this.mainLayout);
            this.MinimumSize = new System.Drawing.Size(360, 250);
            this.Name = "Form1";
            this.Text = "Pokemon List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel mainLayout;
        private TextBox searchTextBox;
        private Button searchButton;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel currentStatus;
        private ListView pokemonsListView;
        private ColumnHeader pokemonName;
    }
}