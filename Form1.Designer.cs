namespace DatabaseII_FinalProject
{
    partial class Form1
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
            System.Windows.Forms.Label game_TitleLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label console_NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.consoleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.consoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataSet = new DatabaseII_FinalProject.ModelDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consoleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.consoleTableAdapter = new DatabaseII_FinalProject.ModelDataSetTableAdapters.ConsoleTableAdapter();
            this.tableAdapterManager = new DatabaseII_FinalProject.ModelDataSetTableAdapters.TableAdapterManager();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new DatabaseII_FinalProject.ModelDataSetTableAdapters.GameTableAdapter();
            this.game_TitleTextBox = new System.Windows.Forms.TextBox();
            this.gameDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.console_NameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.consoleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            game_TitleLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            console_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consoleBindingNavigator)).BeginInit();
            this.consoleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consoleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // game_TitleLabel
            // 
            game_TitleLabel.AutoSize = true;
            game_TitleLabel.Location = new System.Drawing.Point(21, 52);
            game_TitleLabel.Name = "game_TitleLabel";
            game_TitleLabel.Size = new System.Drawing.Size(76, 16);
            game_TitleLabel.TabIndex = 1;
            game_TitleLabel.Text = "Game Title:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(21, 79);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(41, 16);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Price:";
            // 
            // console_NameLabel
            // 
            console_NameLabel.AutoSize = true;
            console_NameLabel.Location = new System.Drawing.Point(21, 113);
            console_NameLabel.Name = "console_NameLabel";
            console_NameLabel.Size = new System.Drawing.Size(100, 16);
            console_NameLabel.TabIndex = 7;
            console_NameLabel.Text = "Console Name:";
            // 
            // consoleBindingNavigator
            // 
            this.consoleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consoleBindingNavigator.BindingSource = this.consoleBindingSource;
            this.consoleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consoleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consoleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.consoleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.consoleBindingNavigatorSaveItem});
            this.consoleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consoleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consoleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consoleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consoleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consoleBindingNavigator.Name = "consoleBindingNavigator";
            this.consoleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consoleBindingNavigator.Size = new System.Drawing.Size(1070, 27);
            this.consoleBindingNavigator.TabIndex = 0;
            this.consoleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // consoleBindingSource
            // 
            this.consoleBindingSource.DataMember = "Console";
            this.consoleBindingSource.DataSource = this.modelDataSet;
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // consoleBindingNavigatorSaveItem
            // 
            this.consoleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consoleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consoleBindingNavigatorSaveItem.Image")));
            this.consoleBindingNavigatorSaveItem.Name = "consoleBindingNavigatorSaveItem";
            this.consoleBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.consoleBindingNavigatorSaveItem.Text = "Save Data";
            this.consoleBindingNavigatorSaveItem.Click += new System.EventHandler(this.consoleBindingNavigatorSaveItem_Click);
            // 
            // consoleTableAdapter
            // 
            this.consoleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsoleTableAdapter = this.consoleTableAdapter;
            this.tableAdapterManager.GameTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DatabaseII_FinalProject.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "FK_Game_Console_Table";
            this.gameBindingSource.DataSource = this.consoleBindingSource;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // game_TitleTextBox
            // 
            this.game_TitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "Game_Title", true));
            this.game_TitleTextBox.Location = new System.Drawing.Point(127, 49);
            this.game_TitleTextBox.Name = "game_TitleTextBox";
            this.game_TitleTextBox.Size = new System.Drawing.Size(100, 22);
            this.game_TitleTextBox.TabIndex = 2;
            // 
            // gameDataGridView
            // 
            this.gameDataGridView.AutoGenerateColumns = false;
            this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gameDataGridView.DataSource = this.gameBindingSource;
            this.gameDataGridView.Location = new System.Drawing.Point(24, 394);
            this.gameDataGridView.Name = "gameDataGridView";
            this.gameDataGridView.RowHeadersWidth = 51;
            this.gameDataGridView.RowTemplate.Height = 24;
            this.gameDataGridView.Size = new System.Drawing.Size(556, 220);
            this.gameDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GameID";
            this.dataGridViewTextBoxColumn3.HeaderText = "GameID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Game_Title";
            this.dataGridViewTextBoxColumn4.HeaderText = "Game_Title";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ConsoleID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ConsoleID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(127, 76);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 6;
            // 
            // console_NameTextBox
            // 
            this.console_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consoleBindingSource, "Console_Name", true));
            this.console_NameTextBox.Location = new System.Drawing.Point(127, 110);
            this.console_NameTextBox.Name = "console_NameTextBox";
            this.console_NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.console_NameTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // consoleDataGridView
            // 
            this.consoleDataGridView.AutoGenerateColumns = false;
            this.consoleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consoleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.consoleDataGridView.DataSource = this.consoleBindingSource;
            this.consoleDataGridView.Location = new System.Drawing.Point(689, 394);
            this.consoleDataGridView.Name = "consoleDataGridView";
            this.consoleDataGridView.RowHeadersWidth = 51;
            this.consoleDataGridView.RowTemplate.Height = 24;
            this.consoleDataGridView.Size = new System.Drawing.Size(310, 220);
            this.consoleDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ConsoleID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ConsoleID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Console_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Console_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 704);
            this.Controls.Add(this.consoleDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(console_NameLabel);
            this.Controls.Add(this.console_NameTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.gameDataGridView);
            this.Controls.Add(game_TitleLabel);
            this.Controls.Add(this.game_TitleTextBox);
            this.Controls.Add(this.consoleBindingNavigator);
            this.Name = "Form1";
            this.Text = "Add Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consoleBindingNavigator)).EndInit();
            this.consoleBindingNavigator.ResumeLayout(false);
            this.consoleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consoleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource consoleBindingSource;
        private ModelDataSetTableAdapters.ConsoleTableAdapter consoleTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consoleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton consoleBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private ModelDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.TextBox game_TitleTextBox;
        private System.Windows.Forms.DataGridView gameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox console_NameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView consoleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

