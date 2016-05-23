namespace ya_mosahel
{
    partial class developer_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(developer_form));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developer_form_level_button1 = new System.Windows.Forms.Button();
            this.developer_form_type_button2 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bugtester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.log_out_button1 = new System.Windows.Forms.Button();
            this.save_developer_formbutton1 = new System.Windows.Forms.Button();
            this.bug_list = new System.Windows.Forms.Button();
            this.new_sms_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.new_sms_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeBugToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 30);
            // 
            // closeBugToolStripMenuItem
            // 
            this.closeBugToolStripMenuItem.Name = "closeBugToolStripMenuItem";
            this.closeBugToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.closeBugToolStripMenuItem.Text = "close bug";
            this.closeBugToolStripMenuItem.Click += new System.EventHandler(this.closeBugToolStripMenuItem_Click);
            // 
            // developer_form_level_button1
            // 
            this.developer_form_level_button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.developer_form_level_button1.Location = new System.Drawing.Point(1117, 404);
            this.developer_form_level_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.developer_form_level_button1.Name = "developer_form_level_button1";
            this.developer_form_level_button1.Size = new System.Drawing.Size(136, 54);
            this.developer_form_level_button1.TabIndex = 5;
            this.developer_form_level_button1.Text = "Bugs by level";
            this.developer_form_level_button1.UseVisualStyleBackColor = false;
            this.developer_form_level_button1.Click += new System.EventHandler(this.developer_form_level_button1_Click);
            // 
            // developer_form_type_button2
            // 
            this.developer_form_type_button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.developer_form_type_button2.Location = new System.Drawing.Point(1117, 324);
            this.developer_form_type_button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.developer_form_type_button2.Name = "developer_form_type_button2";
            this.developer_form_type_button2.Size = new System.Drawing.Size(136, 54);
            this.developer_form_type_button2.TabIndex = 6;
            this.developer_form_type_button2.Text = "Bugs by type";
            this.developer_form_type_button2.UseVisualStyleBackColor = false;
            this.developer_form_type_button2.Click += new System.EventHandler(this.developer_form_type_button2_Click);
            // 
            // list
            // 
            this.list.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.list.AllowDrop = true;
            this.list.BackColor = System.Drawing.Color.Ivory;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.Bugtester});
            this.list.ContextMenuStrip = this.contextMenuStrip1;
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.HoverSelection = true;
            this.list.Location = new System.Drawing.Point(12, 62);
            this.list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(625, 529);
            this.list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list.TabIndex = 7;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
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
            // Bugtester
            // 
            this.Bugtester.Text = "BUG Tester";
            this.Bugtester.Width = 110;
            // 
            // log_out_button1
            // 
            this.log_out_button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.log_out_button1.BackgroundImage = global::ya_mosahel.Properties.Resources.images__2_;
            this.log_out_button1.Location = new System.Drawing.Point(1117, 13);
            this.log_out_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_out_button1.Name = "log_out_button1";
            this.log_out_button1.Size = new System.Drawing.Size(204, 206);
            this.log_out_button1.TabIndex = 9;
            this.log_out_button1.Text = "Log Out";
            this.log_out_button1.UseVisualStyleBackColor = false;
            this.log_out_button1.Click += new System.EventHandler(this.log_out_button1_Click);
            // 
            // save_developer_formbutton1
            // 
            this.save_developer_formbutton1.BackColor = System.Drawing.Color.LemonChiffon;
            this.save_developer_formbutton1.BackgroundImage = global::ya_mosahel.Properties.Resources._1431223396_Save;
            this.save_developer_formbutton1.Location = new System.Drawing.Point(1127, 543);
            this.save_developer_formbutton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_developer_formbutton1.Name = "save_developer_formbutton1";
            this.save_developer_formbutton1.Size = new System.Drawing.Size(126, 131);
            this.save_developer_formbutton1.TabIndex = 8;
            this.save_developer_formbutton1.Text = "Save";
            this.save_developer_formbutton1.UseVisualStyleBackColor = false;
            this.save_developer_formbutton1.Click += new System.EventHandler(this.save_developer_formbutton1_Click);
            // 
            // bug_list
            // 
            this.bug_list.BackColor = System.Drawing.Color.LemonChiffon;
            this.bug_list.Location = new System.Drawing.Point(12, 634);
            this.bug_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bug_list.Name = "bug_list";
            this.bug_list.Size = new System.Drawing.Size(218, 40);
            this.bug_list.TabIndex = 10;
            this.bug_list.Text = "Bug List";
            this.bug_list.UseVisualStyleBackColor = false;
            this.bug_list.Click += new System.EventHandler(this.bug_list_Click);
            // 
            // new_sms_pictureBox1
            // 
            this.new_sms_pictureBox1.Image = global::ya_mosahel.Properties.Resources.flag_notification_2_512;
            this.new_sms_pictureBox1.Location = new System.Drawing.Point(993, 13);
            this.new_sms_pictureBox1.Name = "new_sms_pictureBox1";
            this.new_sms_pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.new_sms_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.new_sms_pictureBox1.TabIndex = 11;
            this.new_sms_pictureBox1.TabStop = false;
            this.new_sms_pictureBox1.Click += new System.EventHandler(this.new_sms_pictureBox1_Click);
            // 
            // developer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ya_mosahel.Properties.Resources.big_fa6b43c0f2abc294ec30de84096be18294d9129b2;
            this.ClientSize = new System.Drawing.Size(1601, 846);
            this.Controls.Add(this.new_sms_pictureBox1);
            this.Controls.Add(this.bug_list);
            this.Controls.Add(this.log_out_button1);
            this.Controls.Add(this.save_developer_formbutton1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.developer_form_type_button2);
            this.Controls.Add(this.developer_form_level_button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "developer_form";
            this.Text = "developer_form";
            this.Load += new System.EventHandler(this.developer_form_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.new_sms_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button developer_form_level_button1;
        private System.Windows.Forms.Button developer_form_type_button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeBugToolStripMenuItem;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button save_developer_formbutton1;
        private System.Windows.Forms.Button log_out_button1;
        private System.Windows.Forms.Button bug_list;
        private System.Windows.Forms.ColumnHeader Bugtester;
        private System.Windows.Forms.PictureBox new_sms_pictureBox1;
    }
}