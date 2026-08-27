# Desenvolvimento Web Completo

## Professor Hamilton Damasceno

## Seção 11: CSS Avançado 

### 73. Posicionamentos (Teoria)

#### 📐 Posicionamentos no CSS — blocos de construção

Antes de estudar `position`, é importante entender **como os elementos HTML ocupam espaço na página**. O navegador possui um fluxo padrão de organização dos elementos, e o CSS permite alterar esse comportamento.

------

#### 1. Nível de bloco e nível em linha

##### O que é?

Os elementos HTML podem ter, de maneira simplificada, dois comportamentos principais de exibição:

- **Elementos de bloco (`block`)**
- **Elementos em linha (`inline`)**

Isso é controlado principalmente pela propriedade CSS `display`.

##### Para que serve?

Determina **como o elemento ocupa espaço e como ele se relaciona com os elementos ao redor**.

##### Como funciona?

##### 🔲 `display: block`

Um elemento de bloco:

- ocupa, por padrão, toda a largura disponível;
- começa em uma nova linha;
- permite definir `width`, `height`, `margin`, `padding` etc.

Exemplos comuns:

```html
<div>Bloco 1</div>
<div>Bloco 2</div>
<p>Parágrafo</p>
<h1>Título</h1>
```

Visualmente:

```text
┌──────────────────────────────┐
│ Bloco 1                      │
└──────────────────────────────┘
┌──────────────────────────────┐
│ Bloco 2                      │
└──────────────────────────────┘
```

##### ➡️ `display: inline`

Um elemento em linha ocupa apenas o espaço necessário para seu conteúdo e permanece na mesma linha, quando houver espaço.

Exemplos comuns:

```html
<span>Texto 1</span>
<span>Texto 2</span>
<a>Link</a>
<strong>Negrito</strong>
```

Visualmente:

```text
Texto 1 Texto 2 Link Negrito
```

##### Sintaxe

```css
seletor {
    display: block;
}
```

ou:

```css
seletor {
    display: inline;
}
```

##### Principais valores

| `display`      | Comportamento                                |
| -------------- | -------------------------------------------- |
| `block`        | Ocupa uma linha inteira                      |
| `inline`       | Permanece na mesma linha                     |
| `inline-block` | Fica em linha, mas aceita `width` e `height` |
| `none`         | Remove o elemento da página                  |
| `flex`         | Cria um contêiner flexível                   |
| `grid`         | Cria um contêiner de grade                   |

##### Exemplo

```html
<div class="caixa">Caixa</div>
<span class="texto">Texto</span>
<span class="texto">Outro texto</span>
.caixa {
    display: block;
    background-color: lightblue;
}

.texto {
    display: inline;
    background-color: yellow;
}
```

##### 🧠 Para memorizar

> **Block = quebra linha.**
> **Inline = continua na linha.**

------

#### 2. Elementos contêineres ou pai

##### O que é?

Um **contêiner** é um elemento que contém outros elementos.

Por exemplo:

```html
<body>
    <div>
        <h1>Título</h1>
        <p>Texto</p>
    </div>
</body>
```

Aqui:

```text
body
└── div
    ├── h1
    └── p
```

`body` é pai de `div`.

`div` é pai de `h1` e `p`.

##### Para que serve?

O conceito de **pai e filho** é fundamental para posicionamento porque alguns elementos posicionados, principalmente `position: absolute`, procuram um **elemento ancestral de referência**.

##### Como funciona?

Imagine:

```html
<div class="pai">
    <div class="filho">
        Conteúdo
    </div>
</div>
.pai {
    position: relative;
}

.filho {
    position: absolute;
    top: 20px;
    left: 30px;
}
```

Nesse caso, o `.filho` será posicionado tomando o `.pai` como referência.

Isso será extremamente importante quando estudarmos `absolute`.

##### Sintaxe

Não existe uma propriedade CSS chamada `pai`.

É uma **relação estrutural do HTML**:

```html
<elemento-pai>
    <elemento-filho>
    </elemento-filho>
</elemento-pai>
```

##### Principais contêineres

```html
<body>
<div>
<section>
<article>
<header>
<main>
<footer>
```

Qualquer elemento pode funcionar como contêiner.

##### 🧠 Para memorizar

> **Pai = contém.**
> **Filho = está dentro.**

E uma regra importantíssima:

> **`absolute` procura um ancestral posicionado para usar como referência.**

------

#### 3. Fluxo normal — `position: static`

##### O que é?

É o **posicionamento padrão** dos elementos.

Se você não declarar `position`, o elemento normalmente estará em:

```css
position: static;
```

##### Para que serve?

É o comportamento natural do navegador.

Os elementos são colocados seguindo o **fluxo normal do documento**.

##### Como funciona?

Imagine:

```html
<div>Caixa 1</div>
<div>Caixa 2</div>
<div>Caixa 3</div>
```

O navegador organiza:

```text
Caixa 1
Caixa 2
Caixa 3
```

Cada elemento ocupa seu espaço normalmente.

##### Sintaxe

```css
.caixa {
    position: static;
}
```

Ou simplesmente não declarar `position`.

##### Atenção ⚠️

Com `static`, as propriedades:

```css
top
right
bottom
left
```

**não deslocam o elemento.**

Por exemplo:

```css
.caixa {
    position: static;
    top: 50px;
}
```

O `top: 50px` não terá o efeito esperado.

##### 🧠 Para memorizar

> **`static` = comportamento normal.**

Pense:

> "Não estou mandando o elemento sair do fluxo."

------

#### 4. Posicionamento relativo — `position: relative`

##### O que é?

`relative` mantém o elemento **no fluxo normal**, mas permite deslocá-lo visualmente a partir de sua posição original.

##### Para que serve?

É muito utilizado para:

1. deslocar um elemento;
2. criar uma referência para elementos `absolute`;
3. criar pequenos ajustes de posicionamento.

##### Como funciona?

Imagine:

```html
<div class="caixa">Caixa</div>
.caixa {
    position: relative;
    top: 20px;
}
```

A caixa será deslocada **20px para baixo**.

Porém, seu espaço original continua reservado.

Antes:

```text
Caixa
Outra caixa
```

Depois:

```text
Caixa        ← visualmente deslocada

Outra caixa
```

O navegador continua considerando que a primeira caixa ocupa seu espaço original.

##### Sintaxe

```css
.elemento {
    position: relative;
    top: 20px;
    left: 30px;
}
```

##### Principais propriedades

```css
position: relative;

top: 20px;
right: 10px;
bottom: 20px;
left: 30px;
```

##### Exemplo

```html
<div class="caixa">
    Olá!
</div>
.caixa {
    position: relative;
    left: 50px;
    top: 20px;
}
```

Resultado:

- `left: 50px` → desloca para a direita;
- `top: 20px` → desloca para baixo.

##### Uma característica MUITO importante

`relative` é frequentemente utilizado no elemento **pai**:

```css
.pai {
    position: relative;
}

.filho {
    position: absolute;
}
```

Isso permite que o filho `absolute` use o pai como referência.

##### 🧠 Para memorizar

> **`relative` = continua no lugar no fluxo, mas pode ser deslocado.**

E:

> **`relative` no pai + `absolute` no filho = combinação clássica.**

------

#### 5. Posicionamento absoluto — `position: absolute`

##### O que é?

`absolute` retira o elemento do **fluxo normal** do documento e permite posicioná-lo em relação a um ancestral de referência.

##### Para que serve?

É usado quando você precisa colocar um elemento em uma posição específica, por exemplo:

- ícone dentro de um campo;
- botão sobre uma imagem;
- etiqueta sobre um produto;
- elemento sobreposto;
- menu;
- badge;
- elementos decorativos.

##### Como funciona?

Considere:

```html
<div class="pai">
    <div class="filho">
        Filho
    </div>
</div>
.pai {
    position: relative;
}

.filho {
    position: absolute;
    top: 20px;
    left: 30px;
}
```

O navegador interpreta aproximadamente assim:

```text
PAI
┌──────────────────────────────┐
│                              │
│   FILHO                      │
│                              │
│                              │
└──────────────────────────────┘
```

O `.filho` utiliza o `.pai` como referência.

##### Sintaxe

```css
.filho {
    position: absolute;
    top: 20px;
    left: 30px;
}
```

##### Característica fundamental

Ao utilizar:

```css
position: absolute;
```

o elemento **sai do fluxo normal**.

Isso significa que os outros elementos passam a se comportar como se aquele elemento não ocupasse mais aquele espaço no fluxo.

##### Exemplo clássico

```html
<div class="card">
    <img src="produto.jpg" alt="Produto">
    <span class="etiqueta">Novo</span>
</div>
.card {
    position: relative;
}

.etiqueta {
    position: absolute;
    top: 10px;
    right: 10px;
}
```

A etiqueta pode ficar sobre a imagem:

```text
┌──────────────────────────┐
│                 ┌──────┐ │
│                 │ NOVO │ │
│      IMAGEM     └──────┘ │
│                          │
└──────────────────────────┘
```

##### 🧠 Para memorizar

> **`absolute` = sai do fluxo e pode ser colocado exatamente onde você quiser.**

E lembre:

> **`absolute` procura um ancestral posicionado.**

Normalmente fazemos:

```css
.pai {
    position: relative;
}

.filho {
    position: absolute;
}
```

------

#### 6. Posicionamento fixo — `position: fixed`

##### O que é?

`fixed` posiciona o elemento em relação à **janela de visualização (viewport)**.

Ele permanece no mesmo lugar da tela mesmo quando a página é rolada.

##### Para que serve?

É muito utilizado para:

- botão "voltar ao topo";
- menu fixo;
- barra de navegação;
- botão de WhatsApp;
- elementos que precisam permanecer visíveis;
- cabeçalhos ou controles fixos.

##### Como funciona?

```css
.botao {
    position: fixed;
    bottom: 20px;
    right: 20px;
}
```

O botão ficará:

```text
┌──────────────────────────────┐
│                              │
│                              │
│          PÁGINA              │
│                              │
│                              │
│                        ┌───┐ │
│                        │ + │ │
│                        └───┘ │
└──────────────────────────────┘
```

Ao rolar a página:

```text
┌──────────────────────────────┐
│                              │
│       OUTRO CONTEÚDO         │
│                              │
│                              │
│                        ┌───┐ │
│                        │ + │ │
│                        └───┘ │
└──────────────────────────────┘
```

O botão continua no mesmo lugar da tela.

##### Sintaxe

```css
.elemento {
    position: fixed;
    bottom: 20px;
    right: 20px;
}
```

##### Exemplo

```html
<button class="ajuda">?</button>
.ajuda {
    position: fixed;
    right: 20px;
    bottom: 20px;
}
```

##### 🧠 Para memorizar

> **`fixed` = preso à tela.**

Pense:

> **Absolute → preso à referência.**
> **Fixed → preso à janela.**

------

#### 7. Deslocamento de caixa — `top`, `right`, `bottom`, `left`

Essas propriedades são chamadas de **offsets** ou propriedades de deslocamento.

Elas indicam **quanto o elemento deve ser deslocado a partir de uma determinada borda**.

------

#### `top`

##### O que é?

Define a distância em relação ao **topo**.

```css
top: 20px;
```

Significa:

> "Fique 20px abaixo da referência pelo topo."

Exemplo:

```css
.elemento {
    position: absolute;
    top: 20px;
}
```

------

#### `right`

Define a distância em relação à **direita**.

```css
right: 20px;
```

Exemplo:

```css
.elemento {
    position: fixed;
    right: 20px;
}
```

Significa:

> "Fique 20px afastado da direita da janela."

------

#### `bottom`

Define a distância em relação à **parte inferior**.

```css
bottom: 20px;
```

Exemplo:

```css
.elemento {
    position: fixed;
    bottom: 20px;
}
```

------

#### `left`

Define a distância em relação à **esquerda**.

```css
left: 20px;
```

Exemplo:

```css
.elemento {
    position: absolute;
    left: 20px;
}
```

------

#### ⚠️ Uma regra muito importante

A direção pode parecer contraintuitiva no começo.

Observe:

```css
top: 20px;
```

⬇️ desce

```css
left: 20px;
```

➡️ vai para a direita

```css
right: 20px;
```

⬅️ fica afastado da direita

```css
bottom: 20px;
```

⬆️ fica afastado da parte inferior

Uma forma fácil de visualizar:

```text
             TOP
              ↓
              20px

LEFT →     ELEMENTO     ← RIGHT

              20px
              ↑
           BOTTOM
```

------

#### 🧩 Como `position` e deslocamentos trabalham juntos

As propriedades `top`, `right`, `bottom` e `left` **não são suficientes sozinhas**.

Normalmente precisamos de:

```css
position: relative;
position: absolute;
position: fixed;
```

Por exemplo:

```css
.elemento {
    position: absolute;
    top: 30px;
    left: 50px;
}
```

Aqui temos:

```text
position
   ↓
"Como o elemento será posicionado?"

top / left
   ↓
"Quanto ele será deslocado?"
```

------

#### 📚 Resumo geral

| `position` | Permanece no fluxo? | Referência principal  | Rola com a página? |
| ---------- | ------------------- | --------------------- | ------------------ |
| `static`   | ✅ Sim               | Fluxo normal          | ✅ Sim              |
| `relative` | ✅ Sim               | Sua posição original  | ✅ Sim              |
| `absolute` | ❌ Não               | Ancestral posicionado | ✅ Sim              |
| `fixed`    | ❌ Não               | Viewport/tela         | ❌ Não              |

------

#### 🧠 Para memorizar

Guarde estas quatro frases:

##### `static`

> **Normal.**

É o posicionamento padrão.

##### `relative`

> **Move, mas mantém seu espaço.**

Continua no fluxo.

##### `absolute`

> **Sai do fluxo e usa uma referência.**

Normalmente:

```css
.pai {
    position: relative;
}

.filho {
    position: absolute;
}
```

##### `fixed`

> **Fica preso à tela.**

Mesmo com a rolagem:

```css
position: fixed;
```

------

#### 🎯 A sequência mental que recomendo

Quando você encontrar um código como:

```css
.caixa {
    position: absolute;
    top: 20px;
    right: 30px;
}
```

leia assim:

> **1. `absolute`** → tire a caixa do fluxo normal.
> **2. `top: 20px`** → coloque 20px a partir do topo da referência.
> **3. `right: 30px`** → mantenha 30px de distância da direita da referência.

E quando encontrar:

```css
.pai {
    position: relative;
}

.filho {
    position: absolute;
    top: 0;
    right: 0;
}
```

pense imediatamente:

> **"O filho está sendo posicionado no canto superior direito do pai."**



---

---



### 74. Posicionamentos (Prática)

#### Arquivo completo - posicionamento.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Posicionamento</title>
    <style>
        body {
            background-color: purple;
        }

        #container {
            width: 700px;
            background-color: white;
            margin: 10px auto;
            padding: 8px;
            position: relative;
        }
        .borda {
            border: 1px solid red;
        }

        /* Fluxo normal */
        .estatica { 
            position: static;
        }

        .relativa {
            position: relative;
            top: 30px;
            right: 30px;
        }

        #container-absoluta {
            position: relative;
            border: 1px solid purple;
            padding: 10px;
        }

        .absoluta {
            background-color: lightpink;
            position: absolute;
            top: 0;
            right: 0;
            width: 450px;
            margin: 0;
        }

        #div-chat {
            background-color: green;
        }

        .fixa {
            position: fixed;
            width: 200px;
            height: 120px;
            bottom: 0;
            right: 0;
            z-index: 10;
        }

    </style>
</head>
<body>
    <div id="container">

        <div id="div-chat" class="fixa">
            <h3>chat</h3>
            <button>Enviar mensagem</button>
        </div>

        <hr>

        <div id="container-absoluta">
            <h1 class="borda">Posição absoluta</h1>
            <p class="borda absoluta">
                Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nulla doloremque sequi odit accusamus quod optio reprehenderit non quas voluptatibus numquam autem, rerum quo similique praesentium earum harum eveniet dicta quos.
            </p>

            <p>
                Lorem ipsum dolor, sit amet consectetur adipisicing elit. Facere sunt officia ratione dolore quos ullam! Animi possimus dolore harum doloremque excepturi nemo quisquam, atque sit voluptatum? Libero ullam dignissimos nulla.
            </p>
            <p>
                Lorem ipsum dolor, sit amet consectetur adipisicing elit. Facere sunt officia ratione dolore quos ullam! Animi possimus dolore harum doloremque excepturi nemo quisquam, atque sit voluptatum? Libero ullam dignissimos nulla.
            </p>

            <p>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Temporibus eius rerum ipsa quis consequatur voluptate perferendis facere molestias quos libero necessitatibus numquam laborum autem quae animi eum sequi, quidem iusto.
            </p>
            <p>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Temporibus eius rerum ipsa quis consequatur voluptate perferendis facere molestias quos libero necessitatibus numquam laborum autem quae animi eum sequi, quidem iusto.
            </p>
        </div>

        <hr>

        <h1 class="borda">Posição relativa</h1>
        <p class="borda relativa" style="background-color: lightgreen;">
            Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nulla doloremque sequi odit accusamus quod optio reprehenderit non quas voluptatibus numquam autem, rerum quo similique praesentium earum harum eveniet dicta quos.
        </p>

        <p class="borda ">
            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Impedit natus harum architecto, eligendi ducimus perspiciatis corporis tempore aliquid a consequatur? Dignissimos illum placeat ut maiores nobis natus, est optio at?
        </p>

        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Illo tempora voluptates excepturi rem laborum nihil earum quae accusamus a eos repudiandae, culpa odio id sint labore obcaecati aspernatur dolorem adipisci.
        </p>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Illo tempora voluptates excepturi rem laborum nihil earum quae accusamus a eos repudiandae, culpa odio id sint labore obcaecati aspernatur dolorem adipisci.
        </p>

        <hr>

        <h1 class="borda estatica">Fluxo normal</h1>
        <p class="borda estatica">
            Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nulla doloremque sequi odit accusamus quod optio reprehenderit non quas voluptatibus numquam autem, rerum quo similique praesentium earum harum eveniet dicta quos.
        </p>
        <p>
            Lorem ipsum dolor sit, amet consectetur adipisicing elit. Cumque optio dolore temporibus blanditiis eos officiis animi rem quas quo ducimus nihil, dignissimos voluptatibus commodi illo voluptatem reprehenderit velit facilis accusamus?
        </p>

        <p>
            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Sequi neque, fuga laboriosam beatae veritatis nihil incidunt molestiae, dignissimos id dolores provident, eaque quae hic nobis repudiandae est quod vel. Sunt.
        </p>
        <p>
            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Sequi neque, fuga laboriosam beatae veritatis nihil incidunt molestiae, dignissimos id dolores provident, eaque quae hic nobis repudiandae est quod vel. Sunt.
        </p>
        <p>
            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Sequi neque, fuga laboriosam beatae veritatis nihil incidunt molestiae, dignissimos id dolores provident, eaque quae hic nobis repudiandae est quod vel. Sunt.
        </p>

    </div>
</body>
</html>
```



---

---



### 75. Posicionamentos (Exercício)  :pushpin::round_pushpin:



### 76. Propriedade Overflow

### 77. Sobrepondo elementos com z-index

### 78. Elementos Flutuantes (Teoria)

### 79. Elementos Flutuantes (Prática) - Parte 1

### 80. Elementos Flutuantes (Prática) - Parte 2

### 81. Elementos Flutuantes (Exercício)

### 82. Elementos Flutuantes (Clear) - Parte 1

### 83. [Exercício] Criando barra de navegação vertical

### 84. Marcando página atual

### 85. Criando barra de navegação horizontal

### 86. Tags: Header, Nav, Main e Footer 

### 87. Tags: Article, Section, Aside e Time

### 88. projeto4 Site de Notícias Cidade - Criando topo

### 89. projeto4 Site de Notícias Cidade - Barra de navegação

### 90. projeto4 Site de Notícias Cidade - Layout em colunas - parte 1

### 91. projeto4 Site de Notícias Cidade - Layout em colunas - parte 2

### 92. projeto4 Site de Notícias Cidade - Barra lateral

### 93. projeto4 Site de Notícias Cidades - Área de conteúdos

### 94. projeto4 Site de Notícias Cidades - Área de notícias

---

---

---

## 