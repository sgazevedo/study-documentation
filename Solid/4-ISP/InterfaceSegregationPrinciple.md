# ISP — Interface Segregation Principle(Princípio da Segregação da Interface)

> Uma classe não deve ser forçada a implementar interfaces e métodos que não irão utilizar.

Esse princípio basicamente diz que é melhor criar interfaces mais específicas ao invés de termos uma única interface genérica.

### Vamos ver o ISP na prática através de códigos:

Em um cenário fictício para criação de um game de animais, teremos algumas aves que serão tratadas como personagens dentro do jogo. Sendo assim, criaremos uma interface Aves para abstrair o comportamento desses animais, depois faremos que nossas classes implementem essa interface, veja:

~~~
interface Aves
{
    void SetLocalizacao(int longitude, int latitude);
    void SetAltitude(int altitude);
    void Renderizar();
}

public class Papagaio : Aves
{
    public void SetLocalizacao(int longitude, int latitude)
    {
        //Faz alguma coisa
    }
    
    public void SetAltitude(int altitude)
    {
        //Faz alguma coisa   
    }
    
    public void Renderizar()
    {
        //Faz alguma coisa
    }
}

public class Pinguim : Aves
{
    public void SetLocalizacao(int longitude, int latitude)
    {
        //Faz alguma coisa
    }
        
    public void SetAltitude(int altitude)
    {
        //Não faz nada...  Pinguins são aves que não voam!
    }
    
    public void Renderizar()
    {
        //Faz alguma coisa
    }
}
~~~

Percebam que ao criar a interface Aves, atribuímos comportamentos genéricos e isso acabou forçando a classe Pinguim a implementar o método setAltitude(), do qual ela não deveria ter, pois pinguins não voam! Dessa forma, estamos violando o Interface Segregation Principle — E o LSP também!

Para resolver esse problema, devemos criar interfaces mais específicas, veja:

~~~
interface Aves
{
    void SetLocalizacao(int longitude, int latitude);    
    void Renderizar();
}

interface AvesQueVoam : Aves
{
    void SetAltitude(int altitude);
}

public class Papagaio : AvesQueVoam
{
    public void SetLocalizacao(int longitude, int latitude)
    {
        //Faz alguma coisa
    }
    
    public void SetAltitude(int altitude)
    {
        //Faz alguma coisa   
    }
    
    public void Renderizar()
    {
        //Faz alguma coisa
    }
}

public class Pinguim : Aves
{
    public void SetLocalizacao(int longitude, int latitude)
    {
        //Faz alguma coisa
    }
    
    public void Renderizar()
    {
        //Faz alguma coisa
    }
}
~~~

No exemplo acima, retiramos o método setAltitude() da interface Aves e adicionamos em uma interface derivada AvesQueVoam. Isso nos permitiu isolar os comportamentos das aves de maneira correta dentro do jogo, respeitando o princípio da segregação das interfaces.

Poderíamos melhorar ainda mais esse exemplo, criando uma interface Renderizavel pra abstrair esse comportamento.
