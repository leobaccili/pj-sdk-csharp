using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class PagamentoDarf {
		// 
		//  Campo para informar o cpf ou cnpj do pagador
		//      
		[DataMember(Name="cnpjCpf", EmitDefaultValue = false)]
		public string CnpjCpf;
		// 
		//  Campo para informar o código da receita
		//      
		[DataMember(Name="codigoReceita", EmitDefaultValue = false)]
		public string CodigoReceita;
		// 
		//  Campo para informar a data de vencimento da DARF
		//  <p>Formato aceito: YYYY-MM-DD</p>
		//      
		[DataMember(Name="dataVencimento", EmitDefaultValue = false)]
		public string DataVencimento;
		// 
		//  Campo para informar a descrição
		//      
		[DataMember(Name="descricao", EmitDefaultValue = false)]
		public string Descricao;
		// 
		//  Campo para informar o nome da empresa
		//      
		[DataMember(Name="nomeEmpresa", EmitDefaultValue = false)]
		public string NomeEmpresa;
		// 
		//  Campo para informar o telefone da empresa
		//      
		[DataMember(Name="telefoneEmpresa", EmitDefaultValue = false)]
		public string TelefoneEmpresa;
		// 
		//  Campo para informar o período de apuração da DARF
		//  <p>Formato aceito: YYYY-MM-DD</p>
		//      
		[DataMember(Name="periodoApuracao", EmitDefaultValue = false)]
		public string PeriodoApuracao;
		// 
		//  Campo para informar o valor principal
		//      
		[DataMember(Name="valorPrincipal", EmitDefaultValue = false)]
		public string ValorPrincipal;
		// 
		//  Campo para informar o valor da multa
		//      
		[DataMember(Name="valorMulta", EmitDefaultValue = false)]
		public string ValorMulta;
		// 
		//  Campo para informar o valor do juros
		//      
		[DataMember(Name="valorJuros", EmitDefaultValue = false)]
		public string ValorJuros;
		// 
		//  Campo para informar a referência da DARF
		//      
		[DataMember(Name="referencia", EmitDefaultValue = false)]
		public string Referencia;

		public static PagamentoDarf Builder() {
			return new PagamentoDarf();
		}

		public PagamentoDarf Build() {
			return this;
		}

		public PagamentoDarf SetCnpjCpf(string cnpjCpf) {
			this.CnpjCpf = cnpjCpf;
			return this;
		}

		public PagamentoDarf SetCodigoReceita(string codigoReceita) {
			this.CodigoReceita = codigoReceita;
			return this;
		}

		public PagamentoDarf SetDataVencimento(string dataVencimento) {
			this.DataVencimento = dataVencimento;
			return this;
		}

		public PagamentoDarf SetDescricao(string descricao) {
			this.Descricao = descricao;
			return this;
		}

		public PagamentoDarf SetNomeEmpresa(string nomeEmpresa) {
			this.NomeEmpresa = nomeEmpresa;
			return this;
		}

		public PagamentoDarf SetTelefoneEmpresa(string telefoneEmpresa) {
			this.TelefoneEmpresa = telefoneEmpresa;
			return this;
		}

		public PagamentoDarf SetPeriodoApuracao(string periodoApuracao) {
			this.PeriodoApuracao = periodoApuracao;
			return this;
		}

		public PagamentoDarf SetValorPrincipal(string valorPrincipal) {
			this.ValorPrincipal = valorPrincipal;
			return this;
		}

		public PagamentoDarf SetValorMulta(string valorMulta) {
			this.ValorMulta = valorMulta;
			return this;
		}

		public PagamentoDarf SetValorJuros(string valorJuros) {
			this.ValorJuros = valorJuros;
			return this;
		}

		public PagamentoDarf SetReferencia(string referencia) {
			this.Referencia = referencia;
			return this;
		}
	}
}
