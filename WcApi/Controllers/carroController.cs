using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WcApi.Models;


namespace WcApi.Controllers
{
    public class carroController : ApiController
    {
        Carro[] carros = new Carro[]
        {
            new Carro{idcarro=1,marca="Ferrari",modelo=2012 },
            new Carro{idcarro=2,marca="BMW",modelo=2002 },
            new Carro{idcarro=3,marca="Mazda",modelo=2013 },
            new Carro{idcarro=4,marca="Nissan",modelo=2018 },
            new Carro{idcarro=5,marca="Toyota",modelo=2019 }
        };

        //metodos

        public IEnumerable<Carro> GetAllCarro()
        {
            return carros;
        }

        //devolver metodo por ID

        public IHttpActionResult GetCarro(int id)
        {
            var carro = carros.FirstOrDefault((c) => c.idcarro == id);
            if (carro != null)
            {
                return Ok(carro);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
