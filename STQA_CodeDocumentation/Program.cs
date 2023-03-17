using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STQA_CodeDocumentation
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks> class dapat membuat operasi tambah, tampil, menjumlahd </remarks>
    public class MenuAyamGeprek
    {
        //Deklarasi variabel global
        public double Prs1, AyamGeprek;

        //Membuat method prosedur untuk input variabel yang diketahui
        public void JumlahAyamGeprek()
        {
            Console.Write("Berapa Jumlah Yang Ingin Dipesan? ");
            Prs1 = Convert.ToDouble(Console.ReadLine());
        }

        //Membuat method fungsi untuk menghitung Harga
        public double HargaAyamGeprek(double Prs1)
        {
            AyamGeprek = 15000 * Prs1;
            return AyamGeprek;
        }

        //Membuat method prosedur untuk menampilkan jumlah yang ingin dibeli
        public void TampilAyamGeprek()
        {
            Console.WriteLine("{0} Ayam Geprek Berhasil Ditambahkan Ke Keranjang ", Prs1);
            Console.ReadKey();
        }
        //Membuat method berupa fungsi untuk menghitung Harga dari data yang telah diinput
        public void HitungAyamGeprek(double Prs1)
        {
            Console.Write("{0} Porsi Ayam Geprek = Rp.{1}", this.Prs1, this.HargaAyamGeprek(Prs1));
        }
    }
    public class MenuMieAyam
    {
        //Deklarasi variabel global
        public double Prs2, MieAyam;

        //Membuat method prosedur untuk input variabel yang diketahui
        public void JumlahMieAyam()
        {
            Console.Write("Berapa Jumlah Yang Ingin Dipesan? ");
            Prs2 = Convert.ToDouble(Console.ReadLine());
        }

        //Membuat method fungsi untuk menghitung Harga
        public double HargaMieAyam(double Prs2)
        {
            MieAyam = 10000 * Prs2;
            return MieAyam;
        }

        //Membuat method prosedur untuk menampilkan jumlah yang ingin dibeli
        public void TampilMieAyam()
        {
            Console.WriteLine("{0} Mie Ayam Berhasil Ditambahkan Ke Keranjang ", Prs2);
            Console.ReadKey();
        }
        //Membuat method berupa fungsi untuk menghitung Harga dari data yang telah diinput
        public void HitungMieAyam(double Prs2)
        {
            Console.Write("{0} Porsi Mie Ayam  = Rp.{1}", this.Prs2, this.HargaMieAyam(Prs2));
        }
    }
    public class MenuBakso
    {
        //Deklarasi variabel global
        public double Prs3, Bakso;

        //Membuat method prosedur untuk input variabel yang diketahui
        public void JumlahBakso()
        {
            Console.Write("Berapa Jumlah Yang Ingin Dipesan? ");
            Prs3 = Convert.ToDouble(Console.ReadLine());
        }

        //Membuat method fungsi untuk menghitung Harga
        public double HargaBakso(double Prs3)
        {
            Bakso = 12000  * Prs3;
            return Bakso;
        }

        //Membuat method prosedur untuk menampilkan jumlah yang ingin dibeli
        public void TampilBakso()
        {
            Console.WriteLine("{0} Bakso Berhasil Ditambahkan Ke Keranjang ", Prs3);
            Console.ReadKey();
        }
        //Membuat method berupa fungsi untuk menghitung Harga dari data yang telah diinput
        public void HitungBakso(double Prs3)
        {
            Console.Write("{0} Porsi Bakso = Rp.{1}", this.Prs3, this.HargaBakso(Prs3));
        }
    }
    public class MenuNasiGorengAyam
    {
        //Deklarasi variabel global
        public double Prs4, NasgorAyam;

        //Membuat method prosedur untuk input variabel yang diketahui
        public void JumlahNasgorAyam()
        {
            Console.Write("Berapa Jumlah Yang Ingin Dipesan? ");
            Prs4 = Convert.ToDouble(Console.ReadLine());
        }

        //Membuat method fungsi untuk menghitung Harga
        public double HargaNasgorAyam(double Prs4)
        {
            NasgorAyam = 12000 * Prs4;
            return NasgorAyam;
        }

        //Membuat method prosedur untuk menampilkan jumlah yang ingin dibeli
        public void TampilNasgorAyam()
        {
            Console.WriteLine("{0} Nasi Goreng Ayam Berhasil Ditambahkan Ke Keranjang ", Prs4);
            Console.ReadKey();
        }
        //Membuat method berupa fungsi untuk menghitung Harga dari data yang telah diinput
        public void HitungNasgorAyam(double Prs4)
        {
            Console.Write("{0} Porsi Nasi Goreng Ayam = Rp.{1}", this.Prs4, this.HargaNasgorAyam(Prs4));
        }
    }
    public class MenuAyamBakar
    {
        //Deklarasi variabel global
        public double Prs5, AyamBakar;

        //Membuat method prosedur untuk input variabel yang diketahui
        public void JumlahAyamBakar()
        {
            Console.Write("Berapa Jumlah Yang Ingin Dipesan? ");
            Prs5 = Convert.ToDouble(Console.ReadLine());
        }

        //Membuat method fungsi untuk menghitung Harga
        public double HargaAyamBakar(double Prs4)
        {
            AyamBakar = 16000 * Prs4;
            return AyamBakar;
        }

        //Membuat method prosedur untuk menampilkan jumlah yang ingin dibeli
        public void TampilAyamBakar()
        {
            Console.WriteLine("{0} Bakso Berhasil Ditambahkan Ke Keranjang ", Prs5);
            Console.ReadKey();
        }
        //Membuat method berupa fungsi untuk menghitung Harga dari data yang telah diinput
        public void HitungAyamBakar(double Prs5)
        {
            Console.Write("{0} Porsi Ayam Bakar = Rp.{1}", this.Prs5, this.HargaAyamBakar(Prs5));
        }
    }
    public class MenuEsTehManis
    {
        //Deklarasi variabel global
        public double Gls1, EsTehManis;

        //Membuat method prosedur untuk input variabel yang diketahui
        public void JumlahEsTehManis()
        {
            Console.Write("Berapa Jumlah Yang Ingin Dipesan? ");
            Gls1 = Convert.ToDouble(Console.ReadLine());
        }

        //Membuat method fungsi untuk menghitung Harga
        public double HargaEsTehManis(double Gls1)
        {
            EsTehManis = 3000 * Gls1;
            return EsTehManis;
        }

        //Membuat method prosedur untuk menampilkan jumlah yang ingin dibeli
        public void TampilEsTehManis()
        {
            Console.WriteLine("{0} Es Teh Manis Berhasil Ditambahkan Ke Keranjang ", Gls1);
            Console.ReadKey();
        }
        //Membuat method berupa fungsi untuk menghitung Harga dari data yang telah diinput
        public void HitungBakso(double Gls1)
        {
            Console.Write("{0} Gelas Es Teh Manis = Rp.{1}", this.Gls1, this.HargaEsTehManis(Gls1));
        }
    }
    public class MenuEsJeruk
    {
        //Deklarasi variabel global
        public double Gls2, EsJeruk;

        //Membuat method prosedur untuk input variabel yang diketahui
        public void JumlahEsJeruk()
        {
            Console.Write("Berapa Jumlah Yang Ingin Dipesan? ");
            Gls2 = Convert.ToDouble(Console.ReadLine());
        }

        //Membuat method fungsi untuk menghitung Harga
        public double HargaEsJeruk(double Gls2)
        {
            EsJeruk = 5000 * Gls2;
            return EsJeruk;
        }

        //Membuat method prosedur untuk menampilkan jumlah yang ingin dibeli
        public void TampilEsJeruk()
        {
            Console.WriteLine("{0} Es Jeruk Berhasil Ditambahkan Ke Keranjang ", Gls2);
            Console.ReadKey();
        }
        //Membuat method berupa fungsi untuk menghitung Harga dari data yang telah diinput
        public void HitungEsJeruk(double Gls2)
        {
            Console.Write("{0} Gelas Es Jeruk = Rp.{1}", this.Gls2, this.HargaEsJeruk(Gls2));
        }
    }
    public class MenuEsSodaGembira
    {
        //Deklarasi variabel global
        public double Gls3, EsSodaGembira;

        //Membuat method prosedur untuk input variabel yang diketahui
        public void JumlahEsSodaGembira()
        {
            Console.Write("Berapa Jumlah Yang Ingin Dipesan? ");
            Gls3 = Convert.ToDouble(Console.ReadLine());
        }

        //Membuat method fungsi untuk menghitung Harga
        public double HargaEsSodaGembira(double Gls3)
        {
            EsSodaGembira = 8000 * Gls3;
            return EsSodaGembira;
        }

        //Membuat method prosedur untuk menampilkan jumlah yang ingin dibeli
        public void TampilEsSodaGembira()
        {
            Console.WriteLine("{0} Es Soda Gembira Berhasil Ditambahkan Ke Keranjang ", Gls3);
            Console.ReadKey();
        }
        //Membuat method berupa fungsi untuk menghitung Harga dari data yang telah diinput
        public void HitungEsSodaGembira(double Gls3)
        {
            Console.Write("{0} Gelas Es Soda Gembira = Rp.{1}", this.Gls3, this.HargaEsSodaGembira(Gls3));
        }
    }
    public class MenuJusAlpukat
    {
        //Deklarasi variabel global
        public double Gls4, JusAlpukat;

        //Membuat method prosedur untuk input variabel yang diketahui
        public void JumlahJusAlpukat()
        {
            Console.Write("Berapa Jumlah Yang Ingin Dipesan? ");
            Gls4 = Convert.ToDouble(Console.ReadLine());
        }

        //Membuat method fungsi untuk menghitung Harga
        public double HargaJusAlpukat(double Gls4)
        {
            JusAlpukat = 9000 * Gls4;
            return JusAlpukat;
        }

        //Membuat method prosedur untuk menampilkan jumlah yang ingin dibeli
        public void TampilJusAlpukat()
        {
            Console.WriteLine("{0} Jus Alpukat Berhasil Ditambahkan Ke Keranjang ", Gls4);
            Console.ReadKey();
        }
        //Membuat method berupa fungsi untuk menghitung Harga dari data yang telah diinput
        public void HitungJusAlpukat(double Gls4)
        {
            Console.Write("{0} Gelas Jus Alpukat = Rp.{1}", this.Gls4, this.HargaJusAlpukat(Gls4));
        }
    }
    public class Transaksi
    {
        public double TotalBayar;
        //membuat method untuk menginput uang yang harus dibayarkan
        public void JumlahBayar()
        {
            Console.Write("\n                       Tunai  = Rp.");
            TotalBayar = Convert.ToDouble(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Nama, Kasir, IdKasir;
            int pilih;
            //Membuat pengisian data awal
            Console.WriteLine("Selamat Datang Di Warung Makan Kasih Ibu");
            Console.Write("\nMasukkan Nama Pembeli    : ");
            Nama = Convert.ToString(Console.ReadLine());
            Console.Write("Masukkan Nama Kasir      : ");
            Kasir = Convert.ToString(Console.ReadLine());
            Console.Write("Masukkan Id Kasir        : ");
            IdKasir = Convert.ToString(Console.ReadLine());
            Console.Clear();
            //Membuat singkatan agar lebih mudah dipanggil
            MenuAyamGeprek AG = new MenuAyamGeprek();
            MenuMieAyam MA = new MenuMieAyam();
            MenuBakso BKS = new MenuBakso();
            MenuNasiGorengAyam NGA = new MenuNasiGorengAyam();
            MenuAyamBakar AB = new MenuAyamBakar();
            MenuEsTehManis ETM = new MenuEsTehManis();
            MenuEsJeruk EJ = new MenuEsJeruk();
            MenuEsSodaGembira ESG = new MenuEsSodaGembira();
            MenuJusAlpukat JA = new MenuJusAlpukat();
            Transaksi T = new Transaksi();

            //Membuat Perulangan 
            do
            {
                //Membuat tampilan Menu
                Console.WriteLine("");
                Console.WriteLine("Pembeli    : {0}", Nama);
                Console.WriteLine("Kasir      : {0}", Kasir);
                Console.WriteLine("Id Kasir   : {0}", IdKasir);
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("");
                Console.WriteLine("Selamat Datang Di Warung Makan Kasih Ibu");
                Console.WriteLine("========================================");
                Console.WriteLine("Silahkan Plih Menu Yang Ingin Dipesan");
                Console.WriteLine("========================================");
                Console.WriteLine("");
                Console.WriteLine(" MENU ");
                Console.WriteLine("======");
                Console.WriteLine("1. Ayam Geprek           Rp. 15000");
                Console.WriteLine("2. Mie Ayam              Rp. 10000");
                Console.WriteLine("3. Bakso                 Rp. 12000");
                Console.WriteLine("4. Nasi Goreng Ayam      Rp. 12000");
                Console.WriteLine("5. Ayam Bakar            Rp. 16000");
                Console.WriteLine("6. Es Teh Manis          Rp. 3000");
                Console.WriteLine("7. Es Jeruk              Rp. 5000");
                Console.WriteLine("8. Es Soda Gembira       Rp. 8000");
                Console.WriteLine("9. Jus Alpukat           Rp. 9000");
                Console.WriteLine("10. Selesai");
                Console.Write("Pilih (1/2/3/4/5/6/7/8/9/10) : ");
                Console.WriteLine();
                Console.Write("Silahkan Pilih Angka Menu = ");
                pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (pilih)
                {
                    case 1:
                        AG.JumlahAyamGeprek();
                        AG.HargaAyamGeprek(AG.Prs1);
                        AG.TampilAyamGeprek();
                        break;
                    case 2:
                        MA.JumlahMieAyam();
                        MA.HargaMieAyam(MA.Prs2);
                        MA.TampilMieAyam();
                        break;
                    case 3:
                        BKS.JumlahBakso();
                        BKS.HargaBakso(BKS.Prs3);
                        BKS.TampilBakso();
                        break;
                    case 4:
                        NGA.JumlahNasgorAyam();
                        NGA.HargaNasgorAyam(NGA.Prs4);
                        NGA.TampilNasgorAyam();
                        break;
                    case 5:
                        AB.JumlahAyamBakar();
                        AB.HargaAyamBakar(AB.Prs5);
                        AB.TampilAyamBakar();
                        break;
                    case 6:
                        ETM.JumlahEsTehManis();
                        ETM.HargaEsTehManis(ETM.Gls1);
                        ETM.TampilEsTehManis();
                        break;
                    case 7:
                        EJ.JumlahEsJeruk();
                        EJ.HargaEsJeruk(EJ.Gls2);
                        EJ.TampilEsJeruk();
                        break;
                    case 8:
                        ESG.JumlahEsSodaGembira();
                        ESG.HargaEsSodaGembira(ESG.Gls3);
                        ESG.TampilEsSodaGembira();
                        break;
                    case 9:
                        JA.JumlahJusAlpukat();
                        JA.HargaJusAlpukat(JA.Gls4);
                        JA.TampilJusAlpukat();
                        break;
                    case 10:
                        Console.Write("\n                 Total Biaya  = Rp.{0}", (AG.AyamGeprek + MA.MieAyam + BKS.Bakso + NGA.NasgorAyam + AB.AyamBakar + ETM.EsTehManis + EJ.EsJeruk + ESG.EsSodaGembira + JA.JusAlpukat));
                        T.JumlahBayar();
                        Console.WriteLine("                   Kembalian  = Rp.{0} ", (T.TotalBayar) - (AG.AyamGeprek + MA.MieAyam + BKS.Bakso + NGA.NasgorAyam + AB.AyamBakar + ETM.EsTehManis + EJ.EsJeruk + ESG.EsSodaGembira + JA.JusAlpukat));
                        Console.WriteLine("==========================================");
                        Console.WriteLine("               Terima Kasih");
                        Console.WriteLine("==========================================");
                        break;
                    default:
                        Console.WriteLine("Angka Menu Tidak Tersedia!");
                        Console.WriteLine("Pilih Angka Menu Yang Tersedia!");
                        Console.ReadKey();
                        break;
                }
            }
            while (pilih < 10);
            {
                string NamaFile;
                try
                {

                    Console.Write("Nama File : ");
                    NamaFile = Console.ReadLine();
                    //deklarasi string untuk menyimpan path di drive C pada folder mydocument
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    //Lewatkan folder dan nama file ynag digunakan untuk menyimpan data di drive C
                    StreamWriter sw = new StreamWriter(Path.Combine(path, $"{NamaFile}.txt"));

                    //Masukkan Kalimat kedalam file
                    sw.WriteLine("Nama Pembeli  : {0}", Nama);
                    sw.WriteLine("Nama Kasir    : {0}", Kasir);
                    sw.WriteLine("Id Kasir      : {0}", IdKasir);
                    sw.WriteLine("Jam Transaksi : {0}", DateTime.Now);
                    sw.WriteLine("");
                    sw.WriteLine("Struk Belanja:");
                    sw.Write("\n{0} Porsi Ayam Geprek        = Rp.{1} ", AG.Prs1, AG.HargaAyamGeprek(AG.Prs1));
                    sw.Write("\n{0} Porsi Mie Ayam           = Rp.{1} ", MA.Prs2, MA.HargaMieAyam(MA.Prs2));
                    sw.Write("\n{0} Porsi Bakso              = Rp.{1} ", BKS.Prs3, BKS.HargaBakso(BKS.Prs3));
                    sw.Write("\n{0} Porsi Nasi Goreng Ayam   = Rp.{1} ", NGA.Prs4, NGA.HargaNasgorAyam(NGA.Prs4));
                    sw.Write("\n{0} Porsi Ayam Bakar         = Rp.{1} ", AB.Prs5, AB.HargaAyamBakar(AB.Prs5));
                    sw.Write("\n{0} Gelas Es Teh Manis       = Rp.{1} ", ETM.Gls1, ETM.HargaEsTehManis(ETM.Gls1));
                    sw.Write("\n{0} Gelas Es Jeruk           = Rp.{1} ", EJ.Gls2, EJ.HargaEsJeruk(EJ.Gls2));
                    sw.Write("\n{0} Gelas Es Soda Gembira    = Rp.{1} ", ESG.Gls3, ESG.HargaEsSodaGembira(ESG.Gls3));
                    sw.Write("\n{0} Gelas Jus Alpukat        = Rp.{1} ", JA.Gls4, JA.HargaJusAlpukat(JA.Gls4));
                    sw.Write("\n");
                    sw.Write("---------------------------------");
                    sw.Write("\n                   Total   = Rp.{0}", (AG.AyamGeprek + MA.MieAyam + BKS.Bakso + NGA.NasgorAyam + AB.AyamBakar + ETM.EsTehManis + EJ.EsJeruk + ESG.EsSodaGembira + JA.JusAlpukat));
                    sw.Write("\n                   Tunai   = Rp.{0}", (T.TotalBayar));
                    sw.Write("\n               Kembalian   = Rp.{0}", (T.TotalBayar) - (AG.AyamGeprek + MA.MieAyam + BKS.Bakso + NGA.NasgorAyam + AB.AyamBakar + ETM.EsTehManis + EJ.EsJeruk + ESG.EsSodaGembira + JA.JusAlpukat));
                    sw.WriteLine();
                    sw.WriteLine("==========================================");
                    sw.WriteLine("               Terima Kasih");
                    sw.WriteLine("==========================================");


                    //Menutup file
                    sw.Close();
                }

                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Nota Berhasil Dicetak.");
                }

            }
        }
    }
}