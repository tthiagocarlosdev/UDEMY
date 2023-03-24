# Curso Web Design Completo: HTML5, CSS3 e JS + 5 Projetos
[link do curso](https://www.udemy.com/course/curso-web-design-fundamentos-aprenda-html-css-e-javascript/)

## Seção 1: Introdução

### 1. Apresentação

### 2. LEIA ANTES DE CONTINUAR

### 3. Interaja com outros alunos

### 4. Introdução

1982 ... Padrão de publicação e distribuição de textos científicos e acadêmicos

__URL__ - Localizador de recursos

__HTTP__ - Protocolo de transferência de Hipertexto

__HTML__ - Linguagem de marcação de texto. Não é linguagem de progrmação.

__O que é um arquivo HTML?__ Um arquivo HTML é apenas um arquivo de texto com marcações HTML que dão significado ao conteúdo.

O que é uma página vs O que é um site.

Página é um arquivo HTML, um site é uma pasta com vários arquivos HTML.

### 5. Primeiro HTML

```html
<h1> primeiro teste </h1>
<h2> subtítulo </h2>
<p> primeiro parágrafo </p>
<p> segundo parágrafo </p>
```

### 6. Atualização - Migrar do Brackts para VSCode

### 7. Migrando de Brackets para VSCode - mais informações

### 8. Algumas Tags principais

__Tags HTML__ - Dando significado ao conteúdo.

__Tags Aninhadas__ - Sinal de atenção

```html
<p>Lorem ipsum <i> dolor </i> sit amet.</p>
```

Níveis de títulos:

```html
<h1> meu título </h1>
<h2> meu título </h2>
<h3> meu título </h3>
<h4> meu título </h4>
<h5> meu título </h5>
<h6> meu título </h6>
```

Ênfase em textos:

```html
<i> itálico </i>
<b> negrito </b>
<em> itálico semântico </em>
<strong> negrito semântico </strong>
```

Listas não ordenadas

```html
<ul>
    <li> ... </li>
    <li> ... </li>
    <li> ... </li>
</ul>
```

Lista ordenada

```html
<ol>
    <li> ... </li>
    <li> ... </li>
    <li> ... </li>
</ol>
```

Links

```html
<p> Texto com <a>link</a> aqui </p>
```

```html
<p> saiba mais sobre <a>HTML5</a> visitando nosso blogo e seja feliz </p>
```

Atributo

```html
<tag atributo="valor"> texto aqui </tag>
```

```html
<p> saiba mais sobre <a href="http://www....com.br" >HTML5</a> visitando nosso blogo e seja feliz </p>
```

```html
<p> saiba mais sobre <a href="http://www....com.br" target="_blank" >HTML5</a> visitando nosso blogo e seja feliz </p>
```

Tipos de Links

```html
<a href="http://www....com.br" ></a>
<a href="outraPagina.html" ></a>
<a href="#secao" ></a>
<a href="mailto:alguem@server.com" ></a>
```

Quebras de linha

```html
<br>
<hr>
```

### 9. Principais tags - mão na massa

```html
<h1> Título head 1 </h1>
<h2> Título head 2 </h2>
<h3> Título head 3 </h3>
<h4> Título head 4 </h4>
<h5> Título head 5 </h5>
<h6> Título head 6 </h6>

<p>meu paragrafo com link para o <a href="./01_teste.html" target="_blank">primeiro exercicio </a> e uma <a href="http://www.google.com.br" target="_blank">pagina externa</a> </p>

<hr>

<ul>
    <li>item de lista</li>
    <li>item com <b>negrito</b> </li>
    <li> item com <a href="./02_tags.html">link</a> </li>
</ul>

<ol>
    <li>primeiro item</li>
    <li>segundo item</li>
</ol>

<p>O <strong>html5</strong> é uma linguagem de marcação para criar páginas na web. Você <b>deve</b> semrpe utiliar a extensão .html</p>

<p>O <em>html5</em> é uma linguagem de marcação para criar páginas na web. Você <i>deve</i> semrpe utiliar a extensão .html</p>
```

### 10. Correção do exercício

```html
<h1> Currículo Vitae </h1>
<hr>
<p><b> Nome: </b> Thiago Carlos Limeira da Silva </p>
<p><b> Objetivo: </b> Webdesigner </p>
<hr>
<h2> Qualificações Profissionais </h2>
<ul>
    <li> Conhecimento básico de windows </li>
    <li> Curso de Datilografia </li>
</ul>
<p><a href="./01_teste.html"> ver primeiro arquivo criado </a></p>
```

### 11. Estrutura base - teoria

- #### Estrutura semântica básica

```html
<html lang="pt-br">
    <head>
        <title> título da página </title>
        <meta tags>
        <link para arquivos externos >
    </head>
    <body>
        <!-- conteúdo da página -->
        <h1> título da página</h1>
        <p> texto </p>
        <ul>
            <li> item de lista </li>
        </ul>
    </body>
</html>
```

- #### Doctype - Maneira de informar para o browser que tipo de documento estou escrevendo

```html
<!doctype html>
```

- #### charset - indica o tipo de codificação de caractere

```html
<meta charset="utf-8">
```

- #### Imagens, arquivos externos e links

```html
<a>
    href
    title
<link>
    href
    rel
<img>
    src
    alt
<script>
    src
```



### 12. Estrutura base - mão na massa

```html
<!doctype html>
<!-- doctype informa ao agnte de usuario a versão do html que deve ser renderizada -->
<html lang="pt-br">
    <head>
        <title> pagina de exemplo estrutura basica </title>
        <meta charset="utf-8">
        <meta name="author" content="Daniel">
        <meta name="description" content="lista de documentos">
        <meta name="keywords" content="html5, tecnologia">
    </head>
    <body>
        <h1>estrutura basica</h1>
    </body>
</html>
```

### 13. Para que servem as Metatags?

## Seção 2: Introdução ao CSS

### 14. As Folhas de estilo em cascata

CSS - cascating style sheets

- #### Sintaxe

```css
seletor { propriedade: valor; }
h1{
    color: red;
    font-size: 16px;
}
```

- #### Como incluir

  - Inline

  ```html
  <p style="..." > ... </p>
  ```

  - Interno

  ```html
  <style> ... </style>
  ```

  - Externo

  ```html
  <link href=".css" rel="stylesheet" >
  ```

- #### Seletores de elemento

HTML

```html
<p> ... </p>
```

CSS

```css
p { ... }
```

- #### Seletores de classes

HTML

```html
<p class="minha_classe"> ... </p>
```

CSS

```css
.minha_classe { ... }
```

- #### Seletores de id

HTML

```html
<p id="meu_id"> ... </p>
```

CSS

```css
#meu_id { ... }
```

Obs.: O id é único, deve aparecer apenas uma vez na página, ao contrário da class.

- #### fonts

  - font-family
  - font-size
  - font-style
  - font-variant

- #### text

  - text-align
  - text-decoration
  - text-ident
  - text-transform

- #### RGB

  - Red light
  - Blue light
  - Green light
  - color
  - background-color

### 15. Primeiras regras de CSS

```html
<!doctype html>
<!-- doctype informa ao agnte de usuario a versão do html que deve ser renderizada -->
<html lang="pt-br">
    <head>
        <title> pagina de exemplo estrutura basica </title>
        <meta charset="utf-8">
        <meta name="author" content="Daniel">
        <meta name="description" content="lista de documentos">
        <meta name="keywords" content="html5, tecnologia">
        
        <style>
            body{
                background-color: #ccc;
            }

            h1{
                font-family: 'Courier New', Courier, monospace;
                font-size: 48px;
                font-style: normal;
                font-variant: small-caps;
                color:#00ff00;
            }

            h2{
                text-transform: uppercase;
                font-family: 'Courier New', Courier, monospace;
                color: #0000ff;
                background-color: coral;
            }

            p{
                font-variant: normal;
                text-align: justify;
                text-decoration: underline;
                text-indent: 50px;
                text-transform: none;;
            }
        </style>
    </head>
    <body>
        <h1>estrutura basica</h1>
        <h2>subtitulo da pagina</h2>

        <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Voluptate placeat consequatur tempora delectus, natus ipsum earum quam vero qui animi.</p>
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, culpa, voluptatibus cum fugiat mollitia id facere nostrum dolorem recusandae sapiente eum voluptates quae, officiis natus odio laudantium. Dolore, aliquam officia?</p>
        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Nam ullam provident iure cum quisquam. Quos minus officia totam nemo odit perspiciatis. Quasi rem minus accusantium ducimus blanditiis sapiente, quibusdam adipisci placeat quod obcaecati numquam nulla et sunt cumque nemo id.</p>
    </body>
</html>
```

### 16.  Adicionando classes

```html
<!doctype html>
<!-- doctype informa ao agnte de usuario a versão do html que deve ser renderizada -->
<html lang="pt-br">
    <head>
        <title> pagina de exemplo estrutura basica </title>
        <meta charset="utf-8">
        <meta name="author" content="Daniel">
        <meta name="description" content="lista de documentos">
        <meta name="keywords" content="html5, tecnologia">
        
        <style>
            body{
                background-color: #ccc;
            }

            h1{
                font-family: 'Courier New', Courier, monospace;
                font-size: 48px;
                font-style: normal;
                font-variant: small-caps;
                color:#00ff00;
            }

            h2{
                text-transform: uppercase;
                font-family: 'Courier New', Courier, monospace;
                color: #0000ff;
                background-color: coral;
            }

            p{
                font-variant: normal;
                text-align: justify;
                text-decoration: underline;
                text-indent: 50px;
                text-transform: none;;
            }

            #destaque{
                color: red;
                background-color: yellow;
            }

            .destaque{
                color:#0000ff;
                background-color:#00ff00;
            }

        </style>
    </head>
    <body>
        <h1>estrutura basica</h1>
        <h2>subtitulo da pagina</h2>

        <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Voluptate placeat consequatur tempora delectus, natus ipsum earum quam vero qui animi.</p>
        <p class="destaque">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, culpa, voluptatibus cum fugiat mollitia id facere nostrum dolorem recusandae sapiente eum voluptates quae, officiis natus odio laudantium. Dolore, aliquam officia?</p>
        <p id="destaque">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Nam ullam provident iure cum quisquam. Quos minus officia totam nemo odit perspiciatis. Quasi rem minus accusantium ducimus blanditiis sapiente, quibusdam adipisci placeat quod obcaecati numquam nulla et sunt cumque nemo id.</p>
        <p class="destaque">Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam ea eveniet ipsa sit necessitatibus fugiat officiis quisquam laborum? Quis, iure architecto? Iusto, eos laudantium? Mollitia, vero in asperiores odit atque officia. Doloremque quasi cupiditate voluptates adipisci iure explicabo tenetur tempora cum quibusdam omnis minima, aliquid facere sit vel dolorem. Aspernatur!</p>
    </body>
</html>
```

### 17.  Background ou background-color?

### 18. Box Model

- #### Modelo de caixa

```html
<!doctype html>
<!-- doctype informa ao agnte de usuario a versão do html que deve ser renderizada -->
<html lang="pt-br">
    <head>
        <title> pagina de exemplo estrutura basica </title>
        <meta charset="utf-8">
        <meta name="author" content="Daniel">
        <meta name="description" content="lista de documentos">
        <meta name="keywords" content="html5, tecnologia">
        
        <style>
            body{
                background-color: #ccc;
            }

            h1{
                font-family: 'Courier New', Courier, monospace;
                font-size: 48px;
                font-style: normal;
                font-variant: small-caps;
                color:#00ff00;
                background-color: yellow;
                margin-top: 50px;
                margin-left: 0;
                margin-bottom: 50px;
                padding-left: 25px;
                padding-top: 50px;
                padding-bottom: 50px;
                padding-right: 25px;
                width: 180px;
                height: 160px;
            }

            h2{
                text-transform: uppercase;
                font-family: 'Courier New', Courier, monospace;
                color: #0000ff;
                border-bottom-color: red;
                border-bottom-style: dotted;
                border-bottom-width: 5px;
                padding: 25px;
            }

            p{
                font-variant: normal;
                text-align: justify;
                text-decoration: underline;
                text-indent: 50px;
                text-transform: none;
                margin-bottom: 30px;
            }

            #destaque{
                color: red;
                background-color: yellow;
            }

            .destaque{
                color:#0000ff;
                background-color:#00ff00;
            }

        </style>
    </head>
    <body>
        <h1>estrutura basica</h1>
        <h2>subtitulo da pagina</h2>

        <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Voluptate placeat consequatur tempora delectus, natus ipsum earum quam vero qui animi.</p>
        <p class="destaque">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, culpa, voluptatibus cum fugiat mollitia id facere nostrum dolorem recusandae sapiente eum voluptates quae, officiis natus odio laudantium. Dolore, aliquam officia?</p>
        <p id="destaque">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Nam ullam provident iure cum quisquam. Quos minus officia totam nemo odit perspiciatis. Quasi rem minus accusantium ducimus blanditiis sapiente, quibusdam adipisci placeat quod obcaecati numquam nulla et sunt cumque nemo id.</p>
        <p class="destaque">Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam ea eveniet ipsa sit necessitatibus fugiat officiis quisquam laborum? Quis, iure architecto? Iusto, eos laudantium? Mollitia, vero in asperiores odit atque officia. Doloremque quasi cupiditate voluptates adipisci iure explicabo tenetur tempora cum quibusdam omnis minima, aliquid facere sit vel dolorem. Aspernatur!</p>
    </body>
</html>
```

### 19. Box-model - parte 2

```css
p{
    margin-top: 50px;
    margin-right: 40px
    margin-bottom: 30px;
    margin-left: 20px;
}

p{ maring: 50px 40px 30px 20px; }
```

```css
p{
    padding-top: 50px;
    padding-right: 40px
    padding-bottom: 30px;
    padding-left: 20px;
}

p{ padding: 50px 40px 30px 20px; }
```

- #### Abreviando margin/padding

A primeira forma equivale a segunda forma:

```css
p{ margin: 50px 40px 30px; }
```

```css
p{ margin: 50px 40px 30px 40px; }
```

A primeira forma equivale a segunda forma:

```css
p{ margin: 50px 40px; }
```

```css
p{ margin: 50px 40px 50px 40px; }
```

A primeira forma equivale a segunda forma:

```css
p{ margin: 50px; }
```

```css
p{ margin: 50px 50px 50px 50px; }
```

- #### border

```css
h1{
    border-style: dotted;
    border-width: 5px;
    border-color: red;
}
```

```css
h1{ border: dotted 5px red; }
```

```css
h1{
    border-top-style: solid;
    border-right-width: 5px;
    border-bottom-color: red;
    border-left-color: #FF00FF;
}
```

```css
h1{ border-top: solid 10px blue; }
```

### 20. Pseudo-classes e list-style

- #### Pseudo-classes

```css
a:link{ ... }
a:visited{ ... }
a:hover{ ... }
a:active{ ... }
```

- #### list-style

```css
list-style-type
list-style-position
list-style-image
```

### 21. Praticando

```html
<!doctype html>
<!-- doctype informa ao agnte de usuario a versão do html que deve ser renderizada -->
<html lang="pt-br">
    <head>
        <title> pagina de exemplo estrutura basica </title>
        <meta charset="utf-8">
        <meta name="author" content="Daniel">
        <meta name="description" content="lista de documentos">
        <meta name="keywords" content="html5, tecnologia">
        <style>
            body {
                font-family: sans-serif;
                color: green;
            }
            a{
                color: green;
            }
            a:hover{
                background-color: rgba(238, 255, 0, 0.634);
            }
            a:link{
                color: green;
            }
            a:active{
                color:orange;
            }

            ul li{
                list-style-type:circle;
            }
            ol li{
                list-style-type: lower-latin;
                list-style-position: inside;
            }
        </style>
    </head>
    <body>
        <a href="./01_teste.html">veja o arquivo 01 teste.html </a> | 
        <a href="./02_tags.html"> veja o segundo arquivo</a>
        <ul>
            <li> item 1</li>
            <li> item 2</li>
            <li> item 3</li>
        </ul>

        <ol>
            <li> item 1</li>
            <li> item 2</li>
            <li> item 3</li>
        </ol>

        <p>paragrafo 1</p>
    </body>
</html>
```

### 22. Exercício. Centralizar na tela



### 23.Exercício. HTML















