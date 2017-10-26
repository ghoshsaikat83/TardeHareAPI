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
    public class BuyerController : ApiController
    {
        TRADEHAREDBEntities objentites = new TRADEHAREDBEntities();

        [Route("api/Buyer/BuyerDetail")]
        [HttpGet]
        public IEnumerable<Buyer> BuyerDetail(int id, string name)
        {
            var result = objentites.GetBuyer(id, name).AsEnumerable();
            return result;
        }

        [Route("api/Buyer/AddBuyer")]
        [HttpPost]
        public IHttpActionResult AddBuyer(BuyerViewModel objcomm)
        {
            try
            {
                ObjectParameter objParam = new ObjectParameter("id", typeof(int));
                var result = objentites.AddBuyer(objcomm.BuyerName, objcomm.AddressLine1, objcomm.AddressLine2, objcomm.City, objcomm.State, objcomm.PostalCode, objcomm.ContactPerson, objcomm.Phone, objcomm.Fax, objcomm.Email1, objcomm.Email2, 1, objParam);
                return Ok(objParam.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [Route("api/Buyer/UpdateBuyer")]
        [HttpPost]
        public IHttpActionResult UpdateBuyer(BuyerViewModel objcomm)
        {
            try
            {
                var result = objentites.UpdateBuyer(objcomm.BuyId, objcomm.BuyerName, objcomm.AddressLine1, objcomm.AddressLine2, objcomm.City, objcomm.State, objcomm.PostalCode, objcomm.ContactPerson, objcomm.Phone, objcomm.Fax, objcomm.Email1, objcomm.Email2, objcomm.Active, 1);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [Route("api/Buyer/DeleteBuyer")]
        [HttpPost]
        public IHttpActionResult DeleteBuyer(BuyerViewModel objcomm)
        {
            try
            {
                var result = objentites.UpdateBuyer(objcomm.BuyId, objcomm.BuyerName, objcomm.AddressLine1, objcomm.AddressLine2, objcomm.City, objcomm.State, objcomm.PostalCode, objcomm.ContactPerson, objcomm.Phone, objcomm.Fax, objcomm.Email1, objcomm.Email2, objcomm.Active, 1);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
