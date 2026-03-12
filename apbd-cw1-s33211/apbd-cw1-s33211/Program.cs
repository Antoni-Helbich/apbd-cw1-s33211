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
            int[] liczby = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                liczby[i] = int.Parse(parts[i]);
            }

            Console.WriteLine("Liczby: " + string.Join(", ", liczby));
            
            Console.WriteLine("Średnia i największa liczba z podanej listy: " + StatisticsHelper.CalculateAverage(liczby) + ", " + StatisticsHelper.Max(liczby));
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd: wpisano coś co nie jest liczbą całkowitą.");
        }
    }
}

