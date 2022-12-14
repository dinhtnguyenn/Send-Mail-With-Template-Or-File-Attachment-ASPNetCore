using System;
namespace SendMail.Models
{
    public interface IMailService
    {
        Task SendMailAsync(MailRequest mailRequest);

        //send mail template
        Task SendMailWithTemplateAsync(MailRequest mailRequest);
    }
}

