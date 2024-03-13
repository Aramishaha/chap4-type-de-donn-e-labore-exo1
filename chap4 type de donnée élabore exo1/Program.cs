using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap4_type_de_donnée_élabore_exo1
{
    class Program
    {
        static void Init (ref Eleve unEleve, string unNom, string unPrenom, double[]Notes) 
        {
            unEleve.nom = unNom;
            unEleve.prenom = unPrenom;
            unEleve.note = Notes;

        }
        
        public struct Eleve
        {
            public string nom;
            public string prenom;
            public double[] note;
        }
        static void Main(string[] args)
        {
            
                Console.WriteLine(" Menu : \n" +
                    " \n" +
                    "Taper 1 pour ajouter un élève : \n"
                    + " \n" +
                    "Taper 2 pour afficher l'ensemble des élèves avec la moyenne de leurs notes : \n" +
                    " \n"
                    + " Taper 3 pour afficher la moyenne de la classe entière , la note la plus basse et la note la plus haute : \n");

            



            Eleve[] lesEleves = new Eleve[5]; 
            
            Eleve eleve1 = new Eleve();
            
            Console.WriteLine(" Entrez le nom de l'élève 1 : ");
            string nom = Console.ReadLine();
            Console.WriteLine(" Entrez le prénom de l'élève 1 : ");
            string prenom = Console.ReadLine();  
            double[] notes = new double[5]  ;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Entrez une note  : ");
                notes[i] = int.Parse(Console.ReadLine());
            }

            Init(ref eleve1, nom, prenom, notes);


            lesEleves[0] = eleve1;
          

            Eleve eleve2 = new Eleve();

            Console.WriteLine(" Entrez le nom de l'élève 2 : ");
            nom = Console.ReadLine();
            Console.WriteLine(" Entrez le prénom de l'élève 2 : ");
            prenom = Console.ReadLine();
            notes= new double[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Entrez une note  : ");
                notes[i] = int.Parse(Console.ReadLine());
            }

            Init(ref eleve2, nom, prenom, notes);

            lesEleves[1] = eleve2;

            Eleve eleve3 = new Eleve();

            Console.WriteLine(" Entrez le nom de l'élève 3 : ");
            nom = Console.ReadLine();
            Console.WriteLine(" Entrez le prénom de l'élève 3 : ");
            prenom = Console.ReadLine();
            notes= new double[5] ;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Entrez une note  : ");
                notes[i] = int.Parse(Console.ReadLine());
            }

            Init(ref eleve3, nom, prenom, notes);

            lesEleves[2] = eleve3;

            Eleve eleve4 = new Eleve();

            Console.WriteLine(" Entrez le nom de l'élève 4 : ");
            nom = Console.ReadLine();
            Console.WriteLine(" Entrez le prénom de l'élève 4 : ");
            prenom = Console.ReadLine();
            notes= new double[5] ;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Entrez une note  : ");
                notes[i] = int.Parse(Console.ReadLine());
            }

            Init(ref eleve4, nom, prenom, notes);

            lesEleves[3] = eleve4;

            Eleve eleve5 = new Eleve();

            Console.WriteLine(" Entrez le nom de l'élève 5 : ");
            nom = Console.ReadLine();
            Console.WriteLine(" Entrez le prénom de l'élève 5 : ");
            prenom = Console.ReadLine();
            notes= new double[5]  ;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Entrez une note  : ");
                notes[i] = int.Parse(Console.ReadLine());
            }


            Init(ref eleve5, nom, prenom, notes);

            lesEleves[4] = eleve5;

            Console.Clear();

            Console.WriteLine(" Voici l'ensemble des élèves et leurs notes : \n" );

            foreach (Eleve eleve in lesEleves  )
            {
                Console.WriteLine(eleve.prenom + " " + eleve.nom + " \n");
                
                foreach(double noteeleve in eleve.note) 
                {
                    Console.WriteLine( noteeleve );

                }
            }
            Console.ReadKey();
   


        }
    }
}
