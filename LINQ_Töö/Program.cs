

namespace LINQ_Töö 
{
    //5. Võta hinnalt järjestatud toodetest seni, kuni hind on alla 100€(take while)
    //6. Leia esimene toode kategooriast "Elektroonika"(FirstOrDefault)
    //7. Arvuta toodete ksekmine hind, Leia kõige kallim toode, ja loenda mitu toodet kuulub kategooriase "Valige ise kategooria(Average, count, sum, max, min)
    //8. Kontrolli, kas mõni toode maksab üle 500€ (All, any)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1.");
            Console.WriteLine("Vali vastav LINQ numbriga");
            Console.WriteLine("1. Hinna otsimine");
            Console.WriteLine("2. Klientide sortimine linna järgi");
            Console.WriteLine("3. Toodete nime välja toomine");
            Console.WriteLine("4. Andmete vahelejätmine");
            Console.WriteLine("5. Tooted mis on üle 100€");
            Console.WriteLine("6. Valib mingist kategooriast esimese toote");
            Console.WriteLine("7. Arvutab toote keskmise, kallima hinna ja loendab mitu toodet kuulub valitud kategooriasse");
            Console.WriteLine("8. Toote maksumuse kontroll");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    HinnaLINQ();
                    break;

                case 2:
                    LinnanimeLINQ();
                    break;
                case 3:
                    ToodeLINQ();
                    break;
                case 4:
                    vahelejätmineLINQ();
                    break;
                case 5:
                    Kuni100euriLINQ();
                    break;
                case 6:
                    KategoorilineLINQ();
                    break;
                case 7:
                    TootehinnaarvutamineLINQ();
                    break;
                case 8:
                    TootehinnamaksumusLINQ();
                    break;
                default:
                    Console.WriteLine("Sellist meetodit veel ei ole");
                    break;
            }


            
        }// 1.
        public static void HinnaLINQ()
        {
            var productPrice = ProductData.products
                .Where(x => x.Price > 50); //where teeb mingi konkreetse päringu, mis vastab mingitele tingimustele

            foreach (var product in productPrice)
            {
                Console.WriteLine(product.Price);
            }
        }// 2.
        public static void LinnanimeLINQ()
        {
            var linnad = ClientData.clients
               .OrderBy(x => x.City);//teeb mingi konkreetse päringu, mis reastab andmed


            foreach (var linn in linnad)
            {
                Console.WriteLine(linn.City);
            }

            var nimed = ClientData.clients
                .OrderBy(x => x.Name);
            foreach (var nimi in nimed)
            {
                Console.WriteLine(nimi.Name);
            }

        }// 3.
        public static void ToodeLINQ()
        {
            var tooted = ProductData.products
           .Select(x => new//teeb mingi konkreetse päringu, mis väljastab teatud andmed
           {
               Name = x.Name
           });
            foreach (var toode in tooted)
            {
                Console.WriteLine(toode.Name);
            }

        }// 4.
        public static void vahelejätmineLINQ()
        {
            var toode2 = ProductData.products
                .OrderBy(x => x.Price)
                .Skip(3); //jätab vahele teatud arvu andmeid
            foreach (var product in toode2)
            {
                Console.WriteLine(product.Name);
            }
        }  //5. Võta hinnalt järjestatud toodetest seni, kuni hind on alla 100€(take while)
        public static void Kuni100euriLINQ()
        {
            var järjestus = ProductData.products
                .TakeWhile(x => x.Price < 100); //võtab andmeid kuniks mingi konkreetne asi on täidetud
            foreach (var hinnad in järjestus)
            {
                
                Console.WriteLine(hinnad.Price);
            }
        } //6. Leia esimene toode kategooriast "Elektroonika"(FirstOrDefault)
        public static void KategoorilineLINQ()
        {
            var kategooria = ProductData.products
            .FirstOrDefault(x => x.Category == "Kodutoode"); //tagastab elemendi mis vajatud on
            
          
            
        }//7. Arvuta toodete keskmine hind, Leia kõige kallim toode, ja loenda mitu toodet kuulub kategooriase "Valige ise kategooria(Average, count, sum, max, min)
        public static void TootehinnaarvutamineLINQ()
        {
            var toode3 = ProductData.products
                .Average(x => x.Price); // leaiab keskmise arvu mingitest andmetest
            

        }//8. Kontrolli, kas mõni toode maksab üle 500€ (All, any)
        public static void TootehinnamaksumusLINQ()
        {
            var toode4 = ProductData.products
                .All(x => x.Price > 500); // vaatab kas andmed on mingis teatud vahemikus ja tagastab selle
                
            
        }
        
    }
}
