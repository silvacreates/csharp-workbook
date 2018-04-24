using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LinqExercises
{
    class Program
    {   // Part of Exercise #4 Code
        static IEnumerable<int> Range(int start, int end, int step = 1)
        {
            while (start <= end)
            {
                yield return start;
                start += step;
            }
        }
        //End of Exercise #4 Code snippet

        static void Main()

        {
            // Exercise #1
            //string names = "Davis,Clyne,Fonte,Hooiveld,Shaw,Davis,Schneiderlin,Cork,Lallana,Rodriguez,Lambert";
            //int i = 1;

            ////    Traditional Linq expression
            ////    var query = from name in names.Split(',')
            ////                select string.Format(" {0}. {1},", i++, name);


            ////    Linq extension "Select" Method
            //var players = names.Split(',').Select(name => string.Format("{0}. {1}, ", i++, name));
            //players.ToList().ForEach(Console.Write);
            //Console.ReadKey();

            //Exercise #2
            //        string players = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";

            //        var output = from player in players.Split(';')
            //                     let splitted = player.Split(',')
            //                     let date = DateTime.ParseExact(splitted[1].Trim(), "dd/mm/yyyy", CultureInfo.InvariantCulture)
            //                     select new Person
            //                     {
            //                         name = splitted[0],
            //                         birthdate = splitted[1],
            //                         age = new DateTime((DateTime.Now - date).Ticks).Year
            //                     };

            //        output.ToList().ForEach(Console.Write);
            //        Console.ReadLine();
            //    }
            //}
            //class Person
            //{
            //    public string name;
            //    public string birthdate;
            //    public int age;

            //Exercise 3
            /* #3
Take the following string "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27" which represents the durations of songs in 
minutes and seconds, and calculate the total duration of the whole album
*/

            //string durations = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";

            //var output = durations.Split(',').Select(d => TimeSpan.Parse(String.Format("0:{0}", d)).TotalSeconds);
            ////a better way is to use ParseExact but this is in next.NET
            ////select TimeSpan.ParseExact(d, "m\\:ss", CultureInfo.InvariantCulture).TotalSeconds;



            //Console.WriteLine(TimeSpan.FromSeconds(output.Sum()));
            //Console.ReadKey();


            //Exercise 4
            /*       Create an enumerable sequence of strings in the form "x,y" representing all the points on a 3x3 grid. 
       e.g.output would be: 0,0 0,1 0,2 1,0 1,1 1,2 2,0 2,1 2,2
       */

            var output = from x in Range(0, 2)
                         select from y in Range(0, 2)
                                select String.Format("{0}, {1}", x, y);
            output.ToList().ForEach(l => l.ToList().ForEach(Console.WriteLine));
            Console.ReadKey();
            /* #5
Take the following string "00:45,01:32,02:18,03:01,03:44,04:31,05:19,06:01,06:47,07:35" which represents the times 
(in minutes and seconds) at which a swimmer completed each of 10 lengths. Turn this into an enumerable of timespan 
objects containing the time taken to swim each length (e.g. first length was 45 seconds, second was 47 seconds etc)


            static void Main(string[] args)
            {
                string times = "00:45,01:32,02:18,03:01,03:44,04:31,05:19,06:01,06:47,07:35";

                var output = from time in times.Split(',')
                                 //like before.. better to use exact ;-]
                             select TimeSpan.Parse(String.Format("0:{0}", time));

                //just to show sth :-)
                output.Select(t => t.ToString()).ToList().ForEach(Console.WriteLine);

                Console.ReadKey();
            }

            Exercise #6
            Take the following string "2,5,7-10,11,17-18" and turn it into an IEnumerable of integers: 2 5 7 8 9 10 11 17 18
            
            static IEnumerable<int> Range(int start, int end, int step = 1)
            {
                while (start <= end)
                {
                    yield return start;
                    start += step;
                }
            }

            static void Main(string[] args)
            {
                string str = "2,5,7-10,11,17-18";

                var output = from n in str.Split(',')
                             let splitted = n.Split('-')
                             let start = int.Parse(splitted[0])
                             let end = int.Parse(splitted.Last())
                             select Range(start, end, 1);

                foreach (var it in output)
                    foreach (var i in it)
                        Console.WriteLine(i);
            }
            */
        }
    }
}