namespace cKamp1
{
    class Program
    {
        static void Main(string[] args)
        {
        Kurs kurs1 = new Kurs();
        kurs1.kursAdi = "C#";
        kurs1.izlenmeOranı = 55.8;
        kurs1.kursEgitmeni = "Engin Demirog";

        Kurs kurs2 = new Kurs();
        kurs2.kursAdi = "Java";
        kurs2.izlenmeOranı = 10;
        kurs2.kursEgitmeni = "Murat Yucedag";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı" + ":" + kurs.kursAdi);
                Console.WriteLine("Izlenme Oranı"+":"+kurs.izlenmeOranı);
                Console.WriteLine("Kurs Egitmeni" + ":" + kurs.kursEgitmeni);
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine("-------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(kurs1);
            sepetManager.Ekle(kurs2);
            





        }
    }

    
}