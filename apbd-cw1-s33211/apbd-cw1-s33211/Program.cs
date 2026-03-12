using apbd_cw1_s33211;

class Program
{
    static void Main(string[] args) 
    {
        try
        {
            Console.WriteLine("Podaj liczby całkowite oddzielone spacją:");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Błąd: Nie podano żadnych liczb.");
                return;
            }

            string[] parts = input.Split(' ');
            int[] liczbyArray = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                liczbyArray[i] = int.Parse(parts[i]);
            }

            Console.WriteLine("Liczby: " + string.Join(", ", liczbyArray));
            
            Console.WriteLine("Statystyki listy: Średnia - " + StatisticsHelper.CalculateAverage(liczbyArray) + ", Największa wartość" + StatisticsHelper.Max(liczbyArray));
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd: wpisano coś co nie jest liczbą całkowitą.");
        }
    }
}

