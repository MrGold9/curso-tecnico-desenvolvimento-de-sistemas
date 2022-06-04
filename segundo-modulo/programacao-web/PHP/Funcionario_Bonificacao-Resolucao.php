 <!DOCTYPE html>
<html>
<title>Array - Funcionários</title>
<body>

<?php

$funcionarios = array(

array("nome" => "Sergio", "idade" => 21, "salario" => 1285.27, "ativo" => true),

array("nome" => "Emerson", "idade" => 35, "salario" => 3885.27, "ativo" => false),

array("nome" => "Osvaldo", "idade" => 54, "salario" => 5285.27, "ativo" => true),

);

$bonificacao = 10;

foreach($funcionarios as $funcionario){

if($funcionario["ativo"]){

$funcionario["salario"] += $funcionario["salario"] * ($bonificacao/100);

echo "Funcionario: {$funcionario['nome']} - {$funcionario['salario']}<p>";

} else {

echo "Funcionario: {$funcionario['nome']} - INATIVO<p>";

}

}

?> 

</body>
</html> 