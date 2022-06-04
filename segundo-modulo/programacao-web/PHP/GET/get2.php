<DOCTYPE html>
<html>
<head>
<body>
<?PHP
$nome = $_GET ["nome"]; //recebe o valor enviado pelo método GET.
$idade = $_GET ["idade"];

 

    $anoatual=date("Y");
        $nascimento=$anoatual-$idade;
            echo "Olá $nome!"; 
            echo "Você nasceu em $nascimento";
?>
</body>
</head>
</html>