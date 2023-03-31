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
                width: 80%;
                margin: auto;
            }
            h1{
                background-color: chocolate;
                text-align: center;
            }
            h2{
                background-color: orangered;
                border-bottom: 2px solid black;
            }
            a{
                list-style-type: none;
            }
        </style>
    </head>
    <body>
        <h1>Lorem, ipsum dolor.</h1>
        <p>Lorem ipsum dolor sit.</p>
        
        <h2>Lorem</h2>
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing.</p>
        
        <h2>Lorem, ipsum.</h2>
        
        <p><a href="http://uol.com.br"><strong>UOL</strong></a> <b> - 03/2018 até 11/2019 - 18 meses</b></p>
        <p><strong>Lorem, ipsum - 2 meses </strong></p>
        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis dolorum eos ratione placeat?</p>
        
        <p><a href="http://terra.com.br"><strong>TERRA</strong></a><b> - 1 ano</b></p>
        <p><strong>Lorem, ipsum dolor - 1 ano</strong></p>
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eum est quod sequi maiores temporibus ipsam, inventore tenetur provident, officia tempora doloremque vero id! Facilis, labore! Natus hic aspernatur ab iure.</p>
        
        <p><a href="http://g1.com.br"> <strong>G1</strong></a><b> - 6 meses</b></p>
        <p><strong>Lorem, ipsum dolor - 6 meses</strong></p>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Nobis fuga ducimus sapiente deleniti nulla beatae explicabo ipsa sed repellat repellendus!</p>
        
        <h2>Lorem</h2>
        <h3>Lorem ipsum dolor sit amet.</h3>
        <p>12/2019 a 07/2022</p>
        <p>Lorem, ipsum dolor.</p>
        <h3>Lorem ipsum dolor sit amet consectetur adipisicing elit. Repudiandae!</h3>
        <p>08/2022 a 03/2023</p>
        <p>Lorem, ipsum dolor.</p>
        
        <h2>Lorem / Ipsum</h2>
        <ul>
            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Provident, eos.</li>
            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Molestias, mollitia.</li>
        </ul>
        <h3>HTML5</h3>
        <p>lorem - 40h - 2018</p>
        <h3>Javascript</h3>
        <p>lorem - 40h - 2018</p>
        <h3>CSS3</h3>
        <p>lorem - 40h - 2018</p>
        <h3>Idiomas</h3>
        <p>Inglês: básico</p>
    </body>
</html>
```

### 23.Exercício. HTML

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
        <h1>Lorem, ipsum dolor.</h1>
        <p>Lorem ipsum dolor sit.</p>
        
        <h2>Lorem</h2>
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing.</p>
        
        <h2>Lorem, ipsum.</h2>
        
        <h3><a href="http://uol.com.br">UOL</a> - 03/2018 até 11/2019 - 18 meses</h3>
        <h4>Lorem, ipsum - 2 meses</h4>
        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis dolorum eos ratione placeat?</p>
        
        <h3><a href="http://terra.com.br">TERRA</a> - 1 ano</h3>
        <p><strong>Lorem, ipsum dolor - 1 ano</strong></p>
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eum est quod sequi maiores temporibus ipsam, inventore tenetur provident, officia tempora doloremque vero id! Facilis, labore! Natus hic aspernatur ab iure.</p>
        
        <h3><a href="http://g1.com.br"> G1</a> - 6 meses</h3>
        <h4>Lorem, ipsum dolor - 6 meses</h4>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Nobis fuga ducimus sapiente deleniti nulla beatae explicabo ipsa sed repellat repellendus!</p>
        
        <h2>Lorem</h2>
        <h3>Lorem ipsum dolor sit amet.</h3>
        <p>12/2019 a 07/2022</p>
        <p>Lorem, ipsum dolor.</p>
        <h3>Lorem ipsum dolor sit amet consectetur adipisicing elit. Repudiandae!</h3>
        <p>08/2022 a 03/2023</p>
        <p>Lorem, ipsum dolor.</p>
        
        <h2>Lorem / Ipsum</h2>
        <ul>
            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Provident, eos.</li>
            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Molestias, mollitia.</li>
        </ul>
        <h3>HTML5</h3>
        <p>lorem - 40h - 2018</p>
        <h3>Javascript</h3>
        <p>lorem - 40h - 2018</p>
        <h3>CSS3</h3>
        <p>lorem - 40h - 2018</p>
        <h3>Idiomas</h3>
        <p>Inglês: básico</p>
    </body>
</html>
```

### 24. Exercício. CSS

```html
<!doctype html>
<!-- doctype informa ao agnte de usuario a versão do html que deve ser renderizada -->
<html lang="pt-br">
    <head>
        <title> 07_curriculum </title>
        <meta charset="utf-8">
        <meta name="author" content="Daniel">
        <meta name="description" content="lista de documentos">
        <meta name="keywords" content="html5, tecnologia">

        <style>
            body{
                width: 80%;
                margin: auto;
                font-family: Verdana, Helvetica, sans-serif;
                color: #444;
            }

            h1{
                background-color: chocolate;
                text-align: center;
                font-size: 46px;
                padding: 4px 0;
            }

            h2{
                background-color: orangered;
                border-bottom: 3px solid #444;
                font-size: 36px;
                padding: 8px;
            }

            ul{
                padding-left: 0;
            }

            li{
                list-style-position: inside;
            }

            a{
                text-decoration: none;
            }
            a:hover{
                text-decoration: underline;
            }
            
        </style>
    </head>
    <body>
        <h1>Lorem, ipsum dolor.</h1>
        <p>Lorem ipsum dolor sit.</p>
        
        <h2>Lorem</h2>
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing.</p>
        
        <h2>Lorem, ipsum.</h2>
        
        <h3><a href="http://uol.com.br" target="_blank">UOL</a> - 03/2018 até 11/2019 - 18 meses</h3>
        <h4>Lorem, ipsum - 2 meses</h4>
        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis dolorum eos ratione placeat?</p>
        
        <h3><a href="http://terra.com.br" target="_blank">TERRA</a> - 1 ano</h3>
        <p><strong>Lorem, ipsum dolor - 1 ano</strong></p>
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eum est quod sequi maiores temporibus ipsam, inventore tenetur provident, officia tempora doloremque vero id! Facilis, labore! Natus hic aspernatur ab iure.</p>
        
        <h3><a href="http://g1.com.br" target="_blank"> G1</a> - 6 meses</h3>
        <h4>Lorem, ipsum dolor - 6 meses</h4>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Nobis fuga ducimus sapiente deleniti nulla beatae explicabo ipsa sed repellat repellendus!</p>
        
        <h2>Lorem</h2>
        <h3>Lorem ipsum dolor sit amet.</h3>
        <p>12/2019 a 07/2022</p>
        <p>Lorem, ipsum dolor.</p>
        <h3>Lorem ipsum dolor sit amet consectetur adipisicing elit. Repudiandae!</h3>
        <p>08/2022 a 03/2023</p>
        <p>Lorem, ipsum dolor.</p>
        
        <h2>Lorem / Ipsum</h2>
        <ul>
            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Provident, eos.</li>
            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Molestias, mollitia.</li>
        </ul>
        <h3>HTML5</h3>
        <p>lorem - 40h - 2018</p>
        <h3>Javascript</h3>
        <p>lorem - 40h - 2018</p>
        <h3>CSS3</h3>
        <p>lorem - 40h - 2018</p>
        <h3>Idiomas</h3>
        <p>Inglês: básico</p>
    </body>
</html>
```

## Seção 3: Mais sobre o Visual - Parte 1

### 25. Trabalhando com imagens

- #### Duas formas para inserirmos imagens

  - HTML

  ```html
  <img src="..." alt="...">
  ```

  - CSS

  ```css
  background-image: url(...);
  ```

- #### Tipos de imagens

.jpg / .jpeg

.png

.gif

.svg

.webp

### 26. Trabalhando com imagens - mão na massa

```html
<!doctype html>
<!-- doctype informa ao agnte de usuario a versão do html que deve ser renderizada -->
<html lang="pt-br">
    <head>
        <title> 08_imagens </title>
        <meta charset="utf-8">
        <meta name="author" content="Daniel">
        <meta name="description" content="lista de documentos">
        <meta name="keywords" content="html5, tecnologia">
        <style>
            body{
                font-size: 22px;
                font-family: sans-serif;
                width: 700px;
                margin: auto;
                background-image: url(../images/bg.jpg);
                background-attachment: fixed;
                background-size: cover;
                background-repeat: repeat;
                background-position: right bottom;
            }

            p{
                line-height: 1.5;
            }

            .img_html{
                float:left;
            }
            .img_css{
                float: right;
            }


        </style>
    </head>
    <body>
        <h1>Incluir imagens</h1>
        <p><a href="https://www.lipsum.com/"> gerador de texto lorem ipsum</a></p>

        <img src="../images/html5.png" class="img_html" alt="logotipo HTML 5">

        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Sed temporibus dignissimos omnis quod delectus dolorem labore similique ut quidem amet quam esse nemo, molestiae adipisci, commodi dolorum! Laudantium laborum et quibusdam provident. Dolor itaque sunt reprehenderit dolore voluptatibus laboriosam sint vitae, ut voluptate nam aliquam eius! Dolores eius, ipsam nisi maiores non, corrupti earum expedita pariatur ipsum ipsa ut. Vel sit possimus animi sapiente cum optio unde maiores, aperiam asperiores ab totam consectetur iusto perferendis repellendus assumenda impedit ducimus, laborum voluptatibus modi eos necessitatibus quam eius corrupti! Inventore cum eos non. Et sunt porro velit magnam doloremque obcaecati quaerat ea.
        </p>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Qui incidunt velit, vel distinctio consequatur non accusantium fugiat numquam facere adipisci labore corrupti tenetur ex pariatur magnam obcaecati quia modi recusandae rerum blanditiis eius odio praesentium repellendus? Esse officiis eligendi voluptas sequi in vel quisquam nostrum debitis quam. Odio nisi odit esse placeat sit, vitae voluptate. Repellendus tempora aut fuga, doloribus et aliquam dolore alias iste dolorum laborum. Ducimus, ratione. Velit perspiciatis, eum reprehenderit expedita, optio sint recusandae illo quidem tempore molestiae laborum rem aliquid quae nesciunt consectetur? Aspernatur maxime iure, doloribus consectetur sed beatae ut voluptates, aliquam soluta repellat saepe sapiente nihil animi temporibus reiciendis laudantium atque! Dolorem dignissimos rerum, debitis quae autem iusto, impedit velit fugiat sequi dolores facere unde eos corporis qui at tenetur nostrum? Ipsum vel delectus quae itaque repellat porro dolorem adipisci vitae cupiditate consequuntur! Ab quia ullam labore. Repudiandae quas optio iusto delectus! Quibusdam, non.
        </p>
        <img src="../images/css3.png" class="img_css" alt="logotipo CSS">
        <p>
            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iure quod minus culpa temporibus accusantium obcaecati exercitationem ipsam, vero repellendus? Excepturi dicta, debitis impedit, nisi eveniet commodi doloremque sed id a porro consequuntur quasi modi. Minima optio eos exercitationem consectetur mollitia cum, debitis, et itaque voluptatem animi est. Voluptas itaque nam, ut recusandae nulla, doloribus voluptatibus sit provident cumque repudiandae excepturi, sint expedita deleniti distinctio voluptates ullam amet exercitationem quod reprehenderit officiis praesentium. Eius beatae odio voluptatum cupiditate sunt deserunt necessitatibus qui, libero in vel harum quo dolor nulla facilis consequatur tenetur deleniti, porro labore error tempore quod quos. Quam, dolor expedita! Itaque optio ex quibusdam id hic voluptates. Eaque quisquam quae illo nemo atque enim fugit odio provident vel ex.
        </p>
        <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Doloribus, eum nam. Eius quibusdam aliquam voluptate impedit ipsa saepe eos eligendi voluptatem pariatur animi quia earum, repudiandae ipsum et veritatis perferendis soluta minima iusto quaerat quod minus ex beatae ab dolorum! Aut qui, esse rerum debitis nulla, perferendis voluptatibus fuga sed dignissimos dicta, sint corrupti magni inventore non quibusdam mollitia illum ab voluptas dolor. Aliquam excepturi repellendus quasi rerum, exercitationem ex praesentium illum ad quos iste temporibus, libero veniam! Vitae, quam repellendus! Aperiam, nihil! Eveniet amet qui minima accusamus! Vero debitis earum vel dolore repellat vitae recusandae tempore aliquid delectus excepturi. Ipsam eaque totam quam. Itaque quisquam earum nihil voluptate amet doloribus quaerat eveniet veniam, reprehenderit dolorem suscipit, iure aspernatur, nostrum inventore accusamus minus aliquam sapiente fugit iusto ea voluptates repudiandae.
        </p>
        <p>
            Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dignissimos quaerat voluptates similique eveniet quidem cum et non enim. Vitae voluptatibus quod asperiores possimus dolorem iure ullam sed nemo qui aperiam porro accusamus, praesentium consequatur, temporibus dolor fugit, ex recusandae natus quos? Eaque suscipit obcaecati sapiente eligendi eveniet cupiditate optio natus ea aliquid animi quae possimus quibusdam, deleniti quod non nisi molestiae quam dolorum? Natus veniam quam voluptatem nostrum nulla quas iure, quia ab dignissimos nemo aut illo quaerat blanditiis esse? Temporibus consectetur non autem. Earum illo nihil enim facere doloremque, reprehenderit animi magni, doloribus eius, provident accusamus ratione nulla labore alias cumque commodi. Modi dicta ut ullam nam maxime ipsam!
        </p>

    </body>
</html>
```



### 27. Estruturando layouts com semântica

- #### Wireframe

```html
<div id="...">
    <div id="..."> </div>
    <div id="..."> </div>
    <div id="..."> </div>
    <div id="..."> </div>
</div>
```

- #### Adicionando Semântica

```html
<div id="...">
	<header> </header>
    <nav> </nav>
    <main> </main>
    <footer> </footer>
</div>
```

- #### Outras Tags Semânticas

```html
<section> </section>
<article> </article>
<aside> </aside>
```

- #### Tags Não Semânticas

```html
<div> </div>
<span> </span>
```



### 28. Projeto 1 - HTML

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
        <div id="principal">

            <header>

                <nav>
                    <ul>
                        <li><a href="index.html">Início</a></li>
                        <li><a href="#">Quem sou eu</a></li>
                        <li><a href="#">Contato</a></li>
                    </ul>
                </nav>

                <div>
                    <h1>Curso Web Fundamentos</h1>
                    <p>Aprenda HTML, CSS e Javascript</p>
                </div>

            </header>

            <main>

                <section>

                    <div class="card">
                        <img src="" alt="">
                        <p>Seletores</p>
                    </div>

                    <div class="card">
                        <img src="" alt="">
                        <p>Posicionamento</p>
                    </div>

                    <div class="card">
                        <img src="" alt="">
                        <p>Fontes e Ícones</p>
                    </div>

                </section>

                <section>

                    <article>

                        <header>
                            <h2>Título do Article</h2>
                        </header>

                        <p>
                            Paragrafo 1
                        </p>
                        <p>
                            Paragrafo 2
                        </p>

                    </article>
                </section>
            </main>

            <footer>

                <p>Copyright &copy; 2023</p>
            </footer>
            
        </div>
    </body>
</html>
```



### 29. Projeto 1 - CSS

```html
<!doctype html>
<!-- doctype informa ao agnte de usuario a versão do html que deve ser renderizada -->
<html lang="pt-br">
    <head>
        <title> index </title>
        <meta charset="utf-8">
        <meta name="author" content="Daniel">
        <meta name="description" content="lista de documentos">
        <meta name="keywords" content="html5, tecnologia">
        <link rel="stylesheet" href="./css/estilo.css">
    </head>
    <body>
        <div id="principal">

            <header class="hero">

                <nav>
                    <ul>
                        <li><a href="index.html">Início</a></li>
                        <li><a href="#">Quem sou eu</a></li>
                        <li><a href="#">Contato</a></li>
                    </ul>
                </nav>

                <div class="hero_content">
                    <h1>Curso Web Fundamentos</h1>
                    <p>Aprenda HTML, CSS e Javascript</p>
                </div>

            </header>

            <main class="main">

                <section class="content_section">

                    <div class="card">
                        <img src="./imagens/card_01.png" alt="">
                        <p>Seletores</p>
                    </div>

                    <div class="card">
                        <img src="./imagens/card_02.jpg" alt="">
                        <p>Posicionamento</p>
                    </div>

                    <div class="card">
                        <img src="./imagens/card_03.jpg" alt="">
                        <p>Fontes e Ícones</p>
                    </div>

                </section>

                <section class="content_section">

                    <article>

                        <header>
                            <h2>Título do Article</h2>
                        </header>

                        <p>
                            Paragrafo 1
                        </p>
                        <p>
                            Paragrafo 2
                        </p>

                    </article>
                </section>
            </main>

            <footer>

                <p>Copyright &copy; 2023</p>
            </footer>

        </div>
    </body>
</html>
```

```css
body{
    font-family: Arial, Helvetica, sans-serif;
    background-color: #ccc;
    margin: 0;
}

.hero{
    background-image: url(/images/ProjetoCSS_inicio/imagens/bg-3.jpg);
    height: 500px;
    background-position: right center;
    background-size: cover;
}

.hero_content{
    text-align: center;
    color:white;
    margin-top: 150px;
}

.hero_content h1{
    text-transform: uppercase;
    font-size: 46px;
    text-shadow: 3px 3px 2px #333;
}

.main{
    width: 80%;
    margin: auto;
}

.content_section{
    background-color: white;
    padding: 15px;
    margin-top: 15px;
}
```



### 30. Como resolver Imagem do .hero cortada em telas grandes



### 31. footer - como centralizar na vertical

```css
body{
    font-family: Arial, Helvetica, sans-serif;
    background-color: #ccc;
    margin: 0;
}

.hero{
    background-image: url(/images/ProjetoCSS_inicio/imagens/bg-3.jpg);
    height: 500px;
    background-position: right center;
    background-size: cover;
}

.hero_content{
    text-align: center;
    color:white;
    margin-top: 150px;
}

.hero_content h1{
    text-transform: uppercase;
    font-size: 46px;
    text-shadow: 3px 3px 2px #333;
}

.main{
    width: 80%;
    margin: auto;
}

.content_section{
    background-color: white;
    padding: 15px;
    margin-top: 15px;
}

.content_section h2{
    background-color: #ccc;
    padding: 12px;
    border-bottom: 3px solid gray;
}

.content_section article p{
    margin-block-start: 0.83em;
}

.footer{
    margin-top: 15px;
    height: 80px;
    color: white;
    font-size: 14px;
    text-align: center;
    text-shadow: 2px 2px 2px black;
    background-color: #6b6c68;
    line-height: 80px;
}
```



### 32. Propriedade display, inline, block e inline-block

- block -> ocupa sempre a área toda disponível, a largura toda da página ou container. Vai ocupar a área inteira, o width, e vai gerar uma queda de linha.

- inline -> funciona como se fosse apenas uma linha.
- inline-block -> continua sendo elemento de linha, mas com propriedades de block

```html
<!doctype html>
<!-- doctype informa ao agnte de usuario a versão do html que deve ser renderizada -->
<html lang="pt-br">
    <head>
        <title> 09_display </title>
        <meta charset="utf-8">
        <meta name="author" content="Daniel">
        <meta name="description" content="lista de documentos">
        <meta name="keywords" content="html5, tecnologia">
        <style>

            body{
                font-family: sans-serif;
            }

            h1, p, div, footer{
                border: 3px solid red;
            }

            p{
                width: 50%;
                padding: 25px;
            }

            div{
                margin: 50px;
            }

            b, em, a, span{
                background-color: yellowgreen;
            }

            em{
                width: 350px;
                height: 50px;
                text-align: center;
                /* display: none; */
                visibility: hidden;
            }

            img, span{
                display: block;
            }

        </style>
    </head>
    <body>
        <h1>Propriedade Display</h1>
        <p>
            <b>Lorem ipsum</b> dolor sit amet <em>consectetur adipisicing elit.</em> Dignissimos quasi sed molestiae nihil qui aut expedita <a href="#">Texto com link falso</a> soluta fuga tenetur hic, consectetur illum. Aliquam inventore officia impedit obcaecati blanditiis nisi autem.
        </p>
        <p>
            <img src="../images/css3.png" alt="">
            Lorem ipsum, dolor sit amet consectetur adipisicing elit. Porro, sunt magni cum commodi sit accusantium delectus esse ipsam aliquid fugiat quidem quo dicta quasi impedit harum deleniti eius exercitationem quisquam! Adipisci delectus quos aspernatur perferendis vitae doloribus dicta, pariatur asperiores!
        </p>
        <p>
            Lorem ipsum dolor sit, amet consectetur adipisicing elit. Commodi dicta est in sit, deserunt atque et blanditiis neque temporibus nam veritatis? Quis voluptas nulla explicabo recusandae? Excepturi quo iusto error voluptates, quasi, omnis quis corporis eius nemo a, molestias aliquid quae facilis voluptate! Vel at ullam saepe iure pariatur porro!
        </p>
        <div>
            uma div com uma span dentro. <span>Viu</span>
        </div>
        <footer>
            rodape
        </footer>
    </body>
</html>
```



### 33. Projeto 1 - menu horizontal











