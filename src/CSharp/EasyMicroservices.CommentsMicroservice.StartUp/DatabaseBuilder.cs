﻿using EasyMicroservices.CommentsMicroservice.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.CommentsMicroservice
{
    public class DatabaseBuilder : IDatabaseBuilder
    {
        public void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Comment");
            //optionsBuilder.UseSqlServer("Server=.;Database=Comments;Integrated Security=True;Trusted_Connection=True;   TrustServerCertificate=True");
        }
    }
}
