namespace ya_mosahel
{
    partial class manager_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_form));
            this.manager_tabs = new System.Windows.Forms.TabControl();
            this.manager_add_developer_tab = new System.Windows.Forms.TabPage();
            this.save_manager_form_developerbutton1 = new System.Windows.Forms.Button();
            this.developer_listView1 = new System.Windows.Forms.ListView();
            this.ID_colum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAMe_columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.submit_manger_add_dev_button1 = new System.Windows.Forms.Button();
            this.developername_textBox1 = new System.Windows.Forms.TextBox();
            this.manager_add_tester_tab = new System.Windows.Forms.TabPage();
            this.manger_save_tester_button1 = new System.Windows.Forms.Button();
            this.listView_tester = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sumbmit_button_tester = new System.Windows.Forms.Button();
            this.testername_textBox1 = new System.Windows.Forms.TextBox();
            this.manager_bug_options = new System.Windows.Forms.TabPage();
            this.save_button1 = new System.Windows.Forms.Button();
            this.assign_developer_listView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assign_bug = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.assignSelectedBugToDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closed_bugs_button2 = new System.Windows.Forms.Button();
            this.open_bugs_button1 = new System.Windows.Forms.Button();
            this.business_button1 = new System.Windows.Forms.Button();
            this.UI_button1 = new System.Windows.Forms.Button();
            this.Sort_bug_button1 = new System.Windows.Forms.Button();
            this.manager_bug_tab_view_all_button1 = new System.Windows.Forms.Button();
            this.listView2_manager_bug_tab = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.select_bug = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.log_out_button1 = new System.Windows.Forms.Button();
            this.manager_tabs.SuspendLayout();
            this.manager_add_developer_tab.SuspendLayout();
            this.manager_add_tester_tab.SuspendLayout();
            this.manager_bug_options.SuspendLayout();
            this.assign_bug.SuspendLayout();
            this.select_bug.SuspendLayout();
            this.SuspendLayout();
            // 
            // manager_tabs
            // 
            this.manager_tabs.Controls.Add(this.manager_add_developer_tab);
            this.manager_tabs.Controls.Add(this.manager_add_tester_tab);
            this.manager_tabs.Controls.Add(this.manager_bug_options);
            this.manager_tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_tabs.Location = new System.Drawing.Point(16, 95);
            this.manager_tabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_tabs.Name = "manager_tabs";
            this.manager_tabs.SelectedIndex = 0;
            this.manager_tabs.Size = new System.Drawing.Size(1237, 628);
            this.manager_tabs.TabIndex = 1;
            // 
            // manager_add_developer_tab
            // 
            this.manager_add_developer_tab.Controls.Add(this.save_manager_form_developerbutton1);
            this.manager_add_developer_tab.Controls.Add(this.developer_listView1);
            this.manager_add_developer_tab.Controls.Add(this.submit_manger_add_dev_button1);
            this.manager_add_developer_tab.Controls.Add(this.developername_textBox1);
            this.manager_add_developer_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_add_developer_tab.Location = new System.Drawing.Point(4, 29);
            this.manager_add_developer_tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_add_developer_tab.Name = "manager_add_developer_tab";
            this.manager_add_developer_tab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_add_developer_tab.Size = new System.Drawing.Size(1229, 595);
            this.manager_add_developer_tab.TabIndex = 0;
            this.manager_add_developer_tab.Text = "Add new devloper to syetem";
            this.manager_add_developer_tab.UseVisualStyleBackColor = true;
            // 
            // save_manager_form_developerbutton1
            // 
            this.save_manager_form_developerbutton1.BackgroundImage = global::ya_mosahel.Properties.Resources._1431223396_Save;
            this.save_manager_form_developerbutton1.Location = new System.Drawing.Point(835, 392);
            this.save_manager_form_developerbutton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_manager_form_developerbutton1.Name = "save_manager_form_developerbutton1";
            this.save_manager_form_developerbutton1.Size = new System.Drawing.Size(128, 133);
            this.save_manager_form_developerbutton1.TabIndex = 7;
            this.save_manager_form_developerbutton1.Text = "save";
            this.save_manager_form_developerbutton1.UseVisualStyleBackColor = true;
            this.save_manager_form_developerbutton1.Click += new System.EventHandler(this.save_manager_form_developerbutton1_Click);
            // 
            // developer_listView1
            // 
            this.developer_listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_colum,
            this.NAMe_columnHeader1});
            this.developer_listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developer_listView1.FullRowSelect = true;
            this.developer_listView1.GridLines = true;
            this.developer_listView1.Location = new System.Drawing.Point(54, 62);
            this.developer_listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.developer_listView1.Name = "developer_listView1";
            this.developer_listView1.Size = new System.Drawing.Size(284, 463);
            this.developer_listView1.TabIndex = 6;
            this.developer_listView1.UseCompatibleStateImageBehavior = false;
            this.developer_listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID_colum
            // 
            this.ID_colum.Text = "ID";
            this.ID_colum.Width = 80;
            // 
            // NAMe_columnHeader1
            // 
            this.NAMe_columnHeader1.Text = "NAME";
            this.NAMe_columnHeader1.Width = 200;
            // 
            // submit_manger_add_dev_button1
            // 
            this.submit_manger_add_dev_button1.BackgroundImage = global::ya_mosahel.Properties.Resources._1431223436_contact_new;
            this.submit_manger_add_dev_button1.Location = new System.Drawing.Point(667, 392);
            this.submit_manger_add_dev_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submit_manger_add_dev_button1.Name = "submit_manger_add_dev_button1";
            this.submit_manger_add_dev_button1.Size = new System.Drawing.Size(130, 133);
            this.submit_manger_add_dev_button1.TabIndex = 5;
            this.submit_manger_add_dev_button1.UseVisualStyleBackColor = true;
            this.submit_manger_add_dev_button1.Click += new System.EventHandler(this.submit_manger_add_dev_button1_Click);
            // 
            // developername_textBox1
            // 
            this.developername_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0625F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developername_textBox1.Location = new System.Drawing.Point(667, 62);
            this.developername_textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.developername_textBox1.Name = "developername_textBox1";
            this.developername_textBox1.Size = new System.Drawing.Size(296, 36);
            this.developername_textBox1.TabIndex = 2;
            this.developername_textBox1.Text = "Developer Name";
            // 
            // manager_add_tester_tab
            // 
            this.manager_add_tester_tab.Controls.Add(this.manger_save_tester_button1);
            this.manager_add_tester_tab.Controls.Add(this.listView_tester);
            this.manager_add_tester_tab.Controls.Add(this.sumbmit_button_tester);
            this.manager_add_tester_tab.Controls.Add(this.testername_textBox1);
            this.manager_add_tester_tab.Location = new System.Drawing.Point(4, 29);
            this.manager_add_tester_tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_add_tester_tab.Name = "manager_add_tester_tab";
            this.manager_add_tester_tab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_add_tester_tab.Size = new System.Drawing.Size(1229, 595);
            this.manager_add_tester_tab.TabIndex = 2;
            this.manager_add_tester_tab.Text = "Add new tester to system";
            this.manager_add_tester_tab.UseVisualStyleBackColor = true;
            // 
            // manger_save_tester_button1
            // 
            this.manger_save_tester_button1.BackgroundImage = global::ya_mosahel.Properties.Resources._1431223396_Save;
            this.manger_save_tester_button1.Location = new System.Drawing.Point(818, 416);
            this.manger_save_tester_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manger_save_tester_button1.Name = "manger_save_tester_button1";
            this.manger_save_tester_button1.Size = new System.Drawing.Size(126, 129);
            this.manger_save_tester_button1.TabIndex = 10;
            this.manger_save_tester_button1.Text = "save";
            this.manger_save_tester_button1.UseVisualStyleBackColor = true;
            this.manger_save_tester_button1.Click += new System.EventHandler(this.manger_save_tester_button1_Click);
            // 
            // listView_tester
            // 
            this.listView_tester.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_tester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_tester.FullRowSelect = true;
            this.listView_tester.GridLines = true;
            this.listView_tester.Location = new System.Drawing.Point(64, 75);
            this.listView_tester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_tester.Name = "listView_tester";
            this.listView_tester.Size = new System.Drawing.Size(290, 470);
            this.listView_tester.TabIndex = 9;
            this.listView_tester.UseCompatibleStateImageBehavior = false;
            this.listView_tester.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NAME";
            this.columnHeader2.Width = 200;
            // 
            // sumbmit_button_tester
            // 
            this.sumbmit_button_tester.BackgroundImage = global::ya_mosahel.Properties.Resources._1431223455_mypc_add1;
            this.sumbmit_button_tester.Location = new System.Drawing.Point(657, 416);
            this.sumbmit_button_tester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sumbmit_button_tester.Name = "sumbmit_button_tester";
            this.sumbmit_button_tester.Size = new System.Drawing.Size(131, 129);
            this.sumbmit_button_tester.TabIndex = 8;
            this.sumbmit_button_tester.UseVisualStyleBackColor = true;
            this.sumbmit_button_tester.Click += new System.EventHandler(this.sumbmit_button_tester_Click);
            // 
            // testername_textBox1
            // 
            this.testername_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0625F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testername_textBox1.Location = new System.Drawing.Point(657, 75);
            this.testername_textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testername_textBox1.Name = "testername_textBox1";
            this.testername_textBox1.Size = new System.Drawing.Size(287, 36);
            this.testername_textBox1.TabIndex = 7;
            this.testername_textBox1.Text = "Tester  Name";
            // 
            // manager_bug_options
            // 
            this.manager_bug_options.Controls.Add(this.save_button1);
            this.manager_bug_options.Controls.Add(this.assign_developer_listView1);
            this.manager_bug_options.Controls.Add(this.closed_bugs_button2);
            this.manager_bug_options.Controls.Add(this.open_bugs_button1);
            this.manager_bug_options.Controls.Add(this.business_button1);
            this.manager_bug_options.Controls.Add(this.UI_button1);
            this.manager_bug_options.Controls.Add(this.Sort_bug_button1);
            this.manager_bug_options.Controls.Add(this.manager_bug_tab_view_all_button1);
            this.manager_bug_options.Controls.Add(this.listView2_manager_bug_tab);
            this.manager_bug_options.Location = new System.Drawing.Point(4, 29);
            this.manager_bug_options.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_bug_options.Name = "manager_bug_options";
            this.manager_bug_options.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_bug_options.Size = new System.Drawing.Size(1229, 595);
            this.manager_bug_options.TabIndex = 3;
            this.manager_bug_options.Text = "BUGS Options";
            this.manager_bug_options.UseVisualStyleBackColor = true;
            // 
            // save_button1
            // 
            this.save_button1.BackgroundImage = global::ya_mosahel.Properties.Resources._1431223396_Save;
            this.save_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button1.Location = new System.Drawing.Point(698, 431);
            this.save_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_button1.Name = "save_button1";
            this.save_button1.Size = new System.Drawing.Size(128, 131);
            this.save_button1.TabIndex = 12;
            this.save_button1.Text = "Save";
            this.save_button1.UseVisualStyleBackColor = true;
            this.save_button1.Click += new System.EventHandler(this.save_button1_Click);
            // 
            // assign_developer_listView1
            // 
            this.assign_developer_listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.assign_developer_listView1.ContextMenuStrip = this.assign_bug;
            this.assign_developer_listView1.FullRowSelect = true;
            this.assign_developer_listView1.GridLines = true;
            this.assign_developer_listView1.Location = new System.Drawing.Point(909, 46);
            this.assign_developer_listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assign_developer_listView1.Name = "assign_developer_listView1";
            this.assign_developer_listView1.Size = new System.Drawing.Size(286, 508);
            this.assign_developer_listView1.TabIndex = 11;
            this.assign_developer_listView1.UseCompatibleStateImageBehavior = false;
            this.assign_developer_listView1.View = System.Windows.Forms.View.Details;
            this.assign_developer_listView1.SelectedIndexChanged += new System.EventHandler(this.assign_developer_listView1_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "NAME";
            this.columnHeader10.Width = 200;
            // 
            // assign_bug
            // 
            this.assign_bug.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignSelectedBugToDeveloperToolStripMenuItem});
            this.assign_bug.Name = "contextMenuStrip1";
            this.assign_bug.Size = new System.Drawing.Size(307, 30);
            // 
            // assignSelectedBugToDeveloperToolStripMenuItem
            // 
            this.assignSelectedBugToDeveloperToolStripMenuItem.Name = "assignSelectedBugToDeveloperToolStripMenuItem";
            this.assignSelectedBugToDeveloperToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.assignSelectedBugToDeveloperToolStripMenuItem.Text = "assign selected bug to developer";
            this.assignSelectedBugToDeveloperToolStripMenuItem.Click += new System.EventHandler(this.assignSelectedBugToDeveloperToolStripMenuItem_Click);
            // 
            // closed_bugs_button2
            // 
            this.closed_bugs_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closed_bugs_button2.Location = new System.Drawing.Point(698, 46);
            this.closed_bugs_button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closed_bugs_button2.Name = "closed_bugs_button2";
            this.closed_bugs_button2.Size = new System.Drawing.Size(128, 40);
            this.closed_bugs_button2.TabIndex = 9;
            this.closed_bugs_button2.Text = "view closed bugs";
            this.closed_bugs_button2.UseVisualStyleBackColor = true;
            this.closed_bugs_button2.Click += new System.EventHandler(this.closed_bugs_button2_Click);
            // 
            // open_bugs_button1
            // 
            this.open_bugs_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_bugs_button1.Location = new System.Drawing.Point(698, 123);
            this.open_bugs_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.open_bugs_button1.Name = "open_bugs_button1";
            this.open_bugs_button1.Size = new System.Drawing.Size(128, 41);
            this.open_bugs_button1.TabIndex = 8;
            this.open_bugs_button1.Text = "view open bugs";
            this.open_bugs_button1.UseVisualStyleBackColor = true;
            this.open_bugs_button1.Click += new System.EventHandler(this.open_bugs_button1_Click);
            // 
            // business_button1
            // 
            this.business_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_button1.Location = new System.Drawing.Point(698, 199);
            this.business_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.business_button1.Name = "business_button1";
            this.business_button1.Size = new System.Drawing.Size(128, 42);
            this.business_button1.TabIndex = 7;
            this.business_button1.Text = "view Business bug ";
            this.business_button1.UseVisualStyleBackColor = true;
            this.business_button1.Click += new System.EventHandler(this.business_button1_Click);
            // 
            // UI_button1
            // 
            this.UI_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_button1.Location = new System.Drawing.Point(698, 273);
            this.UI_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UI_button1.Name = "UI_button1";
            this.UI_button1.Size = new System.Drawing.Size(128, 42);
            this.UI_button1.TabIndex = 6;
            this.UI_button1.Text = "view UI bug ";
            this.UI_button1.UseVisualStyleBackColor = true;
            this.UI_button1.Click += new System.EventHandler(this.UI_button1_Click);
            // 
            // Sort_bug_button1
            // 
            this.Sort_bug_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort_bug_button1.Location = new System.Drawing.Point(698, 351);
            this.Sort_bug_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sort_bug_button1.Name = "Sort_bug_button1";
            this.Sort_bug_button1.Size = new System.Drawing.Size(128, 39);
            this.Sort_bug_button1.TabIndex = 5;
            this.Sort_bug_button1.Text = "view bug by levelty";
            this.Sort_bug_button1.UseVisualStyleBackColor = true;
            this.Sort_bug_button1.Click += new System.EventHandler(this.Sort_bug_button1_Click);
            // 
            // manager_bug_tab_view_all_button1
            // 
            this.manager_bug_tab_view_all_button1.Location = new System.Drawing.Point(900, 627);
            this.manager_bug_tab_view_all_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_bug_tab_view_all_button1.Name = "manager_bug_tab_view_all_button1";
            this.manager_bug_tab_view_all_button1.Size = new System.Drawing.Size(141, 53);
            this.manager_bug_tab_view_all_button1.TabIndex = 4;
            this.manager_bug_tab_view_all_button1.Text = "View all bug";
            this.manager_bug_tab_view_all_button1.UseVisualStyleBackColor = true;
            this.manager_bug_tab_view_all_button1.Click += new System.EventHandler(this.manager_bug_tab_view_all_button1_Click);
            // 
            // listView2_manager_bug_tab
            // 
            this.listView2_manager_bug_tab.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView2_manager_bug_tab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2_manager_bug_tab.ContextMenuStrip = this.select_bug;
            this.listView2_manager_bug_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2_manager_bug_tab.FullRowSelect = true;
            this.listView2_manager_bug_tab.GridLines = true;
            this.listView2_manager_bug_tab.HoverSelection = true;
            this.listView2_manager_bug_tab.Location = new System.Drawing.Point(6, 46);
            this.listView2_manager_bug_tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView2_manager_bug_tab.Name = "listView2_manager_bug_tab";
            this.listView2_manager_bug_tab.Size = new System.Drawing.Size(630, 508);
            this.listView2_manager_bug_tab.TabIndex = 3;
            this.listView2_manager_bug_tab.UseCompatibleStateImageBehavior = false;
            this.listView2_manager_bug_tab.View = System.Windows.Forms.View.Details;
            this.listView2_manager_bug_tab.SelectedIndexChanged += new System.EventHandler(this.listView2_manager_bug_tab_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bug ID";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "BUG NAME";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "BUG Level";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "BUG TYPE";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "BUG STATUE";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tester Name";
            this.columnHeader8.Width = 110;
            // 
            // select_bug
            // 
            this.select_bug.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.select_bug.Name = "contextMenuStrip1";
            this.select_bug.Size = new System.Drawing.Size(151, 30);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.toolStripMenuItem1.Text = "select bug";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // log_out_button1
            // 
            this.log_out_button1.BackgroundImage = global::ya_mosahel.Properties.Resources._1431231230_on_off1;
            this.log_out_button1.Location = new System.Drawing.Point(1151, 20);
            this.log_out_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_out_button1.Name = "log_out_button1";
            this.log_out_button1.Size = new System.Drawing.Size(102, 96);
            this.log_out_button1.TabIndex = 26;
            this.log_out_button1.UseVisualStyleBackColor = true;
            this.log_out_button1.Click += new System.EventHandler(this.log_out_button1_Click);
            // 
            // manager_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::ya_mosahel.Properties.Resources.hariharakrishnan_1400051907_66;
            this.ClientSize = new System.Drawing.Size(1337, 755);
            this.Controls.Add(this.log_out_button1);
            this.Controls.Add(this.manager_tabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "manager_form";
            this.Text = "manager_form";
            this.Load += new System.EventHandler(this.manager_form_Load);
            this.manager_tabs.ResumeLayout(false);
            this.manager_add_developer_tab.ResumeLayout(false);
            this.manager_add_developer_tab.PerformLayout();
            this.manager_add_tester_tab.ResumeLayout(false);
            this.manager_add_tester_tab.PerformLayout();
            this.manager_bug_options.ResumeLayout(false);
            this.assign_bug.ResumeLayout(false);
            this.select_bug.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl manager_tabs;
        private System.Windows.Forms.TabPage manager_add_developer_tab;
        private System.Windows.Forms.ListView developer_listView1;
        private System.Windows.Forms.ColumnHeader ID_colum;
        private System.Windows.Forms.ColumnHeader NAMe_columnHeader1;
        private System.Windows.Forms.TextBox developername_textBox1;
        private System.Windows.Forms.TabPage manager_add_tester_tab;
        private System.Windows.Forms.ListView listView_tester;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button sumbmit_button_tester;
        private System.Windows.Forms.TextBox testername_textBox1;
        private System.Windows.Forms.TabPage manager_bug_options;
        private System.Windows.Forms.Button Sort_bug_button1;
        private System.Windows.Forms.Button manager_bug_tab_view_all_button1;
        private System.Windows.Forms.ListView listView2_manager_bug_tab;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button business_button1;
        private System.Windows.Forms.Button UI_button1;
        private System.Windows.Forms.Button closed_bugs_button2;
        private System.Windows.Forms.Button open_bugs_button1;
        private System.Windows.Forms.ListView assign_developer_listView1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ContextMenuStrip select_bug;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip assign_bug;
        private System.Windows.Forms.ToolStripMenuItem assignSelectedBugToDeveloperToolStripMenuItem;
        private System.Windows.Forms.Button manger_save_tester_button1;
        private System.Windows.Forms.Button save_button1;
        private System.Windows.Forms.Button log_out_button1;
        private System.Windows.Forms.Button save_manager_form_developerbutton1;
        private System.Windows.Forms.Button submit_manger_add_dev_button1;
    }
}