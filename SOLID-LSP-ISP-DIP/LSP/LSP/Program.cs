using System;
using LSP;
Pajaro pajaro = new Pajaro("Piolín");
Pinguino pinguino = new Pinguino("Pingu");

pajaro.Volar();
Console.WriteLine($"{pinguino.Nombre} es un pingüino y no puede volar.");