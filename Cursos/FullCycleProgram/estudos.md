## Arquitetura de software
### Fundamentos da arquitetura de software
Tipos de Arquitetura
Papel do Arquiteto de Software
Por que aprender arquitetura de Software
Arquitetura vs Design
Pilares da arquitetura de software
Requisitos arquiteturais
Características arquiteturais
Estilos arquiteturais
Performance
Escalabilidade

### Comunicação Entre Sistemas
Comunicação síncrona vs assíncrona
REST
gRPC
GraphQL
Filas com RabbitMQ
Apache Kafka

### Domain Driven Design
Entendendo DDD
Linguagem Ubíqua
Domínio e subdomínios
Contextos delimitados
Mapas de contextos
Design patterns

### Solid
Fundamentos do SOLID
Single Responsibility
Open/Closed
Liskov substitution
Interface segregation
Dependency inversion
SOLID na prática

### Event Storming na Prática
O que é Event Storming
Vantagens de se utilizar ES
Entendimento de atores
Levantamento de eventos
Transformando eventos em ações
Cronologia
Definição dos fluxos e Agregados
Descobrindo e definindo Contextos

### DDD: Modelagem Tática e Patterns
Modelagem estratégica vs tática
Entidades vs Agregados
Value Objects
Domain Services
Application Services
Domain Events
Factories
Respositories

### Clean Architecture
O que é Clean architecture
Histórico dos tipos arquiteturais
DDD vs Clean Architecture
Entidades vs Enterprise Business
Roles
Desenvolvimento orientado a Use
Cases
DTOs como Input e Output
Presenters vs DTO
Adaptadores e camadas externas
Gateways

### Arquitetura Hexagonal
Fundamentos
Motivações
Evoluções
Principais camadas
Direcionamento único
Dependency Inversion

### Sistemas monolíticos
O que são sistemas monolíticos
Monolíticos estão ultrapassados?
Porque sistemas monolíticos falham
Como criar um sistema monolítico escaláve
12 Fatores
Como criar um sistema monolítico modular
Sistemas monolíticos vs DDD

### Arquitetura baseada em microsserviços
O que são microsserviços
Sistemas monolíticos vs Microsserviços
Vantagens e desvantagens
9 Características
Comunicação síncrona vs assíncrona
Resiliência com microsserviços
Coeorografia vs Orquestração
Saga Pattern
Principais patterns
Trace distribuído

### EDA - Event Driven Architecture
O que é EDA?
Vantagens e desvantagens
Princípios do EDA
Events e Event Generator
Brokers
Mediator
Mediator vs Broker
Classificação de eventos
Event sourcing

### API Gateway
O que é API Gateway
Principais conceitos
Principais soluções
Projeto Kong e Konga
Roteamento
Plugins
Autenticação
Rate Limit
Stateful vs Stateless
Kong no Kubernetes

### RabbitMQ
Fundamentos de Mensageria
Conceitos básicos do RabbitMQ
Exchanges
Filas
Dinâmica de funcionamento
Garantias de entrega e recebimento

### Apache Kafka
Principais conceitos
Conceitos básicos a prática
Desenvolvendo aplicação
Kafka Connect na prática
Serviços gerenciados

### Autenticação e Keycloak
Introdução ao OAuth 2 e OpenID Connect
Iniciando com Keycloak
Geração de Access Token e IDToken
Atributos de usuário
Roles e Grupos
Gerenciamento de temas

### Service Discovery com Consul
Entendendo Service Discovery
Visão geral do Consul
Service Registry
Health check
Tipos de agentes
Criando Cluster
Criptografia
User Interface

### Arquitetura do projeto prático - Codeflix
Decisões arquiteturais
Microsserviços do Projeto
Dinâmica dos microsserviços
Diagrama C4
Autenticação
Docker, Kubernetes e Cloud Providers

---

## Desenvolvimento de Microsserviços

### Frontend com React.js
TypeScript
React Hooks
Material UI
Context API
Redux e Redux Saga
Uploads paralelos de imagens e vídeos

### .Net 6
Arquitetura limpa
API REST
Asp.Net MVC Core
Ambiente e aplicação Containerizados
Integração com RabbitMQ
Autenticação com Keycloack
Autenticação e validação de Token JWT e Roles
Integração com GCP Cloud Storage
Principais libs do ecossistema .Net
DDD e Clean Architecture

### Typescript com Nest.js
Arquitetura limpa
Nodejs utilizando o Framework Nest.js
DDD e Clean Arquitect
Boas práticas do Nest.js
Conceitos de Desenvolvimento de Microsserviços
API REST
Testes de Unidade, Integração e E2E utilizando JEST
Mensageria com RabbitMQ
Integração com GPC Cloud Storage
Integração Continua
Boas práticas para desenvolvimento de ambiente de desenvolvimento e produção

---

## DevOps

### Docker do básico ao avançado
Instalação
Gerenciamento básico de containers
Volumes
Networks
Docker-compose
Build de imagens
Trabalhando com templates
Otimizando imagens

### Integração contínua
Introdução
Trabalhando com Github Actions
Gerenciamento de Secrets
Geração automática de versão
Integração com diferente Dockerhub
Deploy no Kubernetes

### Práticas avançadas com Github
Regras importante para os branches
CODEOWNERS
Configuração do processo de Code
Review
Geração de Tags e Releases
Bumb versioning
Assinatura de commits
Semantical versioning
Conventional Commits

### Service Mesh com Istio
Conceitos básicos sobre Service Mesh
Instalando Istio
Virtual Service e Ingress Gateway
Regras para Load Balancer
Timeouts e Retries
Cirtcuite Breaker
Geração de certificados SSL

### Kubernetes
Introdução ao mundo Kubernetes
Configurando Kubernetes local com Kind
Pods, ReplicaSets e Deployments
Secrets e ConfigMaps
Gerenciamento de namespaces
Gerenciamento de recursos computacionais
Horizontal Pod Autoscaler
Kubernetes Lens
Instalação de pacotes com Helm

### OpenTelemetry
Conceitos básicos
Formatos de collector
Formatos de instrumentação
Trabalhando com Logs, métricas e tracing
Padrões abertos vs vendors

### Observabilidade
Prometheus e Grafana
Elastic Stack
Observabilidade com Kiali

### IaC com Terraform
Principais conceitos
Variáveis, Outputs e Datasources
Recursos na prática
Provisionando Cluster Kubernetes
Criação de módulos
States remoto

### API Gateway com Kong e Kubernetes
Kong como ingress
Principais plugins
Autenticação básica
Autenticação via introspecção

### Ansible
Entendendo o mundo Ansible
Inventário, módulos e argumentos
Rodando Ansible com Docker
Rodando Ansible na AWS
Playbooks
Ansible-galaxy

### GitOps com Argo CD
O que é GitOps
Principais conceitos
Dinâmica de funcionamento
Principais ferramentas
Iniciando com Argo CD
Introdução ao Kustomize
Realizando Deploy via Github Actions
Deploy manual vs automático
Realizando Rollback

### Gitflow
Entendendo Gitflow
Gitflow e Pull Requests
Trabalhando com Releases
Hotfix