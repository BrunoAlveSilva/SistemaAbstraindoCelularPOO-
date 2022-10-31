using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var  nokia  =  new  Nokia( " (31) 98880-4444 " , " Nokia " , "5111116166" , 10 );
var  iphone  = new Iphone( " (11) 98999-3333 " , " Iphone SE " , "16116184168464" , 10 );
Console.WriteLine( "Smartphone Nokia:" );
nokia . Ligar ();
Console.WriteLine( "\nSmartphone Iphone:" );
iphone . Ligar ();

Console.WriteLine( "\n" );


var  WhatAapp  =  new  Aplicativo ( " WhatAapp " , 100 );
var  Amazon  =  new  Aplicativo ( " Amazon " , 100 );

Console.WriteLine( "Instalando aplicativos no Iphone" );
iphone . InstalarAplicativo ( WhatAapp );
iphone . InstalarAplicativo ( Amazon );

Console.WriteLine( "\n Instalando aplicativos no Nokia" );
nokia . InstalarAplicativo ( WhatAapp );
nokia . InstalarAplicativo ( Amazon );