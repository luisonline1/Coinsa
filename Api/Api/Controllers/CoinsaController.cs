using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Api.Models;

namespace Api.Controllers
{
    public class CoinsaController : Controller
    {
        [HttpGet]
        public string Login(string usuario, string Contraseña)
        {
            try
            {
                using (BdCoinsa BdCoinsa = new BdCoinsa())
                {
                    
                }
                return "";
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }
    }
}