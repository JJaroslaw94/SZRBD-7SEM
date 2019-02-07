namespace Zarządzanie_inwentarzem
{
    partial class DodajPrzedmiot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPrzedmiot));
            System.Windows.Forms.Label prz_IDLabel;
            System.Windows.Forms.Label prz_NazwaLabel;
            System.Windows.Forms.Label prz_LevelLabel;
            this.dataSet = new Zarządzanie_inwentarzem.DataSet();
            this.przedmiotyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przedmiotyTableAdapter = new Zarządzanie_inwentarzem.DataSetTableAdapters.PrzedmiotyTableAdapter();
            this.tableAdapterManager = new Zarządzanie_inwentarzem.DataSetTableAdapters.TableAdapterManager();
            this.przedmiotyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.przedmiotyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prz_IDTextBox = new System.Windows.Forms.TextBox();
            this.prz_NazwaTextBox = new System.Windows.Forms.TextBox();
            this.prz_LevelTextBox = new System.Windows.Forms.TextBox();
            prz_IDLabel = new System.Windows.Forms.Label();
            prz_NazwaLabel = new System.Windows.Forms.Label();
            prz_LevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingNavigator)).BeginInit();
            this.przedmiotyBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // przedmiotyBindingSource
            // 
            this.przedmiotyBindingSource.DataMember = "Przedmioty";
            this.przedmiotyBindingSource.DataSource = this.dataSet;
            // 
            // przedmiotyTableAdapter
            // 
            this.przedmiotyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GraczTableAdapter = null;
            this.tableAdapterManager.PojemnikTableAdapter = null;
            this.tableAdapterManager.PrzedmiotyTableAdapter = this.przedmiotyTableAdapter;
            this.tableAdapterManager.SlotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zarządzanie_inwentarzem.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // przedmiotyBindingNavigator
            // 
            this.przedmiotyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.przedmiotyBindingNavigator.BindingSource = this.przedmiotyBindingSource;
            this.przedmiotyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.przedmiotyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.przedmiotyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.przedmiotyBindingNavigatorSaveItem});
            this.przedmiotyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.przedmiotyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.przedmiotyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.przedmiotyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.przedmiotyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.przedmiotyBindingNavigator.Name = "przedmiotyBindingNavigator";
            this.przedmiotyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.przedmiotyBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.przedmiotyBindingNavigator.TabIndex = 0;
            this.przedmiotyBindingNavigator.Text = "bindingNavigator1";
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
            // przedmiotyBindingNavigatorSaveItem
            // 
            this.przedmiotyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.przedmiotyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("przedmiotyBindingNavigatorSaveItem.Image")));
            this.przedmiotyBindingNavigatorSaveItem.Name = "przedmiotyBindingNavigatorSaveItem";
            this.przedmiotyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.przedmiotyBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.przedmiotyBindingNavigatorSaveItem.Click += new System.EventHandler(this.przedmiotyBindingNavigatorSaveItem_Click);
            // 
            // prz_IDLabel
            // 
            prz_IDLabel.AutoSize = true;
            prz_IDLabel.Location = new System.Drawing.Point(47, 31);
            prz_IDLabel.Name = "prz_IDLabel";
            prz_IDLabel.Size = new System.Drawing.Size(39, 13);
            prz_IDLabel.TabIndex = 1;
            prz_IDLabel.Text = "Prz ID:";
            // 
            // prz_IDTextBox
            // 
            this.prz_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przedmiotyBindingSource, "Prz_ID", true));
            this.prz_IDTextBox.Location = new System.Drawing.Point(114, 28);
            this.prz_IDTextBox.Name = "prz_IDTextBox";
            this.prz_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.prz_IDTextBox.TabIndex = 2;
            // 
            // prz_NazwaLabel
            // 
            prz_NazwaLabel.AutoSize = true;
            prz_NazwaLabel.Location = new System.Drawing.Point(47, 57);
            prz_NazwaLabel.Name = "prz_NazwaLabel";
            prz_NazwaLabel.Size = new System.Drawing.Size(61, 13);
            prz_NazwaLabel.TabIndex = 3;
            prz_NazwaLabel.Text = "Prz Nazwa:";
            // 
            // prz_NazwaTextBox
            // 
            this.prz_NazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przedmiotyBindingSource, "Prz_Nazwa", true));
            this.prz_NazwaTextBox.Location = new System.Drawing.Point(114, 54);
            this.prz_NazwaTextBox.Name = "prz_NazwaTextBox";
            this.prz_NazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.prz_NazwaTextBox.TabIndex = 4;
            // 
            // prz_LevelLabel
            // 
            prz_LevelLabel.AutoSize = true;
            prz_LevelLabel.Location = new System.Drawing.Point(47, 83);
            prz_LevelLabel.Name = "prz_LevelLabel";
            prz_LevelLabel.Size = new System.Drawing.Size(54, 13);
            prz_LevelLabel.TabIndex = 5;
            prz_LevelLabel.Text = "Prz Level:";
            // 
            // prz_LevelTextBox
            // 
            this.prz_LevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przedmiotyBindingSource, "Prz_Level", true));
            this.prz_LevelTextBox.Location = new System.Drawing.Point(114, 80);
            this.prz_LevelTextBox.Name = "prz_LevelTextBox";
            this.prz_LevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.prz_LevelTextBox.TabIndex = 6;
            // 
            // DodajPrzedmiot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 108);
            this.Controls.Add(prz_IDLabel);
            this.Controls.Add(this.prz_IDTextBox);
            this.Controls.Add(prz_NazwaLabel);
            this.Controls.Add(this.prz_NazwaTextBox);
            this.Controls.Add(prz_LevelLabel);
            this.Controls.Add(this.prz_LevelTextBox);
            this.Controls.Add(this.przedmiotyBindingNavigator);
            this.Name = "DodajPrzedmiot";
            this.Text = "DodajPrzedmiot";
            this.Load += new System.EventHandler(this.DodajPrzedmiot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingNavigator)).EndInit();
            this.przedmiotyBindingNavigator.ResumeLayout(false);
            this.przedmiotyBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource przedmiotyBindingSource;
        private DataSetTableAdapters.PrzedmiotyTableAdapter przedmiotyTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator przedmiotyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton przedmiotyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox prz_IDTextBox;
        private System.Windows.Forms.TextBox prz_NazwaTextBox;
        private System.Windows.Forms.TextBox prz_LevelTextBox;
    }
}