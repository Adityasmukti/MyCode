using System;

namespace BatuKertasGuting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string nama = "";
            int acak, pilih = 0, scoreKamu = 0, scoreKomputer = 0; //Variabel
            Console.WriteLine("—— Old Game But Gold ——");
            Console.WriteLine("—— By Adityasmukti ——");
            Console.WriteLine("—— Batu Kertas Gunting ——\n");
            Console.Write("Masukan Nama Kamu : ");
            nama = Console.ReadLine();// Masukan Nama
            Console.Clear(); //Hilangkan Layar

        awal:
            Random rand = new Random(); //Membuat variabel dari class random
            acak = rand.Next(0, 3); // Mengacak angka dari 0 sampai sebelum 3
            Console.WriteLine("—— Old Game But Gold ——");
            Console.WriteLine("—— By Adityasmukti ——");
            Console.WriteLine("—— Batu Kertas Gunting ——\n");
            Console.WriteLine("\t—-pilihan—-");
            Console.WriteLine(" [1]. Batu");
            Console.WriteLine(" [2]. Kertas");
            Console.WriteLine(" [3]. Gunting");
            Console.WriteLine(" [4]. Keluar\n");
            Console.WriteLine("Score");
            Console.WriteLine(nama + " " + scoreKamu + " - Komputer " + scoreKomputer + "\n");
            Console.Write("Masukan Pilihan: ");
            int.TryParse(Console.ReadLine(), out pilih); //Input User
            Console.WriteLine("\n");
            if (pilih == 1)
            {
                Console.WriteLine("\nPilihan Kamu\t\t: Batu");
                if (acak == 0)
                {
                    Console.WriteLine("Pilihan Komputer\t: Batu\n");
                    Console.WriteLine("\t–------ DRAW –------");
                }
                else if (acak == 1)
                {
                    Console.WriteLine("Pilihan Komputer\t: Kertas\n");
                    Console.WriteLine("\t–------ Kamu Kalah –------");
                    scoreKomputer++;

                }
                else if (acak == 2)
                {
                    Console.WriteLine("Pilihan Komputer\t: Gunting\n");
                    Console.WriteLine("\t–------ Kamu Menang –------");
                    scoreKamu++;
                }
            }
            else if (pilih == 2)
            {
                Console.WriteLine("Pilihan Kamu\t\t: Kertas");
                if (acak == 0)
                {
                    Console.WriteLine("Pilihan Komputer\t: Batu\n");
                    Console.WriteLine("\t–------ Kamu Menang –------");
                    scoreKamu++;
                }
                else if (acak == 1)
                {
                    Console.WriteLine("Pilihan Komputer\t: Kertas\n");
                    Console.WriteLine("\t–------ DRAW –------");
                    scoreKomputer++;
                }
                else if (acak == 2)
                {
                    Console.WriteLine("Pilihan Komputer\t: Gunting\n");
                    Console.WriteLine("\t–------ Kamu Kalah –------");
                }
            }
            else if (pilih == 3)
            {
                Console.WriteLine("Pilihan Kamu\t\t: Gunting\n");
                if (acak == 0)
                {
                    Console.WriteLine("Pilihan Komputer\t: Batu\n\n");
                    Console.WriteLine("\t–------ Kamu Kalah –------");
                    scoreKomputer++;
                }
                else if (acak == 1)
                {
                    Console.WriteLine("Pilihan Komputer\t: Kertas\n\n");
                    Console.WriteLine("\t–------ Kamu Menang –------");
                    scoreKamu++;
                }
                else if (acak == 2)
                {
                    Console.WriteLine("Pilihan Komputer\t: Gunting\n\n");
                    Console.WriteLine("\t–------ DRAW –------");
                }
            }
            else if (pilih == 4)
            {
                Console.WriteLine("\n\n************************** TERIMAKASIH **************************");
                Environment.Exit(0); //Keluar dari applikasi
            }
            else
            {
                Console.WriteLine("\nPilihan Yang " + nama + " Pilih Tidak Ada\n");
                Console.ReadKey();
                Console.Clear();
                goto awal;//kembali ke posisi awal
            }

            Console.ReadKey();
            Console.Clear();
            goto awal;
        }
    }
}