using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ya_mosahel
{
    public class manager
    {

        // public Dictionary<int, bug> bug_box = new Dictionary<int, bug>();
        private Stack<bug> system_bug_list = new Stack<bug>();//2
        private Stack<developer> developer_box = new Stack<developer>();//1
        private Stack<tester> tester_box = new Stack<tester>();//3
        //public Dictionary<int, developer> developer_box = new Dictionary<int, developer>();
        private Stack<bug> UI_stack = new Stack<bug>();
        private Stack<bug> temp_stack = new Stack<bug>();
        private Stack<bug> sorted_stack = new Stack<bug>();
        private Stack<bug> Business_stack = new Stack<bug>();
        private Stack<bug> bug_closed = new Stack<bug>();
        private Stack<bug> bug_open = new Stack<bug>();
        private String manager_name = "team";
        private String manager_password = "123456789";
        public int compare1;
        public int compare2;
        /////////////////////////////////////////////////////////code save
        public void save_bugs_file()
        {
            FileStream f = new FileStream("bugs.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f);
            for (int i = 0; i < system_bug_list.Count; i++)
            {
                sw.Write(system_bug_list.ElementAt(i).get_bug_id().ToString());
                sw.Write("@");
                sw.Write(system_bug_list.ElementAt(i).get_bug_name());
                sw.Write("@");
                sw.Write(system_bug_list.ElementAt(i).get_bug_level().ToString());
                sw.Write("@");
                sw.Write(system_bug_list.ElementAt(i).get_bug_type().ToString());
                sw.Write("@");
                sw.Write(system_bug_list.ElementAt(i).get_bug_flag_bool().ToString());
                sw.Write("@");
                sw.WriteLine(system_bug_list.ElementAt(i).get_bug_tester());


            }
            sw.Close();
            f.Close();
        }

        /// ////////////////////////////////////load bugs

        public void load_bugs_file()
        {
            system_bug_list.Clear();
            FileStream f = new FileStream("bugs.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);
            while (sr.Peek() != -1)
            {
                string our_temp_str;
                our_temp_str = sr.ReadLine();
                string[] temp = our_temp_str.Split('@');
                bug b = new bug(temp[1], int.Parse(temp[2]), temp[3]);
                b.set_flag(bool.Parse(temp[4]));
                b.set_real_id(int.Parse(temp[0]));
                b.set_bug_tester(temp[5]);
                system_bug_list.Push(b);
            }
            sr.Close();
            f.Close();
        }



        ///////////////////////////////////////////////////////////save developer
        public void save_dev_file()
        {
            
            FileStream f = new FileStream("dev.txt", FileMode.Create);
            
            StreamWriter sw = new StreamWriter(f);
            for (int i = 0; i < developer_box.Count; i++)
            {
                sw.Write(developer_box.ElementAt(i).developer_id_real().ToString());
                sw.Write("@");
                sw.WriteLine(developer_box.ElementAt(i).get_name());
                if (developer_box.ElementAt(i).get_bugs_assign_to_developer().Count == 0)
                {
                    sw.WriteLine(developer_box.ElementAt(i).get_bugs_assign_to_developer().Count.ToString());
                }
                else
                {
                    
                    sw.Write(developer_box.ElementAt(i).get_bugs_assign_to_developer().Count.ToString());
                    sw.Write("@");
                }

                for (int j = 0; j < developer_box.ElementAt(i).get_bugs_assign_to_developer().Count; j++)
                {
                    if (j == (developer_box.ElementAt(i).get_bugs_assign_to_developer().Count) - 1)
                        sw.WriteLine(developer_box.ElementAt(i).get_bugs_assign_to_developer().ElementAt(j).get_bug_id().ToString());
                    else
                    {

                        sw.Write(developer_box.ElementAt(i).get_bugs_assign_to_developer().ElementAt(j).get_bug_id().ToString());
                        sw.Write("@");
                    }
                }
            }
            sw.Close();
            f.Close();
        }

        /// /////////////////////////////////////load developers

        public void load_dev_file()
        {
            developer_box.Clear();
            FileStream f = new FileStream("dev.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);
            while (sr.Peek() != -1)
            {
                string Our_temp_str;
                Our_temp_str = sr.ReadLine();
                string[] temp = Our_temp_str.Split('@');
                if (temp[0] != "" && temp[1] != "")
                {
                    developer d = new developer(temp[1]);
                    d.set_real_id(int.Parse(temp[0]));

                    Our_temp_str = sr.ReadLine();
                    temp = Our_temp_str.Split('@');
                    for (int i = 1; i < int.Parse(temp[0])+1; i++)
                    {
                        d.id_bugs.Push(int.Parse(temp[i]));
                        for(int k=0;k<system_bug_list.Count;k++)
                        {
                            if (system_bug_list.ElementAt(k).get_bug_id() == int.Parse(temp[i]) && system_bug_list.ElementAt(k).get_bug_flag_bool()==true)
                            {
                                d.assign_bug_to_developer(system_bug_list.ElementAt(k));
                                break;
                            }
                        }
                    }
                    developer_box.Push(d);
                }
            }
            sr.Close();
            f.Close();
            if (developer_box.Count != 0)
            {
                compare1 = developer_box.Peek().developer_id_real();
            }
        }
        //////////////////////////////////////////////////save tester
        public void save_tester_file()
        {
            FileStream f = new FileStream("tester.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f);
            for (int i = 0; i < tester_box.Count; i++)
            {
                sw.Write(tester_box.ElementAt(i).tester_real_id().ToString());
                sw.Write("@");
                sw.WriteLine(tester_box.ElementAt(i).get_name());
            }
            sw.Close();
            f.Close();
        }
        //=======================================================load tester
        public void load_tester_file()
        {
            tester_box.Clear();
            FileStream f = new FileStream("tester.txt", FileMode.OpenOrCreate,FileAccess.Read);
            StreamReader sr = new StreamReader(f);
            while (sr.Peek() != -1)
            {
                string Our_temp_str;
                Our_temp_str = sr.ReadLine();
                string[] temp = Our_temp_str.Split('@');
                if(temp[0]!="" &&temp[1]!="" )
                {
                    tester t = new tester(temp[1]);
                t.set_real_id(int.Parse(temp[0]));
                tester_box.Push(t);
                }
                
            }
            sr.Close();
            f.Close();
            if (tester_box.Count != 0)
            {
                compare2 = tester_box.Peek().tester_real_id();
            }
        }
        /// /////////////////////////////////////////////single tone
        private static manager instance;
        private manager() { }
        public static manager get_Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new manager();

                }
                return instance;
            }
        }


        /// ///////////////////////////////////////////get manager name



        public String get_manager_name()
        {
            return manager_name;
        }
        public String get_manager_password()
        {
            return manager_password;
        }
        //////////////////////////////////////////////////////// put new tester

        public void put_new_tester_box(tester t)
        {
            tester_box.Push(t);
        }
        public Stack<tester> get_tester_box()
        {
            return tester_box;
        }


        /// //////////////////////////////////////////// put new developer

        public void put_new_developer_box(developer d)
        {
            developer_box.Push(d);
        }
        public Stack<developer> get_developer_box()
        {
            return developer_box;
        }
        /// //////////////////////////////////////////bug area
        /// 
        //////////////////////////////////////////////////put new bug
        public void put_new_bug_to_system_list(bug b)
        {
            system_bug_list.Push(b);
        }
        ///////////////////////////////////////////////////filter to types
        public void filter_bug_into_types()///ui or business 
        {
            for (int i = 0; i < system_bug_list.Count; i++)
            {
                if (system_bug_list.ElementAt(i).get_bug_type().ToLower() == "ui")
                {
                    UI_stack.Push(system_bug_list.ElementAt(i));
                }
                else
                {
                    Business_stack.Push(system_bug_list.ElementAt(i));
                }
            }
        }
        /// ////////////////////////////////return ui bug

        public Stack<bug> UI_bugs()
        {
            return UI_stack;
        }

        /// ///////////////////////////////return business bug
        public Stack<bug> Business_bugs()
        {
            return Business_stack;
        }
        /// //////////////////////////////////////////////filter into closed and open

        public void filter_into_closed_and_open()
        {
            bug_open.Clear();
            bug_closed.Clear();
            for (int i = 0; i < system_bug_list.Count; i++)
            {
                if (system_bug_list.ElementAt(i).get_bug_flag_bool() == true)
                {
                    bug_open.Push(system_bug_list.ElementAt(i));

                }
                else
                {
                    bug_closed.Push(system_bug_list.ElementAt(i));
                }
            }
        }
        ///////////////////////////////////////////////////////bug closed must call filter first
        public Stack<bug> bug_closed_method()
        {
            return bug_closed;
        }
        //////////////////////////////////////////////////////bug open call filter first
        public Stack<bug> bug_open_method()
        {
            return bug_open;
        }

        /////////////////////////////////////////////////////add bug to developer
      /*  public void add_bug_to_developer(int idd, bug b, String name)
        {
            for (int i = 0; i < developer_box.Count; i++)
            {
                if (developer_box.ElementAt(i).get_name() == name && developer_box.ElementAt(i).developer_id_real() == idd)
                {
                    developer_box.ElementAt(i).assign_bug_to_developer(b);
                    //break;
                }
            }
        }*/
        //////////////////////////////////////////////////////////////////view all bug system
        public Stack<bug> view_all_system_bug_list()
        {
            return system_bug_list;
        }

        ////////////////////////////////////////////////////////
       public Stack<bug> view_bugs_by_developer_name_id(String name, int id)// call first closed and open stack to view only open stack
        {
            for (int i = 0; i < developer_box.Count; i++)
            {
                if ((developer_box.ElementAt(i).developer_id_real() == id) && (developer_box.ElementAt(i).get_name() == name))
                {
                    temp_stack = developer_box.ElementAt(i).get_bugs_assign_to_developer();
                    break;
                }
            }
            return temp_stack;
        }
        //////////////////////////////////////////////////////sort bugs
        public Stack<bug> arrange_sort()
        {
            bug[] b;
            bug temp;
            b = system_bug_list.ToArray();
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[i].get_bug_level() > b[j].get_bug_level())
                    {
                        temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                        b[i].change_id(b[i].get_bug_id() - 1);
                    }
                }
            }
            //system_bug_list.Clear();
            for (int i = 0; i < b.Length; i++)
            {
                // system_bug_list.Push(b[i]);
                sorted_stack.Push(b[i]);
            }

            return sorted_stack;
        }
        ////////////////////////////////////////////////close bug by developer
        public void close_bug_by_developer(String idd)
        {
            int temp_id = int.Parse(idd);
            for (int i = 0; i < system_bug_list.Count; i++)
            {
                if (system_bug_list.ElementAt(i).get_bug_id() == temp_id)
                {
                    system_bug_list.ElementAt(i).set_flag_closed();
                    break;
                }
            }
        }
        /////////////////////////////////////////////////////// assign bug to developer
        public String[] assign_bug_to_developer(String bug_idd, String deve_id)
        {
            bug temp = new bug();
            String[] namess = new String[2];
            for (int i = 0; i < system_bug_list.Count; i++)
            {
                if (system_bug_list.ElementAt(i).get_bug_id().ToString() == bug_idd)
                {
                    temp = system_bug_list.ElementAt(i);
                    namess[0] = system_bug_list.ElementAt(i).get_bug_name();
                    temp.reduce_id();
                    break;
                }
            }
            for (int i = 0; i < developer_box.Count; i++)
            {
                if (developer_box.ElementAt(i).developer_id_real().ToString() == deve_id)
                {
                    developer_box.ElementAt(i).assign_bug_to_developer(temp);
               
                    namess[1] = developer_box.ElementAt(i).get_name();
                    break;
                }
            }
            return namess;
        }
        ////////////////////////////////////============================compare function
        public void compare_id()
        {
            if (developer_box.Count != 0 || tester_box.Count != 0)
            {

                if (compare1 > compare2)
                {
                    human.id = compare1+1;
                }
                else
                    human.id = compare2+1;
            }

        }
        /////////////////////////////////////============================

            
    }
 }


