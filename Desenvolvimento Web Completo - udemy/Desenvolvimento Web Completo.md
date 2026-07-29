# Desenvolvimento Web Completo

## Professor Hamilton Damasceno



[Submarine cable map](https://www.submarinecablemap.com/)

[IP Location](https://www.iplocation.net/)



HTML5 - Index.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Site do Thiago</title>
</head>
<body>
    <p>Hello, World!</p>
</body>
</html>
```

[Developer Mozilla](https://developer.mozilla.org/pt-BR/)

[W3schools](https://www.w3schools.com/)

HTML5 - cabecalho.index

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cabeçalhos</title>
</head>
<body>
    <h1>Cabeçalho 1</h1>
    <p>Desenvolvimento web</p>
    <h2>Cabeçalho 2</h2>
    <p>Desenvolvimento web</p>
    <h3>Cabeçalho 3</h3>
    <p>Desenvolvimento web</p>
    <h4>Cabeçalho 4</h4>
    <p>Desenvolvimento web</p>
    <h5>Cabeçalho 5</h5>
    <p>Desenvolvimento web</p>
    <h6>Cabeçalho 6</h6>
    <p>Desenvolvimento web</p>
</body>
</html>
```

### 17. Elementos de parágrafos HTML.....

Para parágrafos usamos a Tag `<p></p>`

```html
<p>
        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Perspiciatis quo voluptas quas vel modi, ratione hic repellat eos molestias mollitia. Molestias asperiores odio autem soluta officiis voluptatem quaerat itaque veritatis?
    </p>
```

Para comentários usamos `<!--  -->`

```html
<!-- Isso é um comentário -->
```

Para adicionar uma linha horizontal, usamos a tag `<hr>`

```html
<hr>
```

Arquivo parágrafos.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Parágrafos</title>
</head>
<body>
    <!-- Isso é um comentário -->
    <h1>Melhores notícias sobre tecnologia</h1>
    <hr>
    <h2>Novos recursos anunciádos para Whatsapp</h2>

    <p>
        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Perspiciatis quo voluptas quas vel modi, ratione hic repellat eos molestias mollitia. Molestias asperiores odio autem soluta officiis voluptatem quaerat itaque veritatis?
    </p>
    <p>
        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Perspiciatis quo voluptas quas vel modi, ratione hic repellat eos molestias mollitia. Molestias asperiores odio autem soluta officiis voluptatem quaerat itaque veritatis?
    </p>

    <h2>Microsoft anuncia nova versão do seu sistema operacional</h2>
    <p>
        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Perspiciatis quo voluptas quas vel modi, ratione hic repellat eos molestias mollitia. Molestias asperiores odio autem soluta officiis voluptatem quaerat itaque veritatis?
    </p>
    <p>
        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Perspiciatis quo voluptas quas vel modi, ratione hic repellat eos molestias mollitia. Molestias asperiores odio autem soluta officiis voluptatem quaerat itaque veritatis?
    </p>
</body>
</html>
```



### 18. Semântica e formatação de textos

 `<b></b>` — Negrito

A tag `<b>` deixa o texto em **negrito**, sem indicar importância semântica.

```html
<p>Esse é um texto em <b>negrito</b></p>
```

------

 `<strong></strong>` — Texto importante

A tag `<strong>` destaca um texto como **importante**. Por padrão, os navegadores também exibem esse texto em negrito, mas seu principal objetivo é fornecer **significado semântico**.

```html
<p>Esse é um texto em <strong>importante</strong></p>
```

------

 `<i></i>` — Itálico

A tag `<i>` exibe o texto em **itálico**, normalmente usada para termos estrangeiros, nomes científicos ou trechos que precisam de uma apresentação diferenciada.

```html
<p>Esse é um texto em <i>itálico</i></p>
```

------

 `<em></em>` — Ênfase

A tag `<em>` representa um texto com **ênfase**. Visualmente costuma aparecer em itálico, mas seu principal objetivo é indicar importância semântica.

```html
<p>Esse é um texto em <em>ênfase</em></p>
```

------

 `<mark></mark>` — Texto marcado

A tag `<mark>` destaca um trecho de texto, geralmente com um **fundo amarelo**, como se estivesse marcado com um marca-texto.

```html
<p>Esse é um texto em <mark>marcado</mark></p>
```

------

 `<u></u>` — Sublinhado

A tag `<u>` é usada para exibir um texto **sublinhado**.

> **Observação:** No seu código há um pequeno erro de digitação: `subliado` → **sublinhado**.

```html
<p>Esse é um texto em <u>sublinhado</u></p>
```

------

 `<del></del>` — Texto removido

A tag `<del>` representa um texto que foi **removido ou excluído**. Geralmente é exibida com um risco no meio da palavra.

```html
<p>Esse é um texto <del>apagado</del></p>
```

------

 `<sup></sup>` — Sobrescrito

A tag `<sup>` exibe um texto em **sobrescrito**, acima da linha normal do texto. É muito utilizada para expoentes em expressões matemáticas.

```html
<p>Sobrescrito: 10<sup>2</sup></p>
```

Resultado: 10²

------

`<sub></sub>` — Subscrito

A tag `<sub>` exibe um texto em **subscrito**, abaixo da linha normal do texto. É muito utilizada em fórmulas químicas.

```html
<p>Subscrito: H<sub>2</sub>O</p>
```

Resultado: H₂O

------

#### Resumo das tags

| Tag        | Função                                               |
| ---------- | ---------------------------------------------------- |
| `<h2>`     | Cria um título de nível 2.                           |
| `<p>`      | Define um parágrafo.                                 |
| `<b>`      | Exibe o texto em negrito, sem significado semântico. |
| `<strong>` | Indica um texto importante (semântica).              |
| `<i>`      | Exibe o texto em itálico.                            |
| `<em>`     | Indica um texto com ênfase (semântica).              |
| `<mark>`   | Destaca o texto com marcação.                        |
| `<u>`      | Sublinha o texto.                                    |
| `<del>`    | Indica texto removido ou excluído.                   |
| `<sup>`    | Exibe texto sobrescrito.                             |
| `<sub>`    | Exibe texto subscrito.                               |

Arquivo **formatacao_textos.html**

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formatação de Texto</title>
</head>
<body>
    <h2>Formatações de textos</h2>
    <p>Esse é um texto em <b>negrito</b></p>
    <p>Esse é um texto em <strong>importante</strong></p>
    <p>Esse é um texto em <i>itálico</i></p>
    <p>Esse é um texto em <em>ênfase</em></p>
    <p>Esse é um texto em <mark>marcado</mark></p>
    <p>Esse é um texto em <u>subliado</u></p>
    <p>Esse é um texto <del>apagado</del></p>

    <h2>Diferentes tipos de caracteres</h2>
    <p>Sobrescrito: 10 <sup>2</sup> </p>
    <p>Sobscrito: H<sub>2</sub>O </p>

</body>
</html>
```



### 19. [Projeto] Classificação de Animes

Arquivo **animes_preferidos.html**

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Melhores animes</title>
</head>
<body>
    <h1>Meus animes preferidos de todos os tempos</h1>
    <h2>3 Melhores animes</h2>
    <hr>

    <h3>1) Death note</h3>
    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis veritatis nulla laborum autem, modi assumenda veniam cum? Similique provident ratione, itaque dicta amet accusantium. Aliquam quas repellendus molestias sunt odit?
    </p>

    <h3>2) Fullmental Alchemist</h3>
    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis veritatis nulla laborum autem, modi assumenda veniam cum? Similique provident ratione, itaque dicta amet accusantium. Aliquam quas repellendus molestias sunt odit?
    </p>

    <h3>3) One Piece</h3>
    <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis veritatis nulla laborum autem, modi assumenda veniam cum? Similique provident ratione, itaque dicta amet accusantium. Aliquam quas repellendus molestias sunt odit?
    </p>
</body>
</html>
```



### 20. O Elemento de Lista
