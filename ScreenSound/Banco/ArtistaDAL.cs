﻿using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    public class ArtistaDAL
    {
        private readonly ScreenSoundContext _context;

        public ArtistaDAL(ScreenSoundContext context)
        {
            _context = context;
        }

        public IEnumerable<Artista> Listar()
        {
            return _context.Artistas.ToList();
        }

        public void Adicionar(Artista artista)
        {
            _context.Artistas.Add(artista);

            _context.SaveChanges();
        }

        public void Atualizar(Artista artista)
        {
            _context.Artistas.Update(artista);
            _context.SaveChanges();
        }

        public void Deletar(Artista artista)
        {
            _context.Remove(artista);
            _context.SaveChanges();
        }

        public Artista? RecuperarPeloNome(string nome)
        {
            return _context.Artistas.FirstOrDefault(x => x.Nome.Equals(nome));
        }
    }
}
