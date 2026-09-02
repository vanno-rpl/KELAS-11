//Studi Kasus

//Jawaban Soal 1 (Menampilkan Angka 1-100)
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 100; i++)
//        {
//            Console.Write(i + " ");
//        }
//    }
//}


//Jawaban Soal 2 (Menjumlahkan Bilangan 1-50)
//using System;

//class Program
//{
//    static void Main()
//    {
//        int total = 0;
//        for (int i = 1; i <= 50; i++)
//        {
//            total += i;
//        }
//        Console.WriteLine("Jumlah total 1 sampai 50 = " + total);
//    }
//}

//Jawaban Soal 3 (Membuat Pola Segitiga Bintang)
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            for (int j = 1; j <= i; j++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//Jawaban Soal 4 (Menampilkan Tabel Perkalian)
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine($"5 x {i} = {5 * i}");
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

//Latihan

//Jawaban Soal 1 (Buat Program Menghitung Faktorial)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan angka: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        long faktorial = 1;

//        for (int i = 1; i <= n; i++)
//        {
//            faktorial *= i;
//        }
//        Console.WriteLine($"Faktorial dari {n} adalah {faktorial}");
//    }
//}

//Jawaban Soal 2 (Buat Program Mencari Bilangan Genap 1-100)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Bilangan Genap 1 - 100:");
//        for (int i = 1; i <= 100; i++)
//        {
//            if (i % 2 == 0)
//            {
//                Console.Write(i + " ");
//            }
//        }
//    }
//}

//Jawaban Soal 3 (Buat Program Menampilkan Pola Persegi Menggunakan Nested Loop)
//using System;

//class Program
//{
//    static void Main()
//    {
//        int ukuran = 5;
//        for (int i = 1; i <= ukuran; i++)
//        {
//            for (int j = 1; j <= ukuran; j++)
//            {
//                Console.Write("* ");
//            }
//            Console.WriteLine();
//        }
//    }
//}