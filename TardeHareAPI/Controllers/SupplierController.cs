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
    public class SupplierController : ApiController
    {
        TRADEHAREDBEntities objentites = new TRADEHAREDBEntities();

        [Route("api/Supplier/SupplierDetail")]
        [HttpGet]
        public IEnumerable<Supplier> SupplierDetail(int id, string name)
        {
            var result = objentites.GetSupplier(id, name).AsEnumerable();
            return result;
        }

        [Route("api/Supplier/AddSuppliers")]
        [HttpPost]
        public IHttpActionResult AddSuppliers(SupplierViewModel objcomm)
        {
            try
            {
                ObjectParameter objParam = new ObjectParameter("id", typeof(int));
                var result = objentites.AddSupplier(objcomm.SupplierName, objcomm.AddressLine1, objcomm.AddressLine2, objcomm.City, objcomm.State, objcomm.PostalCode, objcomm.ContactPerson, objcomm.Phone, objcomm.Fax, objcomm.Email1, objcomm.Email2, 1, objParam);
                return Ok(objParam.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [Route("api/Supplier/UpdateSupplier")]
        [HttpPost]
        public IHttpActionResult UpdateSupplier(SupplierViewModel objcomm)
        {
            try
            {
                var result = objentites.UpdateSupplier(objcomm.SupId,objcomm.SupplierName, objcomm.AddressLine1, objcomm.AddressLine2, objcomm.City, objcomm.State, objcomm.PostalCode, objcomm.ContactPerson, objcomm.Phone, objcomm.Fax, objcomm.Email1, objcomm.Email2,objcomm.Active,1);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [Route("api/Supplier/DeleteSupplier")]
        [HttpPost]
        public IHttpActionResult DeleteSupplier(SupplierViewModel objcomm)
        {
            try
            {
                var result = objentites.UpdateSupplier(objcomm.SupId, objcomm.SupplierName, objcomm.AddressLine1, objcomm.AddressLine2, objcomm.City, objcomm.State, objcomm.PostalCode, objcomm.ContactPerson, objcomm.Phone, objcomm.Fax, objcomm.Email1, objcomm.Email2, objcomm.Active, 1);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
