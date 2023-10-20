# API Key

Uma API Key (chave de API, em português) é um código de autenticação utilizado para permitir o acesso a uma API (Interface de Programação de Aplicativos). As APIs são conjuntos de regras e protocolos que permitem que diferentes softwares se comuniquem entre si. Elas são usadas para permitir que aplicativos, sites e serviços acessem dados ou funcionalidades de outros sistemas ou serviços de forma controlada e segura.

A API Key é uma forma de autenticação que geralmente consiste em uma sequência alfanumérica única que é associada a um usuário, aplicativo ou serviço específico. Quando você faz uma solicitação para uma API que requer autenticação, você inclui sua API Key na solicitação. A API Key é então verificada pelo servidor da API para determinar se você tem permissão para acessar os recursos ou dados solicitados.

As API Keys são usadas para controlar o acesso à API e acompanhar o uso, permitindo que os provedores de serviços restrinjam o acesso apenas a usuários autorizados e rastreiem o uso da API para fins de monitoramento e faturamento. É importante proteger sua API Key, tratando-a como uma senha, para evitar que ela seja utilizada de forma não autorizada.

Em muitos casos, as API Keys são apenas uma forma de autenticação básica e podem ser substituídas por métodos mais seguros, como autenticação por token, que oferecem um nível superior de segurança. No entanto, as API Keys ainda são amplamente utilizadas em muitas APIs devido à sua simplicidade e facilidade de implementação.

No .NET, implementar a classe ApiKeyAttribute e regras:

````
[AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]
public class ApiKeyAttribute : Attribute, IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(
        ActionExecutingContext context,
        ActionExecutionDelegate next)
    {
      if (!context.HttpContext.Request.Query.TryGetValue(Configuration.ApiKeyName, out var extractedApiKey))
      {
        context.Result = new ContentResult()
        {
          StatusCode = 401,
          Content = "ApiKey não encontrada"
        };
        return;
      }

      if (!Configuration.ApiKey.Equals(extractedApiKey))
      {
        context.Result = new ContentResult()
        {
          StatusCode = 403,
          Content = "Acesso não autorizado"
        };
        return;
      }

      await next();
    }
}
````

Adicionar no método na controller o atributo ApiKey: 
````
[ApiKey]

````

