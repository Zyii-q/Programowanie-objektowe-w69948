//Zadanie 1

//            Console.WriteLine("Podaj liczbę");
//            var input = Console.ReadLine();

//            if (int.TryParse(input, out int liczba))
//            {
//                if (liczba % 2 == 0)
//                {
//                    Console.WriteLine("Parzysta");
//                }
//                else
//                {
//                 Console.WriteLine("Nieparzysta");
//                }
//            }


//Zadanie 2


Console.WriteLine("Podaj liczbę, od której wypisze wszystkie parzyste liczby od 1 do tej liczby");

    int N = int.Parse(Console.ReadLine());

    Console.WriteLine($"Parzyste liczby od 1 do {N}:");
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0);
        {
            Console.WriteLine(i);
        }
    }