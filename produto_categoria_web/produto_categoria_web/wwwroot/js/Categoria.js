    function adicionar() {

        $.ajax({
            async: true,
            method: "POST",
            cache: false,
            url: `/AdicionarCategoria/${$('#descricao').val()}`,
            success: result => {
                if (result) {
                    if (result.success) {
                        alert(result.json);
                        $("#id").val("");
                        $("#descricao").val("");
                        $("#modalAdicionar").modal("hide");
                        window.location = "/Categoria/Index";
                    } else {
                        alert(result.message);
                    }
                } else {
                    alert("Erro ao adicionar categoria");
                }
               
            },
            error: (err, data, url) => {
                alert(data);
            }
        });

    }

    function editar(id) {

        $.ajax({
            async: true,
            method: "PUT",
            cache: false,
            url: `/EditarCategoria`,
            data: {
                id: id,
                descricao: $("#descricao").val()
            },
            success: result => {
                alert(result);
            },
            error: err => {
                alert(err);
            }
        });

    }

    function excluir(id) {

        $.ajax({
            async: true,
            method: "DELETE",
            cache: false,
            url: `/ExcluirCategoria/${id}`,
            data: {
                id: id,
                descricao: $("#descricao").val()
            },
            success: result => {
                if (result) {
                    alert(result.json);
                    window.location = "/Categoria/Index";
                } else {
                    alert("Erro ao exluir");
                }
            },
            error: (error, data) => {
                alert(data);
            }
        });
    }

