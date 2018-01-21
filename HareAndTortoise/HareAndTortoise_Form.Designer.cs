namespace HareAndTortoise {
    partial class HareAndTortoise_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gameBoardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.LstBox = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNumberOfPlayers = new System.Windows.Forms.Label();
            this.cmbNumber = new System.Windows.Forms.ComboBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblHareAndTortoise = new System.Windows.Forms.Label();
            this.ColourColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinnerColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gameBoardPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnExit);
            this.splitContainer.Panel2.Controls.Add(this.btnReset);
            this.splitContainer.Panel2.Controls.Add(this.btnRollDice);
            this.splitContainer.Panel2.Controls.Add(this.LstBox);
            this.splitContainer.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer.Panel2.Controls.Add(this.lblNumberOfPlayers);
            this.splitContainer.Panel2.Controls.Add(this.cmbNumber);
            this.splitContainer.Panel2.Controls.Add(this.lblPlayers);
            this.splitContainer.Panel2.Controls.Add(this.lblHareAndTortoise);
            this.splitContainer.Size = new System.Drawing.Size(1768, 1262);
            this.splitContainer.SplitterDistance = 1330;
            this.splitContainer.SplitterWidth = 8;
            this.splitContainer.TabIndex = 0;
            // 
            // gameBoardPanel
            // 
            this.gameBoardPanel.AutoSize = true;
            this.gameBoardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameBoardPanel.ColumnCount = 7;
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.gameBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.gameBoardPanel.Margin = new System.Windows.Forms.Padding(6);
            this.gameBoardPanel.Name = "gameBoardPanel";
            this.gameBoardPanel.RowCount = 8;
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.Size = new System.Drawing.Size(1330, 1262);
            this.gameBoardPanel.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(204, 1206);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 44);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(80, 1206);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 44);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(136, 1158);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(6);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(150, 44);
            this.btnRollDice.TabIndex = 6;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // LstBox
            // 
            this.LstBox.FormattingEnabled = true;
            this.LstBox.ItemHeight = 25;
            this.LstBox.Location = new System.Drawing.Point(6, 562);
            this.LstBox.Margin = new System.Windows.Forms.Padding(6);
            this.LstBox.Name = "LstBox";
            this.LstBox.Size = new System.Drawing.Size(409, 579);
            this.LstBox.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColourColumn,
            this.NameColumn,
            this.MoneyColumn,
            this.WinnerColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 210);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(362, 340);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblNumberOfPlayers
            // 
            this.lblNumberOfPlayers.AutoSize = true;
            this.lblNumberOfPlayers.Location = new System.Drawing.Point(74, 96);
            this.lblNumberOfPlayers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfPlayers.Name = "lblNumberOfPlayers";
            this.lblNumberOfPlayers.Size = new System.Drawing.Size(189, 25);
            this.lblNumberOfPlayers.TabIndex = 3;
            this.lblNumberOfPlayers.Text = "Number of Players";
            // 
            // cmbNumber
            // 
            this.cmbNumber.FormattingEnabled = true;
            this.cmbNumber.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbNumber.Location = new System.Drawing.Point(272, 90);
            this.cmbNumber.Margin = new System.Windows.Forms.Padding(6);
            this.cmbNumber.Name = "cmbNumber";
            this.cmbNumber.Size = new System.Drawing.Size(58, 33);
            this.cmbNumber.TabIndex = 2;
            this.cmbNumber.SelectedIndexChanged += new System.EventHandler(this.cmbNumber_SelectedIndexChanged);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(120, 156);
            this.lblPlayers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(164, 51);
            this.lblPlayers.TabIndex = 1;
            this.lblPlayers.Text = "Players";
            // 
            // lblHareAndTortoise
            // 
            this.lblHareAndTortoise.AutoSize = true;
            this.lblHareAndTortoise.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHareAndTortoise.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblHareAndTortoise.Location = new System.Drawing.Point(38, 17);
            this.lblHareAndTortoise.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHareAndTortoise.Name = "lblHareAndTortoise";
            this.lblHareAndTortoise.Size = new System.Drawing.Size(360, 51);
            this.lblHareAndTortoise.TabIndex = 0;
            this.lblHareAndTortoise.Text = "Hare and Tortoise";
            // 
            // ColourColumn
            // 
            this.ColourColumn.DataPropertyName = "PlayerTokenImage";
            this.ColourColumn.HeaderText = "Colour";
            this.ColourColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ColourColumn.Name = "ColourColumn";
            this.ColourColumn.ReadOnly = true;
            this.ColourColumn.Width = 40;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 60;
            // 
            // MoneyColumn
            // 
            this.MoneyColumn.DataPropertyName = "Money";
            this.MoneyColumn.HeaderText = "$";
            this.MoneyColumn.Name = "MoneyColumn";
            this.MoneyColumn.ReadOnly = true;
            this.MoneyColumn.Width = 30;
            // 
            // WinnerColumn
            // 
            this.WinnerColumn.DataPropertyName = "HasWon";
            this.WinnerColumn.HeaderText = "Winner";
            this.WinnerColumn.Name = "WinnerColumn";
            this.WinnerColumn.ReadOnly = true;
            this.WinnerColumn.Width = 50;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(HareAndTortoise.Player);
            // 
            // HareAndTortoise_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 1262);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HareAndTortoise_Form";
            this.Text = "Hare and Tortoise";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel gameBoardPanel;
        private System.Windows.Forms.ComboBox cmbNumber;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblHareAndTortoise;
        private System.Windows.Forms.Label lblNumberOfPlayers;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox LstBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.DataGridViewImageColumn ColourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WinnerColumn;
    }
}

