﻿using CadastroProduto.Data;
using CadastroProduto.Models;
using CadastroProduto.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CadastroProduto.Dal
{
    public class ClienteDAL :IDAL
    {
        private readonly DataBaseContext dbContext;
        public ClienteDAL(DataBaseContext dbContext)
        {
            this.dbContext = dbContext;            
        }

        public void Cadastrar(EntidadeDominio entidadeDominio)
        {
           
            dbContext.Add(entidadeDominio);
            dbContext.SaveChanges();
        }

        public void Alterar(EntidadeDominio entidadeDominio)
        {

        }

        public void Excluir(EntidadeDominio entidadeDominio)
        {

        }

        public List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio)
        {
            var list = dbContext.Cliente.ToList();
            List<EntidadeDominio> resultado = new List<EntidadeDominio>();
            foreach (EntidadeDominio x in list)
            {
                resultado.Add(x);
            }

            return resultado;
        }

        public List<Cliente> ExibirTodos(Cliente cliente)
        {                       
            return dbContext.Cliente.ToList();
        }
    }
}
