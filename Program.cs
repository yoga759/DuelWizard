Wizard wizardA = new Wizard("Zilong", 50);
Wizard wizardB = new Wizard("Argus",50);

Console.WriteLine("Permainan di mulai...\n");
Console.WriteLine("Statistik Awal");
wizardA.showstats();
wizardB.showstats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

Console.WriteLine("Permainan selesai...");
Console.WriteLine("Statistik akhir");
wizardA.showstats();
wizardB.showstats();

if (wizardA.energy > wizardB.energy)
{
    Console.WriteLine("Zilong pemenangnya");
}
else
{
 Console.WriteLine("Victory");
    return;
}
public class Wizard
{
    //field
    public string Name;
    public int energy;
    public int damage;

    //constructor
    public Wizard(string name,int damage)
    {
        Name = name;
        energy = 100;
        this.damage = damage;
    }

    //method
    public void showstats()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Energy: {energy}\n");
    }

    public void Attack(Wizard enemyobj)
    {
        enemyobj.energy -= damage;
        Console.WriteLine($" {Name} menyerang {enemyobj}");
        Console.WriteLine($"Sisa energi {enemyobj.Name}: {energy}");
    }
}
