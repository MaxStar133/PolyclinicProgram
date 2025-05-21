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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Врачи");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Диагнозы");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Записи в медкарте");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Запись на приём");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Кабинеты");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Лекарства");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Медицинские услуги");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Медкарты");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Оказанные услуги");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Отделения");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Пациенты");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Платежи");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Приёмы врачей");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Рецепты");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Специальности");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Таблицы", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Record = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddition = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиВМедкартеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиНаПриёмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оказанныеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мужчиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.женщиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискВрачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоФИОToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.приёмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оказанныеУслугиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.неоплаченныеПлатежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплаченныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неоплаченныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ожидаютсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиНаПриёмToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменённыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ожидаютсяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEndEdit = new System.Windows.Forms.Button();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.поликлиникаDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поликлиникаDataSet = new Polyclinic.ПоликлиникаDataSet();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
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
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.FullRowSelect = true;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Врачи";
            treeNode1.Text = "Врачи";
            treeNode2.Name = "Диагнозы";
            treeNode2.Text = "Диагнозы";
            treeNode3.Name = "Записи в медкарте";
            treeNode3.Text = "Записи в медкарте";
            treeNode4.Name = "Запись на приём";
            treeNode4.Text = "Запись на приём";
            treeNode5.Name = "Кабинеты";
            treeNode5.Text = "Кабинеты";
            treeNode6.Name = "Лекарства";
            treeNode6.Text = "Лекарства";
            treeNode7.Name = "Медицинские услуги";
            treeNode7.Text = "Медицинские услуги";
            treeNode8.Name = "Медкарты";
            treeNode8.Text = "Медкарты";
            treeNode9.Name = "Оказанные услуги";
            treeNode9.Text = "Оказанные услуги";
            treeNode10.Name = "Отделения";
            treeNode10.Text = "Отделения";
            treeNode11.Name = "Пациенты";
            treeNode11.Text = "Пациенты";
            treeNode12.Name = "Платежи";
            treeNode12.Text = "Платежи";
            treeNode13.Name = "Приёмы врачей";
            treeNode13.Text = "Приёмы врачей";
            treeNode14.Name = "Рецепты";
            treeNode14.Text = "Рецепты";
            treeNode15.Name = "Специальности";
            treeNode15.Text = "Специальности";
            treeNode16.Name = "Tables";
            treeNode16.Text = "Таблицы";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.70112F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.29888F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel3.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEndEdit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCancelEdit, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(973, 30);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Record,
            this.запросыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(229, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Record
            // 
            this.Record.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAddition,
            this.buttonEdit,
            this.buttonDelete});
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(59, 20);
            this.Record.Text = "Записи";
            // 
            // buttonAddition
            // 
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.buttonAddition.Size = new System.Drawing.Size(232, 22);
            this.buttonAddition.Text = "Добавить запись";
            this.buttonAddition.Click += new System.EventHandler(this.buttonAddition_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.buttonEdit.Size = new System.Drawing.Size(232, 22);
            this.buttonEdit.Text = "Изменить запись";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.buttonDelete.Size = new System.Drawing.Size(232, 22);
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентToolStripMenuItem,
            this.поискВрачаToolStripMenuItem,
            this.неоплаченныеПлатежиToolStripMenuItem,
            this.записиНаПриёмToolStripMenuItem1});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // пациентToolStripMenuItem
            // 
            this.пациентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоФИОToolStripMenuItem,
            this.записиВМедкартеToolStripMenuItem,
            this.записиНаПриёмToolStripMenuItem,
            this.рецептыToolStripMenuItem,
            this.оказанныеУслугиToolStripMenuItem,
            this.платежиToolStripMenuItem,
            this.полToolStripMenuItem});
            this.пациентToolStripMenuItem.Name = "пациентToolStripMenuItem";
            this.пациентToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.пациентToolStripMenuItem.Text = "Пациент";
            // 
            // поискПоФИОToolStripMenuItem
            // 
            this.поискПоФИОToolStripMenuItem.Name = "поискПоФИОToolStripMenuItem";
            this.поискПоФИОToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.поискПоФИОToolStripMenuItem.Text = "Поиск по ФИО";
            this.поискПоФИОToolStripMenuItem.Click += new System.EventHandler(this.поискПоФИОToolStripMenuItem_Click);
            // 
            // записиВМедкартеToolStripMenuItem
            // 
            this.записиВМедкартеToolStripMenuItem.Name = "записиВМедкартеToolStripMenuItem";
            this.записиВМедкартеToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.записиВМедкартеToolStripMenuItem.Text = "Записи в медкарте";
            this.записиВМедкартеToolStripMenuItem.Click += new System.EventHandler(this.записиВМедкартеToolStripMenuItem_Click);
            // 
            // записиНаПриёмToolStripMenuItem
            // 
            this.записиНаПриёмToolStripMenuItem.Name = "записиНаПриёмToolStripMenuItem";
            this.записиНаПриёмToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.записиНаПриёмToolStripMenuItem.Text = "Записи на приём";
            this.записиНаПриёмToolStripMenuItem.Click += new System.EventHandler(this.записиНаПриёмToolStripMenuItem_Click);
            // 
            // рецептыToolStripMenuItem
            // 
            this.рецептыToolStripMenuItem.Name = "рецептыToolStripMenuItem";
            this.рецептыToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.рецептыToolStripMenuItem.Text = "Рецепты";
            this.рецептыToolStripMenuItem.Click += new System.EventHandler(this.рецептыToolStripMenuItem_Click);
            // 
            // оказанныеУслугиToolStripMenuItem
            // 
            this.оказанныеУслугиToolStripMenuItem.Name = "оказанныеУслугиToolStripMenuItem";
            this.оказанныеУслугиToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.оказанныеУслугиToolStripMenuItem.Text = "Оказанные услуги";
            this.оказанныеУслугиToolStripMenuItem.Click += new System.EventHandler(this.оказанныеУслугиToolStripMenuItem_Click);
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.платежиToolStripMenuItem.Text = "Платежи";
            this.платежиToolStripMenuItem.Click += new System.EventHandler(this.платежиToolStripMenuItem_Click);
            // 
            // полToolStripMenuItem
            // 
            this.полToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мужчиныToolStripMenuItem,
            this.женщиныToolStripMenuItem});
            this.полToolStripMenuItem.Name = "полToolStripMenuItem";
            this.полToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.полToolStripMenuItem.Text = "Пол";
            // 
            // мужчиныToolStripMenuItem
            // 
            this.мужчиныToolStripMenuItem.Name = "мужчиныToolStripMenuItem";
            this.мужчиныToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.мужчиныToolStripMenuItem.Text = "Мужчины";
            this.мужчиныToolStripMenuItem.Click += new System.EventHandler(this.мужчиныToolStripMenuItem_Click);
            // 
            // женщиныToolStripMenuItem
            // 
            this.женщиныToolStripMenuItem.Name = "женщиныToolStripMenuItem";
            this.женщиныToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.женщиныToolStripMenuItem.Text = "Женщины";
            this.женщиныToolStripMenuItem.Click += new System.EventHandler(this.женщиныToolStripMenuItem_Click);
            // 
            // поискВрачаToolStripMenuItem
            // 
            this.поискВрачаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоФИОToolStripMenuItem1,
            this.приёмыToolStripMenuItem,
            this.оказанныеУслугиToolStripMenuItem1});
            this.поискВрачаToolStripMenuItem.Name = "поискВрачаToolStripMenuItem";
            this.поискВрачаToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.поискВрачаToolStripMenuItem.Text = "Врач";
            // 
            // поискПоФИОToolStripMenuItem1
            // 
            this.поискПоФИОToolStripMenuItem1.Name = "поискПоФИОToolStripMenuItem1";
            this.поискПоФИОToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.поискПоФИОToolStripMenuItem1.Text = "Поиск по ФИО";
            this.поискПоФИОToolStripMenuItem1.Click += new System.EventHandler(this.поискПоФИОToolStripMenuItem1_Click);
            // 
            // приёмыToolStripMenuItem
            // 
            this.приёмыToolStripMenuItem.Name = "приёмыToolStripMenuItem";
            this.приёмыToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.приёмыToolStripMenuItem.Text = "Приёмы";
            this.приёмыToolStripMenuItem.Click += new System.EventHandler(this.приёмыToolStripMenuItem_Click);
            // 
            // оказанныеУслугиToolStripMenuItem1
            // 
            this.оказанныеУслугиToolStripMenuItem1.Name = "оказанныеУслугиToolStripMenuItem1";
            this.оказанныеУслугиToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.оказанныеУслугиToolStripMenuItem1.Text = "Оказанные услуги";
            this.оказанныеУслугиToolStripMenuItem1.Click += new System.EventHandler(this.оказанныеУслугиToolStripMenuItem1_Click);
            // 
            // неоплаченныеПлатежиToolStripMenuItem
            // 
            this.неоплаченныеПлатежиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оплаченныеToolStripMenuItem,
            this.неоплаченныеToolStripMenuItem,
            this.ожидаютсяToolStripMenuItem});
            this.неоплаченныеПлатежиToolStripMenuItem.Name = "неоплаченныеПлатежиToolStripMenuItem";
            this.неоплаченныеПлатежиToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.неоплаченныеПлатежиToolStripMenuItem.Text = "Платежи";
            // 
            // оплаченныеToolStripMenuItem
            // 
            this.оплаченныеToolStripMenuItem.Name = "оплаченныеToolStripMenuItem";
            this.оплаченныеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оплаченныеToolStripMenuItem.Text = "Оплаченные";
            this.оплаченныеToolStripMenuItem.Click += new System.EventHandler(this.оплаченныеToolStripMenuItem_Click);
            // 
            // неоплаченныеToolStripMenuItem
            // 
            this.неоплаченныеToolStripMenuItem.Name = "неоплаченныеToolStripMenuItem";
            this.неоплаченныеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.неоплаченныеToolStripMenuItem.Text = "Неоплаченные";
            this.неоплаченныеToolStripMenuItem.Click += new System.EventHandler(this.неоплаченныеToolStripMenuItem_Click);
            // 
            // ожидаютсяToolStripMenuItem
            // 
            this.ожидаютсяToolStripMenuItem.Name = "ожидаютсяToolStripMenuItem";
            this.ожидаютсяToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ожидаютсяToolStripMenuItem.Text = "Ожидаются";
            this.ожидаютсяToolStripMenuItem.Click += new System.EventHandler(this.ожидаютсяToolStripMenuItem_Click);
            // 
            // записиНаПриёмToolStripMenuItem1
            // 
            this.записиНаПриёмToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зToolStripMenuItem,
            this.отменённыеToolStripMenuItem,
            this.ожидаютсяToolStripMenuItem1});
            this.записиНаПриёмToolStripMenuItem1.Name = "записиНаПриёмToolStripMenuItem1";
            this.записиНаПриёмToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.записиНаПриёмToolStripMenuItem1.Text = "Записи на приём";
            // 
            // зToolStripMenuItem
            // 
            this.зToolStripMenuItem.Name = "зToolStripMenuItem";
            this.зToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.зToolStripMenuItem.Text = "Завершённые";
            this.зToolStripMenuItem.Click += new System.EventHandler(this.зToolStripMenuItem_Click);
            // 
            // отменённыеToolStripMenuItem
            // 
            this.отменённыеToolStripMenuItem.Name = "отменённыеToolStripMenuItem";
            this.отменённыеToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.отменённыеToolStripMenuItem.Text = "Отменённые";
            this.отменённыеToolStripMenuItem.Click += new System.EventHandler(this.отменённыеToolStripMenuItem_Click);
            // 
            // ожидаютсяToolStripMenuItem1
            // 
            this.ожидаютсяToolStripMenuItem1.Name = "ожидаютсяToolStripMenuItem1";
            this.ожидаютсяToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.ожидаютсяToolStripMenuItem1.Text = "Запланированные";
            this.ожидаютсяToolStripMenuItem1.Click += new System.EventHandler(this.ожидаютсяToolStripMenuItem1_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // buttonEndEdit
            // 
            this.buttonEndEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEndEdit.Location = new System.Drawing.Point(643, 3);
            this.buttonEndEdit.Name = "buttonEndEdit";
            this.buttonEndEdit.Size = new System.Drawing.Size(157, 24);
            this.buttonEndEdit.TabIndex = 2;
            this.buttonEndEdit.Text = "Завершить изменения";
            this.buttonEndEdit.UseVisualStyleBackColor = true;
            this.buttonEndEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelEdit.Location = new System.Drawing.Point(806, 3);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(164, 24);
            this.buttonCancelEdit.TabIndex = 3;
            this.buttonCancelEdit.Text = "Отменить изменения";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Click += new System.EventHandler(this.button2_Click);
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
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(997, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Поликлиника";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискВрачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пациентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записиВМедкартеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оказанныеУслугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записиНаПриёмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоФИОToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem приёмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оказанныеУслугиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem неоплаченныеПлатежиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оплаченныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неоплаченныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ожидаютсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записиНаПриёмToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменённыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ожидаютсяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem полToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мужчиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem женщиныToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonEndEdit;
        private System.Windows.Forms.Button buttonCancelEdit;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

