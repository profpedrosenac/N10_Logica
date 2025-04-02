const produto = document.getElementById('txtProduto')
const valorUnitario = document.getElementById('txtValorUnit')
const qtde = document.getElementById('txtQtde')
const valorTotalItem = document.getElementById('txtTotal')
const resultado = document.getElementById('resultado')

function PegarValor(){
    valorUnitario.value = produto.value
}

function TotalCompra(){
    let total = valorUnitario.value * qtde.value
    valorTotalItem.value = total
}

function Juros(valor){
    let total = valorTotalItem.value * ( 1 + valor / 100)
    resultado.innerHTML = '<p class="azul">' + total + '</p>'
}

function Desconto(valor){
    let total = valorTotalItem.value * ( 1 - valor / 100)
    resultado.innerHTML = '<p class="vermelho">' + total + '</p>'
}