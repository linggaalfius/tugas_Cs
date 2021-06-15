using System;
using System.Collections.Generic;

namespace ConsoleApp4_HospitalOOP
{
    class Program
    {
        private static void View()
        {
            Console.WriteLine("===  Pendaftaran Pasien  ===");
            Console.WriteLine("1. Lihat Daftar Ruangan");
            Console.WriteLine("2. Tambah Ruangan");
            Console.WriteLine("3. Daftarkan Pasien");
            Console.WriteLine("");
            Console.Write("Masukkan Pilihan : ");
        }

        static void Main(string[] args)
        {
            List<Ruangan> ruangan = new List<Ruangan>();
            Ruangan ruangan1 = new Ruangan { NamaRuang = "Bougenvile" };
            Ruangan ruangan2 = new Ruangan { NamaRuang = "Anggrek" };
            Ruangan ruangan3 = new Ruangan { NamaRuang = "Melati" };

            ruangan.Add(ruangan1);
            ruangan.Add(ruangan2);
            ruangan.Add(ruangan3);

            Pasien pasien1 = new Pasien();
            pasien1.Nik = "3372040001";
            pasien1.Nama = "Lingga";
            pasien1.Ruangans = ruangan1;

            Pasien pasien2 = new Pasien();
            pasien2.Nik = "3372040002";
            pasien2.Nama = "Alfius";
            pasien2.Ruangans = ruangan2;

            Pasien pasien3 = new Pasien();
            pasien3.Nik = "3372040003";
            pasien3.Nama = "Krisworo";
            pasien3.Ruangans = ruangan3;

            ruangan1.Pasiens.Add(pasien1);
            ruangan2.Pasiens.Add(pasien2);
            ruangan3.Pasiens.Add(pasien3);

            while (true)
            {
                try
                {
                    View();
                    int opsi = Convert.ToInt32(Console.ReadLine());
                    switch (opsi)
                    {
                        case 1:
                            ShowRuangan(ruangan);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            //AddRuangan(ruangan);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            AddPasien(ruangan);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //throw;
                }
            }

            static void ShowRuangan(List<Ruangan> ruangan)
            {
                Console.Clear();
                Console.WriteLine("===  Daftar Ruangan  ===");
                foreach (var ruangg in ruangan)
                {
                    ruangg.ShowAll();
                }
            }

            static void AddPasien(List<Ruangan> ruangan)
            {
                Console.Clear();
                Ruangan ruangg = new Ruangan();
                ruangg.ShowRuangans(ruangan);
                Console.Write("Pilih Nomor Ruang  : ");
                int pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("NIK  : ");
                string nik = Console.ReadLine();
                Console.Write("Nama : ");
                string nama = Console.ReadLine();

                Pasien pasien = new Pasien();
                pasien.Nik = nik;
                pasien.Nama = nama;
                pasien.Ruangans = ruangan[pilih - 1];

                ruangan[pilih - 1].Pasiens.Add(pasien);

                Console.WriteLine("Pendaftaran berhasil");
            }
        }
    }
}
