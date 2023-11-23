using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class ExtratoEnriquecido {
		[DataMember(Name="totalPaginas", EmitDefaultValue = false)]
		public int TotalPaginas;
		[DataMember(Name="totalElementos", EmitDefaultValue = false)]
		public int TotalElementos;
		[DataMember(Name="ultimaPagina", EmitDefaultValue = false)]
		public bool UltimaPagina;
		[DataMember(Name="primeiraPagina", EmitDefaultValue = false)]
		public bool PrimeiraPagina;
		[DataMember(Name="tamanhoPagina", EmitDefaultValue = false)]
		public int TamanhoPagina;
		[DataMember(Name="numeroDeElementos", EmitDefaultValue = false)]
		public int NumeroDeElementos;
		[DataMember(Name="transacoes", EmitDefaultValue = false)]
		public List<TransacaoEnriquecida> Transacoes;

		public static ExtratoEnriquecido Builder() {
			return new ExtratoEnriquecido();
		}

		public ExtratoEnriquecido Build() {
			return this;
		}

		public ExtratoEnriquecido SetTotalPaginas(int totalPaginas) {
			this.TotalPaginas = totalPaginas;
			return this;
		}

		public ExtratoEnriquecido SetTotalElementos(int totalElementos) {
			this.TotalElementos = totalElementos;
			return this;
		}

		public ExtratoEnriquecido SetUltimaPagina(bool ultimaPagina) {
			this.UltimaPagina = ultimaPagina;
			return this;
		}

		public ExtratoEnriquecido SetPrimeiraPagina(bool primeiraPagina) {
			this.PrimeiraPagina = primeiraPagina;
			return this;
		}

		public ExtratoEnriquecido SetTamanhoPagina(int tamanhoPagina) {
			this.TamanhoPagina = tamanhoPagina;
			return this;
		}

		public ExtratoEnriquecido SetNumeroDeElementos(int numeroDeElementos) {
			this.NumeroDeElementos = numeroDeElementos;
			return this;
		}

		public ExtratoEnriquecido SetTransacoes(List<TransacaoEnriquecida> transacoes) {
			this.Transacoes = transacoes;
			return this;
		}
	}
}
