Random random = new Random();
int heroLife = 10;
int monsterLife = 10;

do
{
    int Attack = random.Next(1, 11);
    monsterLife -= Attack;
    Console.WriteLine($"Hero Attacks Monster\nMonster was damaged and lost {Attack} health and now has {monsterLife} health.\n");
    if (monsterLife <= 0) continue;
    
    Attack = random.Next(1, 11);
    heroLife -= Attack;
    Console.WriteLine($"Monster attacks Hero\nHero was damaged and lost {Attack} health and now has {heroLife} health.\n");


} while (heroLife > 0 && monsterLife > 0);

Console.WriteLine(heroLife > monsterLife ? "Hero wins!" : "Monster wins!");
