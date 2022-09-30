using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonlar_listIçerisindeNesneOluşturma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "ümit";
            kullanıcı1.Soyisim = "özdağ";
            kullanıcı1.Yas = 61;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim="recep tayyip";
            kullanıcı2.Soyisim = "erdoğan";
            kullanıcı2.Yas = 68;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);


            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar(){
                Isim="MANSUR",
                Soyisim="YAVAŞ",
                Yas=67
            } );

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("kullanıcı adı:"+kullanıcı.Isim);
                Console.WriteLine("kullanıcı soyadı:"+kullanıcı.Soyisim);
                Console.WriteLine("kullanıcı yaşı:"+kullanıcı.Yas);
                Console.WriteLine(" ");
            }


            Console.ReadLine();




        }
    }




    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
