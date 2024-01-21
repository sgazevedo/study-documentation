# Strategy Pattern

## Definição:
> Definir uma família de algoritmos, encapsular cada uma delas e torná-las intercambiáveis. Strategy permite que o algoritmo varie independentemente dos clientes que o utilizam. (GOF)

## Problemas que ataca
- Como uma classe pode utilizar um algoritmo definido dinamicamente?
- Como posso selecionar e trocar uma lógica em tempo de execução?

## Solução
- Encapsular os algoritmos possíveis para o mesmo problema em uma estrutura de Strategy
- O cliente irá delegar a execução para estas estratégias ao invés de possuir toda a lógica internamente.

## Referências
**C# Strategy Design Pattern**, em [DOFACTORY](https://www.dofactory.com/net/strategy-design-pattern). Acesso em: 20/01/2024
**Design Pattern - Strategy**, em [DEV Community](https://dev.to/marcosbelorio/design-pattern-strategy-111n). Acesso em: 20/01/2024
**Padrões de Projeto em JAVA na Prática!**, por Cod3r Cursos, em [Udemy]().


