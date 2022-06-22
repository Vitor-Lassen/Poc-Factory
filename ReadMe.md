# Factory 

Poc prove of concept  - para exemplificar o uso de factory


O exemplo teorico seria realizar o envio de mensagem 

Pode enviar um email, sms ou um whatsapp 

```
mensagem = {
    texto
    destino 
}
```

Métodos sugeridos inicialmete 
```
enviar(whatsapp){}
enviar(email){}
enviar(sms){}

if (messagem.destino == whatsapp)
    enviar (whatsapp)
if (messagem.destino == sms)
    enviar(sms)
if (messagem.destino == email)
    enviar(email)
```

Utilizando Factory
```
SendMessageFactory sendService = New  SendMessageFactory().GetInstance(mensagem.destino);
sendService.send(messagem);
```

TODO: Implementação fctory utilizando o IoC Inversor of Container : Service.Scoped<service,Iservice>();