<!DOCTYPE html>
<html lang="ptbr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Calculadora da Shopee</h1>
    <hr>
    <form action="" method="post">
        <p>
            <label for="txtN1">N1</label><br>
            <input type="number" name="txtN1" id="txtN1">
        </p>
        <p>
            <label for="txtN2">N2</label><br>
            <input type="number" name="txtN2" id="txtN2">
        </p>
        <p>
            <button id="btoCalcular" name="btoCalcular" formaction="calc.php?calc=SOMA" value="Soma">Calcular</button>
        </p>
    </form>
    <?php
        // print_r($_POST);
        // echo '<br>';
        // print_r($_GET);

        if($_POST)
        {
            $n1 = $_POST['txtN1'];
            $n2 = $_POST['txtN2'];
    
            $total = $n1 + $n2;
    
            echo 'Valor total: '.$total;
        }

        
    ?>
</body>
</html>