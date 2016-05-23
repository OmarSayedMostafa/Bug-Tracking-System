using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ya_mosahel
{

    public class tester : human
    {
        private int real_id;
        public tester() : base() 
        {
            real_id = id;
        }
       
         //======================================
        public void set_real_id(int x)
        {
            this.real_id = x;
        }

        /// /////////////////////////////////constructor with paramters
        

        public tester(String name)
        {
            this.name = name;
            real_id = id;
        }
       

        /// //////////////////////////////////////
       

      /*  public override void set_name(string name)
        {
            this.name = name;
        }
        */

        /// ////////////////////////////////////////
     
      /// ////////////////////////////////
      

        public int tester_real_id()
        {
            return real_id;
        }
       

        /// ////////////////////////////////////////
       

        public override string get_name()
        {
            return name;
        }

        public int get_id()
        {
            return id;
        }
    }
}
