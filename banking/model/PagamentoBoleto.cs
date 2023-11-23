using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class PagamentoBoleto {
		// 
		//  REQUERIDO
		//  Código de barras ou linha digitável.
		//      
		[DataMember(Name="codBarraLinhaDigitavel", EmitDefaultValue = false)]
		public string CodBarraLinhaDigitavel;
		// 
		//  REQUERIDO
		//  Valor a ser pago.
		//      
		[DataMember(Name="valorPagar", EmitDefaultValue = false)]
		public double ValorPagar;
		// 
		//  Data para efetivar o pagamento. Se não informada, o pagamento será feito no mesmo dia.
		//  Formato aceito: YYYY-MM-DD
		//      
		[DataMember(Name="dataPagamento", EmitDefaultValue = false)]
		public string DataPagamento;
		// 
		//  REQUERIDO
		//  Data de vencimento do título.
		//  Formato aceito: YYYY-MM-DD
		//      
		[DataMember(Name="dataVencimento", EmitDefaultValue = false)]
		public string DataVencimento;

		public static PagamentoBoleto Builder() {
			return new PagamentoBoleto();
		}

		public PagamentoBoleto Build() {
			return this;
		}

		public PagamentoBoleto SetCodBarraLinhaDigitavel(string codBarraLinhaDigitavel) {
			this.CodBarraLinhaDigitavel = codBarraLinhaDigitavel;
			return this;
		}

		public PagamentoBoleto SetValorPagar(double valorPagar) {
			this.ValorPagar = valorPagar;
			return this;
		}

		public PagamentoBoleto SetDataPagamento(string dataPagamento) {
			this.DataPagamento = dataPagamento;
			return this;
		}

		public PagamentoBoleto SetDataVencimento(string dataVencimento) {
			this.DataVencimento = dataVencimento;
			return this;
		}
	}
}
