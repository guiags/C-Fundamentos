namespace Fundamentos;

public class OperacoesMatematicas
{
    public void Adicionar(int valor1, int valor2)// Se colocar int valor2 = 3 e for o ultimo atributo ele será opicional, não sendo obrigado o usurio de infromar esse segundo parametro
    {
        var resultado = valor1 + valor2;
        Console.WriteLine(resultado);
    }
    public int Subtrair(int valor1, int valor2)
    {
        return valor1 - valor2;
    }
    public int Multiplicar(int valor1, int valor2) => valor1 * valor2; // Ja retorna automaticamente

    public (float divisao, string autor) Dividir(int valor1, int valor2)
    {
        float resultado = valor1 / valor2;
        return (resultado , "Gui");
    }

    public static int AdicionarSem(int valor1, int valor2)
    {
        var resultado = valor1 + valor2;
        return resultado;
    }
}
