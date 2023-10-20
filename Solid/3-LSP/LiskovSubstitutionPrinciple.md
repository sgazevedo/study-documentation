# LSP— Liskov Substitution Principle (Princípio da substituição de Liskov)

> Uma classe derivada deve ser substituível por sua classe base.

O princípio da substituição de Liskov foi introduzido por Barbara Liskov em sua conferência "Data abstraction" em 1987. A definição formal de Liskov diz que:

> Se para cada objeto o1 do tipo S há um objeto o2 do tipo T de forma que, para todos os programas P definidos em termos de T, o comportamento de P é inalterado quando o1 é substituído por o2 então S é um subtipo de T

Um exemplo mais simples e de fácil compreensão dessa definição. Seria:

> se S é um subtipo de T, então os objetos do tipo T, em um programa, podem ser substituídos pelos objetos de tipo S sem que seja necessário alterar as propriedades deste programa. — Wikipedia.

Para facilitar o entendimento, veja esse princípio na prática neste simples exemplo:

~~~
public class A 
{
    public virtual string GetNome()
    {
        return "Meu nome é A";
    }
}

public class B : A 
{ 
    public override string GetNome()
    {
        return "Meu nome é B";
    }
}

public class Program
{
	public static void Main()
	{		
		var objeto1 = new A();
		var objeto2 = new B();

		
		ImprimeNome(objeto1); // Meu nome é A
		ImprimeNome(objeto2); // Meu nome é B
	}
	
	public static void ImprimeNome(A objeto)
	{
		Console.WriteLine(objeto.GetNome());
	}
}
~~~

Estamos passando como parâmetro tanto a classe pai como a classe derivada e o código continua funcionando da forma esperada.

### Exemplos de violação do LSP:

- Sobrescrever/implementar um método que não faz nada;
- Lançar uma exceção inesperada;
- Retornar valores de tipos diferentes da classe base;

~~~
// Sobrescrevendo um método que não faz nada...
public class ContratoDeTrabalho
{
    public double Saldo { get; private set; }

	public virtual void Remuneracao()
	{
		this.Saldo = double.MaxValue;
	}
}

public class Voluntario : ContratoDeTrabalho
{
    public override void Remuneracao()
    {
        // não faz nada
    }
}

// Lançando uma exceção inesperada...
public class MusicPlay
{
    public virtual void Play(string file)
    {
        Console.WriteLine("Playing music.");
    }
}

public class Mp3MusicPlay : MusicPlay
{
    public override void Play(string file)
    {
        if (new FileInfo(file).Extension != "mp3") 
		{
            throw new Exception();
        }
        
		base.Play(file);
    }
}
~~~

Para não violar o Liskov Substitution Principle, além de estruturar muito bem as suas abstrações, em alguns casos, você precisará usar a *injeção de dependência* e também usar outros princípios do SOLID, como por exemplo, o Open-Closed Principle e o Interface Segregation Principle.

Seguir o LSP nos permite usar o polimorfismo com mais confiança. Podemos chamar nossas classes derivadas referindo-se à sua classe base sem preocupações com resultados inesperados.