<DOCTYPE html>
<html>
<head>

<title>Estoque aceitável/Estoque Bom</title>
</head>

<?php
$EstoqueAtual = 8;
    if ($EstoqueAtual < 5)
    echo "Estoque baixo! Emitir pedido de compra...";

    else if ($EstoqueAtual >= 5 && $EstoqueAtual <= 7)
    echo "Estoque em nível aceitável";

    else if ($EstoqueAtual > 7)
    echo "Nível de estoque bom";
?>
</html>
