using Microsoft.EntityFrameworkCore.Migrations;

namespace LivrariaEstoque.Migrations
{
    public partial class PopularTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Ação')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Aventura')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Biográficos')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Científicos')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Contos')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Crônicas')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Drama')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Didáticos')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Fantasia')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Ficção Científica')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Poesia')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Romance')");
            migrationBuilder.Sql("INSERT INTO Generos(GeneroNome) VALUES('Terror')");

            migrationBuilder.Sql("INSERT INTO Livros(Titulo, Autor, Ano, Status, ImagemUrl, ImagemThumbnailUrl, GeneroId) VALUES('O senhor dos anéis','J. R. R. Tolkien','2001','D','https://images-na.ssl-images-amazon.com/images/I/71ZLavBjpRL.jpg','https://images-na.ssl-images-amazon.com/images/I/71ZLavBjpRL.jpg','10')");
            migrationBuilder.Sql("INSERT INTO Livros(Titulo, Autor, Ano, Status, ImagemUrl, ImagemThumbnailUrl, GeneroId) VALUES('Harry Potter e a pedra filosofal','J. K. Rowling','2000','D','http://lojasaraiva.vteximg.com.br/arquivos/ids/12100486/1007942370.jpg?v=637142216975430000','http://lojasaraiva.vteximg.com.br/arquivos/ids/12100486/1007942370.jpg?v=637142216975430000','10')");
            migrationBuilder.Sql("INSERT INTO Livros(Titulo, Autor, Ano, Status, ImagemUrl, ImagemThumbnailUrl, GeneroId) VALUES('Código Limpo: Habilidades Práticas do Agile Software','Robert C. Martin','2009','I','https://images-na.ssl-images-amazon.com/images/I/41aHzYSXZkL._SX380_BO1,204,203,200_.jpg','https://images-na.ssl-images-amazon.com/images/I/41aHzYSXZkL._SX380_BO1,204,203,200_.jpg','8')");
            migrationBuilder.Sql("INSERT INTO Livros(Titulo, Autor, Ano, Status, ImagemUrl, ImagemThumbnailUrl, GeneroId) VALUES('O Codificador Limpo','Robert C. Martin','2012','I','https://images-na.ssl-images-amazon.com/images/I/41MtioCZaEL._SX359_BO1,204,203,200_.jpg','https://images-na.ssl-images-amazon.com/images/I/41MtioCZaEL._SX359_BO1,204,203,200_.jpg','8')");
            migrationBuilder.Sql("INSERT INTO Livros(Titulo, Autor, Ano, Status, ImagemUrl, ImagemThumbnailUrl, GeneroId) VALUES('O guia definitivo do Mochileiro das Galáxias','Douglas Adams','2016','D','https://images-na.ssl-images-amazon.com/images/I/510pr37GO8L._SX347_BO1,204,203,200_.jpg','https://images-na.ssl-images-amazon.com/images/I/510pr37GO8L._SX347_BO1,204,203,200_.jpg','10')");
            migrationBuilder.Sql("INSERT INTO Livros(Titulo, Autor, Ano, Status, ImagemUrl, ImagemThumbnailUrl, GeneroId) VALUES('A arte da guerra','Sun Tzu','2018','D','https://images-na.ssl-images-amazon.com/images/I/41Z+Iod3PDL._SX342_BO1,204,203,200_.jpg','https://images-na.ssl-images-amazon.com/images/I/41Z+Iod3PDL._SX342_BO1,204,203,200_.jpg','8')");
            migrationBuilder.Sql("INSERT INTO Livros(Titulo, Autor, Ano, Status, ImagemUrl, ImagemThumbnailUrl, GeneroId) VALUES('A Invenção de Hugo Cabret','Brian Selznick','2007','I','https://images-na.ssl-images-amazon.com/images/I/61vJZxMNR6L._SX331_BO1,204,203,200_.jpg','https://images-na.ssl-images-amazon.com/images/I/61vJZxMNR6L._SX331_BO1,204,203,200_.jpg','2')");
            migrationBuilder.Sql("INSERT INTO Livros(Titulo, Autor, Ano, Status, ImagemUrl, ImagemThumbnailUrl, GeneroId) VALUES('O código Da Vinci','Dan Brown','2004','D','https://images-na.ssl-images-amazon.com/images/I/41ECSb1mDzL._AC_SY400_.jpg','https://images-na.ssl-images-amazon.com/images/I/41ECSb1mDzL._AC_SY400_.jpg','12')");
            migrationBuilder.Sql("INSERT INTO Livros(Titulo, Autor, Ano, Status, ImagemUrl, ImagemThumbnailUrl, GeneroId) VALUES('O Hobbit','J. R. R. Tolkien','2013','D','https://images-na.ssl-images-amazon.com/images/I/61gZa8gXbtL._SX329_BO1,204,203,200_.jpg','https://images-na.ssl-images-amazon.com/images/I/61gZa8gXbtL._SX329_BO1,204,203,200_.jpg','10')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Generos");
            migrationBuilder.Sql("DELETE FROM Livros");
        }
    }
}
