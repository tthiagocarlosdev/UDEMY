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

### 105. Display Flex

### 106. Flex Direction, Flex Wrap e Flex Flow

### 107. Alinhamentos: Justify Content

### 108. Alinhamentos: Align Items

### 109. Alinhamentos: Align Content

### 110. Align Self

### 111. Flex Basis

### 112. Flex Grow115. Order

### 113. Flex Shrink

### 114. Flex

### 115. Order