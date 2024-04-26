class Kaki
{
    private string name;
    private bool IsKaki;
    public Kaki(string name, bool IsKaki)
    {
        this.name = name;
        this.IsKaki = IsKaki;
    }
    public string GetName() { return this.name; }
}
class Program
{
    static void Main()
    {
        Kaki kaki = new Kaki("Kaki", true);
        Console.WriteLine($"Nama saya adalah {kaki.GetName()}");
        
        if (kaki.IsKaki)
        {
            Console.WriteLine("Saya abdallah Kaki");
        }
        else
        {
            Console.WriteLine("Saya bukan Kaki");
        }
    }
}