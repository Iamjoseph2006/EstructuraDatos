// Nombre: José Hernández
// Fecha: 03/12/2024
// Hoja: 1

using System;

namespace FigurasGeometricas
{
    // Clase que representa un Círculo
    public class Circulo
    {
        private double _radio; // Propiedad privada para encapsular el radio del círculo

        // Constructor para inicializar el radio
        public Circulo(double radio)
        {
            _radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(_radio, 2);
        }

        // Método para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * _radio;
        }
    }

    // Clase que representa un Rectángulo
    public class Rectangulo
    {
        private double _largo; // Propiedad privada para encapsular el largo
        private double _ancho; // Propiedad privada para encapsular el ancho

        // Constructor para inicializar largo y ancho
        public Rectangulo(double largo, double ancho)
        {
            _largo = largo;
            _ancho = ancho;
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            return _largo * _ancho;
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (_largo + _ancho);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Entrada para el círculo
                Console.WriteLine("Ingrese el radio del círculo:");
                double radio = Convert.ToDouble(Console.ReadLine()); // Leer el radio desde el teclado
                if (radio <= 0) throw new Exception("El radio debe ser un número positivo.");

                Circulo circulo = new Circulo(radio); // Crear un objeto de tipo Círculo
                Console.WriteLine("\nCírculo:");
                Console.WriteLine($"Área: {circulo.CalcularArea():F2}");
                Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro():F2}\n");

                // Entrada para el rectángulo
                Console.WriteLine("Ingrese el largo del rectángulo:");
                double largo = Convert.ToDouble(Console.ReadLine()); // Leer el largo desde el teclado
                if (largo <= 0) throw new Exception("El largo debe ser un número positivo.");

                Console.WriteLine("Ingrese el ancho del rectángulo:");
                double ancho = Convert.ToDouble(Console.ReadLine()); // Leer el ancho desde el teclado
                if (ancho <= 0) throw new Exception("El ancho debe ser un número positivo.");

                Rectangulo rectangulo = new Rectangulo(largo, ancho); // Crear un objeto de tipo Rectángulo
                Console.WriteLine("\nRectángulo:");
                Console.WriteLine($"Área: {rectangulo.CalcularArea():F2}");
                Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro():F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor, ingrese un número válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}