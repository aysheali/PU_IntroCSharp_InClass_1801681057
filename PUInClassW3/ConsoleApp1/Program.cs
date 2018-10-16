using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("Playing music.....!!!");

                using (SoundPlayer player = new SoundPlayer(@"C:\Users\fmi\Desktop\week3\music\Mahmut_Orhan_Colonel_Bagshot_-_6_Days_Official_Video_Ultra_Music-1W5BA0lDVLM.wma"))
                {
                    // Use PlaySync to load and then play the sound.
                    // ... The program will pause until the sound is complete.
                    player.PlaySync();
                }

                }
            else if (answer == "no")
            {
                Console.WriteLine("Goodbye!");
            } 

            else
            {
                Console.WriteLine("Wrong input!");
            }


            //Console.WriteLine("Hello Ayshe");
        }
    }
}
