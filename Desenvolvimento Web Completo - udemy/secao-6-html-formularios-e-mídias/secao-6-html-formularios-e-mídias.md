# Desenvolvimento Web Completo

## Professor Hamilton Damasceno

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



---



#### Links da aula

[Tabelas W3School](https://www.w3schools.com/tags/tag_table.asp)

[Tabelas Mozilla](https://developer.mozilla.org/en-US/docs/Web/HTML/Reference/Elements/table)



---

---



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

---

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



###  30.Página inicial do #projeto1 UNES

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



---

---



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

Vídeos e conteúdos incorporados em HTML

As tags `<video>` e `<iframe>` permitem adicionar **conteúdo multimídia e conteúdo externo** a uma página HTML.

A tag `<video>` é utilizada para reproduzir arquivos de vídeo diretamente na página. Já a tag `<iframe>` permite incorporar outro conteúdo ou documento dentro da página atual, como vídeos do YouTube ou outra página HTML.

------

#### Tag `<video>`

A tag `<video>` é utilizada para **incorporar e reproduzir vídeos** diretamente em uma página HTML.

Ela permite controlar características da reprodução por meio de atributos, como tamanho, controles, reprodução automática e repetição.

------

##### Atributo `width`

Define a **largura do vídeo**, normalmente em pixels.

No exemplo:

```text
width="320"
```

O vídeo terá 320 pixels de largura.

------

##### Atributo `controls`

Exibe os **controles de reprodução** do vídeo.

Quando presente, o navegador disponibiliza controles como:

- Play/Pause;
- Volume;
- Barra de progresso;
- Tela cheia;
- Outras opções dependendo do navegador.

É um atributo booleano, portanto sua presença já é suficiente para ativá-lo.

------

##### Atributo `muted`

Inicia o vídeo **sem áudio**.

Também é um atributo booleano.

É especialmente importante quando o vídeo utiliza `autoplay`, pois os navegadores normalmente bloqueiam a reprodução automática de vídeos que iniciam com áudio.

------

##### Atributo `autoplay`

Faz com que o vídeo tente **começar a reprodução automaticamente** assim que estiver disponível.

Como os navegadores possuem políticas contra reprodução automática com áudio, é comum utilizar `autoplay` junto com `muted`.

------

##### Atributo `loop`

Faz com que o vídeo seja **reproduzido novamente automaticamente quando chegar ao final**.

Dessa forma, o vídeo permanece em reprodução contínua.

------

##### Atributo `poster`

Define uma **imagem de capa** que será exibida antes de o vídeo começar a ser reproduzido.

No exemplo:

```text
poster="imagens/ferrari.jpg"
```

A imagem `ferrari.jpg` será utilizada como capa do vídeo.

O caminho definido em `poster` pode ser relativo ou absoluto, assim como acontece com o atributo `src` de imagens.

------

#### Tag `<source>`

A tag `<source>` define o **arquivo de vídeo que será utilizado pelo elemento `<video>`**.

Ela é colocada dentro de `<video>`.

O arquivo pode estar:

- Localmente no projeto;
- Hospedado em outro servidor.

------

##### Atributo `src` do `<source>`

Define o **caminho ou endereço do arquivo de vídeo**.

No primeiro exemplo:

```text
src="./videos/abelhas.mp4"
```

O vídeo está armazenado localmente no projeto.

No segundo:

```text
src="http://site.com.br/video.mp4"
```

O vídeo está localizado em um servidor externo.

------

##### Atributo `type` do `<source>`

Informa ao navegador o **tipo MIME do arquivo de mídia**.

No exemplo:

```text
type="video/mp4"
```

indica que o arquivo é um vídeo no formato MP4.

Esse atributo ajuda o navegador a identificar o formato do conteúdo.

------

#### Tag `<iframe>`

A tag `<iframe>` (**Inline Frame**) permite **incorporar outro conteúdo dentro da página atual**.

Ela cria uma espécie de janela dentro da página, na qual outro documento ou conteúdo pode ser carregado.

No código apresentado, existem dois exemplos:

- Um vídeo do YouTube;
- Uma página HTML local do próprio projeto.

------

#### Incorporando vídeos do YouTube

Um dos usos mais comuns do `<iframe>` é incorporar vídeos de plataformas como o YouTube.

O endereço utilizado no atributo `src` determina qual conteúdo será carregado dentro do `<iframe>`.

------

##### Atributo `src` do `<iframe>`

Define o **endereço do conteúdo que será incorporado**.

No exemplo do YouTube:

```text
src="https://www.youtube-nocookie.com/embed/..."
```

O conteúdo carregado será o vídeo correspondente.

No segundo `<iframe>`:

```text
src="./desafios/unes-universidade/index.html"
```

O conteúdo é uma página HTML localizada dentro do próprio projeto.

------

##### Atributo `height`

Define a **altura** do elemento, normalmente em pixels.

Por exemplo:

```text
height="315"
```

define uma altura de 315 pixels.

------

##### Atributo `width`

No `<iframe>`, assim como no `<video>`, define a **largura** do elemento.

Por exemplo:

```text
width="560"
```

define uma largura de 560 pixels.

------

##### Atributo `title`

O atributo `title` fornece uma **descrição do conteúdo do `<iframe>`**.

É especialmente importante para **acessibilidade**, pois permite que tecnologias assistivas, como leitores de tela, identifiquem o conteúdo incorporado.

No exemplo:

```text
title="YouTube video player"
```

informa que aquele `<iframe>` contém um player de vídeo do YouTube.

------

##### Atributo `frameborder`

O atributo `frameborder` era utilizado para definir se o `<iframe>` teria uma borda.

No exemplo:

```text
frameborder="0"
```

indica que a borda deve ser removida.

Esse atributo é **obsoleto no HTML5**. Atualmente, recomenda-se utilizar CSS para controlar bordas.

------

##### Atributo `allow`

Define quais **recursos e funcionalidades do navegador** podem ser utilizados pelo conteúdo incorporado.

No exemplo:

```text
allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
```

são permitidas funcionalidades como reprodução automática, aceleração, modo picture-in-picture e outros recursos utilizados pelo player.

------

##### Atributo `referrerpolicy`

Define **quais informações de referência (referrer)** o navegador deve enviar ao acessar o conteúdo incorporado.

No exemplo:

```text
referrerpolicy="strict-origin-when-cross-origin"
```

é utilizada uma política que limita as informações de referência enviadas quando o conteúdo é carregado de outro domínio.

------

##### Atributo `allowfullscreen`

Permite que o conteúdo incorporado utilize o **modo de tela cheia**.

É utilizado principalmente em `<iframe>` que incorporam vídeos.

É um atributo booleano, portanto sua presença ativa a funcionalidade.

------

#### Resumo das principais tags, atributos e valores

| Elemento/Atributo | Função                                                    | Exemplo de valor                  |
| ----------------- | --------------------------------------------------------- | --------------------------------- |
| `<video>`         | Reproduz vídeos na página                                 | —                                 |
| `<source>`        | Define o arquivo de mídia utilizado pelo `<video>`        | —                                 |
| `width`           | Define a largura                                          | `320`                             |
| `height`          | Define a altura                                           | `315`                             |
| `controls`        | Exibe os controles do vídeo                               | —                                 |
| `muted`           | Inicia o vídeo sem áudio                                  | —                                 |
| `autoplay`        | Inicia a reprodução automaticamente                       | —                                 |
| `loop`            | Repete o vídeo continuamente                              | —                                 |
| `poster`          | Define a imagem de capa do vídeo                          | `imagens/ferrari.jpg`             |
| `src`             | Define o endereço do conteúdo                             | `./videos/abelhas.mp4`            |
| `type`            | Informa o tipo MIME da mídia                              | `video/mp4`                       |
| `<iframe>`        | Incorpora outro conteúdo ou documento                     | —                                 |
| `title`           | Descreve o conteúdo do iframe                             | `YouTube video player`            |
| `frameborder`     | Define a borda do iframe; obsoleto no HTML5               | `0`                               |
| `allow`           | Define funcionalidades permitidas ao conteúdo incorporado | `autoplay; ...`                   |
| `referrerpolicy`  | Define a política de envio do referrer                    | `strict-origin-when-cross-origin` |
| `allowfullscreen` | Permite o modo de tela cheia                              | —                                 |

------

#### Código completo - arquivo video.html

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Videos</title>
</head>
<body>
    <h1>Executando vídeos</h1>

    <video width="320" controls muted autoplay loop poster="imagens/ferrari.jpg">
        <source src="./videos/abelhas.mp4" type="video/mp4">
    </video>

    <video width="320" controls muted loop poster="imagens/ferrari.jpg">
        <source src="http://site.com.br/video.mp4" type="video/mp4">
    </video>

    <iframe width="560" height="315" 
        src="https://www.youtube-nocookie.com/embed/tPbK3eOJLXQ?si=PWga5a-hglWMFJQB" 
        title="YouTube video player" 
        frameborder="0" 
        allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" 
        referrerpolicy="strict-origin-when-cross-origin" 
        allowfullscreen>
    </iframe>
    
    <iframe width="1024" height="400" src="./desafios/unes-universidade/index.html" frameborder="0"></iframe>

</body>
</html>
```



#### Links da aula

[Tag video 3WSchool](https://www.w3schools.com/html/html5_video.asp)

[Pixabay](https://pixabay.com/pt/videos/) videos e fotos

[Video youtube](https://www.youtube.com/watch?v=tPbK3eOJLXQ) usado na aula



-----

-----



### 38. VS Code: Emmet

#### Emmet Abbreviation

**Emmet Abbreviation** é um recurso presente em diversos editores de código que permite **escrever estruturas HTML e CSS de forma rápida utilizando abreviações**.

Em vez de escrever manualmente várias tags, podemos utilizar uma sintaxe curta e deixar o Emmet gerar a estrutura automaticamente.

A ideia principal é utilizar operadores para representar a **hierarquia, repetição e agrupamento** dos elementos.

------

#### Operador `>`

O operador `>` indica que o elemento da direita será **filho direto** do elemento da esquerda.

##### Fórmula

```text
table>tr>td
```

Significa:

- `table` contém `tr`;
- `tr` contém `td`.

Resultado:

```html
<table>
    <tr>
        <td></td>
    </tr>
</table>
```

------

#### Operador `*`

O operador `*` indica **repetição**.

O número depois do `*` determina quantas vezes o elemento será criado.

##### Fórmula

```text
table>tr>td*5
```

Significa:

- Criar uma `<table>`;
- dentro dela, criar uma `<tr>`;
- dentro da `<tr>`, criar **5 elementos `<td>`**.

Resultado:

```html
<table>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>
```

------

#### Operador `+`

O operador `+` indica que os elementos estarão no **mesmo nível hierárquico**, ou seja, serão elementos irmãos.

##### Fórmula

```text
p>h1+h2
```

Significa:

- Criar um `<p>`;
- dentro dele, criar um `<h1>` e um `<h2>`.

Resultado:

```html
<p>
    <h1></h1>
    <h2></h2>
</p>
```

**Observação:** embora o Emmet consiga gerar essa estrutura, ela não representa uma estrutura HTML semanticamente adequada, pois elementos de título (`h1`, `h2`) não devem ser filhos de `<p>`.

------

#### Parênteses `()`

Os parênteses são utilizados para **agrupar partes de uma abreviação**.

Eles permitem combinar diferentes estruturas e aplicar operadores a grupos específicos.

##### Fórmula

```text
(table>tr>td*5)+(h1+h2)
```

Podemos interpretar em duas partes:

```text
(table>tr>td*5)
```

Cria uma tabela com uma linha contendo cinco células.

E:

```text
(h1+h2)
```

Cria um `<h1>` e um `<h2>` no mesmo nível.

O `+` entre os dois grupos coloca as duas estruturas lado a lado.

Resultado:

```html
<table>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>

<h1></h1>
<h2></h2>
```

------

#### Criando listas com repetição

##### Fórmula

```text
ul>li*10
```

Significa:

- Criar uma lista não ordenada `<ul>`;
- dentro dela, criar **10 elementos `<li>`**.

Resultado:

```html
<ul>
    <li></li>
    <li></li>
    <li></li>
    <li></li>
    <li></li>
    <li></li>
    <li></li>
    <li></li>
    <li></li>
    <li></li>
</ul>
```

------

#### Combinando `>` e `*`

##### Fórmula

```text
ul>li*10>p*2
```

Aqui temos uma combinação de operadores.

Primeiro:

```text
ul
```

Cria uma lista.

Depois:

```text
>li*10
```

Cria **10 `<li>` dentro do `<ul>`**.

Por fim:

```text
>p*2
```

Cria **2 `<p>` dentro de cada `<li>`**.

Resultado:

```html
<ul>
    <li>
        <p></p>
        <p></p>
    </li>
    <li>
        <p></p>
        <p></p>
    </li>
    ...
</ul>
```

Portanto, serão criados:

- 1 `<ul>`;
- 10 `<li>`;
- 20 `<p>` — dois para cada `<li>`.

------

#### Formulários

O Emmet também é bastante útil para criar rapidamente estruturas de formulários.

##### Fórmula

```text
form>input*3
```

Significa:

- Criar um `<form>`;
- dentro dele, criar 3 elementos `<input>`.

Resultado:

```html
<form>
    <input>
    <input>
    <input>
</form>
```

------

#### Misturando `*` e `+`

##### Fórmula

```text
form>input*2+h1
```

Aqui é importante observar a **hierarquia dos operadores**.

A expressão significa:

- Criar um `<form>`;
- dentro dele, criar dois `<input>`;
- ainda dentro do `<form>`, criar um `<h1>`.

Resultado:

```html
<form>
    <input>
    <input>
    <h1></h1>
</form>
```

------

#### Agrupando estruturas com parênteses

##### Fórmula

```text
(form>input*2)+(h1+h2+p)
```

Temos dois grupos separados.

##### Primeiro grupo

```text
(form>input*2)
```

Cria:

```html
<form>
    <input>
    <input>
</form>
```

##### Segundo grupo

```text
(h1+h2+p)
```

Cria três elementos no mesmo nível:

```html
<h1></h1>
<h2></h2>
<p></p>
```

Portanto, o resultado completo será:

```html
<form>
    <input>
    <input>
</form>

<h1></h1>
<h2></h2>
<p></p>
```

------

#### Resumo dos operadores do Emmet

| Operador | Função                 | Exemplo   |
| -------- | ---------------------- | --------- |
| `>`      | Cria um elemento filho | `ul>li`   |
| `+`      | Cria elementos irmãos  | `h1+h2`   |
| `*`      | Repete um elemento     | `li*5`    |
| `()`     | Agrupa estruturas      | `(h1+h2)` |

##### Regra prática

Você pode pensar no Emmet desta forma:

- **`>` = dentro de**
- **`+` = ao lado de**
- **`\*` = repetir**
- **`()` = agrupar**

Por exemplo:

```text
ul>li*5
```

pode ser lido como:

> **ul → dentro de → li → repetir 5 vezes**

E:

```text
(h1+h2)+p
```

pode ser lido como:

> **h1 ao lado de h2, ao lado de p**.



-----

-----

### 39. [Projeto] Site Oficial do Discord

#### Arquivo completo desafio Discord - index.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>DISCORD | Seu lugar par Papear e Ficar de Boa!</title>

    <script src="https://unpkg.com/@codans/discord"></script>

</head>
<body>
    
    <!-- barra de navegação -->
    <img src="./img/logo.svg" alt="logo discord">
    <a href="">Baixar</a>
    <a href="">Nitro</a>
    <a href="">Segurança</a>
    <a href="">Suporte</a>
    <button type="button">
        <a href="">Entrar</a>
    </button>

    <!-- destaque -->
    <h1>Imagine um lugar...</h1>
    <p>
        …onde você possa pertencer a um clube escolar, um grupo de gamers, 
        ou uma comunidade artística mundial. Onde você e alguns amigos 
        possam passar um tempo juntos. Um lugar que torna fácil conversar 
        todos os dias e socializar com mais frequência.
    </p>

    <button type="button">
        <img src="./img/icone-download.svg" alt="ícone download" width="15" >
        <a href="">Baixar para Mac</a>
    </button>

    <button type="button">
        <a href="">Abra o Discord em seu navegador</a>
    </button>

     <img src="./img/fundo.png" alt="fundo">

     <!-- Conteúdos -->

    <img src="./img/grupo-estudo.svg" alt="Grupo de estudo">
    <h2>
        Crie um espaço controlado por convite onde você se sinta em casa
    </h2>
    <p>
        Os servidores Discord são organizados em canais com tópicos 
        para vocês colaborarem, compartilharem ou simplesmente falarem 
        do dia sem entupir um chat geral.
    </p>

    <img src="./img/canal-voz.svg" alt="Canal de voz">
    <h2>
        Aqui é fácil se encontrar
    </h2>
    <p>
        Entre no canal de voz quando estiver à toa. Amigos no mesmo 
        servidor podem te ver e entrar imediatamente, sem nem ter 
        que fazer a chamada.
    </p>

    <img src="./img/membros.svg" alt="Membros">
    <h2>
        Para poucos e para muitos
    </h2>
    <p>
        Organize qualquer comunidade com ferramentas de 
        moderação e acesso personalizado a membros. Dê poderes 
        especiais aos membros, monte canais privados e muito mais.
    </p>

    <img src="./img/relaxando.svg" alt="Relaxando">
    <h2>
        Tecnologia de conexão confiável
    </h2>
    <p>
        Voz e vídeo de baixa latência, para você conversar como se 
        estivesse na mesma sala. Dê um joinha por vídeo, veja amigos 
        transmitirem a jogatina do dia ou junte uma galera pra desenhar 
        na tela compartilhada.
    </p>

    <!-- Pronto para começa a jornada -->

    <img src="./img/fundo-estrela.svg" alt="fundo estrela">
    <h4>Vamos começar a sua jornada?</h4>
    <button type="button">
        <img src="./img/icone-download.svg" alt="ícone download" width="15" >
        <a href="">Baixar para Mac</a>
    </button>

     <!-- Rodapé -->

    <h4>Imagine um lugar</h4>
    <select name="idioma" id="idioma">
        <option value="english">
            <span>English, USA</span>
        </option>
        <option value="portugues" selected>
            <span>Português do Brasil</span>
        </option>
        <option value="espanhol">
            <span>Español</span>
        </option>
    </select>
    <img src="./img/twitter.svg" alt="twitter">
    <img src="./img/instagram.svg" alt="instagram">
    <img src="./img/facebook.svg" alt="facebook">
    <img src="./img/youtube.svg" alt="youtube">

    <h4>Produto</h4>
    <ul>
        <li>
            <a href="">Baixar</a>
        </li>
        <li>
            <a href="">Nitro</a>
        </li>
        <li>
            <a href="">Status</a>
        </li>
    </ul>

    <h4>Empresa</h4>
    <ul>
        <li>
            <a href="">Sobre</a>
        </li>
        <li>
            <a href="">Empregos</a>
        </li>
        <li>
            <a href="">Marca</a>
        </li>
        <li>
            <a href="">Sala de imprensa</a>
        </li>
    </ul>

    <h4>Recursos</h4>
    <ul>
        <li>
            <a href="">Faculdade</a>
        </li>
        <li>
            <a href="">Suporte</a>
        </li>
        <li>
            <a href="">Segurança</a>
        </li>
        <li>
            <a href="">Blog</a>
        </li>
        <li>
            <a href="">Comentários</a>
        </li>
        <li>
            <a href="">Desenvolvedores</a>
        </li>
        <li>
            <a href="">StreamKit</a>
        </li>
    </ul>

    <h4>Política</h4>
    <ul>
        <li>
            <a href="">Termos</a>
        </li>
        <li>
            <a href="">Privacidade</a>
        </li>
        <li>
            <a href="">Diretrizes</a>
        </li>
        <li>
            <a href="">Reconhecimento</a>
        </li>
        <li>
            <a href="">Licenças</a>
        </li>
        <li>
            <a href="">Moderação</a>
        </li>
    </ul>

    <img src="./img/logo.svg" alt="logo">
    <a href="">Registrar</a>
</body>
</html>
```



-----

-----

-----























































