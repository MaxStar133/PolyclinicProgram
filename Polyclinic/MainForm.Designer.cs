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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Врачи");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Диагнозы");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Записи в медкарте");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Запись на приём");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Кабинеты");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Лекарства");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Медицинские услуги");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Медкарты");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Оказанные услуги");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Отделения");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Пациенты");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Платежи");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Приёмы врачей");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Рецепты");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Специальности");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Таблицы", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Record = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddition = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEndEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCancelEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиВМедкартеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиНаПриёмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оказанныеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискВрачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоФИОToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.приёмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оказанныеУслугиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.неоплаченныеПлатежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплаченныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неоплаченныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ожидаютсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кабинетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свободныеКабинетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоОтделениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиНаПриёмToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменённыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ожидаютсяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            treeNode17.Name = "Врачи";
            treeNode17.Text = "Врачи";
            treeNode18.Name = "Диагнозы";
            treeNode18.Text = "Диагнозы";
            treeNode19.Name = "Записи в медкарте";
            treeNode19.Text = "Записи в медкарте";
            treeNode20.Name = "Запись на приём";
            treeNode20.Text = "Запись на приём";
            treeNode21.Name = "Кабинеты";
            treeNode21.Text = "Кабинеты";
            treeNode22.Name = "Лекарства";
            treeNode22.Text = "Лекарства";
            treeNode23.Name = "Медицинские услуги";
            treeNode23.Text = "Медицинские услуги";
            treeNode24.Name = "Медкарты";
            treeNode24.Text = "Медкарты";
            treeNode25.Name = "Оказанные услуги";
            treeNode25.Text = "Оказанные услуги";
            treeNode26.Name = "Отделения";
            treeNode26.Text = "Отделения";
            treeNode27.Name = "Пациенты";
            treeNode27.Text = "Пациенты";
            treeNode28.Name = "Платежи";
            treeNode28.Text = "Платежи";
            treeNode29.Name = "Приёмы врачей";
            treeNode29.Text = "Приёмы врачей";
            treeNode30.Name = "Рецепты";
            treeNode30.Text = "Рецепты";
            treeNode31.Name = "Специальности";
            treeNode31.Text = "Специальности";
            treeNode32.Name = "Tables";
            treeNode32.Text = "Таблицы";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32});
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
            this.файлToolStripMenuItem,
            this.Record,
            this.запросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(303, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
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
            this.Record.Size = new System.Drawing.Size(59, 20);
            this.Record.Text = "Записи";
            // 
            // buttonAddition
            // 
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.buttonAddition.Size = new System.Drawing.Size(249, 22);
            this.buttonAddition.Text = "Добавить запись";
            this.buttonAddition.Click += new System.EventHandler(this.buttonAddition_Click_1);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.buttonEdit.Size = new System.Drawing.Size(249, 22);
            this.buttonEdit.Text = "Изменить запись";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.buttonDelete.Size = new System.Drawing.Size(249, 22);
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonEndEdit
            // 
            this.buttonEndEdit.Name = "buttonEndEdit";
            this.buttonEndEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.buttonEndEdit.Size = new System.Drawing.Size(249, 22);
            this.buttonEndEdit.Text = "Завершить изменения";
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.buttonCancelEdit.Size = new System.Drawing.Size(249, 22);
            this.buttonCancelEdit.Text = "Отменить завершения";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентToolStripMenuItem,
            this.поискВрачаToolStripMenuItem,
            this.неоплаченныеПлатежиToolStripMenuItem,
            this.кабинетыToolStripMenuItem,
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
            this.платежиToolStripMenuItem});
            this.пациентToolStripMenuItem.Name = "пациентToolStripMenuItem";
            this.пациентToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пациентToolStripMenuItem.Text = "Пациент";
            // 
            // поискПоФИОToolStripMenuItem
            // 
            this.поискПоФИОToolStripMenuItem.Name = "поискПоФИОToolStripMenuItem";
            this.поискПоФИОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискПоФИОToolStripMenuItem.Text = "Поиск по ФИО";
            // 
            // записиВМедкартеToolStripMenuItem
            // 
            this.записиВМедкартеToolStripMenuItem.Name = "записиВМедкартеToolStripMenuItem";
            this.записиВМедкартеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.записиВМедкартеToolStripMenuItem.Text = "Записи в медкарте";
            this.записиВМедкартеToolStripMenuItem.Click += new System.EventHandler(this.записиВМедкартеToolStripMenuItem_Click);
            // 
            // записиНаПриёмToolStripMenuItem
            // 
            this.записиНаПриёмToolStripMenuItem.Name = "записиНаПриёмToolStripMenuItem";
            this.записиНаПриёмToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.записиНаПриёмToolStripMenuItem.Text = "Записи на приём";
            // 
            // рецептыToolStripMenuItem
            // 
            this.рецептыToolStripMenuItem.Name = "рецептыToolStripMenuItem";
            this.рецептыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рецептыToolStripMenuItem.Text = "Рецепты";
            // 
            // оказанныеУслугиToolStripMenuItem
            // 
            this.оказанныеУслугиToolStripMenuItem.Name = "оказанныеУслугиToolStripMenuItem";
            this.оказанныеУслугиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оказанныеУслугиToolStripMenuItem.Text = "Оказанные услуги";
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.платежиToolStripMenuItem.Text = "Платежи";
            // 
            // поискВрачаToolStripMenuItem
            // 
            this.поискВрачаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоФИОToolStripMenuItem1,
            this.приёмыToolStripMenuItem,
            this.оказанныеУслугиToolStripMenuItem1});
            this.поискВрачаToolStripMenuItem.Name = "поискВрачаToolStripMenuItem";
            this.поискВрачаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискВрачаToolStripMenuItem.Text = "Врач";
            // 
            // поискПоФИОToolStripMenuItem1
            // 
            this.поискПоФИОToolStripMenuItem1.Name = "поискПоФИОToolStripMenuItem1";
            this.поискПоФИОToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.поискПоФИОToolStripMenuItem1.Text = "Поиск по ФИО";
            // 
            // приёмыToolStripMenuItem
            // 
            this.приёмыToolStripMenuItem.Name = "приёмыToolStripMenuItem";
            this.приёмыToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.приёмыToolStripMenuItem.Text = "Приёмы";
            // 
            // оказанныеУслугиToolStripMenuItem1
            // 
            this.оказанныеУслугиToolStripMenuItem1.Name = "оказанныеУслугиToolStripMenuItem1";
            this.оказанныеУслугиToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.оказанныеУслугиToolStripMenuItem1.Text = "Оказанные услуги";
            // 
            // неоплаченныеПлатежиToolStripMenuItem
            // 
            this.неоплаченныеПлатежиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оплаченныеToolStripMenuItem,
            this.неоплаченныеToolStripMenuItem,
            this.ожидаютсяToolStripMenuItem});
            this.неоплаченныеПлатежиToolStripMenuItem.Name = "неоплаченныеПлатежиToolStripMenuItem";
            this.неоплаченныеПлатежиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.неоплаченныеПлатежиToolStripMenuItem.Text = "Платежи";
            // 
            // оплаченныеToolStripMenuItem
            // 
            this.оплаченныеToolStripMenuItem.Name = "оплаченныеToolStripMenuItem";
            this.оплаченныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оплаченныеToolStripMenuItem.Text = "Оплаченные";
            this.оплаченныеToolStripMenuItem.Click += new System.EventHandler(this.оплаченныеToolStripMenuItem_Click);
            // 
            // неоплаченныеToolStripMenuItem
            // 
            this.неоплаченныеToolStripMenuItem.Name = "неоплаченныеToolStripMenuItem";
            this.неоплаченныеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.неоплаченныеToolStripMenuItem.Text = "Неоплаченные";
            // 
            // ожидаютсяToolStripMenuItem
            // 
            this.ожидаютсяToolStripMenuItem.Name = "ожидаютсяToolStripMenuItem";
            this.ожидаютсяToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ожидаютсяToolStripMenuItem.Text = "Ожидаются";
            // 
            // кабинетыToolStripMenuItem
            // 
            this.кабинетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свободныеКабинетыToolStripMenuItem,
            this.поискПоОтделениюToolStripMenuItem});
            this.кабинетыToolStripMenuItem.Name = "кабинетыToolStripMenuItem";
            this.кабинетыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кабинетыToolStripMenuItem.Text = "Кабинеты";
            // 
            // свободныеКабинетыToolStripMenuItem
            // 
            this.свободныеКабинетыToolStripMenuItem.Name = "свободныеКабинетыToolStripMenuItem";
            this.свободныеКабинетыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.свободныеКабинетыToolStripMenuItem.Text = "Свободные кабинеты";
            // 
            // поискПоОтделениюToolStripMenuItem
            // 
            this.поискПоОтделениюToolStripMenuItem.Name = "поискПоОтделениюToolStripMenuItem";
            this.поискПоОтделениюToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.поискПоОтделениюToolStripMenuItem.Text = "Поиск по отделению";
            // 
            // записиНаПриёмToolStripMenuItem1
            // 
            this.записиНаПриёмToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зToolStripMenuItem,
            this.отменённыеToolStripMenuItem,
            this.ожидаютсяToolStripMenuItem1});
            this.записиНаПриёмToolStripMenuItem1.Name = "записиНаПриёмToolStripMenuItem1";
            this.записиНаПриёмToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.записиНаПриёмToolStripMenuItem1.Text = "Записи на приём";
            // 
            // зToolStripMenuItem
            // 
            this.зToolStripMenuItem.Name = "зToolStripMenuItem";
            this.зToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.зToolStripMenuItem.Text = "Завершённые";
            // 
            // отменённыеToolStripMenuItem
            // 
            this.отменённыеToolStripMenuItem.Name = "отменённыеToolStripMenuItem";
            this.отменённыеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.отменённыеToolStripMenuItem.Text = "Отменённые";
            // 
            // ожидаютсяToolStripMenuItem1
            // 
            this.ожидаютсяToolStripMenuItem1.Name = "ожидаютсяToolStripMenuItem1";
            this.ожидаютсяToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ожидаютсяToolStripMenuItem1.Text = "Ожидаются";
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
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem кабинетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свободныеКабинетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записиНаПриёмToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоОтделениюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменённыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ожидаютсяToolStripMenuItem1;
    }
}

