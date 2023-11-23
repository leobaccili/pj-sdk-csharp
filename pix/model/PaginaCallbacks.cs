using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class PaginaCallbacks {
		// 
		//  Quantidade total de páginas disponíveis para consulta.
		//      
		[DataMember(Name="totalPaginas", EmitDefaultValue = false)]
		public int TotalPaginas;
		// 
		//  Quantidade total de itens disponíveis de acordo com os parâmetros informados.
		//      
		[DataMember(Name="totalElementos", EmitDefaultValue = false)]
		public int TotalElementos;
		// 
		//  Última página
		//      
		[DataMember(Name="ultimaPagina", EmitDefaultValue = false)]
		public bool UltimaPagina;
		// 
		//  Primeira página
		//      
		[DataMember(Name="primeiraPagina", EmitDefaultValue = false)]
		public bool PrimeiraPagina;
		[DataMember(Name="data", EmitDefaultValue = false)]
		public List<Callback> Callbacks;

		public static PaginaCallbacks Builder() {
			return new PaginaCallbacks();
		}

		public PaginaCallbacks Build() {
			return this;
		}

		public PaginaCallbacks SetTotalPaginas(int totalPaginas) {
			this.TotalPaginas = totalPaginas;
			return this;
		}

		public PaginaCallbacks SetTotalElementos(int totalElementos) {
			this.TotalElementos = totalElementos;
			return this;
		}

		public PaginaCallbacks SetUltimaPagina(bool ultimaPagina) {
			this.UltimaPagina = ultimaPagina;
			return this;
		}

		public PaginaCallbacks SetPrimeiraPagina(bool primeiraPagina) {
			this.PrimeiraPagina = primeiraPagina;
			return this;
		}

		public PaginaCallbacks SetCallbacks(List<Callback> callbacks) {
			this.Callbacks = callbacks;
			return this;
		}
	}
}
