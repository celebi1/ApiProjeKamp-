using ApiProje.WebApi.Context;
using ApiProje.WebApi.Dtos.MessageDtos;
using ApiProje.WebApi.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;

        public MessagesController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _context.Messages.ToList();

            return Ok(_mapper.Map<List<ResultMessageDto>>(values));
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            var message = _mapper.Map<Entities.Message>(createMessageDto);
            _context.Messages.Add(message);
            _context.SaveChanges();
            return Ok("Mesaj Ekleme İşlemi Başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            if (value == null)
            {
                return NotFound("Mesaj Bulunamadı");
            }
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return Ok("Mesaj Silme İşlemi Başarılı");
        }
        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var values = _context.Messages.Find(id);
            if (values == null)
            {
                return NotFound("Mesaj Bulunamadı");
            }
            return Ok(_mapper.Map<GetByIdMessageDto>(values));
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            var value = _mapper.Map<Message>(updateMessageDto);
            _context.Messages.Update(value);
            _context.SaveChanges();
            return Ok("Mesaj Güncelleme İşlemi Başarılı");
        }
    }
}
