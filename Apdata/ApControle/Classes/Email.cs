using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace ApControle.Classes
{
    [Table("DisparosEmail")]
    internal class Email
    {
        public Email() { }
        public Email(Controle controle)
        {
            ControleAcesso = controle;
            DestinatariosArray = controle.Destinatarios.Split(";");
            TextoEmail = GetCorpo();
            Destinatarios = controle.Destinatarios;
            IdControle = controle.Id;
        }

        [Key]
        public int Id { get; set; }
        public int IdControle { get; set; }
        public string TextoEmail { get; set; }
        public string Destinatarios { get; set; }
        public DateTime DataEnvio { get; set; } = DateTime.Now;

        [ForeignKey("IdControle")]
        public virtual Controle ControleEnviado { get; set; }


        [NotMapped]
        public Controle ControleAcesso { get; set; }

        [NotMapped]
        public string[] DestinatariosArray { get; set; }

        [NotMapped]
        public static List<Configuracao> Configuracoes { get; set; } = new Contexto().Configuracoes.ToList();

        private static string GetConfiguracao(string parametro)
        {
            return Configuracoes.Where(x =>
                                       x.Parametro.ToLower() == parametro.ToLower())
                                .FirstOrDefault()
                                .Valor;
        }

        public string GetSmtp()
        {
            return GetConfiguracao("Smtp");
        }
        public int GetPorta()
        {
            return int.Parse(GetConfiguracao("Porta"));
        }
        public bool GetSsl()
        {
            return GetConfiguracao("Ssl") == "1";
        }
        public string GetRemetente()
        {
            return GetConfiguracao("Remetente");
        }
        public string GetAssunto()
        {
            return Replace(GetConfiguracao("Assunto"));
        }       
        public string GetCorpo()
        {
            return Replace(GetConfiguracao("Corpo"));
        }
        public int GetDiasRestantes()
        {
            return (int)((DateTime)ControleAcesso.DataFim - DateTime.Today).TotalDays;
        }

        public string Replace(string variavel)
        {
            return variavel.Replace("#BASEDADOS#", ControleAcesso.Database, StringComparison.OrdinalIgnoreCase)
                           .Replace("#IPSERVICO#", ControleAcesso.IpServico, StringComparison.OrdinalIgnoreCase)
                           .Replace("#PORTASERVICO#", ControleAcesso.PortaServico, StringComparison.OrdinalIgnoreCase)
                           .Replace("#DATACRIACAO#", ControleAcesso.DataCriacao?.ToString("dd/MM/yyyy"), StringComparison.OrdinalIgnoreCase)
                           .Replace("#DATAFIM#", ControleAcesso.DataFim?.ToString("dd/MM/yyyy"), StringComparison.OrdinalIgnoreCase)
                           .Replace("#DIASRESTANTES#", GetDiasRestantes().ToString(), StringComparison.OrdinalIgnoreCase); ;
    }

        public void Disparar()
        {
            MailMessage email = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(GetSmtp(), GetPorta());
            email.From = new MailAddress(GetRemetente());
            SmtpServer.EnableSsl = GetSsl();
            email.Subject = GetAssunto();
            email.Body = GetCorpo();
            //email.CC.Add(email.From);
            email.IsBodyHtml = true;
            foreach (var destinatario in DestinatariosArray.Where(x => !string.IsNullOrEmpty(x)))
            {
                email.To.Add(destinatario.Trim());
            }

            SmtpServer.Send(email);

            using (var ctx = new Contexto())
            {
                ctx.Emails.Add(this);
                ctx.SaveChanges();
            }
        }
    }
}
