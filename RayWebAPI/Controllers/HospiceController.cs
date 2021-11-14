using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace RayWebAPI.Controllers
{
    [ApiController]
    [Route("api/Hospice")]
    public class HospiceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Hospice> GetHospices()
        {
            var hospices = new List<Hospice>
            {
                new Hospice()
                {
                    Name = "Приют для животных, Бирюлёво Западное Продолжение названия и т.д.",
                    City = "Москва",
                    Street = "Харьковская улица",
                    HouseNumber = "1к3",
                    Latitude = 55.584126,
                    Longitude = 37.653343,
                    Mobile = "+7(977)124-02-19",
                    Website = "https://yandex.ru/",
                    EMail = "hospice_email@gmail.com",
                    Details = "Details about hospice."
                },
                new Hospice()
                {
                    Name = "Приют, Бирюлёво Западное",
                    City = "Москва",
                    Street = "Харьковская улица",
                    HouseNumber = "1к3",
                    Latitude = 55.584126,
                    Longitude = 37.653343,
                    Mobile = "+7(977)124-02-19",
                    Website = "https://yandex.ru/",
                    EMail = "hospice_email@gmail.com",
                    Details = "Details about hospice."
                },
                new Hospice()
                {
                    Name = "Приют, Бирюлёво Западное",
                    City = "Москва",
                    Street = "Харьковская улица",
                    HouseNumber = "1к3",
                    Metro = "fdsjfhdsfsdi",
                    Latitude = 55.584126,
                    Longitude = 37.653343,
                    Mobile = "+7(977)124-02-19",
                    Website = "https://yandex.ru/",
                    EMail = "hospice_email@gmail.com",
                    Details = "Details about hospice."
                },
                new Hospice()
                {
                    Name = "Приют, Бирюлёво Западное",
                    City = "Москва",
                    Street = "Харьковская улица ffdfgdgfd",
                    HouseNumber = "1к3 6575585656",
                    Latitude = 55.584126,
                    Longitude = 37.653343,
                    Mobile = "+7(977)124-02-19",
                    Website = "https://yandex.ru/",
                    EMail = "hospice_email@gmail.com",
                    Details = "Details about hospice."
                }
            };

            return hospices;
        }
    }
}