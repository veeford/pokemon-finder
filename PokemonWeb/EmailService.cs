using MailKit.Net.Smtp;
using MimeKit;
using PokemonWeb;

public class EmailService
{
    public async Task SendEmailAsync(string email, string subject, string message)
    {                        
        using var emailMessage = new MimeMessage();
 
        emailMessage.From.Add(new MailboxAddress("Pokemon App", Config.EmailAddress));
        emailMessage.To.Add(new MailboxAddress("", email));
        emailMessage.Subject = subject;
        emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        {
            Text = message
        };
             
        using (var client = new SmtpClient())
        {
            await client.ConnectAsync("smtp.yandex.ru", 25, false);
            await client.AuthenticateAsync(Config.EmailAddress, Config.EmailPasswd);
            await client.SendAsync(emailMessage);
 
            await client.DisconnectAsync(true);
        }
    }
}