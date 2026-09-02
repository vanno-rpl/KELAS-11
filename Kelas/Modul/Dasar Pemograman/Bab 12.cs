//Studi Kasus

//Jawaban Soal 1 (Menyimpan Nilai 10 Siswa Dalam Array)
//int[] nilaiSiswa = { 80, 75, 90, 85, 70, 95, 88, 77, 82, 91 };

//Jawaban Soal 2 (Menghitung Nilai Tertinggi Dan Rata-Rata)
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] nilaiSiswa = { 80, 75, 90, 85, 70, 95, 88, 77, 82, 91 };
//        int max = nilaiSiswa[0];
//        int total = 0;

//        foreach (int n in nilaiSiswa)
//        {
//            if (n > max) max = n;
//            total += n;
//        }

//        double rataRata = (double)total / nilaiSiswa.Length;
//        Console.WriteLine("Nilai Tertinggi: " + max);
//        Console.WriteLine("Rata-rata Nilai: " + rataRata);
//    }
//}

//Jawaban Soal 3 (Mengelola Daftar Nama Menggunakan List<T>)
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> daftarNama = new List<string>();
//        daftarNama.Add("Fabio");
//        daftarNama.Add("Vanno");
//        daftarNama.Add("Mirza");

//        Console.WriteLine("Daftar Nama Siswa:");
//        foreach (var nama in daftarNama)
//        {
//            Console.WriteLine("- " + nama);
//        }
//    }
//}

//Mini Project
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan jumlah siswa: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        for (int i = 1; i <= n; i++)
//        {
//            Console.Write($"Nama siswa ke-{i}: ");
//            string nama = Console.ReadLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] nilai = { 75, 80, 90, 85, 70 };
//        int total = 0;

//        foreach (int n in nilai)
//        {
//            total += n;
//        }

//        Console.WriteLine($"Rata-rata = {(double)total / nilai.Length}");
//    }
//}

//Latihan

//Jawaban Soal 1 (Buat Program Mencari Nilai Terbesar Dalam Array)
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] angka = { 12, 45, 67, 23, 89, 34 };
//        int terbesar = angka[0];

//        for (int i = 1; i < angka.Length; i++)
//        {
//            if (angka[i] > terbesar) terbesar = angka[i];
//        }

//        Console.WriteLine("Nilai terbesar = " + terbesar);
//    }
//}

//Jawaban Soal 2 (Buat Program Menghitung Jumlah Bilangan Genap Dalam Array)
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] data = { 1, 4, 7, 8, 12, 15, 18, 21 };
//        int countGenap = 0;

//        foreach (int x in data)
//        {
//            if (x % 2 == 0) countGenap++;
//        }

//        Console.WriteLine("Jumlah angka genap ada: " + countGenap);
//    }
//}

//Jawaban Soal 3 (Buat Aplikasi Daftar Nama Menggunakan List<T>)
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> namaSiswa = new List<string>();

//        // Menambah data
//        namaSiswa.Add("Fabio");
//        namaSiswa.Add("Vanno");
//        namaSiswa.Add("Mirza");

//        // Menghapus data
//        namaSiswa.Remove("Vanno");

//        // Menampilkan list
//        Console.WriteLine("Daftar Nama Terbaru:");
//        foreach (string n in namaSiswa)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}