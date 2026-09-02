//Studi Kasus

//Jawaban Soal 1 (Buat Program Input Biodata Siswa)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan Nama : ");
//        string nama = Console.ReadLine();
//        Console.Write("Masukkan Kelas: ");
//        string kelas = Console.ReadLine();
//        Console.Write("Masukkan Umur : ");
//        int umur = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine($"\n--- BIODATA ---");
//        Console.WriteLine($"Nama : {nama}");
//        Console.WriteLine($"Kelas: {kelas}");
//        Console.WriteLine($"Umur : {umur} tahun");
//    }
//}

//Jawaban Soal 2 (Buat Program Menghitung Luas Persegi Panjang Dari Input Pengguna)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan Panjang: ");
//        double p = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Masukkan Lebar  : ");
//        double l = Convert.ToDouble(Console.ReadLine());

//        double luas = p * l;
//        Console.WriteLine($"Luas Persegi Panjang = {luas}");
//    }
//}

//Jawaban Soal 3 (Buat Program Menghitung Rata - Rata Tiga Nilai)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nilai 1: ");
//        double n1 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Nilai 2: ");
//        double n2 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Nilai 3: ");
//        double n3 = Convert.ToDouble(Console.ReadLine());

//        double rata = (n1 + n2 + n3) / 3.0;
//        Console.WriteLine($"Nilai Rata-rata = {rata:F2}");
//    }
//}


//Latihan

//Jawaban Soal 1 (Jelaskan Perbedaan Write() dan WriteLine())
//Console.Write(): Menampilkan teks ke layar tanpa berpindah ke baris baru. Kursor tetap berada di akhir teks yang dicetak pada baris yang sama. Console.WriteLine(): Menampilkan teks ke layar dan otomatis menambahkan baris baru (newline) di akhir, sehingga cetakan selanjutnya berada di baris di bawahnya.

//Jawaban Soal 2 (Buat Program Yang Meminta Nama Dan Menampilkan Sapaan)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan Nama Anda: ");
//        string nama = Console.ReadLine();
//        Console.WriteLine($"Halo {nama}, selamat pagi!");
//    }
//}

//Jawaban Soal 3 (Buat Program Menghitung Umur Dari Tahun Lahir)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan Tahun Lahir Anda: ");
//        int tahunLahir = Convert.ToInt32(Console.ReadLine());
//        int tahunSekarang = DateTime.Now.Year;
//        int umur = tahunSekarang - tahunLahir;

//        Console.WriteLine($"Umur Anda saat ini adalah {umur} tahun.");
//    }
//}