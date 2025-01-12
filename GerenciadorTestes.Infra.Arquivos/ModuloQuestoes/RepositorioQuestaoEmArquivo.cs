﻿using GerenciadorTestes.Dominio.ModuloQuestoes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorTestes.Infra.Arquivos.ModuloQuestoes
{
    public class RepositorioQuestaoEmArquivo : RepositorioEmArquivoBase<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Questoes.Count > 0)
                contador = dataContext.Questoes.Max(x => x.Numero);
        }

        public override List<Questao> ObterRegistros()
        {
            return dataContext.Questoes;
        }

        public override AbstractValidator<Questao> ObterValidador()
        {
            return new ValidadorQuestao();
        }
       
    }
}
