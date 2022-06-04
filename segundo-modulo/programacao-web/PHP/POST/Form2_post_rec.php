<html>


<head><title>formulario02--recebendo dados</title></head>


<body>


<h2 align="center">www.terra.com.br:</h2>


<?php
$nome=$_POST["nome"];
$endereco=$_POST["endereco"];
$estado=$_POST["estado"];
$sexo=$_POST["sexo"];
$profissao=$_POST["profissao"];
$OPT1=@$_POST["opt1"];
$OPT2=@$_POST["opt2"];
$OPT3=@$_POST["opt3"];/* @ OCULTA A MENSAGEM DE NOTIFICAÇÃO*/
?>


Nome:-----------------<?=$nome?><BR>
endereço:-----------------<?=$endereco?><BR>
estado:-----------------<?=$estado?><br>
sexo:-----------------<?=$sexo?><br>
profissao:-----------------<?=$profissao?><br>
Preferências:-----------------


<?php
if (!empty($OPT1))//função empty "if not empty (!empty- verifica se o vALOR É VAZIO.
{
print "Esporte<br>";
}
if (!empty($OPT2))
{
print "Música<br>";
}
if (!empty($OPT3))
{
print "Video-Game<br>";
}
?>


</body>


</html>