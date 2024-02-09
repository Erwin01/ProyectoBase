using BA.Data;
using BA.Domain.Contracts;
using BA.Domain.Implementation;
using BA.WebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace BA.WebApi.Controllers
{

    /// <summary>
    /// Controlador encargado de acceder a las solicitudes o formularios.
    /// </summary>
    /// *-----------------------------------------------------------------------------------------*
    /// * Archivo:          SolicitudController.cs
    /// * Tipo:             Controller
    /// * Autor:            Erwin Parales
    /// * Fecha:            2019 Septiembre 19
    /// * Propósito:        Acceder a las solicitudes o formularios
    /// *-----------------------------------------------------------------------------------------*

    [RoutePrefix("api/form")]
    [AllowAnonymous]
    public class MembersController : ApiController
    {
        private readonly IServiveMember service = new ServiceMember();

        #region [Create]
        /// <summary>
        /// Create Member
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [Route("save")]
        [HttpPost]
        public IHttpActionResult Create([FromBody] MemberModel data)
        {

            if (!ModelState.IsValid)
            {
                BadRequest();
            }

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                var response = service.Create(data.Id, data.ProjectId, data.FirstName, data.LastName, data.Title);
                data = EntityModel(response);

                return Ok(data);

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return InternalServerError(new Exception(Ex.Message));
            }
        }
        #endregion

        #region [Model Member Global]
        /// <summary>
        /// Model Member Global
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private MemberModel EntityModel(Member entity)
        {
            if (entity == null)
            {
                return null;
            }

            var model = new MemberModel();
            {
                model.Id = entity.Id;
                model.ProjectId = entity.ProjectId;
                model.FirstName = entity.FirstName;
                model.LastName = entity.LastName;
                model.Title = entity.Title;
            };

            return model;
        }
        #endregion
    }
}
