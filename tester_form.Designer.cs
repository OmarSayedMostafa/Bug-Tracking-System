namespace ya_mosahel
{
    partial class tester_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tester_form));
            this.listView2_tester_bugs = new System.Windows.Forms.ListView();
            this.bug_tester_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bug_name_tester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bug_level_tester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bug_type_tester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bug_state_tester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tester_colum_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type_comboBox2 = new System.Windows.Forms.ComboBox();
            this.level_comboBox1 = new System.Windows.Forms.ComboBox();
            this.tester_tab_bug_name = new System.Windows.Forms.TextBox();
            this.tester_add_new_bugbutton1 = new System.Windows.Forms.Button();
            this.save_button2 = new System.Windows.Forms.Button();
            this.log_out_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView2_tester_bugs
            // 
            this.listView2_tester_bugs.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView2_tester_bugs.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView2_tester_bugs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bug_tester_id,
            this.bug_name_tester,
            this.bug_level_tester,
            this.bug_type_tester,
            this.bug_state_tester,
            this.tester_colum_name});
            this.listView2_tester_bugs.FullRowSelect = true;
            this.listView2_tester_bugs.GridLines = true;
            this.listView2_tester_bugs.HoverSelection = true;
            this.listView2_tester_bugs.Location = new System.Drawing.Point(28, 76);
            this.listView2_tester_bugs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView2_tester_bugs.Name = "listView2_tester_bugs";
            this.listView2_tester_bugs.Size = new System.Drawing.Size(632, 602);
            this.listView2_tester_bugs.TabIndex = 15;
            this.listView2_tester_bugs.UseCompatibleStateImageBehavior = false;
            this.listView2_tester_bugs.View = System.Windows.Forms.View.Details;
            this.listView2_tester_bugs.SelectedIndexChanged += new System.EventHandler(this.listView2_tester_bugs_SelectedIndexChanged);
            // 
            // bug_tester_id
            // 
            this.bug_tester_id.Text = "Bug ID";
            this.bug_tester_id.Width = 70;
            // 
            // bug_name_tester
            // 
            this.bug_name_tester.Text = "BUG NAME";
            this.bug_name_tester.Width = 110;
            // 
            // bug_level_tester
            // 
            this.bug_level_tester.Text = "BUG Level";
            this.bug_level_tester.Width = 110;
            // 
            // bug_type_tester
            // 
            this.bug_type_tester.Text = "BUG TYPE";
            this.bug_type_tester.Width = 110;
            // 
            // bug_state_tester
            // 
            this.bug_state_tester.Text = "BUG STATUE";
            this.bug_state_tester.Width = 110;
            // 
            // tester_colum_name
            // 
            this.tester_colum_name.Text = "Tester Name";
            this.tester_colum_name.Width = 110;
            // 
            // type_comboBox2
            // 
            this.type_comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_comboBox2.FormattingEnabled = true;
            this.type_comboBox2.Items.AddRange(new object[] {
            "UI",
            "Business"});
            this.type_comboBox2.Location = new System.Drawing.Point(753, 181);
            this.type_comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.type_comboBox2.Name = "type_comboBox2";
            this.type_comboBox2.Size = new System.Drawing.Size(160, 30);
            this.type_comboBox2.TabIndex = 22;
            this.type_comboBox2.Text = "type";
            // 
            // level_comboBox1
            // 
            this.level_comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_comboBox1.FormattingEnabled = true;
            this.level_comboBox1.Items.AddRange(new object[] {
            "critical",
            "high",
            "midium",
            "low"});
            this.level_comboBox1.Location = new System.Drawing.Point(974, 181);
            this.level_comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.level_comboBox1.Name = "level_comboBox1";
            this.level_comboBox1.Size = new System.Drawing.Size(160, 30);
            this.level_comboBox1.TabIndex = 21;
            this.level_comboBox1.Text = "level";
            // 
            // tester_tab_bug_name
            // 
            this.tester_tab_bug_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tester_tab_bug_name.Location = new System.Drawing.Point(753, 76);
            this.tester_tab_bug_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tester_tab_bug_name.Name = "tester_tab_bug_name";
            this.tester_tab_bug_name.Size = new System.Drawing.Size(381, 28);
            this.tester_tab_bug_name.TabIndex = 19;
            this.tester_tab_bug_name.Text = "bug Name";
            // 
            // tester_add_new_bugbutton1
            // 
            this.tester_add_new_bugbutton1.BackgroundImage = global::ya_mosahel.Properties.Resources._1431237357_bug_spider_tools_128;
            this.tester_add_new_bugbutton1.Location = new System.Drawing.Point(1027, 554);
            this.tester_add_new_bugbutton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tester_add_new_bugbutton1.Name = "tester_add_new_bugbutton1";
            this.tester_add_new_bugbutton1.Size = new System.Drawing.Size(130, 124);
            this.tester_add_new_bugbutton1.TabIndex = 18;
            this.tester_add_new_bugbutton1.Text = "Add New Bug";
            this.tester_add_new_bugbutton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tester_add_new_bugbutton1.UseVisualStyleBackColor = true;
            this.tester_add_new_bugbutton1.Click += new System.EventHandler(this.tester_add_new_bugbutton1_Click);
            // 
            // save_button2
            // 
            this.save_button2.BackgroundImage = global::ya_mosahel.Properties.Resources._1431223396_Save;
            this.save_button2.Location = new System.Drawing.Point(774, 554);
            this.save_button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_button2.Name = "save_button2";
            this.save_button2.Size = new System.Drawing.Size(122, 124);
            this.save_button2.TabIndex = 24;
            this.save_button2.Text = "save";
            this.save_button2.UseVisualStyleBackColor = true;
            this.save_button2.Click += new System.EventHandler(this.save_button2_Click);
            // 
            // log_out_button1
            // 
            this.log_out_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0625F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_button1.Image = global::ya_mosahel.Properties.Resources._1431237647_remove_sign_128;
            this.log_out_button1.Location = new System.Drawing.Point(1195, 76);
            this.log_out_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_out_button1.Name = "log_out_button1";
            this.log_out_button1.Size = new System.Drawing.Size(127, 129);
            this.log_out_button1.TabIndex = 25;
            this.log_out_button1.Text = "Log Out";
            this.log_out_button1.UseVisualStyleBackColor = true;
            this.log_out_button1.Click += new System.EventHandler(this.log_out_button1_Click);
            // 
            // tester_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ya_mosahel.Properties.Resources.wallpaper_developer_api__matuzalem_teles_by_matuzalemteles_d60g4rv4;
            this.ClientSize = new System.Drawing.Size(1723, 828);
            this.Controls.Add(this.log_out_button1);
            this.Controls.Add(this.save_button2);
            this.Controls.Add(this.listView2_tester_bugs);
            this.Controls.Add(this.type_comboBox2);
            this.Controls.Add(this.level_comboBox1);
            this.Controls.Add(this.tester_tab_bug_name);
            this.Controls.Add(this.tester_add_new_bugbutton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "tester_form";
            this.Text = "tester_form";
            this.Load += new System.EventHandler(this.tester_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView2_tester_bugs;
        private System.Windows.Forms.ColumnHeader bug_tester_id;
        private System.Windows.Forms.ColumnHeader bug_name_tester;
        private System.Windows.Forms.ColumnHeader bug_level_tester;
        private System.Windows.Forms.ColumnHeader bug_type_tester;
        private System.Windows.Forms.ColumnHeader bug_state_tester;
        private System.Windows.Forms.ColumnHeader tester_colum_name;
        private System.Windows.Forms.ComboBox type_comboBox2;
        private System.Windows.Forms.ComboBox level_comboBox1;
        private System.Windows.Forms.TextBox tester_tab_bug_name;
        private System.Windows.Forms.Button tester_add_new_bugbutton1;
        private System.Windows.Forms.Button save_button2;
        private System.Windows.Forms.Button log_out_button1;
    }
}