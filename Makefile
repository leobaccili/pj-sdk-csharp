all: inter-sdk-csharp.dll

clean: 
	rm -f inter-sdk-csharp.dll

SDK= \
sdk/BankingSdk.cs \
sdk/HttpUtils.cs \
sdk/SdkException.cs \
sdk/CobrancaSdk.cs \
sdk/InterSdk.cs \
sdk/TokenUtils.cs \
sdk/Constants.cs \
sdk/PixSdk.cs \
sdk/Utils.cs 

MODEL_COBRANCA= \
cobranca/model/Boleto.cs \
cobranca/model/Mora.cs \
cobranca/model/BoletoDetalhado.cs \
cobranca/model/Multa.cs \
cobranca/model/Callback.cs \
cobranca/model/Ordenacao.cs \
cobranca/model/Desconto.cs \
cobranca/model/PaginaBoletos.cs \
cobranca/model/FiltroBaseRecuperarBoletos.cs \
cobranca/model/PaginaCallbacks.cs \
cobranca/model/FiltroBuscarCallbacks.cs \
cobranca/model/Pessoa.cs \
cobranca/model/FiltroRecuperarBoletos.cs \
cobranca/model/RequisicaoCancelarBoleto.cs \
cobranca/model/FiltroRecuperarSumarioBoletos.cs \
cobranca/model/RespostaEmitirBoleto.cs \
cobranca/model/ItemSumario.cs \
cobranca/model/Sumario.cs \
cobranca/model/Mensagem.cs \
cobranca/model/enums/CodigoDesconto.cs \
cobranca/model/enums/CodigoMulta.cs \
cobranca/model/enums/OrdenadoPor.cs \
cobranca/model/enums/TipoDataBoleto.cs \
cobranca/model/enums/TipoPessoa.cs \
cobranca/model/enums/CodigoMora.cs \
cobranca/model/enums/MotivoCancelamento.cs \
cobranca/model/enums/SituacaoBoleto.cs \
cobranca/model/enums/TipoOrdenacao.cs

COBRANCA= \
cobranca/webhook/ExcluirWebhook.cs \
cobranca/webhook/CriarWebhook.cs \
cobranca/webhook/ObterWebhook.cs \
cobranca/webhook/ConsultarCallbacks.cs \
cobranca/boletos/RecuperarBoletos.cs \
cobranca/boletos/CancelarBoleto.cs \
cobranca/boletos/RecuperarBoletoDetalhado.cs \
cobranca/boletos/RecuperarSumarioBoletos.cs \
cobranca/boletos/EmitirBoleto.cs \
cobranca/boletos/RecuperarBoletoPdf.cs

MODEL_BANKING= \
banking/model/RespostaIncluirPagamentosLote.cs \
banking/model/FiltroConsultarExtratoEnriquecido.cs \
banking/model/Saldo.cs \
banking/model/Pix.cs \
banking/model/ItemProcessamentoLote.cs \
banking/model/RespostaIncluirPagamentoDarf.cs \
banking/model/Destinatario.cs \
banking/model/PixDetalhado.cs \
banking/model/Favorecido.cs \
banking/model/Extrato.cs \
banking/model/FiltroBuscarPagamentosDarf.cs \
banking/model/Callback.cs \
banking/model/FiltroBuscarPagamentos.cs \
banking/model/TransacaoEnriquecida.cs \
banking/model/ExtratoEnriquecido.cs \
banking/model/Pagamento.cs \
banking/model/enums/TipoOperacao.cs \
banking/model/enums/TipoTransferencia.cs \
banking/model/enums/OrigemLogin.cs \
banking/model/enums/TipoConta.cs \
banking/model/enums/TipoDataPagamento.cs \
banking/model/enums/TipoDataPagamentoDarf.cs \
banking/model/enums/TipoTransacao.cs \
banking/model/RetornoPagamentoDarf.cs \
banking/model/Transacao.cs \
banking/model/DarfLote.cs \
banking/model/PaginaCallbacks.cs \
banking/model/InstituicaoFinanceira.cs \
banking/model/FiltroBuscarCallbacks.cs \
banking/model/PagamentoDarf.cs \
banking/model/DetalhesTransacao.cs \
banking/model/BoletoLote.cs \
banking/model/Lote.cs \
banking/model/Chave.cs \
banking/model/DadosBancarios.cs \
banking/model/PagamentoBoleto.cs \
banking/model/ProcessamentoLote.cs \
banking/model/RespostaIncluirPix.cs \
banking/model/RespostaIncluirPagamento.cs \
banking/model/ItemLote.cs


BANKING= \
banking/webhook/ExcluirWebhook.cs \
banking/webhook/CriarWebhook.cs \
banking/webhook/ObterWebhook.cs \
banking/webhook/ConsultarCallbacks.cs \
banking/extrato/ConsultarExtrato.cs \
banking/extrato/ConsultarExtratoEnriquecido.cs \
banking/extrato/RecuperarExtratoPdf.cs \
banking/pix/IncluirPix.cs \
banking/saldo/ConsultarSaldo.cs \
banking/pagamento/IncluirPagamentosLote.cs \
banking/pagamento/BuscarPagamentos.cs \
banking/pagamento/IncluirPagamentoDarf.cs \
banking/pagamento/BuscarLotePagamentos.cs \
banking/pagamento/IncluirPagamento.cs \
banking/pagamento/CancelaAgendamentoPagamento.cs \
banking/pagamento/BuscarPagamentosDarf.cs


MODEL_PIX= \
pix/model/CriarLocationRequest.cs \
pix/model/Valor.cs \
pix/model/Pix.cs \
pix/model/DevolucaoDetalhada.cs \
pix/model/PaginaPix.cs \
pix/model/PaginaCobrancas.cs \
pix/model/Calendario.cs \
pix/model/FiltroConsultarCobrancasImediatas.cs \
pix/model/Horario.cs \
pix/model/Callback.cs \
pix/model/FiltroConsultarCobrancasComVencimento.cs \
pix/model/Desconto.cs \
pix/model/CobrancaVencimento.cs \
pix/model/enums/ModalidadeAgente.cs \
pix/model/enums/StatusCobranca.cs \
pix/model/enums/NaturezaDevolucao.cs \
pix/model/enums/TipoCob.cs \
pix/model/CobrancaDetalhada.cs \
pix/model/FiltroConsultarLocations.cs \
pix/model/CalendarioCobV.cs \
pix/model/Juros.cs \
pix/model/Multa.cs \
pix/model/FiltroConsultarPixRecebidos.cs \
pix/model/Recebedor.cs \
pix/model/PaginaCallbacks.cs \
pix/model/CobrancaVencimentoDetalhada.cs \
pix/model/FiltroBuscarCallbacks.cs \
pix/model/CobVValor.cs \
pix/model/Cobranca.cs \
pix/model/InfoAdicional.cs \
pix/model/Abatimento.cs \
pix/model/Devolucao.cs \
pix/model/Troco.cs \
pix/model/Location.cs \
pix/model/PaginaCobrancasVencimento.cs \
pix/model/Paginacao.cs \
pix/model/Devedor.cs \
pix/model/PaginaLocations.cs \
pix/model/Parametros.cs \
pix/model/DescontoDataFixa.cs \
pix/model/Saque.cs \
pix/model/Retirada.cs


PIX= \
pix/webhook/ExcluirWebhook.cs \
pix/webhook/CriarWebhook.cs \
pix/webhook/ObterWebhook.cs \
pix/webhook/ConsultarCallbacks.cs \
pix/location/ConsultarLocationsCadastradas.cs \
pix/location/CriarLocation.cs \
pix/location/DesvincularLocation.cs \
pix/location/RecuperarLocation.cs \
pix/pix/ConsultarPix.cs \
pix/pix/SolicitarDevolucao.cs \
pix/pix/ConsultarDevolucao.cs \
pix/pix/ConsultarPixRecebidos.cs \
pix/cobv/RevisarCobrancaComVencimento.cs \
pix/cobv/ConsultarCobrancaComVencimento.cs \
pix/cobv/ConsultarCobrancasComVencimento.cs \
pix/cobv/CriarCobrancaComVencimento.cs \
pix/cob/RevisarCobrancaImediata.cs \
pix/cob/CriarCobrancaImediata.cs \
pix/cob/ConsultarCobrancasImediatas.cs \
pix/cob/ConsultarCobrancaImediata.cs


MODEL_COMMONS= \
commons/model/RespostaObterToken.cs \
commons/model/Violacao.cs \
commons/model/Config.cs \
commons/model/RetornoPdf.cs \
commons/model/Webhook.cs \
commons/model/Erro.cs \
commons/model/CriarWebhookRequest.cs

inter-sdk-csharp.dll: $(SDK) $(MODEL_COBRANCA) $(MODEL_BANKING) $(MODEL_PIX) $(MODEL_COMMONS) $(COBRANCA) $(BANKING) $(PIX)
	csc -w:0 -target:library /out:inter-sdk-csharp.dll $(SDK) $(MODEL_COBRANCA) $(MODEL_BANKING) $(MODEL_PIX) $(MODEL_COMMONS) $(COBRANCA) $(BANKING) $(PIX) 

