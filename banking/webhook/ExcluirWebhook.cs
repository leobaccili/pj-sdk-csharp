using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class ExcluirWebhook {
		public void Excluir(Config config) {
			InterSdk.LogInfo("ExcluirWebhook banking {0}", config.ClientId);
			string url = Constants.URL_BANKING_WEBHOOK.Replace("AMBIENTE", config.Ambiente) + "/pix-pagamento";
			HttpUtils.CallDelete(config, url, Constants.ESCOPO_WEBHOOK_BANKING_WRITE, "Erro ao excluir webhook");
		}

	}
}
