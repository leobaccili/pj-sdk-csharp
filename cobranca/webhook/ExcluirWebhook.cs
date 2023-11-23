using System.Text;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	public class ExcluirWebhook {
		public void Excluir(Config config) {
			InterSdk.LogInfo("ExcluirWebhook cobrança {0}", config.ClientId);
			string url = Constants.URL_COBRANCA_WEBHOOK_COBRANCA.Replace("AMBIENTE", config.Ambiente);
			HttpUtils.CallDelete(config, url, Constants.ESCOPO_BOLETO_COBRANCA_WRITE, "Erro ao excluir webhook");
		}

	}
}
