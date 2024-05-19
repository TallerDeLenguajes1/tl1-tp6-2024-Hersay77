// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

/*Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo
"nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine
la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo.
*/
/*Console.WriteLine("Ingrese un numero: ");
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
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/
/*

Console.WriteLine("Usar Cacluladora? Si-ingrese 1. No-ingrese 0");
string entrada = Console.ReadLine();
int opcion;
float num1, num2, resultado;


while (int.TryParse(entrada, out opcion) && opcion != 0)
{
    Console.WriteLine("######Menu#########");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("Elija una opcion: ");

    entrada = Console.ReadLine();

    if (int.TryParse(entrada, out opcion) && opcion > 0 && opcion < 5)
    {
        do
        {
            Console.WriteLine("Ingrese primer numero: ");
            entrada = Console.ReadLine();
        } while (float.TryParse(entrada, out num1) != true);
        
        do
        {
            Console.WriteLine("Ingrese segundo numero: ");
            entrada = Console.ReadLine();
        } while (float.TryParse(entrada, out num2) != true);
        

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("La suma entre "+ num1 + " y " + num2 + " es: " + resultado);
            break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine("La Resta entre "+ num1 + " y " + num2 + " es: " + resultado);
            break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine("El producto entre "+ num1 + " y " + num2 + " es: " + resultado);
            break;  
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("\nError no se puede dividir por cero");
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine("La division de "+ num1 + " en " + num2 + " es: " + resultado);
                }
            break;
            default:
                Console.WriteLine("Continuar usando la Cacluladora? Si-ingrese 1. No-ingrese 0");
                entrada = Console.ReadLine();
            break;
        }
    }
    else
    {
        Console.WriteLine("Opcion ingresada incorrecta");
    }

    Console.WriteLine("Continuar usando la Cacluladora? Si-ingrese 1. No-ingrese 0");
    entrada = Console.ReadLine();
}

*/


