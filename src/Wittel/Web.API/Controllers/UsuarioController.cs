using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.API.Models;

namespace Web.API.Controllers
{
    public class UsuarioController : ApiController
    {
        /// <summary>
        /// Cadastro usuário
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <remarks>Recupera dados do cadastro de determinado usuário</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public UsuarioModel Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cadastro completo de usuários
        /// </summary>
        /// <remarks>Recupera dados do cadastro de todos os usuários do sistema</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public List<UsuarioModel> GetAll()
        {
            throw new NotImplementedException();
        }

        //public void Post([FromBody]UsuarioModel value)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Put(int id, [FromBody]UsuarioModel value)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}