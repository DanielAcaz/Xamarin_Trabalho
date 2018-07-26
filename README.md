# Xamarin_Trabalho

AO BAIXAR O PROJETO ZIP DO GITHUB, NA HORA DE BUILD NO PROJETO COMPARTILHADO ESTÁ APARECENDO UM ERRO DOS PACOTES NUGET'S. 

PARA CORRIGIR O ERRO, BASTA ADICIONAR O PACOTE NUGET PARA SQLITE: sqlite-net-pcl CONFOME IMAGEM EM ABAIXO.

APÓS BAIXAR VAI APRECER UM AVISO DE QUE O PACOTE NUGET JÁ ESTÁ PRESENTE. 

A PARTIR DESSE MOMENTO SE BUILDAR O PROJETO COMPARTILHADO NOVAMENTE, NÃO TERÁ MAIS NENHUM ERRO.

<img src="https://github.com/DanielAcaz/Xamarin_Trabalho/blob/master/img.png"/>

## Introdução:

### Motivação: 
Aplicativo para facilitar o usuário a escolher um lugar para comer.

### Objetivo: 
A princípio o usuário vai poder cadastrar os seus restaurantes preferidos e verificar a localização deles no mapa. 
Em uma outra etapa será possível ver a lotação do restaurante, preço, cardapio e outras informações.

### Solução: 
Para o escopo inicial, a solução foi fazer uma lista simples onde o usuário pode cadastrar os restaurantes de sua prefêrencia e ao colocar o endereço no restaurante ele pode ser redirecionado para uma tela de mapa onde vai ser mostrado a localização do estabelecimento.

## Aplicativo:

### Propósito:
Facilitar o usuário a escolher entre seus restaurantes prediletos.

### Público-Alvo:
Público joven entre 18 á 39 anos que frequente bares e restaurantes frequentemente.

### Pilares:
1 - Exclusivo para bares e restaurantes, dessa forma o usuário não tem poluição de outras informações.
2 - Usabilidade para simplificar tudo o que o usuário quiser saber sobre o estabelecimento.
3 - Gameficação do aplicativo onde o usário pode ser divertir enquanto escolhe um lugar para comer.

### Requisito Mínimo:

*OBS.: De acordo com o arquivo da Atividade 7, era necessário apenas um item de cada categoria, porém o nosso aplicativo* abrangeu alguns itens a mais:

#### Básico:
  - Code vs XAML
  - Controles básicos
  - Recursos de Layout
  - Navegação entre páginas

#### Intermediário:
  - Data Binding
  - MVVM
  
#### Avançado:
  - Persistência local com SQLite
  - Consumindo Web API
  - Mapas

## Aplicativo

Abaixo segue um tutorial para uso do aplicativo:

### Tela de Lista de Locais:

A primeira tela mostra lista de locais cadastrados e um botão para adicionar novos locais, se não tiver sido adicionado nenhum local a lista estára vazia:

<img src="https://github.com/DanielAcaz/Xamarin_Trabalho/blob/master/img1.png" width="250" height="400" />

### Adicionar um local:

Ao clicar em adicionar, você é redireciondo para uma tela onde deve ser colocado as infomações do local. 
*Obs.: Colocar o enderço o mais detalhado possível para que o mapa encontre o local corretamente.*

<img src="https://github.com/DanielAcaz/Xamarin_Trabalho/blob/master/img2.png" width="250" height="400" />

### Adicionando um Local

Após preencher com as informações, é só clicar em salvar que você é redirecionado para a tela de lista com o local adicionado.
A persistencia do local é feita através do SQLite, no banco de dados do celular.

<img src="https://github.com/DanielAcaz/Xamarin_Trabalho/blob/master/img3.png" width="250" height="400" align="right" />

<img src="https://github.com/DanielAcaz/Xamarin_Trabalho/blob/master/img4.png" width="250" height="400" align="center"/>

### Editando um local

Ao clicar em "Edit" podemos ver as mesmas informações cadastradas, mas agora com um botão de delete e de update, para apagar ou deletar a informação:

<img src="https://github.com/DanielAcaz/Xamarin_Trabalho/blob/master/img5.png" width="250" height="400"/>

### MAPA

Ao clicar em "Map" você é redirecionado para o mapa, exatamente no endereço especificado do local:
Para mostrar o endereço é feita uma requisição REST (GET) para a API de mapas do google, enviando o endereço e recebendo um objeto JSON com a latitude e longitude (entre outras informações).
Depois é enviado o valor da latitude e longitude para a lib de Mapa do Xamarin.

<img src="https://github.com/DanielAcaz/Xamarin_Trabalho/blob/master/img6.png" width="250" height="400"/>


