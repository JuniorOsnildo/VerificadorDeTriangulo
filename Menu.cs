namespace ferificadorDeTriangulo;

public class Menu
{
    public static void AbrirMenu()
    {
        Console.Clear();
        Console.WriteLine("[1] Criar Triangulo \n" +
                          "[2] Sair");
        var escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                CriarTriangulo();
                break;
            case "2":
                Console.WriteLine("Até a Próxima! :D");
                break;
            default:
                Console.WriteLine("Valor Invalido!");
                Console.Clear();
                AbrirMenu();
                break;
        }
    }

    private static void CriarTriangulo()
    {
        Console.Clear();


        float a = 0, b = 0, c = 0;
        
        try
        {
            Console.WriteLine("Digite os valores do triangulo:");
            Console.Write("Lado A -> ");
            a = float.Parse(Console.ReadLine() ?? "0");
            Console.Write("\nLado B -> ");
            b = float.Parse(Console.ReadLine() ?? "0");
            Console.Write("\nLado C -> ");
            c = float.Parse(Console.ReadLine() ?? "0");

        }
        catch
        {
            CriarTriangulo();
        }
        

        var t = new Triangulo(a, b, c);
        t.ProcessarTriangulo();
        
        Console.WriteLine("\n Precione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        
        AbrirMenu();
    }
}