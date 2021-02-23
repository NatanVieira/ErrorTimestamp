using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.SqlServer.Server;

namespace ErrorTimestamp
{
    [Table("spo-clientes")]
    class SpoClientes
    {
        private int id;
        private int codRep;
        private string nomeRep;
        private string razaoSocial;
        private string segmento;
        private int codSegmento;
        private string cpnj;
        private string inscEstadual;
        private string telefone;
        private string email;
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private bool suframa;
        private string numSuframa;
        private bool filiais;
        private string locFiliais;
        private bool regTrib;
        private string prinProdVend;
        private string numRegJc;
        private DateTime? dtRegJc;
        private double capReg;
        private string socios;
        private string respCompras;
        private string dadosBanco;
        private string bens;
        private string endBolFisico;
        private string endBolDig;
        private double limCredito;
        private string parFinanceiro;
        private string parComercial;
        private int codEmitente;
        private int codStatus;
        private string atividade;
        private bool zfm;

        public SpoClientes()
        {
        }

        public SpoClientes(int id, int codRep, string nomeRep, string razaoSocial, int codSegmento, string cpnj, string inscEstadual, string telefone, string email, string rua,
                           string numero, string bairro, string cidade, string estado, string cep, bool suframa, string numSuframa, bool filiais, string locFiliais, bool regTrib,
                           string prinProdVend, string numRegJc, DateTime dtRegJc, double capReg, string socios, string respCompras, string dadosBanco, string bens, string endBolFisico,
                           string endBolDig, double limCredito, string parFinanceiro, string parComercial, int codEmitente, int codStatus, string atividade, bool zfm,
                           string segmento)
        {
            this.id = id;
            this.codRep = codRep;
            this.nomeRep = nomeRep;
            this.razaoSocial = razaoSocial;
            this.codSegmento = codSegmento;
            this.cpnj = cpnj;
            this.inscEstadual = inscEstadual;
            this.telefone = telefone;
            this.email = email;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.suframa = suframa;
            this.numSuframa = numSuframa;
            this.filiais = filiais;
            this.locFiliais = locFiliais;
            this.regTrib = regTrib;
            this.prinProdVend = prinProdVend;
            this.numRegJc = numRegJc;
            this.dtRegJc = dtRegJc;
            this.capReg = capReg;
            this.socios = socios;
            this.respCompras = respCompras;
            this.dadosBanco = dadosBanco;
            this.bens = bens;
            this.endBolFisico = endBolFisico;
            this.endBolDig = endBolDig;
            this.limCredito = limCredito;
            this.parFinanceiro = parFinanceiro;
            this.parComercial = parComercial;
            this.codEmitente = codEmitente;
            this.codStatus = codStatus;
            this.atividade = atividade;
            this.zfm = zfm;
            this.segmento = segmento;

            switch (this.segmento)
            {
                case "Revenda":
                    this.codSegmento = 1;
                    break;
                case "Institucional":
                    this.codSegmento = 2;
                    break;
                case "Varejo":
                    this.codSegmento = 3;
                    break;
                case "Exportação":
                    this.codSegmento = 4;
                    break;
                case "Supermercado":
                    this.codSegmento = 5;
                    break;
                default:
                    this.codSegmento = 1;
                    break;
            }
        }

        [Key, Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("cod-rep")]
        public int CodRep { get => codRep; set => codRep = value; }
        [Column("nome-rep")]
        public string NomeRep { get => nomeRep; set => nomeRep = value; }
        [Column("razao-social")]
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        [Column("cod-segmento")]
        public int CodSegmento { get => codSegmento; set => codSegmento = value; }
        [Column("cnpj")]
        public string Cpnj { get => cpnj; set => cpnj = value; }
        [Column("insc-estadual")]
        public string InscEstadual { get => inscEstadual; set => inscEstadual = value; }
        [Column("telefone")]
        public string Telefone { get => telefone; set => telefone = value; }
        [Column("e-mail")]
        public string Email { get => email; set => email = value; }
        [Column("rua")]
        public string Rua { get => rua; set => rua = value; }
        [Column("numero")]
        public string Numero { get => numero; set => numero = value; }
        [Column("bairro")]
        public string Bairro { get => bairro; set => bairro = value; }
        [Column("cidade")]
        public string Cidade { get => cidade; set => cidade = value; }
        [Column("estado")]
        public string Estado { get => estado; set => estado = value; }
        [Column("cep")]
        public string Cep { get => cep; set => cep = value; }
        [Column("suframa")]
        public bool Suframa { get => suframa; set => suframa = value; }
        [Column("num-suframa")]
        public string NumSuframa { get => numSuframa; set => numSuframa = value; }
        [Column("filiais")]
        public bool Filiais { get => filiais; set => filiais = value; }
        [Column("loc-filiais")]
        public string LocFiliais { get => locFiliais; set => locFiliais = value; }
        [Column("reg-trib")]
        public bool RegTrib { get => regTrib; set => regTrib = value; }
        [Column("prin-prod-vend")]
        public string PrinProdVend { get => prinProdVend; set => prinProdVend = value; }
        [Column("num-reg-jc")]
        public string NumRegJc { get => numRegJc; set => numRegJc = value; }
        [Column("dt-reg-jc")]
        public DateTime? DtRegJc { get => dtRegJc; set => dtRegJc = value; }
        [Column("cap-reg")]
        public double CapReg { get => capReg; set => capReg = value; }
        [Column("socios")]
        public string Socios { get => socios; set => socios = value; }
        [Column("resp-compras")]
        public string RespCompras { get => respCompras; set => respCompras = value; }
        [Column("dados-banco")]
        public string DadosBanco { get => dadosBanco; set => dadosBanco = value; }
        [Column("bens")]
        public string Bens { get => bens; set => bens = value; }
        [Column("end-bol-fisico")]
        public string EndBolFisico { get => endBolFisico; set => endBolFisico = value; }
        [Column("end-bol-dig")]
        public string EndBolDig { get => endBolDig; set => endBolDig = value; }
        [Column("lim-credito")]
        public double LimCredito { get => limCredito; set => limCredito = value; }
        [Column("par-financeiro")]
        public string ParFinanceiro { get => parFinanceiro; set => parFinanceiro = value; }
        [Column("par-comercial")]
        public string ParComercial { get => parComercial; set => parComercial = value; }
        [Column("cod-emitente")]
        public int CodEmitente { get => codEmitente; set => codEmitente = value; }
        [Column("cod-status")]
        public int CodStatus { get => codStatus; set => codStatus = value; }
        [Column("atividade")]
        public string Atividade { get => atividade; set => atividade = value; }
        [Column("zfm")]
        public bool Zfm { get => zfm; set => zfm = value; }
        [Column("segmento")]
        public string Segmento { get => segmento; set => segmento = value; }
    }
}
