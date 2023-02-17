
using bowling;

List<Drink> drinks = new List<Drink>();

drinks.Add(new Drink { Name = "Mountain Dew", ContainsAlcohol = false, IsCarbonated = true, SizeInOZ = 12 });
drinks.Add(new Drink { Name = "Diet Mountain Dew", ContainsAlcohol = false, IsCarbonated = true, SizeInOZ = 12 });
drinks.Add(new Drink { Name = "Water", ContainsAlcohol = false, IsCarbonated = false, SizeInOZ = 8 });
drinks.Add(new Drink { Name = "Guinness", ContainsAlcohol = true, IsCarbonated = true, SizeInOZ = 12 });
drinks.Add(new Drink { Name = "Bourbon", ContainsAlcohol = true, IsCarbonated = false, SizeInOZ = 2 });

foreach(var drink in drinks)
{
    Console.WriteLine($"{drink.Name} is served in a {drink.SizeInOZ}oz glass");
}


/*
List<int> game = new List<int>();

for(var idx = 1; idx <= 10; idx++)
{
    var score = GetScore();
    game.Add(score); 
}

var gameScore = 0;

foreach(var score in game)
{
    gameScore += score;
}

Console.WriteLine($"Score is {gameScore}");

int GetScore()
{
    Console.Write("Enter Score: ");
    var scoreAsStr = Console.ReadLine();
    var score = Convert.ToInt32(scoreAsStr);
    return score;
}

*/