using System;
using System.Globalization;

namespace ex4_POO
{
    class Program
    {
        //criando a variavel static PI
        static double Pi= 3.14;
        static void Main(string[] args)
        {

            //---------------------------------------------------

            //Pedindo o valor do raio
            Console.WriteLine("Entre com valor do raio: ");
             
            //Lendo o que o usuario digital e guardando na variavel raio
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            
            //criando a varial circ do tipo double e instanciando ela com o método circuferencia da classe calculadora
            double circ = Circuferencia(raio);
            //criando a varial volume do tipo double e instanciando ela com o método volume da classe calculadora
            double volume = Volume(raio);
            
            //Escrevendo o resultado da circunferencia e convertendo ela para string
            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            //Escrevendo o resultado do volume e convertendo ela para string
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            //Escrevendo o valor de PI e convertendo ele para string
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        //Criando o método Circuferencia e passando como parametro a variavel double r
        static double Circuferencia(double r) 
        { 
            //Fazendo o calculo para retornar o valor do comprimenro da circuferencia
            return 2.0 * Pi * r; 
        }
        //Criando o método Volume e passando como parametro a variavel double r
        static double Volume(double r) 
        { 
            //Fazendo o calculo para retornar o valor do volume da circuferencia
            return 4.0 / 3.0 * Pi * r * r * r; 
        }
    }
}
