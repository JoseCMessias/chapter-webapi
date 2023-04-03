using Chapter.WebApi.Contexts;
using Chapter.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Chapter.WebApi.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;
        public LivroRepository(ChapterContext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }

        public Livro BuscaPorId(int id)
        {
            // select where id = id
            return _context.Livros.Find(id);
        }

        // atualizar as infos de um livro
        public void Atualizar(int id, Livro livro)
        {
            // busca o livro pelo id
            Livro livroBuscado = _context.Livros.Find(id);
            if (livroBuscado != null)
            {
                livroBuscado.Titulo = livro.Titulo;
                livroBuscado.QuantidadePaginas = livro.QuantidadePaginas;
                livroBuscado.Disponivel = livro.Disponivel;
            }
            _context.Livros.Update(livroBuscado);
            _context.SaveChanges();
        }

        // cadastrar livro no bd
        public void Cadastrar(Livro livro)
        {
            // adiciona o novo livro
            _context.Livros.Add(livro);
            // salva
            _context.SaveChanges();
        }

        // deleta o livro a partir de um id
        public void Deletar(int id)
        {
            // busca
            Livro livroBuscado = _context.Livros.Find(id);
            // remove o livro
            _context.Livros.Remove(livroBuscado);
            //salva
            _context.SaveChanges();
        }
    }
}
