# SRP - Single Responsiblity Principle

> Uma classe deve ter um, e somente um, motivo para mudar.

Esse princípio declara que uma classe deve ser especializada em um único assunto e possuir apenas uma responsabilidade dentro do software, ou seja, a classe deve ter uma única tarefa ou ação para executar.

Quando estamos aprendendo programação orientada a objetos, sem sabermos, damos a uma classe mais de uma responsabilidade e acabamos criando classes que fazem de tudo — God Class. Num primeiro momento isso pode parecer eficiente, mas como as responsabilidades acabam se misturando, quando há necessidade de realizar alterações nessa classe, será difícil modificar uma dessas responsabilidades sem comprometer as outras. Toda alteração acaba sendo introduzida com um certo nível de incerteza em nosso sistema — principalmente se não existirem testes automatizados!

A violação do Single Responsibility Principle pode gerar alguns problemas, sendo eles:

- Falta de coesão — uma classe não deve assumir responsabilidades que não são suas;
- Alto acoplamento — Mais responsabilidades geram um maior nível de dependências, deixando o sistema engessado e frágil para alterações;
- Dificuldades na implementação de testes automatizados — É difícil de "mockar" esse tipo de classe;
- Dificuldades para reaproveitar o código;

O princípio da responsabilidade única não se limita somente a classes, ele também pode ser aplicado em métodos e funções, ou seja, tudo que é responsável por executar uma ação, deve ser responsável por apenas aquilo que se propõe a fazer.

O SRP é um dos princípios mais importantes, ele acaba sendo a base para outros princípios e padrões porque aborda temas como acoplamento e coesão, características que todo código orientado a objetos deveria ter.

Violação de SRP:
~~~
public interface Modem
{
	void Dial(string pno); // Discar
	void Hangup(); // Desligar
	void Send(char c); // Enviar
	char Recv(); // Receber
}
~~~

Refatorado:
~~~
public interface Modem : DataChannel, Connection
{
}

public interface DataChannel
{
	void Send(char c); // Enviar
	char Recv(); // Receber
}

public interface Connection
{
	void Dial(string pno); // Discar
	void Hangup(); // Desligar
}
~~~
