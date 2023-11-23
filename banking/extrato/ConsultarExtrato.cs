using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class ConsultarExtrato {
		public Extrato Consultar(Config config, string dataInicial, string dataFinal) {
			InterSdk.LogInfo("ConsultarExtrato {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			string url = Constants.URL_BANKING_EXTRATO.Replace("AMBIENTE", config.Ambiente) + "?dataInicio=" + dataInicial + "&dataFim=" + dataFinal;
			InterSdk.LogInfo("URL: {0}", url);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_EXTRATO_READ, "Erro ao consultar extrato");
			InterSdk.LogInfo("Json {0}", json);
			return (Extrato) SdkUtils.Deserialize(typeof(Extrato), json);
		}

	}
}
