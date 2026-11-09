// Ejercicio 1:
Console.WriteLine("Ejercicio 1");
Console.WriteLine();

Console.Write("Introduce el primer número: ");
int numero1 = int.Parse(Console.ReadLine()!);
Console.Write("Introduce el segundo número: ");
int numero2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"La suma es {numero1 + numero2}");
Console.WriteLine($"La resta es: {numero1} - {numero2} = {numero1 - numero2}");
Console.WriteLine($"La multiplicación es: {numero1 * numero2}");
Console.WriteLine($"La división es: {numero1 / numero2}");
Console.WriteLine($"El módulo es: {numero1 % numero2}");
Console.WriteLine();


// Ejercicio 2:
Console.WriteLine("Ejercicio 2");
Console.WriteLine();

const decimal PRECIO_HAMBURGUESA = 4.50m;
const decimal PRECIO_PAPAS = 1.75m;
const decimal PRECIO_BEBIDA = 1.50m;

Console.Write("Cantidad de hamburguesas: ");
int hamburguesas = int.Parse(Console.ReadLine()!);
Console.Write("Cantidad de papas: ");
int papas = int.Parse(Console.ReadLine()!);
Console.Write("Cantidad de bebidas: ");
int bebidas = int.Parse(Console.ReadLine()!);

decimal totalBar = hamburguesas * PRECIO_HAMBURGUESA + papas * PRECIO_PAPAS + bebidas * PRECIO_BEBIDA;

Console.WriteLine($"Cantidad a pagar: {totalBar:0.00}€");
Console.WriteLine();


// Ejercicio 3:
Console.WriteLine("Ejercicio 3");
Console.WriteLine();

Console.Write("Introduce un número: ");
double numero = double.Parse(Console.ReadLine()!);
double otroNumero = 10; // número extra para Max y Min

Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
Console.WriteLine($"Potencia al cubo: {Math.Pow(numero, 3)}");
Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");
Console.WriteLine($"Seno: {Math.Sin(numero)}");
Console.WriteLine($"Coseno: {Math.Cos(numero)}");
Console.WriteLine($"Número máximo entre {numero} y {otroNumero}: {Math.Max(numero, otroNumero)}");
Console.WriteLine($"Número mínimo entre {numero} y {otroNumero}: {Math.Min(numero, otroNumero)}");
Console.WriteLine();


// Ejercicio 4:
Console.WriteLine("Ejercicio 4");
Console.WriteLine();

Console.Write("Introduce el valor de un lado del cuadrado: ");
double lado = double.Parse(Console.ReadLine()!);

double perimetro = lado * 4;

Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
Console.WriteLine();


// Ejercicio 5:
Console.WriteLine("Ejercicio 5");
Console.WriteLine();

Console.Write("Introduce el primer número: ");
double n1 = double.Parse(Console.ReadLine()!);
Console.Write("Introduce el segundo número: ");
double n2 = double.Parse(Console.ReadLine()!);
Console.Write("Introduce el tercer número: ");
double n3 = double.Parse(Console.ReadLine()!);
Console.Write("Introduce el cuarto número: ");
double n4 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"La suma de los dos primeros es: {n1 + n2}");
Console.WriteLine($"El producto del tercero y el cuarto es: {n3 * n4}");
Console.WriteLine();


// Ejercicio 6:
Console.WriteLine("Ejercicio 6");
Console.WriteLine();

Console.Write("Introduce el primer valor: ");
double v1 = double.Parse(Console.ReadLine()!);
Console.Write("Introduce el segundo valor: ");
double v2 = double.Parse(Console.ReadLine()!);
Console.Write("Introduce el tercer valor: ");
double v3 = double.Parse(Console.ReadLine()!);
Console.Write("Introduce el cuarto valor: ");
double v4 = double.Parse(Console.ReadLine()!);

double suma = v1 + v2 + v3 + v4;
double promedio = suma / 4;

Console.WriteLine($"La suma es: {suma}");
Console.WriteLine($"El promedio es: {promedio}");
Console.WriteLine();


// Ejercicio 7:
Console.WriteLine("Ejercicio 7");
Console.WriteLine();

Console.Write("Introduce el precio del artículo: ");
double precio = double.Parse(Console.ReadLine()!);
Console.Write("Introduce la cantidad que lleva el cliente: ");
int cantidad = int.Parse(Console.ReadLine()!);

double costeTotal = precio * cantidad;

Console.WriteLine($"El coste total es: {costeTotal:0.00}€");
Console.WriteLine();


// Ejercicio 8:
Console.WriteLine("Ejercicio 8");
Console.WriteLine();

Console.Write("Introduce la nota del primer parcial: ");
double parcial1 = double.Parse(Console.ReadLine()!);
Console.Write("Introduce la nota del segundo parcial: ");
double parcial2 = double.Parse(Console.ReadLine()!);
Console.Write("Introduce la nota del examen: ");
double examen = double.Parse(Console.ReadLine()!);
Console.Write("Introduce la nota del trabajo final: ");
double trabajo = double.Parse(Console.ReadLine()!);

double promedioParciales = (parcial1 + parcial2) / 2;
double notaFinal = promedioParciales * 0.5 + examen * 0.3 + trabajo * 0.2;

Console.WriteLine($"Tu nota final en Desarrollo de Interfaces es: {notaFinal:0.00}");
Console.WriteLine();


// Ejercicio 9:
Console.WriteLine("Ejercicio 9");
Console.WriteLine();

Console.Write("Aportación del socio 1: ");
double aporte1 = double.Parse(Console.ReadLine()!);
Console.Write("Aportación del socio 2: ");
double aporte2 = double.Parse(Console.ReadLine()!);
Console.Write("Aportación del socio 3: ");
double aporte3 = double.Parse(Console.ReadLine()!);

double totalSocios = aporte1 + aporte2 + aporte3;

double porcentaje1 = aporte1 * 100 / totalSocios;
double porcentaje2 = aporte2 * 100 / totalSocios;
double porcentaje3 = aporte3 * 100 / totalSocios;

Console.WriteLine($"El porcentaje del socio 1 es {porcentaje1:0.##}%, del socio 2 es {porcentaje2:0.##}% y del socio 3 es {porcentaje3:0.##}%");
Console.WriteLine();


// Ejercicio 10:
Console.WriteLine("Ejercicio 10");
Console.WriteLine();

Console.Write("Introduce un texto: ");
string texto = Console.ReadLine()!;

bool empiezaPorWww = texto.StartsWith("www");

Console.WriteLine(empiezaPorWww);
