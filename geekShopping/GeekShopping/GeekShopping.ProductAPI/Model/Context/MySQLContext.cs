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
                ImageUrl = "https://www.camisetas4fun.com.br/media/product/7e2/camiseta-one-piece-1c2.jpg",
                CategoryName = "Vestuário"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 4,
                Name = "Name 4",
                Price = 619.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://cf.shopee.com.br/file/f2fd18b782a1ab556c35f03f443f58a1",
                CategoryName = "Vestuário"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 5,
                Name = "Name 5",
                Price = 269.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://www.camisetas4fun.com.br/media/product/7e2/camiseta-one-piece-1c2.jpg",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 6,
                Name = "Name 6",
                Price = 629.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://a-static.mlcdn.com.br/618x463/camisa-camiseta-one-piece-monkey-d-luffy-manga-home-custom/diasoutlet/30774fcc058f11ecb5264201ac185013/6e9c651f7666e1b720c9fe0987fc12c0.jpg",
                CategoryName = "Vestuário"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 7,
                Name = "Name 7",
                Price = 692.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://cf.shopee.com.br/file/f2fd18b782a1ab556c35f03f443f58a1",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 8,
                Name = "Name 8",
                Price = 691.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://www.camisetas4fun.com.br/media/product/7e2/camiseta-one-piece-1c2.jpg",
                CategoryName = "Papelaria"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 9,
                Name = "Name 9",
                Price = 619.9,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tempor tincidunt urna vel pretium. Sed condimentum neque vitae est fringilla, ac molestie neque mattis. Nullam felis urna, viverra vel eleifend non, fermentum quis ex. Nullam turpis velit, dictum vel varius nec, sagittis bibendum neque. Sed pulvinar augue fringilla nisi posuere, sit amet vehicula tortor semper. Aliquam suscipit, magna ac aliquet iaculis, urna leo faucibus justo, eu dapibus est neque nec elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras euismod justo vitae massa rhoncus, nec finibus odio lacinia. Sed varius aliquam consectetur. Sed vel gravida risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis purus nibh. Donec convallis eget leo eget feugiat.",
                ImageUrl = "https://a-static.mlcdn.com.br/618x463/camisa-camiseta-one-piece-monkey-d-luffy-manga-home-custom/diasoutlet/30774fcc058f11ecb5264201ac185013/6e9c651f7666e1b720c9fe0987fc12c0.jpg",
                CategoryName = "Vestuário"
            });


        }
    }
}
