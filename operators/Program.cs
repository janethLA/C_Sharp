// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operators");
int x= 10, y = 5;
string a = "abcd", b = "fghij";

Console.WriteLine("-------- Basic Math ---------");
Console.WriteLine((x / y) * x);
Console.WriteLine(a + b);

Console.WriteLine("-------- INCREMENT/DECREMENT ---------");
x++;
y--;
Console.WriteLine(x);
Console.WriteLine(y);


Console.WriteLine("-------- Shorthand---------");
a += b;
x += y;
Console.WriteLine(a);
Console.WriteLine(x);

Console.WriteLine("-------- LOGIC && || (and, or)---------");
Console.WriteLine(x > y && y >= 5);
Console.WriteLine(x > y || y >= 5);


string auto = "fiat";
int modelo = 2022;

if (auto == "fiat" && modelo > 2022)
{
    Console.WriteLine("El auto esta bien");
}


//readline

int e;
int f = 3;
string c = "Mayor";

Console.WriteLine("Ingrese un valor");
string d = Console.ReadLine();

if(c==d){
    Console.WriteLine("Es igual");
}else{
    Console.WriteLine("No es igual");
}

int g;
int h = 2;
Console.WriteLine("Ingrese un numero");
int i = Convert.ToInt32(Console.ReadLine());

if(i>h){
    Console.WriteLine("Es Mayor");
}else{
    Console.WriteLine("Es Menor");
}
