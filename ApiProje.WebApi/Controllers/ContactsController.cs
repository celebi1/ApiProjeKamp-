using ApiProje.WebApi.Context;
using ApiProje.WebApi.Dtos.ContactDtos;
using ApiProje.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ApiContext _context;

        public ContactController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var contacts = _context.Contacts.ToList();
            return Ok(contacts);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            Contact contact = new Contact
            {
                MapLocation = createContactDto.MapLocation,
                Phone = createContactDto.Phone,
                Address = createContactDto.Address,
                Email = createContactDto.Email,
                OpenHours = createContactDto.OpenHours
            };
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return Ok("Silme İşlemi Başarılı");
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _context.Contacts.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            Contact contact = new Contact
            {
                ContactId = updateContactDto.ContactId,
                MapLocation = updateContactDto.MapLocation,
                Phone = updateContactDto.Phone,
                Address = updateContactDto.Address,
                Email = updateContactDto.Email,
                OpenHours = updateContactDto.OpenHours
            };
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok("Güncelleme İşlemi Başarılı");
        }
    }
}
