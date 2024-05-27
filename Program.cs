using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TareaPago
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pedir datos de entrada 
            string Nombre;
            int cedula, codigoEmpleado;
            decimal valorHora, numeroHoras, salarioMinimo, salario;
            PedirDatos(out Nombre, out cedula, out codigoEmpleado, out valorHora, out numeroHoras, out salarioMinimo, out salario);
            salario = calcularSalario(numeroHoras, valorHora);
            mostrarResultado(Nombre, salarioMinimo, salario);
        }

        static void PedirDatos(out string Nombre, out int cedula, out int codigoEmpleado, out decimal valorHora, out decimal numeroHoras,
            out decimal salarioMinimo, out decimal salario)
        {
            Console.WriteLine("Ingrese Nombre :");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese cédula :");
            cedula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese código de empleado :");
            codigoEmpleado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese valor hora :");
            valorHora = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese número de horas trabajadas :");
            numeroHoras = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese salario mínimo :");
            salarioMinimo = Convert.ToDecimal(Console.ReadLine());

            salario = 0; 
        }

        static decimal calcularSalario(decimal numeroHoras, decimal valorHora)
        {
            return numeroHoras * valorHora;
        }

        static void mostrarResultado(string Nombre, decimal salarioMinimo, decimal salario)
        {
            Console.WriteLine("Nombre      : {0}", Nombre);
            if (salario > salarioMinimo)
            {
                Console.WriteLine("Salario     : ${0:N2}", salario);
            }
            else
            {
                Console.WriteLine("Salario     : ${0:N2}", salario);
            }
            Console.ReadKey();
        }
    }
}

