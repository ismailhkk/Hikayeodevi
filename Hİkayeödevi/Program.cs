namespace Hİkayeödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evinizde otururken elektrikler bir anda kesildi. Durumu kontrol etmek için pencereden dışarı bakmaya karar veriyorsunuz.");
            Console.WriteLine("1. Pencereden dışarı bakmaya karar veriyorsunuz.");
            Console.WriteLine("2. Etrafı aydınlatmak için el fenerinizi alıp etrafı kontrol etmeye karar veriyorsunuz.");

            string cevap = Console.ReadLine();
            Console.WriteLine();

            if (cevap == "1")
            {
                Console.WriteLine("Pencereden dışarıya baktığınızda, tüm mahallede elektriklerin kesik olduğunu ve sokak lambalarının da yanmadığını görüyorsunuz. Ne yapacaksınız?");
                Console.WriteLine("   a) Komşularınızın durumu hakkında bilgi almak için dışarı çıkıyorsunuz.");
                Console.WriteLine("   b) Güvenliği sağlamak için evinizde kalıp ışığın gelmesini bekliyorsunuz.");

                string ikinciCevap = Console.ReadLine();
                Console.WriteLine();

                if (ikinciCevap == "a")
                {
                    Console.WriteLine("Dışarıya çıktığınızda, mahallenizdeki diğer insanların da aynı durumla karşı karşıya olduğunu görüyorsunuz. Ne yapacaksınız?");
                    Console.WriteLine("   a) Mahalledeki insanlarla iletişim kurmaya ve durumu çözmeye çalışacaksınız.");
                    Console.WriteLine("   b) Eve geri dönüp beklemeye devam edeceksiniz.");

                    string ucuncuCevap = Console.ReadLine();
                    Console.WriteLine();

                    if (ucuncuCevap == "a")
                    {
                        Console.WriteLine("Mahalledeki diğer insanlarla iletişim kurduğunuzda, bir trafo patlaması sonucu elektriklerin kesildiğini öğreniyorsunuz. Hep birlikte durumu çözmek için bir araya gelmeye karar veriyorsunuz.");
                    }
                    else if (ucuncuCevap == "b")
                    {
                        Console.WriteLine("Eve geri dönüp beklemeye devam ederken, elektriklerin gelmesini sabırla bekliyorsunuz.");
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir seçenek girmediniz. Lütfen a veya b seçeneklerinden birini seçin.");
                    }
                }
                else if (ikinciCevap == "b")
                {
                    Console.WriteLine("Evinizde kalıp ışığın gelmesini beklerken, dışarıda tuhaf sesler duymaya başlıyorsunuz. Ne yapacaksınız?");
                    Console.WriteLine("   a) Dışarıya çıkıp tuhaf seslerin kaynağını araştırmaya çalışacaksınız.");
                    Console.WriteLine("   b) Güvenliği sağlamak için evinizde kalacaksınız.");

                    string ucuncuCevap = Console.ReadLine();
                    Console.WriteLine();

                    if (ucuncuCevap == "b")
                    {
                        Console.WriteLine("Dışarıya çıktığınızda, mahallenizdeki diğer insanların da aynı durumla karşı karşıya olduğunu görüyorsunuz. Hep birlikte durumu çözmek için bir araya gelmeye karar veriyorsunuz.");
                    }
                    else if (ucuncuCevap == "b")
                    {
                        Console.WriteLine("Güvenliği sağlamak için evinizde kalıyorsunuz ve ışığın gelmesini beklemeye devam ediyorsunuz.");
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir seçenek girmediniz. Lütfen 'a' veya 'b' seçeneklerinden birini seçin.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli bir seçenek girmediniz. Lütfen 'a' veya 'b' seçeneklerinden birini seçin.");
                }
            }
            else if (cevap == "2")
            {
                Console.WriteLine("El fenerinizi alarak etrafa ışık tutmaya başladığınızda, odanın karşısında birisi olduğunu farkediyorsunuz. Ne yapacaksınız?");
                Console.WriteLine("   a) Yaklaşarak kim olduğunu öğrenmeye çalışacağınız.");
                Console.WriteLine("   b) Evinizi terk ederek komşularınızın yanına gitmeye karar veriyorsunuz.");

                string ikinciCevap = Console.ReadLine();
                Console.WriteLine();

                if (ikinciCevap == "a")
                {
                    Console.WriteLine("Yaklaştığınızda, karşıdakinin ailenizden biri olduğunu farkediyorsunuz. Ancak neden burada olduğunu anlamıyorsunuz ama ailenizden birini görünce güvende olduğunuzu hissedip eve geri dönüyorsun.");
                }
                else if(ikinciCevap == "b") 
                {
                    Console.WriteLine("Komşularının yanına giderek herhangi bir soun olmadığını anlıyorsun ve komşularınla bu durumu tartışıp güvenli bir şekilde eve dönüyorsun.");
                }
                else
                {
                    Console.WriteLine("Geçerli bir seçenek girmediniz. Lütfen 'a' veya 'b' seçeneklerinden birini seçin.");
                }
            }
        }
    }
}

