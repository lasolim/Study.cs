using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "[1,2,3],[4,5,6],[7,8,9]";
            StrToVector(str);
            Console.ReadLine();
        }

        static void StrToVector(string str)
        {
            
            string[] joints = str.Split(']');

            for (int i = 0; i < joints.Length; i++)
            {
                //joints[i].Trim('[');

                //Console.WriteLine(joints[i].Trim('[').Trim(',').Trim('['));

                string[] component = joints[i].Trim('[').Trim(',').Trim('[').Split(',');

                for (int j = 0; j < component.Length; j++)
                {
                    if (Int32.TryParse(component[j], out int a))
                        Console.WriteLine(a);
                    else
                        Console.WriteLine("String could not be parsed. //" + component[j] + "//" + j);
                }

            }
        }
    }
}
