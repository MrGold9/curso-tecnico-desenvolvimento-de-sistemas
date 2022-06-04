 <!DOCTYPE html>
<html>
<title>Array - Funcionários</title>
<body>

<?php


$dados = array(
  array(
    'nome' => 'Adonilton',
    'idade' => '25',
    'salario' => 100,
    'ativo' => false
  ),
  array(
    'nome' => 'Irineu',
    'idade' => '40',
    'salario' => 1200,
    'ativo' => true
  ),
array(
    'nome' => 'Amarildo',
    'idade' => '19',
    'salario' => 900,
    'ativo' => true
  ),
);

$bonificacao = 0.10;

foreach ($dados as $funcionario) {
  if (! $funcionario['ativo']) {
    continue;
  }
  $funcionario['salario'] += floatval($funcionario['salario']) * $bonificacao;

  echo $funcionario['nome'] . ' <br> ' . $funcionario['idade'] . ' <br> ' . $funcionario['salario'] . '<p>' ;
}


?> 

</body>
</html> 