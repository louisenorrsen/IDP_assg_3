namespace IDP_assg_3
{
    internal class Program
    {
        class Grundämne
        {
            public string namn = string.Empty, typ=string.Empty;
            public int Z;
            public double smältpunkt, kokpunkt;
        }
        static void Main(string[] args)
        {
            Grundämne syre = new()
            {
                namn = "syre",
                Z = 8,
                typ = "ickemetall",
                smältpunkt = 54.36,
                kokpunkt = 90.188
            };
            Grundämne järn = new()
            {
                namn = "järn",
                Z = 26,
                typ = "metall",
                smältpunkt = 1811,
                kokpunkt = 3134
            }; 
            Grundämne guld = new()
            {
                namn = "guld",
                Z = 79,
                typ = "metall",
                smältpunkt = 1337.33,
                kokpunkt = 3243
            };
        }
    }
}