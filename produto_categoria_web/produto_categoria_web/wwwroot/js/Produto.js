function adicionar() {
    let formData = $("#formProduto").serialize();

    $.ajax({
        type: "POST",
        url: `/produto/AdicionarProduto`,
        data: formData,
        async: false,
        dataType: "json",
        success: function (response) {
            if (response.success) {
                alert("Produto cadastrado.");
                window.location = "Produto/Index";
            } else {
                alert(response.message)
            }
        },
        error: function (response) {
            alert(response.message)
        }
    });
}

function modalEditar(data) {
    $("#Id").val(data.Id);
    $("#NomeEdit").val(data.Nome);
    $("#DescricaoEdit").val(data.Descricao);
    $("#PrecoAnteriorEdit").val(data.PrecoAnterior);
    $("#PrecoEdit").val(data.Preco);
    $("#IdCategoriaEdit").val(data.IdCategoria);

    $("#modalEditar").modal();
}

function editar() {
    let formData = $("#formProdutoEdicao").serialize();
    $.ajax({
        type: "PUT",
        url: `/produto/editarProduto`,
        data: formData,
        async: false,
        dataType: "json",
        success: function (response) {
            if (response) {
                if (response.success) {
                    alert("Produto Salvo.");
                    window.location = "/Produto/Index";
                } else {
                    alert(response.message)
                }
            } else {
                alert("Erro ao cadastrar");
            }
           
        },
        error: function (response) {
            alert(response.message)
        }
    });
}


function excluir(id) {
    $.ajax({
        type: "DELETE",
        url: `/produto/excluirProduto/${id}`,
        async: false,
        dataType: "json",
        success: function (response) {
            if (response) {
                if (response.success) {
                    alert("Produto excluído.");
                    window.location = "/Produto/Index";
                } else {
                    alert(response.message)
                }
            } else {
                alert("Erro ao excluir");
            }

        },
        error: function (response) {
            alert(response.message)
        }
    });
}