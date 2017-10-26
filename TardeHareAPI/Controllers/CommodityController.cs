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
    public class CommodityController : ApiController
    {
        TRADEHAREDBEntities objentites = new TRADEHAREDBEntities();

        [Route("api/Commodity/CommodityDetail")]
        [HttpGet]
        public IEnumerable<CommodityList> CommodityDetail(int id, string name)
        {
            var result = objentites.GetCommodity(id, name).AsEnumerable();
            return result;
        }

        [Route("api/Commodity/AddCommodity")]
        [HttpPost]
        public IHttpActionResult AddCommodity(CommodityViewModel objcomm)
        {
            try
            {
                ObjectParameter objParam = new ObjectParameter("id", typeof(int));
                var result = objentites.AddCommodity(objcomm.CommodityName, objcomm.CommoditySpec, objcomm.TradeRules, 1, objParam);
                return Ok(objParam.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [Route("api/Commodity/UpdateCommodity")]
        [HttpPost]
        public IHttpActionResult UpdateCommodity(CommodityViewModel objcomm)
        {
            try
            {                
                var result = objentites.UpdateCommodity(objcomm.ComId,objcomm.CommodityName, objcomm.CommoditySpec, objcomm.TradeRules,objcomm.Active, 1);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [Route("api/Commodity/DeleteCommodity")]
        [HttpPost]
        public IHttpActionResult DeleteCommodity(CommodityViewModel objcomm)
        {
            try
            {                
                var result = objentites.UpdateCommodity(objcomm.ComId, objcomm.CommodityName, objcomm.CommoditySpec, objcomm.TradeRules, objcomm.Active, 1);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
