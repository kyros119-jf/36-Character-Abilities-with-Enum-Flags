Abilities characterAbilities = Abilities.Jump | Abilities.Run | Abilities.Swim;

Console.WriteLine($"Character Abilities: {characterAbilities}");

if (characterAbilities.HasFlag(Abilities.Fly))
{
    Console.WriteLine("The character can fly.");
}
else
{
    Console.WriteLine("The character cannot fly.");
}

if (characterAbilities.HasFlag(Abilities.Swim))
{
    Console.WriteLine("The character can swim.");
}
else
{
    Console.WriteLine("The character cannot swim.");
}

if (characterAbilities.HasFlag(Abilities.Invisible))
{
    Console.WriteLine("The character can become invisible.");
}
else
{
    Console.WriteLine("The character cannot become invisible.");
}   