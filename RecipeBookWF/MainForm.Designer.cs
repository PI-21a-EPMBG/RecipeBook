namespace RecipeBookWF
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cookingTimeTextBox = new System.Windows.Forms.RichTextBox();
            this.editRecipeButton = new System.Windows.Forms.Button();
            this.AddToFavoritesButton = new System.Windows.Forms.Button();
            this.recipeIngridientsTextBox = new System.Windows.Forms.RichTextBox();
            this.recipeDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.recipeName = new System.Windows.Forms.TextBox();
            this.recipePictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.CreateRecipeCatalogueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.editRecipeButton_favourites = new System.Windows.Forms.Button();
            this.AddToFavoritesButton_favourites = new System.Windows.Forms.Button();
            this.recipeIngridientsTextBox_favourites = new System.Windows.Forms.RichTextBox();
            this.recipeDescriptionTextBox_favourites = new System.Windows.Forms.RichTextBox();
            this.recipeName_favourites = new System.Windows.Forms.TextBox();
            this.recipePictureBox_favourites = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listBox_favourites = new System.Windows.Forms.ListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipePictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipePictureBox_favourites)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadMenuButton,
            this.SaveMenuButton,
            this.CloseMenuButton});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // LoadMenuButton
            // 
            this.LoadMenuButton.Name = "LoadMenuButton";
            this.LoadMenuButton.Size = new System.Drawing.Size(133, 22);
            this.LoadMenuButton.Text = "Загрузить";
            this.LoadMenuButton.Click += new System.EventHandler(this.LoadMenuButton_Click);
            // 
            // SaveMenuButton
            // 
            this.SaveMenuButton.Name = "SaveMenuButton";
            this.SaveMenuButton.Size = new System.Drawing.Size(133, 22);
            this.SaveMenuButton.Text = "Сохранить";
            this.SaveMenuButton.Click += new System.EventHandler(this.SaveMenuButton_Click);
            // 
            // CloseMenuButton
            // 
            this.CloseMenuButton.Name = "CloseMenuButton";
            this.CloseMenuButton.Size = new System.Drawing.Size(133, 22);
            this.CloseMenuButton.Text = "Выход";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 704);
            this.panel1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1101, 704);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 678);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Каталог";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 672);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(215, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 648);
            this.panel3.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.57798F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.11927F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.4633F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.72477F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cookingTimeTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.editRecipeButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddToFavoritesButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.recipeIngridientsTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.recipeDescriptionTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.recipeName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.recipePictureBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.59259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.024692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.90124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.32716F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 648);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ингридиенты:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(165, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Рецепт";
            // 
            // cookingTimeTextBox
            // 
            this.cookingTimeTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cookingTimeTextBox.Location = new System.Drawing.Point(702, 138);
            this.cookingTimeTextBox.Name = "cookingTimeTextBox";
            this.cookingTimeTextBox.ReadOnly = true;
            this.cookingTimeTextBox.Size = new System.Drawing.Size(167, 25);
            this.cookingTimeTextBox.TabIndex = 4;
            this.cookingTimeTextBox.Text = "";
            // 
            // editRecipeButton
            // 
            this.editRecipeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editRecipeButton.Location = new System.Drawing.Point(730, 619);
            this.editRecipeButton.Name = "editRecipeButton";
            this.editRecipeButton.Size = new System.Drawing.Size(139, 26);
            this.editRecipeButton.TabIndex = 7;
            this.editRecipeButton.Text = "Редактировать";
            this.editRecipeButton.UseVisualStyleBackColor = true;
            this.editRecipeButton.Click += new System.EventHandler(this.editRecipeButton_Click);
            // 
            // AddToFavoritesButton
            // 
            this.AddToFavoritesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddToFavoritesButton.Location = new System.Drawing.Point(541, 619);
            this.AddToFavoritesButton.Name = "AddToFavoritesButton";
            this.AddToFavoritesButton.Size = new System.Drawing.Size(155, 26);
            this.AddToFavoritesButton.TabIndex = 8;
            this.AddToFavoritesButton.Text = "Добавить в избранное";
            this.AddToFavoritesButton.UseVisualStyleBackColor = true;
            this.AddToFavoritesButton.Click += new System.EventHandler(this.AddToFavoritesButton_Click);
            // 
            // recipeIngridientsTextBox
            // 
            this.recipeIngridientsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeIngridientsTextBox.Location = new System.Drawing.Point(3, 169);
            this.recipeIngridientsTextBox.Name = "recipeIngridientsTextBox";
            this.recipeIngridientsTextBox.ReadOnly = true;
            this.recipeIngridientsTextBox.Size = new System.Drawing.Size(156, 434);
            this.recipeIngridientsTextBox.TabIndex = 9;
            this.recipeIngridientsTextBox.Text = "";
            // 
            // recipeDescriptionTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.recipeDescriptionTextBox, 3);
            this.recipeDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recipeDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeDescriptionTextBox.Location = new System.Drawing.Point(165, 169);
            this.recipeDescriptionTextBox.Name = "recipeDescriptionTextBox";
            this.recipeDescriptionTextBox.ReadOnly = true;
            this.recipeDescriptionTextBox.Size = new System.Drawing.Size(704, 434);
            this.recipeDescriptionTextBox.TabIndex = 10;
            this.recipeDescriptionTextBox.Text = "";
            // 
            // recipeName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.recipeName, 3);
            this.recipeName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recipeName.Location = new System.Drawing.Point(165, 63);
            this.recipeName.Multiline = true;
            this.recipeName.Name = "recipeName";
            this.recipeName.ReadOnly = true;
            this.recipeName.Size = new System.Drawing.Size(704, 48);
            this.recipeName.TabIndex = 11;
            // 
            // recipePictureBox
            // 
            this.recipePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipePictureBox.Location = new System.Drawing.Point(3, 3);
            this.recipePictureBox.Name = "recipePictureBox";
            this.recipePictureBox.Size = new System.Drawing.Size(156, 108);
            this.recipePictureBox.TabIndex = 12;
            this.recipePictureBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBox);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 648);
            this.panel4.TabIndex = 8;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 32);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(215, 616);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(215, 32);
            this.panel9.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рецепты";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateRecipeCatalogueButton,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // CreateRecipeCatalogueButton
            // 
            this.CreateRecipeCatalogueButton.Name = "CreateRecipeCatalogueButton";
            this.CreateRecipeCatalogueButton.Size = new System.Drawing.Size(71, 20);
            this.CreateRecipeCatalogueButton.Text = "Добавить";
            this.CreateRecipeCatalogueButton.Click += new System.EventHandler(this.CreateRecipeCatalogueButton_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(99, 20);
            this.toolStripMenuItem5.Text = "Редактировать";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem6.Text = "Удалить";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 678);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Избранное";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.menuStrip3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1087, 672);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(215, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(872, 648);
            this.panel6.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.57798F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.11927F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.4633F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.72477F));
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.richTextBox1, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.editRecipeButton_favourites, 3, 3);
            this.tableLayoutPanel6.Controls.Add(this.AddToFavoritesButton_favourites, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.recipeIngridientsTextBox_favourites, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.recipeDescriptionTextBox_favourites, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.recipeName_favourites, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.recipePictureBox_favourites, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.59259F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.024692F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.90124F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.32716F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(872, 648);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ингридиенты:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(165, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Рецепт";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(702, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(167, 25);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // editRecipeButton_favourites
            // 
            this.editRecipeButton_favourites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editRecipeButton_favourites.Location = new System.Drawing.Point(730, 619);
            this.editRecipeButton_favourites.Name = "editRecipeButton_favourites";
            this.editRecipeButton_favourites.Size = new System.Drawing.Size(139, 26);
            this.editRecipeButton_favourites.TabIndex = 7;
            this.editRecipeButton_favourites.Text = "Редактировать";
            this.editRecipeButton_favourites.UseVisualStyleBackColor = true;
            // 
            // AddToFavoritesButton_favourites
            // 
            this.AddToFavoritesButton_favourites.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddToFavoritesButton_favourites.Location = new System.Drawing.Point(541, 619);
            this.AddToFavoritesButton_favourites.Name = "AddToFavoritesButton_favourites";
            this.AddToFavoritesButton_favourites.Size = new System.Drawing.Size(155, 26);
            this.AddToFavoritesButton_favourites.TabIndex = 8;
            this.AddToFavoritesButton_favourites.Text = "Добавить в избранное";
            this.AddToFavoritesButton_favourites.UseVisualStyleBackColor = true;
            // 
            // recipeIngridientsTextBox_favourites
            // 
            this.recipeIngridientsTextBox_favourites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeIngridientsTextBox_favourites.Location = new System.Drawing.Point(3, 169);
            this.recipeIngridientsTextBox_favourites.Name = "recipeIngridientsTextBox_favourites";
            this.recipeIngridientsTextBox_favourites.ReadOnly = true;
            this.recipeIngridientsTextBox_favourites.Size = new System.Drawing.Size(156, 434);
            this.recipeIngridientsTextBox_favourites.TabIndex = 9;
            this.recipeIngridientsTextBox_favourites.Text = "";
            // 
            // recipeDescriptionTextBox_favourites
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.recipeDescriptionTextBox_favourites, 3);
            this.recipeDescriptionTextBox_favourites.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recipeDescriptionTextBox_favourites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeDescriptionTextBox_favourites.Location = new System.Drawing.Point(165, 169);
            this.recipeDescriptionTextBox_favourites.Name = "recipeDescriptionTextBox_favourites";
            this.recipeDescriptionTextBox_favourites.ReadOnly = true;
            this.recipeDescriptionTextBox_favourites.Size = new System.Drawing.Size(704, 434);
            this.recipeDescriptionTextBox_favourites.TabIndex = 10;
            this.recipeDescriptionTextBox_favourites.Text = "";
            // 
            // recipeName_favourites
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.recipeName_favourites, 3);
            this.recipeName_favourites.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recipeName_favourites.Location = new System.Drawing.Point(165, 63);
            this.recipeName_favourites.Multiline = true;
            this.recipeName_favourites.Name = "recipeName_favourites";
            this.recipeName_favourites.ReadOnly = true;
            this.recipeName_favourites.Size = new System.Drawing.Size(704, 48);
            this.recipeName_favourites.TabIndex = 11;
            // 
            // recipePictureBox_favourites
            // 
            this.recipePictureBox_favourites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipePictureBox_favourites.Location = new System.Drawing.Point(3, 3);
            this.recipePictureBox_favourites.Name = "recipePictureBox_favourites";
            this.recipePictureBox_favourites.Size = new System.Drawing.Size(156, 108);
            this.recipePictureBox_favourites.TabIndex = 12;
            this.recipePictureBox_favourites.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.listBox_favourites);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 24);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 648);
            this.panel7.TabIndex = 8;
            // 
            // listBox_favourites
            // 
            this.listBox_favourites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_favourites.FormattingEnabled = true;
            this.listBox_favourites.Location = new System.Drawing.Point(0, 32);
            this.listBox_favourites.Name = "listBox_favourites";
            this.listBox_favourites.Size = new System.Drawing.Size(215, 616);
            this.listBox_favourites.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(215, 32);
            this.panel8.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Избранные рецепты";
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.White;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip3.TabIndex = 7;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Добавить";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem3.Text = "Удалить";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Кулинарная книга";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipePictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipePictureBox_favourites)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuButton;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox listBox_favourites;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button editRecipeButton_favourites;
        private System.Windows.Forms.Button AddToFavoritesButton_favourites;
        private System.Windows.Forms.RichTextBox recipeIngridientsTextBox_favourites;
        private System.Windows.Forms.RichTextBox recipeDescriptionTextBox_favourites;
        private System.Windows.Forms.TextBox recipeName_favourites;
        private System.Windows.Forms.PictureBox recipePictureBox_favourites;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox cookingTimeTextBox;
        private System.Windows.Forms.Button editRecipeButton;
        private System.Windows.Forms.Button AddToFavoritesButton;
        private System.Windows.Forms.RichTextBox recipeIngridientsTextBox;
        private System.Windows.Forms.RichTextBox recipeDescriptionTextBox;
        private System.Windows.Forms.TextBox recipeName;
        private System.Windows.Forms.PictureBox recipePictureBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem CreateRecipeCatalogueButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}

