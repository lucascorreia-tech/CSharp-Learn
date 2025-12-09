## Explicado como fiz para resolver:

Primeiro preciso explicar que o problema se resolve em achar o número que se repete e qual é o número que teria que **estar** naquele lugar.

Vamos pensar assim: uma caixa de ferramenta possui `[1, 2, 3, 4]`, cada número representa uma ferramenta. Porém a minha veio com uma ferramenta repetida, ou seja, `[1, 2, 2, 4]`.

Somando cada caixa temos valores diferentes:

$$
\begin{aligned}
 \left[ 1 + 2 + 3 + 4 \right] &= 10 \\
 \left[ 1 + 2 + 2 + 4 \right] &= 9
\end{aligned}
$$

Vamos dizer que a soma esperada, que no caso é 10, deu diferente da soma real, que foi 9. Então faremos outra conta, na intenção de descobrir o número que está faltando:

$$
\begin{aligned}
 \text{Faltando} &= \text{SomaEsperada} - (\text{SomaReal} - \text{Repetido}) \\
 \text{Faltando} &= 10 - (9 - 2) \\
 \text{Faltando} &= 10 - 7 \\
 \text{Faltando} &= 3
\end{aligned}
$$

Assim a gente descobre que o número que falta é 3.

## Soluções que me ajudaram

A utilização do `long` ao invés do `int` foi só para não ter problema de overflow.

Já que o problema é de 1 até N, podemos utilizar a Fórmula de Gauss $S = \frac{n(n + 1)}{2}$. Assim, o problema que antes tinha uma Complexidade de **O(N)** passa a ter complexidade de **O(1)**. A intenção dessa fórmula é achar a Soma Esperada sem gastar tempo de processamento.
