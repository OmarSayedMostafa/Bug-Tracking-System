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
    public partial class Log_in_form : Form
    {
        
      
        manager m=manager.get_Instance;
   
        /// /////////////////////////////////////
        
        public Log_in_form()
        {
            
            InitializeComponent();
            ///***********************
            m.load_bugs_file();
           m.load_dev_file();
           m.load_tester_file();
            //////////////////////////
           m.compare_id();
        }
        public Log_in_form(manager m)
        {
            this.m = m;
            m.load_dev_file();
            InitializeComponent();
        }
       
       

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (username_text.Text == "master" && password_textBox2.Text == "123")
            {
               
                MessageBox.Show("Welcome");
                manager_form mf = new manager_form(m);
               
                this.Hide();
                mf.Show();
                
            }
            else if (m.get_developer_box().Count != 0 || m.get_tester_box().Count != 0)
            {
                for (int i = 0; i < m.get_tester_box().Count; i++)
                {
                    if (username_text.Text == m.get_tester_box().ElementAt(i).get_name() && password_textBox2.Text == m.get_tester_box().ElementAt(i).tester_real_id().ToString())
                    {
                        MessageBox.Show("welcome");
                        tester_form tf = new tester_form(m, username_text.Text);
                        
                        
                      
                        this.Hide();
                        tf.Show();
                        break;
                    }

                }
                for (int i = 0; i < m.get_developer_box().Count; i++)
                {
                    if (username_text.Text == m.get_developer_box().ElementAt(i).get_name() && password_textBox2.Text == m.get_developer_box().ElementAt(i).developer_id_real().ToString())
                    {
                        developer_form df = new developer_form(m, m.get_developer_box().ElementAt(i));
                        MessageBox.Show("welcome");
                       
                        this.Hide();
                        df.Show();
                        break;
                    }
                }
            }
           else 
            {
                MessageBox.Show("Invalid Username or Password ");
                username_text.Clear();
                password_textBox2.Clear();
            }
               
            
        }

        private void Log_in_form_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
             if (username_text.Text == "master" && password_textBox2.Text == "123")
            {
              
                MessageBox.Show("welcome" );
                manager_form mf = new manager_form(m);
               
                this.Hide();
                mf.Show();
            }
            else if (m.get_developer_box().Count != 0 || m.get_tester_box().Count != 0)
            {
                for (int i = 0; i < m.get_tester_box().Count; i++)
                {
                    if (username_text.Text == m.get_tester_box().ElementAt(i).get_name() && password_textBox2.Text == m.get_tester_box().ElementAt(i).tester_real_id().ToString())
                    {

                        tester_form tf = new tester_form(m, username_text.Text);
                        MessageBox.Show("welcome");
                        
                      
                        this.Hide();
                        tf.Show();
                        break;
                    }

                }
                for (int i = 0; i < m.get_developer_box().Count; i++)
                {
                    if (username_text.Text == m.get_developer_box().ElementAt(i).get_name() && password_textBox2.Text == m.get_developer_box().ElementAt(i).developer_id_real().ToString())
                    {
                        developer_form df = new developer_form(m, m.get_developer_box().ElementAt(i));
                        MessageBox.Show("welcome ");
                       
                        this.Hide();
                        df.Show();
                        break;
                    }
                }
            }
           else 
            {
                MessageBox.Show("Invalid Username or Password ");
                username_text.Clear();
                password_textBox2.Clear();
            }
               
            
        }

        private void Login_button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
    }

