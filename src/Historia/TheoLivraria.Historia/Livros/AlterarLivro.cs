﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheoLivraria.Dominio.Entidades;
using TheoLivraria.Dominio.IRepositories;

namespace TheoLivraria.Historia.Livros
{
    public class AlterarLivro
    {
        public Dictionary<string, string> Erros { get; private set; } = new Dictionary<string, string>();
        private readonly ILivroRepository _livroRepository;

        public AlterarLivro(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public async Task Executar(Livro livro)
        {
            try
            {
                await _livroRepository.Atualizar(livro);
            }
            catch (System.Exception)
            {
                this.Erros.Add("Erro", "Ocorreu um erro ao alterar um livro.");
            }

        }
    }
}
