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
    public partial class developer_form : Form
    {
        int show_list = 1;
        int checker = 0;//for perevent call ui/business function many times
        manager m;
        developer d;
        public developer_form(manager m,developer d)
        {
            this.m = m;
            this.d = d;
            InitializeComponent();
            new_sms_pictureBox1.Hide();
            if(d.get_bugs_assign_to_developer().Count>0)
            {
                new_sms_pictureBox1.Show();
            }
            list.Hide();
            show_list_temp();
        }

        private void developer_form_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_list_temp();
        }
       
       /// ////////////////////////////////////////////
       
 
        private void developer_form_Load(object sender, EventArgs e)
        {

        }

        private void developer_form_level_button1_Click(object sender, EventArgs e)
        {
            d.arrange();
            show_list_temp();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
            
        }

        private void closeBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem i1 = list.SelectedItems[0];
            String id = i1.SubItems[0].Text;
            d.close_bug_by_developer(id);
           m.close_bug_by_developer(id);
          // m.save_bugs_file();
        //   m.save_dev_file();
            show_list_temp();
            new_sms_pictureBox1.Hide();
           // list.SelectedItems[0].Remove();
            
        }

        private void developer_form_type_button2_Click(object sender, EventArgs e)
        {
            checker++;
            if(checker<=1)
            {
                d.divide_into_types();
            }
            
            list.Items.Clear();
            ListViewItem item;
            for (int i = 0; i < d.Business_bugs().Count; i++)
            {
                item = new ListViewItem(d.Business_bugs().ElementAt(i).get_bug_id().ToString());
                item.SubItems.Add(d.Business_bugs().ElementAt(i).get_bug_name());
                item.SubItems.Add(d.Business_bugs().ElementAt(i).get_bug_level_string());
                item.SubItems.Add(d.Business_bugs().ElementAt(i).get_bug_type());
                item.SubItems.Add(d.Business_bugs().ElementAt(i).get_bug_flag_string());
                item.SubItems.Add(d.Business_bugs().ElementAt(i).get_bug_tester());
                list.Items.Add(item);
            }
            for (int i = 0; i < d.UI_bugs().Count; i++)
            {
                item = new ListViewItem(d.UI_bugs().ElementAt(i).get_bug_id().ToString());
                item.SubItems.Add(d.UI_bugs().ElementAt(i).get_bug_name());
                item.SubItems.Add(d.UI_bugs().ElementAt(i).get_bug_level_string());
                item.SubItems.Add(d.UI_bugs().ElementAt(i).get_bug_type());
                item.SubItems.Add(d.UI_bugs().ElementAt(i).get_bug_flag_string());
                item.SubItems.Add(d.UI_bugs().ElementAt(i).get_bug_tester());
                list.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem it;
            for(int i=0;i<d.get_bugs_assign_to_developer().Count;i++)
            {
                it = new ListViewItem(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_id().ToString());
                it.SubItems.Add(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_name());
                it.SubItems.Add(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_level_string());
                it.SubItems.Add(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_type());
                it.SubItems.Add(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_flag_string());
                it.SubItems.Add(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_tester());
                list.Items.Add(it);
            }
        }
        public void show_list_temp()
        {
            list.Items.Clear();
           // m.load_bugs_file();
         //   m.load_dev_file();
            ListViewItem it;
            for(int i=0;i<d.get_bugs_assign_to_developer().Count;i++)
            {
                it = new ListViewItem(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_id().ToString());
                it.SubItems.Add(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_name());
                it.SubItems.Add(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_level_string());
                it.SubItems.Add(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_type());
                it.SubItems.Add(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_flag_string());
                it.SubItems.Add(d.get_bugs_assign_to_developer().ElementAt(i).get_bug_tester());
                list.Items.Add(it);
            }
        }

        private void save_developer_formbutton1_Click(object sender, EventArgs e)
        {
            m.save_dev_file();
            m.save_bugs_file();
            MessageBox.Show("Saved");
        }

        private void log_out_button1_Click(object sender, EventArgs e)
        {
            m.load_dev_file();
            Log_in_form lg = new Log_in_form(m);
            this.Hide();
            lg.Show();
        }

        private void bug_list_Click(object sender, EventArgs e)
        {
            show_list++;
            if(show_list %2==0)
            {
                list.Show();
            }
            else
            {
                list.Hide();
            }
        }

        private void new_sms_pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Have " + d.get_bugs_assign_to_developer().Count.ToString() + "Bugs Today");
            list.Show();
            show_list++;
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void developer_form_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Environment.Exit(1);
            Environment.Exit(2);
            Application.Exit();
            
        }
    }
}