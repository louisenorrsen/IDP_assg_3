namespace IDP_assg_3
{
    internal class Program
    {
        class Grundämne
        {
            public string namn = string.Empty, typ = string.Empty;
            public int Z;
            public double smältpunkt, kokpunkt;

            public void Print()
            {
                Console.WriteLine($"Grundämne: {namn}");
                Console.WriteLine($"   Typ: {typ}");
                Console.WriteLine($"   Smältpunkt: {smältpunkt} K");
                Console.WriteLine($"   Kokpunkt: {kokpunkt} K\n");
            }
        }
        static void Main(string[] args)
        {
            Grundämne syre = new()
            {
                namn = "Syre",
                Z = 8,
                typ = "ickemetall",
                smältpunkt = 54.36,
                kokpunkt = 90.188
            };
            Grundämne järn = new()
            {
                namn = "Järn",
                Z = 26,
                typ = "metall",
                smältpunkt = 1811,
                kokpunkt = 3134
            };
            Grundämne guld = new()
            {
                namn = "Guld",
                Z = 79,
                typ = "metall",
                smältpunkt = 1337.33,
                kokpunkt = 3243
            };

            //syre.Print();
            //järn.Print();
            //guld.Print();

            Grundämne[] ämnen = new Grundämne[6]
            {
                syre,
                järn,
                guld,
                new()
                {
                    namn = "Väte",
                    Z = 1,
                    typ = "ickemetall",
                    smältpunkt = 13.99,
                    kokpunkt = 20.271
                },
                new()
                {
                    namn = "Brom",
                    Z = 35,
                    typ = "ickemetall",
                    smältpunkt = 265.8,
                    kokpunkt = 332.0
                },
                new()
                {
                    namn = "Kvicksilver",
                    Z = 80,
                    typ = "metall",
                    smältpunkt = 234.3210,
                    kokpunkt = 629.88
                }
            };
            Console.WriteLine("-------- ALLA GRUNDÄMNEN --------");
            foreach (Grundämne grundämne in ämnen)
            {
                grundämne.Print();
            }
            Console.WriteLine("----------- METALLER ------------");
            foreach (Grundämne grundämne in ämnen)
            {
                if (grundämne.typ == "metall") Console.WriteLine(grundämne.namn);
            }
        }
    }
}