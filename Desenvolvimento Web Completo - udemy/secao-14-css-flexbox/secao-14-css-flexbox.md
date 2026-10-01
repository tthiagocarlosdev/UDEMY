#  Desenvolvimento Web Completo

## Professor Hamilton Damasceno

## Seção 14: CSS FlexBox 

### 103. Introdução ao Flexbox e Grid

#### CSS Grid e Flexbox

Tanto o **CSS Grid** quanto o **Flexbox** são sistemas de layout do CSS usados para **organizar e posicionar elementos na página**. Eles facilitam a criação de layouts responsivos sem precisar depender de `float`, posicionamento absoluto (`position: absolute`) ou várias margens.

##### 1. O que é Flexbox?

**Flexbox** (*Flexible Box Layout*) é um sistema de layout criado principalmente para organizar elementos em **uma dimensão**.

Isso significa que ele trabalha principalmente em **uma direção por vez**:

- **linha** → `row`
- **coluna** → `column`

Por exemplo, podemos usar Flexbox para colocar três elementos lado a lado:

```css
.container {
    display: flex;
}
<div class="container">
    <div>Item 1</div>
    <div>Item 2</div>
    <div>Item 3</div>
</div>
```

O Flexbox é muito utilizado para:

- alinhar elementos horizontalmente;
- alinhar elementos verticalmente;
- criar menus;
- organizar botões;
- criar barras de navegação;
- distribuir espaço entre elementos;
- centralizar elementos.

Algumas propriedades importantes:

```css
display: flex;
flex-direction: row;
justify-content: center;
align-items: center;
gap: 20px;
```

------

##### 2. O que é Grid?

**CSS Grid** (*Grid Layout*) é um sistema de layout criado para organizar elementos em **duas dimensões**.

Ele trabalha simultaneamente com:

- **linhas (rows)**
- **colunas (columns)**

Por exemplo:

```css
.container {
    display: grid;
    grid-template-columns: 200px 200px 200px;
    gap: 20px;
}
```

Podemos imaginar o resultado assim:

```text
┌─────────┬─────────┬─────────┐
│ Item 1  │ Item 2  │ Item 3  │
├─────────┼─────────┼─────────┤
│ Item 4  │ Item 5  │ Item 6  │
└─────────┴─────────┴─────────┘
```

O Grid é muito utilizado para criar estruturas maiores, como:

- layouts de páginas;
- painéis (*dashboards*);
- galerias;
- áreas com várias colunas;
- estruturas com cabeçalho, menu, conteúdo e rodapé.

Algumas propriedades importantes:

```css
display: grid;
grid-template-columns: 200px 1fr 200px;
grid-template-rows: 100px 1fr 80px;
gap: 20px;
```

------

#### 3. Qual é a diferença?

A principal diferença pode ser resumida assim:

| Flexbox                                        | Grid                                    |
| ---------------------------------------------- | --------------------------------------- |
| Trabalha em **uma dimensão**                   | Trabalha em **duas dimensões**          |
| Linha **ou** coluna                            | Linhas **e** colunas                    |
| Ótimo para organizar componentes               | Ótimo para estruturar layouts           |
| Foco no conteúdo e alinhamento                 | Foco na estrutura da página             |
| Mais simples para pequenos grupos de elementos | Mais poderoso para estruturas complexas |

##### Uma forma fácil de memorizar

> **Flexbox = uma direção**
> **Grid = duas direções**

Imagine uma fila de pessoas:

```text
👤  👤  👤  👤
```

Isso é um cenário típico para **Flexbox**.

Agora imagine pessoas organizadas em uma sala:

```text
👤  👤  👤
👤  👤  👤
👤  👤  👤
```

Isso é um cenário típico para **Grid**.

------

##### ⚠️ Importante

Não significa que você precisa escolher **Grid ou Flexbox** para um projeto inteiro.

É muito comum utilizar **os dois juntos**.

Por exemplo:

```text
           GRID
┌──────────────────────────┐
│         HEADER           │
├──────────┬───────────────┤
│          │               │
│   MENU   │    CONTENT    │
│          │               │
├──────────┴───────────────┤
│         FOOTER           │
└──────────────────────────┘
```

O **Grid** pode cuidar da estrutura geral da página, enquanto dentro do `header`, `menu` ou `content` podemos usar **Flexbox** para organizar os elementos.

**Regra inicial para memorizar:**

> 🔵 **Flexbox → organizar elementos em uma direção.**
> 🟢 **Grid → organizar elementos em linhas e colunas.**



---

---



### 104. Fundamentos do Flexbox e Grid

Antes de aprender as propriedades do **Flexbox** e do **Grid**, é importante entender três conceitos fundamentais:

1. **Container**
2. **Main Axis (eixo principal)**
3. **Cross Axis (eixo transversal)**

Esses conceitos são especialmente importantes no **Flexbox**. No Grid, a lógica de linhas e colunas é diferente, mas alguns conceitos de alinhamento são semelhantes.

------

#### 1. Container

O **container** é o elemento que contém os elementos que queremos organizar.

Por exemplo:

```html
<div class="container">
    <div>Item 1</div>
    <div>Item 2</div>
    <div>Item 3</div>
</div>
```

Nesse exemplo:

```text
┌───────────────────────────────┐
│          CONTAINER            │
│                               │
│   ┌──────┐ ┌──────┐ ┌──────┐  │
│   │Item 1│ │Item 2│ │Item 3│  │
│   └──────┘ └──────┘ └──────┘  │
│                               │
└───────────────────────────────┘
```

O `container` é o elemento responsável por controlar a disposição dos itens.

No Flexbox, precisamos transformar o elemento em um **Flex Container**:

```css
.container {
    display: flex;
}
```

No Grid:

```css
.container {
    display: grid;
}
```

Os elementos que estão dentro dele são chamados de **flex items** no Flexbox e **grid items** no Grid.

------

#### 2. Main Axis e Cross Axis

Esses dois conceitos são fundamentais principalmente no **Flexbox**.

Quando usamos:

```css
.container {
    display: flex;
}
```

o Flexbox estabelece dois eixos:

- **Main Axis** → eixo principal
- **Cross Axis** → eixo transversal

Podemos imaginar:

```text
              CROSS AXIS
                   ↓
                   │
                   │
                   │
                   │
                   │
                   └────────────────────→
                         MAIN AXIS
```

A direção desses eixos depende do valor de `flex-direction`.

------

#### 3. Main Axis

O **Main Axis** é o **eixo principal** do Flexbox.

Ele é determinado pela propriedade:

```css
flex-direction
```

Por padrão:

```css
flex-direction: row;
```

Portanto, o Main Axis será **horizontal**.

```text
MAIN AXIS →
───────────────────────────────

┌──────┐  ┌──────┐  ┌──────┐
│Item 1│  │Item 2│  │Item 3│
└──────┘  └──────┘  └──────┘
```

Nesse caso:

```text
Main Axis   → horizontal
Cross Axis  ↓ vertical
```

------

#### 4. Cross Axis

O **Cross Axis** é o eixo que fica **perpendicular ao Main Axis**.

Se o Main Axis é horizontal:

```text
Main Axis
────────────────────────→

Cross Axis
     ↓
     ↓
     ↓
```

Portanto:

```text
Main Axis  = horizontal
Cross Axis = vertical
```

------

#### 5. `flex-direction: row`

Esse é o comportamento padrão.

```css
.container {
    display: flex;
    flex-direction: row;
}
```

Temos:

```text
              Cross Axis
                   ↓
                   │
                   │
┌──────┐ ┌──────┐ ┌──────┐
│Item 1│ │Item 2│ │Item 3│ ───→ Main Axis
└──────┘ └──────┘ └──────┘
```

Nesse caso:

- `justify-content` trabalha no **Main Axis**;
- `align-items` trabalha no **Cross Axis**.

Por exemplo:

```css
.container {
    display: flex;
    justify-content: center;
    align-items: center;
}
```

O resultado é a centralização dos itens nos dois eixos.

------

#### 6. `flex-direction: column`

Podemos mudar a direção:

```css
.container {
    display: flex;
    flex-direction: column;
}
```

Agora o Main Axis passa a ser **vertical**:

```text
       Main Axis
           ↓
           │
      ┌──────┐
      │Item 1│
      └──────┘
           │
      ┌──────┐
      │Item 2│
      └──────┘
           │
      ┌──────┐
      │Item 3│
      └──────┘
```

Agora temos:

```text
Main Axis  = vertical
Cross Axis = horizontal
```

E isso é muito importante:

```css
justify-content
```

continua trabalhando no **Main Axis**.

Portanto, com `flex-direction: column`, `justify-content` passa a atuar **verticalmente**.

------

#### 7. `justify-content`

A propriedade:

```css
justify-content
```

controla o alinhamento dos itens no **Main Axis**.

Por exemplo:

```css
.container {
    display: flex;
    justify-content: center;
}
```

Com `row`:

```text
←────── Main Axis ──────→

┌───────────────────────────────┐
│       Item 1 Item 2 Item 3    │
└───────────────────────────────┘
```

Os itens foram centralizados **horizontalmente**.

Com:

```css
flex-direction: column;
justify-content: center;
```

a centralização será **vertical**:

```text
┌─────────────────────┐
│                     │
│       Item 1        │
│       Item 2        │
│       Item 3        │
│                     │
└─────────────────────┘
```

##### Memorize:

> **`justify-content` → Main Axis**

------

#### 8. `align-items`

Já o:

```css
align-items
```

trabalha no **Cross Axis**.

Por exemplo:

```css
.container {
    display: flex;
    align-items: center;
}
```

Com:

```css
flex-direction: row;
```

o Cross Axis é vertical.

Então:

```text
          Cross Axis
              ↓
              │
              │
    ┌─────────┼─────────┐
    │         │         │
    │  Item   │         │
    │         │         │
    └─────────┼─────────┘
              │
```

Os itens são centralizados verticalmente.

##### Memorize:

> **`align-items` → Cross Axis**

------

#### 9. E no CSS Grid?

No **Grid**, existe uma diferença importante.

O Grid trabalha naturalmente com **duas dimensões**:

```text
           COLUNAS
       ↓      ↓      ↓

      ┌──────┬──────┬──────┐
LINHA │      │      │      │
  ↓   ├──────┼──────┼──────┤
      │      │      │      │
      ├──────┼──────┼──────┤
      │      │      │      │
      └──────┴──────┴──────┘
```

Temos:

- **Grid Rows** → linhas
- **Grid Columns** → colunas

Por isso, no Grid, normalmente pensamos em **linhas e colunas**, e não apenas em Main Axis e Cross Axis.

------

#### 10. Alinhamento no Grid

O Grid possui propriedades como:

```css
justify-items
align-items
place-items
```

Por exemplo:

```css
.container {
    display: grid;
    justify-items: center;
    align-items: center;
}
```

Podemos também usar:

```css
.container {
    display: grid;
    place-items: center;
}
```

`place-items` é uma forma abreviada de configurar:

```css
align-items
justify-items
```

------

#### 11. Resumo para memorizar

##### Flexbox

Primeiro descubra qual é o **Main Axis**:

```css
flex-direction: row;
Main Axis  → horizontal
Cross Axis ↓ vertical
```

ou:

```css
flex-direction: column;
Main Axis  ↓ vertical
Cross Axis → horizontal
```

Depois lembre:

```text
justify-content → Main Axis
align-items     → Cross Axis
```

##### Grid

Pense principalmente em:

```text
Rows    → linhas
Columns → colunas
```

E nos alinhamentos:

```text
justify-items → eixo das colunas
align-items   → eixo das linhas
```

##### 🧠 Regra de ouro

> **Flexbox:** primeiro descubra a direção do `flex-direction`.
> **`justify-content` → Main Axis.**
> **`align-items` → Cross Axis.**

> **Grid:** pense em **linhas e colunas** e nas propriedades de alinhamento correspondentes.



---

---



### 105. Display Flex

#### Arquivo commpleto - 1_display_flex.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Flexbox</title>
    <style>
        body {
            background-color: black;
        }
        .container-flex {
            border: 4px solid red;
            display: flex;
        }
        .container-flex > div {
            color: white;
            border: 4px solid white;
            padding: 4px;
            margin: 4px;
        }
    </style>
</head>
<body>
    <h1>Display Flex</h1>

    <div class="container-flex">
        <div>01</div>
        <div>02</div>
        <div>03</div>
        <div>04</div>
        <div>05</div>
        <div>06</div>
        <div>07</div>
        <div>08</div>
        <div>09</div>
        <div>10</div>
    </div>
</body>
</html>
```



---

---



### 106. Flex Direction, Flex Wrap e Flex Flow

Essas três propriedades são fundamentais para controlar **a direção e a quebra dos elementos dentro de um Flex Container**.

Vamos analisar cada uma delas.

------

#### 1. `flex-direction`

A propriedade `flex-direction` define **a direção em que os Flex Items serão organizados** dentro do container.

```css
.container {
    display: flex;
    flex-direction: row;
}
```

Ela possui quatro valores principais:

```css
flex-direction: row;
flex-direction: column;
flex-direction: row-reverse;
flex-direction: column-reverse;
```

------

##### `row`

É o valor padrão.

```css
.container {
    display: flex;
    flex-direction: row;
}
```

Os elementos são organizados **da esquerda para a direita**:

```text
┌───────────────────────────────┐
│  Item 1   Item 2   Item 3     │
└───────────────────────────────┘
      → → → → → → →
        Main Axis
```

Nesse caso:

```text
Main Axis  → horizontal
Cross Axis ↓ vertical
```

------

##### `column`

Organiza os elementos **de cima para baixo**.

```css
.container {
    display: flex;
    flex-direction: column;
}
```

Resultado:

```text
┌───────────────┐
│    Item 1     │
│       ↓       │
│    Item 2     │
│       ↓       │
│    Item 3     │
└───────────────┘
```

Agora:

```text
Main Axis  ↓ vertical
Cross Axis → horizontal
```

Isso é importante porque o `justify-content` sempre trabalha no **Main Axis**.

Por exemplo:

```css
.container {
    display: flex;
    flex-direction: column;
    justify-content: center;
}
```

Nesse caso, `justify-content` fará o alinhamento **verticalmente**.

------

##### `row-reverse`

É semelhante ao `row`, mas **inverte a ordem no eixo horizontal**.

```css
.container {
    display: flex;
    flex-direction: row-reverse;
}
```

Resultado:

```text
┌───────────────────────────────┐
│  Item 3   Item 2   Item 1     │
└───────────────────────────────┘
      ← ← ← ← ← ← ←
```

O primeiro elemento continua sendo o `Item 1`, mas sua posição visual será invertida.

------

##### `column-reverse`

É semelhante ao `column`, mas inverte a direção vertical.

```css
.container {
    display: flex;
    flex-direction: column-reverse;
}
```

Resultado:

```text
┌───────────────┐
│    Item 3     │
│       ↑       │
│    Item 2     │
│       ↑       │
│    Item 1     │
└───────────────┘
```

##### Resumo

| Valor            | Direção                 |
| ---------------- | ----------------------- |
| `row`            | → esquerda para direita |
| `row-reverse`    | ← direita para esquerda |
| `column`         | ↓ cima para baixo       |
| `column-reverse` | ↑ baixo para cima       |

------

#### 2. `flex-wrap`

A propriedade `flex-wrap` determina **se os elementos podem quebrar para uma nova linha ou coluna quando não houver espaço suficiente**.

Por padrão:

```css
flex-wrap: nowrap;
```

Ou seja, os elementos **não quebram**.

------

##### `nowrap`

```css
.container {
    display: flex;
    flex-wrap: nowrap;
}
```

Imagine que temos vários elementos:

```text
┌─────────────────────────────┐
│ Item 1 Item 2 Item 3 Item 4│
└─────────────────────────────┘
```

Se não houver espaço suficiente, os itens tentarão permanecer na mesma linha.

Isso pode fazer com que os elementos:

- fiquem muito apertados;
- ultrapassem o tamanho esperado;
- causem problemas de layout.

`nowrap` é o valor padrão.

------

#### 3. `wrap`

Com:

```css
.container {
    display: flex;
    flex-wrap: wrap;
}
```

os elementos podem **quebrar para uma nova linha** quando não houver espaço.

Por exemplo:

```text
┌──────────────────────────────┐
│ Item 1   Item 2   Item 3     │
│ Item 4   Item 5   Item 6     │
└──────────────────────────────┘
```

Isso é muito útil para layouts **responsivos**.

Por exemplo, imagine uma página com vários cards:

```text
Tela grande:

┌──────┐ ┌──────┐ ┌──────┐ ┌──────┐
│ Card │ │ Card │ │ Card │ │ Card │
└──────┘ └──────┘ └──────┘ └──────┘
```

Em uma tela menor:

```text
┌──────┐ ┌──────┐
│ Card │ │ Card │
└──────┘ └──────┘
┌──────┐ ┌──────┐
│ Card │ │ Card │
└──────┘ └──────┘
```

O `wrap` permite essa quebra.

------

#### 4. `wrap-reverse`

Também permite quebra, mas **inverte o sentido das linhas criadas pelo wrap**.

```css
.container {
    display: flex;
    flex-wrap: wrap-reverse;
}
```

Com `row`, normalmente temos:

```text
┌──────────────────────────┐
│ Item 1  Item 2  Item 3   │
│ Item 4  Item 5  Item 6   │
└──────────────────────────┘
```

Com `wrap-reverse`, a segunda linha é criada no sentido oposto do **Cross Axis**:

```text
┌──────────────────────────┐
│ Item 4  Item 5  Item 6   │
│ Item 1  Item 2  Item 3   │
└──────────────────────────┘
```

O `wrap-reverse` não troca simplesmente a ordem dos itens como `row-reverse`. Ele **inverte a direção do Cross Axis das linhas**.

------

#### 5. `flex-flow`

Agora temos uma propriedade muito interessante:

```css
flex-flow
```

Ela é uma **shorthand**, ou seja, uma propriedade abreviada que combina:

```css
flex-direction
flex-wrap
```

Por exemplo:

```css
.container {
    flex-direction: column;
    flex-wrap: wrap;
}
```

Pode ser escrito de forma abreviada:

```css
.container {
    flex-flow: column wrap;
}
```

É exatamente a mesma configuração.

------

##### Sintaxe

A estrutura é:

```css
flex-flow: <flex-direction> <flex-wrap>;
```

Por exemplo:

```css
flex-flow: row nowrap;
```

equivale a:

```css
flex-direction: row;
flex-wrap: nowrap;
```

Outro exemplo:

```css
flex-flow: row wrap;
```

equivale a:

```css
flex-direction: row;
flex-wrap: wrap;
```

E:

```css
flex-flow: column wrap;
```

equivale a:

```css
flex-direction: column;
flex-wrap: wrap;
```

------

#### 6. Uma forma fácil de memorizar

Pense que:

##### `flex-direction`

> **"Para onde os elementos vão?"**

```text
row             → →
column          ↓ ↓
row-reverse     ← ←
column-reverse  ↑ ↑
```

##### `flex-wrap`

> **"O que acontece quando não cabe?"**

```text
nowrap
→ continua na mesma linha

wrap
→ quebra normalmente

wrap-reverse
→ quebra no sentido contrário do Cross Axis
```

##### `flex-flow`

> **"Quero configurar os dois de uma vez."**

```css
flex-flow: direction wrap;
```

Por exemplo:

```css
flex-flow: row wrap;
```

ou:

```css
flex-flow: column wrap;
```

------

#### 🧠 Para memorizar

```text
┌────────────────────────────────────┐
│        FLEXBOX                     │
├────────────────────────────────────┤
│ flex-direction → direção           │
│                                    │
│ row              →                 │
│ column           ↓                 │
│ row-reverse      ←                 │
│ column-reverse   ↑                 │
├────────────────────────────────────┤
│ flex-wrap → quebra                 │
│                                    │
│ nowrap           não quebra        │
│ wrap             quebra            │
│ wrap-reverse     quebra invertido  │
├────────────────────────────────────┤
│ flex-flow → direction + wrap       │
│                                    │
│ flex-flow: row wrap;               │
└────────────────────────────────────┘
```

**Regra principal:** `flex-direction` define **a direção do Main Axis**; `flex-wrap` define **se os itens podem formar novas linhas/colunas**; e `flex-flow` combina as duas propriedades.

---

#### Arquivo commpleto - 1_display_flex.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Flexbox</title>
    <style>
        body {
            background-color: black;
        }
        .container-flex {
            width: 180px;
            height: 180px;
            border: 4px solid red;
            display: flex;
            /* row, column, row-reverse, column-reverse */
            flex-direction: row;
            /* flex-wrap: wrap, nowrap, wrap-reverse */
            flex-wrap: wrap;
            flex-flow: column wrap;
        }
        .container-flex > div {
            color: white;
            border: 4px solid white;
            padding: 4px;
            margin: 4px;
        }
    </style>
</head>
<body>
    <h1>Display Flex</h1>

    <div class="container-flex">
        <div>01</div>
        <div>02</div>
        <div>03</div>
        <div>04</div>
        <div>05</div>
        <div>06</div>
        <div>07</div>
        <div>08</div>
        <div>09</div>
        <div>10</div>
    </div>
</body>
</html>
```



---

---



### 107. Alinhamentos: Justify Content

A propriedade `justify-content` é utilizada para **distribuir e alinhar os Flex Items ao longo do Main Axis (eixo principal)**.

```css
.container {
    display: flex;
    justify-content: center;
}
```

O ponto mais importante para entender essa propriedade é:

> **`justify-content` sempre trabalha no Main Axis.**

Portanto, a direção depende do `flex-direction`.

Com:

```css
flex-direction: row;
```

o Main Axis é horizontal:

```text
←──────────── MAIN AXIS ────────────→
```

Com:

```css
flex-direction: column;
```

o Main Axis é vertical:

```text
        ↑
        │
   MAIN AXIS
        │
        ↓
```

------

#### 1. `flex-start`

É o valor padrão.

```css
.container {
    display: flex;
    justify-content: flex-start;
}
```

Os itens são colocados **no início do Main Axis**.

Com `row`:

```text
┌────────────────────────────────────┐
│ [1] [2] [3]                        │
└────────────────────────────────────┘
  ↑
 início
```

Existe espaço sobrando depois dos elementos.

##### Com `column`

```text
┌──────────────┐
│ [1]          │
│ [2]          │
│ [3]          │
│              │
│              │
└──────────────┘
  ↑
 início
```

##### Memorize:

> `flex-start` → coloca os itens **no início**.

------

#### 2. `flex-end`

Coloca os itens **no final do Main Axis**.

```css
.container {
    display: flex;
    justify-content: flex-end;
}
```

Com `row`:

```text
┌────────────────────────────────────┐
│                        [1] [2] [3] │
└────────────────────────────────────┘
                                  ↑
                                 fim
```

Com `column`:

```text
┌──────────────┐
│              │
│              │
│              │
│ [1]          │
│ [2]          │
│ [3]          │
└──────────────┘
          ↑
         fim
```

##### Memorize:

> `flex-end` → coloca os itens **no final**.

------

#### 3. `center`

Centraliza os itens no Main Axis.

```css
.container {
    display: flex;
    justify-content: center;
}
```

Resultado:

```text
┌────────────────────────────────────┐
│                                    │
│          [1] [2] [3]               │
│                                    │
└────────────────────────────────────┘
```

O espaço disponível antes e depois dos elementos fica distribuído igualmente.

##### Muito utilizado para:

- centralizar menus;
- centralizar botões;
- centralizar grupos de elementos;
- criar layouts.

Por exemplo:

```css
.menu {
    display: flex;
    justify-content: center;
}
```

------

#### 4. `space-between`

Distribui os elementos deixando **o maior espaço possível entre eles**, mas **sem espaço nas extremidades**.

```css
.container {
    display: flex;
    justify-content: space-between;
}
```

Resultado:

```text
┌────────────────────────────────────┐
│ [1]            [2]            [3] │
└────────────────────────────────────┘
  ↑              ↑               ↑
 início          espaço         fim
```

Observe que:

- o primeiro item encosta no início;
- o último item encosta no final;
- o espaço restante é distribuído **entre os elementos**.

##### Exemplo

Imagine uma barra de navegação:

```text
┌─────────────────────────────────────────┐
│ Home       Produtos       Contato       │
└─────────────────────────────────────────┘
```

O `space-between` é bastante útil nesse tipo de situação.

------

#### 5. `space-around`

Distribui espaço **ao redor de cada elemento**.

```css
.container {
    display: flex;
    justify-content: space-around;
}
```

Visualmente:

```text
┌────────────────────────────────────┐
│   [1]       [2]       [3]         │
└────────────────────────────────────┘
```

Existe espaço antes, entre e depois dos elementos.

Uma maneira de entender é:

```text
   espaço    [1]    espaço    [2]    espaço    [3]    espaço
```

Porém, existe um detalhe importante:

> O espaço entre dois elementos acaba sendo **o dobro** do espaço existente nas extremidades.

Por quê?

Porque cada elemento possui espaço dos dois lados.

```text
  [espaço] [1] [espaço] [espaço] [2] [espaço]
```

Os dois espaços que ficam entre `[1]` e `[2]` se juntam.

------

#### 6. `space-evenly`

Distribui o espaço de maneira **igual em todos os intervalos**.

```css
.container {
    display: flex;
    justify-content: space-evenly;
}
```

Resultado:

```text
┌────────────────────────────────────┐
│    [1]      [2]      [3]           │
└────────────────────────────────────┘
```

Aqui temos:

```text
espaço = item = espaço = item = espaço = item = espaço
```

Na realidade, os elementos possuem seus próprios tamanhos, mas **todos os espaços disponíveis são iguais**.

------

#### 7. Comparando os três `space-*`

Essa é uma das partes mais importantes.

Imagine:

```text
[1] [2] [3]
```

##### `space-between`

```text
│[1]────────[2]────────[3]│
```

Não existe espaço nas extremidades.

```text
extremo → ITEM → espaço → ITEM → espaço → ITEM ← extremo
```

------

##### `space-around`

```text
│──[1]────[2]────[3]──│
```

Existe espaço nas extremidades, mas o espaço entre os itens é **duas vezes** o espaço das extremidades.

------

##### `space-evenly`

```text
│──[1]──[2]──[3]──│
```

Todos os espaços são **iguais**.

------

#### 8. Tabela comparativa

| Valor           | Comportamento                 |
| --------------- | ----------------------------- |
| `flex-start`    | Itens no início               |
| `flex-end`      | Itens no final                |
| `center`        | Itens centralizados           |
| `space-between` | Espaço somente entre os itens |
| `space-around`  | Espaço ao redor dos itens     |
| `space-evenly`  | Espaços completamente iguais  |

------

#### 9. Visualização geral

Com um container assim:

```text
┌────────────────────────────────────────────┐
│                                            │
│                                            │
└────────────────────────────────────────────┘
```

Podemos visualizar:

##### `flex-start`

```text
[1][2][3]────────────────────────
```

##### `flex-end`

```text
────────────────────────[1][2][3]
```

##### `center`

```text
────────────[1][2][3]────────────
```

##### `space-between`

```text
[1]────────────[2]────────────[3]
```

##### `space-around`

```text
──[1]────────[2]────────[3]──
```

##### `space-evenly`

```text
───[1]────[2]────[3]───
```

------

#### 10. Cuidado com `flex-direction`

Lembre-se de que `justify-content` **não significa necessariamente "horizontal"**.

Ele significa:

> **Alinhar/distribuir no Main Axis.**

Por exemplo:

```css
.container {
    display: flex;
    flex-direction: row;
    justify-content: center;
}
```

O `center` centraliza **horizontalmente**.

Mas:

```css
.container {
    display: flex;
    flex-direction: column;
    justify-content: center;
}
```

Agora o `center` centraliza **verticalmente**.

```text
flex-direction: row

        ← Main Axis →
       [1] [2] [3]


flex-direction: column

             ↑
             │
           Main
           Axis
             │
            [1]
            [2]
            [3]
             │
             ↓
```

#### 🧠 Regra para memorizar

> **`justify-content` → Main Axis**

E lembre-se:

> **`flex-direction` determina onde está o Main Axis.**

Então, antes de usar `justify-content`, pergunte:

**"Meu Main Axis está na horizontal ou na vertical?"**

Isso evita uma das confusões mais comuns de quem está começando Flexbox.

---

#### Arquivo commpleto - 2_alinhamento.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Alinhamento</title>
    <style>
        body {
            background-color: black;
        }
        .container-flex {
            height: 180px;
            border: 4px solid red;
            display: flex;
            flex-direction: column;
            /* justify-content: flex-start, flex-end, center, space-between, space-around e space-evenly*/
            justify-content: space-around;
        }
        .container-flex > div {
            color: white;
            border: 4px solid white;
            padding: 4px;
            margin: 4px;
        }
    </style>
</head>
<body>
    <h1>Alinhamentos</h1>

    <div class="container-flex">
        <div>01</div>
        <div>02</div>
        <div>03</div>
    </div>
</body>
</html>
```



---

---



### 108. Alinhamentos: Align Items





### 109. Alinhamentos: Align Content

### 110. Align Self

### 111. Flex Basis

### 112. Flex Grow115. Order

### 113. Flex Shrink

### 114. Flex

### 115. Order