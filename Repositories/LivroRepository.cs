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
    }
}
