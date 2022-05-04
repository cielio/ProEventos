using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Moldels;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private IEnumerable<Evento> _eventos = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto.jpg"
            },
                new Evento(){
                EventoId = 2,
                Tema = "Angular 12 e .Net 6",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto2.jpg"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(evento => evento.EventoId == id);
        }
    }
}
