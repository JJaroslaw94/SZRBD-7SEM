namespace Zarządzanie_inwentarzem
{
    partial class DodajGraczaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajGraczaForm));
            System.Windows.Forms.Label gracz_IDLabel;
            System.Windows.Forms.Label gracz_NazwaLabel;
            System.Windows.Forms.Label gracz_LevelLabel;
            this.dataSet = new Zarządzanie_inwentarzem.DataSet();
            this.graczBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graczTableAdapter = new Zarządzanie_inwentarzem.DataSetTableAdapters.GraczTableAdapter();
            this.tableAdapterManager = new Zarządzanie_inwentarzem.DataSetTableAdapters.TableAdapterManager();
            this.graczBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.graczBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gracz_IDTextBox = new System.Windows.Forms.TextBox();
            this.gracz_NazwaTextBox = new System.Windows.Forms.TextBox();
            this.gracz_LevelTextBox = new System.Windows.Forms.TextBox();
            gracz_IDLabel = new System.Windows.Forms.Label();
            gracz_NazwaLabel = new System.Windows.Forms.Label();
            gracz_LevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingNavigator)).BeginInit();
            this.graczBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graczBindingSource
            // 
            this.graczBindingSource.DataMember = "Gracz";
            this.graczBindingSource.DataSource = this.dataSet;
            // 
            // graczTableAdapter
            // 
            this.graczTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GraczTableAdapter = this.graczTableAdapter;
            this.tableAdapterManager.PojemnikTableAdapter = null;
            this.tableAdapterManager.PrzedmiotyTableAdapter = null;
            this.tableAdapterManager.SlotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zarządzanie_inwentarzem.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // graczBindingNavigator
            // 
            this.graczBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.graczBindingNavigator.BindingSource = this.graczBindingSource;
            this.graczBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.graczBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.graczBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.graczBindingNavigatorSaveItem});
            this.graczBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.graczBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.graczBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.graczBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.graczBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.graczBindingNavigator.Name = "graczBindingNavigator";
            this.graczBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.graczBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.graczBindingNavigator.TabIndex = 0;
            this.graczBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 15);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // graczBindingNavigatorSaveItem
            // 
            this.graczBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.graczBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("graczBindingNavigatorSaveItem.Image")));
            this.graczBindingNavigatorSaveItem.Name = "graczBindingNavigatorSaveItem";
            this.graczBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.graczBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.graczBindingNavigatorSaveItem.Click += new System.EventHandler(this.graczBindingNavigatorSaveItem_Click);
            // 
            // gracz_IDLabel
            // 
            gracz_IDLabel.AutoSize = true;
            gracz_IDLabel.Location = new System.Drawing.Point(48, 34);
            gracz_IDLabel.Name = "gracz_IDLabel";
            gracz_IDLabel.Size = new System.Drawing.Size(52, 13);
            gracz_IDLabel.TabIndex = 1;
            gracz_IDLabel.Text = "Gracz ID:";
            // 
            // gracz_IDTextBox
            // 
            this.gracz_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.graczBindingSource, "Gracz_ID", true));
            this.gracz_IDTextBox.Location = new System.Drawing.Point(128, 31);
            this.gracz_IDTextBox.Name = "gracz_IDTextBox";
            this.gracz_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.gracz_IDTextBox.TabIndex = 2;
            // 
            // gracz_NazwaLabel
            // 
            gracz_NazwaLabel.AutoSize = true;
            gracz_NazwaLabel.Location = new System.Drawing.Point(48, 60);
            gracz_NazwaLabel.Name = "gracz_NazwaLabel";
            gracz_NazwaLabel.Size = new System.Drawing.Size(74, 13);
            gracz_NazwaLabel.TabIndex = 3;
            gracz_NazwaLabel.Text = "Gracz Nazwa:";
            // 
            // gracz_NazwaTextBox
            // 
            this.gracz_NazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.graczBindingSource, "Gracz_Nazwa", true));
            this.gracz_NazwaTextBox.Location = new System.Drawing.Point(128, 57);
            this.gracz_NazwaTextBox.Name = "gracz_NazwaTextBox";
            this.gracz_NazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gracz_NazwaTextBox.TabIndex = 4;
            // 
            // gracz_LevelLabel
            // 
            gracz_LevelLabel.AutoSize = true;
            gracz_LevelLabel.Location = new System.Drawing.Point(48, 86);
            gracz_LevelLabel.Name = "gracz_LevelLabel";
            gracz_LevelLabel.Size = new System.Drawing.Size(67, 13);
            gracz_LevelLabel.TabIndex = 5;
            gracz_LevelLabel.Text = "Gracz Level:";
            // 
            // gracz_LevelTextBox
            // 
            this.gracz_LevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.graczBindingSource, "Gracz_Level", true));
            this.gracz_LevelTextBox.Location = new System.Drawing.Point(128, 83);
            this.gracz_LevelTextBox.Name = "gracz_LevelTextBox";
            this.gracz_LevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.gracz_LevelTextBox.TabIndex = 6;
            // 
            // DodajGraczaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(gracz_IDLabel);
            this.Controls.Add(this.gracz_IDTextBox);
            this.Controls.Add(gracz_NazwaLabel);
            this.Controls.Add(this.gracz_NazwaTextBox);
            this.Controls.Add(gracz_LevelLabel);
            this.Controls.Add(this.gracz_LevelTextBox);
            this.Controls.Add(this.graczBindingNavigator);
            this.Name = "DodajGraczaForm";
            this.Text = "DodajGraczaForm";
            this.Load += new System.EventHandler(this.DodajGraczaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingNavigator)).EndInit();
            this.graczBindingNavigator.ResumeLayout(false);
            this.graczBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource graczBindingSource;
        private DataSetTableAdapters.GraczTableAdapter graczTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator graczBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton graczBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gracz_IDTextBox;
        private System.Windows.Forms.TextBox gracz_NazwaTextBox;
        private System.Windows.Forms.TextBox gracz_LevelTextBox;
    }
}