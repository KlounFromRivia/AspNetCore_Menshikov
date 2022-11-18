using AspNetCore_Menshikov.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Menshikov.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkladController : ControllerBase
    {
        private static readonly IList<SkaldGvozdie> Tovars = new List<SkaldGvozdie>();

        [HttpGet]
        public IEnumerable<SkaldGvozdie> Get()
        {
            return Tovars;
        }


        [HttpPost]
        public SkaldGvozdie Add(SkladModel model)
        {
            model.Proverka();
            var tovar = new SkaldGvozdie
            {
                Id = Guid.NewGuid(),
                TovarName = model.TovarName,
                Material = model.Material,
                Size = model.Size,
                Count = model.Count,
                MinCount = model.MinCount,
                Price = model.Price,
                AllPrice = Math.Round(model.Price*model.Count,2)
            };
            Tovars.Add(tovar);
            return tovar;
        }


        [HttpDelete("{id:guid}")]
        public bool DeleteUser(Guid id)
        {
            var tovar = Tovars.FirstOrDefault(x => x.Id == id);
            if (tovar != null)
            {
                return Tovars.Remove(tovar);
            }
            return false;
        }


        [HttpPut("{id:guid}")]
        public SkaldGvozdie Update([FromRoute] Guid id, [FromBody] SkladModel model)
        {
            var pttovar = Tovars.FirstOrDefault(x => x.Id == id);
            if (pttovar != null)
            {
                model.Proverka();
                pttovar.TovarName = model.TovarName;
                pttovar.Material = model.Material;
                pttovar.Size = model.Size;
                pttovar.Count = model.Count;
                pttovar.MinCount = model.MinCount;
                pttovar.Price = model.Price;
                pttovar.AllPrice = Math.Round(model.Price * model.Count, 2);
            }
            return pttovar;
        }


        [HttpGet("Statistic")]
        public StatisticSklad GetStats()
        {
            var sum = Tovars.Select(p => p.AllPrice).Sum();
            var result = new StatisticSklad()
            {
                AllTovar = Tovars.Count,
                AllPriceWithoutNDS = sum,
                AllPriceNDS = sum + sum* 0.2
            };

            return result;
        }
    }
}
