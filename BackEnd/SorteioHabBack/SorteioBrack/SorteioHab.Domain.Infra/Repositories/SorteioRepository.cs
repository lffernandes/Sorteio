using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SorteioHab.Domain.Entities;
using SorteioHab.Domain.Helpers;
using SorteioHab.Domain.Infra.Contexts;
using SorteioHab.Domain.Queries;
using SorteioHab.Domain.Repositories;

namespace SorteioHab.Domain.Infra.Repositories
{
    public class SorteioRepository : ISorteioRepository
    {
        private readonly DataContext _context;

        public SorteioRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(Participante participante)
        {
            _context.Participantes.Add(participante);
            _context.SaveChanges();
        }

        public IEnumerable<Participante> GetAllIdoso(TipoCota cota)
        {

            return _context.Participantes
            .AsNoTracking()
            .Where(ParticipanteQueries.GetAllIdoso(cota))
            .OrderBy(x => x.Nome);
        }

        public IEnumerable<Participante> GetAllPcd(TipoCota cota)
        {

            return _context.Participantes
            .AsNoTracking()
            .Where(ParticipanteQueries.GetAllPcd(cota))
            .OrderBy(x => x.Nome);
        }

        public IEnumerable<Participante> GetAllGeral(TipoCota cota)
        {

            return _context.Participantes
            .AsNoTracking()
            .Where(ParticipanteQueries.GetAllGeral(cota))
            .OrderBy(x => x.Nome);
        }

        public List<Participante> GetWinnerIdoso(TipoCota cota, int qtd)
        {
            Random rdn = new Random();
            List<Participante> sorteados = new List<Participante>();
            Participante sorteado = new Participante();
            IEnumerable<Participante> lista = _context.Participantes
            .AsNoTracking()
            .Where(ParticipanteQueries.GetAllIdoso(cota));

            for (int i = 1; i <= qtd; i++)
            {
                var result = lista.Where(p => sorteados.All(p2 => p2.Cpf != p.Cpf)).OrderBy(x => rdn.Next()).FirstOrDefault();

                if (result != null)
                {
                    sorteados.Add(result);
                }

            }
            return sorteados;

        }
        public List<Participante> GetWinnerPcd(TipoCota cota, int qtd)
        {
            Random rdn = new Random();
            List<Participante> sorteados = new List<Participante>();
            Participante sorteado = new Participante();
            IEnumerable<Participante> lista = _context.Participantes
            .AsNoTracking()
            .Where(ParticipanteQueries.GetAllPcd(cota));

            for (int i = 1; i <= qtd; i++)
            {
                var result = lista.Where(p => sorteados.All(p2 => p2.Cpf != p.Cpf)).OrderBy(x => rdn.Next()).FirstOrDefault();

                if (result != null)
                {
                    sorteados.Add(result);
                }
            }
            return sorteados;
        }
        public List<Participante> GetWinnerGeral(TipoCota cota, int qtd)
        {
            Random rdn = new Random();
            List<Participante> sorteados = new List<Participante>();
            Participante sorteado = new Participante();
            IEnumerable<Participante> lista = _context.Participantes
            .AsNoTracking()
            .Where(ParticipanteQueries.GetAllGeral(cota));

            for (int i = 1; i <= qtd; i++)
            {
                var result = lista.Where(p => sorteados.All(p2 => p2.Cpf != p.Cpf)).OrderBy(x => rdn.Next()).FirstOrDefault();
                if (result != null)
                {
                    sorteados.Add(result);
                }
            }
            return sorteados;
        }

        public int GetAllValid()
        {
            var idosos = _context.Participantes.Where(ParticipanteQueries.GetAllIdoso(TipoCota.Idoso)).Count();
            var pcds = _context.Participantes.Where(ParticipanteQueries.GetAllPcd(TipoCota.PcD)).Count();
            var gerais = _context.Participantes.Where(ParticipanteQueries.GetAllGeral(TipoCota.Geral)).Count();

            return idosos + pcds + gerais;
        }
    }
}