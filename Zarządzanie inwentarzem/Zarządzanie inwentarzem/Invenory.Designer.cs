namespace Zarządzanie_inwentarzem
{
    partial class Invenory
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invenory));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pojemnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graczBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Zarządzanie_inwentarzem.DataSet();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.przedmiotyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.graczTableAdapter2 = new Zarządzanie_inwentarzem.DataSetTableAdapters.GraczTableAdapter();
            this.tableAdapterManager2 = new Zarządzanie_inwentarzem.DataSetTableAdapters.TableAdapterManager();
            this.pojemnikTableAdapter = new Zarządzanie_inwentarzem.DataSetTableAdapters.PojemnikTableAdapter();
            this.przedmiotyTableAdapter = new Zarządzanie_inwentarzem.DataSetTableAdapters.PrzedmiotyTableAdapter();
            this.graczBindingSource2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.graczBindingSource2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gracz_NazwaTextBox = new System.Windows.Forms.TextBox();
            this.poj_NazwaTextBox = new System.Windows.Forms.TextBox();
            this.dataTable1TableAdapter = new Zarządzanie_inwentarzem.DataSetTableAdapters.DataTable1TableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.slotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slotTableAdapter = new Zarządzanie_inwentarzem.DataSetTableAdapters.SlotTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojemnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource2BindingNavigator)).BeginInit();
            this.graczBindingSource2BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Poprzedni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Następny";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Gracz:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Pojemnik:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Poprzedni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Następny";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.dataTable1BindingSource;
            this.listBox1.DisplayMember = "Prz_Nazwa";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 290);
            this.listBox1.TabIndex = 34;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "Pojemnik_DataTable1";
            this.dataTable1BindingSource.DataSource = this.pojemnikBindingSource;
            // 
            // pojemnikBindingSource
            // 
            this.pojemnikBindingSource.DataMember = "Gracz_Pojemnik";
            this.pojemnikBindingSource.DataSource = this.graczBindingSource2;
            // 
            // graczBindingSource2
            // 
            this.graczBindingSource2.DataMember = "Gracz";
            this.graczBindingSource2.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox2
            // 
            this.listBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataTable1BindingSource, "Prz_Nazwa", true));
            this.listBox2.DataSource = this.przedmiotyBindingSource;
            this.listBox2.DisplayMember = "Prz_Nazwa";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(419, 107);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(356, 290);
            this.listBox2.TabIndex = 35;
            this.listBox2.ValueMember = "Prz_Nazwa";
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // przedmiotyBindingSource
            // 
            this.przedmiotyBindingSource.DataMember = "Przedmioty";
            this.przedmiotyBindingSource.DataSource = this.dataSet2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Lista Przedmiotów";
            // 
            // graczTableAdapter2
            // 
            this.graczTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.GraczTableAdapter = this.graczTableAdapter2;
            this.tableAdapterManager2.PojemnikTableAdapter = this.pojemnikTableAdapter;
            this.tableAdapterManager2.PrzedmiotyTableAdapter = this.przedmiotyTableAdapter;
            this.tableAdapterManager2.SlotTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = Zarządzanie_inwentarzem.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pojemnikTableAdapter
            // 
            this.pojemnikTableAdapter.ClearBeforeFill = true;
            // 
            // przedmiotyTableAdapter
            // 
            this.przedmiotyTableAdapter.ClearBeforeFill = true;
            // 
            // graczBindingSource2BindingNavigator
            // 
            this.graczBindingSource2BindingNavigator.AddNewItem = this.toolStripButton11;
            this.graczBindingSource2BindingNavigator.BindingSource = this.graczBindingSource2;
            this.graczBindingSource2BindingNavigator.CountItem = this.toolStripLabel2;
            this.graczBindingSource2BindingNavigator.DeleteItem = this.toolStripButton12;
            this.graczBindingSource2BindingNavigator.ImeMode = System.Windows.Forms.ImeMode.On;
            this.graczBindingSource2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator6,
            this.toolStripButton11,
            this.toolStripButton12,
            this.graczBindingSource2BindingNavigatorSaveItem});
            this.graczBindingSource2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.graczBindingSource2BindingNavigator.MoveFirstItem = this.toolStripButton7;
            this.graczBindingSource2BindingNavigator.MoveLastItem = this.toolStripButton10;
            this.graczBindingSource2BindingNavigator.MoveNextItem = this.toolStripButton9;
            this.graczBindingSource2BindingNavigator.MovePreviousItem = this.toolStripButton8;
            this.graczBindingSource2BindingNavigator.Name = "graczBindingSource2BindingNavigator";
            this.graczBindingSource2BindingNavigator.PositionItem = this.toolStripTextBox2;
            this.graczBindingSource2BindingNavigator.Size = new System.Drawing.Size(1100, 25);
            this.graczBindingSource2BindingNavigator.TabIndex = 39;
            this.graczBindingSource2BindingNavigator.Text = "bindingNavigator1";
            this.graczBindingSource2BindingNavigator.Visible = false;
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Dodaj nowy";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel2.Text = "z {0}";
            this.toolStripLabel2.ToolTipText = "Suma elementów";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Usuń";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Przenieś pierwszy";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Przenieś poprzedni";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Pozycja";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Bieżąca pozycja";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Przenieś następny";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Przenieś ostatni";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // graczBindingSource2BindingNavigatorSaveItem
            // 
            this.graczBindingSource2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.graczBindingSource2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("graczBindingSource2BindingNavigatorSaveItem.Image")));
            this.graczBindingSource2BindingNavigatorSaveItem.Name = "graczBindingSource2BindingNavigatorSaveItem";
            this.graczBindingSource2BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.graczBindingSource2BindingNavigatorSaveItem.Text = "Zapisz dane";
            this.graczBindingSource2BindingNavigatorSaveItem.Click += new System.EventHandler(this.graczBindingSource2BindingNavigatorSaveItem_Click);
            // 
            // gracz_NazwaTextBox
            // 
            this.gracz_NazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.graczBindingSource2, "Gracz_Nazwa", true));
            this.gracz_NazwaTextBox.Location = new System.Drawing.Point(140, 38);
            this.gracz_NazwaTextBox.Name = "gracz_NazwaTextBox";
            this.gracz_NazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gracz_NazwaTextBox.TabIndex = 42;
            this.gracz_NazwaTextBox.TextChanged += new System.EventHandler(this.gracz_NazwaTextBox_TextChanged);
            // 
            // poj_NazwaTextBox
            // 
            this.poj_NazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pojemnikBindingSource, "Poj_Nazwa", true));
            this.poj_NazwaTextBox.Location = new System.Drawing.Point(140, 67);
            this.poj_NazwaTextBox.Name = "poj_NazwaTextBox";
            this.poj_NazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.poj_NazwaTextBox.TabIndex = 49;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(327, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 50;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(327, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 23);
            this.button6.TabIndex = 51;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(648, 65);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 23);
            this.button7.TabIndex = 52;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(9, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 53;
            this.button8.Text = "ZAPISZ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(93, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 54;
            this.button9.Text = "Update";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // slotBindingSource
            // 
            this.slotBindingSource.DataMember = "Slot";
            this.slotBindingSource.DataSource = this.dataSet2;
            // 
            // slotTableAdapter
            // 
            this.slotTableAdapter.ClearBeforeFill = true;
            // 
            // Invenory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 417);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.poj_NazwaTextBox);
            this.Controls.Add(this.gracz_NazwaTextBox);
            this.Controls.Add(this.graczBindingSource2BindingNavigator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Invenory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojemnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource2BindingNavigator)).EndInit();
            this.graczBindingSource2BindingNavigator.ResumeLayout(false);
            this.graczBindingSource2BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slotBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
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
        private DataSet dataSet1;
        private System.Windows.Forms.BindingSource graczBindingSource1;
        private DataSetTableAdapters.GraczTableAdapter graczTableAdapter1;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator graczBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton graczBindingSource1BindingNavigatorSaveItem;
        private DataSet dataSet2;
        private System.Windows.Forms.BindingSource graczBindingSource2;
        private DataSetTableAdapters.GraczTableAdapter graczTableAdapter2;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingNavigator graczBindingSource2BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton graczBindingSource2BindingNavigatorSaveItem;
        private DataSetTableAdapters.PojemnikTableAdapter pojemnikTableAdapter;
        private System.Windows.Forms.TextBox gracz_NazwaTextBox;
        private System.Windows.Forms.BindingSource pojemnikBindingSource;
        private System.Windows.Forms.TextBox poj_NazwaTextBox;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DataSetTableAdapters.PrzedmiotyTableAdapter przedmiotyTableAdapter;
        private System.Windows.Forms.BindingSource przedmiotyBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.BindingSource slotBindingSource;
        private DataSetTableAdapters.SlotTableAdapter slotTableAdapter;
    }
}

