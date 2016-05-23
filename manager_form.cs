using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ya_mosahel
{
    
    public partial class manager_form : Form
    {
        manager m;
        String id_bug;
        public manager_form(manager m)
        {
            this.m = m;
            //***************
            InitializeComponent();
            //*******************
            m.filter_bug_into_types();
            m.filter_into_closed_and_open();
            //************************
            show_list_MANAGER();
            show_developer_list_to_bug_to_manager();        
           
        }
       //************************************************************************ submit a tester
        private void sumbmit_button_tester_Click(object sender, EventArgs e)
        {
            tester testerr = new tester(testername_textBox1.Text);
            m.put_new_tester_box(testerr);
            ListViewItem item = new ListViewItem(m.get_tester_box().ElementAt(m.get_tester_box().Count - 1).get_id().ToString());
            item.SubItems.Add(m.get_tester_box().Peek().get_name());
            listView_tester.Items.Add(item);
            testername_textBox1.Clear();
        }
        //*************************************************************************************view all bug button
        private void manager_bug_tab_view_all_button1_Click(object sender, EventArgs e)
        {
            listView2_manager_bug_tab.Items.Clear();
            ListViewItem item;
            for (int i = 0; i < m.view_all_system_bug_list().Count; i++)
            {
                item = new ListViewItem(m.view_all_system_bug_list().ElementAt(i).get_bug_id().ToString());
                item.SubItems.Add(m.view_all_system_bug_list().ElementAt(i).get_bug_name());
                item.SubItems.Add(m.view_all_system_bug_list().ElementAt(i).get_bug_level_string());
                item.SubItems.Add(m.view_all_system_bug_list().ElementAt(i).get_bug_type());
                item.SubItems.Add(m.view_all_system_bug_list().ElementAt(i).get_bug_flag_string());
                item.SubItems.Add(m.view_all_system_bug_list().ElementAt(i).get_bug_tester());
                listView2_manager_bug_tab.Items.Add(item);
            }
        }
        //********************************************************************************************sort button
        private void Sort_bug_button1_Click(object sender, EventArgs e)
        {
            listView2_manager_bug_tab.Items.Clear();
            //m.arrange_sort();
            ListViewItem item;
            for (int i = 0; i < m.view_all_system_bug_list().Count; i++)
            {
                item = new ListViewItem(m.arrange_sort().ElementAt(i).get_bug_id().ToString());
                item.SubItems.Add(m.arrange_sort().ElementAt(i).get_bug_name());
                item.SubItems.Add(m.arrange_sort().ElementAt(i).get_bug_level_string());
                item.SubItems.Add(m.arrange_sort().ElementAt(i).get_bug_type());
                item.SubItems.Add(m.arrange_sort().ElementAt(i).get_bug_flag_string());
                item.SubItems.Add(m.arrange_sort().ElementAt(i).get_bug_tester());
                listView2_manager_bug_tab.Items.Add(item);
            }
        }
        //******************************************************************************************ui divide button
        private void UI_button1_Click(object sender, EventArgs e)
        {
            listView2_manager_bug_tab.Items.Clear();
            ListViewItem item;
            for (int i = 0; i < m.UI_bugs().Count; i++)
            {
                item = new ListViewItem(m.UI_bugs().ElementAt(i).get_bug_id().ToString());
                item.SubItems.Add(m.UI_bugs().ElementAt(i).get_bug_name());
                item.SubItems.Add(m.UI_bugs().ElementAt(i).get_bug_level_string());
                item.SubItems.Add(m.UI_bugs().ElementAt(i).get_bug_type());
                item.SubItems.Add(m.UI_bugs().ElementAt(i).get_bug_flag_string());
                item.SubItems.Add(m.UI_bugs().ElementAt(i).get_bug_tester());
                listView2_manager_bug_tab.Items.Add(item);
            }
        }
        //*************************************************************************************************bussiness divide buttoun
        private void business_button1_Click(object sender, EventArgs e)
        {
            listView2_manager_bug_tab.Items.Clear();
            ListViewItem item;
            for (int i = 0; i < m.Business_bugs().Count; i++)
            {
                item = new ListViewItem(m.Business_bugs().ElementAt(i).get_bug_id().ToString());
                item.SubItems.Add(m.Business_bugs().ElementAt(i).get_bug_name());
                item.SubItems.Add(m.Business_bugs().ElementAt(i).get_bug_level_string());
                item.SubItems.Add(m.Business_bugs().ElementAt(i).get_bug_type());
                item.SubItems.Add(m.Business_bugs().ElementAt(i).get_bug_flag_string());
                item.SubItems.Add(m.Business_bugs().ElementAt(i).get_bug_tester());
                listView2_manager_bug_tab.Items.Add(item);
            }
        }
        //*****************************************************************************************
        private void open_bugs_button1_Click(object sender, EventArgs e)
        {
            m.filter_into_closed_and_open();
            listView2_manager_bug_tab.Items.Clear();
            ListViewItem item;
            for (int i = 0; i < m.bug_open_method().Count; i++)
            {
                item = new ListViewItem(m.bug_open_method().ElementAt(i).get_bug_id().ToString());
                item.SubItems.Add(m.bug_open_method().ElementAt(i).get_bug_name());
                item.SubItems.Add(m.bug_open_method().ElementAt(i).get_bug_level_string());
                item.SubItems.Add(m.bug_open_method().ElementAt(i).get_bug_type());
                item.SubItems.Add(m.bug_open_method().ElementAt(i).get_bug_flag_string());
                item.SubItems.Add(m.bug_open_method().ElementAt(i).get_bug_tester());
                listView2_manager_bug_tab.Items.Add(item);
            }
        }
        //**********************************************************************************************
        private void closed_bugs_button2_Click(object sender, EventArgs e)
        {
            listView2_manager_bug_tab.Items.Clear();
            ListViewItem item;
            for (int i = 0; i < m.bug_closed_method().Count; i++)
            {
                item = new ListViewItem(m.bug_closed_method().ElementAt(i).get_bug_id().ToString());
                item.SubItems.Add(m.bug_closed_method().ElementAt(i).get_bug_name());
                item.SubItems.Add(m.bug_closed_method().ElementAt(i).get_bug_level_string());
                item.SubItems.Add(m.bug_closed_method().ElementAt(i).get_bug_type());
                item.SubItems.Add(m.bug_closed_method().ElementAt(i).get_bug_flag_string());
                item.SubItems.Add(m.bug_closed_method().ElementAt(i).get_bug_tester());
                listView2_manager_bug_tab.Items.Add(item);
            }
        }
        //********************************************************************************************** submit developer
        private void submit_manger_add_dev_button1_Click(object sender, EventArgs e)
        {
            developer develop = new developer(developername_textBox1.Text);
            m.put_new_developer_box(develop);
            ListViewItem item = new ListViewItem(m.get_developer_box().ElementAt(m.get_developer_box().Count - 1).get_id().ToString());
            item.SubItems.Add(m.get_developer_box().Peek().get_name());
            developer_listView1.Items.Add(item);
            developername_textBox1.Clear();
        }
        
        /// ///////////////////////////////////////////////***********************************************************
       
        private void assign_bug_to_devloper_button1_Click(object sender, EventArgs e)
        {
            ListViewItem i1 = listView2_manager_bug_tab.SelectedItems[0];
            String bug_id = i1.SubItems[0].Text;

            ListViewItem i2 = assign_developer_listView1.SelectedItems[0];
            String developer_id = i2.SubItems[0].Text;

        }

        private void listView2_manager_bug_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void assign_developer_listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //**************************************************************************************show manager list
        public void show_list_MANAGER()
        {    
           listView2_manager_bug_tab.Items.Clear();
            ListViewItem item;
            for (int i = 0; i < m.view_all_system_bug_list().Count; i++)
            {
                item = new ListViewItem(m.view_all_system_bug_list().ElementAt(i).get_bug_id().ToString());
                item.SubItems.Add(m.view_all_system_bug_list().ElementAt(i).get_bug_name());
                item.SubItems.Add(m.view_all_system_bug_list().ElementAt(i).get_bug_level_string());
                item.SubItems.Add(m.view_all_system_bug_list().ElementAt(i).get_bug_type());
                item.SubItems.Add(m.view_all_system_bug_list().ElementAt(i).get_bug_flag_string());
                item.SubItems.Add(m.view_all_system_bug_list().ElementAt(i).get_bug_tester());
                listView2_manager_bug_tab.Items.Add(item);
            }
        }
        //***********************************************************************************
        public void show_developer_list_to_bug_to_manager()//========================================developer list 
        {
            //MessageBox.Show("developers " + m.get_developer_box().Count().ToString());

            assign_developer_listView1.Items.Clear();
            ListViewItem item;
            for (int i = 0; i < m.get_developer_box().Count; i++)
            {
               item = new ListViewItem(m.get_developer_box().ElementAt(i).developer_id_real().ToString());
                item.SubItems.Add(m.get_developer_box().ElementAt(i).get_name()); 
                assign_developer_listView1.Items.Add(item);
            }
        }
        //=============================================================================================
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListViewItem i1 = listView2_manager_bug_tab.SelectedItems[0];
          id_bug = i1.SubItems[0].Text;
        }

        private void assignSelectedBugToDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem i2 = assign_developer_listView1.SelectedItems[0];
            String developer_id = i2.SubItems[0].Text;
            String[] temp = new String[2];
            temp=m.assign_bug_to_developer(id_bug, developer_id);
            MessageBox.Show("the bug "+temp[0]+" has assigned to developer "+temp[1]);
          
        }

        private void manager_form_Load(object sender, EventArgs e)
        {

        }
        //**********************************************************************************
        private void save_manager_form_developerbutton1_Click(object sender, EventArgs e)
        {
            m.save_dev_file();
            assign_developer_listView1.Items.Clear();
            show_developer_list_to_bug_to_manager();
            MessageBox.Show("saved");
        }
        //****************************************************************************
        private void manger_save_tester_button1_Click(object sender, EventArgs e)
        {
            m.save_tester_file();
            MessageBox.Show("Saved");
        }

        private void save_button1_Click(object sender, EventArgs e)
        {
            m.save_dev_file();
            MessageBox.Show("saved");
        }

        private void log_out_button1_Click(object sender, EventArgs e)
        {
            m.load_dev_file();
            Log_in_form lg = new Log_in_form(m);
            this.Hide();
            lg.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            developer develop = new developer(developername_textBox1.Text);
            m.put_new_developer_box(develop);
            ListViewItem item = new ListViewItem(m.get_developer_box().ElementAt(m.get_developer_box().Count - 1).get_id().ToString());
            item.SubItems.Add(m.get_developer_box().Peek().get_name());
            developer_listView1.Items.Add(item);
            developername_textBox1.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            m.save_dev_file();
            assign_developer_listView1.Items.Clear();
            show_developer_list_to_bug_to_manager();
            MessageBox.Show("saved");
        }
        private void manager_form_Closed(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
            Environment.Exit(1);
            Environment.Exit(2);
        }
    }
}
