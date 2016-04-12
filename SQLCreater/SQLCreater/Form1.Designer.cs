namespace SQLCreater
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.testdataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.testdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aigsTestDataSet = new SQLCreater.AigsTestDataSet();
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
            this.testdataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.testdataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testdataTableAdapter = new SQLCreater.AigsTestDataSetTableAdapters.testdataTableAdapter();
            this.tableAdapterManager = new SQLCreater.AigsTestDataSetTableAdapters.TableAdapterManager();
            this.iNSERT文作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETE文作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEINSERT文作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dROPCREATE文作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.testdataBindingNavigator)).BeginInit();
            this.testdataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aigsTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testdataBindingNavigator
            // 
            this.testdataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.testdataBindingNavigator.BindingSource = this.testdataBindingSource;
            this.testdataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testdataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.testdataBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.testdataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.testdataBindingNavigatorSaveItem});
            this.testdataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testdataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testdataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testdataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testdataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testdataBindingNavigator.Name = "testdataBindingNavigator";
            this.testdataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testdataBindingNavigator.Size = new System.Drawing.Size(628, 34);
            this.testdataBindingNavigator.TabIndex = 0;
            this.testdataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 31);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // testdataBindingSource
            // 
            this.testdataBindingSource.DataMember = "testdata";
            this.testdataBindingSource.DataSource = this.aigsTestDataSet;
            // 
            // aigsTestDataSet
            // 
            this.aigsTestDataSet.DataSetName = "AigsTestDataSet";
            this.aigsTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(59, 31);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 31);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 31);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 31);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 34);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 31);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 31);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // testdataBindingNavigatorSaveItem
            // 
            this.testdataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testdataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testdataBindingNavigatorSaveItem.Image")));
            this.testdataBindingNavigatorSaveItem.Name = "testdataBindingNavigatorSaveItem";
            this.testdataBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 31);
            this.testdataBindingNavigatorSaveItem.Text = "データの保存";
            this.testdataBindingNavigatorSaveItem.Click += new System.EventHandler(this.testdataBindingNavigatorSaveItem_Click);
            // 
            // testdataDataGridView
            // 
            this.testdataDataGridView.AutoGenerateColumns = false;
            this.testdataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testdataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.testdataDataGridView.DataSource = this.testdataBindingSource;
            this.testdataDataGridView.Location = new System.Drawing.Point(12, 81);
            this.testdataDataGridView.Name = "testdataDataGridView";
            this.testdataDataGridView.RowTemplate.Height = 27;
            this.testdataDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testdataDataGridView.Size = new System.Drawing.Size(550, 338);
            this.testdataDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn1.HeaderText = "Email";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Full Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn3.HeaderText = "Country";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "User Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "User Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Created At";
            this.dataGridViewTextBoxColumn5.HeaderText = "Created At";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSERT文作成ToolStripMenuItem,
            this.dELETE文作成ToolStripMenuItem,
            this.dELETEINSERT文作成ToolStripMenuItem,
            this.dROPCREATE文作成ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(302, 132);
            // 
            // testdataTableAdapter
            // 
            this.testdataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.testdataTableAdapter = this.testdataTableAdapter;
            this.tableAdapterManager.UpdateOrder = SQLCreater.AigsTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iNSERT文作成ToolStripMenuItem
            // 
            this.iNSERT文作成ToolStripMenuItem.Name = "iNSERT文作成ToolStripMenuItem";
            this.iNSERT文作成ToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.iNSERT文作成ToolStripMenuItem.Text = "INSERT文作成";
            // 
            // dELETE文作成ToolStripMenuItem
            // 
            this.dELETE文作成ToolStripMenuItem.Name = "dELETE文作成ToolStripMenuItem";
            this.dELETE文作成ToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.dELETE文作成ToolStripMenuItem.Text = "DELETE文作成";
            // 
            // dELETEINSERT文作成ToolStripMenuItem
            // 
            this.dELETEINSERT文作成ToolStripMenuItem.Name = "dELETEINSERT文作成ToolStripMenuItem";
            this.dELETEINSERT文作成ToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.dELETEINSERT文作成ToolStripMenuItem.Text = "DELETE＆INSERT文作成";
            // 
            // dROPCREATE文作成ToolStripMenuItem
            // 
            this.dROPCREATE文作成ToolStripMenuItem.Name = "dROPCREATE文作成ToolStripMenuItem";
            this.dROPCREATE文作成ToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.dROPCREATE文作成ToolStripMenuItem.Text = "DROP＆CREATE文作成";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 445);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.testdataDataGridView);
            this.Controls.Add(this.testdataBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testdataBindingNavigator)).EndInit();
            this.testdataBindingNavigator.ResumeLayout(false);
            this.testdataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aigsTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AigsTestDataSet aigsTestDataSet;
        private System.Windows.Forms.BindingSource testdataBindingSource;
        private AigsTestDataSetTableAdapters.testdataTableAdapter testdataTableAdapter;
        private AigsTestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testdataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton testdataBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView testdataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNSERT文作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETE文作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEINSERT文作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dROPCREATE文作成ToolStripMenuItem;
    }
}

