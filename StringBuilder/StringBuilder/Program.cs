using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Shahane Vardazaryan";
            string usg = msg.Replace("Shahane", "Anahit");
            WriteLine("oldstring={0}", msg);
            WriteLine("newstring={0}", usg);


            string msg1 = "Welcome to";

            string msg2 = " " + "tutlane";

            Console.WriteLine("Message: {0}", string.Concat(msg1, msg2));



            string name1 = "Suresh";

            string name2 = ", " + "Rohini";

            string name3 = ", " + "Trishika";

            Console.WriteLine("Users: {0}", string.Concat(string.Concat(name1, name2), name3));



            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();
            string gsg = "Welcome to Tutlane";

            string subtxt = "Tutlane";

            Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt, msg.Contains(subtxt));

            string subtxt1 = "tutlane";

            StringComparison comp = StringComparison.OrdinalIgnoreCase;

            bool result = msg.IndexOf(subtxt1, comp) > 0 ? true : false;

            Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt1, result);

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

            string dsg= "ShahaneVardazaryan";
            WriteLine(dsg.Substring(7,5));

            string ssh = "Shahane";
            string gh = "Garik";
            WriteLine(string.Compare(ssh, gh));

            string s = "Name:{0} {1}, Location:{2}, Age:{3}";

            string sg = string.Format(s, "Suresh", "Dasari", "Hyderabad", 32);

            Console.WriteLine("Format Result: {0}", sg);


        }
    }
}
