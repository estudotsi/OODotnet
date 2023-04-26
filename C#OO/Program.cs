// See https://aka.ms/new-console-template for more information

using C_OO;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.Titular = "Andre";
contaDoAndre.Agencia = 15;
contaDoAndre.Conta = "1010-x";
contaDoAndre.Saldo = 100;

//Console.WriteLine("Objeto" + contaDoAndre);
//Console.WriteLine("Saldo" + contaDoAndre.Saldo);

Console.WriteLine(contaDoAndre.Saldo);
contaDoAndre.Depositar(80);
contaDoAndre.Sacar(30);
Console.WriteLine(contaDoAndre.Saldo);
