using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class Callback {
		[DataMember(Name="webhookUrl", EmitDefaultValue = false)]
		public string WebhookUrl;
		[DataMember(Name="payload", EmitDefaultValue = false)]
		public Object Payload;
		[DataMember(Name="numeroTentativa", EmitDefaultValue = false)]
		public int NumeroTentativa;
		[DataMember(Name="sucesso", EmitDefaultValue = false)]
		public bool Sucesso;
		[DataMember(Name="httpStatus", EmitDefaultValue = false)]
		public int HttpStatus;
		[DataMember(Name="mensagemErro", EmitDefaultValue = false)]
		public string MensagemErro;
		[DataMember(Name="dataHoraDisparo", EmitDefaultValue = false)]
		public string DataHoraDisparo;

		public static Callback Builder() {
			return new Callback();
		}

		public Callback Build() {
			return this;
		}

		public Callback SetWebhookUrl(string webhookUrl) {
			this.WebhookUrl = webhookUrl;
			return this;
		}

		public Callback SetPayload(Object payload) {
			this.Payload = payload;
			return this;
		}

		public Callback SetNumeroTentativa(int numeroTentativa) {
			this.NumeroTentativa = numeroTentativa;
			return this;
		}

		public Callback SetSucesso(bool sucesso) {
			this.Sucesso = sucesso;
			return this;
		}

		public Callback SetHttpStatus(int httpStatus) {
			this.HttpStatus = httpStatus;
			return this;
		}

		public Callback SetMensagemErro(string mensagemErro) {
			this.MensagemErro = mensagemErro;
			return this;
		}

		public Callback SetDataHoraDisparo(string dataHoraDisparo) {
			this.DataHoraDisparo = dataHoraDisparo;
			return this;
		}
	}
}
