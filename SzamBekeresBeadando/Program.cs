using System;

namespace SzamBekeresBeadando
{
    class Program
    {
        public static int Legnagyobb(int[] tomb, out int hely)
        {
            int max = tomb[0];
            hely = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                    hely = i;
                }
            }
            
            return max;
        }

        public static int Legkisebb(int[] tomb, out int hely)
        {
            int min = tomb[0];
            hely = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                {
                    min = tomb[i];
                    hely = i;
                }
            }

            return min;
        }

        static void Main(string[] args)
        {
            string keres = "";
            int darabszam;
            do
            {
                Console.Write("Adja meg a tömb nagyságát: ");
                keres = Console.ReadLine();

                if (int.TryParse(keres, out darabszam) == false)
                {
                    Console.WriteLine("Nem szabad betűt hasznáni!!!");
                    Console.ReadLine();

                    return;
                }
            } while (int.TryParse(keres,out darabszam)== false);

            int[] szam_ker = new int[darabszam]; 
            for (int i = 0; i < szam_ker.Length; i++)
            {
                do
                {
                    Console.WriteLine("Kérem {0}. számot", i+1);
                    keres = Console.ReadLine();
                    if (int.TryParse(keres, out szam_ker[i])==false)
                    {
                        Console.WriteLine("Nem szabad betűt használni!!!");
                        Console.ReadLine();
                        return;

                    }
                } while (int.TryParse(keres, out szam_ker[i])== false);
            }

            for (int i = 0; i < szam_ker.Length; i++)
            {
                Console.WriteLine(szam_ker[i] + " ");
            }
            int helye;
            int legnagyobb = Legnagyobb(szam_ker, out helye);

            Console.WriteLine(" A legnagyobb bekért szám  {0}, a szám helye {1}",legnagyobb,helye+1);
            int legkisebb = Legkisebb(szam_ker, out helye);
            Console.WriteLine(" A legkisebb bekért szám {0}, a szám helye {1}", legkisebb,helye+1);
            Console.ReadKey();

        }
    }
    
}
