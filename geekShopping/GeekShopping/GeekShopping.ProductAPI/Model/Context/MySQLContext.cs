using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context {
    public class MySQLContext : DbContext {

        public MySQLContext() {
        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 2,
                Name = "Name 2",
                Price = 169.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://github.com/rogcolaco/microservices-dotnet6/blob/main/geekShopping/Images/camiseLuffy.png?raw=true",
                CategoryName = "Vestuário"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 4,
                Name = "Name 4",
                Price = 619.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://github.com/rogcolaco/microservices-dotnet6/blob/main/geekShopping/Images/camisetaVilaFolha.png?raw=true",
                CategoryName = "Vestuário"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 5,
                Name = "Name 5",
                Price = 269.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://github.com/rogcolaco/microservices-dotnet6/blob/main/geekShopping/Images/camisetapoke.png?raw=true",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 6,
                Name = "Name 6",
                Price = 629.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://github.com/rogcolaco/microservices-dotnet6/blob/main/geekShopping/Images/figuraAction.png?raw=true",
                CategoryName = "Vestuário"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 7,
                Name = "Name 7",
                Price = 692.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://github.com/rogcolaco/microservices-dotnet6/blob/main/geekShopping/Images/figuraAction2.png?raw=true",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 8,
                Name = "Name 8",
                Price = 691.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://github.com/rogcolaco/microservices-dotnet6/blob/main/geekShopping/Images/mousePadPikachu.png?raw=true",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 9,
                Name = "Name 9",
                Price = 619.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://github.com/rogcolaco/microservices-dotnet6/blob/main/geekShopping/Images/narutoFigureActions.png?raw=true",
                CategoryName = "Vestuário"
            });


        }
    }
}
