using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ya_mosahel
{
    public class bug
    {
        private string name;
        private int level;//c->crtical;h->high;m->mediam;l->low;
        private String type;//b->business;g->GUI;
        private bool flag = true;// true for open or false for close
        private String temp_level;
        // private DateTime x;
        String tester_name;
        private int real_id;
        static public int bug_id = 0;
        public bug()
        {
            flag = true;
            // System.DateTime x = new DateTime();
             bug_id++;
             real_id = bug_id++;
        }


        /// ///////////////////////////////////////////////constructor with pArameters
        public void change_id(int id)
        {
            bug_id = id;
        }

        public bug(String name, int level, String type)
        {
            this.name = name;
            this.level = level;
            this.type = type.ToLower();
            bug_id++;
            real_id = bug_id;
        }


        /// ///////////////////////////////////////////////


        public int get_bug_id()
        {
            return real_id;

        }


        /// //////////////////////////////////////////set name of tester


        public void set_bug_tester(String s)
        {
            tester_name = s;
        }


        /// /////////////////////////////////////// get name of tester


        public String get_bug_tester()
        {
            return tester_name;
        }


        /// ////////////////////////////////////// set bug name


        public void set_bug_name(string name)
        {
            this.name = name;
        }


        /// ////////////////////////////////////////get bug level "string"


        public String get_bug_level_string()
        {

            if (level == 0)
                temp_level = "low";
            else if (level == 1)
                temp_level = "midium";
            else if (level == 2)
                temp_level = "high";
            else
                temp_level = "critical";
            return temp_level;
        }

        //////////////////////////////////////// set bug type

        public void set_bug_type(String type)
        {
            this.type = type;
        }


        /// /////////////////////////////////////////change flag to closed


        public void set_flag_closed()
        {
            this.flag = false;
            
        }


        /// ///////////////////////////////////////// get bug name


        public string get_bug_name()
        {
            return name;
        }


        /// /////////////////////////////////////// get bug level (int )


        public int get_bug_level()
        {
            return level;
        }


        /// ///////////////////////////////////////////////get bug type "UI/BUSINess"


        public String get_bug_type()
        {
            return type;
        }


        /// //////////////////////////////////////////////////flag to string


        public String get_bug_flag_string()
        {
            String temp;
            if (flag == true)
            {
                temp = "OPEN";
            }
            else
            {
                temp = "closed";
            }
            return temp;
        }


        /// ///////////////////////////////flag bool


        public bool get_bug_flag_bool()
        {
            return flag;
        }
        //////////////////////////////////////
        public void reduce_id()
        {
            bug_id--;
        }
        ////////////////////////////////////////////
        /////////////////////////////////////////////////+2 func doski
        public void set_flag(bool x)
        {
            this.flag = x;
        }
        public void set_real_id(int x)
        {
            this.real_id = x;
        }
    }
}
