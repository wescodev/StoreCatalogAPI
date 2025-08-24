using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreCatalogAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeeDbData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //inserir categorias
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Eletrônicos" }
                );
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Eletrodomésticos" }
                );

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Livros" }
                );

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Fitness" }
                );

            //eletronicos
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Name", "Price", "CategoriaId" },
                values: new object[] { 1, "Smartphone Galaxy S23", 3500.00m, 1 }
                );

            migrationBuilder.InsertData(
              table: "Produtos",
              columns: new[] { "Id", "Name", "Price", "CategoriaId" },
              values: new object[] { 2, "Fone de Ouvido Bluetooth", 250.000m, 1 }
              );

            migrationBuilder.InsertData(
              table: "Produtos",
              columns: new[] { "Id", "Name", "Price", "CategoriaId" },
              values: new object[] { 3, "Smart TV 50 LED", 2800.00m, 1 }
              );

            //Eletrodomésticos
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Name", "Price", "CategoriaId" },
                values: new object[] { 4, "Geladeira Frost Free", 3200.00m, 2 }
                );

            migrationBuilder.InsertData(
              table: "Produtos",
              columns: new[] { "Id", "Name", "Price", "CategoriaId" },
              values: new object[] { 5, "Micro-ondas", 450.00m, 2 }
              );

            migrationBuilder.InsertData(
              table: "Produtos",
              columns: new[] { "Id", "Name", "Price", "CategoriaId" },
              values: new object[] { 6, "Liquidificador", 150.00m, 2 }
              );


            //Livros
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Name", "Price", "CategoriaId" },
                values: new object[] { 7, "O Senhor dos Anéis", 55.00m, 3 }
                );

            migrationBuilder.InsertData(
              table: "Produtos",
              columns: new[] { "Id", "Name", "Price", "CategoriaId" },
              values: new object[] { 8, "Harry Potter - e as Reliquias da Morte", 45.00m, 3 }
              );

            migrationBuilder.InsertData(
              table: "Produtos",
              columns: new[] { "Id", "Name", "Price", "CategoriaId" },
              values: new object[] { 9, "Aprendendo C", 200.00m, 3 }
              );

            //Fitness
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Name", "Price", "CategoriaId" },
                values: new object[] { 10, "Halteres 10kg par", 200.00m, 4 }
                );

            migrationBuilder.InsertData(
              table: "Produtos",
              columns: new[] { "Id", "Name", "Price", "CategoriaId" },
              values: new object[] { 11, "Esteira Doméstica", 2200.00m, 4 }
              );

            migrationBuilder.InsertData(
              table: "Produtos",
              columns: new[] { "Id", "Name", "Price", "CategoriaId" },
              values: new object[] { 12, "Colchonete Yoga", 80.00m, 4 }
              );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {


            // Produtos - Fitness
            migrationBuilder.DeleteData("Produtos", "Id", 13);
            migrationBuilder.DeleteData("Produtos", "Id", 14);
            migrationBuilder.DeleteData("Produtos", "Id", 15);

            // Produtos - Livros
            migrationBuilder.DeleteData("Produtos", "Id", 10);
            migrationBuilder.DeleteData("Produtos", "Id", 11);
            migrationBuilder.DeleteData("Produtos", "Id", 12);

            // Produtos - Eletrodomésticos
            migrationBuilder.DeleteData("Produtos", "Id", 7);
            migrationBuilder.DeleteData("Produtos", "Id", 8);
            migrationBuilder.DeleteData("Produtos", "Id", 9);

            // Produtos - Eletrônicos
            migrationBuilder.DeleteData("Produtos", "Id", 1);
            migrationBuilder.DeleteData("Produtos", "Id", 2);
            migrationBuilder.DeleteData("Produtos", "Id", 3);

            // Categorias
            migrationBuilder.DeleteData("Categorias", "Id", 1); // Eletrônicos
            migrationBuilder.DeleteData("Categorias", "Id", 2); // Eletrodomésticos
            migrationBuilder.DeleteData("Categorias", "Id", 3); // Livros
            migrationBuilder.DeleteData("Categorias", "Id", 4); // Fitness

        }
    }
}
