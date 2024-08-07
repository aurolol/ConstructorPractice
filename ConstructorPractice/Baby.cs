using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPractice
{
    public class Baby
    {
        public DateTime _birthDate { get; set; }
        public string _name { get; set; }
        public string _surName { get; set; }

        public Baby()
        {
            Console.WriteLine("Ingaaaaaaaaa!");
            _birthDate = DateTime.Now;
        }

        public Baby(string name, string surName)
        {
            Console.WriteLine("Ingaaaaaaaaaa!");
            _birthDate = DateTime.Now;
            _name = name;
            _surName = surName;
            
        }
        public void WelcomeWorld()
        {
            Console.WriteLine($"Bebeğin adı: {_name} \nSoyadı: {_surName} \nDoğum tarihi: {_birthDate}");
        }
    }
}
