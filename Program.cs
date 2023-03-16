using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_TASK_1 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter number of scripts");
            string sScripts = Console.ReadLine();
            int scripts = Convert.ToInt32(sScripts);            ;

            Console.WriteLine("Enter number of questions");
            string sQuestions = Console.ReadLine();
            int questions = Convert.ToInt32(sQuestions);

            int[] sub = new int[questions];
            for (int i = 0; i < questions; i++) {
                Console.WriteLine("Enter sub total for question: " + (i + 1));
                sub[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter number of lecturers");
            string sLecturers = Console.ReadLine();
            int lecturers = Convert.ToInt32(sLecturers);

            int scriptsPerLec = scripts / lecturers;

            int minutes = 0, seconds = 0;
            for (int i = 0; i < questions; i++) {
                for (int j = 0; j < sub[i]; j++) {
                    seconds += 2;
                    if (seconds == 60) {
                        minutes++;
                        seconds = 0;
                    }
                }
            }

            if (seconds >= 30) {
                minutes++;
            }

            int totalMinutes = minutes * scriptsPerLec;
            int hours = 0;
            bool notHour = false;
            while (!notHour) {
                if (totalMinutes >= 60) {
                    hours++;
                    totalMinutes -= 60;
                } else {
                    notHour = true;
                }
            }

            Console.WriteLine("It will take each lecturer " + hours + " hours and " + totalMinutes + " minutes to mark " + scriptsPerLec + " Scripts");
            Console.ReadKey();
        }
    }
} 
