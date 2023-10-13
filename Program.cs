using Csharp_abstracao_de_celular.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("2132121", "Nokia", "zmxzljk5lfasfa", 12121);
Smartphone iphone = new IPhone("525252", "IPhone", "knk5125lnlnk", 576575);

iphone.Ligar(nokia);

nokia.ReceberLigacao(iphone);

nokia.InstalarAplicativo("Youtube");
iphone.InstalarAplicativo("Facebook");
