using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        tryagain:
            Console.WriteLine("Adinizi daxil edin");
            string user = Console.ReadLine();
            Console.WriteLine("Parolu daxil edin");
            string password = Console.ReadLine();


        geridonus:
            if (user != "admin" && password != "admin")
            {
                Console.WriteLine("Melumatlar duzgun deyil.");
                goto tryagain;
            }
            else
            {
                Console.WriteLine(" 1 Kredit Götürmək ");
                Console.WriteLine(" 2 Kredit odemek ");
                Console.WriteLine(" 3 Hesabat");
                int Secin = int.Parse(Console.ReadLine());
                switch (Secin)
                {
                    case 1:
                        Console.WriteLine("12 ayliq"); Console.WriteLine("18 ayliq ");
                        int ay = int.Parse(Console.ReadLine());

                        //int umumipul = int.Parse(Console.ReadLine());
                        if (ay == 12)
                        {
                            Console.WriteLine("Meblegi daxil et");
                            int pul = int.Parse(Console.ReadLine());
                            if (pul > 0)
                            {
                                int umumipul = pul * 120 / 100;
                                Console.WriteLine("Umumi borcunuz: " + umumipul);
                                int ayliqodenis = umumipul / 12;
                                Console.WriteLine("Ayliq odenis: " + ayliqodenis);
                                Console.WriteLine(" 1 Razisinizmi?");
                                Console.WriteLine(" 2 Razi deyilem.");
                                int choose = int.Parse(Console.ReadLine());
                                switch (choose)
                                {
                                    case 1:
                                        Console.WriteLine("Emeliyyat ugurla icra olundu.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Emeliyyat legv edildi.");
                                        break;
                                }

                            }

                        }
                        if (ay == 18)
                        {
                            Console.WriteLine("Meblegi daxil et");
                            int pul = int.Parse(Console.ReadLine());
                            if (pul > 0)
                            {
                                int umumipul = pul * 1820 / 100;
                                Console.WriteLine("Umumi borcunuz: " + umumipul);
                                int ayliqodenis = umumipul / 18;
                                Console.WriteLine("Ayliq odenis: " + ayliqodenis);
                                Console.WriteLine("Razisinizmi?");
                                Console.WriteLine(" 1 Razisinizmi?");
                                Console.WriteLine(" 2 Razi deyilem.");
                                int choose = int.Parse(Console.ReadLine());
                                switch (choose)
                                {
                                    case 1:
                                        Console.WriteLine("Emeliyyat ugurla icra olundu.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Emeliyyat legv edildi.");
                                        break;
                                }
                                goto geridonus;
                            }

                        }
                        break;
                    case 2:
                        Console.Write("Umumi Borc elave et: ");
                        int umumiborc = int.Parse(Console.ReadLine());
                    geri:
                        Console.Write("Odeyeceyin pulu daxil et: ");
                        int odeyeceyinborc = int.Parse(Console.ReadLine());
                        if (odeyeceyinborc > 0)
                        {
                            umumiborc = umumiborc - odeyeceyinborc;
                            Console.WriteLine("Qalan borcunuz: " + umumiborc);
                        }
                        else
                        {
                            Console.WriteLine("Pulu daxil edin.");
                            goto geri;
                        }
                        Console.WriteLine("Emeliyyat ugurla icra edildi. ");
                        break;
                        Console.WriteLine("test");
                }
            }








        }

    }
}
