using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ya_mosahel
{
    public abstract class human
    {
        static public int id = 0;
        protected string name;

        public human()
        {
            id++;
        }
     //   public abstract void set_name(string name);
        public abstract string get_name();
       

    }

}
