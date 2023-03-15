string folderPath = @"D:\data\";
string heroFile = "heroes.txt";
string villianFile = "villians.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villians = File.ReadAllLines(Path.Combine(folderPath, villianFile));

//string[] heroes = { "Harry Potter", "Gumball", "Lara Croft", "Scooby-Doo" };
//string[] villians = { "Voldemort", "Joker", "Sauron", "Dracula", "Haruna" };


string[] weapon = { "Magic", "Stic", "sword", "water", "apple" };


//Random rnd = new Random();
//int randomIndex = rnd.Next(0, heroes.Length);

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villian = GetRandomValueFromArray(villians);
string villianWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villian} with {villianWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}


