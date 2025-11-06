int counter = 0;
Console.Write("Geef je gebruikersnaam in: ");
string username = Console.ReadLine();
Console.Write("Geef je wachtwoord in: ");
string password = Console.ReadLine();
while(counter < 3 || (username != "jef" && password != "wachtwoord"))
{
    Console.WriteLine("Foutieve login. Probeer opnieuw.");
    Console.Write("Geef je gebruikersnaam in: ");
    username = Console.ReadLine();
    Console.Write("Geef je wachtwoord in: ");
    password = Console.ReadLine();
    counter++;
}
Console.ReadKey();
