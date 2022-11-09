using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;

namespace Apdata
{
    internal class Mail
    {
        public Mail()
        {
            CarregarVariaveis();
            EnviarEmail();
        }

        public string DiretorioAplicacao { get; set; } = Directory.GetCurrentDirectory().Replace('/', '\\');
        public string ServidorSmtp { get; set; }
        public string PortaSmtp { get; set; }
        public string UsuarioSmtp { get; set; }
        public string SenhaSmtp { get; set; }
        public string Remetente { get; set; }
        public bool Ssl { get; set; }
        public string DiretorioArquivos { get; set; }
        public List<string> Destinatarios { get; set; }
        public List<string> Arquivos { get; set; }

        public void CarregarVariaveis()
        {
            var dic = File.ReadAllLines($@"{DiretorioAplicacao}\\Parametros.cfg")
              .Where(l => l.Contains('='))
              .Select(l => l.Split(new[] { '=' }))
              .ToDictionary(s => s[0].Trim(), s => s[1].Trim(), StringComparer.OrdinalIgnoreCase);

            ServidorSmtp = dic["smtp"];
            PortaSmtp = dic["porta"];
            try { Ssl = bool.Parse(dic["ssl"]); }
            catch { Ssl = true; }
            try
            {
                UsuarioSmtp = dic["usuario"];
                SenhaSmtp = dic["senha"];
            }
            catch
            {
                UsuarioSmtp = "";
                SenhaSmtp = "";
            }
            try { DiretorioArquivos = dic["Arquivos"]; }
            catch { DiretorioArquivos = ""; }

            Remetente = dic["remetente"];
            Destinatarios = dic["destinatario"].Split(';').Where(x => !string.IsNullOrEmpty(x)).ToList();

            if (Directory.Exists(DiretorioArquivos))
                Arquivos = Directory.GetFiles(DiretorioArquivos, "*.txt", SearchOption.TopDirectoryOnly).ToList();
        }
        public void EnviarEmail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(ServidorSmtp);
            mail.From = new MailAddress(Remetente);
            foreach (var destinatario in Destinatarios)
            {
                mail.To.Add(destinatario);
            }
            try
            {
                foreach (var arquivo in Arquivos)
                {
                    Attachment anexo = new Attachment(arquivo);
                    try { mail.Attachments.Add(anexo); }
                    catch { continue; }
                }
            }
            catch { }
            
            SmtpServer.Port = int.Parse(PortaSmtp);
            SmtpServer.Credentials = new System.Net.NetworkCredential(UsuarioSmtp, SenhaSmtp);
            SmtpServer.EnableSsl = Ssl;

            mail.Subject = $"[Apuração mensal {DateTime.Now.ToString("MM/yyyy")}]";
            mail.Body = $"Email automático - {DateTime.Now.ToString("'Enviado em 'dd/MM/yyyy' às 'HH:mm:ss")}";
            SmtpServer.Send(mail);
        }
    }
}
