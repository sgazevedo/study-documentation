# OpenID Connect (OIDC)

O OpenID Connect (OIDC) é um protocolo de autenticação baseado no protocolo OAuth2 (que é usado para autorização). O OIDC usa os fluxos de mensagens padronizados do OAuth2 para prestar serviços de identidade.

O objetivo de design do OIDC é "tornar simples as coisas simples e tornar possíveis as coisas complicadas". 

Você pode implementar uma solução para isso. Ou utilizar soluções já prontas e consolidadas, como o Identity Server e KeyCloak.

Como o custo e risco de manter um OIDC próprio são altos, a recomendação é sempre começar do mais básico, implementando autenticação oAuth com JWT.

## Referências

- [Autenticação do OpenID Connect com a ID do Microsoft Entra](https://learn.microsoft.com/pt-br/azure/active-directory/architecture/auth-oidc)