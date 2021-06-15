using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4_HospitalOOP
{
    class Ruangan
    {
        public string NamaRuang { get; set; }
        public List<Pasien> Pasiens { get; set; }

        public Ruangan()
        {
            Pasiens = new List<Pasien>();
        }

        public void ShowAll()
        {
            Console.WriteLine($"Nama Ruang    : {NamaRuang}");
            Console.WriteLine("Daftar Pasien");
            foreach (var pasien in Pasiens)
            {
                Console.WriteLine(" ----------------------------");
                Console.WriteLine($"    NIK     : {pasien.Nik}");
                Console.WriteLine($"    Nama    : {pasien.Nama}");
                Console.WriteLine(" ----------------------------");
            }
            Console.WriteLine("");
        }

        public void ShowRuangans(List<Ruangan> ruangan)
        {
            Console.WriteLine("Daftar Ruangan");
            Console.WriteLine("===================");
            Console.WriteLine("");
            for (int i = 0; i < ruangan.Count; i++)
            {
                Console.WriteLine($"No.     : {i + 1}");
                Console.WriteLine($"Nama    : {ruangan[i].NamaRuang}");
                Console.WriteLine();
            }
        }

        public void ShowPasiens(int j)
        {
            for (int i = 0; i < Pasiens.Count; i++)
            {
                Console.WriteLine($"No.         : {j + 1}");
                Console.WriteLine($"NIK         : {Pasiens[i].Nik}");
                Console.WriteLine($"Nama        : {Pasiens[i].Nama}");
                Console.WriteLine($"Coding Camp : {Pasiens[i].Ruangans.NamaRuang}");
                Console.WriteLine();
                j++;
            }
        }
    }
}
