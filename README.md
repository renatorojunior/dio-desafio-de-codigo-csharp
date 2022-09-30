# Desafios de Código 

## 1. Subtraindo o produto e a soma de um número inteiro

### Desafio

Dado um número inteiro ( **n** ) , retorne a **diferença** entre o **produto** de seus dígitos e a soma de seus dígitos.

### Entrada

A entrada consiste em um número inteiro ( **n** );

### Saída

A saída consiste na multiplicação do produto dos dígitos ( **n** ), a soma de seus dígitos e a diferenção entre o produto e a soma, como no exemplo a baixo: 

Exemplo de Entrada   | Exemplo de Saída
:-----: | :------:
234 | 15
4421 | 21

## 2. Encaixa ou Não?

### Desafio

Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.

### Entrada

A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro **N** que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores **A** e **B** maiores que zero, cada um deles podendo ter até 1000 dígitos.

### Saída

Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.

Exemplo de Entrada   | Exemplo de Saída
:----- | :------:
4 | 
56234523485723854755454545478690 78690 | Encaixa
5434554 543 | Não Encaixa
1243 1243 | Encaixa
54 64545454545454545454545454545454554 | Não Encaixa

# Desafios de Código 

## 3. Três Divisores

### Desafio

Dado um inteiro **n**, retorne true se **n** tiver exatamente *três divisores positivos*. Caso contrário, retorne **false**. O inteiro **m** é um divisor de **n**, se existe um inteiro **k** tal que **n = k * m**. 

### Entrada

O arquivo de entrada consiste em um inteiro **n** que será validada caso esteja sob as condições do desafio.

### Saída

A saída consistirá em um tipo **booleano: true** ou **false**. Como nos exemplos a baixo:

Exemplo de Entrada   | Exemplo de Saída
:-----: | :------:
2 | False
4 | True
