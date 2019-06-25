using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.API.Models;

namespace Web.API.Controllers
{
    public class ProdutoController : ApiController
    {
        /// <summary>
        /// Cadastro de produto
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <remarks>Recupera dados do cadastro de determinado produto</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public ProdutoModel Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cadastro completo de produtos
        /// </summary>
        /// <remarks>Recupera dados do cadastro de todos os produtos do sistema</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public List<ProdutoModel> GetAll()
        {
            throw new NotImplementedException();
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