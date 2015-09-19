using System;

namespace DriversLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            string State = "";
            bool repeat = true;
            string convertedName = "";
            while (repeat)
            {
                Console.WriteLine("What is your state? (IL/WI/FL)");
                State = Console.ReadLine();

                Console.WriteLine("What is your first name?");
                string firstname = Console.ReadLine();
                string firstinitial = firstname.Substring(0, 1);
                Console.WriteLine("What is your middle initial?");
                string middleinitial = Console.ReadLine();

                convertedName = FirstName.NameConvert(State, firstname, firstinitial, middleinitial);
                if (State == "IL") License.Illinois = License.Illinois.Replace("CCC", convertedName);
                else if (State == "WI") License.Wisconsin = License.Wisconsin.Replace("CCC", convertedName);
                else if (State == "FL") License.Florida = License.Florida.Replace("CCC", convertedName);

                Console.WriteLine("What is your last name?");
                string LastName = Console.ReadLine();
                LastName = Soundex.Compute(LastName);
                if (State == "IL") License.Illinois = License.Illinois.Replace("BBBB", LastName);
                else if (State == "FL") License.Florida = License.Florida.Replace("BBBB", LastName);
                else if (State == "WI") License.Wisconsin = License.Wisconsin.Replace("BBBB", LastName);


                Console.WriteLine("What is your birthdate? (MM/DD/YYYY)(include all zeros and slashes)");
                bool birthunident = true;
                string Birthday = "";
                while (birthunident)
                {
                    Birthday = Console.ReadLine();
                    if (Birthday.Length < 10 || Birthday.Length > 10)
                    {
                        Console.WriteLine("You did not enter a valid birthday. Please type it again. ");
                        birthunident = true;
                    }
                    else birthunident = false;

                }
                string X = Birthday.Substring(8, 1);
                string Y = Birthday.Substring(9, 1);
                if (State == "IL")
                {
                    License.Illinois = License.Illinois.Replace("X", X);
                    License.Illinois = License.Illinois.Replace("Y", Y);
                }
                else if (State == "WI")
                {
                    License.Wisconsin = License.Wisconsin.Replace("X", X);
                    License.Wisconsin = License.Wisconsin.Replace("Y", Y);
                }
                else if (State == "FL")
                {
                    License.Florida = License.Florida.Replace("X", X);
                    License.Florida = License.Florida.Replace("Y", Y);
                }
                string birth_month = Birthday.Substring(0, 2);
                string birth_day = Birthday.Substring(3, 2);

                Console.WriteLine("What is your gender? Male/Female");
                bool genunident = true;
                int il_gender = 0;
                int fl_gender = 0;
                int wi_gender = 0;
                while (genunident)
                {
                    var Gender = Console.ReadLine();
                    if (State == "IL")
                    {
                        switch (Gender)
                        {
                            case "Male":
                                il_gender = 0;
                                genunident = false;
                                break;
                            case "Female":
                                il_gender = 600;
                                genunident = false;
                                break;
                            default:
                                Console.WriteLine("Your gender was not valid. Please type it again.");
                                genunident = true;
                                break;
                        }
                    }
                    else if (State == "WI")
                    {
                        switch (Gender)
                        {
                            case "Male":
                                wi_gender = 0;
                                genunident = false;
                                break;
                            case "Female":
                                wi_gender = 500;
                                genunident = false;
                                break;
                            default:
                                Console.WriteLine("Your gender was not valid. Please type it again.");
                                genunident = true;
                                break;
                        }
                    }
                    else if (State == "FL")
                    {
                        switch (Gender)
                        {
                            case "Male":
                                fl_gender = 0;
                                genunident = false;
                                break;
                            case "Female":
                                fl_gender = 500;
                                genunident = false;
                                break;
                            default:
                                Console.WriteLine("Your gender was not valid. Please type it again.");
                                genunident = true;
                                break;
                        }
                    }
                }
                int birthMonth = Convert.ToInt32(birth_month);
                int birthDay = Convert.ToInt32(birth_day);

                int il_birth_equ = (birthMonth - 1) * 31 + birthDay + il_gender;
                int fl_birth_equ = (birthMonth - 1) * 40 + birthDay + fl_gender;
                int wi_birth_equ = (birthMonth - 1) * 40 + birthDay + wi_gender;
                string birthEquIL = il_birth_equ.ToString();
                string birthEquWI = wi_birth_equ.ToString();
                string birthEquFL = fl_birth_equ.ToString();

                if (birthEquIL.Length < 3) birthEquIL = birthEquIL.PadLeft(3, '0');
                if (birthEquWI.Length < 3) birthEquWI = birthEquWI.PadLeft(3, '0');
                if (birthEquFL.Length < 3) birthEquFL = birthEquFL.PadLeft(3, '0');

                if (State == "IL")
                {
                    License.Illinois = License.Illinois.Replace("EEE", birthEquIL);
                    Console.WriteLine("Your Illinois license number is " + License.Illinois);
                }
                else if (State == "FL")
                {
                    License.Florida = License.Florida.Replace("EEE", birthEquFL);
                    Console.WriteLine("Your Florida license number is " + License.Florida + ". The overflow (the ? at the end) can not be determined.");
                }
                else if (State == "WI")
                {
                    License.Wisconsin = License.Wisconsin.Replace("EEE", birthEquWI);
                    Console.WriteLine("Your Wisconsin license number is " + License.Wisconsin + ". The overflow (the ?? at the end) can not be determined.");
                }


                Console.WriteLine("Try again? y/n");
                bool unident = true;
                while (unident)
                {
                    string Again = Console.ReadLine();
                    if (Again == "y")
                    {
                        unident = false;
                        repeat = true;
                        License.Illinois = "BBBB-CCCX-YEEE";
                        License.Wisconsin = "BBBB-CCCX-YEEE-??";
                        License.Florida = "BBBB-CCC-XY-EEE-?";
                    }
                    else if (Again == "n")
                    {
                        unident = false;
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter 'y' or 'n'. Please type your choice in again.");
                        unident = true;
                    }
                }
            }
        }
    }

    public static class License
    {
        public static string Illinois = "BBBB-CCCX-YEEE";
        public static string Wisconsin = "BBBB-CCCX-YEEE-??";
        public static string Florida = "BBBB-CCC-XY-EEE-?";
    }
}