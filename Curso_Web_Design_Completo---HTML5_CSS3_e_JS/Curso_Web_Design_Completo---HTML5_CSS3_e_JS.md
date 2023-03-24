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































