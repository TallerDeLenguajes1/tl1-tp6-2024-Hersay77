// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/
/*Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo
"nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine
la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo.
*/
/*
Console.WriteLine("Ingrese un numero: ");
string numStr = Console.ReadLine(); 
int aux;
int numeroInvertido = 0; 

if (int.TryParse(numStr, out aux))
{
    if (aux > 0)
    {
        while (aux > 0)
        {
            numeroInvertido =(numeroInvertido*10) + (aux % 10);
            aux /= 10;
        }
        Console.WriteLine($"El numero invertido es: {numeroInvertido}");
    }
    else
    {
        Console.WriteLine($"El numero ingresado es: {aux}");
    }
}
*/


/*
Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
calculadora.. Solicite al usuario un número y muestre por pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.
*/

bool resultado = false;
do
{
    Console.WriteLine("Ingresar un numero");
    string entrada = Console.ReadLine();
    float numero;
    resultado = float.TryParse(entrada, out numero);

    if (resultado)
    {
        Console.WriteLine("El valor absoluto del numero es: " + Math.Abs(numero));
        Console.WriteLine("El cuadrado del numero ingresado es: " + (numero*numero));
        Console.WriteLine("La raiz cuadrada del numero ingresado es: " + Math.Sqrt(numero));
        Console.WriteLine("El seno del numero ingresado es: " +  Math.Sin(numero));
        Console.WriteLine("El coseno del numero ingresado es: " + Math.Cos(numero));
        Console.WriteLine("La parte entera del numero ingresado es: " + Math.Truncate(numero));
    }
    else
    {
        Console.WriteLine("Ingreso incorrecto");
    }     
} while (resultado == false);


/*
    Luego de esto, solicite dos números al usuario y determine:
    ● El Máximo entre los dos números
    ● El Mínimo entre los dos números
*/


bool resultado1;
bool resultado2;
do
{
    Console.WriteLine("Ingrese un primer numero: ");
    string entrada = Console.ReadLine();
    float numero1, numero2;
    resultado1 = float.TryParse(entrada , out numero1);
    Console.WriteLine("Ingrese el segundo numero: ");
    entrada = Console.ReadLine();
    resultado2 = float.TryParse(entrada, out numero2);
    if (resultado1 && resultado2)
    {
        if (numero1 > numero2)
        {
            Console.WriteLine("El maximo entre los dos numeros es el primer numero: " + numero1);
            Console.WriteLine("El minimo entre los dos numeros es el segundo numero: " + numero2);
        }
        else if (numero1<numero2)
        {
            Console.WriteLine("El maximo entre los dos numeros es el segundo numero: " + numero2);
            Console.WriteLine("El minimo entre los dos numeros es el primer numero: " + numero1);
        }
        else
        {
            Console.WriteLine("Ambos numeros ingresados son iguales: " + numero1 + " y " + numero2);
        }
        resultado1 = true;
        resultado2 = true;
    }
    else
    {
        Console.WriteLine("Ingreso de numeros incorrectos");
    }

} while (resultado1 == false || resultado2 == false);




