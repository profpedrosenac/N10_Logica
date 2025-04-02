<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>AJAX

    </title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <h1>Enviando dados para o PHP</h1>
            </div>
        </div>
        <div class="row">
            <form action="" id="frmCadastro" name="frmCadastro" class="form-control" method="post" onsubmit="return false">
                <div class="col-sm-12">
                    <p>
                        <label for="txtID">ID</label>
                    </p>
                    <p>
                        <input type="text" name="txtID" id="txtID" class="form-control">
                    </p>
                    <p>
                        <label for="txtNome">Nome</label>
                    </p>
                    <p>
                        <input type="text" name="txtNome" id="txtNome" class="form-control">
                    </p>
                    <p>
                        <label for="txtTelefone">Telefone</label>
                    </p>
                    <p>
                        <input type="text" name="txtTelefone" id="txtTelefone" class="form-control">
                    </p>
                    <p class="text-end">
                        <button class="btn btn-primary" value="Enviar" onclick="Enviar()" formaction="app.php">Enviar</button>
                    </p>
                </div>
            </form>
        </div>
        <div class="row">
            <div class="col-sm-12">

                <?php include_once('app.php'); ?>

            </div>
        </div>
    </div>
    

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

    <script>
        const form = document.getElementById('frmCadastro')
        const id = document.getElementById('txtID')
        const nome = document.getElementById('txtNome')
        const telefone = document.getElementById('txtTelefone')

        function Enviar()
        {
            if (nome.value == "") {
                alert("Erro, nome deve ser preenchido")
                return
            }
            if (telefone.value == "") {
                alert("Erro, telefone deve ser preenchido")
                return
            }

            form.action = "pag01.php"
            form.submit()
        }
    </script>

</body>
</html>