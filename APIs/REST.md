# REST (Representation State Transfer)

REST é um *estilo de arquitetura* para a concepção de sistemas distribuídos. Não é um padrão, não é uma tecnologia, mas é um conjunto de restrições, um conjunto de regras, tais como:
- Não possuir monitoração de estado (*stateless*)
- Ter um relacionamento *cliente/servidor*
- Ter uma *interface uniforme*

## Características e recursos


### Verbos

Usa verbos HTTP para mapear operações CRUD para requisições.

### Endpoint

Um Endpoint é a URL onde seu serviço pode ser acessado por uma aplicação cliente (recurso).

Exemplo: GET /api/categorias

### Retorno

O retorno de uma API ASP.NET Core por padrão e feito no formato JSON.

As principais regras de sintaxe JSON são:
- Dados JSON estão definidos aos pares no formato: nome : valor
- Os dados são separados por vírgulas (,)
- AS chaves {} contém objetos
- Os colchetes [] expressam matrizes/vetores

Também é retornado o Código de status HTTP, que indicam o resultado da request HTTP:
- 1XX - Informativo
- 2XX - Sucesso
- 3XX - Redirecionamento
- 4XX - Erro do cliente
- 5XX - Erro do Servidor

Códigos de status HTTP mais usados:
- 200 - OK
- 201 - Created
- 204 - No Content
- 400 - Bad Request
- 401 - Unauthorized
- 403 - Forbidden
- 404 - Not Found
- 500 - Internal Server Error
- 501 - Not Implemented
- 502 - Bad Gateway
- 503 - Service Unavailable