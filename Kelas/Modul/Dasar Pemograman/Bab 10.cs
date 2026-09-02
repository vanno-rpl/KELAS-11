//Studi Kasus

//Jawaban Soal 1 (Buat Program Menentukan Bilangan Ganjil atau Genap)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan angka: ");
//        int angka = Convert.ToInt32(Console.ReadLine());

//        if (angka % 2 == 0)
//            Console.WriteLine("Bilangan Genap");
//        else
//            Console.WriteLine("Bilangan Ganjil");
//    }
//}

//Jawaban Soal 2 (Buat Program Menghitung Diskon Berdasarkan Total Belanja)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan Total Belanja: ");
//        double total = Convert.ToDouble(Console.ReadLine());
//        double diskon = 0;

//        if (total >= 100000)
//            diskon = 0.1 * total; // Diskon 10%
//        else if (total >= 50000)
//            diskon = 0.05 * total; // Diskon 5%

//        double bayar = total - diskon;
//        Console.WriteLine($"Diskon: Rp {diskon}");
//        Console.WriteLine($"Total Bayar: Rp {bayar}");
//    }
//}

//Jawaban Soal 3 (Buat Program Menentukan Kategori Nilai Siswa)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan Nilai (0-100): ");
//        int nilai = Convert.ToInt32(Console.ReadLine());

//        if (nilai >= 85)
//            Console.WriteLine("Kategori: Sangat Baik");
//        else if (nilai >= 75)
//            Console.WriteLine("Kategori: Baik");
//        else if (nilai >= 60)
//            Console.WriteLine("Kategori: Cukup");
//        else
//            Console.WriteLine("Kategori: Kurang");
//    }
//}

//Mini Project

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan Umur: ");
//        int umur = Convert.ToInt32(Console.ReadLine());

//        if (umur >= 17)
//        {
//            Console.WriteLine("Boleh membuat KTP");
//        }
//        else
//        {
//            Console.WriteLine("Belum memenuhi syarat");
//        }
//    }
//}

//Latihan

//Jawaban Soal 1 (Buat Program Login Sederhana Menggunakan Username dan Password)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Username: ");
//        string user = Console.ReadLine();
//        Console.Write("Password: ");
//        string pass = Console.ReadLine();

//        if (user == "admin" && pass == "12345")
//            Console.WriteLine("Login Berhasil!");
//        else
//            Console.WriteLine("Username atau Password salah.");
//    }
//}

//Jawaban Soal 2 (Buat Program Menentukan Hari Berdasarkan Nomor 1-7 Dengan Switch)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan angka hari (1-7): ");
//        int noHari = Convert.ToInt32(Console.ReadLine());

//        switch (noHari)
//        {
//            case 1: Console.WriteLine("Senin"); break;
//            case 2: Console.WriteLine("Selasa"); break;
//            case 3: Console.WriteLine("Rabu"); break;
//            case 4: Console.WriteLine("Kamis"); break;
//            case 5: Console.WriteLine("Jumat"); break;
//            case 6: Console.WriteLine("Sabtu"); break;
//            case 7: Console.WriteLine("Minggu"); break;
//            default: Console.WriteLine("Nomor hari tidak valid!"); break;
//        }
//    }
//}

//Jawaban Soal 3 (Buat Program Menentukan Nilai A, B, C, D)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan Nilai: ");
//        int nilai = Convert.ToInt32(Console.ReadLine());

//        if (nilai >= 90) Console.WriteLine("Predikat: A");
//        else if (nilai >= 80) Console.WriteLine("Predikat: B");
//        else if (nilai >= 70) Console.WriteLine("Predikat: C");
//        else Console.WriteLine("Predikat: D");
//    }
//}