using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DriversLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            string lic_temp = "BBBB-CCCX-YEEE";

            Console.WriteLine("What is your last name?");
            string A = Console.ReadLine();
            A = Soundex.Compute(A);
            
            lic_temp = lic_temp.Replace("BBBB", A);

            Console.WriteLine("What is your first name?");
            string C = Console.ReadLine();
            string Cc = C.Substring(0, 1);
            int first_init = 0;
            int middle_init = 0;

            switch (C)
            {
                case "Albert":
                    first_init = 20;  
                    break;
                case "Alice":
                    first_init = 20;
                    break;
                case "Ann":
                    first_init = 40;
                    break;
                case "Anna":
                    first_init = 40;
                    break;
                case "Anne":
                    first_init = 40;
                    break;
                case "Annie":
                    first_init = 40;
                    break;
                case "Arthur":
                    first_init = 40;
                    break;
                case "Bernard":
                    first_init = 80;
                    break;
                case "Bette":
                    first_init = 80;
                    break;
                case "Bettie":
                    first_init = 80;
                    break;
                case "Betty":
                    first_init = 80;
                    break;
                case "Carl":
                    first_init = 120;
                    break;
                case "Catherine":
                    first_init = 120;
                    break;
                case "Charles":
                    first_init = 140;
                    break;
                case "Dorthy":
                    first_init = 180;
                    break;
                case "Edward":
                    first_init = 220;
                    break;
                case "Elizabeth":
                    first_init = 220;
                    break;
                case "Florence":
                    first_init = 260;
                    break;
                case "Donald":
                    first_init = 180;
                    break;
                case "Clara":
                    first_init = 140;
                    break;
                case "Frank":
                    first_init = 260;
                    break;
                case "George":
                    first_init = 300;
                    break;
                case "Grace":
                    first_init = 300;
                    break;
                case "Harold":
                    first_init = 340;
                    break;
                case "Harriet":
                    first_init = 340;
                    break;
                case "Harry":
                    first_init = 360;
                    break;
                case "Hazel":
                    first_init = 360;
                    break;
                case "Helen":
                    first_init = 380;
                    break;
                case "Henry":
                    first_init = 380;
                    break;
                case "James":
                    first_init = 440;
                    break;
                case "Jane":
                    first_init = 440;
                    break;
                case "Jayne":
                    first_init = 440;
                    break;
                case "Jean":
                    first_init = 460;
                    break;
                case "John":
                    first_init = 460;
                    break;
                case "Joan":
                    first_init = 480;
                    break;
                case "Joseph":
                    first_init = 480;
                    break;
                case "Margaret":
                    first_init = 560;
                    break;
                case "Martin":
                    first_init = 560;
                    break;
                case "Marvin":
                    first_init = 580;
                    break;
                case "Mary":
                    first_init = 580;
                    break;
                case "Melvin":
                    first_init = 600;
                    break;
                case "Mildred":
                    first_init = 600;
                    break;
                case "Patricia":
                    first_init = 680;
                    break;
                case "Paul":
                    first_init = 680;
                    break;
                case "Richard":
                    first_init = 740;
                    break;
                case "Ruby":
                    first_init = 740;
                    break;
                case "Ruth":
                    first_init = 760;
                    break;
                case "Thelma":
                    first_init = 820;
                    break;
                case "Thomas":
                    first_init = 820;
                    break;
                case "Walter":
                    first_init = 900;
                    break;
                case "Wanda":
                    first_init = 900;
                    break;
                case "William":
                    first_init = 920;
                    break;
                case "Wilma":
                    first_init = 920;
                    break;
                default:
                    switch (Cc)
                    {
                        case "A":
                            first_init = 0;
                            break;
                        case "B":
                            first_init = 60;
                            break;
                        case "C":
                            first_init = 100;
                            break;
                        case "D":
                            first_init = 160;
                            break;
                        case "E":
                            first_init = 200;
                            break;
                        case "F":
                            first_init = 240;
                            break;
                        case "G":
                            first_init = 280;
                            break;
                        case "H":
                            first_init = 320;
                            break;
                        case "I":
                            first_init = 400;
                            break;
                        case "J":
                            first_init = 420;
                            break;
                        case "K":
                            first_init = 500;
                            break;
                        case "L":
                            first_init = 520;
                            break;
                        case "M":
                            first_init = 540;
                            break;
                        case "N":
                            first_init = 620;
                            break;
                        case "O":
                            first_init = 640;
                            break;
                        case "P":
                            first_init = 660;
                            break;
                        case "Q":
                            first_init = 700;
                            break;
                        case "R":
                            first_init = 720;
                            break;
                        case "S":
                            first_init = 780;
                            break;
                        case "T":
                            first_init = 800;
                            break;
                        case "U":
                            first_init = 840;
                            break;
                        case "V":
                            first_init = 860;
                            break;
                        case "W":
                            first_init = 880;
                            break;
                        case "X":
                            first_init = 940;
                            break;
                        case "Y":
                            first_init = 960;
                            break;
                        case "Z":
                            first_init = 980;
                            break;
                        default:
                            Console.WriteLine("You did not enter a valid initial.");
                            break;
                    }
                    break;
            }

            Console.WriteLine("What is your middle initial?");
            string c = Console.ReadLine();
            switch (c)
            {
                case "A":
                    middle_init = 1;
                    break;
                case "B":
                    middle_init = 2;
                    break;
                case "C":
                    middle_init = 3;
                    break;
                case "D":
                    middle_init = 4;
                    break;
                case "E":
                    middle_init = 5;
                    break;
                case "F":
                    middle_init = 6;
                    break;
                case "G":
                    middle_init = 7;
                    break;
                case "H":
                    middle_init = 8;
                    break;
                case "I":
                    middle_init = 9;
                    break;
                case "J":
                    middle_init = 10;
                    break;
                case "K":
                    middle_init = 11;
                    break;
                case "L":
                    middle_init = 12;
                    break;
                case "M":
                    middle_init = 13;
                    break;
                case "N":
                    middle_init = 14;
                    break;
                case "O":
                    middle_init = 14;
                    break;
                case "P":
                    middle_init = 15;
                    break;
                case "Q":
                    middle_init = 15;
                    break;
                case "R":
                    middle_init = 16;
                    break;
                case "S":
                    middle_init = 17;
                    break;
                case "T":
                    middle_init = 18;
                    break;
                case "U":
                    middle_init = 18;
                    break;
                case "V":
                    middle_init = 18;
                    break;
                case "W":
                    middle_init = 19;
                    break;
                case "X":
                    middle_init = 19;
                    break;
                case "Y":
                    middle_init = 19;
                    break;
                case "Z":
                    middle_init = 19;
                    break;
            }


            int cccc = first_init + middle_init;
            string CCCC = cccc.ToString();
            if (CCCC.Length < 5) CCCC = CCCC.PadLeft(3, '0');
            lic_temp = lic_temp.Replace("CCC", CCCC);

            Console.WriteLine("What is your birthdate? (MM/DD/YYYY)(include all zeros");
            string D = Console.ReadLine();

            string X = D.Substring(8, 1);
            string Y = D.Substring(9, 1);
            lic_temp = lic_temp.Replace("X", X);
            lic_temp = lic_temp.Replace("Y", Y);

            string birth_month = D.Substring(0, 2);
            string birth_day = D.Substring(3, 2);

            Console.WriteLine("What is your gender?");
            var G = Console.ReadLine();

            int gender = 0;

            switch (G)
            {
                case "Male":
                    gender = 0;
                    break;
                case "Female":
                    gender = 600;
                    break;
                default:
                    Console.WriteLine("Your gender was not valid.");
                    break;
            }

            int birthMonth = Convert.ToInt32(birth_month);
            int birthDay = Convert.ToInt32(birth_day);

            int birth_equ = (birthMonth - 1) * 31 + birthDay + gender;

            string birthEqu = birth_equ.ToString();

            if (birthEqu.Length < 3) birthEqu = birthEqu.PadLeft(3, '0');

            lic_temp = lic_temp.Replace("EEE", birthEqu);
            //Illinois: (birth_month - 1) * 31 + birth_day + (male:0, female: 600)

            Console.WriteLine("Your Illinois license number is " + lic_temp);
            Console.ReadLine();

        }
    }
}
