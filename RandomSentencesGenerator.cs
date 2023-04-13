// See https://aka.ms/new-console-template for more information

string[] names = { "Peter", "Marco", "Nicolas", "Ivan", "George", "Steven", "Sofia", "Victoria", "Maria", "Nicole", "Emily", "Yana" };
string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas", "Bansko", "Borovets", "Hawaii" };
string[] verbs = { "plays with", "sees", "catch", "watch", "eats", "brings", "call" };
string[] nouns = { "cake", "ball", "antena", "tv", "chips", "beer can", "smartphone" };
string[] adverbs = { "slowly", "rapidly", "warmly", "noisy", "diligently", "sadly" };
string[] details = { "near the river", "at home", "in the park", "in the shop", "on the porch", "on the terrace" };

Console.WriteLine("Hello, this is yours first random-generatede sentence: ");

while (true)
{
    string randomName = GetRandomWord(names);
    string randomPlace = GetRandomWord(places);
    string randomVerb = GetRandomWord(verbs);
    string randomNoun = GetRandomWord(nouns);
    string randomAdverb = GetRandomWord(adverbs);
    string randomDetails = GetRandomWord(details);

    //who from where
    string who = $"{randomName} from {randomPlace}";
    //action
    string action = $"{randomAdverb} {randomVerb} {randomNoun}";

    string sentence = $"{who} {action} {randomDetails}.";

    Console.WriteLine(sentence);

    Console.WriteLine("Click [Enter] to generate a new one.");

    Console.ReadLine();


}



string GetRandomWord(string[] words)
{
    Random random = new Random();

    int randomIndex = random.Next(words.Length);

    string word = words[randomIndex];
    
    return word;

}








