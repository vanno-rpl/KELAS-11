using System;

namespace Tugas1
{
    // Kalkulator
    class Kalkulator
{
    public static void Eksekusi()
    {
        Console.Clear();
        Console.WriteLine("MENU KALKULATOR");
        Penjumlahan(1, 2);
        Pengurangan(4, 2);
        Perkalian(4, 3);
        Pembagian(5, 2);
        Console.WriteLine("\nTekan tombol apa saja untuk kembali ke menu...");
        Console.ReadKey();
    }

    public static void Penjumlahan(int a, int b)
    {
        Console.WriteLine("1. Penjumlahan");
        double c = a + b;
        Console.WriteLine($"{a} + {b}");
        Console.WriteLine($"Hasil= {c}");
    }

    public static void Pengurangan(int a, int b)
    {
        Console.WriteLine("\n2. Pengurangan");
        double c = a - b;
        Console.WriteLine($"{a} - {b}");
        Console.WriteLine($"Hasil= {c}");
    }

    public static void Perkalian(int a, int b)
    {
        Console.WriteLine("\n3. Perkalian");
        double c = a * b;
        Console.WriteLine($"{a} * {b}");
        Console.WriteLine($"Hasil= {c}");
    }

    public static void Pembagian(double a, double b)
    {
        Console.WriteLine("\n4. Pembagian");
        double c = a / b;
        Console.WriteLine($"{a} / {b}");
        Console.WriteLine($"Hasil= {c}\n");
    }
}

// Bangun Datar
class BangunDatar
{
    private int _keliling;
    private int _luas;

    public static void Eksekusi()
    {
        Console.Clear();
        Console.WriteLine("MENU BANGUN DATAR");
        KelilingPersegi(3);
        LuasPersegi(3, 5);
        Console.WriteLine("\nTekan tombol apa saja untuk kembali ke menu...");
        Console.ReadKey();
    }

    public static void KelilingPersegi(int s)
    {
        Console.WriteLine("Keliling Persegi");
        int k = 4 * s;
        Console.WriteLine($"4 x {s}");
        Console.WriteLine($"Hasil= {k}\n");
    }

    public static void LuasPersegi(int p, int le)
    {
        Console.WriteLine("Luas Persegi");
        int l = p * le;
        Console.WriteLine($"{p} x {le}");
        Console.WriteLine($"Hasil= {l}\n");
    }

    public override bool Equals(object obj)
    {
        return obj is BangunDatar datar && _keliling == datar._keliling && _luas == datar._luas;
    }

    public override int GetHashCode()
    {
        return _keliling.GetHashCode() ^ _luas.GetHashCode();
    }
}

// Bangun Ruang
class BangunRuang
{
    public static void Eksekusi()
    {
        Console.Clear();
        Console.WriteLine("MENU BANGUN RUANG");
        VolumeKubus(2);
        LuasPermukaanKubus(6);
        Console.WriteLine("\nTekan tombol apa saja untuk kembali ke menu...");
        Console.ReadKey();
    }

    public static void VolumeKubus(int s)
    {
        Console.WriteLine("Volume Kubus");
        int v = s * s * s;
        Console.WriteLine($"{s} x {s} x {s}");
        Console.WriteLine($"Hasil= {v}");
    }

    public static void LuasPermukaanKubus(int s)
    {
        Console.WriteLine("\nLuas Permukaan Kubus");
        int lp = 6 * (s * s);
        Console.WriteLine($"6 x {s} x {s}");
        Console.WriteLine($"Hasil= {lp}\n");
    }
}

// Zodiak
class Zodiak
{
    public static void CekZodiak()
    {
        Console.Clear();
        Console.WriteLine("MENU ZODIAK");
        Console.Write("Masukkan tanggal lahir (1-31): ");
        int tanggal = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan bulan lahir (1-12) : ");
        int bulan = Convert.ToInt32(Console.ReadLine());

        string namaZodiak = GetNamaZodiak(tanggal, bulan);
        Console.WriteLine($"\nZodiak Anda adalah : {namaZodiak}");
        Console.WriteLine("\nTekan tombol apa saja untuk kembali ke menu...");
        Console.ReadKey();
    }

    private static string GetNamaZodiak(int tanggal, int bulan)
    {
        if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19)) return "Aries";
        if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20)) return "Taurus";
        if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20)) return "Gemini";
        if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22)) return "Cancer";
        if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22)) return "Leo";
        if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22)) return "Virgo";
        if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22)) return "Libra";
        if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21)) return "Scorpio";
        if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21)) return "Sagittarius";
        if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19)) return "Capricorn";
        if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18)) return "Aquarius";
        if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20)) return "Pisces";
        return "Tidak Valid";
    }
}

// Menu Utama & Program Entry
class MenuUtama
{
    public static void TampilkanMenu()
    {
        bool berjalan = true;
        while (berjalan)
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("     MENU PROGRAM    ");
            Console.WriteLine("\n");
            Console.WriteLine("1. Jalankan Kalkulator");
            Console.WriteLine("2. Hitung Bangun Datar");
            Console.WriteLine("3. Hitung Bangun Ruang");
            Console.WriteLine("4. Cek Zodiak");
            Console.WriteLine("5. Keluar Aplikasi");
            Console.WriteLine("\n");
            Console.Write("Pilih menu (1-5): ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Kalkulator.Eksekusi();
                    break;
                case "2":
                    BangunDatar.Eksekusi();
                    break;
                case "3":
                    BangunRuang.Eksekusi();
                    break;
                case "4":
                    Zodiak.CekZodiak();
                    break;
                case "5":
                    berjalan = false;
                    Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
                    break;
                default:
                    Console.WriteLine("\nPilihan tidak valid! Silakan tekan tombol apa saja untuk mencoba lagi.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MenuUtama.TampilkanMenu();
    }
}
}
