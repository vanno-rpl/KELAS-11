using System;
namespace Matematika
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Belajar PBO");

            Kalkulator Kal = new Kalkulator();
            BangunDatar BDatar = new BangunDatar();
            BangunRuang BRuang = new BangunRuang();

            Kal.Penjumlahan();
            BangunDatar.luasLingkaran();
            BRuang.volumeTabung();
        }
    }

    class Kalkulator
    {
        public void Penjumlahan()
        {
            Console.WriteLine("Penjumlahan");
        }
        public void Pengurangan()
        {
            Console.WriteLine("Pengurangan");
        }
    }

    class BangunDatar
    {
        public static void kelilingPersegiPanjang()
        {
            Console.WriteLine("Keliling Persegi Panjang");
        }

        public static void kelilingLingkaran()
        {
            Console.WriteLine("Keliling Lingkaran");
        }

        public static void luasPersegiPanjang()
        {
            Console.WriteLine("Luas Persegi Panjang");
        }

        public static void luasLingkaran()
        {
            Console.WriteLine("Luas Lingkaran");
        }

    }

    class BangunRuang
    {
        public void volumeBalok()
        {
            Console.WriteLine("Volume Balok");
        }

        public void volumeTabung()
        {
            Console.WriteLine("Volume Tabung");
        }

        public void volumePiramid()
        {
            Console.WriteLine("Volume Piramid");
        }
    }
    
}