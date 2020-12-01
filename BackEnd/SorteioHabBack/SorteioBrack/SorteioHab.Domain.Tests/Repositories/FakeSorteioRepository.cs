using System;
using System.Collections.Generic;
using SorteioHab.Domain.Entities;
using SorteioHab.Domain.Helpers;
using SorteioHab.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeSorteioRepository : ISorteioRepository
    {
        public void Create(Participante participante)
        {
        }

        public IEnumerable<Participante> GetAllGeral(TipoCota cota)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Participante> GetAllIdoso(TipoCota cota)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Participante> GetAllPcd(TipoCota cota)
        {
            throw new NotImplementedException();
        }

        List<Participante> ISorteioRepository.GetWinnerIdoso(TipoCota cota, int qtd)
        {
            throw new NotImplementedException();
        }

        List<Participante> ISorteioRepository.GetWinnerPcd(TipoCota cota, int qtd)
        {
            throw new NotImplementedException();
        }

        List<Participante> ISorteioRepository.GetWinnerGeral(TipoCota cota, int qtd)
        {
            throw new NotImplementedException();
        }

        public int GetAllValid()
        {
            throw new NotImplementedException();
        }
    }
}