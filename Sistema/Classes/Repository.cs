using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using TrabalhoGuisso;


namespace TralhoGumo2
{
    public class Repository : DbContext
    {
        // parametros de conexão
        private static readonly String _connectionParams = @"server=127.0.0.1;port=3306;uid=root;pwd=;database=gumo2";
        
        // criando as tabelas
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        //public DbSet<Item> Itens { get; set; }
        // criando a database
        public Repository() 
        {
            if (Database.EnsureCreated())
            {
                Credencial _adminCredencial = new Credencial()
                {
                    SenhaTexto = "admin",
                    Perfil = Perfil.Gerente
                };
                _adminCredencial.SenhaHash = Credencial.ComputeSHA256(_adminCredencial.SenhaTexto, Credencial.SALT);
                Vendedor _admin = new Vendedor()
                {
                    Nome = "Admin",
                    Gmail = "admin@admin",
                    Telefone = "00000000000",
                    Credencial = _adminCredencial
                };
                VendedorRepository.SaveOrUpdate(_admin);

            }
        }

        // estabelecendo os parametros de conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionParams);
        }
    }
}
