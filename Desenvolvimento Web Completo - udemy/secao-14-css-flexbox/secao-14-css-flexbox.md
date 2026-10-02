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

A propriedade `align-items` controla **como os Flex Items são alinhados no Cross Axis (eixo transversal)** dentro do Flex Container.

```css
.container {
    display: flex;
    align-items: center;
}
```

A regra mais importante para memorizar é:

> **`justify-content` → Main Axis**
> **`align-items` → Cross Axis**

Portanto, `align-items` depende da direção definida por `flex-direction`.

#### Com `row`

```css
flex-direction: row;
```

Temos:

```text
          Cross Axis
               ↓
               │
[ Item 1 ] [ Item 2 ] [ Item 3 ]
────────────────────────────────→
             Main Axis
```

Nesse caso, `align-items` controla o alinhamento **vertical**.

#### Com `column`

```css
flex-direction: column;
```

Os eixos ficam:

```text
        Main Axis
             ↓
       [ Item 1 ]
       [ Item 2 ]
       [ Item 3 ]
             │
             ↓

←───────────────→
   Cross Axis
```

Agora `align-items` controla o alinhamento **horizontal**.

------

#### 1. `stretch`

É o valor **padrão** de `align-items`.

```css
.container {
    display: flex;
    align-items: stretch;
}
```

`stretch` faz com que os itens sejam **esticados no Cross Axis**, desde que eles não tenham um tamanho explícito nesse eixo.

Com `row`:

```text
┌──────────────────────────────────┐
│          Item 1          │
├──────────────────────────────────┤
│          Item 2          │
├──────────────────────────────────┤
│          Item 3          │
└──────────────────────────────────┘
```

Uma forma mais simples de visualizar:

```text
┌───────────────────────────────┐
│ Item 1 │ Item 2 │ Item 3     │
│        │        │             │
│        │        │             │
│        │        │             │
└───────────────────────────────┘
```

Os elementos ocupam a altura disponível do container.

##### Importante

Se você definir uma altura explícita no item:

```css
.item {
    height: 50px;
}
```

o comportamento de `stretch` deixa de poder esticar o item além dessa altura.

##### Memorize:

> `stretch` → **estica os itens no Cross Axis**.

------

#### 2. `flex-start`

Coloca os itens **no início do Cross Axis**.

```css
.container {
    display: flex;
    align-items: flex-start;
}
```

Com `row`, o Cross Axis é vertical:

```text
┌───────────────────────────────┐
│ [1]    [2]    [3]             │
│                               │
│                               │
│                               │
└───────────────────────────────┘
  ↑
  início do Cross Axis
```

Os itens ficam alinhados no **topo**.

Com `column`, o Cross Axis é horizontal, então eles ficam no **lado inicial**:

```text
┌───────────────────────────────┐
│ [1]                           │
│ [2]                           │
│ [3]                           │
└───────────────────────────────┘
  ↑
 início
```

##### Memorize:

> `flex-start` → **início do Cross Axis**.

------

#### 3. `flex-end`

Coloca os itens **no final do Cross Axis**.

```css
.container {
    display: flex;
    align-items: flex-end;
}
```

Com `row`:

```text
┌───────────────────────────────┐
│                               │
│                               │
│ [1]    [2]    [3]             │
└───────────────────────────────┘
                         ↑
                  fim do Cross Axis
```

Os itens ficam alinhados na parte inferior.

Com `column`, ficam no final horizontal:

```text
┌───────────────────────────────┐
│                           [1] │
│                           [2] │
│                           [3] │
└───────────────────────────────┘
                            ↑
                           fim
```

##### Memorize:

> `flex-end` → **final do Cross Axis**.

------

#### 4. `center`

Centraliza os itens no **Cross Axis**.

```css
.container {
    display: flex;
    align-items: center;
}
```

Com `row`:

```text
┌───────────────────────────────┐
│                               │
│   [1]    [2]    [3]           │
│                               │
└───────────────────────────────┘
```

Os itens ficam centralizados **verticalmente**.

Com `column`:

```text
┌───────────────────────────────┐
│                               │
│       [1]                     │
│       [2]                     │
│       [3]                     │
│                               │
└───────────────────────────────┘
```

Agora ficam centralizados **horizontalmente**.

##### Memorize:

> `center` → **centro do Cross Axis**.

------

#### 5. `baseline`

O valor `baseline` alinha os elementos de acordo com a **linha de base do conteúdo**, normalmente a linha de base do texto.

```css
.container {
    display: flex;
    align-items: baseline;
}
```

Isso é especialmente útil quando temos elementos com **textos de tamanhos diferentes**.

Por exemplo:

```text
┌─────────────────────────────────┐
│  Texto pequeno   TEXTO GRANDE   │
│       ────────────────           │
│          baseline               │
└─────────────────────────────────┘
```

Imagine:

```html
<div class="container">
    <span>Texto pequeno</span>
    <h1>Título</h1>
    <span>Outro texto</span>
</div>
```

Com:

```css
.container {
    display: flex;
    align-items: baseline;
}
```

A ideia é fazer com que a **base dos textos fique alinhada**, mesmo que eles tenham tamanhos diferentes.

##### Exemplo visual

Sem alinhamento pela baseline:

```text
Texto pequeno

        TÍTULO

                Texto
```

Com `baseline`:

```text
Texto pequeno      TÍTULO      Texto
──────────────      ──────      ─────
       mesma linha de base
```

É muito útil em situações como:

- títulos e textos lado a lado;
- preços com tamanhos diferentes;
- textos e números;
- elementos tipográficos de tamanhos diferentes.

------

#### Comparando os valores

Imagine um container:

```text
┌──────────────────────────────────┐
│                                  │
│                                  │
│                                  │
│                                  │
└──────────────────────────────────┘
```

Com `flex-direction: row`:

##### `stretch`

```text
┌──────────────────────────────────┐
│ [1]      [2]      [3]            │
│                                  │
│                                  │
└──────────────────────────────────┘
```

Os itens são esticados verticalmente.

##### `flex-start`

```text
┌──────────────────────────────────┐
│ [1]      [2]      [3]            │
│                                  │
│                                  │
└──────────────────────────────────┘
```

Itens no topo.

##### `flex-end`

```text
┌──────────────────────────────────┐
│                                  │
│                                  │
│ [1]      [2]      [3]            │
└──────────────────────────────────┘
```

Itens embaixo.

##### `center`

```text
┌──────────────────────────────────┐
│                                  │
│       [1]  [2]  [3]              │
│                                  │
└──────────────────────────────────┘
```

Itens no centro.

##### `baseline`

```text
┌──────────────────────────────────┐
│                                  │
│  pequeno    GRANDE    pequeno    │
│  ───────────────────────────     │
│                                  │
└──────────────────────────────────┘
```

As **linhas de base dos conteúdos** ficam alinhadas.

------

#### `justify-content` × `align-items`

Essa comparação é fundamental:

| Propriedade       | Eixo           | Função                    |
| ----------------- | -------------- | ------------------------- |
| `justify-content` | **Main Axis**  | Distribui/alinha os itens |
| `align-items`     | **Cross Axis** | Alinha os itens           |

Por exemplo:

```css
.container {
    display: flex;
    flex-direction: row;

    justify-content: center;
    align-items: center;
}
```

Como `row` define o Main Axis horizontal:

```text
       align-items
       ↓       ↓
┌───────────────────────────────┐
│                               │
│       [1] [2] [3]             │
│                               │
└───────────────────────────────┘
        ← justify-content →
```

O resultado é que os itens ficam **centralizados nos dois eixos**.

##### 🧠 Para memorizar

> **`justify-content` → Main Axis**
> **`align-items` → Cross Axis**

E os valores do `align-items`:

```text
stretch      → estica
flex-start   → início
flex-end     → final
center       → centro
baseline     → linha de base do conteúdo
```

Essa relação entre **Main Axis + Cross Axis + `justify-content` + `align-items`** é uma das bases mais importantes para entender Flexbox.

---

#### Arquivo completo - 2_alinhamento.html

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
        h2 {
            color: white;
            text-align: center;
        }
        .container-flex {
            height: 180px;
            border: 4px solid red;
            display: flex;
            flex-direction: row;
            /* justify-content: flex-start, flex-end, center, space-between, space-around e space-evenly*/
            justify-content: center;
            /* align-items: stretch, flex-start, flex-end, center, baseline */
            align-items: flex-start;
        }
        .container-flex > div {
            color: white;
            border: 4px solid white;
            padding: 4px;
            margin: 4px;
        }
        .texto-grande {
            font-size: 3em;
        }
        .coluna {
            flex-direction: column;
        }
    </style>
</head>
<body>
    <h1>Alinhamentos</h1>

    <h2>Row</h2>
    <div class="container-flex">
        <div>01</div>
        <div class="texto-grande">02</div>
        <div>03</div>
    </div>

    <h2>Column</h2>
    <div class="container-flex coluna">
        <div>01</div>
        <div class="texto-grande">02</div>
        <div>03</div>
    </div>
</body>
</html>
```



---

---



### 109. Alinhamentos: Align Content

A propriedade `align-content` é usada para **distribuir as linhas ou colunas de um Flex Container no Cross Axis**.

Ela é parecida com `align-items`, mas existe uma diferença **muito importante**:

> **`align-items` alinha os itens dentro de uma linha.**
> **`align-content` distribui as linhas/colunas do Flex Container.**

Por isso, `align-content` normalmente só apresenta efeito quando:

```css
flex-wrap: wrap;
```

está sendo utilizado e existem **duas ou mais linhas/colunas**.

------

#### 1. Antes de entender `align-content`

Imagine este container:

```css
.container {
    display: flex;
    flex-wrap: wrap;
}
```

Temos vários itens:

```text
┌──────────────────────────────────┐
│ [1] [2] [3] [4]                 │
│ [5] [6] [7] [8]                 │
│ [9] [10]                         │
└──────────────────────────────────┘
```

Aqui temos **três linhas de Flex Items**.

O `align-content` controla **como essas linhas serão distribuídas dentro do container**.

------

#### 2. `align-content: flex-start`

Coloca as linhas **no início do Cross Axis**.

```css
.container {
    display: flex;
    flex-wrap: wrap;
    align-content: flex-start;
}
```

Resultado:

```text
┌──────────────────────────────────┐
│ [1] [2] [3] [4]                 │
│ [5] [6] [7] [8]                 │
│ [9] [10]                        │
│                                  │
│                                  │
└──────────────────────────────────┘
```

As linhas ficam agrupadas no início.

Com `flex-direction: row`, o Cross Axis é vertical. Portanto, elas ficam no **topo**.

##### Memorize:

> `flex-start` → linhas no início do Cross Axis.

------

#### 3. `align-content: flex-end`

Coloca as linhas **no final do Cross Axis**.

```css
.container {
    display: flex;
    flex-wrap: wrap;
    align-content: flex-end;
}
```

Resultado:

```text
┌──────────────────────────────────┐
│                                  │
│                                  │
│ [1] [2] [3] [4]                 │
│ [5] [6] [7] [8]                 │
│ [9] [10]                        │
└──────────────────────────────────┘
```

Com `row`, as linhas ficam na parte inferior.

##### Memorize:

> `flex-end` → linhas no final do Cross Axis.

------

#### 4. `align-content: center`

Centraliza **o conjunto de linhas** no Cross Axis.

```css
.container {
    display: flex;
    flex-wrap: wrap;
    align-content: center;
}
```

Resultado:

```text
┌──────────────────────────────────┐
│                                  │
│ [1] [2] [3] [4]                 │
│ [5] [6] [7] [8]                 │
│ [9] [10]                        │
│                                  │
└──────────────────────────────────┘
```

Observe que não estamos centralizando cada item individualmente.

Estamos centralizando **as linhas como um conjunto**.

Essa diferença é muito importante.

------

#### 5. `align-content: space-between`

Distribui o espaço disponível **entre as linhas**, sem espaço nas extremidades.

```css
.container {
    display: flex;
    flex-wrap: wrap;
    align-content: space-between;
}
```

Resultado:

```text
┌──────────────────────────────────┐
│ [1] [2] [3] [4]                 │
│                                  │
│                                  │
│ [5] [6] [7] [8]                 │
│                                  │
│                                  │
│ [9] [10]                        │
└──────────────────────────────────┘
```

O espaço disponível é colocado **entre as linhas**.

É semelhante ao:

```css
justify-content: space-between;
```

mas existe uma diferença:

- `justify-content` → distribui os **itens** no Main Axis;
- `align-content` → distribui as **linhas/colunas** no Cross Axis.

------

#### 6. `align-content: space-around`

Distribui espaço **ao redor de cada linha**.

```css
.container {
    display: flex;
    flex-wrap: wrap;
    align-content: space-around;
}
```

Visualmente:

```text
┌──────────────────────────────────┐
│                                  │
│ [1] [2] [3] [4]                 │
│                                  │
│ [5] [6] [7] [8]                 │
│                                  │
│ [9] [10]                        │
│                                  │
└──────────────────────────────────┘
```

Existe espaço:

- antes da primeira linha;
- entre as linhas;
- depois da última linha.

Assim como acontece com `justify-content: space-around`, o espaço entre duas linhas acaba sendo maior que o espaço nas extremidades.

------

#### 7. `align-content: space-evenly`

Distribui o espaço de maneira **igual entre todas as linhas e também nas extremidades**.

```css
.container {
    display: flex;
    flex-wrap: wrap;
    align-content: space-evenly;
}
```

Resultado:

```text
┌──────────────────────────────────┐
│                                  │
│ [1] [2] [3] [4]                 │
│                                  │
│ [5] [6] [7] [8]                 │
│                                  │
│ [9] [10]                        │
│                                  │
└──────────────────────────────────┘
```

A ideia é:

```text
espaço
   ↓
linha 1
   ↓
mesmo espaço
   ↓
linha 2
   ↓
mesmo espaço
   ↓
linha 3
   ↓
mesmo espaço
```

Todos os espaços são iguais.

------

#### 8. `align-content` × `align-items`

Essa é provavelmente a parte **mais importante** para memorizar.

Imagine:

```text
┌──────────────────────────────┐
│ [1] [2] [3]                  │ ← Linha 1
│                              │
│ [4] [5] [6]                  │ ← Linha 2
│                              │
│ [7] [8] [9]                  │ ← Linha 3
└──────────────────────────────┘
```

##### `align-items`

Controla o alinhamento dos **itens dentro de cada linha**.

```text
Linha 1 → [1] [2] [3]
Linha 2 → [4] [5] [6]
Linha 3 → [7] [8] [9]
```

##### `align-content`

Controla a **distribuição das próprias linhas**:

```text
┌──────────────────────────────┐
│                              │
│ Linha 1                      │
│                              │
│ Linha 2                      │
│                              │
│ Linha 3                      │
│                              │
└──────────────────────────────┘
```

Uma maneira simples de memorizar:

> **`align-items` → itens**
> **`align-content` → conteúdo/linhas**

------

#### 9. `align-content` precisa de `flex-wrap`

Normalmente você verá:

```css
.container {
    display: flex;
    flex-wrap: wrap;
    align-content: center;
}
```

Isso acontece porque precisamos ter **múltiplas linhas ou colunas** para que `align-content` tenha algo para distribuir.

Por exemplo:

```css
flex-wrap: nowrap;
```

tem apenas uma linha:

```text
[1] [2] [3] [4] [5]
```

Nesse caso, `align-content` normalmente **não terá efeito perceptível**.

Com:

```css
flex-wrap: wrap;
```

podemos ter:

```text
[1] [2] [3]
[4] [5] [6]
[7] [8] [9]
```

Agora existem várias linhas, e `align-content` pode distribuí-las.

------

#### 10. Comparação dos valores

| Valor           | O que faz com as linhas        |
| --------------- | ------------------------------ |
| `flex-start`    | Coloca no início               |
| `flex-end`      | Coloca no final                |
| `center`        | Centraliza                     |
| `space-between` | Espaço somente entre as linhas |
| `space-around`  | Espaço ao redor das linhas     |
| `space-evenly`  | Espaços iguais entre tudo      |

------

#### 11. Uma comparação visual

Imagine três linhas:

```text
Linha 1
Linha 2
Linha 3
```

##### `flex-start`

```text
┌───────────────┐
│ Linha 1       │
│ Linha 2       │
│ Linha 3       │
│               │
│               │
└───────────────┘
```

##### `flex-end`

```text
┌───────────────┐
│               │
│               │
│ Linha 1       │
│ Linha 2       │
│ Linha 3       │
└───────────────┘
```

##### `center`

```text
┌───────────────┐
│               │
│ Linha 1       │
│ Linha 2       │
│ Linha 3       │
│               │
└───────────────┘
```

##### `space-between`

```text
┌───────────────┐
│ Linha 1       │
│               │
│ Linha 2       │
│               │
│ Linha 3       │
└───────────────┘
```

Não há espaço extra nas extremidades.

##### `space-around`

```text
┌───────────────┐
│               │
│ Linha 1       │
│               │
│ Linha 2       │
│               │
│ Linha 3       │
│               │
└───────────────┘
```

Existe espaço ao redor das linhas.

##### `space-evenly`

```text
┌───────────────┐
│               │
│ Linha 1       │
│               │
│ Linha 2       │
│               │
│ Linha 3       │
│               │
└───────────────┘
```

Todos os espaços são iguais.

------

#### 🧠 Resumo para memorizar

```text
align-content
       ↓
Distribui as LINHAS/COLUNAS
       ↓
      Cross Axis
```

Valores:

```text
flex-start    → início
flex-end      → final
center        → centro
space-between → espaço entre
space-around  → espaço ao redor
space-evenly  → espaços iguais
```

E a diferença fundamental:

```text
┌─────────────────────────────────────┐
│ align-items                         │
│ → alinha os ITENS dentro das linhas│
│                                     │
│ align-content                       │
│ → distribui as LINHAS do container  │
└─────────────────────────────────────┘
```

**Regra de ouro:**

> `align-items` trabalha com os **itens**.
> `align-content` trabalha com o **conjunto de linhas/colunas**.

---

#### Arquivo completo - 2_alinhamento.html

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
        h2 {
            color: white;
            text-align: center;
        }
        .container-flex {
            width: 250px;
            height: 400px;
            border: 4px solid red;
            display: flex;
            flex-direction: row;
            /* justify-content: flex-start, flex-end, center, space-between, space-around e space-evenly*/
            justify-content: center;
            /* align-items: stretch, flex-start, flex-end, center, baseline */
            align-items: center;
            /* align-content: flex-start, flex-end, center, space-between, space-around e space-evenly*/
            flex-wrap: wrap;
            align-content: space-evenly;
        }
        .container-flex > div {
            font-size: 2em;
            color: white;
            border: 4px solid white;
            padding: 4px;
            margin: 4px;
        }
        .texto-grande {
            font-size: 3em;
        }
        .coluna {
            flex-direction: column;
        }
    </style>
</head>
<body>
    <h1>Alinhamentos</h1>

    <h2>Row</h2>
    <div class="container-flex">
        <div>01</div>
        <div class="texto-grande">02</div>
        <div>03</div>
        <div>04</div>
        <div>05</div>
        <div>06</div>
        <div>07</div>
        <div>08</div>
        <div>09</div>
        <div>10</div>
    </div>

    <h2>Column</h2>
    <div class="container-flex coluna">
        <div>01</div>
        <div class="texto-grande">02</div>
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



### 110. Align Self

A propriedade `align-self` é usada para **alterar o alinhamento de um Flex Item individualmente no Cross Axis**.

Essa é a principal diferença em relação ao `align-items`:

> **`align-items` → controla todos os itens do container.**
> **`align-self` → controla um item específico.**

------

#### 1. Entendendo a diferença

Imagine este Flex Container:

```css
.container {
    display: flex;
    align-items: center;
}
```

Temos:

```text
┌──────────────────────────────────┐
│                                  │
│  [Item 1] [Item 2] [Item 3]     │
│                                  │
└──────────────────────────────────┘
```

O `align-items: center` centraliza **todos os itens** no Cross Axis.

Mas podemos alterar apenas um deles:

```css
.item2 {
    align-self: flex-start;
}
```

Agora:

```text
┌──────────────────────────────────┐
│  [Item 2]                        │
│                                  │
│  [Item 1]        [Item 3]       │
│                                  │
└──────────────────────────────────┘
```

O `Item 1` e o `Item 3` continuam seguindo o `align-items: center`.

O `Item 2` possui seu próprio alinhamento.

------

#### 2. `align-self: flex-start`

Coloca **aquele item específico** no início do Cross Axis.

```css
.item {
    align-self: flex-start;
}
```

Com:

```css
flex-direction: row;
```

o Cross Axis é vertical:

```text
┌──────────────────────────────────┐
│ [Item 2]                         │
│                                  │
│ [Item 1]        [Item 3]       │
│                                  │
└──────────────────────────────────┘
```

O `Item 2` foi para o início do Cross Axis, enquanto os outros podem continuar centralizados.

##### Memorize:

> `flex-start` → item no **início** do Cross Axis.

------

#### 3. `align-self: flex-end`

Coloca o item específico no **final do Cross Axis**.

```css
.item {
    align-self: flex-end;
}
```

Resultado:

```text
┌──────────────────────────────────┐
│                                  │
│ [Item 1]        [Item 3]        │
│                                  │
│                  [Item 2]        │
└──────────────────────────────────┘
```

Com `flex-direction: row`, isso significa colocar o item na parte inferior.

##### Memorize:

> `flex-end` → item no **final** do Cross Axis.

------

#### 4. `align-self: center`

Centraliza o item específico no Cross Axis.

```css
.item {
    align-self: center;
}
```

Por exemplo:

```css
.container {
    display: flex;
    align-items: flex-start;
}

.item2 {
    align-self: center;
}
```

Resultado:

```text
┌──────────────────────────────────┐
│ [Item 1]                         │
│                                  │
│          [Item 2]                │
│                                  │
│ [Item 3]                         │
└──────────────────────────────────┘
```

O `Item 1` e o `Item 3` estão no início, enquanto o `Item 2` foi individualmente centralizado.

##### Memorize:

> `center` → item no **centro** do Cross Axis.

------

#### 5. `align-self: baseline`

Alinha o item individual de acordo com a **linha de base do conteúdo**.

```css
.item {
    align-self: baseline;
}
```

É especialmente útil quando temos elementos com textos de tamanhos diferentes.

Por exemplo:

```html
<div class="container">
    <span>Texto</span>
    <h1>Título</h1>
    <span>Outro texto</span>
</div>
```

Podemos utilizar:

```css
.container {
    display: flex;
}

.item {
    align-self: baseline;
}
```

A ideia é alinhar a base dos conteúdos:

```text
Texto pequeno     TÍTULO     Texto
────────────      ──────     ─────
          ↑
      baseline
```

Isso pode ser útil em layouts que misturam diferentes tamanhos de texto, números ou elementos tipográficos.

------

#### 6. `align-self` × `align-items`

Essa comparação é fundamental:

##### `align-items`

É definido no **Flex Container**:

```css
.container {
    display: flex;
    align-items: center;
}
```

Afeta os **itens como grupo**:

```text
       ↓ todos seguem center

[Item 1] [Item 2] [Item 3]
```

------

##### `align-self`

É definido no **Flex Item**:

```css
.item2 {
    align-self: flex-start;
}
```

Afeta **somente aquele item**:

```text
[Item 2]

        [Item 1] [Item 3]
```

Portanto:

> **`align-items` define a regra geral.**
> **`align-self` permite criar uma exceção para um item.**

------

#### 7. Exemplo completo

HTML:

```html
<div class="container">
    <div class="item item1">Item 1</div>
    <div class="item item2">Item 2</div>
    <div class="item item3">Item 3</div>
</div>
```

CSS:

```css
.container {
    display: flex;
    height: 300px;
    align-items: center;
}

.item2 {
    align-self: flex-start;
}

.item3 {
    align-self: flex-end;
}
```

Resultado aproximado:

```text
┌───────────────────────────────┐
│          Item 2              │
│                               │
│  Item 1                       │
│                               │
│                         Item 3│
└───────────────────────────────┘
```

Temos:

```text
Container
│
├── align-items: center
│       ↓
│   regra geral
│
├── Item 1 → center
│
├── Item 2 → flex-start
│
└── Item 3 → flex-end
```

------

#### 8. E o `stretch`?

Embora você tenha perguntado especificamente sobre `flex-start`, `flex-end`, `baseline` e `center`, é importante saber que `align-self` também aceita:

```css
align-self: stretch;
```

E também:

```css
align-self: auto;
```

`auto` é o valor padrão e, normalmente, faz o item seguir o valor definido por `align-items` no container.

Por exemplo:

```css
.container {
    align-items: center;
}

.item {
    align-self: auto;
}
```

O item seguirá o `align-items: center`.

------

#### 🧠 Resumo

```text
align-self
     ↓
Controla UM Flex Item
     ↓
     Cross Axis
```

Principais valores:

| Valor        | Função                             |
| ------------ | ---------------------------------- |
| `flex-start` | Início do Cross Axis               |
| `flex-end`   | Final do Cross Axis                |
| `center`     | Centro do Cross Axis               |
| `baseline`   | Alinha pela linha de base          |
| `stretch`    | Estica no Cross Axis               |
| `auto`       | Segue o `align-items` do container |

#### Regra para memorizar

> **`align-items` = todos os itens**
> **`align-self` = um item específico**

E lembre-se:

> **`align-self` sempre trabalha no Cross Axis.**

---

#### Arquivo completo - 3_align-self.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Align Self</title>
    <style>
        body {
            background-color: black;
        }
        h2 {
            color: white;
        }
        .container-flex {
            width: 250px;
            height: 200px;
            border: 4px solid red;
            display: flex;
            flex-direction: row;
            justify-content: center;
            align-items: flex-end;
        }
        .container-flex > div {
            font-size: 2em;
            color: white;
            border: 4px solid white;
            padding: 4px;
            margin: 4px;
        }
        
        .coluna {
            flex-direction: column;
        }

        /* align-self: flex-start, flex-end, baseline, center */
        .item {
            align-self: flex-start;
        }
    </style>
</head>
<body>
    <h1>Alinhamentos</h1>

    <h2>Row</h2>
    <div class="container-flex">
        <div>01</div>
        <div class="item">02</div>
        <div>03</div>
    </div>

    <h2>Column</h2>
    <div class="container-flex coluna">
        <div>01</div>
        <div class="item">02</div>
        <div>03</div>
        
    </div>
</body>
</html>
```



---

---



### 111. Flex Basis





### 112. Flex Grow115. Order

### 113. Flex Shrink

### 114. Flex

### 115. Order