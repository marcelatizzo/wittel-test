using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Web.API.Models;

namespace Web.API.Controllers
{
    public class ProdutoController : ApiController
    {
        private WittelDBContext db = new WittelDBContext();

        /// <summary>
        /// Cadastro de produto
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <remarks>Recupera dados do cadastro de determinado produto</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        public IHttpActionResult Get(int id)
        {
            var obj = db.Produtos.FirstOrDefault(x => x.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return Json(obj);
        }

        /// <summary>
        /// Cadastro completo de produtos
        /// </summary>
        /// <remarks>Recupera dados do cadastro de todos os produtos do sistema</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        public IHttpActionResult GetAll()
        {
            var obj = db.Produtos.ToList();

            if (obj == null)
            {
                return NotFound();
            }

            return Json(obj);
        }

        //public void Post([FromBody]ProdutoModel value)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Put(int id, [FromBody]ProdutoModel value)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}