using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    internal class HumanProperty
    {
        
        public string Isim { get; set; } = "Gökçe Betül";
        public string Soyisim { get; set; } = "ÇAKMAK";
        public int Boy { get; set; } = 164;
        public int Kilo { get; set; } = 48;
        public int Yas { get; set; } = 26;


        public void Tanis()
        {
            Console.WriteLine("Ben {0} {1}, {2}cm boyundayım,{3} kiloyum, Yaşım {4}.", Isim, Soyisim, Boy, Kilo, Yas);

        }
    }

    



    

}
