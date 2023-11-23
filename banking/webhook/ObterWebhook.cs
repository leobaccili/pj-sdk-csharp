using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class ObterWebhook {
		public Webhook Obter(Config config) {
			InterSdk.LogInfo("ObterWebhook banking {0}", config.ClientId);
			string url = Constants.URL_BANKING_WEBHOOK.Replace("AMBIENTE", config.Ambiente) + "/pix-pagamento";
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_WEBHOOK_BANKING_READ, "Erro ao obter webhook");
			return (Webhook) SdkUtils.Deserialize(typeof(Webhook), json);
		}

	}
}
