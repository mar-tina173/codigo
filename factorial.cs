// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void fact()
{
    Console.WriteLine("ingrese un numero para saber el resultado del factorial");
    int n1 = Convert.ToInt16(Console.ReadLine());
    int n3 = 1;

    for (int i = 1; i < n1 + 1; i++)
    {
        n3 = n3 * i;
    }
    Console.WriteLine($"el resultado del factorial es {n3} tiene ");
}
fact();


