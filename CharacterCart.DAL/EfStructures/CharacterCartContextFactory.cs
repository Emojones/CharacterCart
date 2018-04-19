using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCart.DAL.EfStructures
{
    public class CharacterCartContextFactory : IDesignTimeDbContextFactory<CharacterCartContext>
    {
        public CharacterCartContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CharacterCartContext>();
            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=CharacterCart;Trusted_Connection=True;MultipleActiveResultSets=true;";

            optionsBuilder.UseSqlServer(connectionString, options => options.EnableRetryOnFailure()).ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
            return new CharacterCartContext(optionsBuilder.Options);
        }
    }
}
