namespace Polyclinic
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Врачи");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Диагнозы");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Записи в медкарте");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Запись на приём");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Кабинеты");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Лекарства");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Медицинские услуги");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Медкарты");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Оказанные услуги");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Отделения");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Пациенты");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Платежи");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Приёмы врачей");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Рецепты");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Специальности");
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Record = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddition = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEndEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCancelEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.поликлиникаDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поликлиникаDataSet = new Polyclinic.ПоликлиникаDataSet();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.103286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.89671F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.51948F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.48052F));
            this.tableLayoutPanel2.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(967, 462);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode31.Name = "Врачи";
            treeNode31.Text = "Врачи";
            treeNode32.Name = "Диагнозы";
            treeNode32.Text = "Диагнозы";
            treeNode33.Name = "Записи в медкарте";
            treeNode33.Text = "Записи в медкарте";
            treeNode34.Name = "Запись на приём";
            treeNode34.Text = "Запись на приём";
            treeNode35.Name = "Кабинеты";
            treeNode35.Text = "Кабинеты";
            treeNode36.Name = "Лекарства";
            treeNode36.Text = "Лекарства";
            treeNode37.Name = "Медицинские услуги";
            treeNode37.Text = "Медицинские услуги";
            treeNode38.Name = "Медкарты";
            treeNode38.Text = "Медкарты";
            treeNode39.Name = "Оказанные услуги";
            treeNode39.Text = "Оказанные услуги";
            treeNode40.Name = "Отделения";
            treeNode40.Text = "Отделения";
            treeNode41.Name = "Пациенты";
            treeNode41.Text = "Пациенты";
            treeNode42.Name = "Платежи";
            treeNode42.Text = "Платежи";
            treeNode43.Name = "Приёмы врачей";
            treeNode43.Text = "Приёмы врачей";
            treeNode44.Name = "Рецепты";
            treeNode44.Text = "Рецепты";
            treeNode45.Name = "Специальности";
            treeNode45.Text = "Специальности";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45});
            this.treeView1.Size = new System.Drawing.Size(192, 456);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 456);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Record});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(66, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Record
            // 
            this.Record.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAddition,
            this.buttonEdit,
            this.buttonDelete,
            this.buttonEndEdit,
            this.buttonCancelEdit});
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(58, 20);
            this.Record.Text = "Запись";
            // 
            // buttonAddition
            // 
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(198, 22);
            this.buttonAddition.Text = "Добавить запись";
            this.buttonAddition.Click += new System.EventHandler(this.buttonAddition_Click_1);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(198, 22);
            this.buttonEdit.Text = "Изменить запись";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(198, 22);
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonEndEdit
            // 
            this.buttonEndEdit.Name = "buttonEndEdit";
            this.buttonEndEdit.Size = new System.Drawing.Size(198, 22);
            this.buttonEndEdit.Text = "Завершить изменения";
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(198, 22);
            this.buttonCancelEdit.Text = "Отменить завершения";
            // 
            // поликлиникаDataSetBindingSource
            // 
            this.поликлиникаDataSetBindingSource.DataSource = this.поликлиникаDataSet;
            this.поликлиникаDataSetBindingSource.Position = 0;
            // 
            // поликлиникаDataSet
            // 
            this.поликлиникаDataSet.DataSetName = "ПоликлиникаDataSet";
            this.поликлиникаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource поликлиникаDataSetBindingSource;
        private ПоликлиникаDataSet поликлиникаDataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Record;
        private System.Windows.Forms.ToolStripMenuItem buttonAddition;
        private System.Windows.Forms.ToolStripMenuItem buttonEdit;
        private System.Windows.Forms.ToolStripMenuItem buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem buttonEndEdit;
        private System.Windows.Forms.ToolStripMenuItem buttonCancelEdit;
    }
}

