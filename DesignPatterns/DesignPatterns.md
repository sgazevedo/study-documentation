
Singleton (Singleton Pattern):
O Singleton é um padrão de criação que garante que uma classe tenha apenas uma única instância e fornece um ponto de acesso global para essa instância. Isso é útil quando você deseja controlar estritamente o acesso a recursos compartilhados, como uma conexão de banco de dados ou configurações globais.

Factory Method (Factory Method Pattern):
O Factory Method é um padrão de criação que define uma interface para criar um objeto, mas permite que as subclasses escolham a classe concreta a ser instanciada. Isso ajuda a desacoplar o código que cria objetos do código que os utiliza, facilitando a extensibilidade e a manutenção.

Observer (Observer Pattern):
O Observer é um padrão comportamental que permite que um objeto (sujeito) notifique uma lista de objetos dependentes (observadores) sobre mudanças em seu estado. É amplamente utilizado em sistemas de eventos, como interfaces gráficas e notificações em tempo real.

Strategy (Strategy Pattern):
O Strategy é um padrão comportamental que permite que você defina uma família de algoritmos, coloque-os em classes separadas e faça com que sejam intercambiáveis. Isso permite que você escolha o algoritmo a ser utilizado em tempo de execução, tornando seu código mais flexível e extensível. Ele é útil quando você tem diferentes algoritmos ou estratégias que podem ser aplicados a um objeto, e deseja selecionar qual estratégia usar em tempo de execução.

Decorator (Decorator Pattern):
O Decorator é um padrão estrutural que permite que você adicione comportamento adicional a objetos individuais de forma dinâmica. Isso é feito envolvendo os objetos em classes decoradoras que têm a mesma interface que os objetos originais. É uma alternativa flexível à herança de classes para estender funcionalidades.