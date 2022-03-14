// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int idadeFlavin = 29;
int idadeRodrigo = 28;

if (idadeFlavin > idadeRodrigo)
    Console.WriteLine("Flavin eh mais velho");
else
    Console.WriteLine("Rodrigo eh mais velho");

Console.WriteLine("Finalizou o programa");

string name = "andre";

switch (name) {
    case "joao":
        Console.WriteLine("nao e o cara");
        break;
    case "maria":
        Console.WriteLine("tambem nao e");
        break;
    case "andre":
        Console.WriteLine("eh este"); 
        break;
    default: 
        Console.WriteLine("nao encontrado"); 
        break;
}

for (int i = 1; i <= 5; i++) {
    Console.Write(i);
}

MeuMetodo();

static void MeuMetodo() {
    Console.WriteLine("\nExecutei o metodo");
}

string meuNome = RetornaNome("Flavin");

Console.WriteLine(meuNome);

static string RetornaNome(string name) {
    return name;
}

Product mouse = new Product(1, "Mouse Gamer", 125.99, EProductType.Product);

Console.WriteLine(mouse.Id);
Console.WriteLine(mouse.Name);
Console.WriteLine(mouse.Price);
Console.WriteLine((int)mouse.Type);
Console.WriteLine(mouse.PriceInDolar(5.05));

struct Product
{
    public Product(int id, string name, double price, EProductType type)
    {
        Id = id;
        Name = name;
        Price = price;
        Type = type;
    }
    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public double PriceInDolar(double dolar) {
        return Price / dolar;
    }
}

enum EProductType
{
    Product = 1,
    Service = 2
}

