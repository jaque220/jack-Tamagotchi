using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Punisher p1 = new Punisher("Frank Castle", "Killer", 100, 100);
            Console.WriteLine("Name: {0}, Profile: {1}, ammoRounds: {2}, Happy: {3}", p1.getName(), p1.getProfile(), p1.getAmmoRounds(), p1.getHappy());
            while (p1.getAmmoRounds() > 0 && p1.getHappy() > 0)
            {
                Console.WriteLine("Give me food or attention or....YOU WILL DIE!!");
                string action = Console.ReadLine();
                if (action == "reload")
                {
                    p1.reload();
                    Console.WriteLine("I'm kinda, sorta, hungry...FEED ME FOOD! GOOD STUFF! NOWWWWWW!!!!! RAWRRRRR!!");
                }
               
                else if (action == "punishment")
                {
                    p1.punishment();
                    Console.WriteLine("Good job, i'll leave your tombstone blank.....for now.");

                }
                else
                {
                    Console.WriteLine("*gunshots fire rapidly*");
                }
                p1.dostuff();
                    Console.WriteLine("Punisher's ammo is {0} and happiness is {1}", p1.getAmmoRounds(), p1.getHappy());
                if (p1.getAmmoRounds() <= 0 || p1.getHappy() <= 0)
                {
                    Console.WriteLine("Here Lies Frank Castle");
                }
                
                    
            }
        }
    }   
} 