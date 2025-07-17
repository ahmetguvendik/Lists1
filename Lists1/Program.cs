List<string> guests = new List<string>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Davetli Giriniz");
    guests.Add(Console.ReadLine()); 
}

int counter = 1;

foreach (var item in guests)
{
    Console.WriteLine("Davetliler");
    Console.WriteLine($"{counter} ) {item}");
    counter++;
}