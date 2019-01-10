using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000cSharpPractice
{
    class city_zip_using_call_method
    {
                            static void Main(String[] args)
            {

                Console.WriteLine("Enter any zip codes from the followig {92688, 92669, 92667, 92666}");
                Console.WriteLine("Please enter ZipCode:");

                //get the user input
                var number = Console.ReadLine();


                if (number.Length != 5)
                {


                    Console.WriteLine("Invalid format!");

                }
                else
                {
                    DisplayZipCode(number); // Call Method 


                }


                Console.ReadLine();
            }


            //Implement the Call Method
            private static void DisplayZipCode(string value)

            {

                string[] cityNames = { "RSM", "Lake Forest", "Irvine", "Bake Parkway" };


                var n = Convert.ToInt32(value);

                if (n == 92688)
                {
                    Console.WriteLine(cityNames[0]);
                    Console.ReadLine();
                    return;
                }
                if (n == 92669)
                {
                    Console.WriteLine(cityNames[1]);
                    Console.ReadLine();
                    return;

                }
                if (n == 92667)
                {
                    Console.WriteLine(cityNames[2]);
                    Console.ReadLine();
                    return;

                }
                if (n == 92666)
                {
                    Console.WriteLine(cityNames[3]);
                    Console.ReadLine();
                    return;

                }

                else
                {
                    Console.WriteLine("Invalid Zip code!");

                    Console.ReadLine();
                    return;
                }
            }

        }


    }




