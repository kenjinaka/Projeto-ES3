﻿using CadastroProduto.Dal;
using CadastroProduto.Data;
using CadastroProduto.Models;
using CadastroProduto.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroProduto.Facade
{
    public class LinhaFacade :IFacade
    {
        private readonly DataBaseContext dbContext;
        
        public LinhaFacade(DataBaseContext dbContext)
        {
            this.dbContext = dbContext;           
        }

        public LinhaFacade()
        {
        }

        public void Cadastrar(EntidadeDominio entidadeDominio)
        {           
            LinhaDAL ld = new LinhaDAL(dbContext);
            ld.Cadastrar(entidadeDominio);
            Log.Gerar(new Dictionary<string, string>());

        }

        public void Alterar(EntidadeDominio entidadeDominio)
        {

        }

        public void Excluir(EntidadeDominio entidadeDominio)
        {

        }

        public List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio)
        {
            LinhaDAL ld = new LinhaDAL(dbContext);

            List<EntidadeDominio> list = new List<EntidadeDominio>();
            list = ld.Consultar(entidadeDominio);
            return list;
        }

        public Linha ConsultarPorId(int id)
        {           
                LinhaDAL ld = new LinhaDAL(dbContext);            
                Linha linha = ld.ConsultarPorId(id);
                return linha;            
        }
    }
}