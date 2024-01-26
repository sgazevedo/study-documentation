# Domain-Driven Design
O DDD (Domain-Driven Design) é uma abordagem ao *design de software* que se baseia no conceito de domínio; é uma filosofia voltada ao domínio do negócio.

A principal ideia do DDD é a de que o mais importante em um software *não é seu código*, nem *sua arquitetura*, nem *a tecnologia* sobre a qual foi desenvolvido, mas sim o problema que o mesmo se propõe a resolver, ou em outras palavras, a complexidade da **regra de negócio**.

## O que DDD não é
- Não é arquitetura
- Não é tecnologia
- Não é framework
- Não é linguagem 
- Não é padrão

## Quando usar
O DDD vai te ajudar a resolver problemas na **complexidade do negócio**.

A abordagem Domain-Driven Design será útil em projetos onde a *complexidade da lógica de negócio* justificar a sua adoção.

- Não vai te ajudar a gerenciar melhor os dados
- Não vai te ajudar a aumentar o desempenho da sua aplicação
- Não vai te ajudar na complexidade da tecnologia usada no seu projeto

## Principais conceitos usados

**Ubiquitous Language** (Linguagem Ubíqua ou Linguagem Onipresente)
A Linguagem Ubíqua é uma linguagem estruturada em torno do *modelo de domínio* e usada por todos os membros da equipe para conectar todas as atividades da equipe ao software.

**Model**
O modelo de um projeto orientado a domínio é a sua solução para o problema. O Model geralmente representa um aspecto da realidade ou algo de interesse do negócio: o lanche, o cliente, a entrega, o produto, a venda, etc.

**Bounded Context**
Um Bounded Context é um limite conceitual no qual um modelo de domínio é aplicável, sendo que ele fornece um contexto para a linguagem ubíqua que é falada pela equipe e é expressa no modelo de software projetado.

**Context Maps** (Mapas de Contextos)
Os Context Maps permitem identificar o relacionamento entre os Bounded Context e as equipes responsáveis por cada contexto.

**Strategic Design** (Modelagem Estratégica)
O objetivo principal da modelagem estratéfica é definir 3 conveitos importantes com a equipe de projeto:
1) Ubiquitous Language
2) Bounded Context
3) Context Maps

**Tatical Design** (Modelagem Tática)
A modelagem tática esta relacionada com os blocos de construção da DDD, podendo ser: Entities, Services, Repositories, Value Objects, Agreggates, Events, Factories, Modules, etc.

Sendo um conjunto de *recursos técnicos* usados na construção do modelo de domínio do negócio.

**Architecture Design**
Refere-se aos estilos de arquitetura usado na implementação do DDD como: Hexagonal, Onion, Layered, CQRS, REST, etc.

Uma das grandes vantagens do DDD é que ele não requer o uso de nenhuma arquitetura específica.

## Benefícios
- Facilita a comunicação entre as equipes com o uso da *linguagem ubíqua*.
- O código do projeto fica mais coeso e menos acoplado.
- O negócio é melhor compreendido por todos da equipe, o que facilita o desenvolvimento.
- Melhora a flexibilidade do projeto devido ao domínio ser baseado no design orientado a objetos, estando bem encapsulado e modularizado.
- Enfatiza o domínio sobre a interface, onde o foco no domínio significa produzir um produto que ressoa bem com o público associado a esse domínio.

## Desvantagens
- Possui uma alta complexidade, exigindo experiência, conhecimento e capacidade de interação com os especialistas dos negócios.
- Requer um conhecimento robusto do domínio.
- Não adequado para projetos com uma *alta complexidade técnica*, nem para projetos simples como um CRUD básico.

## Referências

**Clean Architecture Essencial - ASP .NET Core com C#**, em [Udemy](https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/).