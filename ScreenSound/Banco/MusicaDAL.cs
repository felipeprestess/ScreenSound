﻿using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal class MusicaDAL : DAL<Musica>
    {
        private readonly ScreenSoundContext _context;

        public MusicaDAL(ScreenSoundContext context)
        {
            _context = context;
        }

        public override IEnumerable<Musica> Listar()
        {
            return _context.Musicas.ToList();
        }

        public override void Adicionar(Musica musica)
        {
            _context.Musicas.Add(musica);

            _context.SaveChanges();
        }

        public override void Atualizar(Musica musica)
        {
            _context.Musicas.Update(musica);
            _context.SaveChanges();
        }

        public override void Deletar(Musica musica)
        {
            _context.Remove(musica);
            _context.SaveChanges();
        }

        public Musica? RecuperarPeloNome(string nome)
        {
            return _context.Musicas.FirstOrDefault(x => x.Nome.Equals(nome));
        }
    }
}
