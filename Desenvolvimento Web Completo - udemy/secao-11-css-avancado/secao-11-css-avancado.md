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



### 75. Posicionamentos (Exercício)

#### Arquivo completo - index.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercício posicionamento</title>
    <link rel="stylesheet" href="./css/estilo.css">
</head>
<body>
    <div id="container">

        <img src="./img/novo.png" alt="novo site" id="img-novo-site">

        <div id="cabecalho">
            <img src="./img/logo-magalu.png" alt="logo magalu">
            <a href="">Home</a>
            <a href="">Sobre</a>
            <a href="">Produtos</a>
            <a href="">Meus pedidos</a>
            <a href="">Contato</a>
        </div> <!--cabecalho-->

        <div id="principal">

            <div id="conteudos">
                <h1>Título do site</h1>
                <p>
                    Lorem ipsum dolor sit amet consectetur, adipisicing elit. Autem qui at incidunt nobis animi enim inventore eius nihil? Laudantium, eaque aliquid ipsa odit omnis minus quibusdam veritatis iusto vel reprehenderit?
                </p>
                <p>
                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Placeat ipsam voluptatibus repellat voluptas. Enim esse alias cumque vero. Ipsa nisi suscipit, nihil tempora ut totam pariatur aliquid magni voluptates ipsam.
                </p>
            </div>
            
            <div id="conteudos">
                <h1>Título do site</h1>
                <p>
                    Lorem ipsum dolor sit amet consectetur, adipisicing elit. Autem qui at incidunt nobis animi enim inventore eius nihil? Laudantium, eaque aliquid ipsa odit omnis minus quibusdam veritatis iusto vel reprehenderit?
                </p>
                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Eligendi vero facere quas, facilis, repellat ducimus vitae, est enim nemo placeat expedita ad? Fugiat iste harum maiores iusto quisquam, eligendi modi?
                </p>
            </div>

            <div id="conteudos">
                <h1>Título do site</h1>
                <p>
                    Lorem ipsum dolor sit amet consectetur, adipisicing elit. Autem qui at incidunt nobis animi enim inventore eius nihil? Laudantium, eaque aliquid ipsa odit omnis minus quibusdam veritatis iusto vel reprehenderit?
                </p>
                <p>
                    Lorem ipsum dolor sit amet consectetur, adipisicing elit. Saepe consequuntur commodi laborum ratione nemo. Recusandae ea, obcaecati vero minima consectetur nobis quae non nulla eveniet. Repellat totam blanditiis expedita doloremque.
                </p>
            </div>

        </div> <!--principal-->

        <div id="chat">
            <h3>Chat</h3>
            <textarea name="" id="" cols="15" rows="5"></textarea>
            <button>Enviar chat</button>
        </div> <!--chat-->

    </div> <!--container-->
</body>
</html>
```

---

#### Arquivo completo - estilo.css

```css
* {
    margin: 0;
    padding: 0;
}

body {
    background-color: lightskyblue;
}

#container {
    background-color: white;
    position: relative;
    width: 700px;
    margin: 1em auto;
    padding: 0.8em;
}

#img-novo-site {
    position: absolute;
    right: 0;
    top: 0;
    width: 100px;
    z-index: 10;
}

#cabecalho {
    background-color: #0497f3;
    padding: 1em;
    position: relative;
}

#cabecalho img {
    width: 100px;
}

#cabecalho a {
    padding: 0.5em;
    text-decoration: none;
    color: white;
    font-weight: bold;
    border-radius: 0.3em;
}

#cabecalho a:hover {
    background-color: white;
    color: #0497f3;
}

#principal {
    margin: 20px 0;
}

#conteudos h1{
    padding: 10px 0;
}

#conteudos p {
    padding: 0.5em 0;
}

#chat {
    background-color: violet;
    width: 150px;
    height: 200px;
    padding: 0.5em;
    position: fixed;
    bottom: 0;
    left: 0;
}

#chat h3 {
    padding: 10px 0;
}
```



---

---



### 76. Propriedade Overflow

##### 🌊 `overflow` no CSS

A propriedade `overflow` está relacionada ao que acontece quando **o conteúdo de um elemento é maior do que o espaço disponível dentro dele**.

É uma propriedade muito importante para entender **caixas, dimensões, barras de rolagem e conteúdo que ultrapassa os limites de um elemento**.

------

#### 1. O que é?

`overflow` é uma propriedade CSS que controla **como o navegador deve tratar o conteúdo que ultrapassa os limites da caixa de um elemento**.

Imagine uma `<div>` com:

```css
.caixa {
    width: 200px;
    height: 100px;
}
```

Mas dentro dela existe muito conteúdo:

```text
┌──────────────────────┐
│ Muito conteúdo...    │
│ Muito conteúdo...    │
│ Muito conteúdo...    │
│ Muito conteúdo...    │
│ Muito conteúdo...    │
│                      │
│ conteúdo ultrapassa  │
└──────────────────────┘
```

O conteúdo pode **transbordar** para fora da caixa.

É aí que entra:

```css
overflow
```

------

#### 2. Para que serve?

Serve para controlar o conteúdo que **não cabe dentro da caixa**.

Por exemplo, podemos determinar se o conteúdo deve:

- ficar visível;
- ser cortado;
- gerar barras de rolagem;
- gerar barras de rolagem somente quando necessário.

Os usos mais comuns são:

```css
overflow: visible;
overflow: hidden;
overflow: scroll;
overflow: auto;
```

------

#### 3. Como funciona?

Imagine uma caixa:

```css
.caixa {
    width: 200px;
    height: 100px;
}
```

E seu conteúdo precisa de 300px de altura.

Temos uma situação de **overflow**:

```text
       conteúdo
          ↓
┌──────────────────┐
│                  │
│     conteúdo     │
│                  │
│                  │
└──────────────────┘
│ conteúdo extra   │
│ conteúdo extra   │
```

A propriedade `overflow` determina o que fazer com essa parte que ultrapassou os limites.

------

#### 4. Sintaxe

A sintaxe básica é:

```css
seletor {
    overflow: valor;
}
```

Exemplo:

```css
.caixa {
    width: 200px;
    height: 100px;
    overflow: hidden;
}
```

------

#### 5. Principais valores

Os quatro valores mais importantes são:

| Valor     | Comportamento                     |
| --------- | --------------------------------- |
| `visible` | Conteúdo continua visível         |
| `hidden`  | Conteúdo que ultrapassa é cortado |
| `scroll`  | Cria barras de rolagem            |
| `auto`    | Cria rolagem quando necessária    |

Vamos entender cada um.

------

#### 6. `overflow: visible`

##### O que é?

É o **valor padrão**.

O conteúdo que ultrapassa a caixa continua visível.

##### Exemplo

```css
.caixa {
    width: 200px;
    height: 100px;
    overflow: visible;
}
```

Se o conteúdo for maior:

```text
┌──────────────────┐
│ conteúdo         │
│ conteúdo         │
│ conteúdo         │
└──────────────────┘
  conteúdo extra
  conteúdo extra
  conteúdo extra
```

O conteúdo pode aparecer fora da caixa.

##### Para memorizar

> **`visible` = deixa aparecer.**

------

#### 7. `overflow: hidden`

##### O que é?

Esconde o conteúdo que ultrapassar os limites da caixa.

##### Exemplo

```css
.caixa {
    width: 200px;
    height: 100px;
    overflow: hidden;
}
```

O conteúdo que ultrapassa será cortado:

```text
┌──────────────────┐
│ conteúdo         │
│ conteúdo         │
│ conteúdo         │
│ conteúdo         │
└──────────────────┘
```

O restante existe, mas **não fica visível**.

##### Para que é muito utilizado?

Um uso bastante comum é controlar imagens:

```css
.card {
    width: 300px;
    height: 200px;
    overflow: hidden;
}
```

Por exemplo, se uma imagem for maior que o `card`, ela não escapará para fora.

##### Para memorizar

> **`hidden` = esconde o que passar.**

------

#### 8. `overflow: scroll`

##### O que é?

Cria barras de rolagem para permitir acessar o conteúdo que ultrapassa a caixa.

```css
.caixa {
    width: 200px;
    height: 100px;
    overflow: scroll;
}
```

Visualmente:

```text
┌─────────────────────┐
│ conteúdo            │
│ conteúdo            │
│ conteúdo          ↕ │
│ conteúdo          ▓ │
│ conteúdo          ▓ │
└─────────────────────┘
```

Dependendo do navegador e da situação, as barras podem aparecer mesmo quando não seriam necessárias.

##### Para memorizar

> **`scroll` = cria rolagem.**

------

#### 9. `overflow: auto`

##### O que é?

Permite que o navegador **crie barras de rolagem somente quando necessário**.

É um dos valores mais utilizados.

```css
.caixa {
    width: 200px;
    height: 100px;
    overflow: auto;
}
```

Se o conteúdo couber:

```text
┌──────────────────┐
│ conteúdo         │
│ conteúdo         │
│ conteúdo         │
└──────────────────┘
```

Não precisa de rolagem.

Se o conteúdo não couber:

```text
┌──────────────────┐
│ conteúdo       ↕ │
│ conteúdo       ▓ │
│ conteúdo       ▓ │
│ conteúdo       ▓ │
└──────────────────┘
```

O navegador permite a rolagem.

##### Para memorizar

> **`auto` = rolagem se precisar.**

------

#### 10. `overflow-x` e `overflow-y`

Além de `overflow`, existem:

```css
overflow-x
overflow-y
```

Eles permitem controlar **cada direção separadamente**.

##### `overflow-x`

Controla o transbordamento **horizontal**.

```css
.caixa {
    overflow-x: auto;
}
```

Pode ser útil para conteúdos muito largos.

Por exemplo, uma tabela:

```text
←────────────────────────────→
┌───────────────────────────────┐
│ Tabela muito larga            │
└───────────────────────────────┘
```

------

##### `overflow-y`

Controla o transbordamento **vertical**.

```css
.caixa {
    overflow-y: auto;
}
```

Muito útil para criar uma área com altura limitada:

```text
┌──────────────────┐
│ Item 1           │
│ Item 2           │
│ Item 3           │
│ Item 4          ↕│
│ Item 5          ▓│
└──────────────────┘
```

------

#### 11. Sintaxe de `overflow-x` e `overflow-y`

```css
.caixa {
    overflow-x: auto;
    overflow-y: hidden;
}
```

Nesse exemplo:

- horizontal → rolagem automática;
- vertical → conteúdo excedente escondido.

------

#### 12. Podemos usar `overflow` em duas direções

Também podemos definir valores diferentes para horizontal e vertical usando dois valores:

```css
.caixa {
    overflow: auto hidden;
}
```

A ordem é:

```text
overflow: horizontal vertical;
             ↓          ↓
             X          Y
```

Portanto:

```css
overflow: auto hidden;
```

significa:

```text
X → auto
Y → hidden
```

Outro exemplo:

```css
overflow: hidden auto;
```

significa:

```text
X → hidden
Y → auto
```

##### 🧠 Para memorizar

> **Primeiro X, depois Y.**

------

#### 13. Exemplo prático — caixa com rolagem

HTML:

```html
<div class="caixa">
    <p>
        Este é um texto muito grande que não cabe
        dentro da caixa.
    </p>

    <p>
        Mais conteúdo para demonstrar o overflow.
    </p>

    <p>
        Mais conteúdo...
    </p>
</div>
```

CSS:

```css
.caixa {
    width: 300px;
    height: 150px;
    border: 2px solid black;
    overflow: auto;
}
```

Resultado:

A caixa mantém:

```text
300px de largura
150px de altura
```

Se houver mais conteúdo do que esses limites comportam, será possível rolar.

------

#### 14. Exemplo muito comum — imagem dentro de uma caixa

HTML:

```html
<div class="imagem">
    <img src="foto.jpg" alt="Foto">
</div>
```

CSS:

```css
.imagem {
    width: 300px;
    height: 200px;
    overflow: hidden;
}

.imagem img {
    width: 400px;
}
```

A imagem é maior que o contêiner:

```text
┌─────────────────────────┐
│                         │
│        IMAGEM           │
│                         │
│                         │
└─────────────────────────┘
```

A parte que ultrapassa os limites é escondida.

Esse conceito é muito utilizado em **cards, galerias, thumbnails e efeitos de zoom**.

------

#### 15. `overflow` e o Box Model

É importante relacionar `overflow` com o **Box Model**.

Uma caixa pode ter:

```text
┌─────────────────────────────┐
│           margin            │
│  ┌───────────────────────┐  │
│  │        border         │  │
│  │  ┌─────────────────┐  │  │
│  │  │     padding     │  │  │
│  │  │  ┌───────────┐  │  │  │
│  │  │  │ conteúdo  │  │  │  │
│  │  │  └───────────┘  │  │  │
│  │  └─────────────────┘  │  │
│  └───────────────────────┘  │
└─────────────────────────────┘
```

Quando o conteúdo ultrapassa o espaço disponível dentro da caixa, temos o **overflow**.

------

#### 16. Uma diferença importante: `hidden` não significa "apagar"

Quando usamos:

```css
overflow: hidden;
```

o conteúdo **não é removido do HTML**.

Ele simplesmente fica **fora da área visível da caixa**.

Por isso, pense:

```text
hidden
   ↓
"Está lá, mas não consigo enxergar."
```

e não:

```text
hidden
   ↓
"Foi apagado."
```

------

#### 17. Propriedades relacionadas

As principais propriedades que você deve conhecer são:

```css
overflow
overflow-x
overflow-y
```

##### `overflow`

Controla X e Y.

```css
overflow: auto;
```

##### `overflow-x`

Controla horizontalmente.

```css
overflow-x: auto;
```

##### `overflow-y`

Controla verticalmente.

```css
overflow-y: auto;
```

------

#### 🧠 Para memorizar

Guarde esta tabela:

| Valor     | Pense em...                  |
| --------- | ---------------------------- |
| `visible` | 👀 **Deixa aparecer**         |
| `hidden`  | 🚫 **Esconde**                |
| `scroll`  | ↕️ **Cria rolagem**           |
| `auto`    | 🤖 **Decide automaticamente** |

E:

```text
overflow
   │
   ├── overflow-x → horizontal
   │
   └── overflow-y → vertical
```

##### A frase principal:

> **`overflow` controla o que acontece quando o conteúdo não cabe dentro da caixa.**

E a sequência para decorar:

```text
visible → mostra
hidden  → esconde
scroll  → rola
auto    → rola se necessário
```

##### 🎯 Regra prática

Se você estiver desenvolvendo e pensar:

> **"Meu conteúdo está escapando da caixa. O que eu faço?"**

Pense imediatamente em:

```css
overflow
```

E, se o problema for especificamente horizontal ou vertical:

```css
overflow-x
overflow-y
```

---

#### Arquivo completo - overflow.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Overflow e dimensões de caixa</title>
    <style>
        .caixa {
            width: 600px;
            height: 300px;
            border: 1px solid red;
            background-color: lightgray;
            padding: 1em;
            /*
            visible: Exibe o conte´do de forma vazada, fora da caixa de conteúdo.
            hidden: Esconde o conteúdo excedente
            scroll: Sempre exibe barras de rolagem
            auto: adiciona scroll somente se necessário
            */
            /* overflow: auto; */
            overflow-x: hidden; /*Horizontal*/
            overflow-y: auto; /*Vertical*/
        }
    </style>
</head>
<body>
    
    <div class="caixa">
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aliquam, unde? Molestias soluta commodi, impedit sed repudiandae recusandae deleniti provident velit quos nihil officia consequatur minus ducimus earum, perferendis suscipit atque.
        </p>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aliquam, unde? Molestias soluta commodi, impedit sed repudiandae recusandae deleniti provident velit quos nihil officia consequatur minus ducimus earum, perferendis suscipit atque.
        </p>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aliquam, unde? Molestias soluta commodi, impedit sed repudiandae recusandae deleniti provident velit quos nihil officia consequatur minus ducimus earum, perferendis suscipit atque.
        </p>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aliquam, unde? Molestias soluta commodi, impedit sed repudiandae recusandae deleniti provident velit quos nihil officia consequatur minus ducimus earum, perferendis suscipit atque.
        </p>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aliquam, unde? Molestias soluta commodi, impedit sed repudiandae recusandae deleniti provident velit quos nihil officia consequatur minus ducimus earum, perferendis suscipit atque.
        </p>
    </div>

</body>
</html>
```



---

---



### 77. Sobrepondo elementos com z-index

#### 📚 `z-index` no CSS

A propriedade `z-index` está relacionada à **profundidade dos elementos**, ou seja, **qual elemento aparece na frente quando dois ou mais elementos se sobrepõem**.

Para entender `z-index`, imagine uma pilha de folhas:

```text
        ┌──────────────┐
        │   elemento C │  ← frente
        └──────────────┘
       ┌──────────────┐
       │  elemento B  │
       └──────────────┘
      ┌──────────────┐
      │ elemento A   │   ← fundo
      └──────────────┘
```

O `z-index` controla essa ordem de sobreposição.

------

#### 1. O que é?

`z-index` é uma propriedade CSS que define a **ordem de empilhamento** de elementos que se sobrepõem.

O nome vem da ideia de um eixo **Z**:

```text
              Z
              ↑
              │
              │
              │
              └────────────→ X
             /
            /
           Y
```

Enquanto:

- `X` → horizontal
- `Y` → vertical
- `Z` → profundidade

Portanto:

> **`z-index` controla quem fica na frente e quem fica atrás.**

------

#### 2. Para que serve?

É utilizado quando elementos precisam se **sobrepor**.

Por exemplo:

- menus sobre conteúdo;
- imagens sobre fundos;
- modal sobre a página;
- botão sobre uma imagem;
- dropdown;
- tooltip;
- notificações;
- cabeçalho sobre outros elementos;
- elementos decorativos.

Imagine:

```text
┌─────────────────────────────┐
│                             │
│        IMAGEM               │
│                             │
│       ┌───────────┐         │
│       │   BOTÃO   │         │
│       └───────────┘         │
│                             │
└─────────────────────────────┘
```

O botão está **sobre** a imagem.

O `z-index` pode determinar qual deles ficará na frente.

------

#### 3. Como funciona?

O navegador precisa decidir:

> "Quando dois elementos ocupam o mesmo espaço, qual deles aparece por cima?"

O `z-index` ajuda a responder essa pergunta.

Por exemplo:

```css
.caixa1 {
    z-index: 1;
}

.caixa2 {
    z-index: 2;
}
```

Se elas estiverem sobrepostas e estiverem no mesmo contexto de empilhamento, a:

```text
z-index: 2
```

ficará na frente da:

```text
z-index: 1
```

Visualmente:

```text
        ┌───────────────┐
        │   CAIXA 2     │  ← z-index: 2
        │               │
        └───────────────┘
      ┌───────────────────┐
      │     CAIXA 1       │  ← z-index: 1
      └───────────────────┘
```

##### Regra básica:

> **Quanto maior o `z-index`, maior a prioridade de empilhamento.**

------

#### 4. Sintaxe

A sintaxe é:

```css
.seletor {
    z-index: valor;
}
```

Exemplo:

```css
.caixa {
    z-index: 10;
}
```

------

#### 5. Principais valores

Os valores mais importantes são:

```css
z-index: auto;
z-index: 0;
z-index: 1;
z-index: 10;
z-index: 100;
z-index: -1;
```

Também podemos usar outros números.

------

##### `z-index: auto`

É o valor padrão.

```css
.elemento {
    z-index: auto;
}
```

Significa, de maneira simplificada:

> "Use a ordem de empilhamento determinada normalmente pelo navegador."

##### Para memorizar:

> **`auto` = automático.**

------

#### 6. Valores positivos

Podemos utilizar números positivos:

```css
z-index: 1;
z-index: 2;
z-index: 10;
z-index: 100;
```

Por exemplo:

```css
.caixa1 {
    z-index: 1;
}

.caixa2 {
    z-index: 10;
}
```

A `caixa2` terá maior prioridade de empilhamento.

```text
CAIXA 2
z-index: 10
   ↓
┌───────────────┐
│               │
└───────────────┘
      ↑
      │
┌───────────────┐
│    CAIXA 1    │
└───────────────┘
z-index: 1
```

##### Para memorizar:

> **Número maior → fica na frente.**

------

#### 7. Valores negativos

Também podemos usar números negativos:

```css
z-index: -1;
```

Por exemplo:

```css
.fundo {
    z-index: -1;
}
```

Isso pode colocar o elemento atrás de outros elementos dentro do contexto de empilhamento apropriado.

É bastante utilizado em determinados efeitos de fundo:

```css
.pagina {
    position: relative;
}

.fundo {
    position: absolute;
    z-index: -1;
}
```

⚠️ Porém, valores negativos exigem cuidado porque o elemento pode acabar **atrás do próprio contêiner ou fora da área visual esperada**, dependendo dos contextos de empilhamento.

##### Para memorizar:

> **`z-index` negativo → tende a mandar para trás.**

------

#### 8. `z-index` não é uma propriedade de posicionamento

Esse é um ponto muito importante.

`z-index` **não posiciona o elemento**.

Ele controla apenas a **ordem de empilhamento**.

Por exemplo:

```css
.caixa {
    z-index: 10;
}
```

Isso não significa:

> "Coloque a caixa em determinada posição."

Significa:

> "Se houver sobreposição, essa caixa pode ficar acima de elementos com menor nível de empilhamento."

Para realmente sobrepor elementos, frequentemente utilizamos:

```css
position: relative;
position: absolute;
position: fixed;
```

junto com:

```css
z-index;
```

------

#### 9. Exemplo clássico com `position`

HTML:

```html
<div class="caixa caixa1"></div>
<div class="caixa caixa2"></div>
```

CSS:

```css
.caixa {
    width: 150px;
    height: 150px;
}

.caixa1 {
    position: absolute;
    top: 50px;
    left: 50px;
    z-index: 1;
}

.caixa2 {
    position: absolute;
    top: 100px;
    left: 100px;
    z-index: 2;
}
```

As caixas vão se sobrepor:

```text
┌──────────────┐
│ Caixa 1      │
│              │
│      ┌──────────────┐
│      │ Caixa 2      │
│      │              │
└──────┤              │
       └──────────────┘
```

A `caixa2` ficará por cima porque:

```css
z-index: 2;
```

é maior que:

```css
z-index: 1;
```

------

#### 10. Exemplo: botão sobre imagem

HTML:

```html
<div class="card">
    <img src="foto.jpg" alt="Foto">
    <button>Comprar</button>
</div>
```

CSS:

```css
.card {
    position: relative;
}

.card img {
    position: relative;
    z-index: 1;
}

.card button {
    position: absolute;
    bottom: 20px;
    left: 20px;
    z-index: 2;
}
```

Aqui temos:

```text
z-index: 2
      ↓
   BOTÃO
─────────────
   IMAGEM
─────────────
z-index: 1
```

O botão fica acima da imagem.

------

#### 11. Exemplo: modal sobre a página

Esse é um exemplo muito importante na prática.

Imagine:

```text
Página normal
──────────────────────────

         ┌──────────────┐
         │    MODAL     │
         │              │
         │    Fechar    │
         └──────────────┘

──────────────────────────
```

CSS:

```css
.modal {
    position: fixed;
    inset: 0;
    z-index: 1000;
}
```

Enquanto outros elementos podem ter:

```css
header {
    position: fixed;
    z-index: 10;
}
```

Nesse caso:

```text
modal → 1000
header → 10
```

O modal terá prioridade de empilhamento.

------

#### 12. Um detalhe importante: `z-index` não significa simplesmente "qualquer número maior fica na frente"

Aqui está uma das partes mais importantes para você aprender corretamente.

O `z-index` trabalha dentro de **contextos de empilhamento (stacking contexts)**.

Imagine:

```text
Página
│
├── Contêiner A
│   ├── Filho A1
│   └── Filho A2
│
└── Contêiner B
    └── Filho B1
```

Se A e B criarem diferentes contextos de empilhamento, um:

```css
z-index: 999999;
```

dentro de A **não necessariamente ficará acima** de um elemento de B com:

```css
z-index: 2;
```

Porque o `z-index` não é uma escala global simples para toda a página.

Ele funciona dentro dos respectivos **contextos de empilhamento**.

------

#### 13. O que é `stacking context`?

Podemos pensar nele como uma **mini-pilha independente**.

Imagine:

```text
Página
│
├── 📦 Contexto A
│   ├── elemento 1
│   ├── elemento 2
│   └── elemento 3
│
└── 📦 Contexto B
    ├── elemento 1
    └── elemento 2
```

Os elementos dentro de A são organizados entre si.

Os elementos dentro de B são organizados entre si.

Depois o navegador decide como **A e B** serão empilhados.

------

#### 14. `position` + `z-index`

Uma associação muito importante para quem está começando:

```css
.elemento {
    position: absolute;
    z-index: 10;
}
```

ou:

```css
.elemento {
    position: relative;
    z-index: 10;
}
```

ou:

```css
.elemento {
    position: fixed;
    z-index: 10;
}
```

O `position` permite participar de determinados comportamentos de posicionamento e empilhamento, enquanto o `z-index` controla a ordem de sobreposição.

⚠️ Mas não pense que `z-index` só funciona com `position`: elementos flex/grid e certos elementos que criam contextos de empilhamento também podem participar do comportamento de `z-index`.

------

#### 15. Exemplo visual para memorizar

Imagine três cartões:

```text
┌─────────────────┐
│                 │
│     CAIXA A     │
│    z-index: 1   │
│                 │
└─────────────────┘

       ┌─────────────────┐
       │                 │
       │     CAIXA B     │
       │    z-index: 5   │
       │                 │
       └─────────────────┘

              ┌─────────────────┐
              │                 │
              │     CAIXA C     │
              │   z-index: 10   │
              │                 │
              └─────────────────┘
```

Em uma situação de sobreposição no mesmo contexto:

```text
z-index: 10  → 🥇 frente
z-index: 5   → 🥈 meio
z-index: 1   → 🥉 trás
```

------

#### 16. Propriedades, atributos e valores

Aqui há uma distinção importante:

`z-index` é uma **propriedade CSS**.

Não é um atributo HTML.

##### Propriedade:

```css
z-index
```

##### Valores comuns:

```css
auto
0
1
2
10
100
1000
-1
```

Os números não possuem unidade:

❌ Errado:

```css
z-index: 10px;
```

✅ Correto:

```css
z-index: 10;
```

##### Por quê?

Porque `z-index` não representa uma distância.

Ele representa uma **ordem de empilhamento**.

------

#### 17. Não existe `z-index: 100px`

Isso é importante:

```css
z-index: 100px; /* ❌ */
```

Não usamos:

```text
px
em
rem
%
vw
vh
```

Usamos um número inteiro ou `auto`.

```css
z-index: 100; /* ✅ */
```

------

#### 18. `z-index` e `top/right/bottom/left` são coisas diferentes

É fácil confundir.

##### Deslocamento:

```css
top: 20px;
left: 30px;
```

Define **onde** o elemento fica.

##### Empilhamento:

```css
z-index: 10;
```

Define **quem fica na frente**.

Portanto:

```text
top / right / bottom / left
              ↓
        POSIÇÃO

z-index
    ↓
PROFUNDIDADE
```

------

#### 🧠 Para memorizar

Guarde esta frase:

> **`z-index` controla a ordem de empilhamento dos elementos.**

E imagine uma pilha:

```text
       Z
       ↑
       │
   10  │ 🥇
    5  │ 🥈
    1  │ 🥉
    0  │
   -1  │
       └────────
```

##### Regra rápida:

```text
z-index maior → frente
z-index menor → trás
```

Mas acrescente uma segunda regra:

> **Isso é comparado dentro do contexto de empilhamento apropriado.**

------

#### 🎯 Resumo final

| Conceito   | Função                                   |
| ---------- | ---------------------------------------- |
| `position` | Define o tipo de posicionamento          |
| `top`      | Deslocamento pelo topo                   |
| `right`    | Deslocamento pela direita                |
| `bottom`   | Deslocamento pela parte inferior         |
| `left`     | Deslocamento pela esquerda               |
| `z-index`  | Define a ordem de empilhamento           |
| `overflow` | Controla conteúdo que ultrapassa a caixa |

Um exemplo que reúne vários conceitos:

```css
.card {
    position: relative;
    overflow: hidden;
}

.card .etiqueta {
    position: absolute;
    top: 10px;
    right: 10px;
    z-index: 2;
}
```

Leia o código assim:

> **`.card` é uma referência (`relative`) e esconde o que ultrapassar seus limites (`overflow: hidden`). A `.etiqueta` é retirada do fluxo (`absolute`), posicionada no canto superior direito (`top` + `right`) e colocada em uma camada superior (`z-index: 2`).**

##### 🧠 Fórmula para decorar:

> **`position` → como posicionar**
> **`top/right/bottom/left` → onde colocar**
> **`z-index` → quem fica por cima**
> **`overflow` → o que fazer com o que ultrapassar**

---

#### Arquivo completo - sobreposicao.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sobreposição de elementos</title>
    <style>
        .caixa1 {
            border: 1px solid blue;
            background-color: lightblue;
            width: 100px;
            height: 100px;
            /* position: absolute; */
            top: 100px;
            left: 100px;
            z-index: 1;
        }
        .caixa2 {
            border: 1px solid red;
            background-color: lightcoral;
            width: 100px;
            height: 100px;
            /* position: absolute; */
            top: 80px;
            left: 80px;
            z-index: 0;
        }

        .caixa3 {
            border: 1px solid green;
            background-color: lightgreen;
            width: 100px;
            height: 100px;
            /* position: absolute; */
            top: 160px;
            left: 160px;
            z-index: 3;
        }

        #exercicio-sobreposicao {
            /* border: 1px solid red; */
            /* padding: 1em; */
        }

        .caixa {
            background-color: purple;
            position: relative;
            width: 700px;
        }

        .caixa img {
            width: 700px;
        }

        .destaque {
            background-color: orange;
            color: white;
            padding: 10px 16px;
            border-radius: 30px;
            position: absolute;
            bottom: 2.5em;
            left: 2em;
        }

        .promocao {
            background-color: white;
            border: 2px dotted purple;
            color: purple;
            position: absolute;
            bottom: -1.8em;
            padding: 1em;
            left: 10%;
            right: 10%;
            text-align: center;
            border-radius: 0 0 20px 20px;
        }

    </style>
</head>
<body>
    
    <div class="caixa1">
        Caixa 1
    </div>

    <div class="caixa2">
        Caixa 2
    </div>

    <div class="caixa3">
        Caixa 3
    </div>

    <hr>

    <div id="exercicio-sobreposicao">
        <h1>Exercício</h1>
        <div class="caixa">
            <img src="./img/banner.png" alt="">

            <div class="destaque">
                Tempo limitado
            </div>

            <div class="promocao">
                Quero a promoção
            </div>
        </div>
    </div>

</body>
</html>
```



---

---



### 78. Elementos Flutuantes (Teoria)    :pushpin::round_pushpin:

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