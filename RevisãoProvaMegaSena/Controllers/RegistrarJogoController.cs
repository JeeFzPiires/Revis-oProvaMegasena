using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RevisãoProvaMegaSena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisãoProvaMegaSena.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrarJogoController : Controller
    {

        [HttpPost("RegistrarJogo")]
       public ActionResult RegistrarJogo(MegaSena megaSena)
        {
            if(     megaSena.Numero1 != megaSena.Numero2 &&
                    megaSena.Numero1 != megaSena.Numero3 &&
                    megaSena.Numero1 != megaSena.Numero4 &&
                    megaSena.Numero1 != megaSena.Numero5 &&
                    megaSena.Numero1 != megaSena.Numero6 &&

                    megaSena.Numero2 != megaSena.Numero3 &&
                    megaSena.Numero2 != megaSena.Numero4 &&
                    megaSena.Numero2 != megaSena.Numero5 &&
                    megaSena.Numero2 != megaSena.Numero6 &&

                    megaSena.Numero3 != megaSena.Numero4 &&
                    megaSena.Numero3 != megaSena.Numero5 &&
                    megaSena.Numero3 != megaSena.Numero6 &&

                    megaSena.Numero4 != megaSena.Numero5 &&
                    megaSena.Numero4 != megaSena.Numero6 &&

                    megaSena.Numero5 != megaSena.Numero6 

                )
            {
                return Ok("Jogo Registrado");
            }

            return BadRequest("Jogo Invalido");
            }

        [HttpPost("RegistrarJogoAleatorio")]
        public ActionResult RegistrarJogoAleatorio()
        {
            Random JogoAleatorio = new Random();
            for (int i = 0; i < 6; i++)

            //gerar 6 numeros alatetorios diferente4s entre 1 e 60
            return Ok("Seu jogo é :" megaSena.Numero1, );

        }
        


    }
}
