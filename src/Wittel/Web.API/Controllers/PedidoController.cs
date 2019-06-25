using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.API.Models;

namespace Web.API.Controllers
{
    public class PedidoController : ApiController
    {
        /// <summary>
        /// Pedido registrado
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <remarks>Recupera dados de determinado pedido</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public PedidoModel Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Registro completo de pedidos
        /// </summary>
        /// <remarks>Recupera dados de todos os pedidos do sistema</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public List<PedidoModel> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cadastrar pedido
        /// </summary>
        /// <param name="value">Dados do pedido a ser cadastrado</param>
        /// <remarks>Cadastra novo pedido no sistema</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public void Post([FromBody]PedidoModel value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Alterar pedido
        /// </summary>
        /// <param name="id">Identificador do pedido</param>
        /// <param name="value">Dados do pedido a ser alterado</param>
        /// <remarks>Altera pedido no sistema</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public void Put(int id, [FromBody]PedidoModel value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Apagar pedido
        /// </summary>
        /// <param name="id">Identificador do pedido</param>
        /// <remarks>Apaga pedido no sistema</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}