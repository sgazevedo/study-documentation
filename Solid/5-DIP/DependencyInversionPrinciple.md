# DIP — Dependency Inversion Principle (Princípio da Inversão de Dependência)

> Dependa de abstrações e não de implementações.

De acordo com Uncle Bob, esse princípio pode ser definido da seguinte forma:

1. Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender da abstração.

2. Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.

No contexto da programação orientada a objetos, é comum que as pessoas confundam a Inversão de Dependência com a Injeção de Dependência, porém são coisas distintas, mas que relacionam entre si com um proposito em comum, deixar o código desacoplado.

Vamos entender tudo isso na prática através de exemplos:

~~~
public class PasswordReminder
{
    private MySQLConnection dbConnection;
    
    public PasswordReminder()
    {
        dbConnection = new MySQLConnection();
    }
    
    // Faz alguma coisa
}
~~~

Para recuperar a senha, a classe PasswordReminder, precisa conectar na base de dados, por tanto, ela cria um instancia da classe MySQLConnection em seu método construtor para realizar as respectivas operações.

Nesse pequeno trecho de código temos um __alto nível de acoplamento__, isso acontece porque a classe PasswordReminder tem a responsabilidade de criar uma instância da classe MySQLConnection. Se quiséssemos reaproveitar essa classe em outro sistema, teriamos obrigatoriamente de levar a classe MySQLConnection junto, portanto, temos um forte acoplamento aqui.

Para resolver esse problema de acoplamento, podemos refatorar nosso código da seguinte forma. Veja:

~~~
public class PasswordReminder
{
    private MySQLConnection dbConnection;
    
    public PasswordReminder(MySQLConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }
    
    // Faz alguma coisa
}
~~~

Com o código refatorado, a criação do objeto MySQLConnection deixa de ser uma responsabilidade da classe PasswordReminder, a classe de conexão com o banco de dados virou uma dependência que deve ser injetada via método construtor. Olha o que apareceu para nós: Injeção de Dependência!

Apesar de termos usado a injeção de dependência para melhorar o nível de acoplamento do nosso código, ele ainda viola o princípio da inversão de dependência!

Além de violar o DIP, se você prestar atenção na forma que o exemplo foi codificado irá perceber que ele também viola o Open-Closed Principle. Por exemplo, se precisarmos alterar o banco de dados de MySQL para Oracle teríamos que editar a classe PasswordReminder.

### Por que nosso exemplo refatorado viola o Dependency Inversion Principle?

Porque estamos dependendo de uma implementação e não de uma abstração, simples assim.

De acordo com a definição do DIP, _um módulo de alto nível não deve depender de módulos de baixo nível, ambos devem depender da abstração_. Então, a primeira coisa que precisamos fazer é identificar no nosso código qual é o módulo de alto nível e qual é o módulo de baixo nível. Módulo de alto nível é um módulo que depende de outros módulos.

No nosso exemplo, PasswordReminder depende da classe MySQLConnection. Sendo assim, PasswordReminder é o módulo de alto nível e MySQLConnection é o módulo de baixo nível. Mas, MySQLConnection é uma implementação e não uma abstração!

### Como refatoramos nosso exemplo para utilizar o DIP?

Se tratando de POO, você já ouviu aquela frase:

> _"Programe para uma interface e não para uma implementação."_

Pois bem, é exatamente o que iremos fazer, criar uma interface!

~~~
public interface IDBConnection
{
    public void Connect();
}
~~~

Agora, vamos refatorar nosso exemplo fazendo que nossos módulos de alto e baixo nível dependam da abstração proposta pela interface que acabamos de criar. Veja:

~~~
public interface IDBConnection
{
    public void Connect();
}

public class MySQLConnection : IDBConnection
{
    public void Connect()
    {
        // ...
    }
}

public class OracleConnection : IDBConnection
{
    public void Connect()
    {
        // ...
    }
}

public class PasswordReminder
{
    private IDBConnection dbConnection;
    
    public PasswordReminder(IDBConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }
    
    // Faz alguma coisa
}
~~~

Perfeito! Agora a classe PasswordReminder não tem a mínima ideia de qual banco de dados a aplicação irá utilizar. Dessa forma, não estamos mais violando o DIP, ambas as classes estão desacopladas e dependendo de uma abstração. Além disso, estamos favorecendo a reusabilidade do código e como "bônus" também estamos respeitando o SRP e o OCP.