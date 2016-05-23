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
    public partial class tester_form : Form
    {
        manager m;
        String tester_name;
        public tester_form(manager m,String name)
        {
            InitializeComponent();
            this.m = m;
            tester_name = name;
        }

        private void tester_add_new_bugbutton1_Click(object sender, EventArgs e)
        {
            int x;
            if (tester_tab_bug_name.Text == "bug Name" || tester_tab_bug_name.Text == "")
            {
                MessageBox.Show("please enter bug name");
            }
            if (level_comboBox1.Text == "level")
            {
                MessageBox.Show("please choose bug level");
            }
            if (type_comboBox2.Text == "type")
            {
                MessageBox.Show("please choose bug type");
            }
            else
            {

                if (level_comboBox1.Text == "critical")
                    x = 3;
                else if (level_comboBox1.Text == "high")
                    x = 2;
                else if (level_comboBox1.Text == "midium")
                    x = 1;
                else
                    x = 0;
                bug b = new bug(tester_tab_bug_name.Text, x, type_comboBox2.Text);
                b.set_bug_tester(tester_name);
                /////////////////////////////////////////////////////////////
                m.put_new_bug_to_system_list(b);

                ////////////////////////////////////////////////////////////
                ListViewItem item = new ListViewItem(m.view_all_system_bug_list().Peek().get_bug_id().ToString());
                item.SubItems.Add(m.view_all_system_bug_list().Peek().get_bug_name());
                item.SubItems.Add(m.view_all_system_bug_list().Peek().get_bug_level_string());
                item.SubItems.Add(m.view_all_system_bug_list().Peek().get_bug_flag_string());
                item.SubItems.Add(m.view_all_system_bug_list().Peek().get_bug_type());
                item.SubItems.Add(m.view_all_system_bug_list().Peek().get_bug_tester());
                listView2_tester_bugs.Items.Add(item);
                tester_tab_bug_name.Clear();
                level_comboBox1.ResetText();
                level_comboBox1.Text = "level";
                type_comboBox2.ResetText();
                type_comboBox2.Text = "type";
            }

               
        }

        private void listView2_tester_bugs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_button2_Click(object sender, EventArgs e)
        {
            m.save_bugs_file();
            MessageBox.Show("Saved");
        }

        private void tester_form_Load(object sender, EventArgs e)
        {

        }

        private void log_out_button1_Click(object sender, EventArgs e)
        {
            Log_in_form lg = new Log_in_form(m);
            this.Hide();
            lg.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void tester_form_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Environment.Exit(1);
            Environment.Exit(2);
            Application.Exit();
           
        }
    }
}
