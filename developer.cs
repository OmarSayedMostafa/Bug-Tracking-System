using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ya_mosahel
{
    public class developer : human
    {
        private Stack<bug> developer_bug = new Stack<bug>();//+2
        private Stack<bug> developer_bug_closed = new Stack<bug>();
        private Stack<bug> UI_stack = new Stack<bug>();
        private Stack<bug> temp_stack = new Stack<bug>();
        private Stack<bug>open_bug = new Stack<bug>();
        private Stack<bug> Business_stack = new Stack<bug>();
        private int real_id;
        public Stack<int> id_bugs = new Stack<int>();
         public developer() : base() 
        {
            real_id = id;
        }
        //===========================================
        public developer(String name)
        {
            this.name = name;
            real_id = id;
        }
        //---------------------------------------------------------------
         public int get_id()
        {
            return id;
        }
        /// //////////////////////////////////////////set real id
        /// 
        public void set_real_id(int x)
        {
            this.real_id = x;
        }
        /// ///////////////////////////////////////////
         
        public int developer_id_real()//real_id
        {
            return real_id;
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////
        /// 
        public void change_flag_closed(bug b)
        {
            b.set_flag_closed();
        }
        


        /// /////////////////////////////
       


        public void assign_bug_to_developer(bug b)
        {
            developer_bug.Push(b);
            id_bugs.Push(b.get_bug_id());
        }

        /// ///////////////////////////////
        public Stack<bug> arrange()
        {
            bug[] b;
            bug temp;
            b = developer_bug.ToArray();
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[i].get_bug_level() > b[j].get_bug_level())
                    {
                        temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                    }
                }
            }
            developer_bug.Clear();
            for (int i = 0; i < b.Length; i++)
            {
                developer_bug.Push(b[i]);
            }
            return developer_bug;
        }
        /////////////////////////////////////

        public void divide_into_types()///ui or business 
        {
            for (int i = 0; i < developer_bug.Count; i++)
            {
                if (developer_bug.ElementAt(i).get_bug_type().ToLower() == "ui")
                {
                    UI_stack.Push(developer_bug.ElementAt(i));
                }
                else
                {
                    Business_stack.Push(developer_bug.ElementAt(i));
                }
            }
        }
        /// ////////////////////////////////

        public Stack<bug> UI_bugs()
        {
            
            return UI_stack;
        }

        /// ///////////////////////////////
        public Stack<bug> Business_bugs()
        {
         
            return Business_stack;
            
        }

        /// ////////////////////////////

        public Stack<bug> get_bugs_assign_to_developer()
        {
                return developer_bug;
        }
        
        /// //////////////////////////////////////
        
    /*    public override void set_name(string name)
        {
            this.name = name;
        }*/
        ////////////////////////////////////////////
    
        ///////////////////////////////////////
        public Stack<bug> closed_bug()
        {
            return developer_bug_closed;
        }
        /// /////////////////////////////////////

        public override string get_name()
        {
            return name;
        }
        //////////////////////////////////////////close bug
        public void close_bug_by_developer(String idd)
        {
            int temp_id = int.Parse(idd);
            for(int i=0;i<developer_bug.Count;i++)
            {
                if(developer_bug.ElementAt(i).get_bug_id()==temp_id)
                {
                    developer_bug.ElementAt(i).set_flag_closed();
                    break;
                }
            }
        }
      
    }

}
