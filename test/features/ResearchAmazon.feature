#language: pt-br

Funcionalidade: Navegação no site amazon.com
  Clientes devem conseguir navegar e comprar os itens no site amazon.com

  Cenario: Validar a compra de um vestido com sucesso no Site Automationpractice
    Dado que eu acesse o site da Amazon
    E que eu selecione o idioma Portugues
    E que eu pesquise o produto desejado "Vestido"
    Quando seleciono o tamanho dos produtos
    #E ordeno o tipo de exibicao dos produtos
    E clico no produto para visualizar
    Então a navegacao foi realizada com sucesso