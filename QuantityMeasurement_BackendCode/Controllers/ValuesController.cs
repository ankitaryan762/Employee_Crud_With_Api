using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurement_Manager;
using QuantityMeasurement_Model;

namespace QuantityMeasurement_BackendCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
            public IManager manager;

            public ValuesController(IManager manager)
            {
                this.manager = manager;
            }


            // GET api/values
            [Route("FeettoInch")]
            [HttpPost]
            public IActionResult FeettoInch(Model value)
            {
                var result = this.manager.FeettoInch(value);

                if (result >= 0)
                {
                    return this.Ok(result);
                }
                return this.BadRequest();
            }


            [Route("InchToFeet")]
            [HttpPost]
            public IActionResult InchToFeet(Model value)
            {
                var result = this.manager.InchToFeet(value);

                if (result >= 0)
                {
                    return this.Ok(result);
                }
                return this.BadRequest();
            }

            [Route("MetertoCentimeter")]
            [HttpPost]
            public IActionResult MetertoCentimeter(Model value)
            {
                var result = this.manager.MetertoCentimeter(value);

                if (result >= 0)
                {
                    return this.Ok(result);
                }
                return this.BadRequest();
            }

            [Route("CentimetertoMeter")]
            [HttpPost]
            public IActionResult CentimetertoMeter(Model value)
            {
                var result = this.manager.CentimetertoMeter(value);

                if (result >= 0)
                {
                    return this.Ok(result);
                }
                return this.BadRequest();
            }

            [Route("KgtoGm")]
            [HttpPost]
            public IActionResult KgtoGm(Model value)
            {
                var result = this.manager.KgtoGm(value);

                if (result >= 0)
                {
                    return this.Ok(result);
                }
                return this.BadRequest();
            }

            [Route("GmtoKg")]
            [HttpPost]
            public IActionResult GmtoKg(Model value)
            {
                var result = this.manager.GmtoKg(value);

                if (result >= 0)
                {
                    return this.Ok(result);
                }
                return this.BadRequest();
            }
        }
}
