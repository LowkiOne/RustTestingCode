using System.Linq;
using System.IO;
using System.Globalization;
using TestingToDelete;

namespace Testing
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public Person(string name, string lastname, string number) 
        {
            FirstName = name;
            LastName = lastname;
            Title = number;
        }
        public Person() { }
    }

    public class AmountSet
    {
        public int Amount { get; set; }
       
        public AmountSet(int amount) 
        {
            Amount = amount;
        }
        public void Gethere(int amount)
        {
            Amount = amount;
        }
    }
    public class Functions
    {
        List<AmountSet> amountset = new List<AmountSet>
        {
            new AmountSet(0)
        };

        public void GetAmountFromMain(int amount)
        {
            Other other = new Other();
            AmountSet newAmount = amountset[0];
            int CalcAmount = amount - other.RemoveFromAmount();

            newAmount.Gethere(CalcAmount);
        }

        public int DisplayAmount()
        {
            int display = 0;
            foreach (AmountSet amountset in amountset)
            {
                display = amountset.Amount;
            }

            return display;
        }
    }

    public class Other
    {
        public int RemoveFromAmount()
        {
            int removethis = 50;
            return removethis;
        }
    }

    public class People
    {
        public string PersonNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? Health { get; set; }
        public int? Risk {  get; set; }
        public int? Infection { get; set; }

    }
    class Program
    {
        static void Main()
        {
            //Functions functions = new Functions();

            //int newAmount = 200;
            //functions.GetAmountFromMain(newAmount);

            //int Display = functions.DisplayAmount();

            //Console.WriteLine(Display);



            //string input = "19901125-1111";

            //// Split the input into date and time parts
            //string datePart = input.Substring(0, 8); // "19901125"
            //string timePart = input.Substring(9);    // "1111"

            //// Create a DateTime object with the date part
            //if (DateTime.TryParseExact(datePart, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime result))
            //{
            //    // The DateTime object now represents November 25, 1990
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid date format.");
            //}
            string person = "19901125-1111";

            DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            string birth = person.Substring(0, 8);
            
            DateOnly dateOnly = DateOnly.FromDateTime(DateTime.ParseExact(birth, "yyyyMMdd", CultureInfo.InvariantCulture));

            int newage = today.Year - dateOnly.Year;

            if(dateOnly > today.AddYears(-newage))
            {
                newage = newage - 1;
            }

            Console.WriteLine(newage);



         

            string[] input = {"90112511111111", "Ernas", "Daniel", "1", "0", "1"};

            //9011251111
            //199011251111
            //901125-1111
            //19901125-1111

            foreach (var number in input[0])
            {
                if(!char.IsDigit(number))
                {
                    if(number != '-')
                    {
                        Console.WriteLine($"{number} is incorrect");
                    }
                }
            }

            if (input[0].Length < 10 || input[0].Length > 13)
            {
                Console.WriteLine("Incorrect form");
            }

            if (input.Length < 6)
            {
                Console.WriteLine("Incorrect");
            }

            if (!input[3].All(char.IsDigit))
            {

            }

            if (!input[4].All(char.IsDigit))
            {

            }

            if (!input[5].All(char.IsDigit))
            {

            }





            if (!int.TryParse(input[0].Substring(0, 6), out int birthdate) && !int.TryParse(input[0].Substring(0, 8), out int result))
            {
                Console.WriteLine("Not a birthdate");
            }

            if (input[0].Length < 12)
            {
                if (input[0].Substring(6, 1) != "-")
                {
                    if (!input[0].Substring(0, 10).All(char.IsDigit))
                    {
                        Console.WriteLine($"Incorrect 1 a {input[0]}");
                    }
                }
                if (input[0].Substring(7, 1) == "-")
                {
                    Console.WriteLine("hej");
                    if (!int.TryParse(input[0].Substring(7, 4), out int aaaa))
                    {
                        Console.WriteLine($"Incorrect 1 b {input[0]}");
                    }
                }
            }

            if (input[0].Length > 12)
            {
                if (input[0].Substring(8, 1) != "-")
                {
                    if (!input[0].Substring(0, 12).All(char.IsDigit))
                    {
                        Console.WriteLine($"Incorrect 2 a {input[0]}");
                    }
                }
                if (input[0].Substring(9, 1) == "-")
                {
                    Console.WriteLine("hej2");
                    if (!int.TryParse(input[0].Substring(8, 4), out int aaaa))
                    {
                        Console.WriteLine($"Incorrect 2 b {input[0]}");
                    }
                }
            }


            //if (!int.TryParse(input[0].Substring(0, 6), out int result))
            //{
            //    Console.WriteLine("Not a birthdate");
            //}

            //if (!int.TryParse(input[0].Substring(0, 6), out int result))
            //{
            //    Console.WriteLine("Not a birthdate");
            //}







































            //int year = int.Parse(person.Substring(0, 4));
            //int month = int.Parse(person.Substring(4, 2));
            //int day = int.Parse(person.Substring(6, 2));

            ////Console.WriteLine($"{year} {month} {day}");

            //DateTime birthdate = new DateTime(year, month, day);

            //int age = today.Year - birthdate.Year;

            //if (birthdate > today.AddYears(-age))
            //{
            //    age--;
            //}

            //if (age >= 33)
            //{
            //    Console.WriteLine(age);
            //}
            //else
            //{
            //    Console.WriteLine("Nope");
            //}





            // string[] strings = 
            // {
            //     "19901125-0341",
            //     "890924-2134",
            //     "8901221341",
            //     "199010251234"
            // };

            // string insert = "-";
            // int index = 8;
            // string insertnumber = "19";
            // int indexnumber = 0;

            // List<string> list = new List<string>();

            // foreach(string sort in strings)
            // {
            //     if (sort.Length == 12)
            //     {
            //         string result = sort.Substring(0, index) + insert + sort.Substring(index);
            //         list.Add(result);
            //     }
            //     else if (sort.Length == 11)
            //     {
            //         string result2 = sort.Substring(0, indexnumber) + insertnumber + sort.Substring(indexnumber);
            //         list.Add(result2);
            //     }
            //     else if(sort.Length == 10)
            //     {
            //         string result3 = sort.Substring(0, indexnumber) + insertnumber +
            //             sort.Substring(0, index - 2) + insert + sort.Substring(index - 2);
            //         list.Add(result3);
            //     }
            //     else 
            //     {
            //         list.Add(sort);
            //     }
            // }

            //List<string> newlist = list.OrderByDescending(x => x).ToList();

            // foreach (string show in newlist) 
            // {
            //     Console.WriteLine(show);
            // }

        }

        static string Metod(string s, int n)
        {
            string x = "";
            for (int i = 0; i < n; i++)
            {
                x += s;
            }
            return x;
        }
    }
}