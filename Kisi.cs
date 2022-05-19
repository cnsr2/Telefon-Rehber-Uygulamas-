using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antrenmanlar2
{
    public class Kisi
    {
        public string Name;
        public string Surname;
        public string PhoNumber;
        public string Id;
        public string _Name { get => Name; set => Name = value; }
        public string _SurName { get => Surname; set => Surname = value; }
        public string _PhoNumber { get => PhoNumber; set => PhoNumber = value; }
        public string _Id { get => Id; set => Id = value; }
        public Kisi()
        {

        }
        public Kisi KisiYarat()
        {
            Console.WriteLine("Lütfen İsim Giriniz :");
            Kisi yeniKisi = new Kisi();
            yeniKisi.Name = Console.ReadLine();
            Console.WriteLine("Lütfen Soyisim Giriniz :");
            yeniKisi.Surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            yeniKisi.PhoNumber = Console.ReadLine();
            Console.WriteLine("Kişi Kaydedildi");
            Console.WriteLine("Kişi Bilgileri: İsim : {0} Soyad : {1} Numara : {2}", yeniKisi.Name, yeniKisi.Surname, yeniKisi.PhoNumber);
            return yeniKisi;
        }
    }
}
