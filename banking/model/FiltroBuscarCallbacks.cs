using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class FiltroBuscarCallbacks {
		[DataMember(Name="endToEnd", EmitDefaultValue = false)]
		public string EndToEnd;

		public static FiltroBuscarCallbacks Builder() {
			return new FiltroBuscarCallbacks();
		}

		public FiltroBuscarCallbacks Build() {
			return this;
		}

		public FiltroBuscarCallbacks SetEndToEnd(string endToEnd) {
			this.EndToEnd = endToEnd;
			return this;
		}

		public string ObterFiltroQuery() {
			string filter = "";
			if (EndToEnd != null) {
				filter = filter + "&endToEnd=" + EndToEnd;
			}
			return filter;
		}
	}
}
