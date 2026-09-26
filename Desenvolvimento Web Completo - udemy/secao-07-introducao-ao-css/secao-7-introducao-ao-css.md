# Desenvolvimento Web Completo

## Professor Hamilton Damasceno

## Seção 7: Introdução ao CSS

### 40. Por que precisamos de CSS?

#### O que é CSS?

##### CSS

**Cascading Style Sheets**

**Folhas de estilo em cascata**

- **Folhas**
- **Cascata**
- **Estilo**

---

##### O que é CSS?

A CSS permite criar regras que especificam como o conteúdo de um elemento deve aparecer.

Por exemplo, você pode especificar que o fundo da página seja azul ;)

---

##### CSS

Controla a aparência do seu site.

**Estrutura → Aparência → Interatividade**O que é CSS?



-----

-----



### 41. Entendendo conceitos importantes

> Pense dentro da caixa ;)

---

#### Página HTML básica

Uma página HTML básica possui elementos como:

```html
<h1> ... </h1>

<body>
</body>

<p> ... </p>
<p> ... </p>
```

------

#### Formatações que podemos usar

#### Estilos de exemplos

##### CAIXAS

Podemos utilizar CSS para definir características das caixas dos elementos, como:

- Largura e altura
- Bordas
  - Cor
  - Espessura
  - Estilo
- Cores e imagens de fundo
- Posição na janela do navegador

##### TEXTO

Podemos modificar características do texto, como:

- Fonte
- Tamanho
- Cor
- Itálico
- Negrito
- Maiúsculas
- Etc.

------

#### Como a CSS funciona?

A CSS funciona associando **regras aos elementos HTML**.

Essas regras determinam como o conteúdo dos elementos especificados deve ser exibido.

Uma regra CSS contém duas partes:

- **Seletor**
- **Declaração**

------

#### Seletores CSS

Um exemplo de regra CSS:

```css
p {
    color: red;
}
```

##### Seletor

O **seletor** indica o elemento ao qual a regra se aplica.

No exemplo:

```css
p
```

O seletor indica que a regra será aplicada aos elementos `<p>`.

##### Declaração

A **declaração** indica como os elementos selecionados devem ser estilizados ou formatados.

No exemplo:

```css
{
    color: red;
}
```

------

#### Propriedades CSS

Uma regra CSS pode ser representada da seguinte forma:

```css
p {
    color: red;
}
```

Nesse exemplo temos:

- **Propriedade:** `color`
- **Valor:** `red`

##### Propriedade

As **propriedades** indicam os aspectos do elemento que desejamos alterar.

Exemplo:

```css
color
```

A propriedade `color` define a cor do texto.

##### Valor

Os **valores** especificam as configurações que queremos utilizar para as propriedades escolhidas.

Exemplo:

```css
red
```

O valor `red` determina que a cor será vermelha.

------

#### Exemplos de formatações

##### Largura

```css
width: 200px;
```

Define a largura do elemento como `200px`.

##### Borda

```css
border: 1px dotted orange;
```

Define uma borda:

- Espessura: `1px`
- Estilo: `dotted`
- Cor: `orange`

#### Cor de fundo

```css
background-color: orange;
```

Define a cor de fundo como `orange`.

##### Tamanho da fonte

```css
font-size: 25px;
```

Define o tamanho da fonte como `25px`.

##### Cor do texto

```css
color: brown;
```

Define a cor do texto como `brown`.

#### Código completo - pagina-principal.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Página principal</title>
    <style>

        h1 {
            border: 2px solid red;
            background-color: blue;
            color: white;
        }

        p {
            color: blueviolet;
        }

    </style>
</head>
<body>
    
    <h1>5 dicas para ser mais produtivo</h1>
    <p>
        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Repellendus nihil dicta, voluptates asperiores labore totam dolorum illo voluptas repellat ad quaerat repudiandae harum commodi itaque, praesentium recusandae sapiente! Maxime, doloribus!
    </p>

    <p>
        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Repellendus nihil dicta, voluptates asperiores labore totam dolorum illo voluptas repellat ad quaerat repudiandae harum commodi itaque, praesentium recusandae sapiente! Maxime, doloribus!
    </p>
</body>
</html>
```



-----

-----



### 42. Como adicionar e aplicar CSS

#### Formas de aplicar CSS

Existem **três formas principais de adicionar CSS a uma página HTML**:

1. **Inline CSS** — CSS na própria linha do elemento
2. **Internal CSS** — CSS dentro do próprio documento HTML
3. **External CSS** — CSS em um arquivo separado

A principal diferença entre elas é **onde as regras CSS são escritas**.

------

##### 1. Inline CSS — CSS na linha

O **Inline CSS** é aplicado diretamente no elemento HTML por meio do atributo `style`.

Nesse caso, a regra CSS fica **dentro da própria tag HTML**.

##### Características

- É aplicado diretamente a um elemento.
- Afeta somente aquele elemento.
- É útil quando queremos fazer uma alteração específica.
- Pode deixar o HTML difícil de organizar quando utilizado em grande quantidade.

Exemplo conceitual:

```html
<p style="color: red;">
    Texto vermelho
</p>
```

Nesse caso, a propriedade `color` foi aplicada diretamente ao elemento `<p>`.

##### Quando utilizar?

É mais adequado para **alterações muito específicas e pontuais**.

------

#### 2. Internal CSS — CSS Interna

O **Internal CSS** é escrito dentro do próprio documento HTML, normalmente no elemento `<head>`, utilizando a tag `<style>`.

Nesse caso, o CSS fica separado do conteúdo HTML, mas ainda está dentro do mesmo arquivo.

##### Características

- O CSS fica dentro do arquivo HTML.
- Pode aplicar uma mesma regra a vários elementos da página.
- É mais organizado do que utilizar vários estilos inline.
- As regras ficam disponíveis somente para aquela página HTML.

Exemplo conceitual:

```html
<head>
    <style>
        p {
            color: red;
        }
    </style>
</head>
```

Nesse caso, todos os elementos `<p>` que forem afetados pelo seletor receberão a regra definida.

##### Quando utilizar?

É interessante quando temos uma página específica que possui estilos próprios e não há necessidade de compartilhar esses estilos com outras páginas.

------

#### 3. External CSS — CSS Externa

O **External CSS** é quando as regras CSS ficam armazenadas em um **arquivo separado**, normalmente com a extensão `.css`.

O arquivo HTML faz referência a esse arquivo externo.

Por exemplo, podemos ter:

```text
index.html
style.css
```

O arquivo `style.css` contém as regras de estilo, enquanto o HTML contém a estrutura da página.

##### Características

- O CSS fica separado do HTML.
- Facilita a organização do projeto.
- Um mesmo arquivo CSS pode ser utilizado por várias páginas.
- Facilita a manutenção do site.
- É a abordagem mais utilizada em projetos maiores.

Exemplo conceitual:

**Arquivo `style.css`:**

```css
p {
    color: red;
}
```

**Arquivo HTML:**

```html
<link rel="stylesheet" href="style.css">
```

A tag `<link>` estabelece a ligação entre o documento HTML e o arquivo CSS externo.

##### Quando utilizar?

É a opção mais adequada quando o projeto possui **várias páginas ou uma quantidade maior de estilos**, pois permite centralizar as regras CSS em um único arquivo ou em arquivos organizados.

------

#### Comparação

| Tipo         | Onde fica o CSS?        | Alcance               | Organização |
| ------------ | ----------------------- | --------------------- | ----------- |
| **Inline**   | Dentro do elemento HTML | Elemento específico   | Baixa       |
| **Internal** | Dentro da tag `<style>` | Página HTML           | Média       |
| **External** | Arquivo `.css` separado | Uma ou várias páginas | Alta        |

#### Resumindo

**Inline:**

> CSS diretamente no elemento.

**Internal:**

> CSS dentro do próprio arquivo HTML.

**External:**

> CSS em um arquivo separado.

Em projetos reais, o **External CSS** geralmente é a melhor opção para manter o código organizado, reutilizável e fácil de manter.



#### Arquivo completo - index.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Página principal</title>

    <link rel="stylesheet" href="./css/estilo.css">

</head>
<body>
    
    <h1>Mercado Livre</h1>
    <a href="index.html">Home</a>
    <a href="produtos.html">Produtos</a>
    <a href="contato.html">Contato</a>

    <h2>Página inicial</h2>
    <p>
        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Repellendus nihil dicta, voluptates asperiores labore totam dolorum illo voluptas repellat ad quaerat repudiandae harum commodi itaque, praesentium recusandae sapiente! Maxime, doloribus!
    </p>

</body>
</html>
```

---

#### Arquivo completo - produtos.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Produtos</title>

    <link rel="stylesheet" href="./css/estilo.css">

    <style>
        p {
            color: orange;
        }
    </style>
</head>
<body>

    <h1>Mercado Livre</h1>
    <a href="index.html">Home</a>
    <a href="produtos.html">Produtos</a>
    <a href="contato.html">Contato</a>

    <h2>Produtos</h2>
    <p>
        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Repellendus nihil dicta, voluptates asperiores labore totam dolorum illo voluptas repellat ad quaerat repudiandae harum commodi itaque, praesentium recusandae sapiente! Maxime, doloribus!
    </p>
    <p>
        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Repellendus nihil dicta, voluptates asperiores labore totam dolorum illo voluptas repellat ad quaerat repudiandae harum commodi itaque, praesentium recusandae sapiente! Maxime, doloribus!
    </p>
    <hr>

    <h1>Exercício</h1>

    <ul>
        <li>Item 1</li>
        <li>Item 2</li>
        <li>Item 3</li>
    </ul>

    <table>
        <tr>
            <td>Item 1</td>
            <td>Item 2</td>
        </tr>
    </table>
</body>
</html>
```

#### Arquivo completo - contato.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Contato</title>
    <link rel="stylesheet" href="./css/estilo.css">
</head>
<body>
    <h1>Mercado Livre</h1>
    <a href="index.html">Home</a>
    <a href="produtos.html">Produtos</a>
    <a href="contato.html">Contato</a>

    <h2>Contato</h2>
    <p>
        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Repellendus nihil dicta, voluptates asperiores labore totam dolorum illo voluptas repellat ad quaerat repudiandae harum commodi itaque, praesentium recusandae sapiente! Maxime, doloribus!
    </p>
</body>
</html>
```

#### Arquivo completo -  estilo.css

```css
h2 {
    color: blue;
}

a {
    color: darkgreen;
}

p {
    color: orange;
}

li {
    background-color:deepskyblue ;
    border: 1px solid blue;
}

table {
    background-color: orange;
    border: 5px solid darkred;
}

td {
    border: 3px solid black;
}
```

---

#### Links da aula

[Flextool](https://www.flextool.com.br/tabela-de-cores) - Tabelas de cores CSS



-----

-----

-----


