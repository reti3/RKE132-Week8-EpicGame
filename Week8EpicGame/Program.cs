//DRY principle - Do Not Repeat Yourself
string folderPath = @"/Users/reti/projects/data/";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile)); //Path.Combine - arvestab kasutaja op-systeemiga
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

//string[] heroes = {"Rayland Grace", "Captain America", "Thor", "Black Widow"}; //massiiv
//string[] villains = { "Professor Moriarty", "The Joker", "Loki", "Hannibal Lecter", "Cruella" };


string[] weapons = { "shield", "bow and arroys", "sword", "warhammer", "wand" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Today {hero} saves the day with {heroWeapon}!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Today {villain} tries to take over the world with {villainWeapon}!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}

