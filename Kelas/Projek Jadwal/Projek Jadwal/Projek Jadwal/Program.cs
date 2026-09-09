using System;
namespace ProjekJadwal
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jadwal Mata Pelajaran");

            Senin Sen = new Senin();
            Selasa Sel = new Selasa();
            Rabu Rabu = new Rabu();
            Sen.Sesi1();
            Sen.Sesi2();
            Sen.Sesi3();
            Sel.Sesi1();
            Sel.Sesi2();
            Sel.Sesi3();
            Rabu.Sesi1();
            Rabu.Sesi2();
            Rabu.Sesi3();
            Kamis.Sesi1();
            Kamis.Sesi2();
            Kamis.Sesi3();
            Jumat.Sesi1();
            Jumat.Sesi2();
        }
    }

    class Senin
    {
        public void Sesi1()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Senin");
            Console.WriteLine("Sesi 1: 07.00 - 09.55");
            Console.WriteLine("Bahasa Jepang");
            Console.WriteLine("Bahasa Inggris");
        }

        public void Sesi2()
        {
            Console.WriteLine("Sesi 2: 10.10 - 11.40");
            Console.WriteLine("Matematika");
        }

        public void Sesi3()
        {
            Console.WriteLine("Sesi 3: 12.30 - 15.00");
            Console.WriteLine("PPLG\n");
        }
    }
    class Selasa
    {
        public void Sesi1()
        {
            Console.WriteLine("Selasa");
            Console.WriteLine("Sesi 1: 07.00 - 09.20");
            Console.WriteLine("KIK");
            Console.WriteLine("PJOK");
        }

        public void Sesi2()
        {
            Console.WriteLine("Sesi 2: 09.30 - 11.35");
            Console.WriteLine("Bahasa Indonesia");
        }

        public void Sesi3()
        {
            Console.WriteLine("Sesi 3: 12.30 - 14.30");
            Console.WriteLine("PPLG\n");
        }
    }

    class Rabu
    {
        public void Sesi1()
        {
            Console.WriteLine("Rabu");
            Console.WriteLine("Sesi 1: 07.00 - 09.20");
            Console.WriteLine("PPLG");
        }   

        public void Sesi2()
        {
            Console.WriteLine("Sesi 2: 09.30 - 11.35");
            Console.WriteLine("PPLG");
        }   

        public void Sesi3()
        {
            Console.WriteLine("Sesi 3: 12.30 - 14.30");
            Console.WriteLine("PPLG");  
            Console.WriteLine("BK\n");  
        }
    }

    class Kamis
    {
        public static void Sesi1()
        {
            Console.WriteLine("Kamis");
            Console.WriteLine("Sesi 1: 07.00 - 09.20");
            Console.WriteLine("Bahasa Jerman");
            Console.WriteLine("Bahasa Jawa");
        }

        public static void Sesi2()
        {
            Console.WriteLine("Sesi 2: 09.30 - 11.35");
            Console.WriteLine("KIK");
            Console.WriteLine("PAI");
        }

        public static void Sesi3()
        {
            Console.WriteLine("Sesi 3: 12.30 - 14.30");
            Console.WriteLine("PAI\n");

        }
    }

    class Jumat
    {
        public static void Sesi1()
        {
            Console.WriteLine("Sesi 1: 06.30 - 09.30");
            Console.WriteLine("Bahasa Inggris");
            Console.WriteLine("Sejarah");
        }

        public static void Sesi2()
        {
            Console.WriteLine("Jumat");
            Console.WriteLine("Sesi 2: 09.45 - 11.15");
            Console.WriteLine("Sejarah");
            Console.WriteLine("Pendidikan Pancasila\n");
        }
    }
}