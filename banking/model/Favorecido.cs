using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class Favorecido : Destinatario {
		// 
		//  Id do favorecido
		//      
		[DataMember(Name="id", EmitDefaultValue = false)]
		public string Id;
		// 
		//  Nome do favorecido
		//  <p>REQUERIDO</p>
		//      
		[DataMember(Name="nome", EmitDefaultValue = false)]
		public string Nome;
		// 
		//  CPF/CNPJ do favorecido
		//      
		[DataMember(Name="cpfCnpj", EmitDefaultValue = false)]
		public string CpfCnpj;
		// 
		//  REQUERIDO
		//      
		[DataMember(Name="instituicaoFinanceira", EmitDefaultValue = false)]
		public InstituicaoFinanceira InstituicaoFinanceira;
		// 
		//  Código da agência
		//  <p>REQUERIDO</p>
		//      
		[DataMember(Name="agencia", EmitDefaultValue = false)]
		public string Agencia;
		// 
		//  Número da conta
		//  <p>REQUERIDO</p>
		//      
		[DataMember(Name="conta", EmitDefaultValue = false)]
		public string Conta;
		// 
		//  Email do favorecido
		//      
		[DataMember(Name="email", EmitDefaultValue = false)]
		public string Email;
		// 
		//  Descricao para o favorecido
		//      
		[DataMember(Name="descricao", EmitDefaultValue = false)]
		public string Descricao;

		public static Favorecido Builder() {
			return new Favorecido();
		}

		public Favorecido Build() {
			return this;
		}

		public Favorecido SetId(string id) {
			this.Id = id;
			return this;
		}

		public Favorecido SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public Favorecido SetCpfCnpj(string cpfCnpj) {
			this.CpfCnpj = cpfCnpj;
			return this;
		}

		public Favorecido SetInstituicaoFinanceira(InstituicaoFinanceira instituicaoFinanceira) {
			this.InstituicaoFinanceira = instituicaoFinanceira;
			return this;
		}

		public Favorecido SetAgencia(string agencia) {
			this.Agencia = agencia;
			return this;
		}

		public Favorecido SetConta(string conta) {
			this.Conta = conta;
			return this;
		}

		public Favorecido SetEmail(string email) {
			this.Email = email;
			return this;
		}

		public Favorecido SetDescricao(string descricao) {
			this.Descricao = descricao;
			return this;
		}
	}
}
