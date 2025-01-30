<!DOCTYPE html>
<html lang="br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="estilo.css">
</head>
<body>
    <div class="total">
        <div id="topo"></div>
        <div id="menu"></div>
    </div>
    <div id="banner">

    </div>
    <div class="total">
        <div id="menuL"></div>
        <div id="conteudo">
            <?php

                for ($x = 1; $x <= 50; $x++) {
                    echo
                    '
                    <div class="quadradinho">
                        <div class="quadradinhoBla">
                            <p>Produto '.$x.'</p>
                        </div>
                    </div>
                    ';
                }
  
                
            ?>
        </div>
    </div>
</body>
</html>