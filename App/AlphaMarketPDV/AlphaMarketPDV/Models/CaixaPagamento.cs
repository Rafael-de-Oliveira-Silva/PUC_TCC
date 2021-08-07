﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AlphaMarketPDV.Models
{
    public class CaixaPagamento
    {
        public int Id { get; set; }
        public int NrSeq { get; set; }
        public double ValorPago { get; set; }
        public double ValoTroco { get; set; }
        public Caixa Caixa { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public CaixaPagamento() 
        { 
        }

        public CaixaPagamento(int id, int nrSeq, double valorPago, double valoTroco, 
                              Caixa caixa, FormaPagamento formaPagamento)
        {
            this.Id = id;
            this.NrSeq = nrSeq;
            this.ValorPago = valorPago;
            this.ValoTroco = valoTroco;
            this.Caixa = caixa;
            this.FormaPagamento = formaPagamento;
        }
    }
}