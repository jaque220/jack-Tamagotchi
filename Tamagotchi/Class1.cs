using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Punisher
    {
        private string name = "N/A";
        private string profile = "N/A";
        private int ammoRounds = 0;
        private int happy = 0;

        public Punisher(string n, string pro, int ar, int h)
        {
            name = n;
            profile = pro;
            ammoRounds = ar;
            happy = h;
        }
        public string getName()
        {
            return name;
        }
        public string getProfile()
        {
            return profile;
        }
        public int getAmmoRounds()
        {
            return ammoRounds;
        }
        public int getHappy()
        {
            return happy;
        }
        public int reload()
        {
            ammoRounds = ammoRounds + 1;
            return ammoRounds;
        }
        public int punishment()
        {
            happy = happy + 1;
            return happy;
        }
        public void dostuff()
        {
            Random rnd = new Random();
            happy = happy - rnd.Next(0, 12);
            ammoRounds = ammoRounds - rnd.Next(10);
            Console.WriteLine(happy);
            Console.WriteLine(ammoRounds);
           
        }
    }
}