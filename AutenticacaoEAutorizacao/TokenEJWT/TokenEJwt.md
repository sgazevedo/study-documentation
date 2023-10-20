# Tokens e JWT

Tokens e JWT (JSON Web Tokens) são conceitos relacionados à autenticação e autorização em sistemas de software, especialmente em aplicações web e serviços RESTful. Eles desempenham um papel fundamental na segurança e na gestão de sessões de usuário.

### Token

Um token é uma pequena unidade de dados que contém informações de autenticação e autorização. Ele é usado para verificar a identidade do usuário e conceder ou negar acesso a recursos ou funcionalidades em um sistema. Existem vários tipos de tokens, incluindo tokens de autenticação, tokens de autorização e tokens de sessão.

- __Token de autenticação__: É usado para verificar a identidade do usuário. Geralmente, um usuário fornece suas credenciais (como nome de usuário e senha) e, após a verificação bem-sucedida, um token de autenticação é gerado e enviado de volta ao usuário. Este token é então usado para autenticar as solicitações subsequentes do usuário.

- __Token de autorização__: É usado para conceder acesso a recursos específicos com base nas permissões do usuário. Por exemplo, em um aplicativo de mídia social, um token de autorização pode determinar se um usuário tem permissão para acessar o perfil de outro usuário ou postar em um grupo específico.

- __Token de sessão__: É usado para rastrear o estado da sessão de um usuário. Ele pode conter informações sobre a sessão, como identificador de sessão, data de expiração e outras informações relevantes. Os tokens de sessão são frequentemente usados em aplicativos da web para manter o estado do usuário entre as solicitações HTTP.

### JWT (JSON Web Token):

JWT é um formato específico de token que é codificado em JSON (JavaScript Object Notation) e usado para representar informações de maneira segura e compacta. JWTs são frequentemente usados em sistemas distribuídos para autenticação e autorização, pois podem ser facilmente transmitidos entre partes e verificados sem a necessidade de consultar um banco de dados central.

Um JWT é composto por três partes separadas por pontos (.):

- __Header (cabeçalho)__: Contém informações sobre o tipo de token e o algoritmo de assinatura usado.
- __Payload (carga)__: Contém as informações que o token carrega, como dados do usuário ou outras informações relevantes.
- __Signature (assinatura)__: É usada para verificar a integridade do token e garantir que ele não tenha sido adulterado. A assinatura é gerada usando uma chave secreta conhecida apenas pelo emissor e pelo receptor.
Os JWTs são frequentemente usados em sistemas de autenticação, onde um usuário faz login e recebe um JWT como prova de autenticação. Esse JWT é então incluído em todas as solicitações subsequentes como um cabeçalho de autorização e usado para verificar a identidade do usuário.

Em resumo, tokens são usados para autenticação e autorização em sistemas de software, enquanto JWTs são um formato específico de token que é comumente usado para representar informações de forma segura em sistemas distribuídos.