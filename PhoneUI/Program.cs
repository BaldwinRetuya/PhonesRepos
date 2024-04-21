using Phones;
using PhonesModel;

namespace PhoneUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhonesDL phonesDL = new PhonesDL();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine(" \nAbout Phones");
                Console.WriteLine("Select a Brand of Phone");
                Console.WriteLine("1. Redmi/Xioami");
                Console.WriteLine("2. Apple");
                Console.WriteLine("3. Infinix");
                Console.WriteLine("4. TECNO");
                Console.WriteLine("5. Asus");
                Console.WriteLine("6. Exit");
                string select = Console.ReadLine();

                switch (select)
                {
                    case "1":
                        {
                            Display(phonesDL.brands[0]);
                            Console.WriteLine(" ");
                            Display(phonesDL.brands[5]);
                            break;
                        }
                    case "2":
                        {
                            Display(phonesDL.brands[1]);
                            Console.WriteLine(" ");
                            Display(phonesDL.brands[6]);
                            break;
                        }
                    case "3":
                        {
                            Display(phonesDL.brands[2]);
                            Console.WriteLine(" ");
                            Display(phonesDL.brands[7]);
                            break;
                        }
                    case "4":
                        {
                            Display(phonesDL.brands[3]);
                            Console.WriteLine(" ");
                            Display(phonesDL.brands[8]);
                            break;
                        }
                    case "5":
                        {
                            Display(phonesDL.brands[4]);
                            Console.WriteLine(" ");
                            Display(phonesDL.brands[9]);
                            break;
                        }
                    case "6":
                        {
                            exit = true; // Set exit flag to true to exit the loop
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid");
                            break;
                        }
                }
            }
        }

        static void Display(CPBrands brand)
        {
            Console.WriteLine("Model: " + brand.Model);
            Console.WriteLine("Operating System: " + brand.OperatingSystem);
            Console.WriteLine("Brand: " + brand.Brand);
            Console.WriteLine("Price: " + brand.Price);
            Console.WriteLine("Processor:  " + brand.Processor);
        }
    }
}
