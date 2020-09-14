using System;

namespace ExtraUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();

            string fråga1 = Console.ReadLine();

            if (fråga1 == "gå till parken")
            {
                Console.WriteLine("vad kul att du ville gå till parken, där kan vi bada i fontänen eller lukta på häst bajs. Vad föredrar du?");



                string fråga2 = Console.ReadLine();

                if (fråga2 == "bada i fontänen")
                {
                    Console.WriteLine("Jag har tydligen glömt badkläder så jag kan inte bada, vill du ändå bada?");
                }
                else if (fråga2 == "lukta på hästbajs")
                {
                    Console.WriteLine("Okej, men då går jag hem.");
                }



                string fråga3 = Console.ReadLine();

                if (fråga3 == "ja")
                {
                    Console.WriteLine("Okej, då då kan jag passa på att sola under tiden du badar");
                }
                else if (fråga3 == "nej")
                {
                    Console.WriteLine("Då kan vi i alla fall köpa glass med tanke på att vi är så nära affären, äter du pinnglass eller strutglass");
                }



                string fråga6 = Console.ReadLine();

                if (fråga6 == "pinnglass")
                {
                    Console.WriteLine("Okej, men då köper vi var sin pinnglass och sedan går vi hem");
                }
                else if (fråga6 == "strutglass")
                {
                    Console.WriteLine("Okej, men då köper vi var sin strutglass och sedan går vi hem");
                }

                Console.ReadLine();





            }
            else if (fråga1 == "äta")
            {
                Console.WriteLine("Tur att du ville äta, jag är super hungrig. Vill du äta hamburgare eller korv?");
            }



            string fråga4 = Console.ReadLine();

            if (fråga4 == "hamburgare")
            {
                Console.WriteLine("Det var så längde sedan jag käkade de, föredrar du kött eller kyckling?");
            }
            else if (fråga4 == "korv")
            {
                Console.WriteLine("Okej, vill du åka till Ikea eller Biltema?");
            }


            string fråga7 = Console.ReadLine();

            if (fråga7 == "kött")
            {
                Console.WriteLine("Då tar vi var sin hamburgare och går hem");
            }
            else if (fråga7 == "kyckling")
            {
                Console.WriteLine("Då tar vi var sin kycklingburgare och går hem");
            }



            string fråga5 = Console.ReadLine();

            if (fråga5 == "Biltema")
            {
                Console.WriteLine("Okej, men då äter vi på Biltema och sen åker vi hem!");
            }



            else if (fråga5 == "Ikea")
            {
                Console.WriteLine("Okej, men då äter vi på Ikea och sen åker vi hem!");
            }

            Console.ReadLine();














        }

        private static void Welcome()
        {
            Console.WriteLine("Hej och välkommen till min by, idag ska vi ha super roligt!");

            Console.WriteLine("vill du börja med att gå till parken eller vill du äta något först?");
        }
    }
}
