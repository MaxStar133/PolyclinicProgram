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
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Врачи");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Диагнозы");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Записи в медкарте");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Запись на приём");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Кабинеты");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Лекарства");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Медицинские услуги");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Медкарты");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Оказанные услуги");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Отделения");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Пациенты");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Платежи");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Приёмы врачей");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Рецепты");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Специальности");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Таблицы", new System.Windows.Forms.TreeNode[] {
            treeNode81,
            treeNode82,
            treeNode83,
            treeNode84,
            treeNode85,
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89,
            treeNode90,
            treeNode91,
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonEndEdit = new System.Windows.Forms.Button();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.поликлиникаDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поликлиникаDataSet = new Polyclinic.ПоликлиникаDataSet();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.103286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.89671F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 435);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 403);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode81.Name = "Врачи";
            treeNode81.Text = "Врачи";
            treeNode82.Name = "Диагнозы";
            treeNode82.Text = "Диагнозы";
            treeNode83.Name = "Записи в медкарте";
            treeNode83.Text = "Записи в медкарте";
            treeNode84.Name = "Запись на приём";
            treeNode84.Text = "Запись на приём";
            treeNode85.Name = "Кабинеты";
            treeNode85.Text = "Кабинеты";
            treeNode86.Name = "Лекарства";
            treeNode86.Text = "Лекарства";
            treeNode87.Name = "Медицинские услуги";
            treeNode87.Text = "Медицинские услуги";
            treeNode88.Name = "Медкарты";
            treeNode88.Text = "Медкарты";
            treeNode89.Name = "Оказанные услуги";
            treeNode89.Text = "Оказанные услуги";
            treeNode90.Name = "Отделения";
            treeNode90.Text = "Отделения";
            treeNode91.Name = "Пациенты";
            treeNode91.Text = "Пациенты";
            treeNode92.Name = "Платежи";
            treeNode92.Text = "Платежи";
            treeNode93.Name = "Приёмы врачей";
            treeNode93.Text = "Приёмы врачей";
            treeNode94.Name = "Рецепты";
            treeNode94.Text = "Рецепты";
            treeNode95.Name = "Специальности";
            treeNode95.Text = "Специальности";
            treeNode96.Name = "Таблицы";
            treeNode96.Text = "Таблицы";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode96});
            this.treeView1.Size = new System.Drawing.Size(151, 397);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(160, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 397);
            this.dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.375F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 456F));
            this.tableLayoutPanel3.Controls.Add(this.buttonAddition, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEndEdit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCancelEdit, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(770, 26);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonAddition
            // 
            this.buttonAddition.Location = new System.Drawing.Point(3, 3);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(120, 20);
            this.buttonAddition.TabIndex = 0;
            this.buttonAddition.Text = "Добавить запись";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.buttonAddition_Click);
            // 
            // buttonEndEdit
            // 
            this.buttonEndEdit.Location = new System.Drawing.Point(130, 3);
            this.buttonEndEdit.Name = "buttonEndEdit";
            this.buttonEndEdit.Size = new System.Drawing.Size(169, 20);
            this.buttonEndEdit.TabIndex = 1;
            this.buttonEndEdit.Text = "Завершить редактирование";
            this.buttonEndEdit.UseVisualStyleBackColor = true;
            this.buttonEndEdit.Click += new System.EventHandler(this.buttonEndEdit_Click);
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Location = new System.Drawing.Point(316, 3);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(154, 20);
            this.buttonCancelEdit.TabIndex = 2;
            this.buttonCancelEdit.Text = "Отменить редактирование";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Click += new System.EventHandler(this.buttonCancelEdit_Click);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonEndEdit;
        private System.Windows.Forms.Button buttonCancelEdit;
    }
}

