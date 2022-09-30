# Desafios de Código 

## 1. Subtraindo o produto e a soma de um número inteiro

### **Desafio**

Dado um número inteiro ( **n** ) , retorne a **diferença** entre o **produto** de seus dígitos e a soma de seus dígitos.

### **Entrada**

A entrada consiste em um número inteiro ( **n** );

### **Saída**

A saída consiste na multiplicação do produto dos dígitos ( **n** ), a soma de seus dígitos e a diferenção entre o produto e a soma, como no exemplo a baixo: 

Exemplo de Entrada   | Exemplo de Saída |
:-----: | :------:
234 | 15 |
4421 | 21 |

## 2. Encaixa ou Não?

### **Desafio**

Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.

### **Entrada**

A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro **N** que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores **A** e **B** maiores que zero, cada um deles podendo ter até 1000 dígitos.

### **Saída**

Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.

Exemplo de Entrada   | Exemplo de Saída
:----- | :------:
4 | 
56234523485723854755454545478690 78690 | Encaixa
5434554 543 | Não Encaixa
1243 1243 | Encaixa
54 64545454545454545454545454545454554 | Não Encaixa

## 3. Três Divisores

### **Desafio**

Dado um inteiro **n**, retorne true se **n** tiver exatamente *três divisores positivos*. Caso contrário, retorne **false**. O inteiro **m** é um divisor de **n**, se existe um inteiro **k** tal que **n = k * m**. 

### **Entrada**

O arquivo de entrada consiste em um inteiro **n** que será validada caso esteja sob as condições do desafio.

### **Saída**

A saída consistirá em um tipo **booleano: true** ou **false**. Como nos exemplos a baixo:

Exemplo de Entrada   | Exemplo de Saída
:-----: | :------:
2 | False
4 | True


## 4. Elemento Majoritário

### **Desafio**

Dado um array **nums** de tamanho **n**, retorne o **elemento majoritário**, isto é, o elemento que aparece o maior número de vezes no seu array.

### **Entrada**

A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas **nums** serão os valores da sua array.

### **Saída**

A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.

#### **- Exemplo 1**

Exemplo de Entrada   | Exemplo de Saída
:-----: | :------:
3 | 7
7 | 
5 |
7 |

#### **- Exemplo 2**

Exemplo de Entrada   | Exemplo de Saída
:-----: | :------:
9 | 1
2 |
1 |
1 |
1 |
2 |
2 |
2 | 
1 |
2 |

## 5. Aumento de Salário

### **Desafio**

A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

Sálario  | Percentual de Reajuste
:-----: | :------:
0 - 400.00 | 15%
400.01 - 800.00 | 12%
800.01 - 1200.00 | 10%
1200.01 - 2000.00 | 7%
Acima de 2000.00 | 4%

Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

### **Entrada**

A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, com duas casas decimais.

### **Saída**

Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.

Exemplo de Entrada   | Exemplo de Saída
:-----: | :------:
400.00 | Novo salario: 460.00
| | Reajuste ganho: 60.00
| | Em percentual: 15 %
800.01 | Novo salario: 880.01
| | Reajuste ganho: 80.00
| | Em percentual: 10 %
2000.00 | Novo salario: 2140.00
| | Reajuste ganho: 140.00
| | Em percentual: 7 %

## 6.  A Corrida de Tartarugas

### **Desafio**

A corrida de tartarugas é um esporte que cresceu muito nos últimos anos, fazendo com que vários competidores se dediquem a capturar tartarugas rápidas, e treina-las para faturar milhões em corridas pelo mundo. Porém a tarefa de capturar tartarugas não é uma tarefa muito fácil, pois quase todos esses répteis são bem lentos. Cada tartaruga é classificada em um nível dependendo de sua velocidade:


**Nível 1:** Se a velocidade é menor que 10 cm/h.

**Nível 2:** Se a velocidade é maior ou igual a 10 cm/h e menor que 20 cm/h.

**Nível 3:** Se a velocidade é maior ou igual a 20 cm/h .

Sua tarefa é identificar qual o nível de velocidade da tartaruga mais veloz de um grupo.

### **Entrada**

A entrada consiste de múltiplos casos de teste, e cada um consiste em duas linhas: A primeira linha contém um inteiro **L** (1 ≤ **L** ≤ 500) representando o número de tartarugas do grupo, e a segunda linha contém **L** inteiros **Vi** (1 ≤ **Vi** ≤ 50) representando as velocidades de cada tartaruga do grupo.

### **Saída**

Para cada caso de teste, imprima uma única linha indicando o nível de velocidade da tartaruga mais veloz do grupo.

Exemplo de Entrada   | Exemplo de Saída
:-----: | :------:
10 | 3
10 10 10 10 15 18 20 15 11 10 | 
10 | 1
1 5 2 9 5 5 8 4 4 3 |
10 | 2
19 9 1 4 5 8 6 11 9 7 |
