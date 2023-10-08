using api.cms.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.cms.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Company>>> Get()
        {
            try
            {
                using (var context = new CmsDbContext())
                {
                    var list = await context.Companies.ToListAsync();
                    return Ok(list);
                }
            }
            catch (Exception)
            {
                return BadRequest("Bir hata oluştu.");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Company>>> GetAsync(int id)
        {
            try
            {
                using (var context = new CmsDbContext())
                {
                    var list = await context.Companies.Where(x => x.Id == id).ToListAsync();
                    return Ok(list);
                }
            }
            catch (Exception)
            {
                return BadRequest("Bir hata oluştu.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Company>> Post([FromBody] Company value)
        {
            try
            {
                using (var context = new CmsDbContext())
                {
                    await context.Companies.AddAsync(value);

                    await context.SaveChangesAsync();
                    return Ok(value);
                }
            }
            catch (Exception)
            {
                return BadRequest("Bir hata oluştu.");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Company>> Put(int id, [FromBody] Company value)
        {
            try
            {
                using (var context = new CmsDbContext())
                {
                    var company = await context.Companies.FirstAsync(item => item.Id == id);

                    if (company == null || value == null)
                    {
                        return BadRequest("Şirket bulunamadı.");
                    }
                    else
                    {
                        company.Name = value.Name;
                        company.Description = value.Description;
                        company.Slogan = value.Slogan;
                        company.PhoneNumber = value.PhoneNumber;
                        company.Email = value.Email;
                        company.About = value.About;

                        await context.SaveChangesAsync();

                        return Ok(company);
                    }
                }
            }
            catch (Exception)
            {
                return BadRequest("Bir hata oluştu.");
            }
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                using (var context = new CmsDbContext())
                {
                    var company = await context.Companies.FirstAsync(item => item.Id == id);
                    context.Companies.Remove(company);
                    await context.SaveChangesAsync();
                };

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Bir hata oluştu.");
            }
        }
    }
}
