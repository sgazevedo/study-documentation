# Autenticação e autorização

Autenticação e autorização são dois conceitos relacionados, mas distintos, que desempenham papéis fundamentais na segurança de sistemas de software. Eles são frequentemente usados em conjunto para proteger recursos e controlar o acesso de usuários. 

Em resumo, a autenticação lida com a verificação da identidade de um usuário, enquanto a autorização controla o acesso e as permissões desse usuário dentro do sistema após a autenticação ter sido bem-sucedida. Juntos, esses dois conceitos desempenham um papel crucial na segurança e na gestão de acesso em sistemas de software.

### Autenticação

Autenticação se refere ao processo de verificar a identidade de um usuário. É a maneira pela qual um sistema determina se um usuário é realmente quem ele afirma ser.

A autenticação envolve a apresentação de credenciais, como nome de usuário e senha, para o sistema. Essas credenciais são então verificadas em relação a registros de usuário armazenados em um banco de dados ou outro mecanismo de armazenamento.

Se as credenciais fornecidas pelo usuário coincidirem com as credenciais armazenadas, o usuário é autenticado com sucesso e recebe acesso ao sistema. Caso contrário, a autenticação falha e o acesso é negado.


### Autorização

Autorização diz respeito às permissões e aos direitos de acesso que um usuário autenticado tem dentro do sistema.

Depois que um usuário é autenticado, o sistema determina o que ele está autorizado a fazer e a que recursos ele tem acesso. Isso é feito com base nas regras de autorização predefinidas e nas permissões associadas ao usuário.

A autorização controla o acesso a recursos específicos ou ações dentro do sistema. Por exemplo, um usuário pode ser autorizado a ler arquivos, mas não a escrever neles. Ou um usuário pode ter permissão para acessar determinadas partes de um site, mas não outras.

A autorização é geralmente implementada com a ajuda de tokens de autorização ou outros mecanismos que carregam informações sobre as permissões do usuário.