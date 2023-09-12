using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class IKood
{
    public string Code { get; set; }
}

public class HospitalService
{
    public static string Haigla(string idCode)
    {
        string digits8910 = idCode.Substring(7, 3);
        int t = int.Parse(digits8910);

        if (t >= 1 && t <= 10)
        {
            return "Kuressaare haigla";
        }
        else if (t >= 11 && t <= 19)
        {
            return "Tartu Ülikooli Naistekliinik";
        }
        else if (t >= 21 && t <= 150)
        {
            return "Ida-Tallinna keskhaigla, Pelgulinna sünnitusmaja (Tallinn)";
        }
        else if (t >= 151 && t <= 160)
        {
            return "Keila haigla";
        }
        else if (t >= 161 && t <= 220)
        {
            return "Rapla haigla, Loksa haigla, Hiiumaa haigla (Kärdla)";
        }
        else if (t >= 221 && t <= 270)
        {
            return "Ida-Viru keskhaigla (Kohtla-Järve, endine Jõhvi)";
        }
        else if (t >= 271 && t <= 370)
        {
            return "Maarjamõisa kliinikum (Tartu), Jõgeva haigla";
        }
        else if (t >= 371 && t <= 420)
        {
            return "Narva haigla";
        }
        else if (t >= 421 && t <= 470)
        {
            return "Pärnu haigla";
        }
        else if (t >= 471 && t <= 490)
        {
            return "Haapsalu haigla";
        }
        else if (t >= 491 && t <= 520)
        {
            return "Järvamaa haigla (Paide)";
        }
        else if (t >= 521 && t <= 570)
        {
            return "Rakvere haigla," +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                " Tapa haigla";
        }
        else if (t >= 571 && t <= 600)
        {
            return "Valga haigla";
        }
        else if (t >= 601 && t <= 650)
        {
            return "Viljandi haigla";
        }
        else if (t >= 651 && t <= 700)
        {
            return "Lõuna-Eesti haigla (Võru), Põlva haigla";
        }
        else
        {
            return "teine ​​haigla";
        }
    }
}