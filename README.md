# C#

Nos códigos fornecidos, é possível identificar o seguinte conteúdo já trabalhado:

Entrada e Saída de Dados:

Em todos os métodos, há o uso de Console.WriteLine para exibir mensagens e Console.ReadLine para capturar entradas do usuário. Essas funções são fundamentais para interagir com o usuário, permitindo que ele insira valores e receba respostas processadas.
Conversão de Tipos de Dados:

O método Convert.ToDouble é amplamente utilizado para converter as entradas de string (provenientes de Console.ReadLine) em valores numéricos do tipo double. Isso é essencial para realizar cálculos com números de ponto flutuante, como no cálculo de combustível, salário, média de notas e faturamento.
Estrutura Condicional (if/else):

A lógica condicional é aplicada no método calcularMedia da classe Media. O código verifica se a média é maior ou igual a 7.0 para determinar se o aluno foi aprovado ou reprovado.
Operações Matemáticas:

Todos os métodos realizam algum tipo de cálculo:
Combustível: cálculo da quantidade de litros abastecidos.
ContraCheque: cálculo do salário com aumento e desconto.
Media: cálculo da média aritmética entre duas notas.
Lanchonete: cálculo da quantidade de ingredientes e lucro/despesa.
Uso de Constantes:

Na classe Lanchonete, são definidas constantes (const) para os pesos e valores dos ingredientes (queijo, presunto, carne, pão). Isso demonstra o uso de valores imutáveis que podem ser referenciados ao longo do código.
Orientação a Objetos:

Cada uma das funcionalidades está organizada em classes (Combustivel, ContraCheque, Media, Lanchonete), cada uma encapsulando um comportamento específico.
Os métodos estão sendo chamados a partir do método Main, instanciando as classes e executando os cálculos conforme necessário.
Uso de Variáveis:

As variáveis são declaradas e utilizadas em cada método para armazenar temporariamente os dados inseridos pelo usuário, bem como os resultados dos cálculos.
O que foi trabalhado:

Interação básica com o console (entrada e saída).
Conversão de tipos de dados (especialmente de string para double e int).
Estruturas de controle (condicionais).
Operações matemáticas simples (adição, subtração, multiplicação, divisão).
Conceitos de orientação a objetos (uso de classes e métodos).

Proposta de atividades:


1. Calcular o Custo Total dos Ingredientes
Atividade: Modifique o programa para calcular o custo total de todos os ingredientes separadamente e exiba o custo de cada um (queijo, presunto, hambúrguer, pão).
Objetivo: Praticar operações matemáticas e o uso de variáveis para cálculo.

'2'. Adicionar Ingredientes Extras
Atividade: Permitir que o usuário escolha quantidades extras de ingredientes, como mais queijo ou hambúrgueres duplos, e ajuste os cálculos de acordo.
Objetivo: Trabalhar com estruturas condicionais e entradas de usuário.

3. Aplicar Descontos para Grandes Quantidades
Atividade: Implementar uma funcionalidade que aplique descontos progressivos conforme o número de lanches. Por exemplo, 5% de desconto para 50 ou mais lanches, 10% para 100 ou mais.
Objetivo: Praticar lógica condicional (uso de if/else) e cálculos com porcentagens.

4. Inserir Variedade de Lanches
Atividade: Expandir o programa para permitir diferentes tipos de lanches com diferentes quantidades de ingredientes (ex.: lanche vegetariano, lanche com bacon, etc.).
Objetivo: Trabalhar com estruturas de seleção (switch/case ou múltiplos if/else), e encapsular melhor o código para diferentes receitas.

5. Cálculo de Impostos
Atividade: Adicione a funcionalidade de calcular o imposto sobre o lucro da lanchonete, usando uma alíquota de 5% sobre o lucro.
Objetivo: Praticar a aplicação de taxas e trabalhar com operações matemáticas mais complexas.

6. Controle de Estoque
Atividade: Implementar uma funcionalidade para gerenciar o estoque de ingredientes, subtraindo a quantidade necessária de cada ingrediente conforme os lanches são preparados.
Objetivo: Praticar manipulação de variáveis e o conceito de persistência de estado (simulação de controle de estoque).

7. Simular Vendas ao Longo do Dia
Atividade: Simular a venda de lanches ao longo do dia com diferentes quantidades. No final, exiba o total de lanches vendidos, o faturamento do dia e o lucro.
Objetivo: Trabalhar com laços (for, while) e acumulação de valores.

8. Relatório Diário
Atividade: Criar um relatório que mostre a quantidade total de ingredientes utilizados e o total de lanches vendidos no final do dia.
Objetivo: Praticar a manipulação e formatação de saídas, bem como acumulação de valores em variáveis.

9. Comparar o Custo de Diferentes Ingredientes
Atividade: Permitir ao usuário informar o preço dos ingredientes e calcular o lanche com base nas variações de preço, comparando o custo de produção em diferentes cenários (ex.: comparar o preço entre diferentes marcas de queijo ou carne).
Objetivo: Praticar entrada de dados, manipulação de variáveis e lógica condicional.

10. Implementar um Menu com Opções
Atividade: Criar um menu interativo para o usuário escolher diferentes funcionalidades, como calcular o custo de ingredientes, visualizar o lucro ou gerar um relatório.
Objetivo: Praticar o uso de estruturas de controle como switch/case e modularidade no código.

11. Verificação de Valores Válidos
Atividade: Adicionar validação para garantir que o usuário insira apenas valores válidos (por exemplo, um número positivo para a quantidade de lanches e preços dos ingredientes).
Objetivo: Praticar a validação de dados e manipulação de erros (uso de condicionais e laços de repetição para corrigir entradas).

12. Simulação de Aumento de Preços de Ingredientes
Atividade: Implementar um aumento automático de preços de acordo com a inflação, ou permitir que o usuário simule o impacto de um aumento nos preços dos ingredientes sobre o lucro.
Objetivo: Trabalhar com porcentagens e manipulação de variáveis.

13. Gerar Previsão de Demanda
Atividade: Criar uma função que simule a demanda futura com base nas vendas passadas, gerando uma estimativa de quantos lanches serão vendidos no próximo mês.
Objetivo: Praticar a lógica de programação e trabalhar com previsões simples.


14. Opção de Lanche Combo
Atividade: Implementar uma função que ofereça lanches no formato de combo (lanche + bebida + acompanhamento) e ajuste o faturamento, despesa e lucro de acordo.
Objetivo: Praticar a manipulação de variáveis e ajustar os cálculos com base em diferentes opções de produto.
