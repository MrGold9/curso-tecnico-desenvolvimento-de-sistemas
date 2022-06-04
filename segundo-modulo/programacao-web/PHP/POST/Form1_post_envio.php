<html>

<head>
	<title>Formulário de envio de dados</title>
</head>


<body>


	<h2 align="www.terra.com.br"></h2>

	<br>

	<form action="Form2_post_rec.php" method="POST">
		Nome: <input type="text" name="nome" size="30" maxlength="30">
		Endereço: <input type="text" name="endereco" size="40" maxlength="40">

	<br>
	<br>

	Estado: 
	<select name="estado" size="1">
			<option value="São Paulo">São Paulo</option>
			<option value="Bahia">Bahia</option>
			<option value="Paraná">Paraná</option>
			<option value="Amazonas">Amazonas</option>
			</select>

        <br>
        <br>

		Sexo: 
		<input type="radio" value="Masculino" name="sexo"> Masculino
		<input type="radio" value="Feminino" name="sexo"> Feminino

        <br>
        <br>

		Profissão:
		<select name="profissao" size="1">
			<option value="Programador">Programador</option>
			<option value="Desenhista">Desenhista</option>
			<option value="Engenheiro">Engenheiro</option>
			<option value="Medico">Médico</option>
			</select>

        <br>
        <br>

            Preferências:
            <br>
			<input type="checkbox" value="esporte" name="opt1">Esporte
			<br>
			<input type="checkbox" value="musica" name="opt2">Música
			<br>
			<input type="checkbox" value="videogame" name="opt3" checked>Vídeo-Game
            
            <br>
            <br>
            <br>

			<input type="submit" value="Enviar">
			<input type="reset" value="Limpar">
		</form>


</body>



<html>