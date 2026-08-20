# Desenvolvimento Web Completo

## Professor Hamilton Damasceno

## Seção 8: Propriedades CSS

### 43. Div e Span (Teoria)

#### Elementos de bloco e elementos em linha

No HTML, os elementos podem se comportar de maneiras diferentes em relação ao espaço que ocupam na página. Os dois comportamentos principais são:

- **Elementos de bloco (`block`)**
- **Elementos em linha (`inline`)**

------

##### Elementos de bloco

Os **elementos de bloco** ocupam, por padrão, **toda a largura disponível** do elemento pai e começam uma nova linha.

Isso significa que, quando colocamos dois elementos de bloco consecutivamente, normalmente um ficará abaixo do outro.

Exemplos de elementos que possuem comportamento de bloco:

- `<div>`
- `<p>`
- `<h1>` até `<h6>`
- `<ul>`
- `<ol>`
- `<li>`

###### Exemplo

```html
<div>Primeiro bloco</div>
<div>Segundo bloco</div>
```

Visualmente, o resultado será semelhante a:

```text
Primeiro bloco
Segundo bloco
```

Cada `<div>` ocupa sua própria linha.

------

#### Elementos em linha

Os **elementos em linha** ocupam somente o espaço necessário para o seu conteúdo e **não iniciam uma nova linha**.

Quando existem vários elementos *inline* consecutivos, eles podem permanecer na mesma linha, desde que exista espaço disponível.

Exemplos:

- `<span>`
- `<a>`
- `<strong>`
- `<em>`

###### Exemplo

```html
<span>Primeiro</span>
<span>Segundo</span>
<span>Terceiro</span>
```

O resultado será semelhante a:

```text
Primeiro Segundo Terceiro
```

Os elementos permanecem na mesma linha.

------

#### Tag `<div>`

A tag `<div>` é um elemento **genérico de bloco**.

Ela é utilizada principalmente para **agrupar outros elementos** e criar uma estrutura ou seção dentro da página.

Por si só, a `<div>` não possui um significado semântico específico. Sua principal função é servir como um **contêiner**.

###### Para que serve?

A `<div>` pode ser utilizada para:

- Agrupar elementos;
- Organizar a estrutura da página;
- Criar áreas ou seções;
- Aplicar CSS a um conjunto de elementos;
- Facilitar a manipulação de elementos com JavaScript.

###### Exemplo

```html
<div>
    <h2>Produtos</h2>
    <p>Confira nossos produtos.</p>
</div>
```

Nesse exemplo, a `<div>` agrupa o título e o parágrafo.

------

#### Tag `<span>`

A tag `<span>` é um elemento **genérico em linha (inline)**.

Assim como a `<div>`, ela não possui um significado semântico específico. Sua principal finalidade é **agrupar ou identificar uma parte específica de um conteúdo**, normalmente para aplicar CSS ou JavaScript.

###### Para que serve?

A `<span>` pode ser utilizada para:

- Destacar uma parte de um texto;
- Aplicar CSS a uma palavra ou trecho;
- Identificar uma parte específica do conteúdo;
- Facilitar a manipulação com JavaScript.

###### Exemplo

```html
<p>
    Este produto está com
    <span>50% de desconto</span>.
</p>
```

Nesse caso, o `<span>` permite aplicar uma formatação específica somente ao trecho **"50% de desconto"**.

------

#### Diferença entre `<div>` e `<span>`

A principal diferença está no comportamento padrão:

| Elemento | Tipo   | Comportamento            |
| -------- | ------ | ------------------------ |
| `<div>`  | Bloco  | Ocupa uma nova linha     |
| `<span>` | Inline | Permanece na mesma linha |

###### Exemplo comparativo

```html
<div>Conteúdo 1</div>
<div>Conteúdo 2</div>

<span>Conteúdo 3</span>
<span>Conteúdo 4</span>
```

Resultado aproximado:

```text
Conteúdo 1
Conteúdo 2
Conteúdo 3 Conteúdo 4
```

As `<div>` ficam em linhas separadas, enquanto os `<span>` permanecem na mesma linha.

------

#### Resumo

##### Elementos de bloco

> Normalmente começam em uma nova linha e ocupam toda a largura disponível.

**Exemplo:** `<div>`, `<p>`, `<h1>`, `<ul>`.

##### Elementos em linha

> Normalmente ocupam apenas o espaço necessário para seu conteúdo e permanecem na mesma linha.

**Exemplo:** `<span>`, `<a>`, `<strong>`.

##### `<div>`

> Elemento genérico de **bloco**, utilizado principalmente para **agrupar e organizar elementos**.

##### `<span>`

> Elemento genérico **em linha**, utilizado principalmente para **agrupar ou destacar pequenos trechos de conteúdo**.



-----

-----



### 44. Div e Span (Prática) - Parte 1

#### Arquivo completo - div-span.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Div e Span</title>
</head>
<body>
    <div style=" border-bottom: 3px solid black;">
        <img src="./img/logo-f1.png" alt="logo fórmula 1" width="100">
        <a href="">Recente</a>
        <a href="">Vídeo</a>
        <a href="">Agenda de Corridas</a>
        <a href="">Pilotos</a>
        <span style="background-color: black; color: white;"> Grupo Liberty Media </span>
    </div>
    
    <div style="background-color: lightgray;">
        <h1>Grandes pilotos da fórmula 1</h1>
        <p>
            Alguns dos <span style="color: purple;"> melhor pilotos </span> da fórmula 1, são vistos juntos na foto abaixo
        </p>
        <img src="./img/pilotos.jpeg" alt="pilotos">
    </div>

    <div style="background-color: black; color: white;">
        Site oficial fórmula 1
    </div>
    
</body>
</html>
```



-----

-----

### 

### 45. Div e Span (Prática) - Parte 2

#### Arquivo completo - magalu.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Magalu exercício</title>
    <style>

        a {
            color: white;
        }

    </style>
</head>
<body>

    <div style="background-color: dodgerblue;">
        <img src="./img/logo-magalu.png" alt="logo magalu" width="200">

        <a href="">Ofertas do dia</a>
        <a href="">Celulares</a>
        <a href="">Eletrodomésticos</a>
        <a href="">Tv e Video</a>
        <a href="">Informática</a>

        <span style="background-color: white; color: dodgerblue;"> 
            compre pelo tel.: 0800 70 70 70
        </span>
    </div>

    <div style="background-color: purple;">
        <img src="./img/banner.png" alt="banner oferta">
    </div>

    <div>
        <h1>Novidades que selecionamos</h1>
        <img src="./img/produto1.jpg" alt="produto1">
        <img src="./img/produto2.jpg" alt="produto2">
        <img src="./img/produto3.jpg" alt="produto3">
        <img src="./img/produto4.jpg" alt="produto4">
        <img src="./img/produto5.jpg" alt="produto5">
    </div>

    <div>
        <h3 style="background-color: dodgerblue; color: white;">
            <span style="color: darkslateblue;" >Magazine Luiza </span>todos os direitos reservados
        </h3>
    </div>
</body>
</html>
```



-----

-----



### 46. Fontes e Cores (Teoria)

#### Entendendo as cores

As cores utilizadas em computadores e telas são normalmente formadas pela combinação de três cores básicas de luz:

- **Vermelho (Red)**
- **Verde (Green)**
- **Azul (Blue)**

Esse sistema é chamado de **RGB**.

A combinação dessas três cores em diferentes intensidades permite representar milhões de cores diferentes.

##### Vermelho

O **vermelho (Red)** é uma das três cores que formam o sistema RGB.

Quando o vermelho está em sua intensidade máxima e as outras duas cores estão desligadas, temos o vermelho puro.

```css
color: rgb(255, 0, 0);
```

##### Verde

O **verde (Green)** é a segunda cor do sistema RGB.

```css
color: rgb(0, 255, 0);
```

##### Azul

O **azul (Blue)** é a terceira cor do sistema RGB.

```css
color: rgb(0, 0, 255);
```

------

#### Maneiras de representar cores

No CSS, existem diferentes maneiras de definir uma cor. As principais são:

- Nomes de cores;
- Valores RGB;
- Códigos hexadecimais;
- Valores HSL.

------

##### 1. Nomes das cores

O CSS possui diversos **nomes de cores predefinidos** que podem ser utilizados diretamente.

###### Para que servem?

Facilitam a definição de cores quando não precisamos de uma tonalidade muito específica.

###### Exemplos

```css
color: red;
color: blue;
color: green;
color: yellow;
color: white;
color: black;
```

Por exemplo:

```css
p {
    color: blue;
}
```

O texto do parágrafo será exibido em azul.

------

##### 2. Valores RGB

**RGB** significa:

- **R** → Red (vermelho)
- **G** → Green (verde)
- **B** → Blue (azul)

Cada componente normalmente recebe um valor entre **0 e 255**.

```css
rgb(vermelho, verde, azul)
```

###### Exemplos

Vermelho puro:

```css
color: rgb(255, 0, 0);
```

Verde puro:

```css
color: rgb(0, 255, 0);
```

Azul puro:

```css
color: rgb(0, 0, 255);
```

Branco:

```css
color: rgb(255, 255, 255);
```

Preto:

```css
color: rgb(0, 0, 0);
```

Também podemos combinar as três cores para criar outras tonalidades:

```css
color: rgb(255, 165, 0);
```

Nesse exemplo, a combinação produz uma tonalidade de laranja.

------

##### 3. Códigos hexadecimais

A representação **hexadecimal** utiliza seis caracteres precedidos pelo símbolo `#`.

```text
#RRGGBB
```

Os dois primeiros caracteres representam o **vermelho**, os dois seguintes o **verde** e os dois últimos o **azul**.

Os valores hexadecimais vão de:

```text
00 até FF
```

###### Exemplos

Vermelho:

```css
color: #FF0000;
```

Verde:

```css
color: #00FF00;
```

Azul:

```css
color: #0000FF;
```

Preto:

```css
color: #000000;
```

Branco:

```css
color: #FFFFFF;
```

Assim como no RGB, podemos combinar diferentes intensidades de vermelho, verde e azul.

Por exemplo:

```css
color: #FFA500;
```

representa uma tonalidade de laranja.

------

##### 4. Cores HSL

**HSL** significa:

- **H** → Hue (matiz)
- **S** → Saturation (saturação)
- **L** → Lightness (luminosidade)

A estrutura é:

```css
hsl(matiz, saturação, luminosidade)
```

###### Matiz — Hue

Representa a **cor propriamente dita**.

É medida em graus, normalmente de `0` a `360`.

Exemplos aproximados:

- `0°` → vermelho
- `120°` → verde
- `240°` → azul

###### Saturação — Saturation

Define a **intensidade da cor**.

É representada em porcentagem:

- `0%` → sem saturação, resultando em uma tonalidade de cinza;
- `100%` → saturação máxima.

###### Luminosidade — Lightness

Define o quanto a cor é **clara ou escura**.

Também é representada em porcentagem:

- `0%` → preto;
- `50%` → cor normal;
- `100%` → branco.

###### Exemplos

Vermelho:

```css
color: hsl(0, 100%, 50%);
```

Verde:

```css
color: hsl(120, 100%, 50%);
```

Azul:

```css
color: hsl(240, 100%, 50%);
```

------

#### Resumo das formas de representar cores

| Forma       | Exemplo             | Descrição                                      |
| ----------- | ------------------- | ---------------------------------------------- |
| Nome        | `red`               | Utiliza o nome predefinido da cor              |
| RGB         | `rgb(255, 0, 0)`    | Combina vermelho, verde e azul                 |
| Hexadecimal | `#FF0000`           | Representa RGB utilizando valores hexadecimais |
| HSL         | `hsl(0, 100%, 50%)` | Utiliza matiz, saturação e luminosidade        |

------

#### Fontes no CSS

As fontes determinam **a aparência dos textos** apresentados em uma página.

O CSS permite definir qual fonte será utilizada, seu tamanho, estilo, espessura e outras características.

Uma das principais propriedades utilizadas é:

```css
font-family
```

Ela define a **família de fontes** utilizada pelo texto.

------

#### Famílias de fontes

As famílias de fontes podem ser agrupadas em diferentes categorias. Entre as principais estão:

- **Serif**
- **Sans-serif**
- **Monospace**
- **Cursive**
- **Fantasy**

------

##### 1. Serif

As fontes **serif** possuem pequenos detalhes ou prolongamentos nas extremidades das letras, chamados de **serifas**.

São frequentemente utilizadas em textos mais tradicionais e impressos.

###### Para que servem?

Podem ser utilizadas em:

- Livros;
- Jornais;
- Documentos;
- Textos que buscam uma aparência mais tradicional.

###### Exemplos

```css
font-family: Georgia;
font-family: "Times New Roman";
```

Exemplo de família genérica:

```css
font-family: serif;
```

------

##### 2. Sans-serif

**Sans-serif** significa, literalmente, **"sem serifas"**.

As letras não possuem os pequenos prolongamentos encontrados nas fontes serif.

São muito utilizadas em sites e interfaces digitais.

###### Para que servem?

São bastante utilizadas em:

- Sites;
- Aplicativos;
- Interfaces;
- Menus;
- Textos digitais.

###### Exemplos

```css
font-family: Arial;
font-family: Verdana;
```

Família genérica:

```css
font-family: sans-serif;
```

------

##### 3. Monospace

Nas fontes **monospace**, cada caractere ocupa a **mesma largura horizontal**.

Por exemplo, o espaço ocupado por `i` e `M` é igual.

###### Para que servem?

São muito utilizadas em:

- Código de programação;
- Terminais;
- Editores de código;
- Exemplos de código.

###### Exemplos

```css
font-family: "Courier New";
```

Família genérica:

```css
font-family: monospace;
```

------

##### 4. Cursive

As fontes **cursive** procuram imitar a aparência de uma **escrita manual ou caligráfica**.

###### Para que servem?

Podem ser utilizadas para criar uma aparência:

- Informal;
- Artística;
- Decorativa;
- Semelhante à escrita à mão.

###### Exemplo

```css
font-family: cursive;
```

O resultado depende da fonte cursiva disponível no sistema ou navegador.

------

##### 5. Fantasy

As fontes **fantasy** possuem características mais **decorativas e estilizadas**.

Elas não são normalmente escolhidas para grandes blocos de texto, mas podem ser utilizadas para criar um visual específico.

###### Para que servem?

Podem ser utilizadas em:

- Títulos;
- Logotipos;
- Elementos decorativos;
- Projetos com estilo temático.

###### Exemplo

```css
font-family: fantasy;
```

Assim como `cursive`, o resultado pode variar de acordo com as fontes disponíveis no sistema.

------

#### Resumo das famílias de fontes

| Família        | Característica                              | Exemplo       |
| -------------- | ------------------------------------------- | ------------- |
| **Serif**      | Possui serifas nas extremidades das letras  | `Georgia`     |
| **Sans-serif** | Não possui serifas                          | `Arial`       |
| **Monospace**  | Todos os caracteres possuem a mesma largura | `Courier New` |
| **Cursive**    | Imita escrita manual                        | `cursive`     |
| **Fantasy**    | Possui aparência decorativa e estilizada    | `fantasy`     |

> **Resumo:** as cores definem a aparência cromática dos elementos, enquanto as fontes definem a aparência dos textos. No CSS, podemos combinar diferentes formas de representação de cores e famílias de fontes para controlar a aparência visual de uma página.



-----

-----



### 47. Fontes e Cores (Prática)

#### Arquivo completo - fontes-cores.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Fontes e cores</title>
    <style>

        body {
            background-color: #2A4D14;
        }

        h1 {
            background: #317B22;
            color: white;
            padding: 8px;

            font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
        }

    </style>
</head>
<body>
    
    <h1>Fontes e cores</h1>

    <div style="font-family: Georgia, 'Times New Roman', Times, serif; color: whitesmoke;">
        <h2>Serif</h2>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos porro quidem magnam aliquid natus iusto, excepturi aliquam, labore laboriosam quibusdam numquam? Consectetur non, laborum nulla error delectus voluptates tempora exercitationem?
        </p>
    </div>

    <div style="font-family: Arial, Helvetica, sans-serif; color: rgba(245, 245, 245, 0.662);">
        <h2>Sans-serif</h2>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos porro quidem magnam aliquid natus iusto, excepturi aliquam, labore laboriosam quibusdam numquam? Consectetur non, laborum nulla error delectus voluptates tempora exercitationem?
        </p>
    </div>

    <div style="font-family: 'Courier New', Courier, monospace; color: #7CF0BD;">
        <h2>Monospace</h2>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos porro quidem magnam aliquid natus iusto, excepturi aliquam, labore laboriosam quibusdam numquam? Consectetur non, laborum nulla error delectus voluptates tempora exercitationem?
        </p>
    </div>

    <div style="font-family: cursive; color: hsl(141, 86%, 83%);">
        <h2>Cursive</h2>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos porro quidem magnam aliquid natus iusto, excepturi aliquam, labore laboriosam quibusdam numquam? Consectetur non, laborum nulla error delectus voluptates tempora exercitationem?
        </p>
    </div>

    <div style="font-family: fantasy; color: #67E0A3;">
        <h2>Fantasy</h2>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos porro quidem magnam aliquid natus iusto, excepturi aliquam, labore laboriosam quibusdam numquam? Consectetur non, laborum nulla error delectus voluptates tempora exercitationem?
        </p>
    </div>

</body>
</html>
```

-----

#### links da aula

[Mozilla](https://developer.mozilla.org/pt-BR/docs/Web/CSS/Guides/Colors/Color_format_converter) - Seletor de cores

[html-color-codes](https://html-color-codes.info/Codigos-de-Cores-HTML/) - Código de cores

[W3School](https://www.w3schools.com/css/css_font.asp) CSS fontes

[W3School](https://www.w3schools.com/cssref/css_websafe_fonts.php) CSS Web Safe Fonts

[Coolors](https://coolors.co/) - Seletor de cores

[Color Hunt ](https://colorhunt.co/) - Seletor de cores



-----

-----



### 48. Modelo de caixa — Box Model

No CSS, podemos imaginar que **cada elemento HTML está dentro de uma caixa**.

Essa ideia é chamada de **Box Model (Modelo de Caixa)**.

Por exemplo, no código apresentado, tanto o `<h1>` quanto o `<p>` podem ser entendidos como caixas que possuem:

1. **Conteúdo (`content`)**
2. **Espaçamento interno (`padding`)**
3. **Borda (`border`)**
4. **Espaçamento externo (`margin`)**

A estrutura pode ser visualizada assim:

```text
┌──────────────────────────────────────┐
│              MARGIN                  │
│   ┌──────────────────────────────┐   │
│   │            BORDER            │   │
│   │   ┌──────────────────────┐   │   │
│   │   │       PADDING        │   │   │
│   │   │   ┌──────────────┐   │   │   │
│   │   │   │   CONTENT    │   │   │   │
│   │   │   └──────────────┘   │   │   │
│   │   └──────────────────────┘   │   │
│   └──────────────────────────────┘   │
└──────────────────────────────────────┘
```

A ordem, de dentro para fora, é:

> **Content → Padding → Border → Margin**

------

#### 1. Content — Conteúdo

O **content (conteúdo)** é a parte central da caixa.

É onde fica o conteúdo propriamente dito do elemento, como:

- Texto;
- Imagens;
- Outros elementos HTML.

No exemplo:

```html
<h1>Modelo de Caixa</h1>
```

O texto **"Modelo de Caixa"** é o conteúdo do elemento `<h1>`.

Da mesma forma, o texto dentro do `<p>` representa o conteúdo do parágrafo.

------

#### 2. `padding` — Espaçamento interno

O **padding** é o espaço entre o **conteúdo e a borda** do elemento.

Podemos imaginar o padding como um espaço interno que impede que o conteúdo fique encostado na borda.

No código:

```css
padding: 20px;
```

Isso adiciona **20 pixels de espaço interno** em todos os lados do elemento.

### Exemplo

```css
h1 {
    padding: 20px;
}
```

O texto do `<h1>` ficará afastado 20px da borda da caixa.

### Para que serve?

O `padding` é utilizado principalmente para:

- Criar espaço ao redor do conteúdo;
- Melhorar a leitura;
- Evitar que o conteúdo fique encostado na borda;
- Criar áreas internas maiores em botões, caixas e outros elementos.

> **Importante:** `padding` é **espaçamento interno**.

------

#### 3. `border` — Borda

O **border** é a borda que fica ao redor do conteúdo e do padding.

No código apresentado:

```css
border: 3px solid darkorange;
```

Temos três informações:

```text
3px       → espessura
solid     → estilo
darkorange → cor
```

Portanto:

```css
border: 3px solid darkorange;
```

significa:

> Criar uma borda de **3 pixels**, com estilo **sólido**, na cor **darkorange**.

------

#### Estrutura do `border`

A propriedade `border` pode ser entendida como:

```css
border: espessura estilo cor;
```

##### Espessura

Define a largura da borda.

Exemplo:

```css
border: 1px;
```

ou:

```css
border: 5px;
```

##### Estilo

Define o tipo de borda.

Alguns exemplos:

```text
solid
dashed
dotted
double
```

##### Cor

Define a cor da borda.

Exemplo:

```css
border: 3px solid blue;
```

------

#### 4. `margin` — Espaçamento externo

O **margin** é o espaço **externo à caixa**.

Ele cria distância entre um elemento e outros elementos ao seu redor.

No código:

```css
margin: 20px;
```

é criado um espaço externo de **20 pixels** em todos os lados do elemento.

##### Para que serve?

O `margin` é utilizado para:

- Separar elementos;
- Criar espaço entre caixas;
- Controlar a distância entre elementos da página;
- Organizar o layout.

> **Importante:** `margin` é **espaçamento externo**, enquanto `padding` é **espaçamento interno**.

------

#### Padding × Margin

Essa é uma das diferenças mais importantes do Box Model.

##### `padding`

Cria espaço **dentro da caixa**.

```text
┌───────────────────────────┐
│        PADDING             │
│    ┌───────────────┐       │
│    │   conteúdo    │       │
│    └───────────────┘       │
└───────────────────────────┘
```

##### `margin`

Cria espaço **fora da caixa**.

```text
      MARGIN
   ↓         ↓
   ┌───────────────┐
   │    caixa      │
   └───────────────┘
      ↑         ↑
      MARGIN
```

Podemos memorizar:

> **Padding = espaço interno**

> **Margin = espaço externo**

------

#### Analisando o código

No `<h1>` temos:

```css
h1 {
    background-color: orange;
    color: white;
    padding: 20px;
    margin: 20px;
    border: 3px solid darkorange;
}
```

Cada propriedade possui uma função diferente:

| Propriedade        | Função                |
| ------------------ | --------------------- |
| `background-color` | Define a cor de fundo |
| `color`            | Define a cor do texto |
| `padding`          | Cria espaço interno   |
| `margin`           | Cria espaço externo   |
| `border`           | Cria a borda da caixa |

Portanto, o `<h1>` possui uma caixa com:

- Fundo laranja;
- Texto branco;
- 20px de espaçamento interno;
- Borda de 3px;
- 20px de espaçamento externo.

------

#### Box Model aplicado ao `<p>`

No parágrafo temos:

```css
p {
    background-color: lightgrey;
    border: 3px solid gray;
    padding: 20px;
    margin: 20px;
}
```

Nesse caso:

- `background-color: lightgrey` → define o fundo cinza-claro;
- `border: 3px solid gray` → cria uma borda cinza de 3px;
- `padding: 20px` → cria 20px de espaço interno;
- `margin: 20px` → cria 20px de espaço externo.

O texto do parágrafo ficará afastado da borda por causa do **padding** e o parágrafo ficará afastado de outros elementos por causa do **margin**.

------

#### Resumo do Box Model

O modelo de caixa pode ser resumido da seguinte maneira:

```text
MARGIN
  ↓
BORDER
  ↓
PADDING
  ↓
CONTENT
```

Ou, pensando **do centro para fora**:

```text
CONTENT → PADDING → BORDER → MARGIN
```

| Parte       | O que é?            | Função                                     |
| ----------- | ------------------- | ------------------------------------------ |
| **Content** | Conteúdo            | Onde está o conteúdo do elemento           |
| **Padding** | Espaçamento interno | Distância entre o conteúdo e a borda       |
| **Border**  | Borda               | Limite visual da caixa                     |
| **Margin**  | Espaçamento externo | Distância entre a caixa e outros elementos |

> **Regra fundamental:** quando estiver trabalhando com Box Model, pense que **todo elemento HTML é uma caixa** e que essa caixa possui **conteúdo, espaço interno, borda e espaço externo**.

---



#### Arquivo completo - modelo-caixa.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>modelo de caixa</title>
    <style>
        h1 {
            background-color: orange;
            color: white;
            padding: 20px;
            margin: 20px;
            border: 3px solid darkorange;
        }
        p {
            background-color: lightgrey;
            border: 3px solid gray;
            padding: 20px;
            margin: 20px;
        }
    </style>
</head>
<body>
    <h1>Modelo de Caixa</h1>
    <p>
        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iste quisquam aliquam deserunt quo, at libero. Cupiditate maxime, perspiciatis ducimus corporis cumque quo, culpa provident amet alias enim accusantium iure praesentium.
    </p>
</body>
</html>
```




-----

-----



### 49. Bordas

No **Box Model**, a borda (`border`) é a região que fica entre o **padding** e o **margin** de um elemento.

Ela pode ser utilizada para:

- Criar limites visuais ao redor de elementos;
- Destacar títulos, parágrafos e seções;
- Criar diferentes efeitos visuais;
- Criar caixas com cantos arredondados;
- Aplicar bordas somente em determinados lados do elemento.

A propriedade `border` permite definir três características principais:

> **espessura + estilo + cor**

Por exemplo:

```css
border: 5px solid red;
```

Significa:

- `5px` → espessura da borda;
- `solid` → estilo da borda;
- `red` → cor da borda.

------

#### 1. Propriedades básicas da borda

Podemos definir cada característica da borda separadamente.

##### `border-width`

Define a **espessura** da borda.

```css
border-width: 4px;
```

No código da aula:

```css
h1 {
    border-width: 4px;
    border-color: purple;
    border-style: double;
}
```

O `<h1>` possui uma borda com:

- **4px** de espessura;
- **purple** como cor;
- **double** como estilo.

------

##### `border-color`

Define a **cor da borda**.

```css
border-color: purple;
```

Exemplo:

```css
border-color: blue;
```

A borda será azul.

------

##### `border-style`

Define o **estilo visual da borda**.

Exemplo:

```css
border-style: solid;
```

Existem vários estilos disponíveis.

------

#### 2. Principais estilos de borda

##### `solid`

Cria uma linha contínua.

```css
border-style: solid;
```

------

##### `dashed`

Cria uma linha tracejada.

```css
border-style: dashed;
```

No código:

```css
#p1 {
    border: 2px dashed blue;
}
```

Nesse caso, o parágrafo possui uma borda:

- `2px` de espessura;
- `dashed` (tracejada);
- `blue` (azul).

------

##### `dotted`

Cria uma borda formada por pontos.

```css
border-style: dotted;
```

------

##### `double`

Cria uma borda dupla.

```css
border-style: double;
```

É utilizada no `<h1>` da aula:

```css
h1 {
    border-width: 4px;
    border-color: purple;
    border-style: double;
}
```

------

##### `groove`

Cria um efeito visual semelhante a uma borda entalhada.

```css
border-style: groove;
```

No exemplo:

```css
#p4 {
    border-width: 20px 10px;
    border-color: green blue;
    border-style: groove ridge;
}
```

------

##### `ridge`

Cria um efeito visual semelhante a uma borda em relevo.

```css
border-style: ridge;
```

É utilizada no exemplo acima e também em:

```css
border-top-style: ridge;
```

------

##### `outset`

Cria um efeito visual que faz a borda parecer projetada para fora.

```css
border-style: outset;
```

No código:

```css
border-right-style: outset;
```

------

#### 3. Forma abreviada: `border`

Em vez de escrever:

```css
border-width: 5px;
border-style: solid;
border-color: red;
```

podemos utilizar a forma abreviada:

```css
border: 5px solid red;
```

Essa forma é chamada de **shorthand property**.

A estrutura é:

```css
border: largura estilo cor;
```

##### Exemplo da aula

```css
#p1 {
    border: 2px dashed blue;
}
```

------

#### 4. Definindo diferentes bordas para cada lado

Uma das características importantes do CSS é a possibilidade de configurar cada lado da caixa individualmente.

Os quatro lados são:

```text
             TOP
              ↑
              │
       ┌──────────────┐
 LEFT  │              │ RIGHT
       └──────────────┘
              │
              ↓
            BOTTOM
```

Para isso, podemos utilizar:

- `border-top`
- `border-right`
- `border-bottom`
- `border-left`

------

#### 5. `border-top`

Define a borda **superior** do elemento.

```css
border-top: 5px solid red;
```

Também podemos definir suas propriedades separadamente:

```css
border-top-width: 5px;
border-top-style: solid;
border-top-color: red;
```

No código da aula:

```css
#p5 {
    border-top-width: 20px;
    border-top-color: tomato;
    border-top-style: ridge;
}
```

A parte superior possui:

- 20px;
- `tomato`;
- `ridge`.

------

#### 6. `border-bottom`

Define a borda **inferior**.

```css
border-bottom: 5px solid green;
```

Ou separadamente:

```css
border-bottom-width: 5px;
border-bottom-style: solid;
border-bottom-color: green;
```

No exemplo:

```css
border-bottom-width: 15px;
border-bottom-color: plum;
border-bottom-style: groove;
```

------

#### 7. `border-left`

Define a borda do **lado esquerdo**.

```css
border-left: 5px solid blue;
```

Também podemos separar:

```css
border-left-width: 5px;
border-left-style: solid;
border-left-color: blue;
```

No código da aula:

```css
#p6 {
    border-left-width: 20px;
    border-left-color: palevioletred;
    border-left-style: double;
}
```

------

#### 8. `border-right`

Define a borda do **lado direito**.

```css
border-right: 5px solid purple;
```

Ou:

```css
border-right-width: 5px;
border-right-style: solid;
border-right-color: purple;
```

No exemplo:

```css
border-right-width: 15px;
border-right-color: brown;
border-right-style: outset;
```

------

#### 9. Shorthand dos quatro lados

Também podemos definir cada lado separadamente usando a forma abreviada.

No código da aula:

```css
#p7 {
    border-top: 5px solid red;
    border-right: 5px solid purple;
    border-bottom: 5px solid green;
    border-left: 5px solid blue;
}
```

Nesse caso:

| Lado     | Espessura | Estilo | Cor    |
| -------- | --------- | ------ | ------ |
| Topo     | 5px       | solid  | red    |
| Direita  | 5px       | solid  | purple |
| Inferior | 5px       | solid  | green  |
| Esquerda | 5px       | solid  | blue   |

Isso permite criar uma borda diferente em cada lado.

------

#### 10. `border-width` com vários valores

A propriedade `border-width` permite informar valores diferentes para os quatro lados.

No código:

```css
#p2 {
    border-width: 10px 8px 6px 4px;
    border-color: red purple green blue;
    border-style: solid;
}
```

Quando fornecemos **quatro valores**, a ordem é:

> **top → right → bottom → left**

Ou:

> **cima → direita → baixo → esquerda**

Portanto:

```text
10px → cima
 8px → direita
 6px → baixo
 4px → esquerda
```

------

#### 11. `border-color` com vários valores

A mesma lógica pode ser aplicada às cores.

No código:

```css
border-color: red purple green blue;
```

A ordem é:

```text
red    → top
purple → right
green  → bottom
blue   → left
```

Portanto:

> **top → right → bottom → left**

------

#### 12. `border-style` com vários valores

Também podemos definir um estilo diferente para cada lado.

No exemplo:

```css
#p3 {
    border-width: 10px;
    border-color: red purple green blue;
    border-style: solid dashed dotted double;
}
```

Temos:

| Lado     | Cor    | Estilo |
| -------- | ------ | ------ |
| Topo     | red    | solid  |
| Direita  | purple | dashed |
| Inferior | green  | dotted |
| Esquerda | blue   | double |

------

#### 13. Dois valores

Também podemos utilizar **dois valores**.

No exemplo:

```css
#p4 {
    border-width: 20px 10px;
    border-color: green blue;
    border-style: groove ridge;
}
```

Quando utilizamos dois valores, eles representam:

```text
Primeiro valor  → cima e baixo
Segundo valor   → esquerda e direita
```

Portanto:

```css
border-width: 20px 10px;
```

significa:

- Cima e baixo → `20px`
- Esquerda e direita → `10px`

O mesmo princípio é utilizado para:

```css
border-color: green blue;
border-style: groove ridge;
```

------

#### 14. Bordas arredondadas — `border-radius`

Além de definir bordas, podemos controlar o formato dos cantos utilizando:

```css
border-radius
```

No exemplo:

```css
#p8 {
    border: 5px solid red;
    border-radius: 15px;
}
```

A borda possui cantos arredondados com raio de `15px`.

------

#### 15. Arredondando cada canto individualmente

Também podemos controlar cada canto separadamente.

As propriedades são:

- `border-top-left-radius`
- `border-top-right-radius`
- `border-bottom-right-radius`
- `border-bottom-left-radius`

No código:

```css
#p9 {
    border: 5px solid blue;
    border-top-left-radius: 10px;
    border-top-right-radius: 20px;
    border-bottom-right-radius: 30px;
    border-bottom-left-radius: 40px;
}
```

Cada canto possui um raio diferente:

| Canto             | Raio |
| ----------------- | ---- |
| Superior esquerdo | 10px |
| Superior direito  | 20px |
| Inferior direito  | 30px |
| Inferior esquerdo | 40px |

------

#### Resumo

##### Propriedades principais

| Propriedade                  | Função                                    |
| ---------------------------- | ----------------------------------------- |
| `border-width`               | Define a espessura                        |
| `border-style`               | Define o estilo                           |
| `border-color`               | Define a cor                              |
| `border`                     | Define espessura, estilo e cor de uma vez |
| `border-top`                 | Borda superior                            |
| `border-right`               | Borda direita                             |
| `border-bottom`              | Borda inferior                            |
| `border-left`                | Borda esquerda                            |
| `border-radius`              | Arredonda os cantos                       |
| `border-top-left-radius`     | Arredonda o canto superior esquerdo       |
| `border-top-right-radius`    | Arredonda o canto superior direito        |
| `border-bottom-right-radius` | Arredonda o canto inferior direito        |
| `border-bottom-left-radius`  | Arredonda o canto inferior esquerdo       |

##### Estilos utilizados na aula

| Estilo   | Característica                      |
| -------- | ----------------------------------- |
| `solid`  | Linha contínua                      |
| `dashed` | Linha tracejada                     |
| `dotted` | Linha pontilhada                    |
| `double` | Linha dupla                         |
| `groove` | Efeito de borda entalhada           |
| `ridge`  | Efeito de relevo                    |
| `outset` | Efeito de borda projetada para fora |

##### Regra para memorizar os quatro lados

Quando uma propriedade recebe **quatro valores**, a ordem é sempre:

```text
       TOP
        ↑
LEFT ← elemento → RIGHT
        ↓
      BOTTOM
```

Ou seja:

> **TOP → RIGHT → BOTTOM → LEFT**

**Cima → Direita → Baixo → Esquerda**

Essa regra aparece no código da aula em `border-width`, `border-color` e `border-style`.

#### Arquivo completo - bordas.html

 ```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bordas</title>
    <style>
        h1 {
            border-width: 4px;
            border-color: purple;
            border-style: double;
        }
        #p1 {
            border: 2px dashed blue;
        }
        #p2 {
            border-width: 10px 8px 6px 4px;
            border-color: red purple green blue;
            border-style: solid;
        }
        #p3 {
            border-width: 10px ;
            border-color: red purple green blue;
            border-style: solid dashed dotted double;
        }
        #p4 {
            border-width: 20px 10px;
            border-color:  green blue;
            border-style: groove ridge;
        }
        #p5 {
            border-top-width: 20px;
            border-top-color:  tomato;
            border-top-style:  ridge;
            border-bottom-width: 15px;
            border-bottom-color:  plum;
            border-bottom-style:  groove;
        }
        #p6 {
            border-left-width: 20px;
            border-left-color:  palevioletred;
            border-left-style:  double;
            border-right-width: 15px;
            border-right-color:  brown;
            border-right-style:  outset;
        }
        #p7 {
            border-top: 5px solid red;
            border-right: 5px solid purple;
            border-bottom: 5px solid green;
            border-left: 5px solid blue;
        }
        #p8 {
            border: 5px solid red;
            border-radius: 15px;
        }
        #p9 {
            border: 5px solid blue;
            border-top-left-radius: 10px;
            border-top-right-radius: 20px;
            border-bottom-right-radius: 30px;
            border-bottom-left-radius: 40px;
        }
        h2 {
            background-color: orange;
            border-bottom: 4px dotted black;
            padding: 8px;
            border-top-left-radius: 20px;
            border-top-right-radius: 20px;
            
        }
        #pd {
            background-color: lightsteelblue;
            border-left: 12px solid darkslateblue;
            border-right: 12px solid darkslateblue;
            padding: 8px;
            border-radius: 20px;
        }

    </style>    

</head>
<body>
    <h1>Esse é um título de exemplo</h1>
    <p id="p1">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Est laudantium velit aperiam repellat dignissimos porro iste fuga voluptatibus, soluta optio tenetur commodi nemo quos dolorem cum vitae totam ea debitis?
    </p>
    <p id="p2">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Illum maiores laboriosam at tempore sunt veritatis cupiditate dolorum recusandae veniam nesciunt, velit, fugit numquam voluptatum distinctio necessitatibus quia nulla minus eaque!
    </p>
    <p id="p3">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Alias magnam ducimus molestias, quis culpa quaerat deserunt ea unde. Culpa eius perferendis quam. Similique dolore voluptatem deserunt mollitia tempore eos amet!
    </p>
    <p id="p4">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Nostrum minima magnam quaerat vel libero ipsam, ea reiciendis nisi quis blanditiis eaque repellat, iusto pariatur fugiat debitis sequi, rerum vero sunt!
    </p>
    <p id="p5">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsam illum dolorum at porro minima eligendi quae blanditiis quos! Adipisci obcaecati sit eligendi accusamus. Maxime tempora, aperiam cumque ad libero animi.
    </p>
    <p id="p6">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsam illum dolorum at porro minima eligendi quae blanditiis quos! Adipisci obcaecati sit eligendi accusamus. Maxime tempora, aperiam cumque ad libero animi.
    </p>
    <p id="p7">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsam illum dolorum at porro minima eligendi quae blanditiis quos! Adipisci obcaecati sit eligendi accusamus. Maxime tempora, aperiam cumque ad libero animi.
    </p>
    <p id="p8">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsam illum dolorum at porro minima eligendi quae blanditiis quos! Adipisci obcaecati sit eligendi accusamus. Maxime tempora, aperiam cumque ad libero animi.
    </p>
    <p id="p9">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsam illum dolorum at porro minima eligendi quae blanditiis quos! Adipisci obcaecati sit eligendi accusamus. Maxime tempora, aperiam cumque ad libero animi.
    </p>

    <h2>Modelo de Caixa</h2>
    <p id="pd">
        Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quia tenetur tempore alias explicabo vero incidunt molestias sint, assumenda, ratione necessitatibus nobis. Quo dicta fuga eos, officia velit vel labore molestias?
    </p>
</body>
</html>
 ```



#### Links da aula

[3WSchool](https://www.w3schools.com/css/css_border.asp) - CSS Borders

[3WSchool](https://www.w3schools.com/css/css3_borders.asp) - CSS Rounded Corners



-----

-----



### 50.  Margin e Padding

No **Box Model**, `padding` e `margin` são propriedades utilizadas para controlar os **espaçamentos dos elementos**.

A principal diferença é:

- **`padding`** → cria **espaço interno**, entre o conteúdo e a borda.
- **`margin`** → cria **espaço externo**, entre o elemento e os elementos ao seu redor.

```text
┌───────────────────────────────┐
│            MARGIN             │
│   ┌───────────────────────┐   │
│   │        BORDER         │   │
│   │  ┌─────────────────┐  │   │
│   │  │     PADDING     │  │   │
│   │  │   ┌─────────┐   │  │   │
│   │  │   │ CONTENT │   │  │   │
│   │  │   └─────────┘   │  │   │
│   │  └─────────────────┘  │   │
│   └───────────────────────┘   │
└───────────────────────────────┘
```

------

#### `padding`

O `padding` define o **espaçamento interno** de um elemento.

Ele cria uma distância entre o **conteúdo** e a **borda** da caixa.

##### `padding: 40px;`

Define `40px` de espaço interno em **todos os quatro lados**:

```css
padding: 40px;
```

Equivale a:

```css
padding-top: 40px;
padding-right: 40px;
padding-bottom: 40px;
padding-left: 40px;
```

###### Exemplo

```css
p {
    padding: 40px;
}
```

O texto do parágrafo ficará afastado `40px` da borda em todas as direções.

------

##### `padding-top`

Define o espaçamento interno da **parte superior**.

```css
padding-top: 10px;
```

###### Exemplo

```css
p {
    padding-top: 10px;
}
```

O conteúdo terá `10px` de espaço entre ele e a borda superior.

------

##### `padding-right`

Define o espaçamento interno do **lado direito**.

```css
padding-right: 20px;
```

###### Exemplo

```css
p {
    padding-right: 20px;
}
```

------

##### `padding-bottom`

Define o espaçamento interno da **parte inferior**.

```css
padding-bottom: 30px;
```

###### Exemplo

```css
p {
    padding-bottom: 30px;
}
```

------

##### `padding-left`

Define o espaçamento interno do **lado esquerdo**.

```css
padding-left: 40px;
```

###### Exemplo

```css
p {
    padding-left: 40px;
}
```

------

##### `padding` com quatro valores

Podemos definir os quatro lados utilizando uma única propriedade:

```css
padding: 10px 20px 30px 40px;
```

Quando existem **quatro valores**, a ordem é:

> **top → right → bottom → left**

Ou:

> **cima → direita → baixo → esquerda**

Portanto:

```text
padding: 10px 20px 30px 40px;

           TOP
            ↓
      10px

LEFT 40px   conteúdo   RIGHT 20px

      30px
            ↑
          BOTTOM
```

| Lado   | Valor  |
| ------ | ------ |
| Top    | `10px` |
| Right  | `20px` |
| Bottom | `30px` |
| Left   | `40px` |

É equivalente a:

```css
padding-top: 10px;
padding-right: 20px;
padding-bottom: 30px;
padding-left: 40px;
```

------

##### `padding` com dois valores

Também podemos utilizar apenas **dois valores**:

```css
padding: 10px 20px;
```

Nesse caso:

- Primeiro valor → **top e bottom**
- Segundo valor → **right e left**

Portanto:

```text
padding: 10px 20px;

TOP    → 10px
BOTTOM → 10px

RIGHT  → 20px
LEFT   → 20px
```

É equivalente a:

```css
padding-top: 10px;
padding-bottom: 10px;
padding-right: 20px;
padding-left: 20px;
```

------

#### `margin`

O `margin` define o **espaçamento externo** de um elemento.

Diferentemente do `padding`, ele cria espaço **fora da caixa**.

```css
margin: 20px;
```

Isso cria `20px` de espaço em todos os lados do elemento.

##### Exemplo

```css
p {
    margin: 20px;
}
```

Nesse caso, o parágrafo terá uma distância de `20px` em relação aos elementos ao seu redor.

------

##### Margin entre os elementos do `body`

Quando queremos aplicar uma margem aos elementos dentro do `body`, podemos utilizar um seletor que englobe todos eles.

Por exemplo:

```css
body > * {
    margin: 20px;
}
```

O seletor `body > *` seleciona os **elementos que são filhos diretos do `<body>`**.

Assim, a margem pode ser aplicada a todos esses elementos.

> **Atenção:** isso é diferente de `margin: 20px` aplicado ao próprio `body`. Nesse caso, estamos definindo a margem do elemento `<body>`, e não dos elementos que estão dentro dele.

------

##### `margin-top`

Define o espaçamento externo da **parte superior**.

```css
margin-top: 10px;
```

###### Exemplo

```css
p {
    margin-top: 10px;
}
```

------

##### `margin-right`

Define o espaçamento externo do **lado direito**.

```css
margin-right: 20px;
```

###### Exemplo

```css
p {
    margin-right: 20px;
}
```

------

##### `margin-bottom`

Define o espaçamento externo da **parte inferior**.

```css
margin-bottom: 30px;
```

###### Exemplo

```css
p {
    margin-bottom: 30px;
}
```

------

##### `margin-left`

Define o espaçamento externo do **lado esquerdo**.

```css
margin-left: 40px;
```

###### Exemplo

```css
p {
    margin-left: 40px;
}
```

------

##### `margin` com quatro valores

Assim como acontece com `padding`, podemos definir os quatro lados utilizando uma única propriedade:

```css
margin: 10px 20px 30px 40px;
```

A ordem é:

> **top → right → bottom → left**

| Lado   | Valor  |
| ------ | ------ |
| Top    | `10px` |
| Right  | `20px` |
| Bottom | `30px` |
| Left   | `40px` |

É equivalente a:

```css
margin-top: 10px;
margin-right: 20px;
margin-bottom: 30px;
margin-left: 40px;
```

------

##### `margin` com dois valores

Também podemos utilizar:

```css
margin: 10px 20px;
```

Nesse caso:

- `10px` → **top e bottom**
- `20px` → **right e left**

É equivalente a:

```css
margin-top: 10px;
margin-bottom: 10px;
margin-right: 20px;
margin-left: 20px;
```

------

#### Regra para memorizar os valores

Tanto `padding` quanto `margin` seguem a mesma lógica.

##### Um valor

```css
padding: 10px;
10px
↓
Todos os lados
```

##### Dois valores

```css
padding: 10px 20px;
10px → cima e baixo
20px → esquerda e direita
```

##### Quatro valores

```css
padding: 10px 20px 30px 40px;
10px → cima
20px → direita
30px → baixo
40px → esquerda
```

A mesma regra vale para `margin`.

------

#### `padding` × `margin`

| Propriedade | Tipo de espaço | Onde é aplicado?               |
| ----------- | -------------- | ------------------------------ |
| `padding`   | Interno        | Entre o conteúdo e a borda     |
| `margin`    | Externo        | Fora da borda, entre elementos |

##### `padding`

```text
┌───────────────────────────┐
│        PADDING             │
│    ┌───────────────┐       │
│    │   conteúdo    │       │
│    └───────────────┘       │
└───────────────────────────┘
```

##### `margin`

```text
      MARGIN
         ↓
   ┌───────────────┐
   │    elemento   │
   └───────────────┘
         ↑
      MARGIN
```

------

#### Resumo

| Propriedade      | Função                                |
| ---------------- | ------------------------------------- |
| `padding`        | Espaçamento interno em todos os lados |
| `padding-top`    | Espaçamento interno superior          |
| `padding-right`  | Espaçamento interno direito           |
| `padding-bottom` | Espaçamento interno inferior          |
| `padding-left`   | Espaçamento interno esquerdo          |
| `margin`         | Espaçamento externo em todos os lados |
| `margin-top`     | Espaçamento externo superior          |
| `margin-right`   | Espaçamento externo direito           |
| `margin-bottom`  | Espaçamento externo inferior          |
| `margin-left`    | Espaçamento externo esquerdo          |

#### Regra principal

> **Padding = espaço dentro da caixa.**

> **Margin = espaço fora da caixa.**

E para `padding` e `margin`:

```text
1 valor  → todos os lados

2 valores → vertical | horizontal

4 valores → top | right | bottom | left
```

Essa regra de **1, 2 ou 4 valores** é uma das mais importantes para trabalhar com o Box Model no CSS.

-----

#### Arquivo completo - margin-padding.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Margin e Padding</title>
    <style>
        body {
            border: 1px solid blue;
            margin: 0;
        }
        h1 {
           border: 1px solid red; 
           padding: 40px;
           margin: 20px;
           /* padding-top: 10px;
           padding-right: 20px;
           padding-bottom: 30px;
           padding-left: 40px; 
           padding: 10px 20px 30px 40px;
           padding: 10px 20px;
           margin entre todos os elementos body
           margin-top: 10px;
           margin-right: 20px;
           margin-bottom: 30px;
           margin-left: 40px;
           margin: 10px 20px 30px 40px;
           margin: 10px 20px;
           */
           
        }
        #topo {
            border: 1px solid green;
            width: 900px;
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <div id="topo">
        <h1>Esse é um título de exemplo</h1>
        <p id="p1">
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Est laudantium velit aperiam repellat dignissimos porro iste fuga voluptatibus, soluta optio tenetur commodi nemo quos dolorem cum vitae totam ea debitis?
        </p>    
    </div>
    
</body>
</html>
```

-----

#### Arquivo completo - magalu-desafio-margin-padding.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Magalu exercício</title>
    <style>
        body {
            margin: 0;
            padding: 0;
        }
        #topo {
            background-color: dodgerblue;
            padding: 10px;
        }

        a {
            background-color: lightsteelblue;
            color: dodgerblue;
            border: 1px solid white;
            border-radius: 5px;
            padding: 8px;
            margin: 8px;            
        }

        #div-promocao {
            background-color: purple;
        }

        #div-banner, #div-produtos, #div-destaques {
            width: 1000px;
            margin: 0 auto;
        }
    </style>
</head>
<body>

    <div id="topo">
        <img src="./img/logo-magalu.png" alt="logo magalu" width="200">

        <a href="">Ofertas do dia</a>
        <a href="">Celulares</a>
        <a href="">Eletrodomésticos</a>
        <a href="">Tv e Video</a>
        <a href="">Informática</a>
    </div>

    <div id="div-promocao">
        <div id="div-banner">
            <img src="./img/banner.png" alt="banner oferta">
        </div>
    </div>
    

    <div id="div-produtos">
        <h1>Produtos</h1>
        <img src="./img/produto1.jpg" alt="produto1">
        <img src="./img/produto2.jpg" alt="produto2">
        <img src="./img/produto3.jpg" alt="produto3">
        <img src="./img/produto4.jpg" alt="produto4">
    </div>

    <div id="div-destaques">
        <h1>Destaques</h1>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam optio eligendi illo, incidunt nihil commodi, cum, earum expedita rerum modi odio consequuntur asperiores ea error libero praesentium adipisci molestiae doloremque.
        </p>
    </div>
</body>
</html>
```



-----

-----



### 51. [PROJETO] Detalhes produto Loja Virtual

#### Desafio -> detalhe-produto

#### Arquivo completo - index.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Detalhes produto - Loja Virtual</title>
    <link rel="stylesheet" href="./css/estilo.css">
</head>
<body>
    <div id="div-produto">
        <h1>Apple Iphone 13 128GB Meia-noite Tela 6,1" 12MP</h1>
        <p>Código 234661800</p>

        <img src="./img/iphone.png" alt="iphone">

        <h2>Informações do Produto</h2>

        <span>Avaliações (5)</span>
        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Vero totam praesentium, sint cumque tenetur repellat, vitae molestias asperiores aspernatur illum reprehenderit odit ipsum? Officiis iusto, dolores quas sed ratione perferendis!</p>
    </div>
</body>
</html>
```

-----

#### Arquivo completo - estilo.css

```css
body {
    background-color: #dbdbdb;
}

#div-produto {
    background-color: white;
    padding: 20px;
    margin: 20px;
    border: 5px solid blueviolet;
}

h1 {
    color: blueviolet;
}

p {
    color: gray;
}

img {
    border: 2px solid blueviolet;
    padding: 10px;
}
```



-----

-----

-----

