Wizard wizardA = new Wizard("Zilong", 50);
Wizard wizardB = new Wizard("Argus", 50);

Console.WriteLine("Permainan di mulai...\n");
Console.WriteLine("Statistik Awal");
wizardA.showstats();
wizardB.showstats();

string pilihan;

while (true)
{
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.Write("\npilihanmu (1/2/3/4): ");
    pilihan = Console.ReadLine();

    if (pilihan == "1") wizardA.Attack(wizardB);
    else if (pilihan == "2") wizardB.Attack(wizardA);
    else if (pilihan == "3") wizardA.heal ();
    else if (pilihan == "4")  wizardB.heal ();
    else Console.WriteLine("Pilihanmu tidak valid");

    if (wizardA.energy <= 0 || wizardB.energy <= 0)
    {
        Console.WriteLine("Permainan berakhir.....");
        if (wizardA.energy > wizardB.energy)
        {
            Console.WriteLine($"{wizardA.Name} victory!");
            Console.WriteLine($"{wizardB.Name} berhasil dikalahkan");
        }
        else
        {
            Console.WriteLine($"{wizardB.Name} victory!");
            Console.WriteLine($"{wizardB.Name} berhasil dikalahkan");
        }
        break;
    }
}

//wizardA.Attack(wizardB);
//wizardA.Attack(wizardB);
//wizardA.Attack(wizardB);
//wizardB.heal();

Console.WriteLine("Permainan selesai...");
Console.WriteLine("Statistik akhir");
wizardA.showstats();
wizardB.showstats();

if (wizardA.energy > wizardB.energy)
{
    Console.WriteLine("Victory,Zilong pemenangnya");
}
else
{
    return;
}
public class Wizard
{
    //field
    public string Name;
    public int energy;
    public int damage;

    //constructor
    public Wizard(string name, int damage)
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
        Console.WriteLine($" {Name} menyerang {enemyobj.Name}");
        Console.WriteLine($"Sisa energi {enemyobj.Name}: {energy}");
    }


    public void heal()
    {
        if (energy >= 100)
        {
            Console.WriteLine("Gagal melakukan heal.Energi sudah mencapai maksimum");
        }
        else
        {
            if (energy > 95)
            {
                energy = 100;
            }
            else
            {
                energy += 5;
            }
            Console.WriteLine($"{Name} berhasil melakukan heal. Energi meningkat menjadi {energy}");
            
        }
        
    }
    

}



