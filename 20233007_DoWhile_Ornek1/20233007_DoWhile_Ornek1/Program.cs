using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20233007_DoWhile_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userName = "ahmet", password = "123456";

            //Kullanıcı adı ve şifre doğru girildikten sonra giriş başarılı denecek
            //Eğer yanlış giriş yapılırsa 'yanlış kullanıcı adı veya şifre' uyarısı verilecek
            bool girisYapildiMi=false;
            do
            {
                Console.Write("Kullanıcı Adı : ");
                string kAdi = Console.ReadLine();
                Console.Write("Şifre : ");
                string sifre=Console.ReadLine();

                if (userName==kAdi&&password==sifre)
                {
                    girisYapildiMi = true;
                }
                if (!girisYapildiMi)
                {
                    Console.WriteLine("Yanlış kullanıcı adı veya şifre");
                }

            } while (!girisYapildiMi);
            Console.WriteLine("Giriş İşlemi Başarılı");
            Console.ReadKey();
        }
    }
}
