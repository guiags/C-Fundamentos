using System;
using System.Globalization;
using System.Text;

namespace Fundamentos;

class Program
{
    enum NivelDeDificuldade{ 
    facil = 0,
    medio = 1,
    dificil = 2
    };



    static void Main()
    {
    //1- Tipos Númericos
        int numero = 7;
        long numero2 = 7;
        uint numero3 = 7;
        sbyte numero4 = 125;
        double numero5 = 3.14;
        float numero6 = 3.14f;
        decimal numero7 = 3.14m;
        //Console.WriteLine(numero);


    //2- Tipo Booleano
        bool numero8 = false;//true

    //3- Tipos de texto
        char letra = 'a';
        char valor = '1';
        char caracter = '@';
        string texto = "Este curso é muito bom!";
        char primeiraLetra = texto[0];
        //Console.WriteLine(texto);
        //Console.WriteLine(primeiraLetra);
        string nome = "             Guilherme              ";
        string nomeSemEspaco = nome.Trim();
        //Console.WriteLine(nomeSemEspaco);
        //Console.WriteLine(nome);
        bool comecaComG = nomeSemEspaco.StartsWith("G"); //EndsWith
        //Console.WriteLine(comecaComG);
        string repla = nome.Replace(" ", "-");
        //Console.WriteLine(repla);
        bool contem = nome.Contains("Gui");// Equal(identico)
        //Console.WriteLine(contem);


    //4- Operações com Texto
        string texto1 = "A primeira frase";
        string texto2 = "A segunda frase";

        string paragrafo = texto1 + " " + texto2;
        //Console.WriteLine(paragrafo);

        string caminho = "C:\\teste";//@"C:\teste" O arroba da o mesmo resultado;
        //Console.WriteLine(caminho);

        string paragrafo2 = $"Frase 1. {7} {true} Frase 2.";// Interpolação de String
        //Console.WriteLine(paragrafo2);

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(paragrafo);
        stringBuilder.Append(paragrafo2);
        string resultado = stringBuilder.ToString();
        //Console.WriteLine(resultado);

        string texto3 = "O {0} tem {1} anos";
        string resultado2 = string.Format(texto3, "Guilherme", 24);
        //Console.WriteLine(resultado2);  


        //5- Datas e Horas
        DateOnly dia = new DateOnly(1999, 09, 29);
        string resultadodia = dia.ToLongDateString();
        string resultadodia2 = dia.ToString("d MMM yyyy" ,new CultureInfo("pt-BR"));
        //Console.WriteLine(resultadodia2);
        DateTime dia1 = new DateTime(1999, 09, 29, 19, 09, 29);
        //Console.WriteLine(dia1);
        DateTime hoje = DateTime.UtcNow; //Now(tempo da máquina)
       // Console.WriteLine(hoje);
        DateTime novaData = hoje.AddDays(5);
        //Console.WriteLine(novaData);



        //6- Outros Tipos de dados
        //enum
        NivelDeDificuldade nivel = NivelDeDificuldade.facil;
        int nivelInteiro = (int)nivel;
        //Console.WriteLine(nivel);
        //Console.WriteLine(nivelInteiro);

        //Var
        var valor1 = 15;// É necessário ter a atribuição do valor
        //Console.WriteLine(valor1);

        //Object
        object valor2 = 150;

        //Null
        int? valor3 = null;
        bool informouValor = valor3.HasValue;

        //7- Coleções
        //Array
        int[] inteiros = new int[10];
        int[] inteiros2 = [1, 2, 4];
        int[,] inteiros3 = new int[10, 10];
        inteiros[0] = 1;
        inteiros3[0, 0] = 2;
        //Console.WriteLine(inteiros.Length);

        //Listas
        List<int> list = new List<int>();
        list.Add(4);
        list.Add(5);
        list.Add(6);
        list.Remove(4);//Remove o valor passado
        list.RemoveAt(0); // Remove a posição passada
        //list.Clear(); Apaga toda a lista
        int vari = list.First();//Retorna o primeiro elemento da lista(Last() Ultimo elemento, ElementAt() o elemento da posição)
        //Console.WriteLine(list.Count);
        //List de object permite qualquer tipo de variavel ao mesmo tempo
        List<string> strings = new List<string>();
        strings.Add("Hello");
        strings.Add("Mundo");
        string resultado6 = string.Join(" ", strings);// Junta todos elementos pelo separador do primeiro atributo
        //Console.WriteLine(resultado6);


        //Dicionarios
        Dictionary<string, int> dicionario = new Dictionary<string, int>();
        dicionario.Add("Ana", 100000);
        dicionario.Add("Gui", 0);
        bool existe = dicionario.ContainsKey("Ana");
        //Console.WriteLine(existe);
        //Console.WriteLine(dicionario["Ana"]);

        //HashSet Lista de valores unicos
        HashSet<int> hash = new HashSet<int>();
        hash.Add(1);
        hash.Add(2);
        hash.Add(1);
        //Console.WriteLine(hash.Count);

        //7- Funcoes, variaveis e debug
        var matematica = new OperacoesMatematicas();
        matematica.Adicionar(10, 15);
        matematica.Adicionar(valor1: 10, valor2: 15);//Pode ser em qualquer ordem já que é atribuido
        int resultado4 = matematica.Subtrair(20, 15);
        int resultado5 = matematica.Multiplicar(20, 15);
        (float divis, string autor) = matematica.Dividir(10, 2);
        //Console.WriteLine(divis + autor);

        //Criando classes com valores
        Carro carro = new Carro("Uno", new DateOnly(21, 01, 01), Cor.Azul);
        //carro.ImprimirModelo();

        //Static
        Console.WriteLine(OperacoesMatematicas.AdicionarSem(10, 2));


        //8- If, else e else if
        int numero9 = 15;
        bool verif = true;
        if (numero9 > 0 || verif == true)
        {
            Console.WriteLine("Positivo");
        }
        else if (numero9 == 0 && verif == true)
        {
            Console.WriteLine("Zero");
        }
        else 
        {
            Console.WriteLine("Negativo");
        }
        if(verif == true)
        {
            Console.WriteLine("Passou");
        }
        //Ternario
        string autor1 = verif == true ? "Guilherme" : "Ana";
        //Switch
        int numero10 = 4;

        switch (numero10)
        {
            case 0:
                {
                    Console.WriteLine("1");
                }break;
            case 1:
                {
                    Console.WriteLine("2");
                }break;
            case >= 2:
                {
                    Console.WriteLine("3");
                }break;
            default:
                {
                    Console.WriteLine("padrao");
                }break;
        }
        string result = numero10 switch
        {
            0 => "1",
            1=> "2",
            2=> "3",
            3=> "4",
            _=> "5"
        };

        //9- Looping
        var lista1 = new List<string>() {"Gui", "Ana", "Alice", "Lorde" };
        for(int i = 0; i < lista1.Count; i++)
        {
            Console.WriteLine(lista1[i]);
        }
        foreach(var item in lista1)
        {
            Console.WriteLine(item);
        }
        int numero11 = 0;
        while(numero11 < 3)
        {
            Console.WriteLine(numero11);
            numero11++;
        }
        do
        {
            Console.WriteLine("Entrou");
        } while (numero11 < 3);


        //10- Jump
        numero11 = 0;
        while (numero11 < 10)
        {
            if(numero11 == 3)
            {
                break;// Sai do Loop
            }
            Console.WriteLine(numero11);
            numero11++;
        }
        numero11 = 0;
        while (numero11 < 5)
        {
            numero11++;
            if (numero11 == 3)
            {
                continue;//Pula a iteração em questão
            }
            Console.WriteLine(numero11);
        }
        numero11 = 0;
        while (numero11 < 10)
        {
            if (numero11 == 3)
            {
                return;// Sai do Loop igual o break
            }
            Console.WriteLine(numero11);
            numero11++;
        }

    }
    /*
     namespace => Organizar as classes dentro do projeto(caixas);
classe => Molde(Características, propriedades e comportamentos de um objeto);
função => conjunto de Instruções(Nome de funções) 

Modificadores de acesso:
public = Qualquer outra classe que tiver instanciado um objeto daquela outra classe poderá utilizar a função
private = Somente aquela classe poderá utilizar a função
internal  = Poderá ser usada a função somente as classes dentro do projeto
static = Faz com que a função de uma classe não precise ser instanciada para acessar os metodos.

var pega o tipo da variavel automaticamente, deve possuir atribuição
object parecido com var mas n identifica o tipo

Debugar= Criar o break Point e usar F10 para avançar, passar o mouse na variavel, F11 entra na função, Shift F11 sai da função

.net = plataforma composta por varias bibliotecas
Compilação = C# -> Linguagem intermediaria dll -> CLR Common language runtime(De acordo com o processador)
jit = Just in time, compila na hora a partir da dll
gerar projeto no CLI = cmd na pasta -> new console -n olamundo
executar projeto no CLI = dotnet run
ajuda = dotnet new --help
build = verificar se ha erro no projeto ou solution
http = Protocolo de transferencia hipertexto
*/
}