﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ORM_Exemplo
{

    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public ICollection<Filme>? Filme { get; set; }
    }

    public class Filme
    {
        [Key]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public Genero? Genero { get; set; }
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<Genero>? Genero { get; set; }
        public DbSet<Filme>? Filme { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=GERALDO\SQLEXPRESS;Database=orm;TrustServerCertificate=True;");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}

