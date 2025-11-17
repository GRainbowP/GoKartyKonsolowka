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
                int czas = Convert.ToInt32(Console.ReadLine());
                tablica[i] = czas;
            }

            int wynik = NWD(tablica[0], tablica[1]);
            wynik = NWD(wynik, tablica[2]);
            wynik = NWD(wynik, tablica[3]);

            Console.WriteLine(string.Empty);
            Console.WriteLine($"NWD podanych czasów wynosi: {wynik}");
        }

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
