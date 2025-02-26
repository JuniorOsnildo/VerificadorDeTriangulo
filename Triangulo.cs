using System.Runtime.CompilerServices;

namespace ferificadorDeTriangulo;

public class Triangulo(float ladoA, float ladoB, float ladoC)
{
    private float ladoA { get; } = ladoA;
    private float ladoB { get; } = ladoB;
    private float ladoC { get; } = ladoC;
    private string tipo {get; set;}


    public void ProcessarTriangulo()
    {
        if (ValidarLados())
        {
            RotularTriangulo();
            Console.WriteLine(this.ToString());
        }
        else
        {
            TrianguloInvalido();
        }
    }
    
    private bool ValidarLados()
    {
        return ladoA+ladoB > ladoC && ladoA+ladoC > ladoB && ladoC+ladoB > ladoA;
    }

    private void RotularTriangulo()
    {
        if (ladoA == ladoB && ladoB == ladoC)
        {
            this.tipo = "Equilátero";
        } else if (ladoA == ladoB || ladoB == ladoC || ladoC == ladoA)
        {
            this.tipo = "Isósceles";
        }
        else
        {
            this.tipo = "Escaleno";
        }
    }


    public override string ToString()
    {
        return "\nO triâgulo criado tem lados de: " + ladoA + "um , " + ladoB + "um , " + ladoC +"um \n"
               + "e é do tipo:"+ this.tipo;
    }

    private void TrianguloInvalido()
    {
        Console.WriteLine("O triângulo criado é inválido!");
    }
}