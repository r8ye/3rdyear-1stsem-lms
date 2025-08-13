namespace lms_w_barcode
{
    partial class Form1
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
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.conBorrowers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBorrowerOrg = new FontAwesome.Sharp.IconButton();
            this.btnDepartment = new FontAwesome.Sharp.IconButton();
            this.btnGradeLevel = new FontAwesome.Sharp.IconButton();
            this.btnSection = new FontAwesome.Sharp.IconButton();
            this.conCatalogs = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCatalog = new FontAwesome.Sharp.IconButton();
            this.btnAuthor = new FontAwesome.Sharp.IconButton();
            this.btnGenre = new FontAwesome.Sharp.IconButton();
            this.btnPublisher = new FontAwesome.Sharp.IconButton();
            this.btnClassification = new FontAwesome.Sharp.IconButton();
            this.btnBook = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnOthers = new FontAwesome.Sharp.IconButton();
            this.btnRecord = new FontAwesome.Sharp.IconButton();
            this.btnProcurement = new FontAwesome.Sharp.IconButton();
            this.elipseDesktop = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerCatalogs = new System.Windows.Forms.Timer(this.components);
            this.timerBorrowers = new System.Windows.Forms.Timer(this.components);
            this.btnBorrowers = new FontAwesome.Sharp.IconButton();
            this.btnInventory = new FontAwesome.Sharp.IconButton();
            this.btnCirculation = new FontAwesome.Sharp.IconButton();
            this.conRecords = new System.Windows.Forms.FlowLayoutPanel();
            this.timerRecords = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.conBorrowers.SuspendLayout();
            this.conCatalogs.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.conRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.conRecords);
            this.panelMenu.Controls.Add(this.conBorrowers);
            this.panelMenu.Controls.Add(this.conCatalogs);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.ShadowDecoration.Parent = this.panelMenu;
            this.panelMenu.Size = new System.Drawing.Size(210, 620);
            this.panelMenu.TabIndex = 0;
            // 
            // conBorrowers
            // 
            this.conBorrowers.Controls.Add(this.btnBorrowerOrg);
            this.conBorrowers.Controls.Add(this.btnDepartment);
            this.conBorrowers.Controls.Add(this.btnGradeLevel);
            this.conBorrowers.Controls.Add(this.btnSection);
            this.conBorrowers.Dock = System.Windows.Forms.DockStyle.Top;
            this.conBorrowers.Location = new System.Drawing.Point(0, 154);
            this.conBorrowers.Name = "conBorrowers";
            this.conBorrowers.Size = new System.Drawing.Size(210, 49);
            this.conBorrowers.TabIndex = 10;
            // 
            // btnBorrowerOrg
            // 
            this.btnBorrowerOrg.BackColor = System.Drawing.Color.White;
            this.btnBorrowerOrg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowerOrg.FlatAppearance.BorderSize = 0;
            this.btnBorrowerOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowerOrg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowerOrg.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBorrowerOrg.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnBorrowerOrg.IconColor = System.Drawing.Color.DarkGray;
            this.btnBorrowerOrg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrowerOrg.IconSize = 40;
            this.btnBorrowerOrg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowerOrg.Location = new System.Drawing.Point(0, 0);
            this.btnBorrowerOrg.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrowerOrg.Name = "btnBorrowerOrg";
            this.btnBorrowerOrg.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnBorrowerOrg.Size = new System.Drawing.Size(210, 49);
            this.btnBorrowerOrg.TabIndex = 4;
            this.btnBorrowerOrg.Text = "Borrowers";
            this.btnBorrowerOrg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowerOrg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrowerOrg.UseVisualStyleBackColor = false;
            this.btnBorrowerOrg.Click += new System.EventHandler(this.btnBorrower_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.White;
            this.btnDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartment.FlatAppearance.BorderSize = 0;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDepartment.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnDepartment.IconColor = System.Drawing.Color.DarkGray;
            this.btnDepartment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDepartment.IconSize = 40;
            this.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.Location = new System.Drawing.Point(0, 49);
            this.btnDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnDepartment.Size = new System.Drawing.Size(210, 49);
            this.btnDepartment.TabIndex = 7;
            this.btnDepartment.Text = "Departments";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnGradeLevel
            // 
            this.btnGradeLevel.BackColor = System.Drawing.Color.White;
            this.btnGradeLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGradeLevel.FlatAppearance.BorderSize = 0;
            this.btnGradeLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradeLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeLevel.ForeColor = System.Drawing.Color.DarkGray;
            this.btnGradeLevel.IconChar = FontAwesome.Sharp.IconChar.Stairs;
            this.btnGradeLevel.IconColor = System.Drawing.Color.DarkGray;
            this.btnGradeLevel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGradeLevel.IconSize = 40;
            this.btnGradeLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGradeLevel.Location = new System.Drawing.Point(0, 98);
            this.btnGradeLevel.Margin = new System.Windows.Forms.Padding(0);
            this.btnGradeLevel.Name = "btnGradeLevel";
            this.btnGradeLevel.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnGradeLevel.Size = new System.Drawing.Size(210, 49);
            this.btnGradeLevel.TabIndex = 8;
            this.btnGradeLevel.Text = "Grade Levels";
            this.btnGradeLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGradeLevel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGradeLevel.UseVisualStyleBackColor = false;
            this.btnGradeLevel.Click += new System.EventHandler(this.btnGradeLevel_Click);
            // 
            // btnSection
            // 
            this.btnSection.BackColor = System.Drawing.Color.White;
            this.btnSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSection.FlatAppearance.BorderSize = 0;
            this.btnSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSection.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btnSection.IconColor = System.Drawing.Color.DarkGray;
            this.btnSection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSection.IconSize = 40;
            this.btnSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSection.Location = new System.Drawing.Point(0, 147);
            this.btnSection.Margin = new System.Windows.Forms.Padding(0);
            this.btnSection.Name = "btnSection";
            this.btnSection.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnSection.Size = new System.Drawing.Size(210, 49);
            this.btnSection.TabIndex = 9;
            this.btnSection.Text = "Sections";
            this.btnSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSection.UseVisualStyleBackColor = false;
            this.btnSection.Click += new System.EventHandler(this.btnSection_Click);
            // 
            // conCatalogs
            // 
            this.conCatalogs.BackColor = System.Drawing.Color.White;
            this.conCatalogs.Controls.Add(this.btnCatalog);
            this.conCatalogs.Controls.Add(this.btnAuthor);
            this.conCatalogs.Controls.Add(this.btnGenre);
            this.conCatalogs.Controls.Add(this.btnPublisher);
            this.conCatalogs.Controls.Add(this.btnClassification);
            this.conCatalogs.Controls.Add(this.btnBook);
            this.conCatalogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.conCatalogs.Location = new System.Drawing.Point(0, 105);
            this.conCatalogs.Name = "conCatalogs";
            this.conCatalogs.Size = new System.Drawing.Size(210, 49);
            this.conCatalogs.TabIndex = 9;
            // 
            // btnCatalog
            // 
            this.btnCatalog.BackColor = System.Drawing.Color.White;
            this.btnCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalog.FlatAppearance.BorderSize = 0;
            this.btnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalog.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCatalog.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnCatalog.IconColor = System.Drawing.Color.DarkGray;
            this.btnCatalog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCatalog.IconSize = 40;
            this.btnCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalog.Location = new System.Drawing.Point(0, 0);
            this.btnCatalog.Margin = new System.Windows.Forms.Padding(0);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnCatalog.Size = new System.Drawing.Size(210, 49);
            this.btnCatalog.TabIndex = 2;
            this.btnCatalog.Text = "Catalogs";
            this.btnCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCatalog.UseVisualStyleBackColor = false;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalogs_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.Color.White;
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAuthor.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnAuthor.IconColor = System.Drawing.Color.DarkGray;
            this.btnAuthor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAuthor.IconSize = 40;
            this.btnAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.Location = new System.Drawing.Point(0, 49);
            this.btnAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnAuthor.Size = new System.Drawing.Size(210, 49);
            this.btnAuthor.TabIndex = 4;
            this.btnAuthor.Text = "Authors";
            this.btnAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuthor.UseVisualStyleBackColor = false;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.BackColor = System.Drawing.Color.White;
            this.btnGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenre.FlatAppearance.BorderSize = 0;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenre.ForeColor = System.Drawing.Color.DarkGray;
            this.btnGenre.IconChar = FontAwesome.Sharp.IconChar.BookQuran;
            this.btnGenre.IconColor = System.Drawing.Color.DarkGray;
            this.btnGenre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenre.IconSize = 40;
            this.btnGenre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenre.Location = new System.Drawing.Point(0, 98);
            this.btnGenre.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnGenre.Size = new System.Drawing.Size(210, 49);
            this.btnGenre.TabIndex = 5;
            this.btnGenre.Text = "Genres";
            this.btnGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenre.UseVisualStyleBackColor = false;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnPublisher
            // 
            this.btnPublisher.BackColor = System.Drawing.Color.White;
            this.btnPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPublisher.FlatAppearance.BorderSize = 0;
            this.btnPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublisher.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublisher.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPublisher.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnPublisher.IconColor = System.Drawing.Color.DarkGray;
            this.btnPublisher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPublisher.IconSize = 40;
            this.btnPublisher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublisher.Location = new System.Drawing.Point(0, 147);
            this.btnPublisher.Margin = new System.Windows.Forms.Padding(0);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnPublisher.Size = new System.Drawing.Size(210, 49);
            this.btnPublisher.TabIndex = 6;
            this.btnPublisher.Text = "Publishers";
            this.btnPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublisher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPublisher.UseVisualStyleBackColor = false;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // btnClassification
            // 
            this.btnClassification.BackColor = System.Drawing.Color.White;
            this.btnClassification.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClassification.FlatAppearance.BorderSize = 0;
            this.btnClassification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassification.ForeColor = System.Drawing.Color.DarkGray;
            this.btnClassification.IconChar = FontAwesome.Sharp.IconChar.Swatchbook;
            this.btnClassification.IconColor = System.Drawing.Color.DarkGray;
            this.btnClassification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClassification.IconSize = 40;
            this.btnClassification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassification.Location = new System.Drawing.Point(0, 196);
            this.btnClassification.Margin = new System.Windows.Forms.Padding(0);
            this.btnClassification.Name = "btnClassification";
            this.btnClassification.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnClassification.Size = new System.Drawing.Size(210, 49);
            this.btnClassification.TabIndex = 7;
            this.btnClassification.Text = "Classifications";
            this.btnClassification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClassification.UseVisualStyleBackColor = false;
            this.btnClassification.Click += new System.EventHandler(this.btnClassification_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.White;
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBook.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnBook.IconColor = System.Drawing.Color.DarkGray;
            this.btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBook.IconSize = 40;
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 245);
            this.btnBook.Margin = new System.Windows.Forms.Padding(0);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnBook.Size = new System.Drawing.Size(210, 49);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "Books";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnDashboard.IconColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 40;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 56);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnDashboard.Size = new System.Drawing.Size(210, 49);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.guna2Separator1);
            this.panelLogo.Controls.Add(this.guna2HtmlLabel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.ShadowDecoration.Parent = this.panelLogo;
            this.panelLogo.Size = new System.Drawing.Size(210, 56);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lms_w_barcode.Properties.Resources.ubnhslogooo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 51);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(202, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(59, 17);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(132, 32);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "UBNHS-LMS";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(210, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(749, 56);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Black;
            this.lblTitleChildForm.Location = new System.Drawing.Point(9, 17);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(65, 32);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelDesktop.Controls.Add(this.btnOthers);
            this.panelDesktop.Controls.Add(this.btnProcurement);
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.Location = new System.Drawing.Point(219, 67);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(729, 542);
            this.panelDesktop.TabIndex = 2;
            // 
            // btnOthers
            // 
            this.btnOthers.BackColor = System.Drawing.Color.White;
            this.btnOthers.FlatAppearance.BorderSize = 0;
            this.btnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOthers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.ForeColor = System.Drawing.Color.DarkGray;
            this.btnOthers.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnOthers.IconColor = System.Drawing.Color.DarkGray;
            this.btnOthers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOthers.IconSize = 40;
            this.btnOthers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOthers.Location = new System.Drawing.Point(462, 87);
            this.btnOthers.Margin = new System.Windows.Forms.Padding(2);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnOthers.Size = new System.Drawing.Size(210, 49);
            this.btnOthers.TabIndex = 6;
            this.btnOthers.Text = "Others";
            this.btnOthers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOthers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOthers.UseVisualStyleBackColor = false;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.White;
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRecord.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnRecord.IconColor = System.Drawing.Color.DarkGray;
            this.btnRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecord.IconSize = 40;
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Location = new System.Drawing.Point(0, 0);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnRecord.Size = new System.Drawing.Size(210, 49);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.Text = "Records";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnProcurement
            // 
            this.btnProcurement.BackColor = System.Drawing.Color.White;
            this.btnProcurement.FlatAppearance.BorderSize = 0;
            this.btnProcurement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurement.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurement.ForeColor = System.Drawing.Color.DarkGray;
            this.btnProcurement.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnProcurement.IconColor = System.Drawing.Color.DarkGray;
            this.btnProcurement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProcurement.IconSize = 40;
            this.btnProcurement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurement.Location = new System.Drawing.Point(475, 258);
            this.btnProcurement.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcurement.Name = "btnProcurement";
            this.btnProcurement.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnProcurement.Size = new System.Drawing.Size(210, 49);
            this.btnProcurement.TabIndex = 3;
            this.btnProcurement.Text = "Procurements";
            this.btnProcurement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcurement.UseVisualStyleBackColor = false;
            this.btnProcurement.Click += new System.EventHandler(this.btnProcurements_Click);
            // 
            // elipseDesktop
            // 
            this.elipseDesktop.BorderRadius = 20;
            this.elipseDesktop.TargetControl = this.panelDesktop;
            // 
            // timerCatalogs
            // 
            this.timerCatalogs.Interval = 1;
            this.timerCatalogs.Tick += new System.EventHandler(this.timerCatalogs_Tick);
            // 
            // timerBorrowers
            // 
            this.timerBorrowers.Interval = 1;
            this.timerBorrowers.Tick += new System.EventHandler(this.timerBorrowers_Tick);
            // 
            // btnBorrowers
            // 
            this.btnBorrowers.BackColor = System.Drawing.Color.White;
            this.btnBorrowers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowers.FlatAppearance.BorderSize = 0;
            this.btnBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowers.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBorrowers.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            this.btnBorrowers.IconColor = System.Drawing.Color.DarkGray;
            this.btnBorrowers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrowers.IconSize = 40;
            this.btnBorrowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowers.Location = new System.Drawing.Point(0, 49);
            this.btnBorrowers.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrowers.Name = "btnBorrowers";
            this.btnBorrowers.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnBorrowers.Size = new System.Drawing.Size(210, 49);
            this.btnBorrowers.TabIndex = 7;
            this.btnBorrowers.Text = "Borrowers";
            this.btnBorrowers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrowers.UseVisualStyleBackColor = false;
            this.btnBorrowers.Click += new System.EventHandler(this.btnBorrowers_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.White;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.DarkGray;
            this.btnInventory.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnInventory.IconColor = System.Drawing.Color.DarkGray;
            this.btnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventory.IconSize = 40;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 98);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnInventory.Size = new System.Drawing.Size(210, 49);
            this.btnInventory.TabIndex = 8;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnCirculation
            // 
            this.btnCirculation.BackColor = System.Drawing.Color.White;
            this.btnCirculation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCirculation.FlatAppearance.BorderSize = 0;
            this.btnCirculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCirculation.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCirculation.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
            this.btnCirculation.IconColor = System.Drawing.Color.DarkGray;
            this.btnCirculation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCirculation.IconSize = 40;
            this.btnCirculation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCirculation.Location = new System.Drawing.Point(0, 147);
            this.btnCirculation.Margin = new System.Windows.Forms.Padding(0);
            this.btnCirculation.Name = "btnCirculation";
            this.btnCirculation.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnCirculation.Size = new System.Drawing.Size(210, 49);
            this.btnCirculation.TabIndex = 9;
            this.btnCirculation.Text = "Circulations";
            this.btnCirculation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCirculation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCirculation.UseVisualStyleBackColor = false;
            this.btnCirculation.Click += new System.EventHandler(this.btnCirculation_Click);
            // 
            // conRecords
            // 
            this.conRecords.Controls.Add(this.btnRecord);
            this.conRecords.Controls.Add(this.btnBorrowers);
            this.conRecords.Controls.Add(this.btnInventory);
            this.conRecords.Controls.Add(this.btnCirculation);
            this.conRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.conRecords.Location = new System.Drawing.Point(0, 203);
            this.conRecords.Name = "conRecords";
            this.conRecords.Size = new System.Drawing.Size(210, 49);
            this.conRecords.TabIndex = 10;
            // 
            // timerRecords
            // 
            this.timerRecords.Interval = 1;
            this.timerRecords.Tick += new System.EventHandler(this.timerRecords_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(959, 620);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upper Bicutan National High School - Library Management System";
            this.panelMenu.ResumeLayout(false);
            this.conBorrowers.ResumeLayout(false);
            this.conCatalogs.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.conRecords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnProcurement;
        private FontAwesome.Sharp.IconButton btnCatalog;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel panelTitleBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private Guna.UI2.WinForms.Guna2Elipse elipseDesktop;
        private FontAwesome.Sharp.IconButton btnBook;
        private FontAwesome.Sharp.IconButton btnClassification;
        private FontAwesome.Sharp.IconButton btnPublisher;
        private FontAwesome.Sharp.IconButton btnGenre;
        private FontAwesome.Sharp.IconButton btnAuthor;
        private System.Windows.Forms.FlowLayoutPanel conCatalogs;
        private System.Windows.Forms.Timer timerCatalogs;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private FontAwesome.Sharp.IconButton btnGradeLevel;
        private FontAwesome.Sharp.IconButton btnDepartment;
        private FontAwesome.Sharp.IconButton btnOthers;
        private FontAwesome.Sharp.IconButton btnRecord;
        private FontAwesome.Sharp.IconButton btnBorrowerOrg;
        private FontAwesome.Sharp.IconButton btnSection;
        private System.Windows.Forms.FlowLayoutPanel conBorrowers;
        private System.Windows.Forms.Timer timerBorrowers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCirculation;
        private FontAwesome.Sharp.IconButton btnInventory;
        private FontAwesome.Sharp.IconButton btnBorrowers;
        private System.Windows.Forms.FlowLayoutPanel conRecords;
        private System.Windows.Forms.Timer timerRecords;
    }
}

