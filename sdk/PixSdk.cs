using System.Collections.Generic;
using Sdk.PixApi;

namespace Sdk {
	public class PixSdk {
		private Config config;

		public PixSdk(Config config) {
			this.config = config;
		}

		// 
		//  Crio uma cobrança imediata.
		// 
		//  @param cobranca Cobrança a ser criada
		//  @return cobranaa Cobrança que foi criada
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-Imediata/paths/~1cob~1%7Btxid%7D/put">Criar cobrança imediata</a>
		//      
		public CobrancaDetalhada CriarCobrancaImediataTxId(Cobranca cobranca) {
			return new CriarCobrancaImediata().Criar(config, cobranca);
		}

		// 
		//  Revisa uma cobrança imediata.
		// 
		//  @param cobranca Cobrança a ser criada
		//  @return cobranaa Cobrança que foi criada
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-Imediata/paths/~1cob~1%7Btxid%7D/patch">Revisar cobrança imediata</a>
		//      
		public CobrancaDetalhada RevisarCobrancaImediata(Cobranca cobranca) {
			return new RevisarCobrancaImediata().Revisar(config, cobranca);
		}

		// 
		//  Consulta uma cobrança através de um determinado txid.
		//  @param txId  identificador da cobrança
		//  @return cobrança
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-Imediata/paths/~1cob~1%7Btxid%7D/get">Consultar cobrança imediata</a>
		//      
		public CobrancaDetalhada ConsultarCobrancaImediata(string txId) {
			return new ConsultarCobrancaImediata().Consultar(config, txId);
		}

		// 
		//  Crio uma cobrança imediata. O txid será definido pelo PSP.
		// 
		//  @param cobranca Cobrança a ser criada
		//  @return cobranaa Cobrança que foi criada
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-Imediata/paths/~1cob/post">Criar cobrança imediata</a>
		//      
		public CobrancaDetalhada CriarCobrancaImediata(Cobranca cobranca) {
			return new CriarCobrancaImediata().Criar(config, cobranca);
		}

		// 
		//  Consulta cobranças imediatas através de parâmetros como início, fim, cpf, cnpj e status.
		// 
		//  @param dataInicial Filtra os registros cuja data de criação seja maior ou igual que a data de início. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param dataFinal   Filtra os registros cuja data de criação seja menor ou igual que a data de fim. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @return lista de cobranças
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-Imediata/paths/~1cob/get">Consultar lista de cobranças imediatas</a>
		//      
		public List<CobrancaDetalhada> ConsultarCobrancasImediatas(string dataInicial, string dataFinal, FiltroConsultarCobrancasImediatas filtro) {
			return new ConsultarCobrancasImediatas().Consultar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Consulta cobranças imediatas através de parâmetros como início, fim, cpf, cnpj e status, com paginação.
		// 
		//  @param dataInicial Filtra os registros cuja data de criação seja maior ou igual que a data de início. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param dataFinal   Filtra os registros cuja data de criação seja menor ou igual que a data de fim. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @param pagina      Número da página iniciando com 0.
		//  @return página com lista de cobranças
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-Imediata/paths/~1cob/get">Consultar lista de cobranças imediatas</a>
		//      
		public PaginaCobrancas ConsultarCobrancasImediatas(string dataInicial, string dataFinal, FiltroConsultarCobrancasImediatas filtro, int pagina) {
			return new ConsultarCobrancasImediatas().Consultar(config, dataInicial, dataFinal, pagina, 0, filtro);
		}

		// 
		//  Consulta cobranças imediatas através de parâmetros como início, fim, cpf, cnpj e status, com paginação.
		// 
		//  @param dataInicial   Filtra os registros cuja data de criação seja maior ou igual que a data de início. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param dataFinal     Filtra os registros cuja data de criação seja menor ou igual que a data de fim. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param filtro        Filtros para consulta(opcional, pode ser null).
		//  @param pagina        Número da página iniciando com 0.
		//  @param tamanhoPagina Tamanho da páfina, padrão = 50.
		//  @return página com lista de cobranças
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-Imediata/paths/~1cob/get">Consultar lista de cobranças imediatas</a>
		//      
		public PaginaCobrancas ConsultarCobrancasImediatas(string dataInicial, string dataFinal, FiltroConsultarCobrancasImediatas filtro, int pagina, int tamanhoPagina) {
			return new ConsultarCobrancasImediatas().Consultar(config, dataInicial, dataFinal, pagina, tamanhoPagina, filtro);
		}

		// 
		//  Cria uma cobrança com vencimento
		// 
		//  @param cobranca Cobrança a ser criada
		//  @return cobranca Cobrança que foi criada
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-com-Vencimento/paths/~1cobv~1%7Btxid%7D/put">Criar cobrança com vencimento</a>
		//      
		public CobrancaVencimentoDetalhada CriarCobrancaComVencimentoTxId(string txid, CobrancaVencimento cobranca) {
			return new CriarCobrancaComVencimento().Criar(config, txid, cobranca);
		}

		// 
		//  Revisa uma cobrança com Vencimento.
		// 
		//  @param cobranca Cobrança a ser criada
		//  @return cobranaa Cobrança que foi criada
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-com-Vencimento/paths/~1cobv~1%7Btxid%7D/patch">Revisar cobrança imediata</a>
		//      
		public CobrancaVencimentoDetalhada RevisarCobrancaComVencimento(string txid, CobrancaVencimento cobranca) {
			return new RevisarCobrancaComVencimento().Revisar(config, txid, cobranca);
		}

		// 
		//  Consulta uma cobrança com vencimento através de um determinado txid.
		//  @param txId  identificador da cobrança
		//  @return cobrança
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-com-Vencimento/paths/~1cobv~1%7Btxid%7D/get">Consultar cobrança imediata</a>
		//      
		public CobrancaVencimentoDetalhada ConsultarCobrancaComVencimento(string txId) {
			return new ConsultarCobrancaComVencimento().Consultar(config, txId);
		}

		// 
		//  Consulta cobranças com vencimento através de parâmetros como início, fim, cpf, cnpj e status.
		// 
		//  @param dataInicial Filtra os registros cuja data de criação seja maior ou igual que a data de início. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param dataFinal   Filtra os registros cuja data de criação seja menor ou igual que a data de fim. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @return lista de cobranças
		//  @see <a href="https://developers.inter.co/references/pix#tag/Cobranca-com-Vencimento/paths/~1cobv/get">Consultar lista de cobranças imediatas</a>
		//      
		public List<CobrancaVencimentoDetalhada> ConsultarCobrancasComVencimento(string dataInicial, string dataFinal, FiltroConsultarCobrancasComVencimento filtro) {
			return new ConsultarCobrancasComVencimento().Consultar(config, dataInicial, dataFinal, filtro);
		}

		public PaginaCobrancasVencimento ConsultarCobrancasComVencimento(string dataInicial, string dataFinal, FiltroConsultarCobrancasComVencimento filtro, int pagina) {
			return new ConsultarCobrancasComVencimento().Consultar(config, dataInicial, dataFinal, pagina, 0, filtro);
		}

		public PaginaCobrancasVencimento ConsultarCobrancasComVencimento(string dataInicial, string dataFinal, FiltroConsultarCobrancasComVencimento filtro, int pagina, int tamanhoPagina) {
			return new ConsultarCobrancasComVencimento().Consultar(config, dataInicial, dataFinal, pagina, tamanhoPagina, filtro);
		}

		// 
		//  Cria location do payload
		// 
		//  @param tipoCob cov|cobv
		//  @return dados da location
		//  @see <a href="https://developers.inter.co/references/pix#tag/Location/paths/~1loc/post">Criar location do payload</a>
		//      
		public Location CriarLocation(string tipoCob) {
			return new CriarLocation().Criar(config, tipoCob);
		}

		// 
		//  Consulta locations cadastradas.
		// 
		//  @param dataInicial Filtra os registros cuja data de criação seja maior ou igual que a data de início. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param dataFinal   Filtra os registros cuja data de criação seja menor ou igual que a data de fim. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @return lista de locations
		//  @see <a href="https://developers.inter.co/references/pix#tag/Location/paths/~1loc/get">Consultar locations cadastradas</a>
		//      
		public List<Location> ConsultarLocationsCadastradas(string dataInicial, string dataFinal, FiltroConsultarLocations filtro) {
			return new ConsultarLocationsCadastradas().Consultar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Consulta locations cadastradas.
		// 
		//  @param dataInicial Filtra os registros cuja data de criação seja maior ou igual que a data de início. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param dataFinal   Filtra os registros cuja data de criação seja menor ou igual que a data de fim. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @param pagina      Número da página iniciando com 0.
		//  @return página com lista de locations
		//  @see <a href="https://developers.inter.co/references/pix#tag/Location/paths/~1loc/get">Consultar locations cadastradas</a>
		//      
		public PaginaLocations ConsultarLocationsCadastradas(string dataInicial, string dataFinal, FiltroConsultarLocations filtro, int pagina) {
			return new ConsultarLocationsCadastradas().Consultar(config, dataInicial, dataFinal, pagina, 0, filtro);
		}

		// 
		//  Consulta locations cadastradas.
		// 
		//  @param dataInicial   Filtra os registros cuja data de criação seja maior ou igual que a data de início. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param dataFinal     Filtra os registros cuja data de criação seja menor ou igual que a data de fim. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param filtro        Filtros para consulta(opcional, pode ser null).
		//  @param pagina        Número da página iniciando com 0.
		//  @param tamanhoPagina Tamanho da páfina, padrão = 100.
		//  @return página com lista de locations
		//  @see <a href="https://developers.inter.co/references/pix#tag/Location/paths/~1loc/get">Consultar locations cadastradas</a>
		//      
		public PaginaLocations ConsultarLocationsCadastradas(string dataInicial, string dataFinal, FiltroConsultarLocations filtro, int pagina, int tamanhoPagina) {
			return new ConsultarLocationsCadastradas().Consultar(config, dataInicial, dataFinal, pagina, tamanhoPagina, filtro);
		}

		// 
		//  Recupera a location do payload.
		// 
		//  @param id identificador da location
		//  @return location
		//  @see <a href="https://developers.inter.co/references/pix#tag/Location/paths/~1loc~1%7Bid%7D/get">Recuperar location do payload</a>
		//      
		public Location RecuperarLocation(string id) {
			return new RecuperarLocation().Recuperar(config, id);
		}

		// 
		//  Endpoint utilizado para desvincular uma cobrança de uma location.
		//  <p>Se executado com sucesso, a entidade loc não apresentará mais um txid,
		//  se apresentava anteriormente à chamada. Adicionalmente, a entidade cob ou cobv associada ao
		//  txid desvinculado também passará a não mais apresentar um location. Esta operação
		//  não altera o status da cob ou cobv em questão.</p>
		// 
		//  @param id identificador da location
		//  @return cobrança representada pelo txid informado desvinculada com sucesso.
		//  @see <a href="https://developers.inter.co/references/pix#tag/Location/paths/~1loc~1%7Bid%7D~1txid/delete">Desvincular uma cobrança de uma location</a>
		//      
		public Location DesvincularLocation(string id) {
			return new DesvincularLocation().Desvincular(config, id);
		}

		// 
		//  Consulta um pix através de um determinado EndToEndId.
		// 
		//  @param e2eId Id único para identificação do pagamento Pix.
		//  @return pix
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/get_pix-e2eid">Consultar pix</a>
		//      
		public Pix ConsultarPix(string e2eId) {
			return new ConsultarPix().Consultar(config, e2eId);
		}

		// 
		//  Consulta pix por um período específico, de acordo com os parâmetros informados.
		// 
		//  @param dataInicial Filtra os registros cuja data de criação seja maior ou igual que a data de início. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param dataFinal   Filtra os registros cuja data de criação seja menor ou igual que a data de fim. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @return lista de pix recebidos
		//  @see <a href="https://developers.inter.co/references/pix#tag/Pix/paths/~1pix~1%7Be2eId%7D/get">Consultar pix recebidos</a>
		//      
		public List<Pix> ConsultarPixRecebidos(string dataInicial, string dataFinal, FiltroConsultarPixRecebidos filtro) {
			return new ConsultarPixRecebidos().Consultar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Consulta pix por um período específico, de acordo com os parâmetros informados.
		// 
		//  @param dataInicial Filtra os registros cuja data de criação seja maior ou igual que a data de início. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param dataFinal   Filtra os registros cuja data de criação seja menor ou igual que a data de fim. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @param pagina      Número da página iniciando com 0.
		//  @return página com lista de pix recebidos
		//  @see <a href="https://developers.inter.co/references/pix#tag/Pix/paths/~1pix/get">Consultar pix recebidos</a>
		//      
		public PaginaPix ConsultarPixRecebidos(string dataInicial, string dataFinal, FiltroConsultarPixRecebidos filtro, int pagina) {
			return new ConsultarPixRecebidos().Consultar(config, dataInicial, dataFinal, pagina, 0, filtro);
		}

		// 
		//  Consulta pix por um período específico, de acordo com os parâmetros informados.
		// 
		//  @param dataInicial   Filtra os registros cuja data de criação seja maior ou igual que a data de início. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param dataFinal     Filtra os registros cuja data de criação seja menor ou igual que a data de fim. Formato yyyy-MM-ddTHH:mm:ssZ.
		//  @param filtro        Filtros para consulta(opcional, pode ser null).
		//  @param pagina        Número da página iniciando com 0.
		//  @param tamanhoPagina Tamanho da páfina, padrão = 100.
		//  @return página com lista de pix recebidos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/get_pix">Consultar pix recebidos</a>
		//      
		public PaginaPix ConsultarPixRecebidos(string dataInicial, string dataFinal, FiltroConsultarPixRecebidos filtro, int pagina, int tamanhoPagina) {
			return new ConsultarPixRecebidos().Consultar(config, dataInicial, dataFinal, pagina, tamanhoPagina, filtro);
		}

		// 
		//  Solicitauma devolução através de um E2EID do Pix e do ID da devolução.
		// 
		//  @param e2eId     Id único para identificação do pagamento Pix.
		//  @param id        Id gerado pelo cliente para representar unicamente uma devolução.
		//  @param devolucao Dados da devolução.
		//  @return devolução detalhada
		//  @see <a href="https://developers.inter.co/references/pix#tag/Pix/paths/~1pix~1%7Be2eId%7D~1devolucao~1%7Bid%7D/put">Consultar devolução</a>
		//      
		public DevolucaoDetalhada SolicitarDevolucao(string e2eId, string id, Devolucao devolucao) {
			return new SolicitarDevolucao().Solicitar(config, e2eId, id, devolucao);
		}

		// 
		//  Consulta uma devolução através de um E2EID do Pix e do ID da devolução.
		// 
		//  @param e2eId Id único para identificação do pagamento Pix.
		//  @param id    Id gerado pelo cliente para representar unicamente uma devolução.
		//  @return devolução
		//  @see <a href="https://developers.inter.co/references/pix#tag/Pix/paths/~1pix~1%7Be2eId%7D~1devolucao~1%7Bid%7D/get">Consultar devolução</a>
		//      
		public DevolucaoDetalhada ConsultarDevolucao(string e2eId, string id) {
			return new ConsultarDevolucao().Consultar(config, e2eId, id);
		}

		// 
		//  Método destinado a criar um webhook para receber notificações de cobranças Pix recebidas (callbacks).
		// 
		//  @param webhookUrl
		//  @param chave      Chave pix
		//  @see <a href="https://developers.inter.co/references/pix#tag/Webhook/operation/webhookPut">Criar webhook</a>
		//      
		public void CriarWebhook(string webhookUrl, string chave) {
			new CriarWebhook().Criar(config, webhookUrl, chave);
		}

		// 
		//  Obter webhook cadastrado
		// 
		//  @param chave Chave pix
		//  @return webhook
		//  @see <a href="https://developers.inter.co/references/pix#tag/Webhook/operation/webhookGet">Obter webhook cadastrado</a>
		//      
		public Webhook ObterWebhook(string chave) {
			return new ObterWebhook().Obter(config, chave);
		}

		// 
		//  Exclui o webhook
		// 
		//  @param chave Chave pix
		//  @see <a href="https://developers.inter.co/references/pix#tag/Webhook/operation/webhookDelete">Excluir webhook</a>
		//      
		public void ExcluirWebhook(string chave) {
			new ExcluirWebhook().Excluir(config, chave);
		}

		public PaginaCallbacks ConsultarCallbacks(string dataHoraInicio, string dataHoraFim, int tamanhoPagina, int pagina, FiltroBuscarCallbacks filtro) {
			return new ConsultarCallbacks().Buscar(config, dataHoraInicio, dataHoraFim, pagina, tamanhoPagina, filtro);
		}

		public List<Callback> ConsultarCallbacks(string dataHoraInicio, string dataHoraFim, FiltroBuscarCallbacks filtro) {
			return new ConsultarCallbacks().Buscar(config, dataHoraInicio, dataHoraFim, filtro);
		}

	}
}
