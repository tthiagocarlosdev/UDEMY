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
                <span class="data-postagem">postado 25 agosto 2026</span>
                <img src="./img/imagem1.jpg" alt="imagem1">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus labore vel aspernatur. Est provident, consequatur vero ratione minima ipsam commodi! Architecto nulla qui earum rerum fuga praesentium nesciunt assumenda? Suscipit!</p>
                <a href="">Leia mais</a>
            </div><!--//fechamento postagem-->

            <!--abertura postagem-->
            <div class="postagem">
                <h2>Título da postagem 2</h2>
                <span class="data-postagem">postado 26 agosto 2026</span>
                <img src="./img/imagem2.jpg" alt="imagem1">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus labore vel aspernatur. Est provident, consequatur vero ratione minima ipsam commodi! Architecto nulla qui earum rerum fuga praesentium nesciunt assumenda? Suscipit!</p>
                <a href="">Leia mais</a>
            </div><!--//fechamento postagem-->

        </div> <!--area-postagens-->

        <div id="area-lateral">
            
            <div class="conteudo-lateral">
                <h3>Postagens recentes</h3>
                <div class="postagem-lateral">
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit.
                    </p>
                    <a href="">Leia mais</a>
                </div>

                <div class="postagem-lateral">
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit.
                    </p>
                    <a href="">Leia mais</a>
                </div>

            </div>

            <div class="conteudo-lateral">
                <h3>Categorias</h3>
                
                <a href="./index.html">Home</a> <br>
                <a href="./conteudo/jogos.html">Jogos</a> <br>
                <a href="./conteudo/celulares.html">Celulares</a> <br>
                <a href="./conteudo/informatica.html">Informática</a> <br>
                <a href="./conteudo/eletronicos.html">Eletrônicos</a>

            </div>


        </div> <!--area-lateral-->

        <div id="rodape">
            <p>Todos os direitos reservados</p>
        </div>

    </div> <!--area-principal-->
</body>
</html>
```

---

#### Arquivo completo - jogos.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>TecBlog - Jogos</title>
    <link rel="stylesheet" href="../css/estilo.css">
</head>
<body>
    <div id="area-cabecalho">
        <div id="area-logo">
            <h1>Tec<span class="branco" >Blog</span></h1>
        </div>
        <div id="area-menu">
            <a href="../index.html">Home</a>
            <a href="./jogos.html">Jogos</a>
            <a href="./celulares.html">Celulares</a>
            <a href="./informatica.html">Informática</a>
            <a href="./eletronicos.html">Eletrônicos</a>
        </div>
    </div> <!--area-cabecalho-->

    <div id="area-principal">

        <div id="area-jogos">
            <h1>Jogos</h1>
        </div>

        <div id="rodape">
            <p>Todos os direitos reservados</p>
        </div>

    </div> <!--area-principal-->
</body>
</html>
```

---

#### Arquivo completo - celulares.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>TecBlog - Celulares</title>
    <link rel="stylesheet" href="../css/estilo.css">
</head>
<body>
    <div id="area-cabecalho">
        <div id="area-logo">
            <h1>Tec<span class="branco" >Blog</span></h1>
        </div>
        <div id="area-menu">
            <a href="../index.html">Home</a>
            <a href="./jogos.html">Jogos</a>
            <a href="./celulares.html">Celulares</a>
            <a href="./informatica.html">Informática</a>
            <a href="./eletronicos.html">Eletrônicos</a>
        </div>
    </div> <!--area-cabecalho-->

    <div id="area-principal">

        <div id="area-jogos">
            <h1>Celulares</h1>
        </div>

        <div id="rodape">
            <p>Todos os direitos reservados</p>
        </div>

    </div> <!--area-principal-->
</body>
</html>
```

---

#### Arquivo completo - informatica.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>TecBlog - Informática</title>
    <link rel="stylesheet" href="../css/estilo.css">
</head>
<body>
    <div id="area-cabecalho">
        <div id="area-logo">
            <h1>Tec<span class="branco" >Blog</span></h1>
        </div>
        <div id="area-menu">
            <a href="../index.html">Home</a>
            <a href="./jogos.html">Jogos</a>
            <a href="./celulares.html">Celulares</a>
            <a href="./informatica.html">Informática</a>
            <a href="./eletronicos.html">Eletrônicos</a>
        </div>
    </div> <!--area-cabecalho-->

    <div id="area-principal">

        <div id="area-jogos">
            <h1>Informática</h1>
        </div>

        <div id="rodape">
            <p>Todos os direitos reservados</p>
        </div>

    </div> <!--area-principal-->
</body>
</html>
```

---

#### Arquivo completo - eletronicos.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>TecBlog - Eletrônicos</title>
    <link rel="stylesheet" href="../css/estilo.css">
</head>
<body>
    <div id="area-cabecalho">
        <div id="area-logo">
            <h1>Tec<span class="branco" >Blog</span></h1>
        </div>
        <div id="area-menu">
            <a href="../index.html">Home</a>
            <a href="./jogos.html">Jogos</a>
            <a href="./celulares.html">Celulares</a>
            <a href="./informatica.html">Informática</a>
            <a href="./eletronicos.html">Eletrônicos</a>
        </div>
    </div> <!--area-cabecalho-->

    <div id="area-principal">

        <div id="area-jogos">
            <h1>Eletrônicos</h1>
        </div>

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
    padding: 15px;
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

.conteudo-lateral {
    background-color: white;
    padding: 10px;
    margin-bottom: 20px;
}

.postagem-lateral {
    font-size: 0.8em;
    padding: 5px;
    border-bottom: 1px dotted #CCC;
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
    color: #f7b600;
}

 a:hover {
    text-decoration: underline;
}

#area-cabecalho a:link, #area-cabecalho a:visited {
    color: #fff;
    padding: 8px 12px;
}

#area-cabecalho a:hover {
    color: #f7b600;
    background-color: #fff;
    text-decoration: none;
}

/* Formatações em geral  */
h1 {
    color: #4e4e4e;
    font-size: 2.5em;
}

h2 {
    color: #f7b600;
}

h3 {
    color: #565656;
    background-color: #CCC;
    padding: 5px;
}

.branco {
    color: #ffffff;
}

.data-postagem {
    font-size: 0.8em;
    border-bottom: 1px solid #f4f4f4;
    padding-bottom: 10px;
    margin-bottom: 10px;
    display: block;
}

/* Area de jogos */

#area-jogos {
    background-color: #f4f4f4;
    margin: 0 0 20px 0;
    padding: 1em;
}

#area-jogos h1 {
    text-align: center;
}
```

