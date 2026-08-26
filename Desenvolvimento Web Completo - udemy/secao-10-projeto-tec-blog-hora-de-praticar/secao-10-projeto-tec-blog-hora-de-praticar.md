# Desenvolvimento Web Completo

## Professor Hamilton Damasceno

## Seção 10: Projeto TecBlog - Hora de praticar

### 70. #projeto3 TecBlog - parte 1

#### Arquivo completo - index.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>TecBlog</title>
    <link rel="stylesheet" href="./css/estilo.css">
</head>
<body>
    <div id="area-cabecalho">
        <div id="area-logo">
            <h1>Tec<span class="branco" >Blog</span></h1>
        </div>
        <div id="area-menu">
            <a href="./index.html">Home</a>
            <a href="./conteudo/jogos.html">Jogos</a>
            <a href="./conteudo/celulares.html">Celulares</a>
            <a href="./conteudo/informatica.html">Informática</a>
            <a href="./conteudo/eletronicos.html">Eletrônicos</a>
        </div>
    </div>
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
    font-size: 1em;
    font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
    background-color: #e6e6e6;
}

/* Layout */

#area-cabecalho {
    background-color: #f7b600;
    padding: 15px;
    text-align: center;
}

#area-logo, #area-menu {
    padding: 10px;
}
/* Formatação do menu */

a {
    text-decoration: none;
    border-radius: 5px;
}

a:link, a:visited {
    color: #fff;
    padding: 8px 12px;
}

a:hover {
    color: #f7b600;
    background-color: #fff;
}

/* Formatações em geral  */
h1 {
    color: #4e4e4e;
    font-size: 2.5em;
}

.branco {
    color: #ffffff;
}
```



---

---



### 71. #projeto3 TecBlog - parte 2
#### Arquivo completo - index.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>TecBlog</title>
    <link rel="stylesheet" href="./css/estilo.css">
</head>
<body>
    <div id="area-cabecalho">
        <div id="area-logo">
            <h1>Tec<span class="branco" >Blog</span></h1>
        </div>
        <div id="area-menu">
            <a href="./index.html">Home</a>
            <a href="./conteudo/jogos.html">Jogos</a>
            <a href="./conteudo/celulares.html">Celulares</a>
            <a href="./conteudo/informatica.html">Informática</a>
            <a href="./conteudo/eletronicos.html">Eletrônicos</a>
        </div>
    </div> <!--area-cabecalho-->

    <div id="area-principal">

        <div id="area-postagens">
            
            <!--abertura postagem-->
            <div class="postagem">
                <h2>Título da postagem 1</h2>
                <span>postado 25 agosto 2026</span>
                <img src="./img/imagem1.jpg" alt="imagem1">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus labore vel aspernatur. Est provident, consequatur vero ratione minima ipsam commodi! Architecto nulla qui earum rerum fuga praesentium nesciunt assumenda? Suscipit!</p>
                <a href="">Leia mais</a>
            </div><!--//fechamento postagem-->

        </div> <!--area-postagens-->

        <div id="area-lateral">
            Area lateral
        </div> <!--area-lateral-->

        <div id="rodape">
            <p>Todos os direitos reservados</p>
        </div>

    </div> <!--area-principal-->
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
    font-size: 1em;
    font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
    background-color: #e6e6e6;
}

/* Layout */

#area-cabecalho {
    background-color: #f7b600;
    padding: 15px;
    text-align: center;
}

#area-logo, #area-menu {
    padding: 10px;
}

#area-principal {
    width: 920px;
    margin: 0 auto;
}

#area-postagens, #area-lateral {
    background-color: orange;
}

#area-postagens {
    width: 660px;
    float: left;
}

#area-lateral {
    width: 240px;
    float: right;
}

.postagem {
    padding: 20px;
    margin-bottom: 20px;
    background: #ffffff;
}

img {
    width: 620px;
}

#rodape {
    clear: both;
    text-align: center;
    padding: 15px;
    background: #CCC;
}

/* Formatação do menu */

a {
    text-decoration: none;
    border-radius: 5px;
}

a:link, a:visited {
    color: #fff;
    padding: 8px 12px;
}

a:hover {
    color: #f7b600;
    background-color: #fff;
}

/* Formatações em geral  */
h1 {
    color: #4e4e4e;
    font-size: 2.5em;
}

.branco {
    color: #ffffff;
}
```



---


---



### 72. #projeto3 TecBlog - parte 3