using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;


//Implementado..!!!
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"4321-1234", modelo:"flip", imei: "0001", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();
Console.WriteLine("Smartphone iPhone");
Smartphone iPhone = new Iphone(numero:"1234-4321", modelo: "flop", imei: "0002", memoria: 128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Telegram");