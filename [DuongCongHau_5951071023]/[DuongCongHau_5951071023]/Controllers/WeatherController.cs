using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Runtime.Serialization;
using Weather.Models;

namespace Weather.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<WeatherInfor> Get()
        {
            var weatherInfList = new List<WeatherInfor>();
            for (int i = 0; i < 10; i++)
            {
                var WeatherInfor = new WeatherInfor
                {
                    Location = $"Location{i}",
                    Degree = i * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime()
                };
                weatherInfList.Add(WeatherInfor);
            }
            return weatherInfList;
        }

        // GET: api/Weather/5
        public WeatherInfor Get(int id)
        {
            return new WeatherInfor
            {
                Location = $"Location{id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()
            };
        }
    }
}
