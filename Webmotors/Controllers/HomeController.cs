using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Webmotors.Lib;

namespace Webmotors.Controllers
{
    public class HomeController : Controller
    {
        private const string ws_address = "http://desafioonline.webmotors.com.br/api/OnlineChallenge";

        public IActionResult Index()
        {
            List<Models.AnuncioWebmotors> cars = new List<Models.AnuncioWebmotors>();
            BD.Repo.AnuncioWebmotors repo = new BD.Repo.AnuncioWebmotors();
            cars = repo.Consultar();

            return View(cars);
        }


        [Route("/Edit/{id?}")]
        public IActionResult Car(int id)
        {
            Models.AnuncioWebmotors anuncio = new Models.AnuncioWebmotors();
            if (id != 0)
            {
                anuncio = new BD.Repo.AnuncioWebmotors().Consultar(id);
                anuncio.modelos = GetModels(anuncio.marca);
                anuncio.versoes = GetVersions(anuncio.modelo);
            }

            anuncio.marcas = GetMakes();
            return View(anuncio);
        }


        public List<Models.Ws> GetMakes()
        {
            try
            {
                return Util.GetJsonAndDeserialize<List<Models.Ws>>(string.Concat(ws_address, "/Make"), "GET", "application/json");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Models.Ws> GetModels(string makeId)
        {
            try
            {
                return Util.GetJsonAndDeserialize<List<Models.Ws>>(string.Concat(ws_address, "/Model?MakeID=", makeId), "GET", "application/json");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public JsonResult GetModelsJs(int makeId)
        {
            try
            {
                if (makeId != 0)
                {
                    return Json(GetModels(makeId.ToString()));
                }
                else
                {
                    return Json("");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Models.Ws> GetVersions(string modelId)
        {
            try
            {

                return Util.GetJsonAndDeserialize<List<Models.Ws>>(string.Concat(ws_address, "/Version?ModelID=", modelId), "GET", "application/json");

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public JsonResult GetVersionsJs(int modelId)
        {
            try
            {
                if (modelId != 0)
                {
                    return Json(GetVersions(modelId.ToString()));
                }
                else
                {
                    return Json("");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public List<Models.AnuncioWebmotors> GetVehicles(int page)
        //{
        //    try
        //    {
        //        return Util.GetJsonAndDeserialize<List<Car>>(string.Concat(address, "/Vehicles?Page=", page.ToString()), "GET", "application/json");
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        [HttpPost]
        [Route("/Edit")]
        public void Edit(Models.AnuncioWebmotors car)
        {
            BD.Repo.AnuncioWebmotors repo = new BD.Repo.AnuncioWebmotors();
            if (car.ID == 0)
            {
                repo.Incluir(car);
            }
            else
            {
                repo.Atualizar(car);
            }
        }
        [HttpPost]
        public bool Del(int id)
        {
            try
            {
                Models.AnuncioWebmotors car = new Models.AnuncioWebmotors();
                BD.Repo.AnuncioWebmotors repo = new BD.Repo.AnuncioWebmotors();
                car = repo.Consultar(id);

                repo.Remover(car);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
