using System.Text.Json;

string contents = File.ReadAllText("weapon.json");


if (JsonSerializer.Deserialize<Weapon>(contents) is not Weapon w) {
    Console.WriteLine("Error!");
    return;
}


Console.WriteLine("Hur många attacker?");

int numAttacks = 0;
string numAttacksStr = "";

while (!int.TryParse(numAttacksStr, out numAttacks))
{
    if (Console.ReadLine() is string inputString) {
        numAttacksStr = inputString;
    }
}

int damageSum = 0;

Console.ForegroundColor = ConsoleColor.Red;

for (int i = 0; i < numAttacks; i++)
{
    int damage = w.Attack();
    Console.WriteLine($"+{damage}");
    damageSum += damage;
}

Console.ResetColor();

Console.WriteLine($"Du gjorde totalt {damageSum} skada!");


Console.ReadLine();