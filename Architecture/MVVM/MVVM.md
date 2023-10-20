
# Arquitetura MVVM (Model-View-ViewModel)

A arquitetura MVVM (Model-View-ViewModel) é um padrão de arquitetura de software frequentemente utilizado em desenvolvimento de aplicativos, especialmente em aplicações de interface de usuário (UI), como aplicativos móveis e aplicativos da web. O MVVM é uma variação do padrão arquitetural Model-View-Controller (MVC) e foi introduzido pela Microsoft no contexto do desenvolvimento de aplicativos para a plataforma Windows Presentation Foundation (WPF) e Silverlight. No entanto, o MVVM é agora amplamente adotado em várias plataformas e tecnologias.

### Componentes

A arquitetura MVVM é composta por três componentes principais:

- __Model (Modelo)__: O Modelo representa a camada de dados da aplicação. Ele contém a lógica de negócios, os dados e as regras de validação. O Modelo não possui conhecimento sobre a interface do usuário.

- __View (Visão)__: A View é responsável pela apresentação da interface do usuário. Ela exibe os dados do Modelo e captura as interações do usuário. A View não contém lógica de negócios.

- __ViewModel (Modelo de Visualização)__: O ViewModel age como uma camada intermediária que conecta o Modelo e a View. Ele contém a lógica que formata e prepara os dados do Modelo para serem exibidos na View. Além disso, o ViewModel também lida com as interações do usuário e atualiza o Modelo conforme necessário.

### Funcionamento

O funcionamento do MVVM pode ser resumido da seguinte forma:

- A View está vinculada ao ViewModel por meio de técnicas de ligação de dados. Isso significa que os elementos da interface do usuário são automaticamente atualizados quando os dados no ViewModel mudam, e as interações do usuário são automaticamente refletidas no ViewModel.

- O ViewModel acessa os dados do Modelo e os apresenta de maneira adequada para a View.

- Quando o usuário interage com a interface do usuário, como clicando em um botão, a interação é capturada pelo ViewModel, que pode executar ações com base nessa interação e atualizar o Modelo conforme necessário.

### Vantagens

- __Separação de preocupações__: O MVVM promove uma clara separação de preocupações, facilitando a manutenção e o teste do código.

- __Reutilização de código__: Os ViewModels podem ser reutilizados em diferentes partes da aplicação ou em diferentes aplicativos.

- __Facilita o desenvolvimento colaborativo__: A separação entre View e ViewModel permite que desenvolvedores de interface do usuário e desenvolvedores de lógica de negócios trabalhem de forma independente.

- __Testabilidade__: A lógica de negócios no ViewModel é facilmente testável, pois não depende da interface do usuário.

### Desvantagens
- __Complexidade inicial__: Configurar uma estrutura MVVM pode ser mais complexo do que criar uma aplicação simples sem um padrão de arquitetura.

- __Overhead de código__: Em pequenas aplicações, a estrutura MVVM pode parecer excessiva e resultar em mais código do que o necessário.

- __Curva de aprendizado__: Pode haver uma curva de aprendizado para desenvolvedores que não estão familiarizados com o padrão MVVM.

## Referências

- [What Is MVVM Architecture?](https://builtin.com/software-engineering-perspectives/mvvm-architecture)