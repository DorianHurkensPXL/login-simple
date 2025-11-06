Console.WriteLine("Geef je gebruikersnaam in: ");
string username = Console.ReadLine();
Console.WriteLine("Geef je wachtwoord in: ");
string password = Console.ReadLine();
if (username == "jef" && password == "wachtwoord")
{
    Console.WriteLine("Welkom Jef.");
}
else
{
    Console.WriteLine("Foutieve login.");
}
    Console.ReadKey();
