using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPesquisaClinica.Domain.Entity.Forms
{
   public class Dia
    {
        public int DiaId { get; set; }
        public DateTime? dt_d { get; set; }
        public int? catur_d { get; set; }
        public int? vm_d { get; set; }
        public int? cvc_d { get; set; }
        public string atb_d { get; set; }
        public int? qatb_d { get; set; }
        public int? atbc1_d { get; set; }
        public string qatbc1_d { get; set; }
        public int? atbc2_d { get; set; }
        public string qatbc2_d { get; set; }
        public int? atbc3_d { get; set; }
        public string qatbc3_d { get; set; }
        public int? atbc4_d { get; set; }
        public string qatbc4_d { get; set; }
        public int? atbc5_d { get; set; }
        public string qatbc5_d { get; set; }
        public int? atbc6_d { get; set; }
        public string qatbc6_d { get; set; }
        public int? atbc7_d { get; set; }
        public string qatbc7_d { get; set; }
        public int? atbc8_d { get; set; }
        public string qatbc8_d { get; set; }
        public int? sofaresp_d { get; set; }
        public int? sofacoag_d { get; set; }
        public int? sofahep_d { get; set; }
        public int? sofacard_d { get; set; }
        public int? sofasnc_d { get; set; }
        public int? sofaren_d { get; set; }
        public string sofa_d { get; set; }

        public int seqdia { get; set; }
        public int ParticipacaoId { get; set; }
        public int Status { get; set; }
        public int CadeadoId { get; set; }
        public DateTime dataAlteracao { get; set; }
        public int user { get; set; }
        public string statPree { get; set; }
    }
}
