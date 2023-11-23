using System.Collections.Generic;
using Sdk.BankingApi;

namespace Sdk {
	public class BankingSdk {
		private Config config;

		public BankingSdk(Config config) {
			this.config = config;
		}

		// 
		//  Consulta o extrato por um período específico. O período máximo entre as datas é de 90 dias.
		// 
		//  @param dataInicial Data início da consulta de extrato. Formato: YYYY-MM-DD.
		//  @param dataFinal   Data fim da consulta de extrato. Formato: YYYY-MM-DD.
		//  @return lista de transações
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/extrato-1">Consultar extrato</a>
		//      
		public Extrato ConsultarExtrato(string dataInicial, string dataFinal) {
			return new ConsultarExtrato().Consultar(config, dataInicial, dataFinal);
		}

		// 
		//  Recupera o extrato em pdf por um período específico. O período máximo entre as datas é de 90 dias.
		// 
		//  @param dataInicial Data inicio da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param dataFinal   Data fim da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param arquivo     Arquivo PDF que será gravado.
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/extratoexport">Recuperar extrato em PDF</a>
		//      
		public void RecuperarExtratoPdf(string dataInicial, string dataFinal, string arquivo) {
			new RecuperarExtratoPdf().Recuperar(config, dataInicial, dataFinal, arquivo);
		}

		// 
		//  Consulta extrato enriquecido num intervalo de datas com os filtros especificados
		// 
		//  @param dataInicial data inicial para consulta. Formato: YYYY-MM-DD.
		//  @param dataFinal   data final para consulta. Formato: YYYY-MM-DD.
		//  @param filtro      filtros para consulta(opcional, pode ser null)
		//  @return lista de transações enriquecidas
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/extratocomplete">Consultar extrato enriquecido</a>
		//      
		public List<TransacaoEnriquecida> ConsultarExtratoEnriquecido(string dataInicial, string dataFinal, FiltroConsultarExtratoEnriquecido filtro) {
			return new ConsultarExtratoEnriquecido().Consultar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Consulta extrato enriquecido com informações detalhadas de cada transação dado um período específico. O período máximo entre as datas é de 90 dias.
		// 
		//  @param dataInicial Data início da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param dataFinal   Data fim da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @param pagina      Número da página iniciando com 0.
		//  @return lista de transações enriquecidas
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/extratocomplete-1">Consultar extrato enriquecido</a>
		//      
		public ExtratoEnriquecido ConsultarExtratoEnriquecido(string dataInicial, string dataFinal, FiltroConsultarExtratoEnriquecido filtro, int pagina) {
			return new ConsultarExtratoEnriquecido().Consultar(config, dataInicial, dataFinal, pagina, 0, filtro);
		}

		// 
		//  Consulta extrato enriquecido com informações detalhadas de cada transação dado um período específico. O período máximo entre as datas é de 90 dias.
		// 
		//  @param dataInicial   Data início da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param dataFinal     Data fim da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param filtro        Filtros para consulta(opcional, pode ser null).
		//  @param pagina        Número da página iniciando com 0.
		//  @param tamanhoPagina Tamanho da páfina, padrão = 50.
		//  @return lista de transações enriquecidas
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/extratocomplete-1">Consultar extrato enriquecido</a>
		//      
		public ExtratoEnriquecido ConsultarExtratoEnriquecido(string dataInicial, string dataFinal, FiltroConsultarExtratoEnriquecido filtro, int pagina, int tamanhoPagina) {
			return new ConsultarExtratoEnriquecido().Consultar(config, dataInicial, dataFinal, pagina, tamanhoPagina, filtro);
		}

		// 
		//  Consulta o saldo atual.
		// 
		//  @return objeto com os saldos atuais da conta
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/saldo-3">Consultar saldo</a>
		//      
		public Saldo ConsultarSaldo() {
			return ConsultarSaldo(null);
		}

		// 
		//  Consulta o saldo por um período específico.
		// 
		//  @param dataSaldo Data de consulta para o saldo posicional. Formato: YYYY-MM-DD.
		//  @return objeto com os saldos da conta na data especificada
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/saldo-1">Consultar saldo</a>
		//      
		public Saldo ConsultarSaldo(string dataSaldo) {
			return new ConsultarSaldo().Consultar(config, dataSaldo);
		}

		// 
		//  Método para inclusão de um pagamento imediato ou agendamento do pagamento de boleto, convênio ou tributo com código de barras.
		// 
		//  @param pagamento Dados do pagamento
		//  @return objeto com quantidadeAprovadores, statusPagamento, codigoTransacao...
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pagarboleto">Incluir pagamento com código de barras</a>
		//      
		public RespostaIncluirPagamento IncluirPagamento(PagamentoBoleto pagamento) {
			return new IncluirPagamento().Incluir(config, pagamento);
		}

		// 
		//  Busca informações de pagamentos de boleto.
		// 
		//  @param dataInicial Data inicio, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal   Data Fim, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @return lista de pagamentos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/buscarinformacoespagamentos">Buscar pagamentos</a>
		//      
		public List<Pagamento> BuscarPagamentos(string dataInicial, string dataFinal, FiltroBuscarPagamentos filtro) {
			return new BuscarPagamentos().Buscar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Método para inclusão de um pagamento imediato de DARF sem código de barras.
		// 
		//  @param pagamento Dados do pagamento
		//  @return objeto com autenticacao, nroOperacao, tipoRetorno, codigoTransacao...
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pagamentosdarf-1">Incluir pagamento de DARF</a>
		//      
		public RespostaIncluirPagamentoDarf IncluirPagamentoDarf(PagamentoDarf pagamento) {
			return new IncluirPagamentoDarf().Incluir(config, pagamento);
		}

		// 
		//  Busca informações de pagamento de DARF.
		// 
		//  @param dataInicial Data inicio, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal   Data Fim, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @return lista de pagamentos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/buscarinformacoespagamentodarf">Buscar pagamentos de DARF</a>
		//      
		public List<RetornoPagamentoDarf> BuscarPagamentosDarf(string dataInicial, string dataFinal, FiltroBuscarPagamentosDarf filtro) {
			return new BuscarPagamentosDarf().Buscar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Inclusão de um lote de pagamentos digitados pelo cliente
		// 
		//  @param meuIdentificador Identificador do lote para o cliente.
		//  @param pagamentos       Pagamentos a serem efetuados.
		//  @return informações do processamento do lote
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pagamentoslote">Incluir pagamentos em lote</a>
		//      
		public RespostaIncluirPagamentosLote IncluirPagamentosLote(string meuIdentificador, List<ItemLote> pagamentos) {
			return new IncluirPagamentosLote().Incluir(config, meuIdentificador, pagamentos);
		}

		// 
		//  Inclusão de um lote de pagamentos digitados pelo cliente
		// 
		//  @param idLote Identificador do lote.
		//  @return informações do processamento do lote
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/buscarinformacoespagamentolote">Buscar lote de pagamentos</a>
		//      
		public ProcessamentoLote BuscarLotePagamentos(string idLote) {
			return new BuscarLotePagamentos().Buscar(config, idLote);
		}

		// 
		//  Método para inclusão de um pagamento/transferência Pix utilizando dados bancários ou chave.
		// 
		//  @param pix Dados do pix
		//  @return objeto com endToEndId...
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/realizarpagamentopix-1">Incluir Pix</a>
		//      
		public RespostaIncluirPix IncluirPix(Pix pix) {
			return new IncluirPix().Incluir(config, pix);
		}

		// 
		//  Método destinado a criar um webhook para receber notificações de confirmação de envio de pix (callbacks).
		// 
		//  @param webhookUrl
		//  @see <a href="https://developers.inter.co/references/criar-webhook">Criar webhook</a>
		//      
		public void CriarWebhook(string webhookUrl) {
			new CriarWebhook().Criar(config, webhookUrl);
		}

		// 
		//  Obter webhook cadastrado
		// 
		//  @return webhook
		//  @see <a href="https://developers.inter.co/references/obter-webhook-cadastrado">Obter webhook cadastrado</a>
		//      
		public Webhook ObterWebhook() {
			return new ObterWebhook().Obter(config);
		}

		// 
		//  Exclui o webhook
		// 
		//  @see <a href="https://developers.inter.co/references/excluir-webhook">Excluir webhook</a>
		//      
		public void ExcluirWebhook() {
			new ExcluirWebhook().Excluir(config);
		}

		public List<Callback> ConsultarCallbacks(string tipo, string dataHoraInicio, string dataHoraFim, FiltroBuscarCallbacks filtro) {
			return new ConsultarCallbacks().Buscar(config, tipo, dataHoraInicio, dataHoraFim, filtro);
		}

		public PaginaCallbacks ConsultarCallbacks(string tipo, string dataHoraInicio, string dataHoraFim, int tamanhoPagina, int pagina, FiltroBuscarCallbacks filtro) {
			return new ConsultarCallbacks().Buscar(config, tipo, dataHoraInicio, dataHoraFim, pagina, tamanhoPagina, filtro);
		}

		// 
		//  Método para o cancelamento da agendamento
		// 
		//  @param codigoTransacao
		//  @see <a href="https://developers.inter.co/references/cancelar-agendamento-do-pagamento">Cancelar Agendamento do pagamento</a>
		//      
		public void CancelarAgendamento(string codigoTransacao) {
			new CancelaAgendamentoPagamento().Cancelar(config, codigoTransacao);
		}

	}
}
