# API de Demonstração ASP.NET Core

Este projeto é uma API de demonstração simples desenvolvida em ASP.NET Core, apresentando operações CRUD básicas para um recurso `Produto`.
![API](https://github.com/user-attachments/assets/593242d7-cbf8-4314-8d7c-a7143e304ee5)

## Tecnologias Utilizadas

- ASP.NET Core
- C#

## Estrutura do Projeto

O projeto contém um controlador `TesteController` que expõe os seguintes endpoints:

## Endpoints da API

A API expõe os seguintes endpoints para gerenciar produtos:

### `GET /api/demo`

Retorna uma lista de produtos. Atualmente, retorna um único produto de demonstração.

**Resposta de Sucesso (200 OK):**
```json
{
  "id": 1,
  "nome": "Arroz",
  "preco": 23,
  "quantidade": 1
}
```

### `GET /api/demo/{id}`

Retorna um produto específico pelo seu ID. Atualmente, retorna um único produto de demonstração, independentemente do ID fornecido.

**Parâmetros:**
- `id` (int): O ID do produto.

**Resposta de Sucesso (200 OK):**
```json
{
  "id": 1,
  "nome": "Arroz",
  "preco": 23,
  "quantidade": 1
}
```

**Resposta de Erro (404 Not Found):**
Se o produto não for encontrado.
![Status Code](https://github.com/user-attachments/assets/6517624e-5815-4d3b-8092-a01e27f28782)

**Por dentro do código:**
![c#](https://github.com/user-attachments/assets/75098732-1570-4a5a-b67d-e372e868c80e)

### `POST /api/demo`

Cria um novo produto.

**Corpo da Requisição (application/json):**
```json
{
  "id": 1,
  "nome": "Arroz",
  "preco": 23,
  "quantidade": 1
}
```

**Resposta de Sucesso (201 Created):**
Retorna o produto criado.
```json
{
  "id": 1,
  "nome": "Arroz",
  "preco": 23,
  "quantidade": 1
}
```

**Resposta de Erro (400 Bad Request):**
Se o corpo da requisição for nulo ou inválido.

### `PUT /api/demo/{id}`

Atualiza um produto existente.

**Parâmetros:**
- `id` (int): O ID do produto a ser atualizado.

**Corpo da Requisição (application/json):**
```json
{
  "id": 1,
  "nome": "Arroz",
  "preco": 23,
  "quantidade": 1
}
```

**Resposta de Sucesso (204 No Content):**

**Resposta de Erro (400 Bad Request):**
Se o produto for nulo ou o ID no corpo da requisição não corresponder ao ID da URL.

### `DELETE /api/demo/{id}`

Exclui um produto existente.

**Parâmetros:**
- `id` (int): O ID do produto a ser excluído.

**Resposta de Sucesso (204 No Content):**

**Resposta de Erro (404 Not Found):**
Se o produto não for encontrado.

## Utilização da Tag `<IncludeOpenAPIAnalyzers>` 

A tag `<IncludeOpenAPIAnalyzers>` é uma configuração presente nos arquivos `.csproj` de projetos ASP.NET Core, especialmente aqueles que desenvolvem APIs RESTful. Quando definida como `true`, ela ativa um conjunto de analisadores de código específicos para APIs web que utilizam o padrão OpenAPI (anteriormente conhecido como Swagger).


### Propósito e Funcionalidade

O principal objetivo desses analisadores é ajudar os desenvolvedores a criar APIs mais consistentes, bem documentadas e que sigam as convenções do OpenAPI. Eles atuam como ferramentas de análise estática de código, identificando possíveis problemas ou inconsistências na forma como os endpoints da API são definidos e como suas respostas são tratadas.

### Benefícios:

1.  **Melhoria da Documentação OpenAPI/Swagger**: Os analisadores podem inferir informações sobre os tipos de retorno, parâmetros e códigos de status HTTP esperados pelos seus endpoints. Isso ajuda a gerar uma documentação OpenAPI mais precisa e completa, que é crucial para ferramentas como o Swagger UI.

2.  **Validação de Convenções**: Eles verificam se os controladores e métodos da API estão seguindo as convenções recomendadas para APIs web. Por exemplo, podem alertar sobre a falta de atributos `[ProducesResponseType]` que indicam os possíveis tipos de resposta e códigos de status HTTP para um determinado endpoint [1].

3.  **Detecção de Erros em Tempo de Compilação**: Ao invés de descobrir problemas apenas em tempo de execução, os analisadores fornecem feedback imediato durante o desenvolvimento, destacando potenciais erros ou omissões que podem afetar a documentação ou o comportamento da API.

4.  **Consistência da API**: Ao aplicar um conjunto de regras e convenções, os analisadores contribuem para a criação de APIs mais consistentes em termos de design e comportamento, o que facilita o consumo por parte dos clientes.

## Como Executar o Projeto

1. Certifique-se de ter o .NET SDK instalado.
2. Navegue até o diretório raiz do projeto no terminal.
3. Execute o comando:
   ```bash
   dotnet run
   ```
4. A API estará disponível em `https://localhost:5001` (ou outra porta configurada).

## Contribuição

Sinta-se à vontade para contribuir com este projeto. Para isso, siga os passos:

1. Faça um fork do repositório.
2. Crie uma nova branch (`git checkout -b feature/sua-feature`).
3. Faça suas alterações e commit (`git commit -m 'Adiciona nova feature'`).
4. Envie para a branch original (`git push origin feature/sua-feature`).
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

## Referências

[1] [Use web API analyzers - Microsoft Learn](https://learn.microsoft.com/en-us/aspnet/core/web-api/advanced/analyzers?view=aspnetcore-9.0)


