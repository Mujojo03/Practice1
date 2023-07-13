using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Student
    {
        public virtual void ShowData()
        {
            Console.WriteLine("Showing student data");
        }     
    }
    public class Child:Student
    {
        public override void ShowData()
        {
            Console.WriteLine("Showing Child Data");
        }
    }
}
