//void Star() – en metod som använder Console.SetCursorPosition, slump och Console.Write för att rita ut en stjärna (*) på en slumpad plats på konsolfönstret.

Star();

//void Typewriter(string text) – en metod som skriver ut en text, ett tecken i taget. Ledtråd: Du kommer att behöva en for-loop och Thread.Sleep.
Typewriter("Doktor Glass av Hjalmar");

//string GetYesOrNo() – en metod där användaren får skriva in "yes" eller "no". Metoden avslutas inte förrän användaren följt instruktionen. Svaret returneras.
Console.WriteLine(GetYesOrNo());

//string Obscure(string text) – en metod som tar emot en text och returnerar så många *-tecken. Så om man stoppar in ordet "variabel" så får man tillbaka ********. Stoppar man in "hej" så får man tillbaka ***.
Console.WriteLine(Obscure("Bögarnas fel"));

Console.ReadLine();




void Star()
{
    Console.SetCursorPosition(Random.Shared.Next(100), Random.Shared.Next(20));
    Console.Write("*");
}

void Typewriter(string text)
{
    foreach (char letter in text)
    {
        Console.Write(letter);
        Thread.Sleep(20);
    }
}

string GetYesOrNo()
{
    string awnser = "";
    while (awnser != "yes" && awnser != "no")
    {
        awnser = Console.ReadLine().ToLower();
    }
    return awnser;
}

string Obscure(string text)
{
    string output = "";
    foreach (char letter in text)
    {
        output += "*";
    }
    return output;
}