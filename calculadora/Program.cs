// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

bool sw = false;


while (!sw) {
    menu();
   
    int op = Convert.ToInt32(Console.ReadLine());
    switch (op)
    {
        case 1:
            suma();
            break;
        case 2:
            resta();
            break;

        case 3:
            mul();
            break;
        case 0:
            Console.Clear();
            sw = true;
            break;
        default:
            Console.WriteLine("Opción no válida. Intenta de nuevo.");
            break;
    }
}
static void menu()
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1.- Suma");
    Console.WriteLine("2.- Resta");
    Console.WriteLine("3.- Mul");
    Console.WriteLine("0.- Salir");
}
static void suma()
{
    Console.Clear();
    Console.WriteLine("SUMA");
    Console.WriteLine("Ingrese un numero");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese un numero");
    int b = Convert.ToInt32(Console.ReadLine());
    int c = a + b;
    Console.WriteLine("Suma");
    Console.WriteLine(c);
    Console.WriteLine("Presione Enter para volver al menu");
    Console.ReadLine();
}
static void resta()
{
    Console.Clear();
    Console.WriteLine("RESTA");
    Console.WriteLine("Ingrese un numero");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese un numero");
    int b = Convert.ToInt32(Console.ReadLine());
    int c = a - b;
    Console.WriteLine("Resta");
    Console.WriteLine(c);
    Console.WriteLine("Presione Enter para volver al menu");
    Console.ReadLine();
}
static void mul()
{
    Console.Clear();
    Console.WriteLine("MULTIPLICACION");
    Console.WriteLine("Ingrese un numero");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese un numero");
    int b = Convert.ToInt32(Console.ReadLine());
    int c = a * b;
    Console.WriteLine("MUL");
    Console.WriteLine(c);
    Console.WriteLine("Presione Enter para volver al menu");
    Console.ReadLine();
}

