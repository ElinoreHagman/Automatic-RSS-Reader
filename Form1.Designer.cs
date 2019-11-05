namespace Project_RSS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCategory = new System.Windows.Forms.Label();
            this.LbInterval = new System.Windows.Forms.Label();
            this.LbUrl = new System.Windows.Forms.Label();
            this.LbCategories = new System.Windows.Forms.Label();
            this.LbEpisodes = new System.Windows.Forms.Label();
            this.LbPodcastInformation = new System.Windows.Forms.Label();
            this.TbUrl = new System.Windows.Forms.TextBox();
            this.ListCategories = new System.Windows.Forms.ListBox();
            this.TbInputCategory = new System.Windows.Forms.TextBox();
            this.LbDeletePodcast = new System.Windows.Forms.Button();
            this.LbSavePodcast = new System.Windows.Forms.Button();
            this.LbAddPodcast = new System.Windows.Forms.Button();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.BtnSaveCategory = new System.Windows.Forms.Button();
            this.BtnDeleteCategory = new System.Windows.Forms.Button();
            this.ListPodcastEpisodes = new System.Windows.Forms.ListBox();
            this.CboxInterval = new System.Windows.Forms.ComboBox();
            this.CboxCategory = new System.Windows.Forms.ComboBox();
            this.TxtPodcastDescription = new System.Windows.Forms.TextBox();
            this.TableFeed = new System.Windows.Forms.DataGridView();
            this.ColumnEpisode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListPodcastsFromCategory = new System.Windows.Forms.Button();
            this.BtnShowAll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbFeedOfPodcasts = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbWriteCategory = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LbProgramTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableFeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(403, 223);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(65, 13);
            this.lbCategory.TabIndex = 6;
            this.lbCategory.Text = "Category:";
            // 
            // LbInterval
            // 
            this.LbInterval.AutoSize = true;
            this.LbInterval.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInterval.Location = new System.Drawing.Point(264, 223);
            this.LbInterval.Name = "LbInterval";
            this.LbInterval.Size = new System.Drawing.Size(99, 13);
            this.LbInterval.TabIndex = 5;
            this.LbInterval.Text = "Update interval:";
            // 
            // LbUrl
            // 
            this.LbUrl.AutoSize = true;
            this.LbUrl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUrl.Location = new System.Drawing.Point(12, 223);
            this.LbUrl.Name = "LbUrl";
            this.LbUrl.Size = new System.Drawing.Size(82, 13);
            this.LbUrl.TabIndex = 4;
            this.LbUrl.Text = "Podcast URL:";
            // 
            // LbCategories
            // 
            this.LbCategories.AutoSize = true;
            this.LbCategories.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCategories.Location = new System.Drawing.Point(12, 11);
            this.LbCategories.Name = "LbCategories";
            this.LbCategories.Size = new System.Drawing.Size(117, 20);
            this.LbCategories.TabIndex = 7;
            this.LbCategories.Text = "Your categories";
            // 
            // LbEpisodes
            // 
            this.LbEpisodes.AutoSize = true;
            this.LbEpisodes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEpisodes.Location = new System.Drawing.Point(76, 9);
            this.LbEpisodes.Name = "LbEpisodes";
            this.LbEpisodes.Size = new System.Drawing.Size(129, 20);
            this.LbEpisodes.TabIndex = 8;
            this.LbEpisodes.Text = "Podcast episodes";
            // 
            // LbPodcastInformation
            // 
            this.LbPodcastInformation.AutoSize = true;
            this.LbPodcastInformation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPodcastInformation.Location = new System.Drawing.Point(11, 9);
            this.LbPodcastInformation.Name = "LbPodcastInformation";
            this.LbPodcastInformation.Size = new System.Drawing.Size(145, 20);
            this.LbPodcastInformation.TabIndex = 9;
            this.LbPodcastInformation.Text = "Episode description";
            // 
            // TbUrl
            // 
            this.TbUrl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUrl.Location = new System.Drawing.Point(14, 239);
            this.TbUrl.Name = "TbUrl";
            this.TbUrl.Size = new System.Drawing.Size(235, 21);
            this.TbUrl.TabIndex = 14;
            this.TbUrl.TextChanged += new System.EventHandler(this.TbUrl_TextChanged);
            // 
            // ListCategories
            // 
            this.ListCategories.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCategories.FormattingEnabled = true;
            this.ListCategories.ItemHeight = 15;
            this.ListCategories.Location = new System.Drawing.Point(15, 35);
            this.ListCategories.Name = "ListCategories";
            this.ListCategories.Size = new System.Drawing.Size(214, 139);
            this.ListCategories.TabIndex = 17;
            this.ListCategories.SelectedIndexChanged += new System.EventHandler(this.ListCategories_SelectedIndexChanged);
            // 
            // TbInputCategory
            // 
            this.TbInputCategory.Location = new System.Drawing.Point(15, 238);
            this.TbInputCategory.Name = "TbInputCategory";
            this.TbInputCategory.Size = new System.Drawing.Size(214, 20);
            this.TbInputCategory.TabIndex = 19;
            this.TbInputCategory.TextChanged += new System.EventHandler(this.TbInputCategory_TextChanged);
            // 
            // LbDeletePodcast
            // 
            this.LbDeletePodcast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDeletePodcast.Location = new System.Drawing.Point(452, 268);
            this.LbDeletePodcast.Name = "LbDeletePodcast";
            this.LbDeletePodcast.Size = new System.Drawing.Size(75, 27);
            this.LbDeletePodcast.TabIndex = 20;
            this.LbDeletePodcast.Text = "Delete";
            this.LbDeletePodcast.UseVisualStyleBackColor = true;
            this.LbDeletePodcast.Click += new System.EventHandler(this.LbDeletePodcast_Click);
            // 
            // LbSavePodcast
            // 
            this.LbSavePodcast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSavePodcast.Location = new System.Drawing.Point(345, 268);
            this.LbSavePodcast.Name = "LbSavePodcast";
            this.LbSavePodcast.Size = new System.Drawing.Size(101, 27);
            this.LbSavePodcast.TabIndex = 21;
            this.LbSavePodcast.Text = "Save/Change";
            this.LbSavePodcast.UseVisualStyleBackColor = true;
            this.LbSavePodcast.Click += new System.EventHandler(this.LbSavePodcast_Click);
            // 
            // LbAddPodcast
            // 
            this.LbAddPodcast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddPodcast.Location = new System.Drawing.Point(264, 268);
            this.LbAddPodcast.Name = "LbAddPodcast";
            this.LbAddPodcast.Size = new System.Drawing.Size(75, 27);
            this.LbAddPodcast.TabIndex = 22;
            this.LbAddPodcast.Text = "Add";
            this.LbAddPodcast.UseVisualStyleBackColor = true;
            this.LbAddPodcast.Click += new System.EventHandler(this.LbAddPodcast_Click);
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCategory.Location = new System.Drawing.Point(15, 268);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(46, 27);
            this.BtnAddCategory.TabIndex = 25;
            this.BtnAddCategory.Text = "Add";
            this.BtnAddCategory.UseVisualStyleBackColor = true;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // BtnSaveCategory
            // 
            this.BtnSaveCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCategory.Location = new System.Drawing.Point(67, 268);
            this.BtnSaveCategory.Name = "BtnSaveCategory";
            this.BtnSaveCategory.Size = new System.Drawing.Size(92, 27);
            this.BtnSaveCategory.TabIndex = 24;
            this.BtnSaveCategory.Text = "Save/Change";
            this.BtnSaveCategory.UseVisualStyleBackColor = true;
            this.BtnSaveCategory.Click += new System.EventHandler(this.BtnSaveCategory_Click);
            // 
            // BtnDeleteCategory
            // 
            this.BtnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCategory.Location = new System.Drawing.Point(165, 268);
            this.BtnDeleteCategory.Name = "BtnDeleteCategory";
            this.BtnDeleteCategory.Size = new System.Drawing.Size(64, 27);
            this.BtnDeleteCategory.TabIndex = 23;
            this.BtnDeleteCategory.Text = "Delete";
            this.BtnDeleteCategory.UseVisualStyleBackColor = true;
            this.BtnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategory_Click);
            // 
            // ListPodcastEpisodes
            // 
            this.ListPodcastEpisodes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListPodcastEpisodes.FormattingEnabled = true;
            this.ListPodcastEpisodes.ItemHeight = 15;
            this.ListPodcastEpisodes.Location = new System.Drawing.Point(14, 32);
            this.ListPodcastEpisodes.Name = "ListPodcastEpisodes";
            this.ListPodcastEpisodes.Size = new System.Drawing.Size(370, 184);
            this.ListPodcastEpisodes.TabIndex = 26;
            this.ListPodcastEpisodes.SelectedIndexChanged += new System.EventHandler(this.ListPodcastEpisodes_SelectedIndexChanged);
            // 
            // CboxInterval
            // 
            this.CboxInterval.BackColor = System.Drawing.SystemColors.Window;
            this.CboxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxInterval.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CboxInterval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxInterval.FormattingEnabled = true;
            this.CboxInterval.Location = new System.Drawing.Point(266, 238);
            this.CboxInterval.Name = "CboxInterval";
            this.CboxInterval.Size = new System.Drawing.Size(127, 23);
            this.CboxInterval.TabIndex = 36;
            this.CboxInterval.SelectedIndexChanged += new System.EventHandler(this.CboxInterval_SelectedIndexChanged);
            // 
            // CboxCategory
            // 
            this.CboxCategory.AccessibleName = "";
            this.CboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxCategory.FormattingEnabled = true;
            this.CboxCategory.Location = new System.Drawing.Point(405, 238);
            this.CboxCategory.Name = "CboxCategory";
            this.CboxCategory.Size = new System.Drawing.Size(122, 23);
            this.CboxCategory.TabIndex = 37;
            this.CboxCategory.SelectedIndexChanged += new System.EventHandler(this.CboxCategory_SelectedIndexChanged);
            // 
            // TxtPodcastDescription
            // 
            this.TxtPodcastDescription.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPodcastDescription.CausesValidation = false;
            this.TxtPodcastDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPodcastDescription.Location = new System.Drawing.Point(15, 32);
            this.TxtPodcastDescription.Multiline = true;
            this.TxtPodcastDescription.Name = "TxtPodcastDescription";
            this.TxtPodcastDescription.ReadOnly = true;
            this.TxtPodcastDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtPodcastDescription.Size = new System.Drawing.Size(354, 190);
            this.TxtPodcastDescription.TabIndex = 38;
            this.TxtPodcastDescription.TextChanged += new System.EventHandler(this.TxtPodcastDescription_TextChanged);
            // 
            // TableFeed
            // 
            this.TableFeed.AllowUserToAddRows = false;
            this.TableFeed.AllowUserToDeleteRows = false;
            this.TableFeed.AllowUserToResizeColumns = false;
            this.TableFeed.AllowUserToResizeRows = false;
            this.TableFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableFeed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableFeed.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TableFeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableFeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEpisode,
            this.ColumnName,
            this.ColumnInterval,
            this.ColumnCategory});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableFeed.DefaultCellStyle = dataGridViewCellStyle5;
            this.TableFeed.Location = new System.Drawing.Point(14, 35);
            this.TableFeed.MultiSelect = false;
            this.TableFeed.Name = "TableFeed";
            this.TableFeed.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableFeed.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TableFeed.RowHeadersVisible = false;
            this.TableFeed.RowHeadersWidth = 62;
            this.TableFeed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableFeed.Size = new System.Drawing.Size(513, 177);
            this.TableFeed.TabIndex = 39;
            this.TableFeed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnEpisode
            // 
            this.ColumnEpisode.HeaderText = "Episodes";
            this.ColumnEpisode.MinimumWidth = 8;
            this.ColumnEpisode.Name = "ColumnEpisode";
            this.ColumnEpisode.ReadOnly = true;
            this.ColumnEpisode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnInterval
            // 
            this.ColumnInterval.HeaderText = "Frequency";
            this.ColumnInterval.MinimumWidth = 8;
            this.ColumnInterval.Name = "ColumnInterval";
            this.ColumnInterval.ReadOnly = true;
            this.ColumnInterval.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.HeaderText = "Category";
            this.ColumnCategory.MinimumWidth = 8;
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            this.ColumnCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BtnListPodcastsFromCategory
            // 
            this.BtnListPodcastsFromCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListPodcastsFromCategory.Location = new System.Drawing.Point(15, 179);
            this.BtnListPodcastsFromCategory.Name = "BtnListPodcastsFromCategory";
            this.BtnListPodcastsFromCategory.Size = new System.Drawing.Size(214, 33);
            this.BtnListPodcastsFromCategory.TabIndex = 40;
            this.BtnListPodcastsFromCategory.Text = "List podcasts in selected category";
            this.BtnListPodcastsFromCategory.UseVisualStyleBackColor = true;
            this.BtnListPodcastsFromCategory.Click += new System.EventHandler(this.BtnListPodcastsFromCategory_Click);
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowAll.Location = new System.Drawing.Point(398, 4);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.Size = new System.Drawing.Size(129, 27);
            this.BtnShowAll.TabIndex = 41;
            this.BtnShowAll.Text = "Show all podcasts";
            this.BtnShowAll.UseVisualStyleBackColor = true;
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LbFeedOfPodcasts);
            this.panel1.Controls.Add(this.TableFeed);
            this.panel1.Controls.Add(this.BtnShowAll);
            this.panel1.Controls.Add(this.CboxCategory);
            this.panel1.Controls.Add(this.LbUrl);
            this.panel1.Controls.Add(this.TbUrl);
            this.panel1.Controls.Add(this.CboxInterval);
            this.panel1.Controls.Add(this.LbDeletePodcast);
            this.panel1.Controls.Add(this.LbInterval);
            this.panel1.Controls.Add(this.lbCategory);
            this.panel1.Controls.Add(this.LbSavePodcast);
            this.panel1.Controls.Add(this.LbAddPodcast);
            this.panel1.Location = new System.Drawing.Point(22, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 306);
            this.panel1.TabIndex = 42;
            // 
            // LbFeedOfPodcasts
            // 
            this.LbFeedOfPodcasts.AutoSize = true;
            this.LbFeedOfPodcasts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFeedOfPodcasts.Location = new System.Drawing.Point(12, 11);
            this.LbFeedOfPodcasts.Name = "LbFeedOfPodcasts";
            this.LbFeedOfPodcasts.Size = new System.Drawing.Size(107, 20);
            this.LbFeedOfPodcasts.TabIndex = 42;
            this.LbFeedOfPodcasts.Text = "Your podcasts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.LbWriteCategory);
            this.panel2.Controls.Add(this.ListCategories);
            this.panel2.Controls.Add(this.LbCategories);
            this.panel2.Controls.Add(this.TbInputCategory);
            this.panel2.Controls.Add(this.BtnAddCategory);
            this.panel2.Controls.Add(this.BtnListPodcastsFromCategory);
            this.panel2.Controls.Add(this.BtnSaveCategory);
            this.panel2.Controls.Add(this.BtnDeleteCategory);
            this.panel2.Location = new System.Drawing.Point(590, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 306);
            this.panel2.TabIndex = 43;
            // 
            // LbWriteCategory
            // 
            this.LbWriteCategory.AutoSize = true;
            this.LbWriteCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWriteCategory.Location = new System.Drawing.Point(13, 223);
            this.LbWriteCategory.Name = "LbWriteCategory";
            this.LbWriteCategory.Size = new System.Drawing.Size(166, 13);
            this.LbWriteCategory.TabIndex = 41;
            this.LbWriteCategory.Text = "Create or change category:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ListPodcastEpisodes);
            this.panel3.Controls.Add(this.LbEpisodes);
            this.panel3.Location = new System.Drawing.Point(22, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 238);
            this.panel3.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Podcast:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.TxtPodcastDescription);
            this.panel4.Controls.Add(this.LbPodcastInformation);
            this.panel4.Location = new System.Drawing.Point(450, 401);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 238);
            this.panel4.TabIndex = 45;
            // 
            // LbProgramTitle
            // 
            this.LbProgramTitle.AutoSize = true;
            this.LbProgramTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProgramTitle.Location = new System.Drawing.Point(214, 17);
            this.LbProgramTitle.Name = "LbProgramTitle";
            this.LbProgramTitle.Size = new System.Drawing.Size(421, 32);
            this.LbProgramTitle.TabIndex = 46;
            this.LbProgramTitle.Text = "AUTOMATIC PODCAST RSS READER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(859, 660);
            this.Controls.Add(this.LbProgramTitle);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Podcast RSS Reader";
            ((System.ComponentModel.ISupportInitialize)(this.TableFeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label LbInterval;
        private System.Windows.Forms.Label LbUrl;
        private System.Windows.Forms.Label LbCategories;
        private System.Windows.Forms.Label LbEpisodes;
        private System.Windows.Forms.Label LbPodcastInformation;
        private System.Windows.Forms.TextBox TbUrl;
        private System.Windows.Forms.ListBox ListCategories;
        private System.Windows.Forms.TextBox TbInputCategory;
        private System.Windows.Forms.Button LbDeletePodcast;
        private System.Windows.Forms.Button LbSavePodcast;
        private System.Windows.Forms.Button LbAddPodcast;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.Button BtnSaveCategory;
        private System.Windows.Forms.Button BtnDeleteCategory;
        private System.Windows.Forms.ListBox ListPodcastEpisodes;
        private System.Windows.Forms.ComboBox CboxInterval;
        private System.Windows.Forms.ComboBox CboxCategory;
        private System.Windows.Forms.TextBox TxtPodcastDescription;
        private System.Windows.Forms.Button BtnListPodcastsFromCategory;
        private System.Windows.Forms.Button BtnShowAll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbFeedOfPodcasts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LbWriteCategory;
        private System.Windows.Forms.Label LbProgramTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TableFeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEpisode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
    }
}

