var nomeArquivo = 'Relatorio' + document.title + '_' + new Date().toISOString().slice(0, 10).replace(/-/g, "");

$(document).ready(function () {
    $('#DataTable').DataTable({
        scrollX: true,
        "autoWidth": false,
        "pageLength": 13,
        "lengthChange": false,
        "language": {
            "decimal": "",
            "emptyTable": "Não há dados disponíveis na tabela",
            "info": "_START_ - _END_ (_TOTAL_ registros)",
            //"info":           "Mostrando _START_ para _END_ de _TOTAL_ registros",
            "infoEmpty": "0 registros",
            "infoFiltered": "(filtrado de _MAX_ registros totais)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ registros",
            "loadingRecords": "Carregando...",
            "processing": "",
            "search": "Buscar:",
            "zeroRecords": "Nenhum registro correspondente encontrado",
            "paginate": {
                "first": "Primeiro",
                "last": "Último",
                "next": "Próximo",
                "previous": "Anterior"
            },
            "aria": {
                "sortAscending": ": Ativar ordenação crescente",
                "sortDescending": ": Ativar ordenação decrescente"
            }
        },
        dom: 'Bfrtip',
        buttons: [
            {
                extend: 'excelHtml5',
                title: [nomeArquivo].toString(),
                className: 'botao darkgreen',
                text: '<i class="fa fa-file-excel-o"></i>'
            },
            {
                extend: 'pdfHtml5',
                title: [nomeArquivo].toString(),
                className: 'botao darkred',
                text: '<i class="fa fa-file-pdf-o"></i>'
            },
            {
                extend: 'csvHtml5',
                title: [nomeArquivo].toString(),
                className: 'botao darkblue',
                text: '<i class="fa fa-file-o"></i>'
            },
        ],
    });
});