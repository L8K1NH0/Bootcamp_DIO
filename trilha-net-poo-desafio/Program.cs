﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone 
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo:"Modelo 1" , imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagran");

Console.WriteLine("\n\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Pou");
