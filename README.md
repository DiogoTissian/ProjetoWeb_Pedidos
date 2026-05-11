# ProjetoWeb: API de Pedidos
Projeto desenvolvido para a disciplina de Projetos Web da Uniftec. Período letivo 2/2026

## Objetivo
Desenvolver uma API para a consulta de pedidos, implementando as definições REST, permitindo ser integrada com outras aplicações

## Desenvolvimento
API construída em C# com o framework .NET Core

### Entidades
- Pedido
  
| Cmpo  | Tipo | Descrição |
| ------------- | ------------- | ------------- |
| Id | Guid | Id do pedido |
| UsuarioId  | Guid  | Id do usuário que fez o pedido  |
| ProdutosModel  | Lista de produtos  | Lista de produtos contidos dentro do pedido. Apenas uma abstração dos produtos, com informações essênciais  |
| DataPedido  | DateTime  | Data em que o pedido foi atualizado pela última vez  |
| StatusPedido  | int  | Indica o status do pedido: Pendente pagamento (0), Concluído (1) e Cancelado (-1) |

- Produto (Abstração)
  
| Cmpo  | Tipo | Descrição |
| ------------- | ------------- | ------------- |
| Id  | Guid  | Id do produto  |
| PedidoId | Guid | Id do pedido em que ele pertence |
| ProdutoId | Guid | Id do produto na tabela de produtos (consulta microsserviço) |
| Quantidade | int | Quantidade escolhida para o produto |
| Valor | decimal | Valor do produto unitário (consulta em microsserviço) |

### Endpoints
- GET - api/Pedido - Lista todos os pedidos salvos no banco de dados
Resposta:

- GET - api/Pedido/{id} - Lista o pedido do id especificado
Resposta:

- GET - api/Pedido/GetPedidosUsuario/{usuarioId} - Lista todos os pedidos do usuário especificado
Resposta:

- POST - api/Pedido - Insere um pedido no banco de dados
Resposta:

- PUT - api/Pedido - Atualiza um pedido no banco de dados
Resposta:

- DELETE - api/Pedido/{id} - Deleta um pedido especificado no banco de dados
Resposta:

- DELETE - api/Pedido/DeletePedidos/{usuarioid} - Deleta todos os pedidos de um usuário especificado
Resposta:

### Banco de dados
- PostgreSQL
- Scripts de criação de tabelas necessárias:
