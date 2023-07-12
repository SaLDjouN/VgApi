
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VgApi.Config;
using VgApi.Models;

namespace VgApi
{
    public class ExempleContext : DbContext
    {

        /*Accesseur pour nos tables*/
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }

        /// <summary>
        /// C'est ici que je vais renseigner mes fichiers de configs pour mes entités/table
        /// </summary>
        /// <param name="modelBuilder">Représente l'objet global DB faisant le lien entre mon c# et mes tables</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Ajout de la config pour la table personne
            modelBuilder.ApplyConfiguration<Game>(new GameConfig());
            //Ajout de la config pour la table Course
            modelBuilder.ApplyConfiguration<Genre>(new GenreConfig());
            //Ajout de la config pour la table Prof

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Quel base de données j'utilise : Type et la connectionstring
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5MK6E25\MSSQLSERVER01;Initial Catalog=VgBd;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}

