using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class RespostaIncluirTed {
		[DataMember(Name="titulo", EmitDefaultValue = false)]
		public string Titulo;
		[DataMember(Name="mensagem", EmitDefaultValue = false)]
		public string Mensagem;
		[DataMember(Name="aguardandoAprovacao", EmitDefaultValue = false)]
		public bool AguardandoAprovacao;
		[DataMember(Name="quantidadeAprovadores", EmitDefaultValue = false)]
		public int QuantidadeAprovadores;
		[DataMember(Name="codigoTransacao", EmitDefaultValue = false)]
		public string CodigoTransacao;

		public static RespostaIncluirTed Builder() {
			return new RespostaIncluirTed();
		}

		public RespostaIncluirTed Build() {
			return this;
		}

		public RespostaIncluirTed SetTitulo(string titulo) {
			this.Titulo = titulo;
			return this;
		}

		public RespostaIncluirTed SetMensagem(string mensagem) {
			this.Mensagem = mensagem;
			return this;
		}

		public RespostaIncluirTed SetAguardandoAprovacao(bool aguardandoAprovacao) {
			this.AguardandoAprovacao = aguardandoAprovacao;
			return this;
		}

		public RespostaIncluirTed SetQuantidadeAprovadores(int quantidadeAprovadores) {
			this.QuantidadeAprovadores = quantidadeAprovadores;
			return this;
		}

		public RespostaIncluirTed SetCodigoTransacao(string codigoTransacao) {
			this.CodigoTransacao = codigoTransacao;
			return this;
		}
	}
}
