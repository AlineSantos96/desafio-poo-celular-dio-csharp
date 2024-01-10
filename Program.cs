﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("================= Meu Iphone ====================");
System.Console.WriteLine();
Iphone meuIPhone = new Iphone("424234235", "Iphone 14", "346345353", 64);
meuIPhone.InstalarAplicativo("Twitter");

System.Console.WriteLine();

System.Console.WriteLine("================= Meu Nokia ====================");
System.Console.WriteLine();
Nokia meuNokia = new Nokia("4254434353", "Nokia Antigo", "r4325235346", 32);
meuNokia.InstalarAplicativo("Snake");