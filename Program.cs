// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

/*Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo
"nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine
la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo.
*/

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

/*
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/


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

bool resultadoDev = false;
do
{
    Console.WriteLine("Ingresar un numero");
    entrada = Console.ReadLine();
    float numero;
    resultadoDev = float.TryParse(entrada, out numero);

    if (resultadoDev)
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
} while (resultadoDev == false);


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
    entrada = Console.ReadLine();
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

/*Trabajando con el tipo string
Funciones útiles para realizar el ejercicio 4
A continuación se presenta una lista de métodos pertenecientes al objeto string para
procesar cadenas de texto. Se recomienda investigar el comportamiento de cada uno
a medida que los vaya necesitando para resolver el punto 4.
Conversor de tipo: ToString()
Comparador de cadenas: Compare(), CompareTo() == y !=
Mayúsculas y minúsculas: ToUpper() o ToLower()
Acceso a los caracteres individuales: SubString(), Replace(),Split() y Trim()
Búsqueda y manipulación de una cadena: IndexOf() LastIndexOf, StartsWith y EndsWith. Split()

Ejercicio 4.
Responder las siguientes preguntas en el archivo readme.md
¿String es una tipo por valor o un tipo por referencia?
¿Qué secuencias de escape tiene el tipo string?
¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Realizar los siguientes ejercicios
Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes
tarea:
● Obtener la longitud de la cadena y muestre por pantalla.
● A partir de una segunda cadena ingresada por el usuario, concatene ambas
cadenas distintas.
● Extraer una subcadena de la cadena ingresada.
● Utilizando la calculadora creada anteriormente realizar las operaciones de dos
números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para
la suma sería:
“la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
Donde num1, num2 y resultados son los sumandos y el resultado de la operación
respectivamente.
Nota: Busque el comportamiento del Método ToString();
● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por
elemento en pantalla
● Buscar la ocurrencia de una palabra determinada en la cadena ingresada
● Convierta la cadena a mayúsculas y luego a minúsculas.
● Ingrese una cadena separada por caracteres que usted determine y muestre por
pantalla los resultados (Revisar el comportamiento de split())
● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
por pantalla “582+2” y que le devuelva la suma de 582 con 2
*/


