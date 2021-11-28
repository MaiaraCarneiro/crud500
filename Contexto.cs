﻿using CRUD.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) = base (option)
      
        public DbSet<Personagem> Personagem { get; set; }
   
    }
}
