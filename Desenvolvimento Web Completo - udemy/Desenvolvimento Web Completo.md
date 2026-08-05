# Desenvolvimento Web Completo

## Professor Hamilton Damasceno



## Seção 4: Introdução ao HTML

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



-----

-----



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



-----

-----



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



-----

-----



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



-----

-----

-----



## Seção 5: HTML Intermediário

### 20. O Elemento de Lista

#### `<ul></ul>`

O elemento `<ul>` (**Unordered List**) é usado para criar uma **lista não ordenada**, ou seja, uma lista cujos itens são exibidos com marcadores (bolinhas) por padrão.

```html
<ul>
    ...
</ul>
```

------

####  `<ol></ol>`

O elemento `<ol>` (**Ordered List**) é usado para criar uma **lista ordenada**, em que os itens são numerados automaticamente.

```html
<ol>
    ...
</ol>
```

------

####  `<li></li>`

O elemento `<li>` (**List Item**) representa um **item de uma lista**. Ele deve estar sempre dentro de uma lista `<ul>` ou `<ol>`.

```html
<li>Veículos</li>
```

------

####  Lista aninhada (lista dentro de outra lista)

É possível colocar uma lista dentro de um item (`<li>`), criando uma **sublista**. Esse recurso é muito utilizado para menus, categorias e estruturas hierárquicas.

Exemplo de uma lista não ordenada dentro de outra:

```html
<li>
    Tecnologia
    <ul>
        <li>Celulares e telefone</li>
        <li>Câmeras e acessórios</li>
    </ul>
</li>
```

Nesse caso:

- `Tecnologia` é um item da lista principal.
- A lista `<ul>` interna cria duas categorias pertencentes a **Tecnologia**.

O resultado será semelhante a:

- Veículos
- Tecnologia
  - Celulares e telefone
  - Câmeras e acessórios

------

####  Lista ordenada com subitens

Assim como acontece com `<ul>`, uma lista ordenada (`<ol>`) também pode conter outra lista dentro de um item.

```html
<li>
    Geléia
    <ol>
        <li>Sub item de geléia</li>
        <li>Sub item de geléia</li>
        <li>Sub item de geléia</li>
    </ol>
</li>
```

Nesse exemplo:

- `Geléia` é um item da lista principal.
- A lista `<ol>` interna cria uma sequência numerada de subitens relacionados à geléia.

O resultado será semelhante a:

1. Melancia
2. Molho de tomate
3. Macarrão
4. Geléia
   1. Sub item de geléia
   2. Sub item de geléia
   3. Sub item de geléia

------



#### Resumo dos elementos

| Elemento                | Função                                        |
| ----------------------- | --------------------------------------------- |
| `<ul>`                  | Cria uma lista não ordenada (com marcadores). |
| `<ol>`                  | Cria uma lista ordenada (numerada).           |
| `<li>`                  | Representa um item de uma lista.              |
| `<ul>` dentro de `<li>` | Cria uma sublista com marcadores.             |
| `<ol>` dentro de `<li>` | Cria uma sublista numerada.                   |



#### Arquivo listas.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Listas</title>
</head>
<body>
    <h2>Lista não ordenada (menus)</h2>
    <ul>
        <li>Veículos</li>
        <li>
            Tecnologia
            <ul>
                <li>Celulares e telefone</li>
                <li>Câmeras e acessórios</li>
            </ul>
        </li>
    </ul>

    <h2>Lista ordenada (lista de compras)</h2>
    <ol>
        <li>Melancia</li>
        <li>Molho de tomate</li>
        <li>Macarrão</li>
        <li>
            Geléia
            <ol>
                <li>Sub intem de geléia</li>
                <li>Sub intem de geléia</li>
                <li>Sub intem de geléia</li>
            </ol>
        </li>
    </ol>

    <h5>Contatos</h5>
    <ul>
        <li>Comprar</li>
        <li>Vender</li>
        <li>Solução</li>
        <li>Segurança</li>
    </ul>
    
    <h5>Redes sociais</h5>
    <ul>
        <li>Twitter</li>
        <li>Facebook</li>
        <li>Instagram</li>
        <li>Youtube</li>
    </ul>
</body>
</html>
```



#### Links da aula

[Lista ordenada](https://www.w3schools.com/tags/att_ol_type.asp)

[Lista NÃO ordenada](https://www.w3schools.com/tags/tag_ul.asp)



-----

-----



### 21. Imagens: Elementos de Imagem



#### `<img>`

O elemento `<img>` (**Image**) é usado para **inserir imagens em uma página HTML**. Diferentemente da maioria das tags HTML, `<img>` é uma **tag vazia**, ou seja, não possui tag de fechamento (`</img>`). Todas as informações sobre a imagem são definidas por meio de atributos.

```html
<img src="caminho-da-imagem.jpg" alt="Descrição da imagem">
```

Os principais atributos da tag `<img>` são:

- **`src`** (*Source*): especifica o caminho ou a URL da imagem que será exibida.
- **`alt`** (*Alternative Text*): fornece uma descrição da imagem. Esse texto é exibido caso a imagem não possa ser carregada e também é utilizado por leitores de tela para melhorar a acessibilidade.
- **`width`**: define a largura da imagem.
- **`height`**: define a altura da imagem.

------

#### Exemplo 1 – Imagem hospedada na internet

Neste exemplo, a imagem é carregada diretamente de um endereço (URL) na internet.

```html
<img
    src="https://www.melhoresdestinos.com.br/wp-content/uploads/2020/06/praias-brasil-sancho.jpg"
    alt="Imagem de uma praia, vista do alto"
    width="500"
>
```

##### Explicação

- `src`: informa a URL da imagem.
- `alt`: descreve a imagem para acessibilidade e para situações em que ela não seja carregada.
- `width="500"`: define a largura da imagem em **500 pixels**. A altura será ajustada automaticamente para manter a proporção original.

------

#### Exemplo 2 – Imagem armazenada localmente

Também é possível carregar uma imagem que está salva na própria estrutura do projeto.

```html
<img
    src="./imagens/praias-brasil-sancho.jpg"
    alt="Imagem de uma praia, vista do alto"
    height="250"
>
```

##### Explicação

- `src="./imagens/praias-brasil-sancho.jpg"`: indica que a imagem está dentro da pasta `imagens`.
- `height="250"`: define a altura da imagem em **250 pixels**. A largura será ajustada automaticamente para manter a proporção.

------

#### Exemplo 3 – Definindo a largura

```html
<img
    src="./imagens/ferrari.jpg"
    alt="Carro modelo ferrari"
    width="250"
>
```

##### Explicação

Neste exemplo:

- A imagem é carregada da pasta `imagens`.
- O texto alternativo descreve o conteúdo da imagem.
- A largura é definida como **250 pixels**, enquanto a altura é calculada automaticamente.

------

#### Exemplo 4 – Exibindo um GIF

A tag `<img>` também pode ser utilizada para exibir imagens animadas no formato GIF.

```html
<img
    src="./imagens/animado.gif"
    alt=""
    height="100"
>
```

##### Explicação

- `src`: aponta para um arquivo GIF.
- `height="100"`: define a altura da animação.
- `alt=""`: indica que a imagem é decorativa e não possui uma descrição relevante.

------

#### Exemplo 5 – Imagem com fundo transparente

A imagem abaixo possui transparência e está sendo exibida sobre um fundo azul.

```html
<img
    src="./imagens/html.png"
    alt="Imagem do HTML com transparência"
    width="400"
>
```

##### Explicação

- A imagem é um arquivo PNG com transparência.
- O fundo azul do elemento pai fica visível nas áreas transparentes da imagem.
- `width="400"` define a largura da imagem em **400 pixels**.

------

#### Resumo dos principais atributos da tag `<img>`

| Atributo | Função                                                       |
| -------- | ------------------------------------------------------------ |
| `src`    | Define o caminho ou a URL da imagem que será exibida.        |
| `alt`    | Fornece uma descrição alternativa da imagem, importante para acessibilidade e para quando a imagem não puder ser carregada. |
| `width`  | Define a largura da imagem.                                  |
| `height` | Define a altura da imagem.                                   |

#### Arquivo imagens.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Imagens</title>
</head>
<body>
    <h1>Imagens</h1>
    <img src="https://www.melhoresdestinos.com.br/wp-content/uploads/2020/06/praias-brasil-sancho.jpg" 
        alt="Imagem de uma praia, vista do alto"
        width="500"
    >

    <img src="./imagens/praias-brasil-sancho.jpg" 
        alt="Imagem de uma praia, vista do alto"
        height="250"
    >
    <img src="./imagens/ferrari.jpg" 
        alt="Carro modelo ferrari"
        width="250"
    >
    <img src="./imagens/animado.gif" 
        alt=""
        height="100"
    >
    <p style="background-color: blue;">
        <img src="./imagens/html.png" 
            alt="Imagem do HTML com transparência"
            width="400"
        >
    </p>
    
</body>
</html>
```



#### Links da aula

[Imagens W3School](https://www.w3schools.com/html/html_images.asp)



-----

-----



### 22. Imagens: Caminho Relativo e Absoluto

Ao utilizar a tag `<img>`, o atributo `src` informa **onde a imagem está localizada**. Esse caminho pode ser de dois tipos:

- **Caminho absoluto:** utiliza uma URL completa para acessar uma imagem hospedada na internet.
- **Caminho relativo:** utiliza a estrutura de pastas do próprio projeto para localizar a imagem.

#### Caminho absoluto

Um caminho absoluto informa o endereço completo da imagem, incluindo o protocolo (`https://`) e o domínio do site.

```html
<img
    src="https://www.exemplo.com/imagens/praia.jpg"
    alt="Imagem de uma praia"
>
```

Nesse caso, a imagem será carregada diretamente da internet.

------

#### Caminho relativo

Um caminho relativo indica a localização da imagem em relação ao arquivo HTML que está sendo executado.

##### Mesma pasta (`./`)

O prefixo `./` indica que a imagem está na **mesma pasta** do arquivo HTML.

```html
<img
    src="./praia.jpeg"
    alt="Imagem de uma praia"
>
```

Estrutura de exemplo:

```
projeto/
│
├── index.html
└── praia.jpeg
```

------

##### Voltar uma pasta (`../`)

O prefixo `../` significa **voltar um nível** na estrutura de diretórios.

```html
<img
    src="../imagens/praia.jpeg"
    alt="Imagem de uma praia"
>
```

Estrutura de exemplo:

```
projeto/
│
├── imagens/
│   └── praia.jpeg
│
└── paginas/
    └── index.html
```

O HTML está dentro da pasta `paginas`. O comando `../` retorna para a pasta `projeto` e depois entra na pasta `imagens`.

------

##### Navegar entre várias pastas

É possível combinar vários diretórios para chegar ao arquivo desejado.

```html
<img
    src="../arquivos/images/praia.jpeg"
    alt="Imagem de uma praia"
>
```

Nesse exemplo:

- `..` volta uma pasta.
- `arquivos` entra nessa pasta.
- `images` entra na subpasta.
- `praia.jpeg` é o arquivo da imagem.

------

##### Voltar mais de um nível

Também é possível voltar vários níveis utilizando `../../`.

```html
<img
    src="../../HTML5/imagens/praia.jpeg"
    alt="Imagem de uma praia"
>
```

Nesse caso:

- `../` volta um nível.
- Outro `../` volta mais um nível.
- Depois o navegador entra na pasta `HTML5` e, em seguida, na pasta `imagens`.

------

#### Atributo `title`

O atributo `title` adiciona um **texto informativo** à imagem.

Quando o usuário posiciona o ponteiro do mouse sobre a imagem, esse texto é exibido como uma dica (tooltip).

```html
<img
    src="./praia.jpeg"
    alt="Imagem de uma praia"
    title="Praia da Boa Vista"
>
```

Nesse exemplo:

- `title="Praia da Boa Vista"` exibe essa mensagem quando o usuário passa o mouse sobre a imagem.

O atributo `title` **não substitui** o atributo `alt`.

Enquanto:

- `alt` é utilizado para acessibilidade e quando a imagem não pode ser carregada;
- `title` apenas fornece uma informação adicional ao usuário.

------

#### Resumo dos principais atributos

| Atributo | Função                                                       |
| -------- | ------------------------------------------------------------ |
| `src`    | Define o caminho da imagem (relativo ou absoluto).           |
| `./`     | Indica que o arquivo está na mesma pasta do documento HTML.  |
| `../`    | Volta um nível na estrutura de diretórios.                   |
| `../../` | Volta dois níveis na estrutura de diretórios.                |
| `title`  | Exibe uma dica (tooltip) quando o mouse passa sobre a imagem. |
| `alt`    | Fornece uma descrição alternativa da imagem para acessibilidade e para casos em que ela não seja carregada. |

------

#### Arquivo fotos.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Fotos</title>
</head>
<body>

    <h1>Caminhos relativos e absolutos</h1>

    <img
        src="./praia.jpeg"
        alt="Imagem de uma praia"
        title="Praia da Boa Vista"
        width="300"
    >

    <img
        src="../imagens/praia.jpeg"
        alt="Imagem de uma praia"
        title="Praia da Boa Vista"
        width="300"
    >

    <img
        src="../arquivos/images/praia.jpeg"
        alt="Imagem de uma praia"
        title="Praia da Boa Vista"
        width="300"
    >

    <img
        src="../../HTML5/imagens/praia.jpeg"
        alt="Imagem de uma praia"
        title="Praia da Boa Vista"
        width="300"
    >

    <h2>Tag figure</h2>

    <figure>
        <img
            src="./praia.jpeg"
            alt="Imagem de uma praia"
            title="Praia da Boa Vista"
            width="300"
        >
        <figcaption>Praia da Boa Vista</figcaption>
    </figure>

</body>
</html>
```



#### Links da aula

[Figure Tag W3School](https://www.w3schools.com/tags/tag_figure.asp)



-----

-----



### 23. Links: Elementos de Âncora

O elemento `<a>` (**Anchor**, ou âncora) é utilizado para **criar links** em uma página HTML. Esses links podem direcionar o usuário para:

- Outra página da internet;
- Outra página do mesmo projeto;
- Uma seção específica da própria página;
- Arquivos para download;
- Endereços de e-mail, entre outros.

A sintaxe básica é:

```html
<a href="destino">Texto do link</a>
```

O atributo `href` (**Hypertext Reference**) define o destino para onde o usuário será direcionado ao clicar no link.

Exemplo:

```html
<a href="https://www.google.com/">Google</a>
```

------

#### Links externos

Os links externos direcionam o usuário para páginas hospedadas em outros sites da internet.

```html
<a href="https://www.google.com/" target="_self">
    Google
</a>
```

Neste exemplo:

- `href` contém a URL do Google.
- O texto **Google** é o conteúdo clicável do link.
- `target="_self"` informa que o site será aberto na mesma aba do navegador.

Outro exemplo:

```html
<a href="https://www.mercadolivre.com.br/" target="_blank">
    Mercado Livre
</a>
```

Neste caso, o atributo `target="_blank"` faz com que o link seja aberto em uma **nova aba** do navegador.

------

#### Links internos

Também é possível criar links para outras páginas do mesmo projeto utilizando caminhos relativos.

```html
<a href="./imagens.html" target="_self">
    Imagens
</a>
```

Como o arquivo `imagens.html` está na mesma pasta do documento atual, utiliza-se `./`.

Outro exemplo:

```html
<a href="./desafios/desafio-imagens.html" target="_blank">
    Fórmula 1
</a>
```

Nesse caso:

- `./` indica a pasta atual.
- `desafios/` é uma subpasta.
- `desafio-imagens.html` é o arquivo que será aberto.

------

#### Criando âncoras na mesma página

Além de navegar entre páginas, os links podem levar o usuário para uma **seção específica da própria página**.

Para isso são utilizados:

- o atributo `href="#id"` no link;
- o atributo `id` no elemento de destino.

Exemplo dos links:

```html
<a href="#web">Desenvolvimento Web</a>

<a href="#apps">Desenvolvimento de Apps Nativos</a>

<a href="#multi">Desenvolvimento Multiplataforma</a>
```

Os destinos são definidos pelos respectivos atributos `id`:

```html
<h3 id="web">
    Desenvolvimento Web
</h3>
<h3 id="apps">
    Desenvolvimento de Apps Nativos
</h3>
<h3 id="multi">
    Desenvolvimento Multiplataforma
</h3>
```

Quando o usuário clica em um desses links, o navegador rola automaticamente até o elemento cujo `id` corresponde ao valor informado no `href`.

------

#### Atributo `target`

O atributo `target` define **como o link será aberto**.

Os valores mais utilizados são:

##### `_self`

Abre o link na **mesma aba ou janela**.

```html
<a href="https://www.google.com/" target="_self">
    Google
</a>
```

Esse é o comportamento padrão dos navegadores.

------

##### `_blank`

Abre o link em uma **nova aba** do navegador.

```html
<a href="https://www.mercadolivre.com.br/" target="_blank">
    Mercado Livre
</a>
```

Esse valor é muito utilizado para links externos, permitindo que o usuário permaneça na página atual.

------

# Resumo das principais tags e propriedades

| Elemento ou atributo | Função                                                       |
| -------------------- | ------------------------------------------------------------ |
| `<a>`                | Cria um link (âncora) para outra página, arquivo ou seção do documento. |
| `href`               | Define o destino do link.                                    |
| `target`             | Define onde o link será aberto.                              |
| `_self`              | Abre o link na mesma aba (valor padrão).                     |
| `_blank`             | Abre o link em uma nova aba do navegador.                    |
| `id`                 | Identifica um elemento da página para que ele possa ser acessado por uma âncora. |
| `href="#id"`         | Cria um link para um elemento da própria página que possui o mesmo `id`. |

------

# Código completo

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Links</title>
</head>
<body>
    <h1>Links: Elementos de Âncora</h1>

    <a href="https://www.google.com/" target="_self">Google</a>
    <a href="https://www.mercadolivre.com.br/" target="_blank">Mercado Livre</a>
    <a href="./imagens.html" target="_self">Imagens</a>
    <a href="./desafios/desafio-imagens.html" target="_blank">Fórmula 1</a>

    <h2>Criando âncora</h2>
    <a href="#web">Desenvolvimento Web</a>
    <a href="#apps">Desenvolvimento de Apps Nativos</a>
    <a href="#multi">Desenvolvimento Multiplataforma</a>

    <h3 id="web">Desenvolvimento Web</h3>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>

    <h3 id="apps">Desenvolvimento de Apps Nativos</h3>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>

    <h3 id="multi" >Desenvolvimento Multiplataforma</h3>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
    <p>
        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima nemo vitae modi ratione sit, optio beatae nam dignissimos sint iure, magnam debitis eligendi reiciendis aliquam, deserunt asperiores accusamus dolorem in?
    </p>
</body>
</html>
```



#### Links da aula

[Tag a W3School](https://www.w3schools.com/tags/tag_a.asp)



-----

-----



### 24. Links: Mais sobre as Âncoras

Desafio página mercado livre.

#### index.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mercado Livre</title>
</head>
<body>
    <h1>Mercado Livre</h1>

    <a href="index.html">Home</a> |
    <a href="./conteudo/produtos.html">Produtos</a> |
    <a href="./conteudo/contato.html">Contato</a>
    <hr>

    <h2>Página inicial</h2>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Doloremque veniam eligendi atque odit reiciendis impedit suscipit deleniti? Unde, hic similique sunt illo quaerat nobis deserunt ad impedit eaque illum vero.</p>

    <figure>
        <img src="./img/item1.jpeg" 
            alt="Imagem de um Notebook"
            width="300"
        >
        <figcaption>Notebook</figcaption>        
    </figure>
    
    <figure>
        <img src="./img/item2.jpeg" 
            alt="Imagem de um Celular"
            width="300"
        >
        <figcaption>Celular</figcaption>        
    </figure>
</body>
</html>
```



#### produtos.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Produtos</title>
</head>
<body>
    <h1 id="topo" > Mercado Livre </h1>

    <a href="../index.html"> Home </a> |
    <a href="./produtos.html"> Produtos </a> |
    <a href="./contato.html"> Contato </a>
    <hr>

    <h2>Produtos</h2>
    <a href="#veiculos"> Veículos </a> |
    <a href="#tecnologia"> Tecnologia </a> |
    <a href="#casa-e-moveis"> Casa e móveis </a> |
    <a href="#eletrodomesticos"> Eletrodomésticos </a>
    <hr>

    <h3 id="veiculos">Veículos</h3>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <a href="#topo">Voltar</a>

    <h3 id="tecnologia">Tecnologia</h3>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <a href="#topo">Voltar</a>

    <h3 id="casa-e-moveis" >Casa e móveis</h3>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <a href="#topo">Voltar</a>

    <h3 id="eletrodomesticos" >Eletrodomésticos</h3>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aspernatur voluptas iure rem eaque quod quas? Odio libero, dolorem voluptate quis omnis quidem laborum maiores aperiam, repudiandae laboriosam quasi fugiat deleniti!</p>
    <a href="#topo">Voltar</a>

</body>
</html>
```



#### contato.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Contato</title>
</head>
<body>
    <h1>Mercado Livre</h1>

    <a href="../index.html"> Home </a> |
    <a href="./produtos.html"> Produtos </a> |
    <a href="./contato.html"> Contato </a>
    <hr>

    <h2>Entre em contato</h2>
    <p>email: atendimento@meusite.com.br</p>
    <p>telefone: (11) 3321-9067</p>
    <p>...</p>
    <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Fuga error blanditiis reiciendis laudantium obcaecati eos temporibus impedit, corporis excepturi nulla aspernatur, a ex voluptate culpa iusto reprehenderit earum natus. Quas!</p>
</body>
</html>
```



-----

-----



### 25. Tabelas: Elementos de Tabela

As tabelas em HTML são utilizadas para **organizar informações em linhas e colunas**, facilitando a visualização e comparação de dados.

Uma tabela é formada por diversos elementos que definem sua estrutura, como linhas, células de dados e cabeçalhos.

A estrutura básica de uma tabela é composta pelas seguintes tags:

```html
<table>
    <tr>
        <th>Cabeçalho</th>
    </tr>

    <tr>
        <td>Dado</td>
    </tr>
</table>
```

------

#### Tag `<table>`

O elemento `<table>` é o contêiner principal de uma tabela. Todos os demais elementos da tabela devem estar dentro dessa tag.

```html
<table>
    ...
</table>
```

No código fornecido, a tabela possui o atributo:

```html
<table border="1">
```

O atributo `border` adiciona uma borda à tabela.

- `border="1"` cria uma borda simples ao redor das células.
- **IMPORTANTE:** Atualmente, recomenda-se utilizar **CSS** para definir bordas, pois o atributo `border` é considerado obsoleto no HTML5.

------

#### Tag `<tr>`

O elemento `<tr>` (**Table Row**) representa uma **linha** da tabela.

Cada linha pode conter células de cabeçalho (`<th>`) ou células de dados (`<td>`).

Exemplo:

```html
<tr>
    <td>Notebook</td>
    <td>1</td>
    <td>R$2.000,00</td>
</tr>
```

Nesse exemplo, a linha possui três células.

------

#### Tag `<th>`

O elemento `<th>` (**Table Header**) representa uma **célula de cabeçalho**.

Seu conteúdo normalmente aparece em **negrito** e centralizado, indicando o significado das colunas.

Exemplo:

```html
<tr>
    <th>Produto</th>
    <th>Quantidade</th>
    <th>Preço</th>
</tr>
```

Essa linha define o cabeçalho da tabela.

------

#### Tag `<td>`

O elemento `<td>` (**Table Data**) representa uma **célula de dados**.

É nele que são inseridas as informações da tabela.

Exemplo:

```html
<tr>
    <td>Notebook</td>
    <td>1</td>
    <td>R$2.000,00</td>
</tr>
```

Cada `<td>` corresponde a uma coluna da linha.

------

#### Atributo `colspan`

O atributo `colspan` permite que uma célula ocupe **mais de uma coluna**.

Sua sintaxe é:

```html
<td colspan="2">
    Cupom 1 - R$20,00
</td>
```

Nesse exemplo:

- A célula ocupa **duas colunas** da tabela.
- As duas colunas são unificadas em uma única célula.

No código fornecido:

```html
<tr>
    <td rowspan="2">Desconto</td>
    <td colspan="2">
        Cupom 1 - R$20,00
    </td>
</tr>
```

O texto **Cupom 1 - R$20,00** ocupa simultaneamente as colunas **Quantidade** e **Preço**.

------

#### Atributo `rowspan`

O atributo `rowspan` permite que uma célula ocupe **mais de uma linha**.

Sua sintaxe é:

```html
<td rowspan="2">
    Desconto
</td>
```

Nesse exemplo:

- A célula **Desconto** ocupa duas linhas consecutivas.
- Dessa forma, ela é compartilhada entre as duas linhas dos cupons.

Visualmente, a estrutura fica semelhante a:

| Produto      | Quantidade        | Preço      |
| ------------ | ----------------- | ---------- |
| Notebook     | 1                 | R$2.000,00 |
| Tablet       | 1                 | R$1.000,00 |
| **Desconto** | Cupom 1 - R$20,00 |            |
|              | Cupom 2 - R$15,00 |            |

------

#### Combinando `rowspan` e `colspan`

Os atributos `rowspan` e `colspan` podem ser utilizados juntos para criar tabelas mais complexas.

No código apresentado:

```html
<tr>
    <td rowspan="2">Desconto</td>
    <td colspan="2">
        Cupom 1 - R$20,00
    </td>
</tr>

<tr>
    <td colspan="2">
        Cupom 2 - R$15,00
    </td>
</tr>
```

Nesse caso:

- A célula **Desconto** ocupa duas linhas (`rowspan="2"`).
- Cada cupom ocupa duas colunas (`colspan="2"`).

------

#### Resumo das principais tags e atributos

| Elemento ou atributo | Função                                                       |
| -------------------- | ------------------------------------------------------------ |
| `<table>`            | Define uma tabela.                                           |
| `<tr>`               | Representa uma linha da tabela.                              |
| `<th>`               | Define uma célula de cabeçalho da tabela.                    |
| `<td>`               | Define uma célula de dados da tabela.                        |
| `border`             | Adiciona uma borda à tabela (atualmente recomenda-se usar CSS). |
| `colspan`            | Faz uma célula ocupar duas ou mais colunas.                  |
| `rowspan`            | Faz uma célula ocupar duas ou mais linhas.                   |

------

#### Código completo - tabelas.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tabelas</title>
</head>
<body>
    <h1>Tabelas</h1>

    <table border="1">
        <tr>
            <th> Produto </th>
            <th> Quantidade </th>
            <th> Preço </th>
        </tr>
        <tr>
            <td> Notebook </td>
            <td> 1 </td>
            <td> R$2.000,00 </td>
        </tr>
        <tr>
            <td> Tablet </td>
            <td> 1 </td>
            <td> R$1.000,00 </td>
        </tr>


        <!-- 
            colspan -> extensão da coluna
            rowspan -> extensão da linha 
        -->

        <tr>
            <td rowspan="2" > Desconto </td>
            <td colspan="2">Cupom 1 - R$20,00</td>
        </tr>
        <tr>
            <td colspan="2" >Cupom 2 - R$15,00</td>
        </tr>

    </table>
</body>
</html>
```



#### Links da aula

[Tabelas 3WSchool](https://www.w3schools.com/tags/tag_table.asp)

[Tabelas Mozilla](https://developer.mozilla.org/en-US/docs/Web/HTML/Reference/Elements/table)



_____

-----



### 26. Tabelas: Estrutura Semântica

Além das tags básicas (`<table>`, `<tr>`, `<th>` e `<td>`), o HTML oferece elementos que ajudam a **organizar melhor a estrutura de uma tabela**. Esses elementos tornam o código mais legível, facilitam a manutenção e permitem que navegadores e tecnologias assistivas interpretem corretamente as diferentes partes da tabela.

Os principais elementos são:

- `<caption>`: legenda ou título da tabela.
- `<thead>`: cabeçalho da tabela.
- `<tbody>`: corpo da tabela.
- `<tfoot>`: rodapé da tabela.

------

#### Tag `<caption>`

O elemento `<caption>` é utilizado para definir um **título ou legenda** para a tabela.

Ele deve ser o primeiro elemento dentro da tag `<table>`.

Exemplo:

```html
<caption>Listagem de produtos</caption>
```

Nesse exemplo, **Listagem de produtos** será exibido como o título da tabela.

O uso de `<caption>` melhora a organização do conteúdo e também contribui para a acessibilidade da página.

------

#### Tag `<thead>`

O elemento `<thead>` (**Table Head**) representa o **cabeçalho da tabela**.

Dentro dele normalmente ficam as linhas que contêm as células de cabeçalho (`<th>`).

Exemplo:

```html
<thead>
    <tr>
        <th>Produto</th>
        <th>Quantidade</th>
        <th>Preço</th>
    </tr>
</thead>
```

Nesse exemplo:

- O `<thead>` agrupa o cabeçalho da tabela.
- Os elementos `<th>` identificam o significado de cada coluna.

Essa organização facilita a leitura do código e permite que navegadores e leitores de tela reconheçam corretamente o cabeçalho da tabela.

------

#### Tag `<tbody>`

O elemento `<tbody>` (**Table Body**) representa o **corpo da tabela**.

É nele que ficam os dados principais apresentados ao usuário.

Exemplo:

```html
<tbody>
    <tr>
        <td>Notebook</td>
        <td>1</td>
        <td>R$2.000,00</td>
    </tr>

    <tr>
        <td>Tablet</td>
        <td>1</td>
        <td>R$1.000,00</td>
    </tr>
</tbody>
```

Nesse caso:

- Cada `<tr>` representa uma linha de dados.
- Cada `<td>` contém uma informação referente ao produto.

O `<tbody>` separa claramente os dados do cabeçalho e do rodapé da tabela.

------

#### Tag `<tfoot>`

O elemento `<tfoot>` (**Table Footer**) representa o **rodapé da tabela**.

Normalmente é utilizado para apresentar informações finais, como:

- totais;
- médias;
- observações;
- resumos dos dados.

Exemplo:

```html
<tfoot>
    <tr>
        <td>Total</td>
        <td colspan="2">R$3.000,00</td>
    </tr>
</tfoot>
```

Nesse exemplo:

- A primeira célula informa que a linha representa o **Total**.
- A segunda célula utiliza `colspan="2"` para ocupar as duas últimas colunas da tabela.

------

#### Resumo das principais tags

| Elemento    | Função                                                       |
| ----------- | ------------------------------------------------------------ |
| `<caption>` | Define o título ou legenda da tabela.                        |
| `<thead>`   | Agrupa o cabeçalho da tabela.                                |
| `<tbody>`   | Agrupa o corpo da tabela, onde ficam os dados principais.    |
| `<tfoot>`   | Agrupa o rodapé da tabela, geralmente utilizado para totais ou resumos. |

------

#### Código completo - mais-tabela.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mais tabelas</title>
</head>
<body>
    <h1>Mais sobre tabelas</h1>

    <!-- 
        caption -> Legenda / título da tabela
        thead -> Table Header (cabeçalho da tabela)
        tbody -> Table Body (corpo da tabela)
        tfoot -> Table Footer (rodapé da tabela)
    -->

    <table border="1">
        <caption>Listagem de produtos</caption>
        
        <thead>
            <tr>
                <th> Produto </th>
                <th> Quantidade </th>
                <th> Preço </th>
            </tr>
        </thead>

        <tbody>
            <tr>
                <td> Notebook </td>
                <td> 1 </td>
                <td> R$2.000,00 </td>
            </tr>
            <tr>
                <td> Tablet </td>
                <td> 1 </td>
                <td> R$1.000,00 </td>
            </tr>
        </tbody>

        <tfoot>
            <tr>
                <td> Total </td>
                <td colspan="2" > R$3.000,00 </td>
            </tr>
        </tfoot>
        
    </table>

</body>
</html>
```



#### Desafio da aula - tabela-exercicio.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tabelas</title>
</head>
<body>
    <h1> Tabelas - exercício </h1>
    <table border="1">
        <caption> Lista de países populosos </caption>
        <thead>
            <tr>
                <th> Posição </th>
                <th> País </th>
                <th> População aproximada (milhões) </th>
            </tr>
        </thead>

        <tbody>
            <tr>
                <td>1</td>
                <td>
                    <img src="./img/b1.jpg" alt="">
                    China
                </td>
                <td> 1.440 </td>
            </tr>
            <tr>
                <td>2</td>
                <td>
                    <img src="./img/b2.jpg" alt="">
                    Índia
                </td>
                <td> 1.380 </td>
            </tr>
            <tr>
                <td>3</td>
                <td>
                    <img src="./img/b3.jpg" alt="">
                    Estados Unidos
                </td>
                <td> 331  </td>
            </tr>
            <tr>
                <td>4</td>
                <td>
                    <img src="./img/b4.jpg" alt="">
                    Indonésia
                </td>
                <td> 273 </td>
            </tr>
            <tr>
                <td>5</td>
                <td>
                    <img src="./img/b5.jpg" alt="">
                    Paquistão
                </td>
                <td> 220 </td>
            </tr>
            <tr>
                <td>6</td>
                <td>
                    <img src="./img/b6.jpg" alt="">
                    Brasil
                </td>
                <td> 212 </td>
            </tr>
        </tbody>

        <tfoot>
            <tr>
                <td colspan="3">fonte: ficticio.com.br</td>
            </tr>
        </tfoot>

    </table>

</body>
</html>
```



#### Links da aula



_____

_____

-----



## Seção 6: HTML - Formulários e Mídias

### 27. Tabelas: Elementos de Tabela

Revisão de Tabelas, elementos e atributos.

#### Código completo - tabela2.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tabelas</title>
    <style>
        table, td, th{
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <h1>Tabelas</h1>
    <table>
        <tr>
            <th>Produto</th>
            <th>Quantidade</th>
            <th>Preço</th>
        </tr>
        <tr>
            <td>Notebook</td>
            <td>1</td>
            <td>R$2.000,00</td>
        </tr>
        <tr>
            <td>Tablet</td>
            <td>2</td>
            <td>R$1.000,00</td>
        </tr>
        <tr>
            <td rowspan="2" >Desconto</td>
            <td colspan="2" > Cupom 1 - R$20,00</td>
        </tr>
        <tr>
            <td colspan="2" > Cupom 2 - R$25,00</td>
        </tr>

    </table>
</body>
</html>
```



#### Links da aula

[Tabelas W3School](https://www.w3schools.com/tags/tag_table.asp)

[Tabelas Mozilla](https://developer.mozilla.org/en-US/docs/Web/HTML/Reference/Elements/table)



-----

-----



### 28. Tabelas: Estrutura Semântica

Revisão de Tabelas, elementos e atributos.

#### Código completo - mais-tabelas2.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mais tabelas 2</title>
</head>
<body>
    <h1>Mais Tabelas 2</h1>
    <table border="1" >
        <caption>Listagem de produtos</caption>
        <thead>
            <tr>
                <th>Produto</th>
                <th>Quantidade</th>
                <th>Preço</th>
            </tr>
        </thead>
        
        <tbody>
            <tr>
            <td>Notebook</td>
            <td>1</td>
            <td>R$2.000,00</td>
        </tr>
        <tr>
            <td>Tablet</td>
            <td>2</td>
            <td>R$1.000,00</td>
        </tr>
        </tbody>

        <tfoot>
            <tr>
                <td>Total</td>
                <td colspan="2">R$3.000,00</td>
            </tr>
        </tfoot>
    </table>

</body>
</html>
```



-----

-----



### 29. Finalizando #projeto1 UNES

#### Arquivo completo - quem-somos.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Unes - Quem Somos</title>
</head>
<body background="../img/fundo2.png" >
    
    <table border="0" width="900" align="center">
        <tr>
            <td height="89"> <img src="../img/logo.png" alt="Logo Unes"></td>
            <td align="right">
                <a href="../index.html"> Home </a> |
                <a href="./quem-somos.html"> Quem Somos </a> |
                <a href="./contato.html"> Contato </a>
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <h2>Quem Somos</h2>
                <p>
                    Lorem <strong>ipsum, dolor</strong> sit <em>amet</em> consectetur adipisicing elit. Architecto delectus odio, suscipit voluptas minima, harum dignissimos ipsa aspernatur labore accusantium tempore omnis. Itaque minus odio omnis nulla reiciendis exercitationem dolores. Lorem ipsum, dolor sit amet consectetur adipisicing elit. Architecto delectus odio, suscipit voluptas minima, harum dignissimos ipsa aspernatur labore accusantium tempore omnis. Itaque minus odio omnis nulla reiciendis exercitationem dolores.
                </p>

                <h2>5 motivos para estudar</h2>

                <ol>
                    <li>Material sempre atualizado</li>
                    <li>Tablets em sala de aula</li>
                    <li>Professores renomados</li>
                    <li>Universidade bem avaliada</li>
                    <li>Ótima localização</li>
                </ol>

                <hr>

                <h2>Objetivos</h2>

                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Officiis, maiores sit quos minus corporis, iusto, inventore porro minima voluptatum quibusdam placeat fuga assumenda soluta! A numquam obcaecati voluptatem molestiae ex. Lorem ipsum dolor sit amet consectetur adipisicing elit. Tempore tempora commodi eligendi dolor. Consequatur nam dolorum illum recusandae, modi pariatur autem voluptas eveniet corporis debitis sunt cum, sit quas harum!
                </p>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <h4>Todos os direitos reservados</h4>
            </td>
        </tr>

    </table>

</body>
</html>
```

#### Arquivo completo - contato.html

```html
<!DOCTYPE html>
<html lang="pt-BT">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Unes - Contato</title>
</head>
<body background="../img/fundo2.png" >
    
    <table border="0" width="900" align="center">
        <tr>
            <td height="89"> <img src="../img/logo.png" alt="Logo Unes"></td>
            <td align="right">
                <a href="../index.html"> Home </a> |
                <a href="./quem-somos.html"> Quem Somos </a> |
                <a href="./contato.html"> Contato </a>
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <h2>Entre em contato</h2>
                <p>
                    Lorem ipsum, dolor sit amet consectetur adipisicing elit. Architecto delectus odio, suscipit voluptas minima, harum dignissimos ipsa aspernatur labore accusantium tempore omnis. Itaque minus odio omnis nulla reiciendis exercitationem dolores.
                </p>

                <hr>

                <form action="">
                    Seu e-mail: <br>
                    <input type="text" name="email"><br>

                    Assunto: <br>
                    <input type="text" name="email"><br>

                    Descrição: <br>
                    <textarea name="" id=""></textarea><br>

                    <input type="submit" value="Enviar">
                </form>

            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <h4>Todos os direitos reservados</h4>
            </td>
        </tr>

    </table>

</body>
</html>
```



-----

-----



### 30.Página inicial do #projeto1 UNES

Projeto Unes Universidade

#### Arquivo completo - index.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Unes - Página principal</title>
</head>
<body background="img/fundo.png">
    

    <table border="0" width="900" align="center">
        <tr>
            <td height="89"> <img src="./img/logo.png" alt="Logo Unes"></td>
            <td align="right">
                <a href="./index.html"> Home </a> |
                <a href="./conteudo/quem-somos.html"> Quem Somos </a> |
                <a href="./conteudo/contato.html"> Contato </a>
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <img src="./img/capa.png" alt="Imagem da Capa">
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <h2>Sobre a Universidade</h2>
                <p>
                    Lorem <strong>ipsum, dolor</strong> sit <em>amet</em> consectetur adipisicing elit. Architecto delectus odio, suscipit voluptas minima, harum dignissimos ipsa aspernatur labore accusantium tempore omnis. Itaque minus odio omnis nulla reiciendis exercitationem dolores. Lorem ipsum, dolor sit amet consectetur adipisicing elit. Architecto delectus odio, suscipit voluptas minima, harum dignissimos ipsa aspernatur labore accusantium tempore omnis. Itaque minus odio omnis nulla reiciendis exercitationem dolores.
                </p>
                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Officiis, maiores sit quos minus corporis, iusto, inventore porro minima voluptatum quibusdam placeat fuga assumenda soluta! A numquam obcaecati voluptatem molestiae ex. Lorem ipsum dolor sit amet consectetur adipisicing elit. Tempore tempora commodi eligendi dolor. Consequatur nam dolorum illum recusandae, modi pariatur autem voluptas eveniet corporis debitis sunt cum, sit quas harum!
                </p>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <h4>Todos os direitos reservados</h4>
            </td>
        </tr>

    </table>

</body>
</html>
```



-----

-----



### 31. Formulários: Introdução


#### O que é um formulário?

Um **formulário** é um elemento do HTML utilizado para **coletar informações fornecidas pelo usuário**. Essas informações podem ser enviadas para um servidor, onde serão processadas, armazenadas ou utilizadas por uma aplicação.

Os formulários são fundamentais para a interação entre o usuário e um site, permitindo o envio de dados como cadastro, login, pesquisas, comentários, pagamentos, buscas, entre outros.

------

#### Para que serve um formulário?

Os formulários têm como principal objetivo **permitir a entrada de dados** pelo usuário.

Alguns exemplos de uso são:

- Cadastro de usuários;
- Login em sistemas;
- Formulários de contato;
- Pesquisas e questionários;
- Compras em lojas virtuais;
- Agendamento de serviços;
- Envio de arquivos;
- Busca de informações.

Sem formulários, uma página HTML seria apenas informativa, sem permitir interação por meio do envio de dados.

------

#### Tipos de elementos de formulário (inputs)

Um formulário pode conter diversos elementos responsáveis por coletar diferentes tipos de informação.

Os principais são:

- **Campo de texto:** utilizado para inserir textos curtos, como nome ou cidade.
- **Campo de senha:** oculta os caracteres digitados pelo usuário.
- **Campo de e-mail:** recebe endereços de e-mail e pode realizar validações automáticas.
- **Campo numérico:** aceita apenas valores numéricos.
- **Campo de data:** permite selecionar uma data.
- **Campo de telefone:** destinado à digitação de números telefônicos.
- **Campo de pesquisa:** utilizado para buscas dentro de um site.
- **Botões de opção (Radio Button):** permitem selecionar apenas uma opção entre várias.
- **Caixas de seleção (Checkbox):** permitem selecionar uma ou mais opções.
- **Lista suspensa (Select):** apresenta uma lista de opções para escolha.
- **Área de texto (Textarea):** utilizada para textos longos, como mensagens ou comentários.
- **Botões (Button):** executam ações, como enviar ou limpar o formulário.
- **Campo para envio de arquivos:** permite anexar documentos, imagens e outros arquivos.

Cada tipo de elemento é adequado para uma finalidade específica, proporcionando uma melhor experiência ao usuário e facilitando a validação das informações.

------

#### Como funciona um formulário?

O funcionamento de um formulário pode ser dividido em quatro etapas principais:

1. O usuário preenche os campos disponíveis na página.
2. Ao clicar no botão de envio, o navegador reúne todos os dados informados.
3. Essas informações são enviadas para um endereço configurado no formulário.
4. O servidor recebe os dados, realiza o processamento e retorna uma resposta ao navegador.

Essa resposta pode ser, por exemplo:

- confirmar um cadastro;
- autenticar um usuário;
- armazenar informações em um banco de dados;
- enviar um e-mail;
- apresentar uma mensagem de erro;
- exibir uma nova página.

------

#### Como os dados são recebidos pelo servidor?

Quando o usuário envia um formulário, o navegador cria uma **requisição HTTP** contendo todas as informações preenchidas.

Cada campo enviado possui dois componentes:

- **Nome do campo (name):** identifica qual informação está sendo enviada.
- **Valor (value):** corresponde ao dado informado pelo usuário.

O servidor recebe esses pares de dados (nome e valor), interpreta cada informação e decide o que fazer com ela.

Por exemplo, em um formulário de login, o servidor pode receber informações como:

- usuário → joao123
- senha → ********

Após receber esses dados, a aplicação pode:

- verificar se o usuário existe;
- validar a senha;
- consultar um banco de dados;
- criar uma sessão de autenticação;
- devolver uma resposta ao navegador.

Todo esse processamento ocorre no **back-end** da aplicação, utilizando linguagens como PHP, Java, Python, C#, Node.js, Ruby, entre outras.

------

#### Fluxo simplificado do funcionamento de um formulário

O processo de envio de um formulário pode ser resumido da seguinte forma:

1. O usuário preenche o formulário.
2. O navegador coleta todas as informações.
3. Os dados são enviados ao servidor por meio de uma requisição HTTP.
4. O servidor processa as informações.
5. O servidor retorna uma resposta ao navegador.
6. O navegador exibe o resultado ao usuário.

------

#### Resumo dos principais conceitos

| Conceito                     | Definição                                                    |
| ---------------------------- | ------------------------------------------------------------ |
| **Formulário**               | Elemento utilizado para coletar informações do usuário e enviá-las para um servidor. |
| **Entrada de dados (Input)** | Elementos que permitem ao usuário informar dados, como texto, senha, e-mail, números, datas e arquivos. |
| **Botões de seleção**        | Permitem escolher uma ou mais opções (radio e checkbox).     |
| **Lista suspensa**           | Exibe uma lista de opções para seleção.                      |
| **Área de texto**            | Campo destinado à digitação de textos longos.                |
| **Envio do formulário**      | Processo em que o navegador reúne todos os dados preenchidos e os envia ao servidor. |
| **Servidor**                 | Responsável por receber, processar, validar, armazenar ou utilizar os dados enviados pelo formulário. |
| **Requisição HTTP**          | Comunicação realizada pelo navegador para enviar os dados do formulário ao servidor. |
| **Nome e valor dos campos**  | Cada informação enviada é composta pelo nome do campo e pelo valor digitado pelo usuário. |



-----

-----



### 32. Formulários: Entendendo na prática



Os formulários permitem que o usuário **insira informações em uma página web** para que esses dados sejam enviados e processados por um servidor. Eles são amplamente utilizados em páginas de login, cadastros, pesquisas, formulários de contato, compras on-line e diversas outras aplicações.

Um formulário é composto por diferentes elementos, cada um com uma função específica na coleta e envio dos dados.

------

#### Tag `<form>`

O elemento `<form>` representa um **formulário HTML**. Todos os campos utilizados para coletar informações do usuário devem estar dentro dessa tag.

Além de agrupar os elementos do formulário, ela define **para onde os dados serão enviados** e **como serão enviados**.

------

#### Atributo `action`

O atributo `action` especifica **o endereço da página ou do servidor que receberá os dados do formulário** após o envio.

No código apresentado, o valor é:

- `processa.html`

Isso significa que, ao enviar o formulário, o navegador encaminhará as informações para esse arquivo.

------

#### Atributo `method`

O atributo `method` define **o método HTTP utilizado para enviar os dados ao servidor**.

Os métodos mais comuns são:

- **GET:** envia os dados na própria URL da página. É indicado para pesquisas e informações que não sejam sensíveis.
- **POST:** envia os dados no corpo da requisição, sendo mais apropriado para logins, cadastros e envio de informações confidenciais.

No exemplo, foi utilizado o método **GET**.

------

#### Tag `<input>`

O elemento `<input>` é o principal componente de um formulário.

Ele é utilizado para criar campos onde o usuário poderá inserir informações.

Seu comportamento depende do valor definido no atributo `type`.

------

#### Atributo `type`

O atributo `type` determina **o tipo de campo** que será exibido ao usuário.

No código apresentado são utilizados três tipos.

##### `type="text"`

Cria um campo de texto simples.

É utilizado para informações como:

- nome;
- e-mail;
- cidade;
- profissão;
- entre outras.

------

##### `type="password"`

Cria um campo para senhas.

Os caracteres digitados são ocultados por símbolos (como ● ou •), aumentando a privacidade durante a digitação.

------

##### `type="submit"`

Cria um botão responsável por **enviar o formulário**.

Ao ser clicado, o navegador coleta todos os dados preenchidos e os envia para o endereço definido no atributo `action`.

------

#### Atributo `name`

O atributo `name` identifica cada campo do formulário.

É através dele que o servidor consegue reconhecer cada informação enviada.

Por exemplo:

- `email`
- `senha`
- `comentario`

Quando o formulário é enviado, cada valor digitado será associado ao respectivo nome do campo.

------

#### Tag `<textarea>`

O elemento `<textarea>` é utilizado para criar um **campo de texto de múltiplas linhas**.

É indicado para informações longas, como:

- comentários;
- mensagens;
- observações;
- descrições.

Diferentemente do `<input>`, o `<textarea>` permite que o usuário escreva várias linhas de texto.

------

#### Atributo `placeholder`

O atributo `placeholder` exibe um **texto de orientação** dentro do campo antes que o usuário comece a digitar.

Esse texto desaparece automaticamente quando o campo recebe conteúdo.

Seu objetivo é indicar ao usuário qual informação deve ser preenchida.

------

#### Tag `<button>`

O elemento `<button>` cria um botão personalizável.

Diferentemente do `<input type="submit">`, ele pode conter não apenas texto, mas também:

- imagens;
- ícones;
- outros elementos HTML.

No exemplo, o botão possui uma imagem e o texto **Entrar**.

------

#### Atributo `type="submit"` no botão

Quando o botão possui o atributo `type="submit"`, sua função é **enviar o formulário**.

Ao ser clicado, todos os dados preenchidos são enviados para o endereço definido pelo atributo `action`.

------

#### Tag `<img>` dentro do botão

Uma imagem pode ser inserida dentro do botão para tornar sua aparência mais intuitiva ou atrativa.

No exemplo, a imagem funciona apenas como um ícone ilustrativo ao lado do texto **Entrar**.

------

#### Diferença entre `<button>` e `<input type="submit">`

Ambos podem enviar um formulário, porém possuem características diferentes.

##### `<button>`

- Permite inserir texto, imagens e outros elementos HTML.
- Possui maior flexibilidade para personalização.

##### `<input type="submit">`

- Cria um botão simples.
- O texto exibido é definido pelo atributo `value`.
- Não permite adicionar imagens ou outros elementos HTML em seu interior.

------

#### Resumo das principais tags e atributos

| Elemento ou atributo | Função                                                       |
| -------------------- | ------------------------------------------------------------ |
| `<form>`             | Define um formulário HTML.                                   |
| `action`             | Indica o destino para onde os dados serão enviados.          |
| `method`             | Define o método HTTP utilizado no envio dos dados (`GET` ou `POST`). |
| `<input>`            | Cria um campo de entrada de dados.                           |
| `type="text"`        | Campo para entrada de texto simples.                         |
| `type="password"`    | Campo para digitação de senhas, ocultando os caracteres.     |
| `type="submit"`      | Cria um botão para enviar o formulário.                      |
| `name`               | Identifica cada campo enviado ao servidor.                   |
| `<textarea>`         | Cria uma área de texto com múltiplas linhas.                 |
| `placeholder`        | Exibe um texto de orientação antes da digitação.             |
| `<button>`           | Cria um botão personalizável que pode conter texto, imagens e outros elementos HTML. |
| `<img>`              | Exibe uma imagem, podendo ser utilizada como ícone dentro de um botão. |

------

#### Código completo - arquivo formularios.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulários</title>
</head>
<body>

    <h1>Formulários</h1>

    <form action="processa.html" method="get">

        Email: <br>
        <input type="text" name="email"> <br>

        Senha: <br>
        <input type="password" name="senha"> <br>

        Comentário: <br>
        <textarea
            name="comentario"
            placeholder="Digite um comentário">
        </textarea> <br>

        <button type="submit">
            <img
                src="./imagens/p6.png"
                alt="Button"
                width="15">
            Entrar
        </button>

        <input
            type="submit"
            value="Entrar">

    </form>

</body>
</html>
```



-----

-----



### 33. Formulários: Descobrindo Mais Elementos

Além dos campos básicos de um formulário, o HTML oferece diversos elementos que melhoram a **organização**, **acessibilidade** e **experiência do usuário** durante o preenchimento das informações.

Neste exemplo são apresentados novos elementos bastante utilizados na construção de formulários.

------

#### Tag `<label>`

O elemento `<label>` representa um **rótulo** para um campo do formulário.

Sua principal função é informar ao usuário qual informação deve ser preenchida em determinado campo.

Além disso, quando o `<label>` está associado corretamente a um campo, basta clicar no texto do rótulo para que o cursor seja direcionado automaticamente ao elemento correspondente.

Isso melhora a acessibilidade e facilita a utilização do formulário.

------

#### Atributo `for`

O atributo `for` é utilizado na tag `<label>` para indicar **qual elemento do formulário está sendo identificado**.

O valor do atributo `for` deve ser exatamente igual ao valor do atributo `id` do campo correspondente.

Essa associação permite que o navegador relacione corretamente o rótulo ao campo.

------

#### Atributo `id`

O atributo `id` fornece um **identificador único** para um elemento HTML.

Nos formulários, ele é utilizado principalmente para conectar um `<label>` ao seu respectivo campo de entrada.

Cada `id` deve ser único dentro da página.

------

#### `type="email"`

O tipo `email` cria um campo destinado à digitação de endereços de e-mail.

Os navegadores modernos realizam uma validação básica do formato informado, verificando se o texto possui uma estrutura semelhante a um endereço de e-mail.

Em dispositivos móveis, também pode exibir um teclado adaptado para facilitar a digitação.

------

#### `type="radio"`

O tipo `radio` cria um **botão de opção**.

Ele é utilizado quando o usuário deve escolher **apenas uma alternativa** entre várias opções.

Todos os botões que pertencem ao mesmo grupo devem possuir o mesmo atributo `name`.

Dessa forma, ao selecionar uma opção, as demais são automaticamente desmarcadas.

É muito utilizado para informações como:

- gênero;
- estado civil;
- forma de pagamento;
- tipo de entrega.

------

#### Atributo `value`

O atributo `value` define o **valor que será enviado ao servidor** quando um campo for selecionado ou preenchido.

No caso dos botões de opção e caixas de seleção, o usuário visualiza apenas o texto do `<label>`, mas o servidor recebe o valor definido em `value`.

------

#### `type="checkbox"`

O tipo `checkbox` cria uma **caixa de seleção**.

Diferentemente do botão de opção (`radio`), ele permite que o usuário selecione **uma, várias ou nenhuma opção**.

É indicado para situações em que múltiplas escolhas são permitidas, como:

- estilos musicais;
- idiomas;
- interesses;
- preferências.

------

#### Tag `<select>`

O elemento `<select>` cria uma **lista suspensa** (combo box).

Ela é utilizada quando existe um conjunto de opções pré-definidas e o usuário deve escolher uma delas.

Esse elemento ajuda a economizar espaço na página e evita erros de digitação.

------

#### Tag `<option>`

O elemento `<option>` representa cada uma das opções existentes dentro de um `<select>`.

Cada opção possui um texto exibido ao usuário e pode possuir um valor diferente que será enviado ao servidor.

------

#### `type="file"`

O tipo `file` cria um campo para **envio de arquivos**.

Por meio dele, o usuário pode selecionar documentos, imagens, vídeos, planilhas e outros arquivos armazenados em seu computador ou dispositivo.

Esse tipo de campo é amplamente utilizado em:

- envio de currículos;
- upload de fotos;
- anexos de documentos;
- sistemas de cadastro.

------

#### Tag `<fieldset>`

O elemento `<fieldset>` é utilizado para **agrupar campos relacionados** dentro de um formulário.

Seu objetivo é organizar visualmente as informações, tornando o formulário mais fácil de compreender e preencher.

Normalmente, o navegador desenha uma borda ao redor do grupo de campos.

------

#### Tag `<legend>`

O elemento `<legend>` define o **título de um grupo de campos** criado por um `<fieldset>`.

Esse título descreve o conjunto de informações presentes naquele grupo.

Por exemplo:

- Dados pessoais;
- Endereço;
- Informações profissionais;
- Dados adicionais.

O uso de `<legend>` melhora tanto a organização visual quanto a acessibilidade do formulário.

------

#### Resumo das principais tags e atributos

| Elemento ou atributo | Função                                                       |
| -------------------- | ------------------------------------------------------------ |
| `<label>`            | Define um rótulo para um campo do formulário.                |
| `for`                | Associa um `<label>` ao elemento cujo `id` possui o mesmo valor. |
| `id`                 | Identifica de forma única um elemento HTML.                  |
| `type="email"`       | Campo destinado à digitação de endereços de e-mail.          |
| `type="radio"`       | Permite selecionar apenas uma opção entre várias.            |
| `type="checkbox"`    | Permite selecionar uma ou mais opções.                       |
| `value`              | Define o valor enviado ao servidor quando o campo é selecionado ou preenchido. |
| `<select>`           | Cria uma lista suspensa de opções.                           |
| `<option>`           | Define cada opção existente dentro de uma lista suspensa.    |
| `type="file"`        | Permite selecionar e enviar arquivos para o servidor.        |
| `<fieldset>`         | Agrupa campos relacionados dentro de um formulário.          |
| `<legend>`           | Define o título ou legenda de um grupo de campos criado por um `<fieldset>`. |

------

#### Código completo - arquivo mais-formulario.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mais formulários</title>
</head>
<body>

    <h1>Mais sobre formulários</h1>

    <form action="processa.html" method="GET">

        <h2>Label</h2>

        <label for="name">Nome:</label>
        <input type="text" name="name" id="name">

        <label for="email">Email</label>
        <input type="email" name="email" id="email">

        <br><br>

        Gênero:<br>

        <input type="radio" name="genero" value="feminino" id="feminino">
        <label for="feminino">Feminino</label>

        <input type="radio" name="genero" value="masculino" id="masculino">
        <label for="masculino">Masculino</label>

        <br><br>

        Estilo Musical<br>

        <input type="checkbox" name="estilo" value="rock" id="rock">
        <label for="rock">Rock</label>

        <input type="checkbox" name="estilo" value="pop" id="pop">
        <label for="pop">Pop</label>

        <input type="checkbox" name="estilo" value="sertanejo" id="sertanejo">
        <label for="sertanejo">Sertanejo</label>

        <br><br>

        Estado:

        <select name="estado">
            <option value="">Selecione...</option>
            <option value="pe">Pernambuco</option>
            <option value="al">Alagoas</option>
            <option value="pb">Paraíba</option>
            <option value="se">Sergipe</option>
        </select>

        <br><br>

        Upload de arquivo:

        <input type="file" name="arquivo">

        <br><br>

        <input type="submit" value="Cadastrar">

    </form>

    <form>

        <h2>Fieldset & Legend</h2>

        <fieldset>

            <legend>Dados pessoais</legend>

            <label for="name2">Nome:</label>
            <input type="text" name="name" id="name2">

            <label for="email2">Email</label>
            <input type="email" name="email" id="email2">

        </fieldset>

        <fieldset>

            <legend>Dados adicionais</legend>

            Gênero:<br>

            <input type="radio" name="genero" value="feminino" id="feminino2">
            <label for="feminino2">Feminino</label>

            <input type="radio" name="genero" value="masculino" id="masculino2">
            <label for="masculino2">Masculino</label>

        </fieldset>

    </form>

</body>
</html>
```

> **Observação:** No segundo formulário, foi ajustado o valor dos atributos `id` dos botões de opção (`feminino2` e `masculino2`). Em um mesmo documento HTML, cada `id` deve ser **único**, evitando conflitos e garantindo que os elementos `<label>` funcionem corretamente.



-----

-----



### 34. Formulários: Exercício 1

#### Arquivo completo - trello.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Interface de login do Trello</title>

    <!--
      <script src="https://unpkg.com/@codans/trello"></script>
    -->

    <script src="https://unpkg.com/@codans/trello"></script>

</head>
<body>
    <img src="./img/trello.svg" alt="Logo trello" width="200">

    <h1>Fazer login no Trello</h1>

    <form action="" method="GET">

      <input type="email" name="email" id="email" placeholder="Insira o e-mail">
      <input type="password" name="senha" id="senha" placeholder="Insira a senha">
      <input type="submit" value="Fazer Login">

      <span>ou</span>

      <button>
        <img src="./img/google.svg" alt="Imagem do Google" width="20">
        Continuar com o Google
      </button>

      <button>
        <img src="./img/microsoft.svg" alt="Imagem da Microsoft" width="20">
        Continuar com a Microsoft
      </button>
      
      <button>
        <img src="./img/apple.svg" alt="Imagem da Apple" width="20">
        Continuar com a Apple
      </button>
      
      <button>
        <img src="./img/slack.svg" alt="Imagem do Slack" width="20">
        Continuar com o Slack
      </button>

    </form>

    <img src="./img/atlassian.svg" alt="Imagem da Atlassian" width="200">
    <img src="./img/analytics.svg" alt="Imagem Analytics" width="200">
    <img src="./img/interactive.svg" alt="Imagem Interactive" width="200">
  
</body>
</html>

```



-----

-----



### 35. Formulários: Exercício 2

#### Arquivo completo - exercicio-formulario-2

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercícios de formulários</title>
</head>
<body>
        <h1>Exercício de formulário</h1>

        <form action="../../processa.html" method="GET">
            <fieldset>
                <legend>Dados pessoais</legend>
                
                <label for="name">Nome</label><br>
                <input type="text" name="name" id="name"><br>
                
                <label for="email">Email</label><br>
                <input type="text" name="email" id="email"><br>

                <input type="checkbox" name="queroemail" value="ativado" id="queroemail">
                <label for="queroemail">Quero receber e-mail</label><br><br>

                <label for="senha">Senha</label><br>
                <input type="password" name="senha" id="senha">

            </fieldset>

            <fieldset>
                <legend>Informações adicionais</legend>

                <input type="radio" name="status" value="pessoafisica" id="pessoafisica">
                <label for="pessoafisica">Pessoa Física</label>
                <input type="radio" name="status" value="pessoajuridica" id="pessoafisica">
                <label for="pessoajuridica">Pessoa Jurídica</label>
            </fieldset>

            <br>
            <input type="submit" value="Cadastrar">
        </form>
        
</body>
</html>
```



-----

-----



### 36. HTML: Caracteres especiais



## HTML Entities (Caracteres especiais)

Os **HTML Entities** (entidades HTML) são códigos especiais utilizados para representar **caracteres que possuem significado próprio no HTML** ou caracteres que não estão facilmente disponíveis no teclado, como símbolos matemáticos, moedas, emojis e caracteres especiais.

Uma entidade HTML sempre começa com o caractere **`&`** (e comercial) e termina com **`;`** (ponto e vírgula).

Exemplo:

- `&amp;lt;`
- `&amp;copy;`
- `&amp;#128512;`

Ao interpretar o código, o navegador substitui essas entidades pelo caractere correspondente.

---

#### Por que utilizar HTML Entities?

Alguns caracteres possuem uma função especial na linguagem HTML.

Por exemplo, os símbolos `<` e `>` são utilizados para criar tags. Se forem digitados diretamente no código, o navegador tentará interpretá-los como elementos HTML.

Para exibir esses caracteres como texto comum, é necessário utilizar suas entidades HTML.

Além disso, as entidades permitem exibir símbolos que não existem no teclado ou que podem apresentar problemas de compatibilidade entre diferentes sistemas.

---

#### Caracteres reservados

Os caracteres reservados são aqueles que possuem um significado especial dentro do HTML.

Para exibi-los como texto, utilizam-se suas respectivas entidades.

Exemplos:

| Entidade   | Resultado | Descrição             |
| ---------- | --------- | --------------------- |
| &amp;lt;   | `<`       | Símbolo de menor que. |
| &amp;gt;   | `>`       | Símbolo de maior que. |
| &amp;amp;  | `&`       | E comercial.          |
| &amp;quot; | `"`       | Aspas duplas.         |
| &amp;apos; | `'`       | Aspas simples.        |

---

#### Símbolos especiais

As entidades HTML também permitem representar diversos símbolos utilizados em textos e documentos.

Alguns exemplos são:

| Entidade    | Resultado | Significado        |
| ----------- | --------- | ------------------ |
| &amp;copy;  | ©         | Direitos autorais. |
| &amp;reg;   | ®         | Marca registrada.  |
| &amp;trade; | ™         | Marca comercial.   |
| &amp;euro;  | €         | Euro.              |
| &amp;pound; | £         | Libra esterlina.   |
| &amp;yen;   | ¥         | Iene japonês.      |
| &amp;cent;  | ¢         | Centavo.           |

---

#### Símbolos matemáticos

Também é possível inserir símbolos utilizados em expressões matemáticas.

Exemplos:

| Entidade     | Resultado | Significado    |
| ------------ | --------- | -------------- |
| &amp;sum;    | ∑         | Somatório.     |
| &amp;plusmn; | ±         | Mais ou menos. |
| &amp;times;  | ×         | Multiplicação. |
| &amp;divide; | ÷         | Divisão.       |
| &amp;infin;  | ∞         | Infinito.      |
| &amp;radic;  | √         | Raiz quadrada. |

---

#### Símbolos diversos

O HTML possui centenas de entidades para diferentes áreas.

Exemplos:

| Entidade    | Resultado | Descrição         |
| ----------- | --------- | ----------------- |
| &amp;#9827; | ♣         | Naipe de paus.    |
| &amp;#9829; | ♥         | Naipe de copas.   |
| &amp;#9830; | ♦         | Naipe de ouros.   |
| &amp;#9824; | ♠         | Naipe de espadas. |

Nesse caso, foi utilizada uma **entidade numérica**, identificada pelo prefixo `&#`.

---

#### Emojis

Os emojis também podem ser inseridos em uma página HTML utilizando **entidades numéricas** baseadas no padrão Unicode.

Exemplo:

| Entidade      | Emoji |
| ------------- | ----- |
| &amp;#128512; | 😀     |
| &amp;#128511; | 👿     |
| &amp;#128525; | 😍     |
| &amp;#128640; | 🚀     |

Cada emoji possui um código Unicode próprio que pode ser representado por uma entidade HTML.

---

#### Entidades nomeadas e numéricas

Existem duas formas principais de representar uma entidade HTML.

##### Entidades nomeadas

Utilizam um nome descritivo.

Exemplos:

- `&amp;copy;`
- `&amp;euro;`
- `&amp;lt;`
- `&amp;gt;`

São mais fáceis de ler e memorizar.

---

##### Entidades numéricas

Utilizam o código Unicode do caractere.

Exemplos:

- `&amp;#169;` → ©
- `&amp;#8364;` → €
- `&amp;#9827;` → ♣
- `&amp;#128512;` → 😀

São úteis quando não existe uma entidade nomeada ou quando se deseja utilizar diretamente o código Unicode.

---

#### Resumo das principais HTML Entities

| Tipo              | Entidade      | Resultado |
| ----------------- | ------------- | --------- |
| Menor que         | &amp;lt;      | `<`       |
| Maior que         | &amp;gt;      | `>`       |
| E comercial       | &amp;amp;     | `&`       |
| Aspas duplas      | &amp;quot;    | `"`       |
| Direitos autorais | &amp;copy;    | ©         |
| Euro              | &amp;euro;    | €         |
| Somatório         | &amp;sum;     | ∑         |
| Naipe de paus     | &amp;#9827;   | ♣         |
| Emoji (Unicode)   | &amp;#128512; | 😀         |
| Emoji (Unicode)   | &amp;#128511; | 👿         |

> **Observação:** Existem milhares de HTML Entities disponíveis. Elas são utilizadas para representar caracteres reservados, símbolos matemáticos, moedas, letras especiais, emojis e diversos outros caracteres Unicode de forma compatível com os navegadores.



#### Código completo - caracteres-especiais.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Caracteres Especiais</title>
</head>
<body>
    <h1>Caracteres Especiais</h1>
        Tag de abertura de um parágrafo: &lt;p&gt; <br>
    	&euro; 4.19 <br>
        &#9827; <br>
        &#128511; 	&#128512;

        <h2>Exercício</h2>
        &lt;h1&gt; Damasceno &amp; co - 	&sum; &lt;h1/&gt; <br>
        &euro; 2.59 <br>
        &copy; Todos os direitos reservados
</body>
</html>
```



#### Links da aula

[Character references](https://html.spec.whatwg.org/multipage/named-characters.html#named-character-references)

[Character Entities](https://www.w3schools.com/html/html_entities.asp)



-----

-----





### 37. Mídias: Executar vídeos c/ HTML





























-----

