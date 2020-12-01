using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SorteioHab.Domain.Commands;
using SorteioHab.Domain.Entities;
using SorteioHab.Domain.Handlers;
using SorteioHab.Domain.Helpers;
using SorteioHab.Domain.Repositories;

namespace SorteioHab.Api.Controllers
{
    [ApiController]
    [Route("v1/participantes")]
    //[EnableCors("AllowOrigin")]
    public class ParticipanteController : ControllerBase
    {

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
           [FromBody] CreateParticipanteCommand command,
           [FromServices] ParticipanteHandler handler)
        {
            return (GenericCommandResult)handler.Handle(command);
        }


        [Route("idosos")]
        [HttpGet]
        public IEnumerable<Participante> GetAllIdoso(
            [FromServices] ISorteioRepository repository
        )

        {
            return repository.GetAllIdoso(TipoCota.Idoso);
        }

        [Route("pcds")]
        [HttpGet]
        public IEnumerable<Participante> GetAllPcd(
           [FromServices] ISorteioRepository repository
       )

        {
            return repository.GetAllPcd(TipoCota.PcD);
        }

        [Route("gerais")]
        [HttpGet]
        public IEnumerable<Participante> GetAllGeral(
           [FromServices] ISorteioRepository repository
       )

        {
            return repository.GetAllGeral(TipoCota.Geral);
        }

        [Route("sorteioidosos")]
        [HttpGet]
        public IEnumerable<Participante> GetWinnerIdoso(
            [FromServices] ISorteioRepository repository
        )

        {
            return repository.GetWinnerIdoso(TipoCota.Idoso, 1);
        }

        [Route("sorteiopcds")]
        [HttpGet]
        public IEnumerable<Participante> GetWinnerPcd(
            [FromServices] ISorteioRepository repository
        )

        {
            return repository.GetWinnerPcd(TipoCota.PcD, 1);
        }
        [Route("sorteiogerais")]
        [HttpGet]
        public IEnumerable<Participante> GetWinnerGeral(
            [FromServices] ISorteioRepository repository
        )

        {
            return repository.GetWinnerGeral(TipoCota.Geral, 3);
        }

        [Route("participantesvalidos")]
        [HttpGet]
        public int GetAllValid(
            [FromServices] ISorteioRepository repository
        )

        {
            return repository.GetAllValid();
        }
    
    }
}