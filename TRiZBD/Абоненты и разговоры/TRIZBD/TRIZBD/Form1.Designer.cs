namespace TRIZBD
{
    partial class Form1
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
            System.Windows.Forms.Label номерТелефонаLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label колВремениLabel;
            System.Windows.Forms.Label названиеГородаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataGridAbAndSp = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bindingNavigatorAbAndSp = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AdSpFIO = new System.Windows.Forms.TextBox();
            this.названиеГородаComboBox = new System.Windows.Forms.ComboBox();
            this.тарифBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonentsAndSpeaksDataSet = new TRIZBD.AbonentsAndSpeaksDataSet();
            this.bindingNavigatorAddSpeak = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.номерТелефонаComboBox = new System.Windows.Forms.ComboBox();
            this.разговорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.колВремениTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.разговорTableAdapter = new TRIZBD.AbonentsAndSpeaksDataSetTableAdapters.РазговорTableAdapter();
            this.tableAdapterManager = new TRIZBD.AbonentsAndSpeaksDataSetTableAdapters.TableAdapterManager();
            this.abonentTableAdapter = new TRIZBD.AbonentsAndSpeaksDataSetTableAdapters.AbonentTableAdapter();
            this.тарифTableAdapter = new TRIZBD.AbonentsAndSpeaksDataSetTableAdapters.ТарифTableAdapter();
            this.abonentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            номерТелефонаLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            колВремениLabel = new System.Windows.Forms.Label();
            названиеГородаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAbAndSp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAbAndSp)).BeginInit();
            this.bindingNavigatorAbAndSp.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsAndSpeaksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAddSpeak)).BeginInit();
            this.bindingNavigatorAddSpeak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.разговорBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номерТелефонаLabel
            // 
            номерТелефонаLabel.AutoSize = true;
            номерТелефонаLabel.Location = new System.Drawing.Point(320, 160);
            номерТелефонаLabel.Name = "номерТелефонаLabel";
            номерТелефонаLabel.Size = new System.Drawing.Size(127, 17);
            номерТелефонаLabel.TabIndex = 2;
            номерТелефонаLabel.Text = "Номер Телефона:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(400, 232);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(46, 17);
            датаLabel.TabIndex = 4;
            датаLabel.Text = "Дата:";
            // 
            // колВремениLabel
            // 
            колВремениLabel.AutoSize = true;
            колВремениLabel.Location = new System.Drawing.Point(344, 296);
            колВремениLabel.Name = "колВремениLabel";
            колВремениLabel.Size = new System.Drawing.Size(99, 17);
            колВремениLabel.TabIndex = 8;
            колВремениLabel.Text = "Кол Времени:";
            // 
            // названиеГородаLabel
            // 
            названиеГородаLabel.AutoSize = true;
            названиеГородаLabel.Location = new System.Drawing.Point(320, 264);
            названиеГородаLabel.Name = "названиеГородаLabel";
            названиеГородаLabel.Size = new System.Drawing.Size(128, 17);
            названиеГородаLabel.TabIndex = 10;
            названиеГородаLabel.Text = "Название Города:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(400, 200);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(46, 17);
            фИОLabel.TabIndex = 11;
            фИОLabel.Text = "ФИО:";
            // 
            // DataGridAbAndSp
            // 
            this.DataGridAbAndSp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridAbAndSp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridAbAndSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAbAndSp.Location = new System.Drawing.Point(3, 40);
            this.DataGridAbAndSp.Name = "DataGridAbAndSp";
            this.DataGridAbAndSp.ReadOnly = true;
            this.DataGridAbAndSp.RowTemplate.Height = 24;
            this.DataGridAbAndSp.Size = new System.Drawing.Size(1218, 560);
            this.DataGridAbAndSp.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 632);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bindingNavigatorAbAndSp);
            this.tabPage1.Controls.Add(this.DataGridAbAndSp);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1224, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Абоненты и их разговоры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorAbAndSp
            // 
            this.bindingNavigatorAbAndSp.AddNewItem = null;
            this.bindingNavigatorAbAndSp.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorAbAndSp.DeleteItem = null;
            this.bindingNavigatorAbAndSp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorAbAndSp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorAbAndSp.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorAbAndSp.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorAbAndSp.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorAbAndSp.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorAbAndSp.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorAbAndSp.Name = "bindingNavigatorAbAndSp";
            this.bindingNavigatorAbAndSp.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorAbAndSp.Size = new System.Drawing.Size(1218, 27);
            this.bindingNavigatorAbAndSp.TabIndex = 1;
            this.bindingNavigatorAbAndSp.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AdSpFIO);
            this.tabPage2.Controls.Add(фИОLabel);
            this.tabPage2.Controls.Add(названиеГородаLabel);
            this.tabPage2.Controls.Add(this.названиеГородаComboBox);
            this.tabPage2.Controls.Add(this.bindingNavigatorAddSpeak);
            this.tabPage2.Controls.Add(номерТелефонаLabel);
            this.tabPage2.Controls.Add(this.номерТелефонаComboBox);
            this.tabPage2.Controls.Add(датаLabel);
            this.tabPage2.Controls.Add(this.датаDateTimePicker);
            this.tabPage2.Controls.Add(колВремениLabel);
            this.tabPage2.Controls.Add(this.колВремениTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1224, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить разговор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AdSpFIO
            // 
            this.AdSpFIO.Location = new System.Drawing.Point(456, 192);
            this.AdSpFIO.Name = "AdSpFIO";
            this.AdSpFIO.ReadOnly = true;
            this.AdSpFIO.Size = new System.Drawing.Size(200, 22);
            this.AdSpFIO.TabIndex = 12;
            // 
            // названиеГородаComboBox
            // 
            this.названиеГородаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тарифBindingSource, "НазваниеГорода", true));
            this.названиеГородаComboBox.DataSource = this.тарифBindingSource;
            this.названиеГородаComboBox.DisplayMember = "НазваниеГорода";
            this.названиеГородаComboBox.FormattingEnabled = true;
            this.названиеГородаComboBox.Location = new System.Drawing.Point(456, 256);
            this.названиеГородаComboBox.Name = "названиеГородаComboBox";
            this.названиеГородаComboBox.Size = new System.Drawing.Size(200, 24);
            this.названиеГородаComboBox.TabIndex = 11;
            // 
            // тарифBindingSource
            // 
            this.тарифBindingSource.DataMember = "Тариф";
            this.тарифBindingSource.DataSource = this.abonentsAndSpeaksDataSet;
            // 
            // abonentsAndSpeaksDataSet
            // 
            this.abonentsAndSpeaksDataSet.DataSetName = "AbonentsAndSpeaksDataSet";
            this.abonentsAndSpeaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorAddSpeak
            // 
            this.bindingNavigatorAddSpeak.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorAddSpeak.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorAddSpeak.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorAddSpeak.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorAddSpeak.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.сохранитьToolStripButton});
            this.bindingNavigatorAddSpeak.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorAddSpeak.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorAddSpeak.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorAddSpeak.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorAddSpeak.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorAddSpeak.Name = "bindingNavigatorAddSpeak";
            this.bindingNavigatorAddSpeak.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorAddSpeak.Size = new System.Drawing.Size(1218, 27);
            this.bindingNavigatorAddSpeak.TabIndex = 10;
            this.bindingNavigatorAddSpeak.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            // 
            // номерТелефонаComboBox
            // 
            this.номерТелефонаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.разговорBindingSource, "НомерТелефона", true));
            this.номерТелефонаComboBox.DataSource = this.разговорBindingSource;
            this.номерТелефонаComboBox.DisplayMember = "НомерТелефона";
            this.номерТелефонаComboBox.FormattingEnabled = true;
            this.номерТелефонаComboBox.Location = new System.Drawing.Point(456, 157);
            this.номерТелефонаComboBox.Name = "номерТелефонаComboBox";
            this.номерТелефонаComboBox.Size = new System.Drawing.Size(200, 24);
            this.номерТелефонаComboBox.TabIndex = 3;
            this.номерТелефонаComboBox.SelectionChangeCommitted += new System.EventHandler(this.номерТелефонаComboBox_SelectionChangeCommitted);
            // 
            // разговорBindingSource
            // 
            this.разговорBindingSource.DataMember = "Разговор";
            this.разговорBindingSource.DataSource = this.abonentsAndSpeaksDataSet;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.разговорBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(456, 224);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаDateTimePicker.TabIndex = 5;
            // 
            // колВремениTextBox
            // 
            this.колВремениTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.разговорBindingSource, "КолВремени", true));
            this.колВремениTextBox.Location = new System.Drawing.Point(456, 293);
            this.колВремениTextBox.Name = "колВремениTextBox";
            this.колВремениTextBox.Size = new System.Drawing.Size(200, 22);
            this.колВремениTextBox.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1224, 603);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Города и тарифы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1224, 603);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Платеж по датам";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // разговорTableAdapter
            // 
            this.разговорTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonentTableAdapter = this.abonentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = TRIZBD.AbonentsAndSpeaksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.РазговорTableAdapter = this.разговорTableAdapter;
            this.tableAdapterManager.ТарифTableAdapter = this.тарифTableAdapter;
            // 
            // abonentTableAdapter
            // 
            this.abonentTableAdapter.ClearBeforeFill = true;
            // 
            // тарифTableAdapter
            // 
            this.тарифTableAdapter.ClearBeforeFill = true;
            // 
            // abonentBindingSource
            // 
            this.abonentBindingSource.DataMember = "Abonent";
            this.abonentBindingSource.DataSource = this.abonentsAndSpeaksDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 649);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAbAndSp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAbAndSp)).EndInit();
            this.bindingNavigatorAbAndSp.ResumeLayout(false);
            this.bindingNavigatorAbAndSp.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsAndSpeaksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAddSpeak)).EndInit();
            this.bindingNavigatorAddSpeak.ResumeLayout(false);
            this.bindingNavigatorAddSpeak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.разговорBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridAbAndSp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAbAndSp;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private AbonentsAndSpeaksDataSet abonentsAndSpeaksDataSet;
        private System.Windows.Forms.BindingSource разговорBindingSource;
        private AbonentsAndSpeaksDataSetTableAdapters.РазговорTableAdapter разговорTableAdapter;
        private AbonentsAndSpeaksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAddSpeak;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.ComboBox номерТелефонаComboBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox колВремениTextBox;
        private AbonentsAndSpeaksDataSetTableAdapters.ТарифTableAdapter тарифTableAdapter;
        private System.Windows.Forms.BindingSource тарифBindingSource;
        private System.Windows.Forms.ComboBox названиеГородаComboBox;
        private AbonentsAndSpeaksDataSetTableAdapters.AbonentTableAdapter abonentTableAdapter;
        private System.Windows.Forms.BindingSource abonentBindingSource;
        private System.Windows.Forms.TextBox AdSpFIO;
    }
}

