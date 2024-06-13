﻿using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    public class DAL<T> where T : class
    {
        protected readonly ScreenSoundContext _context;

        public DAL(ScreenSoundContext context)
        {
            _context = context;
        }

        public IEnumerable<T> Listar()
        {
            return _context.Set<T>().ToList();
        }
        public void Adicionar(T objeto)
        {
            _context.Set<T>().Add(objeto);

            _context.SaveChanges();
        }
        public void Atualizar(T objeto)
        {
            _context.Set<T>().Update(objeto);
            _context.SaveChanges();
        }
        public void Deletar(T objeto)
        {
            _context.Remove(objeto);
            _context.SaveChanges();
        }

        public T? RecuperarPor(Func<T, bool> condicao)
        {
            return _context.Set<T>().FirstOrDefault(condicao);
        }
    }
}
