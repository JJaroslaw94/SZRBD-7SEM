namespace Zarządzanie_inwentarzem
{
    partial class DodajPojemnik
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
            System.Windows.Forms.Label poj_IDLabel;
            System.Windows.Forms.Label gracz_IDLabel;
            System.Windows.Forms.Label poj_NazwaLabel;
            System.Windows.Forms.Label poj_SlotyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPojemnik));
            System.Windows.Forms.Label prz_IDLabel;
            System.Windows.Forms.Label prz_NazwaLabel;
            System.Windows.Forms.Label prz_LevelLabel;
            System.Windows.Forms.Label expr1Label;
            System.Windows.Forms.Label poj_IDLabel1;
            System.Windows.Forms.Label slot_IDLabel;
            this.dataSet = new Zarządzanie_inwentarzem.DataSet();
            this.pojemnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pojemnikTableAdapter = new Zarządzanie_inwentarzem.DataSetTableAdapters.PojemnikTableAdapter();
            this.tableAdapterManager = new Zarządzanie_inwentarzem.DataSetTableAdapters.TableAdapterManager();
            this.pojemnikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.pojemnikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.poj_IDTextBox = new System.Windows.Forms.TextBox();
            this.gracz_IDTextBox = new System.Windows.Forms.TextBox();
            this.poj_NazwaTextBox = new System.Windows.Forms.TextBox();
            this.poj_SlotyTextBox = new System.Windows.Forms.TextBox();
            this.slotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slotTableAdapter = new Zarządzanie_inwentarzem.DataSetTableAdapters.SlotTableAdapter();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Zarządzanie_inwentarzem.DataSetTableAdapters.DataTable1TableAdapter();
            this.prz_IDTextBox = new System.Windows.Forms.TextBox();
            this.prz_NazwaTextBox = new System.Windows.Forms.TextBox();
            this.prz_LevelTextBox = new System.Windows.Forms.TextBox();
            this.expr1TextBox = new System.Windows.Forms.TextBox();
            this.poj_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.slot_IDTextBox = new System.Windows.Forms.TextBox();
            poj_IDLabel = new System.Windows.Forms.Label();
            gracz_IDLabel = new System.Windows.Forms.Label();
            poj_NazwaLabel = new System.Windows.Forms.Label();
            poj_SlotyLabel = new System.Windows.Forms.Label();
            prz_IDLabel = new System.Windows.Forms.Label();
            prz_NazwaLabel = new System.Windows.Forms.Label();
            prz_LevelLabel = new System.Windows.Forms.Label();
            expr1Label = new System.Windows.Forms.Label();
            poj_IDLabel1 = new System.Windows.Forms.Label();
            slot_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojemnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojemnikBindingNavigator)).BeginInit();
            this.pojemnikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // poj_IDLabel
            // 
            poj_IDLabel.AutoSize = true;
            poj_IDLabel.Location = new System.Drawing.Point(52, 31);
            poj_IDLabel.Name = "poj_IDLabel";
            poj_IDLabel.Size = new System.Drawing.Size(39, 13);
            poj_IDLabel.TabIndex = 1;
            poj_IDLabel.Text = "Poj ID:";
            // 
            // gracz_IDLabel
            // 
            gracz_IDLabel.AutoSize = true;
            gracz_IDLabel.Location = new System.Drawing.Point(52, 57);
            gracz_IDLabel.Name = "gracz_IDLabel";
            gracz_IDLabel.Size = new System.Drawing.Size(52, 13);
            gracz_IDLabel.TabIndex = 3;
            gracz_IDLabel.Text = "Gracz ID:";
            // 
            // poj_NazwaLabel
            // 
            poj_NazwaLabel.AutoSize = true;
            poj_NazwaLabel.Location = new System.Drawing.Point(52, 83);
            poj_NazwaLabel.Name = "poj_NazwaLabel";
            poj_NazwaLabel.Size = new System.Drawing.Size(61, 13);
            poj_NazwaLabel.TabIndex = 5;
            poj_NazwaLabel.Text = "Poj Nazwa:";
            // 
            // poj_SlotyLabel
            // 
            poj_SlotyLabel.AutoSize = true;
            poj_SlotyLabel.Location = new System.Drawing.Point(52, 109);
            poj_SlotyLabel.Name = "poj_SlotyLabel";
            poj_SlotyLabel.Size = new System.Drawing.Size(51, 13);
            poj_SlotyLabel.TabIndex = 7;
            poj_SlotyLabel.Text = "Poj Sloty:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pojemnikBindingSource
            // 
            this.pojemnikBindingSource.DataMember = "Pojemnik";
            this.pojemnikBindingSource.DataSource = this.dataSet;
            // 
            // pojemnikTableAdapter
            // 
            this.pojemnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GraczTableAdapter = null;
            this.tableAdapterManager.PojemnikTableAdapter = this.pojemnikTableAdapter;
            this.tableAdapterManager.PrzedmiotyTableAdapter = null;
            this.tableAdapterManager.SlotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zarządzanie_inwentarzem.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pojemnikBindingNavigator
            // 
            this.pojemnikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pojemnikBindingNavigator.BindingSource = this.pojemnikBindingSource;
            this.pojemnikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pojemnikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pojemnikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pojemnikBindingNavigatorSaveItem});
            this.pojemnikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pojemnikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pojemnikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pojemnikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pojemnikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pojemnikBindingNavigator.Name = "pojemnikBindingNavigator";
            this.pojemnikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pojemnikBindingNavigator.Size = new System.Drawing.Size(275, 25);
            this.pojemnikBindingNavigator.TabIndex = 0;
            this.pojemnikBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pojemnikBindingNavigatorSaveItem
            // 
            this.pojemnikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pojemnikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pojemnikBindingNavigatorSaveItem.Image")));
            this.pojemnikBindingNavigatorSaveItem.Name = "pojemnikBindingNavigatorSaveItem";
            this.pojemnikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pojemnikBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.pojemnikBindingNavigatorSaveItem.Click += new System.EventHandler(this.pojemnikBindingNavigatorSaveItem_Click);
            // 
            // poj_IDTextBox
            // 
            this.poj_IDTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.poj_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pojemnikBindingSource, "Poj_ID", true));
            this.poj_IDTextBox.Location = new System.Drawing.Point(119, 28);
            this.poj_IDTextBox.Name = "poj_IDTextBox";
            this.poj_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.poj_IDTextBox.TabIndex = 2;
            // 
            // gracz_IDTextBox
            // 
            this.gracz_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pojemnikBindingSource, "Gracz_ID", true));
            this.gracz_IDTextBox.Location = new System.Drawing.Point(119, 54);
            this.gracz_IDTextBox.Name = "gracz_IDTextBox";
            this.gracz_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.gracz_IDTextBox.TabIndex = 4;
            // 
            // poj_NazwaTextBox
            // 
            this.poj_NazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pojemnikBindingSource, "Poj_Nazwa", true));
            this.poj_NazwaTextBox.Location = new System.Drawing.Point(119, 80);
            this.poj_NazwaTextBox.Name = "poj_NazwaTextBox";
            this.poj_NazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.poj_NazwaTextBox.TabIndex = 6;
            // 
            // poj_SlotyTextBox
            // 
            this.poj_SlotyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pojemnikBindingSource, "Poj_Sloty", true));
            this.poj_SlotyTextBox.Location = new System.Drawing.Point(119, 106);
            this.poj_SlotyTextBox.Name = "poj_SlotyTextBox";
            this.poj_SlotyTextBox.Size = new System.Drawing.Size(100, 20);
            this.poj_SlotyTextBox.TabIndex = 8;
            // 
            // slotBindingSource
            // 
            this.slotBindingSource.DataMember = "Slot";
            this.slotBindingSource.DataSource = this.dataSet;
            // 
            // slotTableAdapter
            // 
            this.slotTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // prz_IDLabel
            // 
            prz_IDLabel.AutoSize = true;
            prz_IDLabel.Location = new System.Drawing.Point(479, 68);
            prz_IDLabel.Name = "prz_IDLabel";
            prz_IDLabel.Size = new System.Drawing.Size(39, 13);
            prz_IDLabel.TabIndex = 9;
            prz_IDLabel.Text = "Prz ID:";
            // 
            // prz_IDTextBox
            // 
            this.prz_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Prz_ID", true));
            this.prz_IDTextBox.Location = new System.Drawing.Point(546, 65);
            this.prz_IDTextBox.Name = "prz_IDTextBox";
            this.prz_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.prz_IDTextBox.TabIndex = 10;
            // 
            // prz_NazwaLabel
            // 
            prz_NazwaLabel.AutoSize = true;
            prz_NazwaLabel.Location = new System.Drawing.Point(479, 94);
            prz_NazwaLabel.Name = "prz_NazwaLabel";
            prz_NazwaLabel.Size = new System.Drawing.Size(61, 13);
            prz_NazwaLabel.TabIndex = 11;
            prz_NazwaLabel.Text = "Prz Nazwa:";
            // 
            // prz_NazwaTextBox
            // 
            this.prz_NazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Prz_Nazwa", true));
            this.prz_NazwaTextBox.Location = new System.Drawing.Point(546, 91);
            this.prz_NazwaTextBox.Name = "prz_NazwaTextBox";
            this.prz_NazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.prz_NazwaTextBox.TabIndex = 12;
            // 
            // prz_LevelLabel
            // 
            prz_LevelLabel.AutoSize = true;
            prz_LevelLabel.Location = new System.Drawing.Point(479, 120);
            prz_LevelLabel.Name = "prz_LevelLabel";
            prz_LevelLabel.Size = new System.Drawing.Size(54, 13);
            prz_LevelLabel.TabIndex = 13;
            prz_LevelLabel.Text = "Prz Level:";
            // 
            // prz_LevelTextBox
            // 
            this.prz_LevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Prz_Level", true));
            this.prz_LevelTextBox.Location = new System.Drawing.Point(546, 117);
            this.prz_LevelTextBox.Name = "prz_LevelTextBox";
            this.prz_LevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.prz_LevelTextBox.TabIndex = 14;
            // 
            // expr1Label
            // 
            expr1Label.AutoSize = true;
            expr1Label.Location = new System.Drawing.Point(479, 146);
            expr1Label.Name = "expr1Label";
            expr1Label.Size = new System.Drawing.Size(37, 13);
            expr1Label.TabIndex = 15;
            expr1Label.Text = "Expr1:";
            // 
            // expr1TextBox
            // 
            this.expr1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Expr1", true));
            this.expr1TextBox.Location = new System.Drawing.Point(546, 143);
            this.expr1TextBox.Name = "expr1TextBox";
            this.expr1TextBox.Size = new System.Drawing.Size(100, 20);
            this.expr1TextBox.TabIndex = 16;
            // 
            // poj_IDLabel1
            // 
            poj_IDLabel1.AutoSize = true;
            poj_IDLabel1.Location = new System.Drawing.Point(479, 172);
            poj_IDLabel1.Name = "poj_IDLabel1";
            poj_IDLabel1.Size = new System.Drawing.Size(39, 13);
            poj_IDLabel1.TabIndex = 17;
            poj_IDLabel1.Text = "Poj ID:";
            // 
            // poj_IDTextBox1
            // 
            this.poj_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Poj_ID", true));
            this.poj_IDTextBox1.Location = new System.Drawing.Point(546, 169);
            this.poj_IDTextBox1.Name = "poj_IDTextBox1";
            this.poj_IDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.poj_IDTextBox1.TabIndex = 18;
            // 
            // slot_IDLabel
            // 
            slot_IDLabel.AutoSize = true;
            slot_IDLabel.Location = new System.Drawing.Point(479, 198);
            slot_IDLabel.Name = "slot_IDLabel";
            slot_IDLabel.Size = new System.Drawing.Size(42, 13);
            slot_IDLabel.TabIndex = 19;
            slot_IDLabel.Text = "Slot ID:";
            // 
            // slot_IDTextBox
            // 
            this.slot_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Slot_ID", true));
            this.slot_IDTextBox.Location = new System.Drawing.Point(546, 195);
            this.slot_IDTextBox.Name = "slot_IDTextBox";
            this.slot_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.slot_IDTextBox.TabIndex = 20;
            // 
            // DodajPojemnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 160);
            this.Controls.Add(prz_IDLabel);
            this.Controls.Add(this.prz_IDTextBox);
            this.Controls.Add(prz_NazwaLabel);
            this.Controls.Add(this.prz_NazwaTextBox);
            this.Controls.Add(prz_LevelLabel);
            this.Controls.Add(this.prz_LevelTextBox);
            this.Controls.Add(expr1Label);
            this.Controls.Add(this.expr1TextBox);
            this.Controls.Add(poj_IDLabel1);
            this.Controls.Add(this.poj_IDTextBox1);
            this.Controls.Add(slot_IDLabel);
            this.Controls.Add(this.slot_IDTextBox);
            this.Controls.Add(poj_IDLabel);
            this.Controls.Add(this.poj_IDTextBox);
            this.Controls.Add(gracz_IDLabel);
            this.Controls.Add(this.gracz_IDTextBox);
            this.Controls.Add(poj_NazwaLabel);
            this.Controls.Add(this.poj_NazwaTextBox);
            this.Controls.Add(poj_SlotyLabel);
            this.Controls.Add(this.poj_SlotyTextBox);
            this.Controls.Add(this.pojemnikBindingNavigator);
            this.Name = "DodajPojemnik";
            this.Text = "DodajPojemnik";
            this.Load += new System.EventHandler(this.DodajPojemnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojemnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojemnikBindingNavigator)).EndInit();
            this.pojemnikBindingNavigator.ResumeLayout(false);
            this.pojemnikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource pojemnikBindingSource;
        private DataSetTableAdapters.PojemnikTableAdapter pojemnikTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pojemnikBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pojemnikBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox poj_IDTextBox;
        private System.Windows.Forms.TextBox gracz_IDTextBox;
        private System.Windows.Forms.TextBox poj_NazwaTextBox;
        private System.Windows.Forms.TextBox poj_SlotyTextBox;
        private System.Windows.Forms.BindingSource slotBindingSource;
        private DataSetTableAdapters.SlotTableAdapter slotTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.TextBox prz_IDTextBox;
        private System.Windows.Forms.TextBox prz_NazwaTextBox;
        private System.Windows.Forms.TextBox prz_LevelTextBox;
        private System.Windows.Forms.TextBox expr1TextBox;
        private System.Windows.Forms.TextBox poj_IDTextBox1;
        private System.Windows.Forms.TextBox slot_IDTextBox;
    }
}