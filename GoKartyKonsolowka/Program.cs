namespace GoKartyKonsolowka
{
    internal class Program
    {
        static int[] tablica = new int[4];
        static void Main(string[] args)
        {
            Console.WriteLine("Czasy podawaj w sekundach!");
            Console.WriteLine(string.Empty);

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Podaj czas użytkownika {i+1}: ");
                string odp = Console.ReadLine();
                if(!odp.All(char.IsNumber))
                {
                    Console.WriteLine("Podana wartość nie jest liczbą całkowitą!");
                    break;
                }
                int czas = Convert.ToInt32(odp);
                tablica[i] = czas;
            }

            int wynik = NWD(tablica[0], tablica[1]);
            wynik = NWD(wynik, tablica[2]);
            wynik = NWD(wynik, tablica[3]);

            Console.WriteLine(string.Empty);
            Console.WriteLine($"NWD podanych czasów wynosi: {wynik}");
        }

        //**************************
        //nazwa funkcji: NWD
        //opis funkcji: bierze największy wspólny dzielnik z dwóch wartości
        //parametry: a - pierwsza liczba całkowita
        //           b - druga liczba całkowita
        //zwracany typ i opis: int - największy wspólny dzielnik dwóch liczb
        //autor: Paweł
        //**************************
        static int NWD(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                    a = a - b;
                else if(b > a)
                    b = b - a;
            }
            return a;
        }
    }
}
