// See https://aka.ms/new-console-template for more information
using SendGrid;
using SendGrid.Helpers.Mail;

Console.WriteLine("Hello, World!");
Execute().Wait();

static async Task Execute()
{
    var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
    var client = new SendGridClient(apiKey);
    var from = new EmailAddress("sharon088@gmail.com", "sharon User");
    var subject = "Sending with SendGrid is Fun";
    var to = new EmailAddress("rotem23592@gmail.com", "Example User");
    var plainTextContent = "and easy to do anywhere, even with C#";
    var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
    var response = await client.SendEmailAsync(msg);
}
