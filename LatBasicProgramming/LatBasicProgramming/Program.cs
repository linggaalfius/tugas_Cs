using System;
//using System.Collections.Generic;

namespace LatBasicProgramming
{
    class Program
    {
        //private static List<String> mataUang = new List<String>();
        //object[,] currency = new object[5, 2]
        //{ { "USD", 0.000070 }, { "EUR", 0.000058 }, { "GBP", 0.000049 }, { "JPY", 0.007937 }, { "MYR", 0.000289 } };
        private static double nilai;
        //private static string[] kode = new string[5] { "USD", "EUR", "GBP", "JPY", "MYR" };
        private static double[] rate = new double[5] { 0.000070, 0.000058, 0.000049, 0.007937, 0.000289 };
        
        private static void View()
        {
            Console.WriteLine("APLIKASI KONVERSI MATA UANG SEDERHANA");
            Console.WriteLine("");
            Console.WriteLine("1. IDR ke Mata uang Asing");
            Console.WriteLine("2. Mata uang Asing ke IDR");
            Console.WriteLine("3. Selesai");
            Console.WriteLine("");
            Console.Write("Pilih menu: ");
        }

        private static void Cls()
        {
            Console.ReadKey();
            Console.Clear();
        }

        public static void IDRtoValas()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("IDR ke Mata Uang Asing");
                Console.WriteLine("1. USD");
                Console.WriteLine("2. EURO");
                Console.WriteLine("3. Poundsterling");
                Console.WriteLine("4. Japan Yen");
                Console.WriteLine("5. MYRinggit");
                Console.WriteLine("");
                Console.Write("Silakan Pilih Nomor: ");
                int kode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (kode)
                {
                    case 1:
                        Console.Write("Input Nilai IDR: ");
                        nilai = Convert.ToDouble(Console.ReadLine());
                        double kurs = nilai * rate[0];
                        Console.WriteLine("");
                        Console.WriteLine("IDR " + nilai + " sama dengan   USD " + kurs.ToString("0.000"));
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.Write("Input Nilai IDR: ");
                        nilai = Convert.ToDouble(Console.ReadLine());
                        kurs = nilai * rate[1];
                        Console.WriteLine("");
                        Console.WriteLine("IDR " + nilai + " sama dengan   EUR " + kurs.ToString("0.000"));
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.Write("Input Nilai IDR: ");
                        nilai = Convert.ToDouble(Console.ReadLine());
                        kurs = nilai * rate[2];
                        Console.WriteLine("");
                        Console.WriteLine("IDR " + nilai + " sama dengan   GBP " + kurs.ToString("0.000"));
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.Write("Input Nilai IDR: ");
                        nilai = Convert.ToDouble(Console.ReadLine());
                        kurs = nilai * rate[3];
                        Console.WriteLine("");
                        Console.WriteLine("IDR " + nilai + " sama dengan   JPY " + kurs.ToString("0.000"));
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.Write("Input Nilai IDR: ");
                        nilai = Convert.ToDouble(Console.ReadLine());
                        kurs = nilai * rate[4];
                        Console.WriteLine("");
                        Console.WriteLine("IDR " + nilai + " sama dengan   MYR " + kurs.ToString("0.000"));
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Perintah yang anda input salah");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Cls();
        }

        private static void ValastoIDR()
        {
            try
            {
                Console.WriteLine("Mata Uang Asing ke IDR");
                Console.WriteLine("1. USD");
                Console.WriteLine("2. EURO");
                Console.WriteLine("3. Poundsterling");
                Console.WriteLine("4. Japan Yen");
                Console.WriteLine("5. MYRinggit");
                Console.WriteLine("");
                Console.Write("Silakan ketik kode: ");
                int kode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (kode)
                {
                    case 1:
                        Console.Write("Input Nilai USD: ");
                        nilai = Convert.ToDouble(Console.ReadLine());
                        double kurs = nilai / rate[0];
                        Console.WriteLine("");
                        Console.WriteLine("sama dengan IDR " + kurs.ToString("0.00"));
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.Write("Input Nilai EUR: ");
                        nilai = Convert.ToDouble(Console.ReadLine());
                        kurs = nilai / rate[1];
                        Console.WriteLine("");
                        Console.WriteLine("sama dengan IDR " + kurs.ToString("0.00"));
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.Write("Input Nilai GBP: ");
                        nilai = Convert.ToDouble(Console.ReadLine());
                        kurs = nilai / rate[2];
                        Console.WriteLine("");
                        Console.WriteLine("sama dengan IDR " + kurs.ToString("0.00"));
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.Write("Input Nilai JPY: ");
                        nilai = Convert.ToDouble(Console.ReadLine());
                        kurs = nilai / rate[3];
                        Console.WriteLine("");
                        Console.WriteLine("sama dengan IDR " + kurs.ToString("0.00"));
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.Write("Input Nilai MYR: ");
                        nilai = Convert.ToDouble(Console.ReadLine());
                        kurs = nilai / rate[4];
                        Console.WriteLine("");
                        Console.WriteLine("sama dengan IDR " + kurs.ToString("0.00"));
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Perintah yang anda input salah");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Cls();
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                View();
                int opsi = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (opsi == 1)
                    {
                        IDRtoValas();
                    }
                    else if (opsi == 2)
                    {
                        ValastoIDR();
                    }
                    else if (opsi == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tidak ada");
                    }
                    //Cls();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
