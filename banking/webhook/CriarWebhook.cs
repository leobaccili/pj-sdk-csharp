using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class CriarWebhook {
		public void Criar(Config config, string webhookUrl) {
			InterSdk.LogInfo("CriarWebhook banking {0} {1}", config.ClientId, webhookUrl);
			string url = Constants.URL_BANKING_WEBHOOK.Replace("AMBIENTE", config.Ambiente) + "/pix-pagamento";
			CriarWebhookRequest request = CriarWebhookRequest.Builder()
				.SetWebhookUrl(webhookUrl)
				.Build();
			string json = SdkUtils.Serialize(request);
			HttpUtils.CallPut(config, url, Constants.ESCOPO_WEBHOOK_BANKING_WRITE, "Erro ao criar webhook", json);
		}

	}
}
