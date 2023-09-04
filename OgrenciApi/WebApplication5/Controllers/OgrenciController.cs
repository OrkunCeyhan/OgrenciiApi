using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OgrenciController : ControllerBase
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 1, AdSoyad = "ahmet sarı" },
            new Ogrenci { Id = 2, AdSoyad = "mehmet köse" },
            new Ogrenci { Id = 3, AdSoyad = "salih vardar" }
        };

        [HttpGet]
        public List<Ogrenci> Get()
        {

            return ogrenciler;
        }

        [HttpGet("{id}")]
        public Ogrenci Get(int id) {
        return ogrenciler.FirstOrDefault(o => o.Id == id);
        }
        [HttpPost]
        public Ogrenci Post(Ogrenci ogrenci) {
            ogrenciler.Add(ogrenci);
            return ogrenci;
        }

    }
}
