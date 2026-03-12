class Program
{
    static void Main(string[] args) 
    {
     Console.WriteLine("Podaj liczby całkowite oddzielone spacją:");
     string input = Console.ReadLine();
     string[] parts = input.Split(' ');
     int[] liczby = new int[parts.Length];
     for (int i = 0; i < parts.Length; i++)
     {
         liczby[i] = int.Parse(parts[i]);
     }
     
     
    }
}

