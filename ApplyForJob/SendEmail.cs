using System;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using ApplyForJob.MainActivity;

namespace ApplyForJob {
	public class Sendmail
	{
		

		public static void FrontEnd (string[] args)
		{

			MainActivity = new MainActivity ();
		
			var message = new MimeMessage ();
			message.From.Add (new MailboxAddress ("test", "test@test.com"));
			message.To.Add (new MailboxAddress (MainActivity.nome, MainActivity.email));
			message.Subject = "Obrigado por se candidatar";

			message.Body = new TextPart ("plain") {
				Text = @"Obrigado por se candidatar, assim que tivermos uma vaga disponível

para programador Front-End entraremos em contato."

			};

			using (var client = new SmtpClient ()) {
				client.Connect ("smtp.test.com", 587, false);

				// Note: since we don't have an OAuth2 token, disable
				// the XOAUTH2 authentication mechanism.
				client.AuthenticationMechanisms.Remove ("XOAUTH2");

				// Note: only needed if the SMTP server requires authentication
				client.Authenticate ("test", "password");

				client.Send (message);
				client.Disconnect (true);
			}
		}
		public static void BackEnd (string[] args)
		{

			MainActivity = new MainActivity ();

			var message = new MimeMessage ();
			message.From.Add (new MailboxAddress ("test", "test@test.com"));
			message.To.Add (new MailboxAddress (MainActivity.nome, MainActivity.email));
			message.Subject = "Obrigado por se candidatar";

			message.Body = new TextPart ("plain") {
				Text = @"Obrigado por se candidatar, assim que tivermos uma vaga disponível

para programador Back-End entraremos em contato."

			};

			using (var client = new SmtpClient ()) {
				client.Connect ("smtp.test.com", 587, false);

				// Note: since we don't have an OAuth2 token, disable
				// the XOAUTH2 authentication mechanism.
				client.AuthenticationMechanisms.Remove ("XOAUTH2");

				// Note: only needed if the SMTP server requires authentication
				client.Authenticate ("test", "password");

				client.Send (message);
				client.Disconnect (true);
			}
		}
		public static void Mobile (string[] args)
		{

			MainActivity = new MainActivity ();

			var message = new MimeMessage ();
			message.From.Add (new MailboxAddress ("test", "test@test.com"));
			message.To.Add (new MailboxAddress (MainActivity.nome, MainActivity.email));
			message.Subject = "Obrigado por se candidatar";

			message.Body = new TextPart ("plain") {
				Text = @"Obrigado por se candidatar, assim que tivermos uma vaga disponível

para programador Mobile entraremos em contato."
			};

			using (var client = new SmtpClient ()) {
				client.Connect ("smtp.test.com", 587, false);

				// Note: since we don't have an OAuth2 token, disable
				// the XOAUTH2 authentication mechanism.
				client.AuthenticationMechanisms.Remove ("XOAUTH2");

				// Note: only needed if the SMTP server requires authentication
				client.Authenticate ("test", "password");

				client.Send (message);
				client.Disconnect (true);
			}
		}
		public static void Generic (string[] args)
		{

			MainActivity = new MainActivity ();

			var message = new MimeMessage ();
			message.From.Add (new MailboxAddress ("test", "test@test.com"));
			message.To.Add (new MailboxAddress (MainActivity.nome, MainActivity.email));
			message.Subject = "Obrigado por se candidatar";

			message.Body = new TextPart ("plain") {
				Text = @"Obrigado por se candidatar, assim que tivermos uma vaga disponível

para programador entraremos em contato."

			};

			using (var client = new SmtpClient ()) {
				client.Connect ("smtp.test.com", 587, false);

				// Note: since we don't have an OAuth2 token, disable
				// the XOAUTH2 authentication mechanism.
				client.AuthenticationMechanisms.Remove ("XOAUTH2");

				// Note: only needed if the SMTP server requires authentication
				client.Authenticate ("test", "password");

				client.Send (message);
				client.Disconnect (true);
			}
		}
	}
}
