using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Bucles
{
    class Program
    {
        static void Main(string[] args)
        {


            //////tabla de multiplicar x10
            ////int i = 0;
            ////int num;

            ////Console.WriteLine("Escribe un numero para multiplicar");
            ////num = Convert.ToInt32(Console.ReadLine());

            ////while (i <= 10)
            ////{
            ////    Console.WriteLine(num + " x " + i + " = " + (num * i));
            ////    i++;
            ////}

            //////programa que muestre del 1 al 100 con el while

            ////int e = 0;

            ////while (e<=100)
            ////{
            ////    Console.WriteLine(e);
            ////    e++;
            ////}

            //////programa que muestre del 1 al 100 con el do while

            ////int a = 1;
            ////do
            ////{
            ////    Console.WriteLine(a);
            ////    a++;
            ////}
            ////while (a <= 100);

            //////Pedir numeros hasta que se introduzca uno negativo con WHILE y DO WHILE
            //////En este caso el DO WHILE es mas correcto por que pide directamente sin tener que escribirlo antes
            //////En caso de necesidad de un cambio al no haber una copia, no hay que corregir redundantemente.


            ////int o ;

            ////Console.WriteLine("Dame un numero");
            ////o = Convert.ToInt32(Console.ReadLine());

            ////while (o > -1)
            ////{
            ////    Console.WriteLine("Dame un numero");
            ////    o = Convert.ToInt32(Console.ReadLine());
            ////}

            ////Console.WriteLine("El numero es negativo");
            ////Console.ReadLine();

            ////do
            ////{
            ////    Console.WriteLine("Dame un numero");
            ////    o = Convert.ToInt32(Console.ReadLine());
            ////}
            ////while (o > -1);

            ////Console.WriteLine("El numero es negativo");

            //////Contar hasta 10 con FOR

            ////for (int i = 0; i <= 10; i++)
            ////{
            ////    Console.WriteLine(i);
            ////}


            //////Pedir 4 numeros y que haga la suma de los 4
            ////int suma=0;
            ////int num;

            ////for (int i = 0; i<4;i++)
            ////{
            ////    Console.WriteLine("Dame un numero");
            ////    num=Convert.ToInt32(Console.ReadLine());
            ////    suma = suma + num;

            ////}

            ////Console.WriteLine("Total " + suma);

            //////Escribe un programa que muestre en pantalla los números del 10 al 20 (incluidos los dos) con una línea vacía entre ellos.
            //////WHILE y en FOR

            ////int i = 10;

            ////while (i <= 20)
            ////{
            ////    Console.WriteLine(i + "\n");
            ////    i++;
            ////}

            ////for (int e = 10;e<= 20;e++)
            ////{
            ////    Console.WriteLine(e + "\n");
            ////}

            //////Escribe un programa que muestre en pantalla los números del 20 al 10 (incluidos los dos) con una línea vacía entre ellos.

            ////for(int i=20; i>=10;i--)
            ////{
            ////    Console.WriteLine(i + "\n");
            ////}

            //////Escribe un programa que pida 4 valores. Al final mostrar la media de esos valores.

            ////int suma = 0;
            ////int num;


            ////for(int i=0;i<4;i++)
            ////{
            ////    Console.WriteLine("Dame un valor");
            ////    num = Convert.ToInt32(Console.ReadLine());
            ////    suma = suma + num;
            ////}
            ////Console.WriteLine("la media es " + suma / 4);

            ////Escribe un programa que pida valores hasta que el usuario introduzca un 0.
            ////Si introduce un valor negativo, mostrar un mensaje diciendo que se ignoran los valores negativos.
            ////Mostrar la suma de los valores introducidos. 


            ////HECHO CON FOR, MEJOR NO HACERLO CON FOR

            ////int suma = 0;
            ////int num = 0;


            ////Console.WriteLine("dame un numero");
            ////num = Convert.ToInt32(Console.ReadLine());
            ////if (num < 0)
            ////{

            ////    Console.WriteLine("valores negativos se ignoran");
            ////}
            ////else
            ////{
            ////    suma = suma + num;
            ////}

            ////for (int i = 0; num != 0; i++)
            ////{
            ////    Console.WriteLine("dame un numero");
            ////    num = Convert.ToInt32(Console.ReadLine());
            ////    if (num < 0)
            ////    {

            ////        Console.WriteLine("valores negativos se ignoran");
            ////    }
            ////    else
            ////    {
            ////        suma = suma + num;
            ////    }
            ////}

            ////Console.WriteLine("suma es: " + suma);
            ////Console.ReadLine();

            ////HECHO CON WHILE, MEJOR NO HACERLO CON WHILE

            ////int i = 0;
            ////int suma = 0;


            ////Console.WriteLine("Dame un numero");
            ////i = Convert.ToInt32(Console.ReadLine());
            ////if (i < 0)
            ////{
            ////    Console.WriteLine("Valores negativos se ignoran");
            ////}
            ////else
            ////{
            ////    suma = suma + i;
            ////}

            ////while (i != 0)
            ////{
            ////    Console.WriteLine("Dame un numero");
            ////    i = Convert.ToInt32(Console.ReadLine());
            ////    if (i < 0)
            ////    {
            ////        Console.WriteLine("Valores negativos se ignoran");
            ////    }
            ////    else
            ////    {
            ////        suma = suma + i;
            ////    }
            ////}
            ////Console.WriteLine("total " + suma);
            ////Console.ReadLine();

            ////HECHO CON DO WHILE, LA MEJOR FORMA DE HACERLO

            ////int suma = 0;
            ////int num = 0;

            ////do
            ////{
            ////    Console.WriteLine("Dame un numero");
            ////    num = Convert.ToInt32(Console.ReadLine());
            ////    if (num < 0)
            ////    {
            ////        Console.WriteLine("numero negativo");
            ////    }
            ////    else
            ////    {
            ////        suma = suma + num;
            ////    }
            ////}
            ////while (num != 0);

            ////Console.WriteLine("total " + suma);
            ////Console.ReadLine();

            ////Escribe un programa que muestre todos los valores pares o impares entre 1 y 100 dependiendo de si el usuario introduce P o I.
            ////Si introduce otra cosa, decir que ese valor no es correcto y pedirle otra vez.

            ////string respuesta = "";
            ////while(respuesta != "P" && respuesta != "I")
            ////{
            ////    Console.WriteLine("escribe P o I:");
            ////    respuesta = Console.ReadLine();
            ////}

            ////if (respuesta == "P")
            ////{
            ////    for (int i = 2; i < 101; i = i + 2)
            ////    {
            ////        Console.WriteLine(i);
            ////    }
            ////}
            ////else
            ////{
            ////    for (int i = 1; i < 100; i = i + 2)
            ////    {
            ////        Console.WriteLine(i);
            ////    }

            ////}

            ////Console.ReadLine();

            ////Escribe un programa que pregunte al usuario su edad. Mostrar en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.

            ////int edad;

            ////Console.WriteLine("¿Cuantos años tienes?");
            ////edad = Convert.ToInt32(Console.ReadLine());


            ////for (int i=0; i<edad;i++)
            ////{
            ////    Console.WriteLine("Feliz Cumpleaños");

            ////}
            ////Console.ReadLine();

            ////Pedir al usuario un número. Mostrar en pantalla 
            ////        *
            ////        **
            ////        ***
            ////Con tantas líneas como el número que ha introducido

            ////int lineas;

            ////Console.WriteLine("Dame un numero");
            ////lineas = Convert.ToInt32(Console.ReadLine());

            ////for (int i=0; i<lineas;i++)
            ////{
            ////    for(int j=0;j<=i;j++)
            ////    {
            ////        Console.Write("*");
            ////    }
            ////    Console.WriteLine();
            ////}
            ////Console.ReadLine();

            //////Escribe un programa que muestre los números de 1 a 12 en una columna. 
            //////En la columna de al lado de los números impares mostrar el cuadrado de ese valor y en la de los pares mostrar el cubo.

            ////for (int i = 1; i <= 12; i++)
            ////{
            ////    Console.Write(i);
            ////    if (i % 2 != 0)
            ////    {
            ////        Console.WriteLine("\t" + (Math.Pow(i, 2)));
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("\t" + (Math.Pow(i, 3)));
            ////    }
            ////}
            ////Console.ReadLine();

            //////Mostrar en pantalla diez números, siendo el primero 1 y los siguientes la suma del número anterior y 5.

            ////int suma=1;

            ////for(int i=1; i<=10;i++)
            ////{ 
            ////    Console.WriteLine(suma);
            ////    suma = suma + 5;

            ////}
            ////Console.ReadLine();

            ////Escribe un programa que te calcule la largura de un string.

            //String largura;
            //largura = Console.ReadLine();
            //Console.WriteLine(largura.Length);

            //Console.ReadLine();

            ////Escribe un programa que te calcule el total de palabras que hay en un string.


            //int palabras = 0;

            //Console.WriteLine("Escribe un frase");
            //string frase;
            //frase = Console.ReadLine();

            //for (int i = 0; i < frase.Length; i++)
            //{
            //    if (frase[i] == ' ')
            //    {
            //        palabras++;
            //    }
            //}
            //Console.WriteLine("La frase " + frase + " contiene " + palabras + " palabras");
            //Console.ReadLine();

            //Escribe un programa que copia un string a otro string.

            string a = "copiame en b";
            string b;



            //Escribe un programa que nos cuente el número de vocales en un string.


            //int vocales = 0;

            //Console.WriteLine("Escribe una palabra");
            //string palabra;
            //palabra = Console.ReadLine();

            //for (int i = 0; i < palabra.Length; i++)
            //{
            //    if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
            //    {
            //        vocales = vocales + 1;
            //        //vocales += 1;
                      //vocales++
            //    }

            //}
            //Console.WriteLine("La palabra " + palabra +" tiene " + vocales + " vocales");

            //Console.ReadLine();


            //Escribe un programa que devuelva un string en minúsculas en mayúsculas y al revés.



            //Escribe un programa que evalúe si un string contiene la letra ‘r’.









        }
    }
}
