using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau__liste__6
{
    class Program

    {
        enum week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(string[] args)
        {
            week lun = week.Lundi;
            Console.WriteLine(lun);
            week Mar = week.Mardi;
            Console.WriteLine(Mar);
            week Mer = week.Mercredi;
            Console.WriteLine(Mer);
            week Jeu = week.Jeudi;
            Console.WriteLine(Jeu);
            week Ven = week.Vendredi;
            Console.WriteLine(Ven);
            week Sam = week.Samedi;
            Console.WriteLine(Sam);
            week Dim = week.Dimanche;
            Console.WriteLine(Dim);

            /*Correction
 foreach (int i in Enum.GetValues(typeof(week))) ----> Permet d'afficher les valeurs indices de l'énumération 0,1,2,3...
foreach (string i in Enum.GetNames(typeof(week))) // Permet d'afficher les constantes de l'énumération*/
        }
    }
}