using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SendMail.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SendMail.Controllers
{
    public class SendMailController : Controller
    {
        private readonly IMailService mailService;
        public SendMailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost("send-mail")]
        public async Task<IActionResult> SendMail(MailRequest request)
        {
            try
            {
                await mailService.SendMailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        [HttpPost("send-mail-with-template")]
        public async Task<IActionResult> SendEmaiWithTemplate(MailRequest request)
        {
            try
            {
                await mailService.SendMailWithTemplateAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

