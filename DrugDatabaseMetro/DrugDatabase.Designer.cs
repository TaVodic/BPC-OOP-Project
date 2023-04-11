namespace DrugDatabaseMetro
{
    partial class DrugDatabase
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.Menu = new MetroSet_UI.Controls.MetroSetTabControl();
            this.TabSearch = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Label_DrgInStock = new MetroSet_UI.Controls.MetroSetLabel();
            this.DrgInStock = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.DrgPrice = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.DrgProducer = new MetroSet_UI.Controls.MetroSetLabel();
            this.DrgDescription = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.DrgName = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.DrgSearch = new MetroSet_UI.Controls.MetroSetTextBox();
            this.SearchBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.TabEdit = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.DrugList = new System.Windows.Forms.ListView();
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColProducer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Error = new MetroSet_UI.Controls.MetroSetLabel();
            this.BtnImport = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnExport = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton3 = new MetroSet_UI.Controls.MetroSetButton();
            this.ColID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroSetButton4 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.Menu.SuspendLayout();
            this.TabSearch.SuspendLayout();
            this.TabEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(792, 8);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // Menu
            // 
            this.Menu.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.Menu.AnimateTime = 200;
            this.Menu.BackgroundColor = System.Drawing.Color.White;
            this.Menu.Controls.Add(this.TabSearch);
            this.Menu.Controls.Add(this.TabEdit);
            this.Menu.Cursor = System.Windows.Forms.Cursors.Default;
            this.Menu.IsDerivedStyle = true;
            this.Menu.ItemSize = new System.Drawing.Size(100, 38);
            this.Menu.Location = new System.Drawing.Point(15, 93);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 1;
            this.Menu.SelectedTextColor = System.Drawing.Color.White;
            this.Menu.Size = new System.Drawing.Size(876, 431);
            this.Menu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Menu.Speed = 100;
            this.Menu.Style = MetroSet_UI.Enums.Style.Light;
            this.Menu.StyleManager = null;
            this.Menu.TabIndex = 1;
            this.Menu.ThemeAuthor = "Narwin";
            this.Menu.ThemeName = "MetroLite";
            this.Menu.UnselectedTextColor = System.Drawing.Color.Gray;
            this.Menu.UseAnimation = false;
            this.Menu.SelectedIndexChanged += new System.EventHandler(this.Menu_SelectedIndexChanged);
            // 
            // TabSearch
            // 
            this.TabSearch.BaseColor = System.Drawing.Color.White;
            this.TabSearch.Controls.Add(this.metroSetLabel7);
            this.TabSearch.Controls.Add(this.metroSetTextBox1);
            this.TabSearch.Controls.Add(this.metroSetButton4);
            this.TabSearch.Controls.Add(this.Label_DrgInStock);
            this.TabSearch.Controls.Add(this.DrgInStock);
            this.TabSearch.Controls.Add(this.metroSetLabel5);
            this.TabSearch.Controls.Add(this.DrgPrice);
            this.TabSearch.Controls.Add(this.metroSetLabel4);
            this.TabSearch.Controls.Add(this.DrgProducer);
            this.TabSearch.Controls.Add(this.DrgDescription);
            this.TabSearch.Controls.Add(this.metroSetLabel3);
            this.TabSearch.Controls.Add(this.DrgName);
            this.TabSearch.Controls.Add(this.metroSetLabel2);
            this.TabSearch.Controls.Add(this.metroSetLabel1);
            this.TabSearch.Controls.Add(this.DrgSearch);
            this.TabSearch.Controls.Add(this.SearchBtn);
            this.TabSearch.Controls.Add(this.metroSetLabel6);
            this.TabSearch.Controls.Add(this.metroSetPanel1);
            this.TabSearch.Font = null;
            this.TabSearch.ImageIndex = 0;
            this.TabSearch.ImageKey = null;
            this.TabSearch.IsDerivedStyle = true;
            this.TabSearch.Location = new System.Drawing.Point(4, 42);
            this.TabSearch.Name = "TabSearch";
            this.TabSearch.Size = new System.Drawing.Size(868, 385);
            this.TabSearch.Style = MetroSet_UI.Enums.Style.Light;
            this.TabSearch.StyleManager = null;
            this.TabSearch.TabIndex = 0;
            this.TabSearch.Text = "Search database";
            this.TabSearch.ThemeAuthor = "Narwin";
            this.TabSearch.ThemeName = "MetroLite";
            this.TabSearch.ToolTipText = null;
            // 
            // Label_DrgInStock
            // 
            this.Label_DrgInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_DrgInStock.IsDerivedStyle = true;
            this.Label_DrgInStock.Location = new System.Drawing.Point(29, 170);
            this.Label_DrgInStock.Name = "Label_DrgInStock";
            this.Label_DrgInStock.Size = new System.Drawing.Size(81, 23);
            this.Label_DrgInStock.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_DrgInStock.StyleManager = null;
            this.Label_DrgInStock.TabIndex = 12;
            this.Label_DrgInStock.Text = "In stock:";
            this.Label_DrgInStock.ThemeAuthor = "Narwin";
            this.Label_DrgInStock.ThemeName = "MetroLite";
            // 
            // DrgInStock
            // 
            this.DrgInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DrgInStock.IsDerivedStyle = true;
            this.DrgInStock.Location = new System.Drawing.Point(116, 170);
            this.DrgInStock.Name = "DrgInStock";
            this.DrgInStock.Size = new System.Drawing.Size(265, 23);
            this.DrgInStock.Style = MetroSet_UI.Enums.Style.Light;
            this.DrgInStock.StyleManager = null;
            this.DrgInStock.TabIndex = 11;
            this.DrgInStock.ThemeAuthor = "Narwin";
            this.DrgInStock.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(29, 147);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(81, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 10;
            this.metroSetLabel5.Text = "Price:";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // DrgPrice
            // 
            this.DrgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DrgPrice.IsDerivedStyle = true;
            this.DrgPrice.Location = new System.Drawing.Point(116, 147);
            this.DrgPrice.Name = "DrgPrice";
            this.DrgPrice.Size = new System.Drawing.Size(265, 23);
            this.DrgPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.DrgPrice.StyleManager = null;
            this.DrgPrice.TabIndex = 9;
            this.DrgPrice.ThemeAuthor = "Narwin";
            this.DrgPrice.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(29, 124);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(81, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 8;
            this.metroSetLabel4.Text = "Producer:";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // DrgProducer
            // 
            this.DrgProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DrgProducer.IsDerivedStyle = true;
            this.DrgProducer.Location = new System.Drawing.Point(116, 124);
            this.DrgProducer.Name = "DrgProducer";
            this.DrgProducer.Size = new System.Drawing.Size(265, 23);
            this.DrgProducer.Style = MetroSet_UI.Enums.Style.Light;
            this.DrgProducer.StyleManager = null;
            this.DrgProducer.TabIndex = 7;
            this.DrgProducer.ThemeAuthor = "Narwin";
            this.DrgProducer.ThemeName = "MetroLite";
            // 
            // DrgDescription
            // 
            this.DrgDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DrgDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DrgDescription.IsDerivedStyle = true;
            this.DrgDescription.Location = new System.Drawing.Point(116, 226);
            this.DrgDescription.Name = "DrgDescription";
            this.DrgDescription.Size = new System.Drawing.Size(496, 130);
            this.DrgDescription.Style = MetroSet_UI.Enums.Style.Light;
            this.DrgDescription.StyleManager = null;
            this.DrgDescription.TabIndex = 6;
            this.DrgDescription.ThemeAuthor = "Narwin";
            this.DrgDescription.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(29, 226);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(92, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 5;
            this.metroSetLabel3.Text = "Description:";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // DrgName
            // 
            this.DrgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DrgName.IsDerivedStyle = true;
            this.DrgName.Location = new System.Drawing.Point(116, 101);
            this.DrgName.Name = "DrgName";
            this.DrgName.Size = new System.Drawing.Size(265, 23);
            this.DrgName.Style = MetroSet_UI.Enums.Style.Light;
            this.DrgName.StyleManager = null;
            this.DrgName.TabIndex = 4;
            this.DrgName.ThemeAuthor = "Narwin";
            this.DrgName.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(29, 101);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(54, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 3;
            this.metroSetLabel2.Text = "Name:";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(29, 16);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 2;
            this.metroSetLabel1.Text = "Search";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // DrgSearch
            // 
            this.DrgSearch.AutoCompleteCustomSource = null;
            this.DrgSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DrgSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DrgSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.DrgSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DrgSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.DrgSearch.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.DrgSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DrgSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DrgSearch.Image = null;
            this.DrgSearch.IsDerivedStyle = true;
            this.DrgSearch.Lines = null;
            this.DrgSearch.Location = new System.Drawing.Point(29, 42);
            this.DrgSearch.MaxLength = 32767;
            this.DrgSearch.Multiline = false;
            this.DrgSearch.Name = "DrgSearch";
            this.DrgSearch.ReadOnly = false;
            this.DrgSearch.Size = new System.Drawing.Size(448, 25);
            this.DrgSearch.Style = MetroSet_UI.Enums.Style.Light;
            this.DrgSearch.StyleManager = null;
            this.DrgSearch.TabIndex = 1;
            this.DrgSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DrgSearch.ThemeAuthor = "Narwin";
            this.DrgSearch.ThemeName = "MetroLite";
            this.DrgSearch.UseSystemPasswordChar = false;
            this.DrgSearch.WatermarkText = "";
            // 
            // SearchBtn
            // 
            this.SearchBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SearchBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SearchBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.SearchBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.SearchBtn.HoverTextColor = System.Drawing.Color.White;
            this.SearchBtn.IsDerivedStyle = true;
            this.SearchBtn.Location = new System.Drawing.Point(499, 42);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SearchBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SearchBtn.NormalTextColor = System.Drawing.Color.White;
            this.SearchBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.SearchBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.SearchBtn.PressTextColor = System.Drawing.Color.White;
            this.SearchBtn.Size = new System.Drawing.Size(96, 25);
            this.SearchBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.SearchBtn.StyleManager = null;
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.ThemeAuthor = "Narwin";
            this.SearchBtn.ThemeName = "MetroLite";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // TabEdit
            // 
            this.TabEdit.BaseColor = System.Drawing.Color.White;
            this.TabEdit.Controls.Add(this.metroSetButton3);
            this.TabEdit.Controls.Add(this.metroSetButton2);
            this.TabEdit.Controls.Add(this.metroSetButton1);
            this.TabEdit.Controls.Add(this.BtnImport);
            this.TabEdit.Controls.Add(this.BtnExport);
            this.TabEdit.Controls.Add(this.DrugList);
            this.TabEdit.Font = null;
            this.TabEdit.ImageIndex = 0;
            this.TabEdit.ImageKey = null;
            this.TabEdit.IsDerivedStyle = true;
            this.TabEdit.Location = new System.Drawing.Point(4, 42);
            this.TabEdit.Name = "TabEdit";
            this.TabEdit.Size = new System.Drawing.Size(868, 385);
            this.TabEdit.Style = MetroSet_UI.Enums.Style.Light;
            this.TabEdit.StyleManager = null;
            this.TabEdit.TabIndex = 1;
            this.TabEdit.Text = "Edit database";
            this.TabEdit.ThemeAuthor = "Narwin";
            this.TabEdit.ThemeName = "MetroLite";
            this.TabEdit.ToolTipText = null;
            // 
            // DrugList
            // 
            this.DrugList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColID,
            this.ColName,
            this.ColProducer,
            this.ColStock,
            this.ColPrice,
            this.ColDesc});
            this.DrugList.GridLines = true;
            this.DrugList.HideSelection = false;
            this.DrugList.Location = new System.Drawing.Point(3, 12);
            this.DrugList.Name = "DrugList";
            this.DrugList.Size = new System.Drawing.Size(849, 324);
            this.DrugList.TabIndex = 3;
            this.DrugList.UseCompatibleStateImageBehavior = false;
            this.DrugList.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.Text = "Name";
            this.ColName.Width = 200;
            // 
            // ColProducer
            // 
            this.ColProducer.Text = "Producer";
            this.ColProducer.Width = 120;
            // 
            // Error
            // 
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Error.IsDerivedStyle = true;
            this.Error.Location = new System.Drawing.Point(279, 43);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(445, 35);
            this.Error.Style = MetroSet_UI.Enums.Style.Light;
            this.Error.StyleManager = null;
            this.Error.TabIndex = 2;
            this.Error.ThemeAuthor = "Narwin";
            this.Error.ThemeName = "MetroLite";
            // 
            // BtnImport
            // 
            this.BtnImport.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnImport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnImport.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnImport.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnImport.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnImport.HoverTextColor = System.Drawing.Color.White;
            this.BtnImport.IsDerivedStyle = true;
            this.BtnImport.Location = new System.Drawing.Point(605, 347);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnImport.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnImport.NormalTextColor = System.Drawing.Color.White;
            this.BtnImport.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnImport.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnImport.PressTextColor = System.Drawing.Color.White;
            this.BtnImport.Size = new System.Drawing.Size(113, 35);
            this.BtnImport.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnImport.StyleManager = null;
            this.BtnImport.TabIndex = 1;
            this.BtnImport.Text = "Import data";
            this.BtnImport.ThemeAuthor = "Narwin";
            this.BtnImport.ThemeName = "MetroLite";
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnExport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnExport.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnExport.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnExport.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnExport.HoverTextColor = System.Drawing.Color.White;
            this.BtnExport.IsDerivedStyle = true;
            this.BtnExport.Location = new System.Drawing.Point(739, 347);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnExport.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnExport.NormalTextColor = System.Drawing.Color.White;
            this.BtnExport.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnExport.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnExport.PressTextColor = System.Drawing.Color.White;
            this.BtnExport.Size = new System.Drawing.Size(113, 35);
            this.BtnExport.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnExport.StyleManager = null;
            this.BtnExport.TabIndex = 0;
            this.BtnExport.Text = "Export data";
            this.BtnExport.ThemeAuthor = "Narwin";
            this.BtnExport.ThemeName = "MetroLite";
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Enabled = false;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.IsDerivedStyle = true;
            this.metroSetButton1.Location = new System.Drawing.Point(3, 347);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(113, 35);
            this.metroSetButton1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 4;
            this.metroSetButton1.Text = "Add";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            // 
            // metroSetButton2
            // 
            this.metroSetButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton2.Enabled = false;
            this.metroSetButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton2.IsDerivedStyle = true;
            this.metroSetButton2.Location = new System.Drawing.Point(269, 347);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Size = new System.Drawing.Size(113, 35);
            this.metroSetButton2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton2.StyleManager = null;
            this.metroSetButton2.TabIndex = 5;
            this.metroSetButton2.Text = "Delete";
            this.metroSetButton2.ThemeAuthor = "Narwin";
            this.metroSetButton2.ThemeName = "MetroLite";
            // 
            // metroSetButton3
            // 
            this.metroSetButton3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton3.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton3.Enabled = false;
            this.metroSetButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton3.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton3.IsDerivedStyle = true;
            this.metroSetButton3.Location = new System.Drawing.Point(136, 347);
            this.metroSetButton3.Name = "metroSetButton3";
            this.metroSetButton3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton3.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton3.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton3.Size = new System.Drawing.Size(113, 35);
            this.metroSetButton3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton3.StyleManager = null;
            this.metroSetButton3.TabIndex = 6;
            this.metroSetButton3.Text = "Edit";
            this.metroSetButton3.ThemeAuthor = "Narwin";
            this.metroSetButton3.ThemeName = "MetroLite";
            // 
            // ColID
            // 
            this.ColID.Text = "ID";
            this.ColID.Width = 30;
            // 
            // ColStock
            // 
            this.ColStock.Text = "In stock";
            // 
            // ColPrice
            // 
            this.ColPrice.Text = "Price";
            // 
            // ColDesc
            // 
            this.ColDesc.Text = "Description";
            this.ColDesc.Width = 300;
            // 
            // metroSetButton4
            // 
            this.metroSetButton4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton4.Enabled = false;
            this.metroSetButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton4.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton4.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton4.IsDerivedStyle = true;
            this.metroSetButton4.Location = new System.Drawing.Point(742, 333);
            this.metroSetButton4.Name = "metroSetButton4";
            this.metroSetButton4.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton4.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton4.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton4.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton4.Size = new System.Drawing.Size(113, 35);
            this.metroSetButton4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton4.StyleManager = null;
            this.metroSetButton4.TabIndex = 16;
            this.metroSetButton4.Text = "Sell item";
            this.metroSetButton4.ThemeAuthor = "Narwin";
            this.metroSetButton4.ThemeName = "MetroLite";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(637, 192);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 17;
            this.metroSetLabel6.Text = "Amount";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // metroSetTextBox1
            // 
            this.metroSetTextBox1.AutoCompleteCustomSource = null;
            this.metroSetTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.metroSetTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.metroSetTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox1.Image = null;
            this.metroSetTextBox1.IsDerivedStyle = true;
            this.metroSetTextBox1.Lines = null;
            this.metroSetTextBox1.Location = new System.Drawing.Point(637, 218);
            this.metroSetTextBox1.MaxLength = 32767;
            this.metroSetTextBox1.Multiline = false;
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.ReadOnly = false;
            this.metroSetTextBox1.Size = new System.Drawing.Size(100, 31);
            this.metroSetTextBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox1.StyleManager = null;
            this.metroSetTextBox1.TabIndex = 18;
            this.metroSetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox1.ThemeAuthor = "Narwin";
            this.metroSetTextBox1.ThemeName = "MetroLite";
            this.metroSetTextBox1.UseSystemPasswordChar = false;
            this.metroSetTextBox1.WatermarkText = "";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(743, 226);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 19;
            this.metroSetLabel7.Text = "pcs";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(618, 170);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(254, 212);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 20;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            // 
            // DrugDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 532);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Error);
            this.Name = "DrugDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drug database";
            this.Load += new System.EventHandler(this.DrugDatabase_Load);
            this.Menu.ResumeLayout(false);
            this.TabSearch.ResumeLayout(false);
            this.TabEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl Menu;
        private MetroSet_UI.Child.MetroSetSetTabPage TabSearch;
        private MetroSet_UI.Controls.MetroSetTextBox DrgSearch;
        private MetroSet_UI.Controls.MetroSetButton SearchBtn;
        private MetroSet_UI.Child.MetroSetSetTabPage TabEdit;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel DrgName;
        private MetroSet_UI.Controls.MetroSetLabel DrgDescription;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel DrgProducer;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel DrgPrice;
        private MetroSet_UI.Controls.MetroSetLabel Label_DrgInStock;
        private MetroSet_UI.Controls.MetroSetLabel DrgInStock;
        private MetroSet_UI.Controls.MetroSetButton BtnImport;
        private MetroSet_UI.Controls.MetroSetButton BtnExport;
        private MetroSet_UI.Controls.MetroSetLabel Error;
        private System.Windows.Forms.ListView DrugList;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader ColProducer;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton2;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton3;
        private System.Windows.Forms.ColumnHeader ColID;
        private System.Windows.Forms.ColumnHeader ColStock;
        private System.Windows.Forms.ColumnHeader ColPrice;
        private System.Windows.Forms.ColumnHeader ColDesc;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
    }
}

