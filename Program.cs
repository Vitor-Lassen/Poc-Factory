using Model;
using Poc.Factory.Enum;
using Poc.Factory.Factory;

var messagem = new Message(){
    Destino = SenderEnum.sms,
    Texto = "olá, bem vindo" };


var SenderFactory = new SenderFactory().GetSenderFactory(messagem.Destino);

SenderFactory.Send(messagem);



