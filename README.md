# Message API
Esse projeto foi desenvolvido com foco em utilizar os princípios da arquitetura/design orientada a domínio (DDD), implementando também testes unitários e alguns conceitos de clean code e clean architeture, como injeção de dependências, modelo rico nas classes, princípios de responsabilidade única e máxima abstração de métodos (SOLID) entre outros.


TECHNOLOGIES
-----------------
Foram utilizados para este projeto os seguintes recursos:
- .NET 6
- ASP.NET MVC
- Entity Framework Core
- Identity
- DDD
- TDD
- JWT (Json Web Token)
- AutoMapper

ENVIRONMENTS
------------------
O arquivo ```appsettings.json``` contém a string de conexão com o banco.

INSTRUÇÕES
---------------------
Algumas considerações importantes:
- Esse projeto tem o intuito de simular uma situação real de negócio, mas é mais focado no aprendizado.
- Nesse modelo orientado a domínio é possível implementar testes unitários em praticamente todas as camadas da aplicação. No teste por questão de tempo foi aplicado nas classes do domínio e no repositório.
- Foram criadas migrations para inserção dos dados solicitados no banco. Não sendo necessário scripts SQL.


UTILIZAR O PROJETO
-------------
A API não está em produção, entretanto, caso queira utiliza-la, é bem fácil!

1° passo: Faça o pull do projeto;
2° passo: Troque a string de conexão do app.settings e no Contexto;
3° passo: Rode as migrations;
4° passo: Rode e consuma a API onde e como quiser!


PRINTS  DO PROJETO
--------------
Swagger: 
![image](https://github.com/JotaPeCarvalho/MessageProjectDDD/assets/91575096/c7ba5880-82c0-4f3b-a252-02c08199be8f)

Projeto: 
![image](https://github.com/JotaPeCarvalho/MessageProjectDDD/assets/91575096/6e7937b8-e034-4016-9c12-f611262eeb4e)
