using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test_payment_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class ProdutoController : ControllerBase
    {

    public static List<Produto> ListaProduto;
    public ProdutoController()
    {
        ListaProduto = new List<Produto>();

        var prod1 = new Produto();
        prod1.Idp = 001;
        prod1.Nome = "bola de Futebol";
        prod1.Valor = 98.00M;
        ListaProduto.Add(prod1);

        var prod2 = new Produto();
        prod2.Idp = 002;
        prod2.Nome = "Camisa da Seleção Brasileira";
        prod2.Valor = 108.00M;
        ListaProduto.Add(prod2);
        
        var prod3 = new Produto();
        prod3.Idp = 003;
        prod3.Nome = "Albun de Figurinha da Copa do Mundo";
        prod3.Valor = 20.00M;
        ListaProduto.Add(prod3);
    }    
        [HttpGet("Registro de todos os Produtos")]
        public IActionResult Index()
        {
            return Ok(ListaProduto);
        }
    }
}
    
