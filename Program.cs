using System;

namespace ErrorTimestamp
{
    class Program
    {
        static void Main()
        {
            SpoClientes spoCliente = new SpoClientes();

            spoCliente.Id = 1;
            spoCliente.InscEstadual = "0000000";
            spoCliente.LimCredito = 10000;
            spoCliente.LocFiliais = "";
            spoCliente.NomeRep = "XXXXXX";
            spoCliente.Numero = "909";
            spoCliente.NumRegJc = "999999";
            spoCliente.NumSuframa = "999999999";
            spoCliente.ParComercial = "XXXXXXXX";
            spoCliente.ParFinanceiro = "XXXXXXXX";
            spoCliente.PrinProdVend = "XXXXXXXX";
            spoCliente.RazaoSocial = "XXXXXXXXX";
            spoCliente.RegTrib = true;
            spoCliente.RespCompras = "XXXXXXXX";
            spoCliente.Rua = "XXXX";
            spoCliente.Segmento = "XXXXXXXXXXXX";
            spoCliente.Socios = "XXXXXXXX";
            spoCliente.Suframa = true;
            spoCliente.Telefone = "XXXX-XXXX";
            spoCliente.Zfm = true;
            spoCliente.Atividade = "XXXXXXXX";
            spoCliente.Bairro = "XXXXX";
            spoCliente.Bens = "XXXXXXXXXX";
            spoCliente.CapReg = 99999;
            spoCliente.Cep = "99999999";
            spoCliente.Cidade = "XXXXXXX";
            spoCliente.CodEmitente = 99999;
            spoCliente.CodRep = 999;
            spoCliente.CodStatus = 1;
            spoCliente.Cpnj = "999999999999";
            spoCliente.DadosBanco = "XXXXXX";
            spoCliente.DtRegJc = Convert.ToDateTime("26/01/1995");
            spoCliente.Email = "XXXXXXX";
            spoCliente.EndBolDig = "XXXXXX";
            spoCliente.EndBolFisico = "XXXXXXXXX";
            spoCliente.Estado = "XX";
            spoCliente.Filiais = true;

            Ems2CustomContext cnx = new Ems2CustomContext();
            using (cnx)
            {
                try
                {
                    cnx.SClientes.Add(spoCliente);
                    cnx.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
