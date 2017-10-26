using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TardeHareAPI.Models;

namespace TardeHareAPI.Controllers
{
    public class NotifyPartyController : ApiController
    {
        TRADEHAREDBEntities objentites = new TRADEHAREDBEntities();

        [Route("api/NotifyParty/NotifyPartyDetail")]
        [HttpGet]
        public IEnumerable<NotifyParty> NotifyPartyDetail(int id, string name)
        {
            var result = objentites.GetNotifyParty(id, name).AsEnumerable();
            return result;
        }

        [Route("api/NotifyParty/AddNotifyParty")]
        [HttpPost]
        public IHttpActionResult AddNotifyParty(NotifyPartyViewModel objcomm)
        {
            try
            {
                ObjectParameter objParam = new ObjectParameter("id", typeof(int));
                var result = objentites.AddNotifyParty(objcomm.PartyName, objcomm.AddressLine1, objcomm.AddressLine2, objcomm.City, objcomm.State, objcomm.PostalCode, objcomm.ContactPerson, objcomm.Phone, objcomm.Fax, objcomm.Email1, objcomm.Email2, 1, objParam);
                return Ok(objParam.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [Route("api/NotifyParty/UpdateNotifyParty")]
        [HttpPost]
        public IHttpActionResult UpdateNotifyParty(NotifyPartyViewModel objcomm)
        {
            try
            {
                var result = objentites.UpdateNotifyParty(objcomm.ParId, objcomm.PartyName, objcomm.AddressLine1, objcomm.AddressLine2, objcomm.City, objcomm.State, objcomm.PostalCode, objcomm.ContactPerson, objcomm.Phone, objcomm.Fax, objcomm.Email1, objcomm.Email2, objcomm.Active, 1);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [Route("api/NotifyParty/DeleteNotifyParty")]
        [HttpPost]
        public IHttpActionResult DeleteNotifyParty(NotifyPartyViewModel objcomm)
        {
            try
            {
                var result = objentites.UpdateNotifyParty(objcomm.ParId, objcomm.PartyName, objcomm.AddressLine1, objcomm.AddressLine2, objcomm.City, objcomm.State, objcomm.PostalCode, objcomm.ContactPerson, objcomm.Phone, objcomm.Fax, objcomm.Email1, objcomm.Email2, objcomm.Active, 1);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
