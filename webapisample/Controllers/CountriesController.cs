using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Controllers
{

    [Route("api/countries/{id}")]
    public class CountriesController : ApiController
    {



   
        [HttpGet]
        public IEnumerable<CountryModel> GetAll([FromUri] GetAllCountriesModel request, [FromUri] PagingModel paging)
        {

            return new[] { new CountryModel() };
        }

        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            return Request.CreateResponse<CountryModel>(new CountryModel());
        }

    }
}
