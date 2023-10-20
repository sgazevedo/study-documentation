# OCP - Open-Closed Principle (Princípio Aberto-Fechado)

> Objetos ou entidades devem estar abertos para extensão, mas fechados para modificação.

Ou seja, quando novos comportamentos e recursos precisam ser adicionados no software, devemos estender e não alterar o código fonte original.

### Exemplo prático do OCP:

Em um sistema hipotético de RH, temos duas classes que representam os contratos de trabalhos dos funcionários de uma pequena empresa, contratados e estagiários. Além de uma classe para processar a folha de pagamento.

~~~
public class ContratoClt
{
    public double Salario() 
    { 
        // ...
    }
}

public class Estagio
{
    public double BolsaAuxilio() 
    { 
        // ...
    }
}

class FolhaDePagamento
{
    public double Saldo { get; private set; }
    
    public void Calcular(object funcionario)
    {
        if (funcionario is ContratoClt) 
        {
            this.Saldo = (funcionario as ContratoClt).Salario();
        } 
        else if (funcionario is Estagio) 
        {
            this.Saldo = (funcionario as Estagio).BolsaAuxilio();
        }
    }
}
~~~

A classe FolhaDePagamento precisa verificar o funcionário para aplicar a regra de negócio correta na hora do pagamento. Supondo que a empresa cresceu e resolveu trabalhar com funcionários PJ, obviamente seria necessário modificar essa classe! Sendo assim, estaríamos quebrando o princípio Open-Closed do SOLID.

### Qual o problema de se alterar a classe FolhaDePagamento?

Não seria mais fácil apenas acrescentar mais um IF e verificar o novo tipo de funcionário PJ aplicando as respectivas regras? Sim, e provavelmente essa seria a solução que programadores menos experientes iriam fazer. Mas, esse é exatamente o problema! __Alterar uma classe já existente para adicionar um novo comportamento, corremos um sério risco de introduzir bugs em algo que já estava funcionando.__

Como adicionamos um novo comportamento sem alterar o código fonte já existente?

O guru Uncle Bob resumiu a solução em uma frase:

> Separate extensible behavior behind an interface, and flip the dependencies.

Em tradução direta, seria:

> Separe o comportamento extensível por trás de uma interface e inverta as dependências.

O que devemos fazer é concentrar nos aspectos essênciais do contexto, abstraindo-os para uma interface. Se as abstrações são bem definidas, logo o software estará aberto para extensão.

### Aplicando OCP na prática

Voltando para o nosso exemplo, podemos concluir que o contexto que estamos lidando é a remuneração dos contratos de trabalho, aplicando as premissas de se isolar o comportamento extensível atrás de uma interface, podemos criar uma interface com o nome __Remuneravel__ contendo o método remuneracao(), e fazer com que nossas classes de contrato de trabalho implementem essa interface. Além disso, iremos colocar as regras de calculo de remuneração para suas respectivas classes, dentro do método remuneracao(), fazendo com que a classe FolhaDePagamento dependa somente da interface Remuneravel que iremos criar.

Veja o código refatorado abaixo:

~~~
public interface IRemuneravel
{
    double Remuneracao();
}

class ContratoClt : IRemuneravel
{
    public double Remuneracao()
    {
        //...
    }
}

class Estagio : IRemuneravel
{
    public double Remuneracao()
    {
        //...
    }
}

class FolhaDePagamento
{
    public double Saldo { get; private set; }
    
    public void Calcular(IRemuneravel funcionario)
    {
        this.Saldo = funcionario.Remuneracao();
    }
}
~~~

Agora a classe FolhaDePagamento não precisa mais saber quais métodos chamar para calcular. Ela será capaz de calcular o pagamento corretamente de qualquer novo tipo de funcionário que seja criado no futuro (ContratoPJ) — desde que ele implemente a interface Remuneravel — sem qualquer necessidade de alteração do seu código fonte. Dessa forma, acabamos de implementar o princípio de Aberto-Fechado do SOLID em nosso código!

Open-Closed Principle também é base para o padrão de projeto Strategy. A sua principal vantagem é a facilidade na adição de novos requisitos, diminuindo as chances de introduzir novos bugs — ou bugs de menor expressão — pois o novo comportamento fica isolado, e o que estava funcionando provavelmente continuará funcionando.