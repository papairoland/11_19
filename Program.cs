namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> napiCsapadek = new List<int>
{
0,0,1,0,0,2,0,0,3,1,0,0,0,0,4,0,0,1,0,0,0,0,2,0,0,1,0,0,0,0,
1,0,0,2,0,3,0,0,0,1,0,0,0,5,0,0,0,0,0,0,0,0,1,2,0,0,0,0,4,0,
0,0,0,0,0,3,0,0,1,0,0,0,0,0,0,2,0,0,3,0,0,5,0,0,0,0,0,0,0,0,
0,0,0,1,4,0,0,0,0,0,0,7,0,0,0,0,0,0,1,0,0,0,3,0,0,0,0,0,0,0,
0,0,0,1,0,0,0,2,0,0,0,0,0,0,0,5,0,0,0,1,0,0,0,0,0,0,2,0,0,0,
0,0,0,0,0,6,0,0,0,0,3,0,0,0,0,0,10,0,0,0,0,0,12,0,0,0,0,0,8,0,
0,0,0,0,5,0,0,0,3,0,0,0,0,0,0,14,0,0,0,0,0,0,0,0,18,0,0,0,0,0,
0,2,0,0,0,0,0,0,22,0,0,0,0,3,0,0,0,0,0,0,12,0,0,0,0,0,0,0,7,0,
0,0,0,0,0,0,25,0,0,0,0,4,0,0,0,0,0,16,0,0,0,0,0,9,0,0,0,0,0,0,
3,0,0,0,0,5,0,0,0,0,0,0,15,0,0,0,0,0,8,0,0,0,0,2,0,0,0,0,0,0,
0,0,0,4,0,0,0,0,1,0,0,0,0,0,6,0,0,0,0,0,0,0,10,0,0,0,0,0,0,2,
0,0,0,0,0,0,0,0,0,0,0,8,0,0,0,0,3,0,0,0,0,0,1,0,0,0,0,0,0,0,
0,0,0,0,0,2,0,0,0,0,0,0,4,0,0,0,1,0,0,0,0,0,0,5,0,0,0,0,0,0,
0,0,0,0,0,0,0,2,0,0,0,1,0,0,0,0,0
};

            List<string> versenyzok = new List<string>
{
"Nagy-Péter","Kovács-Anna","Tóth-Gábor","Szabó-Dóra","Varga-Balázs","Kiss-Eszter","Molnár-Tamás","Németh-Kata","Horváth-László","Balogh-Zsófia",
"Papp-Máté","Farkas-Júlia","Lakatos-Dávid","Juhász-Lili","Takács-Roland","Mészáros-Vivien","Oláh-Kristóf","Simon-Laura","Rácz-Dániel","Fekete-Noémi",
"Vass-Márton","Bodnár-Kinga","Fehér-Patrik","Török-Blanka","Gulyás-Bence","Balázs-Viktória","Antal-Kristina","Fodor-Gergely","Szalai-Emese","Kelemen-Robert",
"Major-Liliána","Bognár-Attila","Pintér-Erika","Hegedűs-Kristóf","Sipos-Alexandra","Kocsis-Levente","Orosz-Eszter","Lengyel-Kristóf","Szűcs-Ágnes","Pál-Gábor",
"Vincze-Lilla","Vörös-Dávid","Király-Laura","Tóth-Miklós","Jakab-Zita","Lukács-Márk","Kovács-Viktor","Varga-Rebeka","Kiss-Zoltán","Szabó-Nóra",
"Horváth-Kristóf","Molnár-Dorina","Balogh-Levente","Papp-Emma","Nagy-Gergely","Németh-Vivien","Takács-Márk","Farkas-Luca","Juhász-Tamás","Vass-Klaudia",
"Fehér-Gábor","Török-Anna","Gulyás-Dóra","Balázs-Máté","Antal-Kitti","Fodor-Balázs","Szalai-Noémi","Kelemen-Máté","Major-Petra","Bognár-Dániel",
"Pintér-Laura","Hegedűs-Ádám","Sipos-Vivien","Kocsis-Norbert","Orosz-Kata","Lengyel-Bence","Szűcs-Lili","Pál-Márk","Vincze-Ádám","Vörös-Rebeka",
"Király-Gergő","Tóth-Klaudia","Jakab-Márton","Lukács-Dóra","Kovács-Gábor","Varga-Lilla","Kiss-Dániel","Szabó-Petra","Horváth-Balázs","Molnár-Noémi",
"Balogh-Zoltán","Papp-Jázmin","Nagy-László","Németh-Klaudia","Takács-Gergely","Farkas-Nóra","Juhász-Márk","Vass-Dorina","Fehér-Levente","Török-Gábor",
"Gulyás-Laura","Balázs-Kristóf","Antal-Eszter","Fodor-Patrik","Szalai-Emma","Kelemen-Dániel","Major-Zsófia","Bognár-Kristóf","Pintér-Dóra","Hegedűs-Lili",
"Sipos-Márton","Kocsis-Ágnes","Orosz-Vivien","Lengyel-Dorina","Szűcs-Gergő","Pál-Kinga","Vincze-Tamás","Vörös-Laura","Király-Zsombor","Tóth-Dorina",
"Jakab-Gergely","Lukács-Kata","Kovács-Bence","Varga-Jázmin","Kiss-Márton","Szabó-Lilla","Horváth-Dávid","Molnár-Rebeka","Balogh-Kristina","Papp-Kristóf",
"Nagy-Liliána","Németh-Márk","Takács-Dóra","Farkas-Zoltán","Juhász-Vivien","Vass-Miklós","Fehér-Dóra","Török-Máté","Gulyás-Zsófia","Balázs-Levente",
"Antal-Luca","Fodor-Dániel","Szalai-Balázs","Kelemen-Klaudia","Major-Gábor","Bognár-Lili","Pintér-Gergő","Hegedűs-Laura","Sipos-Zoltán","Kocsis-Vivien",
"Orosz-Dániel","Lengyel-Eszter","Szűcs-Tamás","Pál-Emma","Vincze-Márton","Vörös-Nóra","Király-Ádám","Tóth-Kinga","Jakab-Balázs","Lukács-Eszter"
};

            List<double> maxHofok = new List<double>
{
29.1, 28.4, 27.8, 27.2, 26.5, 25.9, 26.0, 25.3, 24.8, 25.1,
24.4, 23.7, 23.2, 22.8, 21.9, 22.3, 21.5, 20.8, 20.2, 19.7,
20.1, 19.4, 18.8, 18.1, 17.6, 17.3, 16.9, 16.1, 15.8, 15.2
};

            List<String> diakok = new List<String>() {
                "Balogh Zsombor",
                "Sopronyi Zoltán",
                "Hőgye Dominik",
                "Kelemen Marcell",
                "Máté Patrik",
                "Körtvélyessi Benedek",
                "Szabó Zoltán",
                "Turóczi Dávid",
                "Nagy Balázs",
                "Csahóczi Máté Benedek",
                "Tasnádi Attila",
                "Tarsoly Levente Ákos",
                "Vas Bence",
                "Tóth Martin",
                "Macz Enikő",
                "Kiss Gergő",
                "Balogh Endre",
                "Mozsár Máté",
                "Félegyházi Gergő",
                "Pápai Sándor",
                "Orosz Levente",
                "Kovács Ákos",
                "Bodnár Petra",
                "Mercs Alex",
                "Sztrik Márton",
                "Gellén Csaba Kálmán",
                "Barta Ernő Péter",
                "Bányai Gábor",
                "Kis Ábel",
                "Kiss Gergely",
                "Hajdú Bettina",
                "Bereczki István",
                "Moldován Adrián"
            };

            //1) Hány olyan nap volt, amikor 20 fok feletti hőmérsékletet mértek? (2p)
            byte huszfokfelett = 0;
            for (int i = 0; i < maxHofok.Count(); i++)
            {
                if (maxHofok[i] > 20)
                {
                    huszfokfelett++;
                }
            }
            Console.WriteLine(huszfokfelett.ToString());

            //7) Készítsen egy új listát aligesett néven, amely a 3mm alatti csapadékértékeket tartalmazza. (3p)
            List<int> aligesett = new();
            for (int i = 0; i < napiCsapadek.Count(); i++)
            {
                if (napiCsapadek[i] < 3)
                {
                    aligesett.Add(napiCsapadek[i]);
                }
            }

            //11) Listázza ki azoknak a versenyzőknek a nevét, akik keresztneve [Dávid] (4p)
            for (int i = 0; i < versenyzok.Count(); i++)
            {
                if (versenyzok[i].EndsWith("Dávid"))
                {
                    Console.WriteLine(versenyzok[i]);
                }
            }

            //12) Mekkora volt a legnagyobb hőmérsékletkülönbség a mérések között? (2p)
            double legkisebb = maxHofok[0];
            double legnagyobb = maxHofok[0];
            for (int i = 0; i < maxHofok.Count(); i++)
            {
                if (maxHofok[i] > legnagyobb)
                {
                    legnagyobb = maxHofok[i];
                }
                if (maxHofok[i] < legkisebb)
                {
                    legkisebb = maxHofok[i];
                }
            }

            //15) Van-e a versenyzők között „Szuper Béla” nevű induló? (2p)
            if (versenyzok.Contains("Szuper Béla"))
            {
                Console.WriteLine("van");
            }
            else
            {
                Console.WriteLine("nincs");
            }

            //16) Az év melyik napján (sorszám) esett utoljára 30mm feletti csapadék? (3p)
            int sorszam = 0;
            for (int i = 0; i < napiCsapadek.Count(); i++)
            {
                if (napiCsapadek[i] > 30)
                {
                    sorszam = napiCsapadek.IndexOf(napiCsapadek[i]);
                }
            }
            if (sorszam == 0)
            {
                Console.WriteLine("nem volt ilyen nap");
            }
        }
    }
}