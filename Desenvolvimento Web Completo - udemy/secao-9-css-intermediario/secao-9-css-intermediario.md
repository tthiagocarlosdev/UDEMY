# Desenvolvimento Web Completo

## Professor Hamilton Damasceno

## Seção 9: CSS Intermediário

### 52. Classes e IDs (Teoria)

Os **seletores CSS** são utilizados para indicar **quais elementos HTML receberão determinada regra de estilo**.

Uma regra CSS normalmente possui:

```css
seletor {
    propriedade: valor;
}
```

Por exemplo:

```css
p {
    color: blue;
}
```

Nesse caso:

- `p` → **seletor**
- `color` → **propriedade**
- `blue` → **valor**

O seletor `p` indica que a regra será aplicada aos elementos `<p>`.

------

#### Tipos de seletores

Existem diversos tipos de seletores CSS. Entre os mais importantes estão:

- **Seletor por elemento (tag)**
- **Seletor por ID**
- **Seletor por classe**
- **Seletor universal**
- **Seletor por atributo**
- **Seletores combinadores**

Nesta etapa, vamos dar atenção principalmente aos **seletores de ID e de classe**, pois são fundamentais para organizar e estilizar páginas HTML.

------

#### Seletor por elemento (tag)

É o seletor que utiliza diretamente o nome de uma tag HTML.

##### Exemplo

```css
p {
    color: blue;
}
```

Nesse caso, o seletor `p` seleciona **todos os elementos `<p>`** da página.

##### HTML

```html
<p>Primeiro parágrafo</p>
<p>Segundo parágrafo</p>
<p>Terceiro parágrafo</p>
```

Todos os parágrafos receberão a cor azul.

##### Quando utilizar?

É útil quando queremos aplicar uma mesma regra a **todos os elementos de determinado tipo**.

------

#### Seletor por ID

O **ID** é um identificador utilizado para identificar um elemento específico dentro do documento HTML.

No HTML, utilizamos o atributo:

```html
id="nome"
```

No CSS, utilizamos o símbolo `#` para selecionar esse elemento.

```css
#nome {
    color: red;
}
```

------

##### O que é um ID?

O `id` funciona como um **identificador único** para um elemento.

Por exemplo:

```html
<h1 id="titulo">Meu site</h1>
```

Podemos selecionar esse elemento no CSS utilizando:

```css
#titulo {
    color: red;
}
```

O `#` indica que estamos trabalhando com um **seletor de ID**.

------

##### Onde utilizar ID?

O ID é apropriado quando precisamos identificar **um elemento específico**.

Por exemplo:

```html
<p id="introducao">
    Bem-vindo ao meu site!
</p>
```

No CSS:

```css
#introducao {
    color: blue;
}
```

A regra será aplicada ao elemento que possui o ID `introducao`.

##### Regra importante

Um mesmo `id` deve ser utilizado para identificar **um único elemento** dentro da página.

Por isso, evite fazer:

```html
<p id="texto">Primeiro</p>
<p id="texto">Segundo</p>
```

O ideal é que cada elemento tenha um identificador diferente quando houver necessidade de identificá-los individualmente.

------

#### Seletor por classe

A **classe** é utilizada para **agrupar elementos que possuem uma característica em comum**.

No HTML, utilizamos:

```html
class="nome"
```

No CSS, utilizamos o símbolo `.` para selecionar uma classe.

```css
.nome {
    color: blue;
}
```

------

##### O que é uma classe?

Uma classe permite atribuir uma mesma característica a **vários elementos**.

Por exemplo:

```html
<p class="destaque">Primeiro texto</p>
<p class="destaque">Segundo texto</p>
<p>Terceiro texto</p>
```

No CSS:

```css
.destaque {
    color: red;
}
```

Os dois primeiros parágrafos ficarão vermelhos porque possuem a classe `destaque`.

O terceiro parágrafo não será afetado porque não possui essa classe.

------

#### Onde utilizar classes?

As classes são muito utilizadas quando vários elementos precisam compartilhar o mesmo estilo.

Por exemplo, podemos ter vários elementos que representam botões:

```html
<button class="botao">Salvar</button>
<button class="botao">Cancelar</button>
<button class="botao">Excluir</button>
```

No CSS:

```css
.botao {
    padding: 10px;
    border: 1px solid black;
}
```

Todos os elementos que possuem a classe `botao` receberão essas propriedades.

Isso evita repetir o mesmo CSS para cada elemento.

------

#### ID × Classe

Essa é uma diferença fundamental:

| Característica                          | ID                                 | Classe            |
| --------------------------------------- | ---------------------------------- | ----------------- |
| Símbolo no CSS                          | `#`                                | `.`               |
| HTML                                    | `id="nome"`                        | `class="nome"`    |
| Objetivo                                | Identificar um elemento específico | Agrupar elementos |
| Pode ser utilizado em vários elementos? | O ideal é não                      | Sim               |
| Exemplo                                 | `#menu`                            | `.botao`          |

Podemos pensar da seguinte maneira:

> **ID = identidade específica**

> **Classe = grupo ou característica compartilhada**

------

#### Exemplo utilizando ID e classe

### HTML

```html
<h1 id="titulo">Minha página</h1>

<p class="destaque">Primeiro texto</p>
<p class="destaque">Segundo texto</p>
<p>Terceiro texto</p>
```

###### CSS

```css
#titulo {
    color: blue;
}

.destaque {
    color: red;
}
```

Nesse exemplo:

- `#titulo` seleciona somente o `<h1>` que possui `id="titulo"`.
- `.destaque` seleciona os dois `<p>` que possuem `class="destaque"`.
- O terceiro `<p>` não possui a classe e não recebe essa regra.

------

#### Um elemento pode ter mais de uma classe

Um elemento HTML pode possuir **várias classes**.

Por exemplo:

```html
<p class="texto destaque grande">
    Meu texto
</p>
```

Esse elemento possui três classes:

- `texto`
- `destaque`
- `grande`

Podemos criar regras separadas:

```css
.texto {
    font-family: Arial;
}

.destaque {
    color: red;
}

.grande {
    font-size: 25px;
}
```

As três regras poderão ser aplicadas ao mesmo elemento.

------

#### Seletor universal

O seletor universal utiliza `*`.

```css
* {
    margin: 0;
}
```

O `*` seleciona **todos os elementos** da página.

###### Aplicabilidade

Pode ser utilizado para aplicar uma configuração geral aos elementos.

Um exemplo comum é remover as margens e espaçamentos padrão:

```css
* {
    margin: 0;
    padding: 0;
}
```

------

#### Seletor por atributo

Também podemos selecionar elementos com base em seus atributos.

Por exemplo:

```css
input[type="text"] {
    border: 1px solid blue;
}
```

Nesse caso, o seletor seleciona os elementos `<input>` cujo atributo `type` possui o valor `text`.

###### HTML

```html
<input type="text">
<input type="email">
<input type="password">
```

A regra será aplicada somente ao:

```html
<input type="text">
```

------

#### Seletores combinadores

Também podemos criar seletores que relacionam elementos.

Por exemplo:

```css
div p {
    color: red;
}
```

Esse seletor seleciona os elementos `<p>` que estão dentro de um `<div>`.

###### HTML

```html
<div>
    <p>Este parágrafo será vermelho.</p>
</div>

<p>Este não será vermelho.</p>
```

O primeiro `<p>` está dentro do `<div>`, portanto será selecionado.

------

#### Resumo dos principais seletores

| Tipo        | Sintaxe              | Função                                       |
| ----------- | -------------------- | -------------------------------------------- |
| Elemento    | `p`                  | Seleciona todos os `<p>`                     |
| ID          | `#titulo`            | Seleciona um elemento pelo ID                |
| Classe      | `.destaque`          | Seleciona elementos que possuem a classe     |
| Universal   | `*`                  | Seleciona todos os elementos                 |
| Atributo    | `input[type="text"]` | Seleciona elementos com determinado atributo |
| Descendente | `div p`              | Seleciona `<p>` dentro de `<div>`            |

------

#### Quando utilizar ID ou classe?

Uma maneira simples de decidir é perguntar:

##### "Quero identificar um elemento específico?"

Use **ID**:

```html
<header id="cabecalho">
#cabecalho {
    background-color: gray;
}
```

##### "Quero aplicar o mesmo estilo a vários elementos?"

Use **classe**:

```html
<p class="destaque">Texto 1</p>
<p class="destaque">Texto 2</p>
.destaque {
    color: red;
}
```

------

#### Resumo final

##### Seletor por elemento

> Seleciona elementos pelo nome da tag.

```css
p {
    color: blue;
}
```

##### ID

> Identifica um elemento específico.

**HTML:**

```html
<p id="principal">Texto</p>
```

**CSS:**

```css
#principal {
    color: red;
}
```

##### Classe

> Permite agrupar elementos que possuem uma característica ou estilo em comum.

**HTML:**

```html
<p class="destaque">Texto 1</p>
<p class="destaque">Texto 2</p>
```

**CSS:**

```css
.destaque {
    color: red;
}
```

##### Regra para memorizar

```text
# → ID → elemento específico

. → CLASS → grupo de elementos
```

> **ID identifica; classe agrupa.**



-----

-----



### 53. Classes e IDs (Prática)

#### Arquivo completo - index-americanas.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Americanas - página inicial</title>
    <link rel="stylesheet" href="./css/estilo-americanas.css">
</head>
<body>
    <div id="topo">
        <img src="./img/logo-americanas.png" alt="logo Americanas">
        <a href="index-americanas.html">Inicial</a> |
        <a href="">Mercado</a> |
        <a href="celulares-americanas.html">Celulares</a> |
        <a href="">Brinquedos</a> |
        <a href="">Eletrodomésticos</a> |
        <a href="">Notebook</a> |
        <a href="">TV e home theater</a> |
        <a href="">Perfumaria</a>
    </div>

    <div id="banner">
        <img src="./img/banner.png" alt="banner Americanas">
    </div>

    <div id="produtos-promocao">
        <h1>Produto em produtos promoção</h1>
        
        <div class="destaque">
            <img src="./img/p1.png" alt="gopro">
            <h2>Produto 1</h2>
            <p>
                Lorem ipsum dolor, sit amet consectetur adipisicing elit. Dignissimos perferendis iure sunt est ex odit corrupti voluptas veritatis, atque nesciunt enim et numquam id? Praesentium enim ea quae! Officiis, asperiores.
            </p>
        </div>

        <hr>

        <div>
            <img src="./img/p2.png" alt="gopro">
            <h2>Produto 2</h2>
            <p>
                Lorem ipsum dolor, sit amet consectetur adipisicing elit. Dignissimos perferendis iure sunt est ex odit corrupti voluptas veritatis, atque nesciunt enim et numquam id? Praesentium enim ea quae! Officiis, asperiores.
            </p>
        </div>
    </div>

</body>
</html>
```

-----

#### Arquivo completo - celulares-americanas.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Americanas - celulares</title>
    <link rel="stylesheet" href="./css/estilo-americanas.css">
</head>
<body>
    <div id="topo">
        <img src="./img/logo-americanas.png" alt="logo Americanas">
        <a href="index-americanas.html">Inicial</a> |
        <a href="">Mercado</a> |
        <a href="celulares-americanas.html">Celulares</a> |
        <a href="">Brinquedos</a> |
        <a href="">Eletrodomésticos</a> |
        <a href="">Notebook</a> |
        <a href="">TV e home theater</a> |
        <a href="">Perfumaria</a>
    </div>

    <div id="produtos-promocao">
        <h1>Celulares</h1>

        <div class="destaque">
            <img src="./img/celular1.png" alt="gopro">
            <h2>Celular 1</h2>
            <p>
                Lorem ipsum dolor, sit amet consectetur adipisicing elit. Dignissimos perferendis iure sunt est ex odit corrupti voluptas veritatis, atque nesciunt enim et numquam id? Praesentium enim ea quae! Officiis, asperiores.
            </p>
        </div>

        <hr>

        <div class="destaque">
            <img src="./img/celular2.png" alt="gopro">
            <h2>Celular 2</h2>
            <p>
                Lorem ipsum dolor, sit amet consectetur adipisicing elit. Dignissimos perferendis iure sunt est ex odit corrupti voluptas veritatis, atque nesciunt enim et numquam id? Praesentium enim ea quae! Officiis, asperiores.
            </p>
        </div>

        <hr>

        <div>
            <img src="./img/celular3.png" alt="gopro">
            <h2>Celular 3</h2>
            <p>
                Lorem ipsum dolor, sit amet consectetur adipisicing elit. Dignissimos perferendis iure sunt est ex odit corrupti voluptas veritatis, atque nesciunt enim et numquam id? Praesentium enim ea quae! Officiis, asperiores.
            </p>
        </div>

        <hr>

        <div >
            <img src="./img/celular4.png" alt="gopro">
            <h2>Celular 4</h2>
            <p>
                Lorem ipsum dolor, sit amet consectetur adipisicing elit. Dignissimos perferendis iure sunt est ex odit corrupti voluptas veritatis, atque nesciunt enim et numquam id? Praesentium enim ea quae! Officiis, asperiores.
            </p>
        </div>

    </div>

</body>
</html>
```

-----

#### Arquivo completo - estilo-americanas.css

```css
body {
    margin: 0;
    padding: 0;
}

#topo {
    background-color: red;
}

#banner {
    background-color: grey;
}

.destaque {
    background-color: orange;
}

```



---

---



### 54. Classes e IDs (Exercício)

#### Arquivo completo - class-id-exercicio.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercício Classe e Id</title>
    <link rel="stylesheet" href="./css/class-id-exercicio.css">
</head>
<body>
    <div id="div-topo">
        <h1>Mobile</h1>
        <span>10/03/2025</span>
        <span>por Thiago Carlos</span>
    </div>

    <div class="div-celular">
        <h2>Desenvolvimento com Android</h2>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam quos sapiente laudantium ipsum explicabo voluptatum, fugiat facilis ut, doloribus, repellendus quisquam molestiae asperiores aliquam. Commodi, hic? Ea accusantium maxime veniam.
        </p>
    </div>
    <div class="div-celular">
        <h2>Desenvolvimento com IOS</h2>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam quos sapiente laudantium ipsum explicabo voluptatum, fugiat facilis ut, doloribus, repellendus quisquam molestiae asperiores aliquam. Commodi, hic? Ea accusantium maxime veniam.
        </p>
    </div>
    <div class="div-celular div-flutter">
        <h2>Desenvolvimento com Flutter</h2>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam quos sapiente laudantium ipsum explicabo voluptatum, fugiat facilis ut, doloribus, repellendus quisquam molestiae asperiores aliquam. Commodi, hic? Ea accusantium maxime veniam.
        </p>
    </div>

    <div id="div-rodape">
        <p>
            Todos os direitos reservados.
        </p>
    </div>
    
</body>
</html>
```

-----

#### Arquivo completo - class-id-exercicio.css

```css
#div-topo {
    background-color: yellow;
}

.div-celular {
    background-color: grey;
}

.div-flutter {
    background-color: orange;
}

#div-rodape {
    border: 2px solid black;
}

#div-rodape p {
    margin: 0;
}
```



----

-----



### 55. Cascatas, Herança

No CSS, **cascata** e **herança** são dois conceitos fundamentais para entender como o navegador decide **quais estilos serão aplicados aos elementos HTML**.

Eles ajudam a explicar situações como:

- Por que uma regra CSS sobrescreve outra;
- Por que um elemento recebe o estilo definido em outro elemento;
- Por que algumas propriedades são herdadas e outras não;
- Como organizar regras CSS de maneira previsível.

------

#### 1. Cascata no CSS

##### O que é a cascata?

A **cascata** é o mecanismo utilizado pelo CSS para determinar **qual regra de estilo deve prevalecer quando existem várias regras aplicáveis ao mesmo elemento**.

É comum que um elemento possa receber estilos de diferentes regras.

Por exemplo:

```css
p {
    color: blue;
}

p {
    color: red;
}
```

As duas regras selecionam o mesmo elemento `<p>`.

Nesse caso, a regra que aparece **por último** possui prioridade quando as demais condições de prioridade são equivalentes.

O resultado será:

```text
Texto vermelho
```

------

#### 2. Por que a cascata é necessária?

Imagine uma página com vários arquivos CSS ou várias regras diferentes.

Um mesmo elemento pode ser atingido por várias regras.

Por exemplo:

```css
p {
    color: blue;
}

.destaque {
    color: red;
}
```

E no HTML:

```html
<p class="destaque">
    Texto de exemplo
</p>
```

O elemento `<p>` recebe duas regras:

- `p` → define `color: blue`;
- `.destaque` → define `color: red`.

O CSS precisa decidir qual delas terá prioridade.

Nesse caso, o seletor de **classe** possui maior especificidade que o seletor de elemento.

Portanto, o texto ficará vermelho.

------

#### 3. Ordem de prioridade no CSS

A cascata considera diversos fatores para determinar qual regra será aplicada.

De maneira simplificada, podemos pensar em:

1. **Importância**
2. **Especificidade**
3. **Ordem de aparecimento**

------

#### 4. Especificidade

A **especificidade** representa o quanto um seletor é específico para determinado elemento.

Por exemplo:

```css
p {
    color: blue;
}
```

É um seletor de elemento.

Já:

```css
.destaque {
    color: red;
}
```

é um seletor de classe e é mais específico.

E:

```css
#principal {
    color: green;
}
```

é um seletor de ID e é ainda mais específico.

Podemos representar de forma simplificada:

```text
Elemento < Classe < ID
```

Ou seja:

```text
p
↓
.destaque
↓
#principal
```

Quanto mais específico for o seletor, maior será sua prioridade na cascata.

------

#### 5. Exemplo de especificidade

HTML:

```html
<p id="principal" class="destaque">
    Texto de exemplo
</p>
```

CSS:

```css
p {
    color: blue;
}

.destaque {
    color: red;
}

#principal {
    color: green;
}
```

O elemento possui os três seletores:

- `p`
- `.destaque`
- `#principal`

Como o ID possui maior especificidade, o resultado será:

```text
Texto verde
```

------

#### 6. Ordem das regras

Quando duas regras possuem a **mesma especificidade**, a ordem em que aparecem pode determinar qual será aplicada.

Exemplo:

```css
p {
    color: blue;
}

p {
    color: red;
}
```

As duas regras possuem o mesmo seletor.

Como a segunda regra aparece depois, ela prevalece.

Resultado:

```text
Texto vermelho
```

Podemos resumir:

> Quando as regras possuem a mesma prioridade e especificidade, a regra que aparece por último vence.

------

#### 7. `!important`

O `!important` pode aumentar a prioridade de uma declaração CSS.

Exemplo:

```css
p {
    color: blue !important;
}

p {
    color: red;
}
```

Nesse caso, o `blue` será aplicado porque a declaração possui `!important`.

Apesar de existir, o uso excessivo de `!important` não é recomendado, pois pode dificultar a manutenção e o entendimento do CSS.

------

#### 8. Herança no CSS

##### O que é herança?

A **herança** é o mecanismo pelo qual determinadas propriedades CSS são transmitidas de um elemento **pai para seus elementos filhos**.

Por exemplo:

```html
<div>
    <p>Texto do parágrafo.</p>
</div>
```

Podemos definir uma propriedade no `<div>`:

```css
div {
    color: blue;
}
```

O `<p>` poderá receber essa propriedade do elemento pai.

Visualmente:

```text
div
│
└── p
```

O `<p>` herda a propriedade `color` do `<div>`.

------

#### 9. Elemento pai e elemento filho

Para entender herança, precisamos compreender a relação entre os elementos.

```html
<div>
    <p>Texto</p>
</div>
```

Nesse exemplo:

- `<div>` → **elemento pai**
- `<p>` → **elemento filho**

Se houver outro elemento dentro do `<p>`:

```html
<div>
    <p>
        <strong>Texto</strong>
    </p>
</div>
```

Temos:

```text
div
└── p
    └── strong
```

O `<div>` é pai do `<p>`.

O `<p>` é pai do `<strong>`.

O `<strong>` é filho do `<p>`.

------

#### 10. Exemplo de herança

HTML:

```html
<div>
    <p>Primeiro parágrafo.</p>
    <p>Segundo parágrafo.</p>
</div>
```

CSS:

```css
div {
    color: blue;
}
```

Como `color` é uma propriedade que normalmente pode ser herdada, os parágrafos também receberão a cor azul.

O CSS pode ser entendido como:

```text
div → azul
 │
 ├── p → herda azul
 │
 └── p → herda azul
```

------

#### 11. Nem todas as propriedades são herdadas

É importante entender que **nem todas as propriedades CSS são herdadas automaticamente**.

Por exemplo, propriedades relacionadas ao texto frequentemente são herdadas:

- `color`
- `font-family`
- `font-size`
- `font-style`

Já propriedades relacionadas à caixa normalmente não são herdadas automaticamente:

- `margin`
- `padding`
- `border`
- `width`
- `height`

Por exemplo:

```css
div {
    border: 2px solid red;
}
```

Os elementos filhos não receberão automaticamente essa mesma borda.

------

#### 12. Herança pode ser sobrescrita

Um elemento filho pode possuir sua própria regra CSS.

HTML:

```html
<div>
    <p>Texto azul</p>
</div>
```

CSS:

```css
div {
    color: blue;
}

p {
    color: red;
}
```

O `<p>` receberia inicialmente a cor do pai, mas possui uma regra própria.

Portanto:

```text
div → blue
p   → red
```

A regra específica do `<p>` prevalece sobre a herança.

------

#### 13. Cascata e herança trabalhando juntas

Os dois conceitos podem aparecer simultaneamente.

Considere:

```html
<div class="container">
    <p>Texto</p>
</div>
```

CSS:

```css
div {
    color: blue;
}

p {
    color: red;
}
```

O `<p>` poderia herdar `color: blue` do `<div>`.

Porém, existe uma regra específica para o próprio `<p>`:

```css
p {
    color: red;
}
```

Portanto, o `<p>` ficará vermelho.

Podemos representar:

```text
div
│
│ color: blue
│
└── p
      │
      └── color: red
```

A regra própria do elemento prevalece sobre o valor herdado.

------

#### 14. `inherit`

O CSS também possui o valor `inherit`.

Ele informa explicitamente que uma propriedade deve utilizar o valor herdado do elemento pai.

Exemplo:

```css
p {
    color: inherit;
}
```

Nesse caso, o `<p>` utilizará o valor de `color` fornecido pelo elemento pai.

Por exemplo:

```css
div {
    color: blue;
}

p {
    color: inherit;
}
```

O resultado será:

```text
div → blue
p   → blue
```

------

#### 15. Cascata × Herança

Embora estejam relacionados, são conceitos diferentes.

| Conceito    | O que significa?                                             |
| ----------- | ------------------------------------------------------------ |
| **Cascata** | Decide qual regra CSS deve prevalecer                        |
| **Herança** | Permite que determinadas propriedades passem do pai para os filhos |

##### Cascata

Pergunta:

> **"Existem várias regras para este elemento. Qual delas vence?"**

##### Herança

Pergunta:

> **"O elemento não possui uma regra própria. Ele pode receber essa propriedade do elemento pai?"**

------

#### 16. Exemplo completo

HTML:

```html
<div class="container">
    <h1>Título</h1>
    <p>Primeiro parágrafo.</p>
    <p class="destaque">Segundo parágrafo.</p>
</div>
```

CSS:

```css
.container {
    color: blue;
}

p {
    color: green;
}

.destaque {
    color: red;
}
```

Vamos analisar:

##### `<div>`

Possui:

```css
color: blue;
```

Portanto, seu texto é azul.

##### `<h1>`

Não possui uma regra específica para `color`.

Assim, pode herdar a cor do `<div>`:

```text
azul
```

##### Primeiro `<p>`

Possui:

```css
p {
    color: green;
}
```

Portanto, será verde.

##### Segundo `<p>`

Possui:

```html
class="destaque"
```

E existe:

```css
.destaque {
    color: red;
}
```

A classe possui maior especificidade que o seletor `p`.

Portanto, será vermelho.

------

#### Resumo

##### Cascata

A **cascata** determina qual regra CSS terá prioridade quando existem várias regras que podem ser aplicadas ao mesmo elemento.

Os principais fatores que devemos observar são:

- Importância;
- Especificidade;
- Ordem das regras.

De forma simplificada:

```text
elemento < classe < ID
```

------

##### Herança

A **herança** permite que determinadas propriedades CSS sejam transmitidas de um elemento pai para seus elementos filhos.

Exemplo:

```text
pai
│
├── filho
│
└── filho
```

Se uma propriedade herdável for definida no pai, os filhos poderão receber esse valor.

------

#### Regra para memorizar

> **Cascata = qual regra vence?**

> **Herança = o que o filho recebe do pai?**

Esses dois conceitos são fundamentais para compreender por que determinado estilo aparece em um elemento e por que uma regra CSS pode ou não sobrescrever outra.

---

### Arquivo compleo - cascata.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cascata e Herança no CSS</title>
    <style>
        p {
            background-color: peru;
        }
        div {
            color: brown;
        }
        div p{
            background-color: plum;
        }
    </style>
</head>
<body>
    <h1>Cascata e Herança no CSS</h1>
    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Minima odit atque voluptatum sunt, et doloremque nemo nisi ea sequi eos soluta natus! Non reiciendis ad sapiente. Necessitatibus consequatur aspernatur fuga.
    </p>
    <div>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Minima odit atque voluptatum sunt, et doloremque nemo nisi ea sequi eos soluta natus! Non reiciendis ad sapiente. Necessitatibus consequatur aspernatur fuga.
        </p>
    </div>
    
</body>
</html>
```



-----

-----



### 56. Unidades de medidas CSS - Parte 1

As **unidades de medida** são utilizadas no CSS para definir valores como:

- Tamanho de fontes;
- Largura e altura de elementos;
- Espaçamentos;
- Margens;
- Tamanhos de imagens;
- Entre outras propriedades.

Existem dois grandes grupos de unidades:

- **Unidades absolutas** → possuem um tamanho fixo, como `px`;
- **Unidades relativas** → seu tamanho depende de outro elemento ou da área disponível.

------

#### 1. O que é Pixel (`px`)?

O **pixel** é uma unidade de medida utilizada para definir tamanhos no CSS.

```css
font-size: 16px;
```

Nesse exemplo, o tamanho da fonte é definido como `16px`.

O `px` é considerado uma unidade **absoluta no CSS**, pois seu valor não depende diretamente do tamanho da fonte do elemento pai ou da largura do elemento pai.

##### Exemplo

```css
h1 {
    font-size: 32px;
}
```

O tamanho da fonte do `<h1>` será definido em `32px`.

##### Aplicabilidade

O `px` é bastante utilizado quando queremos ter um controle mais direto sobre determinado tamanho.

Exemplos:

```css
border: 2px solid black;

padding: 20px;

margin: 10px;

font-size: 16px;
```

------

#### 2. Unidades relativas

As **unidades relativas** possuem seu valor determinado em relação a outro valor.

Isso significa que o tamanho final pode mudar dependendo do contexto em que a unidade é utilizada.

Entre as unidades relativas estudadas estão:

- `em`
- `rem`
- `%`
- `vw`

Essas unidades são muito importantes para criar páginas mais **flexíveis e responsivas**.

------

#### 3. `em`

A unidade `em` é relativa ao **tamanho da fonte do elemento pai**.

Por exemplo, se o elemento pai possui:

```css
font-size: 20px;
```

e o elemento filho possui:

```css
font-size: 2em;
```

o tamanho será:

```text
2 × 20px = 40px
```

##### Exemplo

```css
div {
    font-size: 20px;
}

p {
    font-size: 2em;
}
```

Nesse caso:

- `<div>` → `20px`;
- `<p>` → `2em`;
- `2em` corresponde a `40px`.

##### Aplicabilidade

O `em` pode ser útil quando queremos que o tamanho de um elemento seja proporcional ao tamanho da fonte do seu contexto.

> **`em` → relativo ao tamanho da fonte do elemento pai.**

------

#### 4. `rem`

A unidade `rem` significa **root em**.

Ela é relativa ao tamanho da fonte do **elemento raiz**, que normalmente é o elemento `<html>`.

Por exemplo:

```css
html {
    font-size: 16px;
}
```

Então:

```css
h1 {
    font-size: 2rem;
}
```

Teremos:

```text
2 × 16px = 32px
```

Portanto:

```text
1rem = 16px
2rem = 32px
3rem = 48px
```

##### Exemplo

```css
html {
    font-size: 16px;
}

p {
    font-size: 1.5rem;
}
```

O tamanho da fonte do parágrafo será:

```text
1.5 × 16px = 24px
```

##### Aplicabilidade

O `rem` é muito utilizado quando queremos manter tamanhos proporcionais a uma referência global da página.

Uma vantagem importante é que o cálculo não depende da quantidade de elementos pai existentes.

> **`rem` → relativo ao tamanho da fonte do elemento raiz (`html`).**

------

#### 5. Diferença entre `em` e `rem`

Essa é uma diferença importante:

| Unidade | Referência                                 |
| ------- | ------------------------------------------ |
| `em`    | Tamanho da fonte do elemento pai           |
| `rem`   | Tamanho da fonte do elemento raiz (`html`) |

Por exemplo:

```css
html {
    font-size: 16px;
}

div {
    font-size: 20px;
}

p {
    font-size: 2em;
}
```

O `<p>` terá:

```text
2 × 20px = 40px
```

Porque `em` utiliza como referência o tamanho da fonte do elemento pai.

Agora:

```css
p {
    font-size: 2rem;
}
```

O `<p>` terá:

```text
2 × 16px = 32px
```

Porque `rem` utiliza como referência o `<html>`.

------

#### 6. Porcentagem (`%`)

A unidade `%` representa uma **porcentagem relativa a uma referência definida pelo contexto da propriedade**.

No caso mais comum de `width` e `height`, a porcentagem é calculada em relação ao tamanho do elemento pai.

##### Exemplo

Imagine um elemento pai com:

```css
width: 1000px;
```

E um elemento filho com:

```css
width: 50%;
```

O filho terá:

```text
50% de 1000px = 500px
```

##### Exemplo

```css
.container {
    width: 1000px;
}

.caixa {
    width: 50%;
}
```

A `.caixa` ocupará `50%` da largura disponível do elemento pai.

##### Aplicabilidade

A porcentagem é muito utilizada para criar elementos que se adaptem ao tamanho do elemento que os contém.

Por exemplo:

```css
img {
    width: 100%;
}
```

A imagem poderá ocupar toda a largura disponível do seu elemento pai.

> **`%` → geralmente relativo ao tamanho do elemento pai, dependendo da propriedade utilizada.**

------

#### 7. `vw` — Viewport Width

`vw` significa **Viewport Width**.

A unidade representa uma porcentagem da **largura da área de visualização (viewport)**.

> **1vw corresponde a 1% da largura da viewport.**

Portanto:

```text
100vw = 100% da largura da viewport
```

##### Exemplo

```css
div {
    width: 50vw;
}
```

O elemento terá uma largura correspondente a **50% da largura da viewport**.

Se a viewport tiver `1000px` de largura:

```text
50vw = 500px
```

Se a viewport tiver `500px`:

```text
50vw = 250px
```

##### Aplicabilidade

O `vw` é bastante útil para criar elementos cujo tamanho deve acompanhar a **largura da tela**.

Exemplo:

```css
.banner {
    width: 100vw;
}
```

O banner terá uma largura correspondente à largura da viewport.

------

#### 8. Comparando as unidades

| Unidade | Referência                                                   |
| ------- | ------------------------------------------------------------ |
| `px`    | Tamanho definido em pixels                                   |
| `em`    | Tamanho da fonte do elemento pai                             |
| `rem`   | Tamanho da fonte do elemento raiz (`html`)                   |
| `%`     | Percentual relativo ao contexto da propriedade, frequentemente ao elemento pai |
| `vw`    | Largura da viewport                                          |

------

#### 9. Exemplo prático

Podemos utilizar várias unidades na mesma página:

```css
html {
    font-size: 16px;
}

.container {
    width: 80%;
}

.titulo {
    font-size: 2rem;
}

.texto {
    font-size: 1.2em;
}

.banner {
    width: 100vw;
}

.caixa {
    width: 300px;
}
```

Cada unidade possui uma referência diferente:

```text
300px → tamanho definido em pixels

80% → relativo ao contexto do elemento pai

2rem → relativo à fonte do html

1.2em → relativo à fonte do elemento pai

100vw → relativo à largura da viewport
```

------

#### Resumo

##### `px`

> Unidade de tamanho em pixels.

```css
font-size: 16px;
```

------

##### `em`

> Relativo ao tamanho da fonte do elemento pai.

```css
font-size: 2em;
```

------

##### `rem`

> Relativo ao tamanho da fonte do elemento raiz (`html`).

```css
font-size: 2rem;
```

------

##### `%`

> Representa uma porcentagem relativa a uma referência determinada pelo contexto da propriedade, sendo frequentemente relacionada ao elemento pai.

```css
width: 50%;
```

------

##### `vw`

> Relativo à largura da viewport.

```css
width: 100vw;
```

#### Regra para memorizar

```text
px  → tamanho em pixels

em  → fonte do pai

rem → fonte do html

%   → porcentagem relativa ao contexto/pai

vw  → largura da viewport
```

Essas unidades são fundamentais para desenvolver páginas que possam **se adaptar a diferentes tamanhos de tela**, especialmente quando combinamos unidades relativas com técnicas de **design responsivo**.



---

---



### 57. Unidades de medidas CSS - Parte 2

#### Arquivo completo - porcentagem-pixel.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Porcentagem e Pixel</title>
    <style>
        .pixel {
            border: 1pz solid black;
            background-color: red;
            padding: 8px;
            width: 200px;
        }

        .porcentagem {
            border: 1px solid black;
            background-color: orange;
            padding: 8px;
            width: 50%;
        }

        #area {
            border: 3px solid black;
            width: 500px;
        }
    </style>
</head>
<body>

    <h1>Porcentagem e Pixel</h1>

    <div class="pixel">Pixel é a menor parte de uma i</div>
    <div class="porcentagem">Porcentagem (50%)</div>

    <hr>

    <div id="area">
        <div class="pixel">Pixel é a menor parte de uma i</div>
        <div class="porcentagem">Porcentagem (50%)</div>
    </div>

</body>
</html>
```



---



#### Arquivo completo - vw-vh.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>vw & vh</title>
    <style>
    body {
        /* border: 3px solid purple; */
        margin: 0;
    }

    .pixel {
        border: 1pz solid black;
        background-color: red;
        padding: 8px;
        width: 200px;
    }

    .porcentagem {
        border: 1px solid black;
        background-color: orange;
        padding: 8px;
        width: 50%;
    }

    .vw {
        border: 1px solid black;
        background-color: orange;
        padding: 8px;
        width: 50vw;
    }

    #area {
        border: 3px solid black;
        width: 500px;
    }
    </style>
</head>
<body>
    <h1>vw & vh</h1>

    <div class="pixel">Pixel é a menor parte de uma i</div>
    <div class="porcentagem">Porcentagem (50%)</div>
    <div class="vw">VW (50vw)</div>

    <hr>

    <div id="area">
        <div class="pixel">Pixel é a menor parte de uma i</div>
        <div class="porcentagem">Porcentagem (50%)</div>
        <div class="vw">VW (50vw)</div>
    </div>
</body>
</html>
```



---



#### Arquivo completo - em-rem.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>em & rem</title>
    <style>
        html {
            font-size: 16px;
        }
        body {
            font-size: 16px;
        }
        p {
            font-size: 2em;
        }
        .caixa-pequena {
            border: 3px solid black;
            font-size: 16px;
        }
        .caixa-grande {
            border: 3px solid red;
            font-size: 32px;
        }

        .um-em {
            font-size: 1em;
        }
        .dois-em {
            font-size: 2em;
        }
        .tres-em {
            font-size: 3em;
        }

        .em {
            font-size: 1em;
            border: 3px solid red;
        }
        .rem {
            font-size: 1rem;
            border: 3px solid purple;
        }
        .porcentagem {
            font-size: 100%;
            border: 3px solid green;
        }
        #area {
            border: 3px solid black;
            width: 500px;
            font-size: 32px;
        }
    </style>
</head>
<body>
    <h1>em & rem</h1>

    <div class="caixa-pequena">
        <p>Thiago Carlos</p>
            Thiago Carlos
    </div>

    <hr>

    <div class="caixa-grande">
        <p>Thiago Carlos</p>
            Thiago Carlos
    </div>

    <p class="tres-em">Destaque</p>
    <p class="um-em">Menor</p>
    <p class="dois-em">Médio</p>

    <hr>

    <div id="area">
        <p class="em">EM</p>
        <p class="rem">REM</p>
        <p class="porcentagem">PORCENTAGEM</p>
    </div>

</body>
</html>
```



---

---



### 58. Fontes customizadas

Ao desenvolver um site, podemos utilizar diferentes fontes para melhorar a **aparência, identidade visual e legibilidade** da página.

O CSS permite utilizar fontes que já existem no sistema, fontes disponibilizadas por serviços externos e também **arquivos de fontes armazenados dentro do próprio projeto**.

No código da aula, temos três formas diferentes de trabalhar com fontes:

1. **Fontes instaladas no sistema**
2. **Fontes externas usando `@import`**
3. **Fontes personalizadas usando `@font-face`**

------

#### 1. Fontes instaladas no sistema

Uma maneira simples de utilizar fontes é informar o nome de uma fonte que já esteja disponível no computador do usuário.

Exemplo:

```css
p {
    font-family: Arial;
}
```

Nesse caso, o navegador tentará utilizar a fonte `Arial`.

Também podemos informar uma **lista de fontes alternativas**:

```css
h1 {
    font-family: Arial, Helvetica, sans-serif;
}
```

Nesse caso, o navegador tenta utilizar as fontes na ordem apresentada:

1. `Arial`
2. `Helvetica`
3. `sans-serif`

Se `Arial` não estiver disponível, tenta `Helvetica`.

Se nenhuma das duas estiver disponível, utiliza uma fonte da família genérica `sans-serif`.

------

#### 2. Família de fontes

A propriedade:

```css
font-family
```

define a família tipográfica que será utilizada pelo elemento.

Exemplo:

```css
h1 {
    font-family: Arial, Helvetica, sans-serif;
}
```

No código da aula:

```css
h1 {
    font-family: 'CursedGothic', Arial, Helvetica, sans-serif;
}
```

Aqui existe uma fonte personalizada (`CursedGothic`) seguida de fontes alternativas.

Essa técnica é conhecida como **font stack**.

> **Font stack** é uma lista de fontes utilizada para fornecer alternativas caso determinada fonte não esteja disponível.

------

#### 3. Utilizando fontes externas com `@import`

Outra possibilidade é importar uma fonte de um serviço externo.

No código da aula foi utilizado o **Google Fonts**:

```css
@import url('https://fonts.googleapis.com/css2?family=Black+Ops+One&display=swap');
```

O `@import` permite importar uma folha de estilos externa para o CSS.

Nesse caso, a folha de estilos disponibilizada pelo Google Fonts fornece a fonte **Black Ops One**.

Depois de importada, ela pode ser utilizada normalmente:

```css
p {
    font-family: "Black Ops One", system-ui;
}
```

Assim, o navegador poderá utilizar a fonte `Black Ops One`.

------

#### 4. Como funciona o `@import`

Podemos dividir:

```css
@import url('endereço-da-fonte');
```

Em:

- `@import` → regra CSS utilizada para importar outro recurso CSS;
- `url()` → informa o endereço do recurso;
- URL → endereço onde está localizada a folha de estilos.

No exemplo:

```css
@import url('https://fonts.googleapis.com/css2?family=Black+Ops+One&display=swap');
```

o endereço aponta para uma folha de estilos do Google Fonts.

------

#### 5. Utilizando arquivos de fontes do próprio projeto

Também podemos armazenar arquivos de fontes dentro do próprio projeto.

Para isso, utilizamos:

```css
@font-face
```

O `@font-face` permite **definir uma fonte personalizada** e informar ao navegador onde está localizado o arquivo dessa fonte.

No código:

```css
@font-face {
    font-family: 'CursedGothic';
    src: url("./css/fonts/cursed_gothic/CursedGothic.ttf"), 
         url(./css/fonts/cursed_gothic/CursedGothic-Wood.ttf);
}
```

------

#### 6. `font-family` dentro do `@font-face`

A propriedade:

```css
font-family
```

define o **nome que será utilizado para referenciar a fonte no CSS**.

No exemplo:

```css
font-family: 'CursedGothic';
```

Esse nome será utilizado posteriormente:

```css
h1 {
    font-family: 'CursedGothic';
}
```

Portanto, podemos pensar:

```text
@font-face
    ↓
define um nome para a fonte
    ↓
font-family: 'CursedGothic'
    ↓
h1 utiliza esse nome
```

------

#### 7. `src` dentro do `@font-face`

A propriedade:

```css
src
```

informa **onde está localizado o arquivo da fonte**.

No exemplo:

```css
src: url("./css/fonts/cursed_gothic/CursedGothic.ttf");
```

O navegador procura o arquivo:

```text
./css/fonts/cursed_gothic/CursedGothic.ttf
```

Como o caminho começa com `./`, ele é um **caminho relativo** ao arquivo CSS/documento em que essa regra está sendo interpretada, conforme a estrutura do projeto.

------

#### 8. Vários arquivos de fonte

O código também apresenta mais de uma URL:

```css
@font-face {
    font-family: 'CursedGothic';
    src: url("./css/fonts/cursed_gothic/CursedGothic.ttf"), 
         url(./css/fonts/cursed_gothic/CursedGothic-Wood.ttf);
}
```

A propriedade `src` pode indicar diferentes fontes/formas de carregamento para uma mesma família, mas, para um projeto real, é importante configurar corretamente os formatos e variantes da fonte.

------

#### 9. Outra fonte personalizada com `@font-face`

O código possui outra definição:

```css
@font-face {
    font-family: 'Audiowide';
    src: url("css/fonts/Audiowide/Audiowide-Regular.ttf");
}
```

Aqui temos:

- Nome definido → `Audiowide`;
- Arquivo da fonte → `Audiowide-Regular.ttf`.

Depois ela é utilizada:

```css
h2 {
    font-family: 'Audiowide';
}
```

------

#### 10. Formatos de arquivos de fontes

Existem diferentes formatos de arquivos de fontes que podem ser utilizados na Web.

Alguns dos mais conhecidos são:

| Formato                | Extensão |
| ---------------------- | -------- |
| TrueType               | `.ttf`   |
| OpenType               | `.otf`   |
| Web Open Font Format   | `.woff`  |
| Web Open Font Format 2 | `.woff2` |

No código da aula são utilizados arquivos:

```text
.ttf
```

como:

```text
CursedGothic.ttf
Audiowide-Regular.ttf
```

------

#### 11. `font-weight`

Além da família da fonte, podemos controlar o **peso** da fonte utilizando:

```css
font-weight
```

No código:

```css
p {
    font-family: "Black Ops One", system-ui;
    font-weight: 400;
}
```

O valor `400` normalmente representa o peso **normal**.

Alguns valores comuns:

```text
100 → muito fino
200 → fino
300 → leve
400 → normal
500 → médio
600 → seminegrito
700 → negrito
800 → muito negrito
900 → extremamente negrito
```

A disponibilidade desses pesos depende da fonte utilizada.

------

#### 12. `font-style`

A propriedade:

```css
font-style
```

define o estilo da fonte.

No código:

```css
p {
    font-style: normal;
}
```

O valor `normal` indica que a fonte será exibida no estilo normal.

Um valor bastante conhecido é:

```css
font-style: italic;
```

que aplica o estilo itálico, desde que a fonte tenha suporte apropriado.

------

#### 13. `font-size`

A propriedade:

```css
font-size
```

define o tamanho da fonte.

No código:

```css
h2 {
    font-size: 3em;
}
```

O tamanho é definido utilizando a unidade relativa `em`.

No parágrafo:

```css
p {
    font-size: 1.5em;
}
```

Portanto, além de escolher a fonte, também podemos controlar seu tamanho.

------

#### 14. Analisando o `<h1>` da aula

O código possui:

```css
h1 {
    font-family: 'CursedGothic', Arial, Helvetica, sans-serif;
}
```

A prioridade será:

1. `CursedGothic`
2. `Arial`
3. `Helvetica`
4. `sans-serif`

A ideia é que `CursedGothic` seja a fonte principal e as demais funcionem como alternativas.

------

#### 15. Analisando o `<h2>` da aula

O `<h2>` utiliza:

```css
h2 {
    font-family: 'Audiowide';
    font-size: 3em;
}
```

Aqui temos duas propriedades:

##### `font-family`

Define a família:

```css
font-family: 'Audiowide';
```

##### `font-size`

Define o tamanho:

```css
font-size: 3em;
```

Portanto, o `<h2>` utiliza a fonte personalizada `Audiowide` e possui tamanho de `3em`.

------

#### 16. Analisando o `<p>` da aula

O parágrafo utiliza:

```css
p {
    font-family: "Black Ops One", system-ui;
    font-weight: 400;
    font-style: normal;
    font-size: 1.5em;
}
```

Temos:

| Propriedade   | Valor                        | Função           |
| ------------- | ---------------------------- | ---------------- |
| `font-family` | `Black Ops One`, `system-ui` | Define a família |
| `font-weight` | `400`                        | Define o peso    |
| `font-style`  | `normal`                     | Define o estilo  |
| `font-size`   | `1.5em`                      | Define o tamanho |

------

#### 17. Três maneiras apresentadas na aula

Podemos resumir as formas utilizadas no código:

##### 1. Fonte já disponível no sistema

```css
font-family: Arial, Helvetica, sans-serif;
```

Utiliza fontes que podem estar disponíveis no sistema do usuário.

------

##### 2. Fonte externa com `@import`

```css
@import url('https://fonts.googleapis.com/...');
```

Carrega uma folha de estilos externa que disponibiliza a fonte.

No exemplo da aula:

```css
p {
    font-family: "Black Ops One", system-ui;
}
```

------

##### 3. Fonte personalizada com `@font-face`

```css
@font-face {
    font-family: 'Audiowide';
    src: url("css/fonts/Audiowide/Audiowide-Regular.ttf");
}
```

Permite utilizar um arquivo de fonte armazenado no projeto.

Depois:

```css
h2 {
    font-family: 'Audiowide';
}
```

------

#### Resumo

| Recurso       | Para que serve                                        |
| ------------- | ----------------------------------------------------- |
| `font-family` | Define a família da fonte                             |
| `@import`     | Importa uma folha de estilos externa                  |
| `@font-face`  | Define uma fonte personalizada a partir de um arquivo |
| `src`         | Indica a localização do arquivo da fonte              |
| `font-weight` | Define o peso da fonte                                |
| `font-style`  | Define o estilo da fonte                              |
| `font-size`   | Define o tamanho da fonte                             |

#### Regra para memorizar

```text
font-family → qual fonte usar

@import → importar fonte/folha de estilos externa

@font-face → cadastrar uma fonte personalizada

src → onde está o arquivo da fonte

font-size → tamanho

font-weight → peso

font-style → estilo
```

Assim, no desenvolvimento Web, você pode trabalhar tanto com **fontes disponíveis no sistema**, quanto com **fontes externas** e **fontes personalizadas armazenadas no próprio projeto**.

---

#### Arquivo completo - fontes-customizadas.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Fontes customizadas</title>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Black+Ops+One&display=swap');

        @font-face {
            font-family: 'CursedGothic';
            src: url("./css/fonts/cursed_gothic/CursedGothic.ttf"), 
                 url(./css/fonts/cursed_gothic/CursedGothic-Wood.ttf);
        }
        @font-face {
            font-family: 'Audiowide';
            src: url("css/fonts/Audiowide/Audiowide-Regular.ttf");
        }

        h1 {
            font-family: 'CursedGothic', Arial, Helvetica, sans-serif;
        }
        h2 {
            font-family: 'Audiowide';
            font-size: 3em;
        }
        p {
            font-family: "Black Ops One", system-ui;
            font-weight: 400;
            font-style: normal;
            font-size: 1.5em;
        }

    </style>
</head>
<body>
    <h1>Feliz Natal</h1>
    <h2>boas festas</h2>
    <p>
        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quis voluptatem, quisquam nemo aut ex quod illum? Vero reprehenderit eius repudiandae mollitia eum ratione ab, officia ut quaerat neque, sequi eveniet!
    </p>
</body>
</html>
```

---



#### Links da aula

[Dafont](https://www.dafont.com/pt/) - diversas fontes

[Transfonter](https://transfonter.org/) - Webfont generator

[Google](https://fonts.google.com/) Fonts

[3Wschool](https://www.w3schools.com/cssref/atrule_font-face.php) - CSS @font-face Rule

[Developer Mozilla](https://developer.mozilla.org/pt-BR/docs/conflicting/Web/CSS/Reference/At-rules/@font-face) - glyphRef



---

---



### 59. Fontes, estilos e alinhamentos

As propriedades de texto do CSS permitem controlar a **aparência, o tamanho, o espaçamento, o alinhamento e a disposição dos textos** dentro de uma página.

Nesta aula veremos:

- `font-weight`
- `font-style`
- `text-transform`
- `text-decoration`
- `line-height`
- `letter-spacing`
- `word-spacing`
- `text-indent`
- `text-align`

------

#### 1. `font-weight`

A propriedade `font-weight` define o **peso ou espessura da fonte**.

Ela pode receber valores como `normal`, `bold` ou valores numéricos de `100` a `900`.

##### Valores `normal` e `bold`

```css
p {
    font-weight: normal;
}
```

Utiliza o peso normal da fonte.

```css
p {
    font-weight: bold;
}
```

Utiliza uma versão em **negrito** da fonte.

##### Valores de 100 a 900

Também podemos utilizar valores numéricos:

```css
p {
    font-weight: 700;
}
```

Os valores normalmente seguem esta escala:

| Valor | Peso aproximado |
| ----- | --------------- |
| `100` | Muito fino      |
| `200` | Extra fino      |
| `300` | Fino            |
| `400` | Normal          |
| `500` | Médio           |
| `600` | Seminegrito     |
| `700` | Negrito         |
| `800` | Extra negrito   |
| `900` | Muito negrito   |

Uma associação comum é:

```text
400 → normal
700 → bold
```

> **Importante:** a fonte utilizada precisa possuir o peso solicitado ou uma variação próxima poderá ser utilizada pelo navegador.

------

#### 2. `font-style`

A propriedade `font-style` define o **estilo da fonte**.

Os principais valores são:

- `normal`
- `italic`
- `oblique`

##### `normal`

Exibe o texto normalmente.

```css
p {
    font-style: normal;
}
```

##### `italic`

Exibe o texto em **itálico**.

```css
p {
    font-style: italic;
}
```

##### `oblique`

Inclina o texto, produzindo um efeito oblíquo.

```css
p {
    font-style: oblique;
}
```

##### Diferença entre `italic` e `oblique`

De forma simplificada:

- `italic` → normalmente utiliza uma variante itálica da fonte;
- `oblique` → normalmente utiliza uma versão inclinada da fonte.

------

#### 3. `text-transform`

A propriedade `text-transform` controla a **transformação das letras do texto**.

Os principais valores são:

- `uppercase`
- `lowercase`
- `capitalize`

##### `uppercase`

Transforma todas as letras em **maiúsculas**.

```css
h1 {
    text-transform: uppercase;
}
```

Exemplo:

```text
desenvolvimento web
```

Resultado:

```text
DESENVOLVIMENTO WEB
```

------

##### `lowercase`

Transforma todas as letras em **minúsculas**.

```css
h1 {
    text-transform: lowercase;
}
```

Exemplo:

```text
DESENVOLVIMENTO WEB
```

Resultado:

```text
desenvolvimento web
```

------

##### `capitalize`

Coloca a primeira letra de cada palavra em maiúscula.

```css
h1 {
    text-transform: capitalize;
}
```

Exemplo:

```text
desenvolvimento web
```

Resultado:

```text
Desenvolvimento Web
```

------

#### 4. `text-decoration`

A propriedade `text-decoration` adiciona ou remove **decorações no texto**.

Os principais valores são:

- `none`
- `underline`
- `overline`
- `line-through`

##### `none`

Remove a decoração do texto.

```css
a {
    text-decoration: none;
}
```

É muito utilizado para remover o sublinhado padrão dos links.

------

##### `underline`

Adiciona uma linha **abaixo** do texto.

```css
p {
    text-decoration: underline;
}
```

Resultado:

```text
Texto sublinhado
```

------

##### `overline`

Adiciona uma linha **acima** do texto.

```css
p {
    text-decoration: overline;
}
```

------

##### `line-through`

Adiciona uma linha **atravessando** o texto.

```css
p {
    text-decoration: line-through;
}
```

É muito utilizado para representar algo riscado.

Exemplo:

```text
Preço antigo
```

------

#### 5. `line-height`

A propriedade `line-height` define a **altura das linhas de texto**, controlando o espaço vertical entre elas.

Exemplo:

```css
p {
    line-height: 1.5;
}
```

Nesse caso, a altura da linha será proporcional ao tamanho da fonte.

Também podemos utilizar valores com unidades:

```css
p {
    line-height: 24px;
}
```

##### Exemplo

Um texto com várias linhas:

```text
Lorem ipsum dolor sit amet,
consectetur adipisicing elit.
```

Com um `line-height` maior, haverá mais espaço vertical entre as linhas.

##### Aplicabilidade

É muito utilizada para melhorar a **legibilidade de textos**, principalmente em parágrafos.

Por exemplo:

```css
p {
    font-size: 16px;
    line-height: 1.5;
}
```

------

#### 6. `letter-spacing`

A propriedade `letter-spacing` controla o **espaçamento entre as letras**.

##### Exemplo

```css
h1 {
    letter-spacing: 2px;
}
```

As letras ficarão mais afastadas.

Também podemos utilizar valores negativos:

```css
h1 {
    letter-spacing: -1px;
}
```

Nesse caso, as letras ficarão mais próximas.

##### Aplicabilidade

Pode ser utilizada para criar efeitos tipográficos, principalmente em:

- Títulos;
- Menus;
- Textos em letras maiúsculas;
- Elementos de destaque.

------

#### 7. `word-spacing`

A propriedade `word-spacing` controla o **espaçamento entre as palavras**.

Exemplo:

```css
p {
    word-spacing: 10px;
}
```

O espaço entre uma palavra e outra será aumentado.

Também podemos utilizar valores negativos:

```css
p {
    word-spacing: -2px;
}
```

##### Diferença

É importante não confundir:

```text
letter-spacing → espaço entre letras

word-spacing   → espaço entre palavras
```

------

#### 8. `text-indent`

A propriedade `text-indent` define o **recuo da primeira linha de um texto**.

É semelhante ao recuo utilizado no início de um parágrafo em textos impressos.

Exemplo:

```css
p {
    text-indent: 30px;
}
```

A primeira linha do parágrafo será deslocada `30px` para a direita.

##### Exemplo visual

Sem `text-indent`:

```text
Lorem ipsum dolor sit amet, consectetur...
```

Com `text-indent: 30px`:

```text
     Lorem ipsum dolor sit amet, consectetur...
Lorem ipsum dolor sit amet, consectetur...
```

Observe que normalmente **apenas a primeira linha** recebe o recuo.

------

#### 9. `text-align`

A propriedade `text-align` define o **alinhamento horizontal do conteúdo textual**.

Os principais valores estudados são:

- `left`
- `right`
- `center`
- `justify`

------

##### `left`

Alinha o texto à esquerda.

```css
p {
    text-align: left;
}
```

É o alinhamento padrão mais comum para textos em idiomas como português.

------

##### `right`

Alinha o texto à direita.

```css
p {
    text-align: right;
}
```

------

##### `center`

Centraliza o texto.

```css
h1 {
    text-align: center;
}
```

Muito utilizado em títulos.

------

##### `justify`

Justifica o texto.

```css
p {
    text-align: justify;
}
```

O navegador ajusta os espaços entre as palavras para que as linhas ocupem a largura disponível, deixando as bordas do bloco de texto mais alinhadas.

É bastante comum em parágrafos de textos longos.

------

#### Resumo

| Propriedade       | Função                           | Exemplos de valores                             |
| ----------------- | -------------------------------- | ----------------------------------------------- |
| `font-weight`     | Define o peso da fonte           | `normal`, `bold`, `100`–`900`                   |
| `font-style`      | Define o estilo da fonte         | `normal`, `italic`, `oblique`                   |
| `text-transform`  | Transforma maiúsculas/minúsculas | `uppercase`, `lowercase`, `capitalize`          |
| `text-decoration` | Adiciona/remove decoração        | `none`, `underline`, `overline`, `line-through` |
| `line-height`     | Define a altura das linhas       | `1.5`, `24px`                                   |
| `letter-spacing`  | Define o espaço entre letras     | `2px`, `-1px`                                   |
| `word-spacing`    | Define o espaço entre palavras   | `10px`, `-2px`                                  |
| `text-indent`     | Define o recuo da primeira linha | `30px`                                          |
| `text-align`      | Define o alinhamento do texto    | `left`, `right`, `center`, `justify`            |

#### Para memorizar

```text
font-weight     → espessura
font-style      → estilo
text-transform  → maiúsculas/minúsculas
text-decoration → decoração
line-height     → altura das linhas
letter-spacing  → espaço entre letras
word-spacing    → espaço entre palavras
text-indent     → recuo da primeira linha
text-align      → alinhamento
```

Essas propriedades, combinadas com `font-family` e `font-size`, formam a base para controlar a **tipografia e apresentação dos textos em CSS**.



#### Arquivo completo - estilos-alinhamentos.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Estilos & alinhamentos</title>
    <style>
        body {
            font-size: 1.5em;
            font-family: Arial, Helvetica, sans-serif;
        }
        .negrito {
            /* bold, normal, 100 até 900 */
            font-weight: 800;
        }
        .estilo {
            /* normal, italic, oblique */
            font-style: oblique;
        }
        .trasformacao {
            /* uppercase, lowercase, capitalize */
            text-transform: capitalize;
        }
        h1 {
            text-transform: uppercase;
        }
        .decoracao {
            /* none, underline, overline, line-through */
            text-decoration: line-through;
        }
        a {
            text-decoration: none;
        }
        .entrelinhas {
            border: 1px solid red;
            line-height: 2em;
        }
        .espacamento {
            letter-spacing: 0.5em; /* Espaçamento entre linhas */
            word-spacing: 2em; /* Espaçamento entre palavras */
        }
        .recuado {
            text-indent: 2em;
        }
        .alinhamento {
            /* left, right, center, justify */
            text-align: justify;
        }
        
    </style>
</head>
<body>
    <h1>Formatação de texto</h1>
    <p class="negrito">Texto em negrito</p>
    <p class="estilo">Texto com estilo</p>
    <p class="trasformacao">Texto com transformação</p>
    <p class="decoracao">Texto com decoração</p>
    <a href="">Google</a>
    <p class="entrelinhas">Texto entrelinhas</p>
    <p class="espacamento">Texto com espaço entre letras e palavras</p>
    <p class="recuado">Texto recuado</p>
    <p>Texto normal</p>

    <h1>Alinhamento de texto</h1>
    <p class="alinhamento">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Magnam cumque ut, distinctio incidunt nobis nam minima tempora maiores vero dolorum eaque, perferendis nesciunt in error, sapiente debitis ad. Blanditiis, enim?
    </p>
</body>
</html>
```



---

---



### 60. Imagens de fundo

A propriedade `background` permite definir e controlar o **fundo de um elemento HTML**, podendo envolver cor, imagem, posição, repetição, fixação e outros aspectos.

No seu código, você utilizou praticamente os principais recursos relacionados a imagens de fundo.

------

#### 1. O que é?

Em CSS, o **background** é o conjunto de propriedades responsáveis pela aparência do fundo de um elemento.

Por exemplo:

```css
.caixa {
    background-color: lightgreen;
}
```

Define uma cor de fundo para a `.caixa`.

Também podemos utilizar uma imagem:

```css
.caixa {
    background-image: url('./img/fundo-css-claro.png');
}
```

Nesse caso, a imagem passa a ser utilizada como **imagem de fundo**.

> **Importante:** `background` não é uma propriedade exclusiva para imagens. Ele pode controlar **cor, imagem, repetição, posição, tamanho, comportamento da imagem, entre outros aspectos**.

------

#### 2. Para que serve?

É utilizado para colocar elementos visuais **no fundo de outros elementos**.

Por exemplo:

- imagens decorativas;
- texturas;
- padrões;
- gradientes;
- imagens de destaque;
- fundos de seções;
- imagens que ficam atrás de textos ou outros elementos.

Uma diferença importante:

```html
<img src="imagem.jpg">
```

é utilizado quando a imagem faz **parte do conteúdo** da página.

Já:

```css
background-image: url("imagem.jpg");
```

é mais apropriado quando a imagem é **parte da apresentação/decoração** do elemento.

------

#### 3. Como funciona?

No seu código, temos uma `<div>`:

```html
<div class="caixa">
```

E no CSS:

```css
.caixa {
    width: 700px;
    height: 300px;
}
```

Portanto, temos uma área de **700 × 300 pixels** onde o background será aplicado.

Você pode definir diferentes características desse fundo:

```css
background-color: lightgreen;
background-image: url('./img/fundo-css-claro.png');
background-repeat: no-repeat;
background-attachment: scroll;
background-position: right top;
```

Cada propriedade controla uma característica diferente.

##### `background-color`

Define a cor de fundo:

```css
background-color: lightgreen;
```

##### `background-image`

Define uma imagem:

```css
background-image: url('./img/fundo-css-claro.png');
```

##### `background-repeat`

Define se a imagem será repetida:

```css
background-repeat: no-repeat;
```

##### `background-position`

Define a posição da imagem:

```css
background-position: right top;
```

##### `background-attachment`

Define como a imagem se comporta em relação à rolagem da página:

```css
background-attachment: scroll;
```

------

#### 4. Qual é a sintaxe?

Cada propriedade possui sua própria sintaxe.

##### Imagem

```css
background-image: url("imagem.jpg");
```

##### Repetição

```css
background-repeat: no-repeat;
```

##### Posição

```css
background-position: right top;
```

##### Cor

```css
background-color: purple;
```

Também existe a propriedade **shorthand** `background`, que permite juntar várias configurações:

```css
background: purple url("imagem.jpg") no-repeat scroll right top;
```

A ideia é:

```text
background: cor imagem repetição fixação posição;
```

Mas nem todos os valores precisam obrigatoriamente aparecer.

------

#### 5. Principais propriedades e valores

#### `background-image`

Define a imagem.

```css
background-image: url("imagem.jpg");
```

Também pode receber:

```css
background-image: none;
```

E pode trabalhar com múltiplas imagens:

```css
background-image:
    url("imagem1.png"),
    url("imagem2.png");
```

------

#### `background-repeat`

Controla a repetição da imagem.

| Valor       | Comportamento                           |
| ----------- | --------------------------------------- |
| `repeat`    | repete horizontal e verticalmente       |
| `repeat-x`  | repete horizontalmente                  |
| `repeat-y`  | repete verticalmente                    |
| `no-repeat` | não repete                              |
| `space`     | distribui as imagens deixando espaços   |
| `round`     | ajusta as imagens para preencher a área |

O mais importante inicialmente:

```css
background-repeat: no-repeat;
```

------

#### `background-position`

Controla a posição da imagem.

Exemplos:

```css
background-position: left top;
background-position: center;
background-position: right bottom;
```

Também podemos utilizar valores:

```css
background-position: 50px 100px;
```

A primeira posição representa o eixo **X** e a segunda o eixo **Y**.

------

#### `background-position-x`

Controla especificamente a posição horizontal:

```css
background-position-x: left;
```

Valores comuns:

```css
left
center
right
```

------

#### `background-position-y`

Controla especificamente a posição vertical:

```css
background-position-y: top;
```

Valores comuns:

```css
top
center
bottom
```

No seu código:

```css
background-position-x: left;
background-position-y: bottom;
```

seria equivalente, em termos de posição, a:

```css
background-position: left bottom;
```

------

#### `background-attachment`

Controla o comportamento da imagem durante a rolagem.

Principais valores:

```css
background-attachment: scroll;
```

A imagem acompanha o elemento durante a rolagem normal.

```css
background-attachment: fixed;
```

A imagem fica fixa em relação à área de visualização.

Existe também:

```css
background-attachment: local;
```

que está relacionado à rolagem do próprio elemento.

------

#### `background-color`

Define a cor de fundo:

```css
background-color: lightgreen;
```

É importante lembrar que uma cor pode funcionar como **fundo de segurança** caso uma imagem não seja carregada.

------

#### 6. A propriedade `background` — shorthand

Essa é uma das partes mais importantes da sua aula.

Em vez de escrever:

```css
background-color: purple;
background-image: url("imagem.jpg");
background-repeat: no-repeat;
background-attachment: scroll;
background-position: right top;
```

podemos escrever:

```css
background: purple url("imagem.jpg") no-repeat scroll right top;
```

Isso é chamado de **shorthand**.

Ou seja, `background` consegue reunir várias propriedades relacionadas ao fundo em uma única declaração.

------

#### 7. Múltiplas imagens de fundo

Você utilizou algo muito interessante no final:

```css
background: 
    url('./img/fundo-css-escuro.png') no-repeat right top,
    url('./img/fundo-css-claro.png') no-repeat left bottom;
```

O CSS permite colocar **mais de uma imagem de fundo**.

As imagens são separadas por vírgula:

```css
background: imagem1, imagem2;
```

No seu exemplo:

```text
fundo-css-escuro.png → canto superior direito
fundo-css-claro.png  → canto inferior esquerdo
```

A **primeira imagem fica sobre as seguintes** quando existe sobreposição.

Isso permite criar fundos bastante complexos utilizando várias imagens.

------

#### 8. Um detalhe importante no seu código

Você escreveu várias declarações de `background`:

```css
background-color: lightgreen;
background-image: url('./img/fundo-css-claro.png');
background-repeat: no-repeat;
background-attachment: scroll;
background-position: right top;
background-position-x: left;
background-position-y: bottom;
```

Depois:

```css
background: purple url('./img/fundo-css-claro.png') no-repeat scroll right top;
```

E finalmente:

```css
background: 
    url('./img/fundo-css-escuro.png') no-repeat right top,
    url('./img/fundo-css-claro.png') no-repeat left bottom;
```

**A última declaração é a que prevalece sobre as anteriores quando há conflito.**

Isso acontece por causa da **cascata do CSS**.

Então, para estudar esse código, não pense que todas essas declarações estão sendo aplicadas simultaneamente.

As últimas declarações de `background` estão sobrescrevendo as configurações anteriores correspondentes.

------

#### 9. O que é importante saber/memorizar?

Para essa aula, eu focaria principalmente nestes pontos:

```css
background-color
background-image
background-repeat
background-position
background-attachment
background
```

E memorize principalmente:

```css
background-image: url("imagem.jpg");
background-repeat: no-repeat;
background-position: center;
```

e o shorthand:

```css
background: cor imagem repetição posição;
```

Além disso:

**`background` pode receber múltiplas imagens**, separadas por vírgulas.

```css
background:
    url("imagem1.png"),
    url("imagem2.png");
```

#### Resumo mental

Pense assim:

> **Imagem → repete? → onde fica? → acompanha a página? → qual é a cor de fundo?**

Isso já representa grande parte do que você precisa dominar sobre `background` nesse momento.

---

#### Arquivo completo - imagem-fundo.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Imagens de fundo</title>
    <style>
        .caixa {
            width: 700px;
            height: 300px;
            border: 3px dotted red;
            background-color: lightgreen;
            background-image: url('./img/fundo-css-claro.png');
            background-repeat: no-repeat;
            background-attachment: scroll;
            background-position: right top;
            background-position-x: left;
            background-position-y: bottom;
            background: purple url('./img/fundo-css-claro.png') no-repeat scroll right top;
            background: 
                        url('./img/fundo-css-escuro.png') no-repeat right top,
                        url('./img/fundo-css-claro.png') no-repeat left bottom;
        }
       
    </style>
</head>
<body>
    
    <div class="caixa">
        <h1>Título do texto</h1>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Cupiditate, vel maxime! Natus ea, deleniti culpa vitae non omnis tenetur nulla alias exercitationem temporibus magni molestiae nostrum sit harum iure eaque.
        </p>
    </div>


</body>
</html>
```



---

---



### 61. [Exercício] Cores e Imagens de Fundo

#### Código completo - exercicio-imagem-fundo.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cores e imagens de fundo</title>
    <style>
        body {
            background: white url('./img/fundo-site.png') repeat scroll left top;
        }
        .caixa {
            background: #d9d7b6 url('./img/fundo-h1.png') repeat-x scroll left top;
            padding: 0.5em 1em;
        }
        h2 {
            color: #827f65;
        }
    </style>
</head>
<body>
    <h1>Logo do site</h1>
    <div class="caixa">
        <h2>Título do texto</h2>
        <p>
            Lorem ipsum, dolor sit amet consectetur adipisicing elit. Cum doloremque consectetur, veniam amet, iusto placeat adipisci similique praesentium voluptas tempore enim in. Cupiditate consequuntur a temporibus maxime sint voluptates repudiandae!
        </p>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti aliquam facilis sequi unde ipsam temporibus, error ullam corporis delectus molestias in sit minus maiores culpa odio voluptate deleniti eveniet dicta?
        </p>
    </div>
</body>
</html>
```



---

---



### 62. Mais sobre seletores (Teoria)

Os **seletores CSS** são usados para indicar **quais elementos HTML serão afetados por uma regra CSS**.

A ideia básica é:

```css
seletor {
    propriedade: valor;
}
```

Por exemplo:

```css
h1 {
    color: blue;
}
```

Aqui, `h1` é o seletor. A regra será aplicada aos elementos `<h1>`.

------

#### 1. Seletor universal `*`

##### O que é?

O `*` representa **todos os elementos HTML**.

##### Para que serve?

Serve para aplicar uma regra a todos os elementos da página.

##### Como funciona?

```css
* {
    margin: 0;
}
```

Todo elemento receberá `margin: 0`.

##### Sintaxe

```css
* {
    propriedade: valor;
}
```

##### Exemplo

```css
* {
    box-sizing: border-box;
}
```

É bastante comum utilizar o seletor universal para fazer uma configuração inicial da página.

------

#### 2. Seletor de tipo/tag

**Seletor de tipo** ou **seletor de elemento**.

Exemplos:

```css
h1 {}
h2 {}
p {}
div {}
```

##### O que é?

Seleciona elementos HTML pelo **nome da tag**.

##### Para que serve?

Serve para aplicar uma regra a **todos os elementos daquele tipo**.

##### Como funciona?

```css
h1 {
    color: red;
}
```

Todos os `<h1>` da página receberão `color: red`.

##### Sintaxe

```css
elemento {
    propriedade: valor;
}
```

##### Exemplo

HTML:

```html
<h1>Título 1</h1>
<h1>Título 2</h1>
<p>Um parágrafo.</p>
```

CSS:

```css
h1 {
    color: blue;
}
```

Os dois `<h1>` serão selecionados.

------

#### 3. Seletor de classe `.destaque`

##### O que é?

Seleciona elementos que possuem determinada **classe**.

##### Para que serve?

É um dos seletores mais utilizados para criar estilos que podem ser aplicados a **vários elementos diferentes**.

##### Como funciona?

HTML:

```html
<p class="destaque">Texto importante</p>
<p>Texto normal</p>
<h2 class="destaque">Título importante</h2>
```

CSS:

```css
.destaque {
    color: red;
}
```

Tanto o `<p>` quanto o `<h2>` serão selecionados porque possuem a classe `destaque`.

##### Sintaxe

```css
.nome-da-classe {
    propriedade: valor;
}
```

##### Exemplo

```css
.destaque {
    background-color: yellow;
    font-weight: bold;
}
```

##### Ponto importante

Uma classe pode ser utilizada em **vários elementos**:

```html
<p class="destaque">Texto 1</p>
<p class="destaque">Texto 2</p>
<div class="destaque">Texto 3</div>
```

Essa é uma das principais diferenças em relação ao `id`.

------

#### 4. Seletor de ID `#principal`

##### O que é?

Seleciona um elemento através do seu atributo `id`.

##### Para que serve?

Serve para selecionar um elemento específico que possui determinado ID.

##### Como funciona?

HTML:

```html
<h1 id="principal">Título</h1>
```

CSS:

```css
#principal {
    color: red;
}
```

O elemento com `id="principal"` será selecionado.

##### Sintaxe

```css
#nome-do-id {
    propriedade: valor;
}
```

##### Exemplo

```html
<div id="cabecalho">
    <h1>Meu site</h1>
</div>
#cabecalho {
    background-color: black;
}
```

##### Classe × ID

Uma forma simples de lembrar:

```text
.class → pode ser usada em vários elementos
#id    → identifica um elemento específico
```

Além disso, um `id` deve ser **único dentro da página**.

------

#### 5. Seletor de filho `div > h1`

##### O que é?

Seleciona um elemento que é **filho direto** de outro elemento.

##### Para que serve?

Quando você quer selecionar apenas elementos que estão **imediatamente dentro** de outro elemento.

##### Como funciona?

HTML:

```html
<div>
    <h1>Título</h1>
</div>
```

CSS:

```css
div > h1 {
    color: red;
}
```

O `<h1>` é filho direto do `<div>`, portanto será selecionado.

Mas observe:

```html
<div>
    <section>
        <h1>Título</h1>
    </section>
</div>
```

Nesse caso:

```css
div > h1 {
    color: red;
}
```

**não selecionará o `<h1>`**, porque ele não é filho direto do `<div>`.

A relação é:

```text
div
└── section
    └── h1
```

O `<h1>` é descendente do `div`, mas não é seu filho direto.

##### Sintaxe

```css
pai > filho {
    propriedade: valor;
}
```

------

#### 6. Seletor de descendente `div h1`

##### O que é?

Seleciona elementos que estão **dentro de outro elemento**, independentemente de quantos níveis existam entre eles.

##### Para que serve?

Quando você quer selecionar um elemento que seja descendente de outro.

##### Como funciona?

```html
<div>
    <section>
        <h1>Título</h1>
    </section>
</div>
div h1 {
    color: blue;
}
```

O `<h1>` será selecionado.

A relação pode ser:

```text
div
└── section
    └── article
        └── h1
```

Ainda assim:

```css
div h1 {}
```

selecionará o `<h1>`.

##### Sintaxe

```css
ancestral descendente {
    propriedade: valor;
}
```

##### Diferença importante

```css
div > h1
```

→ somente **filho direto**

```css
div h1
```

→ qualquer **descendente**

------

#### 7. Seletor de irmão adjacente `h1 + p`

##### O que é?

Seleciona um elemento que é o **irmão imediatamente seguinte** de outro elemento.

##### Para que serve?

Quando você quer aplicar um estilo ao elemento que aparece **logo depois** de outro.

##### Como funciona?

HTML:

```html
<h1>Título</h1>
<p>Primeiro parágrafo.</p>
<p>Segundo parágrafo.</p>
```

CSS:

```css
h1 + p {
    color: red;
}
```

Somente o **primeiro `<p>`** será selecionado.

Porque ele vem imediatamente depois do `<h1>`.

Visualmente:

```text
h1
↓
p     ← selecionado
↓
p     ← não selecionado
```

##### Sintaxe

```css
elemento1 + elemento2 {
    propriedade: valor;
}
```

------

#### 8. Seletor de irmão geral `h1 ~ p`

##### O que é?

Seleciona os **irmãos que aparecem depois** de determinado elemento.

##### Para que serve?

Quando você quer selecionar vários elementos irmãos posteriores, e não apenas o primeiro.

##### Como funciona?

```html
<h1>Título</h1>
<p>Primeiro parágrafo.</p>
<p>Segundo parágrafo.</p>
<p>Terceiro parágrafo.</p>
h1 ~ p {
    color: red;
}
```

Os **três `<p>`** serão selecionados.

```text
h1
↓
p ← selecionado
↓
p ← selecionado
↓
p ← selecionado
```

##### Sintaxe

```css
elemento1 ~ elemento2 {
    propriedade: valor;
}
```

------

#### Diferença entre `+` e `~`

Essa é uma diferença que vale muito a pena memorizar:

##### `+` — irmão adjacente

Seleciona **somente o próximo irmão**.

```css
h1 + p {}
h1
 ↓
 p ← selecionado
 ↓
 p ← não
```

##### `~` — irmão geral

Seleciona **todos os irmãos posteriores compatíveis**.

```css
h1 ~ p {}
h1
 ↓
 p ← selecionado
 ↓
 p ← selecionado
 ↓
 p ← selecionado
```

------

#### Resumo dos seletores

| Seletor      | Nome            | Seleciona                                     |
| ------------ | --------------- | --------------------------------------------- |
| `*`          | Universal       | Todos os elementos                            |
| `h1`         | Tipo/elemento   | Todos os `<h1>`                               |
| `.destaque`  | Classe          | Elementos com essa classe                     |
| `#principal` | ID              | Elemento com esse ID                          |
| `div > h1`   | Filho           | `<h1>` filho direto de `<div>`                |
| `div h1`     | Descendente     | `<h1>` dentro de `<div>`, em qualquer nível   |
| `h1 + p`     | Irmão adjacente | Primeiro `<p>` imediatamente depois de `<h1>` |
| `h1 ~ p`     | Irmão geral     | Todos os `<p>` irmãos depois de `<h1>`        |

#### Uma maneira fácil de memorizar

```text
*       → todos
h1      → pela tag
.classe → pela classe
#id     → pelo ID

A > B   → B é filho direto de A
A B     → B é descendente de A

A + B   → primeiro B depois de A
A ~ B   → todos os B depois de A
```

---

---



### 63. Seletores (Prática) - Universal, Classe e ID

#### Arquivo completo - mais-sobre-seletores.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mais sobre seletores (pŕatica)</title>

    <style>
        /* seletor universal */
        * {
            border: solid 1px red;
            margin: 0;
            padding: 0;
        }

        /* seletor de tipo/elemento */
        h1, p, h2 {
            padding: 10px;
            border: solid 1px purple;
        }

        /* seletor de classe */
        .destaque {
            background-color: red;
        }

        /* seletor de classe */
        .titulo {
            color: white;
        }

        /* seletor de ID */
        #promocao {
            background-color: purple;
            color: white;
        }

    </style>

</head>
<body>
    <h1 class="destaque titulo">Título da página</h1>

    <h2 class="destaque">Subtítulo da página</h2>

    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ullam veniam nemo tempora maxime est impedit expedita, omnis esse magni quisquam? Voluptatum quaerat quae odio sit. Corporis pariatur beatae aperiam explicabo!
    </p>

    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Animi molestias earum qui molestiae aspernatur eligendi quos unde eaque error, assumenda nobis. Eos maxime ratione laudantium modi quaerat, praesentium placeat sapiente.
    </p>

    <div id="promocao">
        <h2>Subtítulo da página</h2>

        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit laudantium nobis eius alias aspernatur vero cum deleniti aperiam, nam eligendi consequuntur facilis voluptatibus, non provident voluptatum dicta labore harum est.
        </p>
    </div>
    

</body>
</html>
```

---

---



### 64. Seletores (Prática) - Filho, Descendente e Irmão

#### Arquivo completo - mais-sobre-seletores2.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mais sobre seletores (pŕatica)</title>

    <style>
        /* seletor de filho direto */
        div>h1 {
            background-color: orange;
        }

        /* seletor de filho direto */
        li>a {
            color: brown;
            text-decoration: none;
        }

        /* seletor de descendente */
        div h2 {
            background-color: olivedrab;
            color: whitesmoke;
        }

        /* seletor de irmão adjacente */
        h2+p {
            color: brown;
            border: 1px solid brown;
        }

        /* seletor de irmão geral */
        h3~p {
            color: brown;
            border: 1px solid brown;
        }
    </style>

</head>
<body>
    <div style="border: solid 1px black;">
        <h1 class="destaque titulo">Título da página</h1>
        <div style="background-color: grey;">
            <h1 class="destaque titulo">Título da página</h1>
        </div>
    </div>

    <ul>
        <li>
            <a href="">Home</a>
            <span><a href="">Outro link</a></span>
        </li>
        <li><a href="">Sobre</a></li>
    </ul>

    <div style="border: solid 1px black;">
        <h2 class="destaque titulo">Subtítulo da página</h2>
        <div style="background-color: grey;">
            <h2 class="destaque titulo">Subtítulo da página</h2>
        </div>
    </div>

    <p>
        Lorem ipsum dolor sit amet consectetur, adipisicing elit. Exercitationem tempore dolore quos excepturi consectetur sunt minima quae commodi eveniet voluptatibus dolorem impedit et sint quibusdam, ea, suscipit cum odit voluptatum?
    </p>

    <h2>Seletor de irmão adjacente</h2>

    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ullam veniam nemo tempora maxime est impedit expedita, omnis esse magni quisquam? Voluptatum quaerat quae odio sit. Corporis pariatur beatae aperiam explicabo!
    </p>

    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Animi molestias earum qui molestiae aspernatur eligendi quos unde eaque error, assumenda nobis. Eos maxime ratione laudantium modi quaerat, praesentium placeat sapiente.
    </p>

    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Vero ducimus adipisci, nihil odit assumenda dicta saepe fugiat. Quisquam molestias delectus pariatur praesentium optio. Recusandae, dolor obcaecati! Dolor necessitatibus deserunt excepturi.
    </p>

    <h3>Seletor de irmão geral</h3>

    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ullam veniam nemo tempora maxime est impedit expedita, omnis esse magni quisquam? Voluptatum quaerat quae odio sit. Corporis pariatur beatae aperiam explicabo!
    </p>

    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Animi molestias earum qui molestiae aspernatur eligendi quos unde eaque error, assumenda nobis. Eos maxime ratione laudantium modi quaerat, praesentium placeat sapiente.
    </p>

    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Fuga hic repellat eius, necessitatibus in et. Minus, sapiente assumenda officia sint hic illum iusto minima quia unde, culpa perferendis, fugit omnis.
    </p>

</body>
</html>
```

---

#### Arquivo completo - desafio-seletores.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Desafio seletores</title>

    <style>

        h1 {
            color: green;
        }

        h1+p {
            border-top: 3px solid gray;
            padding-top: 10px;
        }

        p>a {
            background-color: purple;
            color: white;
        }

        p.destaque {
            color: purple;
        }

    </style>
</head>
<body>
        <h1>Título da página</h1>
        <p>
            Lorem ipsum, dolor sit amet consectetur adipisicing elit. Rerum totam in soluta, repellendus illo obcaecati labore molestias provident neque consectetur cumque recusandae veritatis aliquam ab atque error molestiae eius doloremque! <br>
            <a href="">Leia mais</a> - 
            <a href="">Gostei (10)</a>
        </p>

        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Illo, quaerat fugit? Eius expedita cumque, cum sunt sequi aliquam quos fugiat harum ipsam quo laudantium! Impedit nobis perspiciatis eveniet saepe cumque.
        </p>

        <h2>Subtítulo da página</h2>
        <p>
            Lorem ipsum dolor sit amet consectetur, adipisicing elit. Ea consectetur laboriosam dolorum minima exercitationem cumque ab quos at? Voluptatem dolore laboriosam numquam dolorum minus, quaerat dolorem molestias ex voluptate neque.
        </p>
        <p class="destaque">
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Iste iusto aliquid at eligendi enim atque veniam non recusandae repudiandae dolore perferendis, minima odio veritatis optio vel amet sint quam aspernatur.
        </p>
</body>
</html>
```

---

---



### 65. Pseudo-Classes & Pseudo-Elementos

Pseudo-classes e pseudo-elementos permitem aplicar estilos a elementos HTML com base em **um estado, uma condição ou uma parte específica do elemento**.

A principal diferença é:

> **Pseudo-classe → estado ou condição do elemento.**
> **Pseudo-elemento → parte específica do elemento ou conteúdo criado pelo CSS.**

------

#### 1. Pseudo-classes

##### O que são?

Pseudo-classes são palavras-chave adicionadas a um seletor para selecionar um elemento quando ele está em **determinado estado ou condição**.

Elas utilizam **um `:`**:

```css
seletor:pseudo-classe {
    propriedade: valor;
}
```

Por exemplo:

```css
a:hover {
    color: red;
}
```

O estilo será aplicado quando o mouse estiver sobre o link.

------

##### Para que servem?

São muito utilizadas para criar **interatividade e comportamentos visuais** sem precisar de JavaScript.

Por exemplo:

- mudar um link quando o mouse passa sobre ele;
- identificar links visitados;
- alterar um campo quando ele recebe foco;
- estilizar checkbox marcado;
- estilizar campos obrigatórios;
- selecionar elementos com determinadas condições.

------

#### 2. `:link`

Seleciona links que **ainda não foram visitados**.

```css
a:link {
    color: grey;
}
```

os links não visitados ficam cinza.

------

#### 3. `:visited`

Seleciona links que o navegador considera **já visitados**.

```css
a:visited {
    color: red;
}
```

O link visitado ficará vermelho.

É importante saber que os navegadores restringem algumas propriedades que podem ser alteradas em `:visited`, principalmente por questões de privacidade.

------

#### 4. `:hover`

É uma das pseudo-classes mais utilizadas.

Seleciona o elemento quando o **cursor está sobre ele**.

```css
a:hover {
    background-color: green;
    color: white;
}
```

Quando o mouse passa sobre o link:

- o fundo fica verde;
- o texto fica branco.

Também pode ser usado em outros elementos:

```css
button:hover {
    background-color: black;
    color: white;
}
```

------

#### 5. `:active`

Representa o momento em que o elemento está sendo **ativado**.

Por exemplo, ao clicar e manter o botão do mouse pressionado sobre um link:

```css
a:active {
    background-color: purple;
}
```

Uma maneira simples de memorizar:

```text
:hover  → mouse sobre
:active → momento da ativação/clique
```

------

#### 6. `:checked`

Seleciona elementos de formulário que estão **marcados/selecionados**.

No seu código:

```css
input:checked {
    margin-left: 20px;
}
```

Isso pode afetar:

```html
<input type="checkbox">
<input type="radio">
```

quando estiverem selecionados.

Por exemplo:

```css
input:checked {
    accent-color: green;
}
```

------

#### 7. `:focus`

Seleciona um elemento que está **recebendo foco**.

Por exemplo, quando você clica em um campo de texto:

```css
input:focus {
    background-color: purple;
    color: white;
}
```

No seu código, ao clicar no `<input>`:

```html
<input type="text">
```

ele recebe `focus` e o CSS é aplicado.

É muito utilizado para melhorar a experiência de preenchimento de formulários.

------

#### 8. `:required`

Seleciona elementos que possuem o atributo HTML `required`.

```css
input:required {
    border: 2px solid red;
}
```

Este campo:

```html
<input type="text" required>
```

será selecionado.

Enquanto este:

```html
<input type="text">
```

não será.

#### Atenção

`required` é um **atributo HTML**.

`:required` é uma **pseudo-classe CSS** que permite selecionar elementos que possuem essa condição.

------

#### 9. Pseudo-elementos

##### O que são?

Pseudo-elementos permitem selecionar e estilizar **uma parte específica de um elemento** ou inserir determinado conteúdo através do CSS.

A sintaxe moderna utiliza **dois `::`**:

```css
seletor::pseudo-elemento {
    propriedade: valor;
}
```

Por exemplo:

```css
p::first-letter {
    color: red;
}
```

Seleciona a primeira letra do `<p>`.

------

#### 10. `::first-line`

Seleciona a **primeira linha visual** de um texto.

```css
p::first-line {
    color: red;
}
```

A primeira linha do parágrafo ficará vermelha.

Importante: a primeira linha depende do tamanho disponível para o texto.

Se você aumentar ou diminuir a janela do navegador, a quantidade de palavras que cabem na primeira linha pode mudar.

------

#### 11. `::first-letter`

Seleciona a **primeira letra**.

```css
p::first-letter {
    font-size: 3em;
    color: purple;
}
```

Faz com que a primeira letra fique:

- maior;
- roxa.

É bastante utilizado para criar efeitos de **letra capitular**.

------

#### 12. `::selection`

Controla a aparência do texto enquanto o usuário o **seleciona com o mouse**.

```css
p::selection {
    background-color: yellow;
}
```

Ao selecionar o texto do `<p>`, o fundo da seleção ficará amarelo.

Também podemos fazer:

```css
p::selection {
    background-color: black;
    color: white;
}
```

------

#### 13. `::before`

O `::before` cria um pseudo-elemento **antes do conteúdo** do elemento.

```css
h2::before {
    content: "{";
    color: violet;
}
```

O CSS adicionará `{` antes do conteúdo do `<h2>`.

Se tivermos:

```html
<h2>Conteúdo do h2</h2>
```

visualmente teremos algo semelhante a:

```text
{Conteúdo do h2
```

##### Importante

Quando utilizamos `::before` para inserir conteúdo, normalmente precisamos utilizar:

```css
content: "...";
```

------

#### 14. `::after`

É semelhante ao `::before`, mas insere o conteúdo **depois**.

```css
h2::after {
    content: "}";
    color: violet;
}
```

Resultado:

```text
Conteúdo do h2}
```

Juntando os dois:

```css
h2::before {
    content: "{";
}

h2::after {
    content: "}";
}
```

Temos:

```text
{Conteúdo do h2}
```

------

#### Pseudo-classe × pseudo-elemento

Essa é provavelmente a parte **mais importante para memorizar**.

|            | Pseudo-classe   | Pseudo-elemento            |
| ---------- | --------------- | -------------------------- |
| Símbolo    | `:`             | `::`                       |
| Representa | estado/condição | parte do elemento/conteúdo |
| Exemplo    | `:hover`        | `::first-letter`           |
| Exemplo    | `:focus`        | `::before`                 |
| Exemplo    | `:checked`      | `::after`                  |

#### Pense assim:

```text
:hover
   ↓
"Quando isso acontecer com o elemento..."

::first-letter
   ↓
"Quero mexer nesta parte do elemento..."
```

------

#### Sintaxe

##### Pseudo-classe

```css
seletor:pseudo-classe {
    propriedade: valor;
}
```

Exemplo:

```css
a:hover {
    color: red;
}
```

##### Pseudo-elemento

```css
seletor::pseudo-elemento {
    propriedade: valor;
}
```

Exemplo:

```css
p::first-letter {
    color: red;
}
```

------

#### Principais pseudo-classes desta aula

| Pseudo-classe | Função                     |
| ------------- | -------------------------- |
| `:link`       | link não visitado          |
| `:visited`    | link visitado              |
| `:hover`      | cursor sobre o elemento    |
| `:active`     | elemento sendo ativado     |
| `:checked`    | checkbox/radio selecionado |
| `:focus`      | elemento recebeu foco      |
| `:required`   | elemento possui `required` |

Existem muitas outras, como:

```css
:first-child
:last-child
:nth-child()
:not()
:disabled
:enabled
:valid
:invalid
```

Você provavelmente estudará várias delas posteriormente.

------

#### Principais pseudo-elementos desta aula

| Pseudo-elemento  | Função            |
| ---------------- | ----------------- |
| `::first-line`   | primeira linha    |
| `::first-letter` | primeira letra    |
| `::selection`    | texto selecionado |
| `::before`       | conteúdo antes    |
| `::after`        | conteúdo depois   |

Também existem outros, como:

```css
::placeholder
::marker
::file-selector-button
```

------

#### Um detalhe importante sobre `:` e `::`

Você verá códigos antigos usando apenas um `:` para pseudo-elementos:

```css
p:first-letter {}
p:before {}
```

A sintaxe moderna/preferida é:

```css
p::first-letter {}
p::before {}
```

Portanto, para seus estudos, **prefira `::` para pseudo-elementos**.

------

#### Para memorizar

Eu guardaria apenas estas ideias inicialmente:

##### 1. Pseudo-classe = estado/condição

```css
a:hover {}
input:focus {}
input:checked {}
```

Pense:

> **"Em que estado o elemento está?"**

------

##### 2. Pseudo-elemento = parte do elemento

```css
p::first-letter {}
p::first-line {}
```

Pense:

> **"Qual parte do elemento quero modificar?"**

------

##### 3. `::before` e `::after` = conteúdo criado pelo CSS

```css
h2::before {
    content: "{";
}

h2::after {
    content: "}";
}
```

------

##### 4. Decore esta diferença

```text
:   → PSEUDO-CLASSE  → estado/condição
::  → PSEUDO-ELEMENTO → parte/conteúdo
```

E uma observação importante: **pseudo-classes e pseudo-elementos não são propriedades, atributos ou valores**. Eles são **seletores especiais** usados para determinar quais elementos ou partes dos elementos receberão as regras CSS.

---

#### Arquivo completo - pseudo-classe-elemento.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>pseudo-classe-elemento.html</title>

    <style>

        /* links */
        a {
            text-decoration: none;
            color: green;
            padding: 5px 10px;
        }

        /* links não visitados */
        a:link {
            color: grey;
        }

        /* links visitados */
        a:visited {
            color: red;
        }
        
        /* links hover, passar o cursor sobre o link */
        a:hover {
            background-color: green;
            color: white;
        }

        /* links ativos */
        a:active {
            background-color: purple;
        }

        /* Formulários */
        input:checked {
            margin-left: 20px
        }

        input:focus {
            background-color: purple;
            color: white;
        }

        input:required {
            border: 2px solid red;
        }

        /* Pseudo-elemento */
        p::first-line {
            color: red;
        }

        p::first-letter {
            font-size: 3em;
            color: purple;
        }

        p::selection {
            background-color: yellow;
        }

        h2::before {
            content: "{";
            color: violet;
        }
        h2::after {
            content: "}";
            color: violet;
        }

    </style>

</head>
<body>
    
    <div>
        Conteúdo da div
    </div>

    <h2>Conteúdo do h2</h2>
    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Doloribus, architecto. Ipsa, ea a amet doloribus magnam numquam aperiam, quam iste exercitationem praesentium sit et veniam nulla, culpa optio fuga fugit?
    </p>

    <a href="https://www.google.com/">Google</a> | 
    <a href="https://www.facebook.com/">Facebook</a> | 
    <a href="https://www.instagram.com/">Instagram</a>

    <h2>Formulários</h2>
    <input type="checkbox" name="" id=""> aceito <br>
    <input type="radio" name="opcao" id=""> Sim <br>
    <input type="radio" name="opcao" id=""> Não <br>
    <input type="text" required placeholder="Digite seu nome" name="" id="">
    <input type="text" placeholder="Digite seu nome" name="" id="">

    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Numquam facere, illo sapiente ipsam alias mollitia dicta magni, quos, soluta quam odit ducimus ab! Odio sapiente accusamus possimus aliquid soluta enim?
    </p>

</body>
</html>
```

---

#### Arquivo completo - desafio-pseudo-classe-elemento.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Desafio pseudo-classe-elemento</title>

    <style>
        a {
            text-decoration: none;
            padding: 0.5em 1em;
            color: blueviolet;
        }

        a:hover {
            background-color: blueviolet;
            color: white;
            
        }

        a:active {
            color: lightblue;
        }

    </style>
    
</head>
<body>
    <a href="">Home</a> | 
    <a href="">Sobre</a> | 
    <a href="">Empresa</a> |
    <a href="">Produtos</a> |
    <a href="">Contato</a>
</body>
</html>
```

---

---



### 66. Herança e Especificidade

Esses dois conceitos são fundamentais para entender **por que determinado estilo CSS é aplicado a um elemento**, principalmente quando existem várias regras que poderiam afetá-lo.

------

#### 1. Herança

##### O que é?

**Herança** é o mecanismo pelo qual algumas propriedades CSS de um elemento são transmitidas para seus **elementos filhos**.

Por exemplo:

```css
body {
    color: black;
    font-family: Arial, sans-serif;
}
```

Os elementos dentro do `<body>` normalmente herdam essas propriedades.

Então:

```html
<body>
    <h1>Título</h1>
    <p>Texto</p>
</body>
```

pode herdar:

```css
color: black;
font-family: Arial;
```

sem que você precise declarar essas propriedades novamente em `h1` e `p`.

------

##### Para que serve?

A herança evita repetição de código.

Em vez de:

```css
h1 {
    font-family: Arial;
}

p {
    font-family: Arial;
}

span {
    font-family: Arial;
}
```

podemos fazer:

```css
body {
    font-family: Arial;
}
```

E os elementos descendentes poderão herdar essa propriedade.

------

#### 2. Como funciona?

A herança acontece de **elemento pai para elemento filho**.

Por exemplo:

```html
<div>
    <p>
        <span>Texto</span>
    </p>
</div>
```

Podemos imaginar:

```text
div
└── p
    └── span
```

Se definirmos:

```css
div {
    color: red;
}
```

o `p` e o `span` poderão herdar `color: red`.

##### Mas atenção:

**Nem todas as propriedades são herdadas.**

Por exemplo:

```css
body {
    color: red;
}
```

`color` é herdável.

Mas:

```css
body {
    border: 1px solid red;
}
```

o `border` **não é herdado automaticamente** pelos filhos.

É exatamente por isso que no código temos:

```css
h1 {
    border: inherit;
}
```

------

#### 3. `inherit`

##### O que é?

`inherit` é um valor CSS que diz:

> **"Use o valor que o elemento pai possui para esta propriedade."**

No seu código:

```css
body {
    border: 1px solid red;
}

h1 {
    border: inherit;
}
```

Normalmente o `<h1>` não herdaria `border`.

Mas `inherit` força o `<h1>` a utilizar o valor de `border` do pai.

Resultado:

```text
body → border: 1px solid red
           ↓
h1   → border: 1px solid red
```

##### Sintaxe

```css
elemento {
    propriedade: inherit;
}
```

Exemplo:

```css
p {
    color: inherit;
}
```

------

#### 4. Outros valores importantes relacionados à herança

Além de `inherit`, existem alguns valores especiais que você encontrará durante seus estudos.

##### `inherit`

Herda explicitamente do elemento pai:

```css
color: inherit;
```

##### `initial`

Volta para o valor inicial definido pela especificação CSS:

```css
color: initial;
```

##### `unset`

Funciona como `inherit` para propriedades herdáveis e como `initial` para propriedades que não são herdáveis.

```css
color: unset;
```

Por enquanto, o mais importante é memorizar:

> **`inherit` = herdar do pai.**

------

#### 5. Especificidade

##### O que é?

**Especificidade** é o mecanismo utilizado pelo CSS para determinar qual regra deve prevalecer quando **mais de uma regra pode ser aplicada ao mesmo elemento**.

Por exemplo:

```css
p {
    color: red;
}

.destaque {
    color: blue;
}
```

E:

```html
<p class="destaque">Texto</p>
```

As duas regras selecionam o `<p>`.

Então surge a pergunta:

> Qual cor será aplicada?

A resposta é: **azul**.

Porque `.destaque` é mais específico que `p`.

------

#### 6. Como funciona?

A especificidade pode ser entendida como uma espécie de **pontuação**.

De forma simplificada, temos:

| Seletor             | Peso de especificidade |
| ------------------- | ---------------------- |
| Inline              | maior prioridade       |
| `#id`               | 100                    |
| `.classe`           | 10                     |
| `:pseudo-classe`    | 10                     |
| `[atributo]`        | 10                     |
| `elemento`          | 1                      |
| `::pseudo-elemento` | 1                      |

Por exemplo:

```css
p {
    color: red;
}

.destaque {
    color: blue;
}

#promocao {
    color: brown;
}
```

HTML:

```html
<p class="destaque" id="promocao">
    Texto
</p>
```

Temos:

```text
p             → 1
.destaque     → 10
#promocao     → 100
```

Portanto:

```text
#promocao
   ↓
vence
```

O texto ficará **marrom**.

------

#### 7. Exemplo de especificidade

No código temos:

```css
#promocao {
    color: brown;
}

p {
    color: red;
}

.destaque {
    color: blueviolet;
}
```

E:

```html
<p class="destaque" id="promocao">
```

Todas as três regras se aplicam.

Mas:

```text
p          → 1
.destaque  → 10
#promocao  → 100
```

Logo:

```css
#promocao {
    color: brown;
}
```

vence as outras.

------

#### 8. E se a especificidade for igual?

Nesse caso entra em ação a **ordem das regras**.

Por exemplo:

```css
p {
    color: red;
}

p {
    color: blue;
}
```

Os dois seletores têm a mesma especificidade.

Então a última regra vence:

```css
p {
    color: blue;
}
```

Resultado: **azul**.

Isso é chamado de **regra posterior** ou **ordem de origem**.

------

#### 9. `!important`

> Regra com `!important`

Podemos escrever:

```css
p {
    color: red !important;
}
```

O `!important` dá uma prioridade especial à declaração.

Por exemplo:

```css
p {
    color: red !important;
}

#promocao {
    color: brown;
}
```

Mesmo o `#promocao` sendo mais específico, a declaração com `!important` pode prevalecer.

##### Porém:

**Evite usar `!important` sem necessidade.**

Ele pode tornar o CSS difícil de manter porque cria uma prioridade que depois pode ser difícil de sobrescrever.

------

#### 10. Inline, ID, classe e elemento

Regra simplificada para estudar especificidade:

```text
1) Estilo em linha
2) IDs
3) Classes, atributos e pseudo-classes
4) Elementos e pseudo-elementos
```

Por exemplo:

```html
<p
    id="promocao"
    class="destaque"
    style="color: green;">
    Texto
</p>
```

Temos:

```text
style=""       → inline
#promocao      → ID
.destaque      → classe
p              → elemento
```

Em termos de especificidade:

```text
inline
  ↓
ID
  ↓
classe/atributo/pseudo-classe
  ↓
elemento/pseudo-elemento
```

------

#### 11. Seletor de atributo e especificidade

No código:

```css
p[class] {
    border: 2px solid green;
}
```

Aqui temos duas coisas:

```text
p       → seletor de elemento
[class] → seletor de atributo
```

O seletor:

```css
p[class]
```

seleciona `<p>` que possuem o atributo `class`.

Por exemplo:

```html
<p class="destaque">Texto</p>
```

será selecionado.

Mas:

```html
<p>Texto</p>
```

não será.

A especificidade de:

```css
p[class]
```

é maior que simplesmente:

```css
p
```

porque possui:

```text
elemento + atributo
```

------

#### 12. `p[id]`

No código:

```css
p[id] {
    background-color: bisque;
}
```

Isso significa:

> Selecione elementos `<p>` que possuem o atributo `id`.

Por exemplo:

```html
<p id="promocao">Texto</p>
```

será selecionado.

Isso é diferente de:

```css
#promocao
```

porque `#promocao` procura especificamente um elemento cujo ID seja `promocao`.

Enquanto:

```css
p[id]
```

procura **qualquer `<p>` que tenha um atributo `id`**, independentemente do valor.

------

#### 13. Um detalhe importante: especificidade não é simplesmente "quem vem por último"

> 1. `!important`
> 2. Seletores mais específicos
> 3. Última regra processada

Isso é uma **boa simplificação para começar**, mas existe uma hierarquia mais completa no CSS, porque entram também conceitos como **origem, importância, especificidade, ordem de declaração e camadas (`@layer`)**.

Para o seu nível atual, pense assim:

##### Primeiro:

**Existe uma regra `!important`?**

↓

##### Depois:

**Qual regra possui maior especificidade?**

↓

##### Se houver empate:

**Qual foi declarada por último?**

Isso já é suficiente para compreender a grande maioria dos exemplos básicos de especificidade.

------

#### Exemplos para fixar

##### Exemplo 1 — classe vence elemento

```css
p {
    color: red;
}

.destaque {
    color: blue;
}
<p class="destaque">Texto</p>
```

Resultado:

**azul**

------

##### Exemplo 2 — ID vence classe

```css
.destaque {
    color: blue;
}

#principal {
    color: green;
}
<p id="principal" class="destaque">Texto</p>
```

Resultado:

**verde**

------

##### Exemplo 3 — empate

```css
p {
    color: red;
}

p {
    color: blue;
}
```

Resultado:

**azul**, porque a segunda regra vem depois.

------

##### Exemplo 4 — herança

```css
body {
    color: red;
}
<body>
    <p>Texto vermelho</p>
</body>
```

O `<p>` pode herdar `color: red`.

------

##### Exemplo 5 — `inherit`

```css
body {
    border: 1px solid red;
}

h1 {
    border: inherit;
}
```

O `<h1>` recebe explicitamente a borda do `body`.

------

#### Para memorizar

##### Herança

Pense:

> **"O filho pode receber algumas propriedades do pai."**

```text
PAI
 ↓
FILHO
 ↓
NETO
```

Mas **nem todas as propriedades são herdadas**.

E:

```css
inherit
```

significa:

> **"Pegue o valor do pai."**

------

##### Especificidade

Pense em uma disputa:

```text
!important
     ↓
inline
     ↓
ID
     ↓
classe / atributo / pseudo-classe
     ↓
elemento / pseudo-elemento
     ↓
se houver empate → última regra
```

Uma forma ainda mais fácil de decorar a pontuação:

```text
ID          = 100
classe      = 10
elemento    = 1
```

Por exemplo:

```css
#id.classe p
```

tem:

```text
ID       → 100
classe   → 10
elemento → 1

total → 111
```

**E o ponto mais importante:** especificidade é utilizada quando **duas ou mais regras disputam a mesma propriedade no mesmo elemento**.

---

#### Arquivo completo - herança-especificidade.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Herança & especificidade</title>
    <style>
        /* Herança */
        body {
            font-family: Arial, Helvetica, sans-serif;
            color: black;
            border: 1px solid red;
            /* background-color: blueviolet; */
            padding: 3em;
        }

        h1 {
            color: violet;
            border: inherit;
        }

        p {
            border: 1px solid red;
            padding: 0.5em;
        }

        /* Especificidade
        é a maneira de como os navegadores definem quais valores de proprieddes são os mais relevantes para o elemento a ser utilizado. a especificidade é baseada apenas nas regras impostas na composição de diferentes tipos de seletores.

        Ordem de aplicação das formatações:
        1. Regra com !important
        2. Seletores mais específicos
        3. Última regra processada
        
        */

        #promocao {
            color: brown;
        }

        p {
            color: red;
        }

        .destaque {
            color: blueviolet;
        }

        /* PARTE 2
        Seletores mais específicos
        1) Estilo em linha (inline style)
        2) IDs
        3) Classes, atributos e pseudo-classes
        4) Elementos e pseudo-elementos
        */
        
        p[class] {
            border: 2px solid green;
        }

        p[id] {
            background-color: bisque;
        }

    </style>
</head>
<body>
    <h1>Herança & especificidade</h1>
    <p class="destaque" id="promocao">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Facilis iusto itaque saepe quasi ipsam perferendis, doloribus obcaecati doloremque, ab expedita harum quas maiores tempora excepturi accusantium illum perspiciatis consequatur cupiditate!
    </p>

    <p class="teste">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Facilis iusto itaque saepe quasi ipsam perferendis, doloribus obcaecati doloremque, ab expedita harum quas maiores tempora excepturi accusantium illum perspiciatis consequatur cupiditate!
    </p>

    <span>Texto</span>
</body>
</html>
```

---

#### Link da aula

[Specificity Calculator](https://specificity.keegan.st/#google_vignette) - *A visual way to understand* [CSS specificity](https://www.w3.org/TR/selectors-4/#specificity)*. Change the selectors or paste in your own.*



----

---



### 67. [Projeto] Anna Bella - Página principal

#### Arquivo completo - index.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Anna Bella</title>
    <link rel="stylesheet" href="estilo.css">
</head>
<body>
    <div id="principal">
        <img src="./img/capa.png" alt="capa">

        <div id="menu">
            <a href="">Home</a> |
            <a href="">Biografia</a> |
            <a href="">Campanhas publicitárias</a> |
            <a href="">Contato</a> |
        </div>

        <div id="conteudo">

            <h1>Sobre Anna Bella</h1>

            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quos similique amet corrupti illo sequi id unde quisquam, vitae aliquid quia ullam adipisci, reiciendis minima corporis! Perspiciatis consequuntur expedita corporis harum.
            </p>
            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quos similique amet corrupti illo sequi id unde quisquam, vitae aliquid quia ullam adipisci, reiciendis minima corporis! Perspiciatis consequuntur expedita corporis harum.
            </p>
            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quos similique amet corrupti illo sequi id unde quisquam, vitae aliquid quia ullam adipisci, reiciendis minima corporis! Perspiciatis consequuntur expedita corporis harum.
            </p>
        </div> <!--conteudo-->

        <div id="rodape">
            <h4>Todos os direitos reservados</h4>
        </div>

    </div> <!--principal-->
</body>
</html>
```



---

---



### 68. [Projeto] Anna Bella - Formatação CSS

#### Arquivo completo - estilo.css

 ```css
 /* 
 menu: #c5c5b2
 conteudo: #e8e8d9
 link: #4b566a
 h1: #828271
  */
 
  body {
     background: #d2d2c1 url('img/fundo.png');
     font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
  }
 
  #principal {
     width: 900px;
  }
 
  #menu {
     background: #c5c5b2;
     padding: 20px;
  }
 
  #conteudo {
     background: #e8e8d9;
     padding: 10px;
  }
 
  #rodape {
     text-align: center;
  }
 
  a {
     color: #4b566a;
     text-decoration: none;
     font-weight: bold;
     text-transform: uppercase;
  }
 
  h1 {
     color: #828271;
     font-size: 1.3em;
  }
 ```



---

---



### 69. [Projeto] Anna Bella - Navegação

#### Arquivo completo - index.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Anna Bella</title>
    <link rel="stylesheet" href="estilo.css">
</head>
<body>
    <div id="principal">
        <img src="./img/capa.png" alt="capa">

        <div id="menu">
            <a href="index.html">Home</a> |
            <a href="./conteudo/biografia.html">Biografia</a> |
            <a href="./conteudo/campanhas.html">Campanhas publicitárias</a> |
            <a href="./conteudo/contato.html">Contato</a> |
        </div>

        <div id="conteudo">

            <h1>Sobre Anna Bella</h1>

            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quos similique amet corrupti illo sequi id unde quisquam, vitae aliquid quia ullam adipisci, reiciendis minima corporis! Perspiciatis consequuntur expedita corporis harum.
            </p>
            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quos similique amet corrupti illo sequi id unde quisquam, vitae aliquid quia ullam adipisci, reiciendis minima corporis! Perspiciatis consequuntur expedita corporis harum.
            </p>
            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quos similique amet corrupti illo sequi id unde quisquam, vitae aliquid quia ullam adipisci, reiciendis minima corporis! Perspiciatis consequuntur expedita corporis harum.
            </p>
        </div> <!--conteudo-->

        <div id="rodape">
            <h4>Todos os direitos reservados</h4>
        </div>

    </div> <!--principal-->
</body>
</html>
```

---

#### Arquivo completo - biografia.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Biografia - Anna Bella</title>
    <link rel="stylesheet" href="../estilo.css">
</head>
<body>
    <div id="principal">
        <img src="../img/capa.png" alt="capa">

        <div id="menu">
            <a href="../index.html">Home</a> |
            <a href="./biografia.html">Biografia</a> |
            <a href="./campanhas.html">Campanhas publicitárias</a> |
            <a href="./contato.html">Contato</a> |
        </div>

        <div id="conteudo">

            <h1>Biografia</h1>

            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quos similique amet corrupti illo sequi id unde quisquam, vitae aliquid quia ullam adipisci, reiciendis minima corporis! Perspiciatis consequuntur expedita corporis harum.
            </p>

            <img src="../img/foto1.png" alt="foto1">

            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quos similique amet corrupti illo sequi id unde quisquam, vitae aliquid quia ullam adipisci, reiciendis minima corporis! Perspiciatis consequuntur expedita corporis harum.
            </p>

            <img src="../img/foto2.png" alt="foto2">

            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quos similique amet corrupti illo sequi id unde quisquam, vitae aliquid quia ullam adipisci, reiciendis minima corporis! Perspiciatis consequuntur expedita corporis harum.
            </p>

            <img src="../img/foto3.png" alt="foto3">

        </div> <!--conteudo-->

        <div id="rodape">
            <h4>Todos os direitos reservados</h4>
        </div>

    </div> <!--principal-->
</body>
</html>
```

---

#### Arquivo completo - campanhas.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Campanhas - Anna Bella</title>
    <link rel="stylesheet" href="../estilo.css">
</head>
<body>
    <div id="principal">
        <img src="../img/capa.png" alt="capa">

        <div id="menu">
            <a href="../index.html">Home</a> |
            <a href="./biografia.html">Biografia</a> |
            <a href="./campanhas.html">Campanhas publicitárias</a> |
            <a href="./contato.html">Contato</a> |
        </div>

        <div id="conteudo">

            <h1>Campanhas Publicitárias</h1>

            <p>
                Lorem ipsum, dolor sit amet.
            </p>

            <img src="../img/foto1.png" alt="foto1">

            <p>
                Lorem ipsum, dolor sit amet.
            </p>

            <img src="../img/foto2.png" alt="foto2">

            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit.
            </p>

            <img src="../img/foto3.png" alt="foto3">
        </div> <!--conteudo-->

        <div id="rodape">
            <h4>Todos os direitos reservados</h4>
        </div>

    </div> <!--principal-->
</body>
</html>
```

---

#### Arquivo completo - contato.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Contato - Anna Bella</title>
    <link rel="stylesheet" href="../estilo.css">
</head>
<body>
    <div id="principal">
        <img src="../img/capa.png" alt="capa">

        <div id="menu">
            <a href="../index.html">Home</a> |
            <a href="./biografia.html">Biografia</a> |
            <a href="./campanhas.html">Campanhas publicitárias</a> |
            <a href="./contato.html">Contato</a> |
        </div>

        <div id="conteudo">

            <h1>Contato</h1>

            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quos similique amet corrupti illo sequi id unde quisquam, vitae aliquid quia ullam adipisci, reiciendis minima corporis!
            </p>

            <img src="../img/foto3.png" alt="">

            <div>
                <strong>Telefone: (11) 99999-9999</strong> <br>
                <strong>E-mail: annabella@email.com</strong> <br>
            </div>
            
        </div> <!--conteudo-->

        <div id="rodape">
            <h4>Todos os direitos reservados</h4>
        </div>

    </div> <!--principal-->
</body>
</html>
```



---

---

---

