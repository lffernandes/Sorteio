using System.Collections.Generic;
using SorteioHab.Domain.Entities;
using SorteioHab.Domain.Helpers;

namespace SorteioHab.Domain.Repositories
{
    public interface ISorteioRepository
    {
        void Create(Participante participante);
        IEnumerable<Participante> GetAllIdoso(TipoCota cota);
        IEnumerable<Participante> GetAllPcd(TipoCota cota);
        IEnumerable<Participante> GetAllGeral(TipoCota cota);
        List<Participante> GetWinnerIdoso(TipoCota cota, int qtd);
        List<Participante> GetWinnerPcd(TipoCota cota, int qtd);
        List<Participante> GetWinnerGeral(TipoCota cota, int qtd);
        int GetAllValid();
    }
}