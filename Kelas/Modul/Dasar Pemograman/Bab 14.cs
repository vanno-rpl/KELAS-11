//Studi Kasus

//Jawaban Soal 1 (Membuat Class Siswa Dengan Nama Dan Nilai)
//class Siswa
//{
//    public string Nama { get; set; }
//    public double Nilai { get; set; }
//}

//Jawaban Soal 2 (Membuat Class Persegi Panjang Untuk Menghitung Luas)
//class PersegiPanjang
//{
//    public double Panjang { get; set; }
//    public double Lebar { get; set; }

//    public double HitungLuas()
//    {
//        return Panjang * Lebar;
//    }
//}

//Jawaban Soal 3 (Membuat Class Rekening Dengan Setor Dan Lihat Saldo)
//class Rekening
//{
//    private double saldo;

//    public void Setor(double jumlah)
//    {
//        saldo += jumlah;
//    }

//    public double LihatSaldo()
//    {
//        return saldo;
//    }
//}

//Mini Project

//using System;

//class Mobil
//{
//    public string Merk { get; set; }

//    public void Jalan()
//    {
//        Console.WriteLine($"{Merk} sedang berjalan.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Mobil m = new Mobil();
//        m.Merk = "Toyota";
//        m.Jalan();
//    }
//}

//Latihan

//Jawaban Soal 1 (Buat Class Buku Dengan Judul Dan Penulis)
//class Buku
//{
//    public string Judul { get; set; }
//    public string Penulis { get; set; }
//}

//Jawaban Soal 2 (Buat Class Mahasiswa Dengan Method TampilData())
//using System;

//class Mahasiswa
//{
//    public string Nama;
//    public string NIM;

//    public void TampilData()
//    {
//        Console.WriteLine($"Nama: {Nama}, NIM: {NIM}");
//    }
//}

//Jawaban Soal 3 (Buat Constructor Yang Menerima Dua Parameter)
//using System;

//class Mahasiswa
//{
//    public string Nama;
//    public string NIM;

//    // Constructor dengan 2 parameter
//    public Mahasiswa(string nama, string nim)
//    {
//        Nama = nama;
//        NIM = nim;
//    }

//    public void TampilData()
//    {
//        Console.WriteLine($"Nama: {Nama}, NIM: {NIM}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Mahasiswa mhs = new Mahasiswa("Budi", "123456");
//        mhs.TampilData();
//    }
//}

//LKPD

//Jawaban Soal 1 (Praktik Membuat Minimal Tiga Class Berbeda)
//using System;

//// Class 1: Kendaraan
//class Kendaraan
//{
//    public string Jenis { get; set; }
//    public void BunyikanKlakson()
//    {
//        Console.WriteLine($"{Jenis} berbunyi: Telolet!");
//    }
//}

//// Class 2: Guru
//class Guru
//{
//    public string Nama { get; set; }
//    public string MataPelajaran { get; set; }

//    public void Mengajar()
//    {
//        Console.WriteLine($"Guru {Nama} sedang mengajar {MataPelajaran}.");
//    }
//}

//// Class 3: Laptop
//class Laptop
//{
//    public string Merk { get; set; }
//    public int RAM { get; set; }

//    public void Spesifikasi()
//    {
//        Console.WriteLine($"Laptop {Merk} dengan RAM {RAM}GB.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Kendaraan k = new Kendaraan { Jenis = "Bus" };
//        Guru g = new Guru { Nama = "Pak Ahmad", MataPelajaran = "C#" };
//        Laptop l = new Laptop { Merk = "ASUS", RAM = 16 };

//        k.BunyikanKlakson();
//        g.Mengajar();
//        l.Spesifikasi();
//    }
//}

//Jawaban Soal 2 (Presentasikan Hasil Program Dan Jelaskan Hubungan Class Dan Object)
//Class merupakan rancangan atau template abstrak yang mendefinisikan atribut (field/property) dan perilaku (method) yang dimiliki oleh suatu entitas. Contohnya class Siswa. Object merupakan bentuk nyata dari sebuah class yang dibuat di dalam memori dan memiliki nilai data yang spesifik. Contohnya objek s1 dengan Nama = "Vanno" yang dibuat dari class Siswa(Siswa s1 = new Siswa();).  Hubungan: Class adalah konsep atau rancangannya, sedangkan Object adalah perwujudan fisik/konkret dari rancangan tersebut yang siap digunakan dalam program.