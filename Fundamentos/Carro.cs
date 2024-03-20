namespace Fundamentos;

public class Carro
{
    public string Modelo{ get; set; } //required antes de string obriga o preenchimento do atributo
    public DateOnly DataLancamento{ get; set; }
    public Cor Cor { get; set;}// Pode ser statica pra ser usada por função statica, mas será somente a ultima variavel informada a ser acessada

    public Carro(string modelo, DateOnly dataLancamento, Cor cor)
    {
        Modelo = modelo;
        DataLancamento = dataLancamento;
        Cor = cor;
    }

    public void ImprimirModelo()
    {
        Console.WriteLine(Modelo);
    }


}
