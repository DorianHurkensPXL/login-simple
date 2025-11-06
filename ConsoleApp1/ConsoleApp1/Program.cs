int counter = 1;
bool login = false;
string adminUser = "jef";
string adminPassword = "wachtwoord";
Console.Write("Geef je gebruikersnaam in: ");
string username = Console.ReadLine();
Console.Write("Geef je wachtwoord in: ");
string password = Console.ReadLine();
if (username == "jef" && password == "wachtwoord")
{
    login = true;
}
while (counter < 3 && login == false)
{
    Console.WriteLine($"Foutieve login. Probeer opnieuw. Nog {3 - counter} pogingen over.");
    Console.Write("Geef je gebruikersnaam in: ");
    username = Console.ReadLine();
    Console.Write("Geef je wachtwoord in: ");
    password = Console.ReadLine();
    if (username == "jef" && password == "wachtwoord")
    {
        login = true;
    }
    counter++;
}
if (login == false)
{
    Console.WriteLine("3 foute pogingen, sluit de app af.");
}
else { Console.WriteLine("Welkom Jef"); }
Console.ReadKey();
