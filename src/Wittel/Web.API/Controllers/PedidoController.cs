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

        private WittelDBContext db = new WittelDBContext();

        /// <summary>
        /// Pedido registrado
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <remarks>Recupera dados de determinado pedido</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        public IHttpActionResult Get(int id)
        {
            var obj = db.Pedidos.FirstOrDefault(x => x.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return Json(obj);
        }

        /// <summary>
        /// Registro completo de pedidos
        /// </summary>
        /// <remarks>Recupera dados de todos os pedidos do sistema</remarks>
        /// <response code="200">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        public IHttpActionResult GetAll()
        {
            var obj = db.Pedidos.ToList();

            if ((obj == null) || (obj.Count == 0))
            {
                return NotFound();
            }

            return Json(obj);
        }

        /// <summary>
        /// Cadastrar pedido
        /// </summary>
        /// <param name="value">Dados do pedido a ser cadastrado</param>
        /// <remarks>Cadastra novo pedido no sistema</remarks>
        /// <response code="201">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        public IHttpActionResult Post([FromBody]Order value)
        {
            try
            {
                using (var dbContext = new WittelDBContext())
                {
                    var order = new Order()
                    {
                        DataPedido = value.DataPedido,
                        Descricao = value.Descricao,
                        ValorTotalPedido = value.ValorTotalPedido
                    };

                    order.ItensPedido = new List<OrderItem>();

                    foreach (var item in value.ItensPedido)
                    {
                        var orderItem = new OrderItem()
                        {
                            ProdutoId = item.ProdutoId,
                            Descricao = item.Descricao,
                            Quantidade = item.Quantidade,
                            ValorUnitario = item.ValorUnitario,
                            ValorTotal = item.ValorTotal
                        };

                        order.ItensPedido.Add(orderItem);
                    }

                    dbContext.Pedidos.Add(value);

                    dbContext.SaveChanges();
                }
                return StatusCode(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Alterar pedido
        /// </summary>
        /// <param name="id">Identificador do pedido</param>
        /// <param name="value">Dados do pedido a ser alterado</param>
        /// <remarks>Altera pedido no sistema</remarks>
        /// <response code="202">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        public IHttpActionResult Put(int id, [FromBody]Order value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Apagar pedido
        /// </summary>
        /// <param name="id">Identificador do pedido</param>
        /// <remarks>Apaga pedido no sistema</remarks>
        /// <response code="202">Sucesso</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        public IHttpActionResult Delete(int id)
        {
            throw new NotImplementedException();
            //var obj = db.Pedidos.FirstOrDefault(x => x.Id == id);

            //if (obj != null)
            //{
            //    db.Pedidos.Remove(obj);
            //    db.SaveChanges();

            //    return StatusCode(HttpStatusCode.Accepted);
            //}

            //return NotFound();
        }
    }
}