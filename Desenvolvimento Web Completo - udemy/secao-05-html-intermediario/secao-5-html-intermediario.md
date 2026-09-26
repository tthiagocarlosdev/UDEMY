# Desenvolvimento Web Completo

## Professor Hamilton Damasceno

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

#### `Lista aninhada (lista dentro de outra lista)

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

---

#### Arquivo completo - listas.html

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

---

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

---

#### Resumo dos principais atributos da tag `<img>`

| Atributo | Função                                                       |
| -------- | ------------------------------------------------------------ |
| `src`    | Define o caminho ou a URL da imagem que será exibida.        |
| `alt`    | Fornece uma descrição alternativa da imagem, importante para acessibilidade e para quando a imagem não puder ser carregada. |
| `width`  | Define a largura da imagem.                                  |
| `height` | Define a altura da imagem                                    |

---

#### Arquivo completo - imagens.html

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

---

#### Links da aula

[Imagens W3School](https://www.w3schools.com/html/html_images.asp)



---

---



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

---

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

---

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

#### Arquivo completo - fotos.html

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



---

---



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

---

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

---

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

---

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

---

#### Resumo das principais tags e propriedades

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

#### Arquivo completo - links.html

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

---

#### Links da aula

[Tag a W3School](https://www.w3schools.com/tags/tag_a.asp)



---

---



### 24. Links: Mais sobre as Âncoras

Desafio página mercado livre.

#### Arquivo completo - index.html

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

#### Arquivo completo - produtos.html

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

#### Arquivo completo - contato.html

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



---

---



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

---

#### Links da aula

[Tabelas 3WSchool](https://www.w3schools.com/tags/tag_table.asp)

[Tabelas Mozilla](https://developer.mozilla.org/en-US/docs/Web/HTML/Reference/Elements/table)



---

---



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

---

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























