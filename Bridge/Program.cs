using Bridge.ConcreteImplementor;
using Bridge.RefinedAbstraction;

var contaCorrente = new ContaCorrente(new Pix());
contaCorrente.TransferirDinheiro(100.00M);

contaCorrente = new ContaCorrente(new Ted());
contaCorrente.TransferirDinheiro(200.00M);

var contaPoupanca = new ContaPoupanca(new Pix());
contaPoupanca.TransferirDinheiro(300.00M);

contaPoupanca = new ContaPoupanca(new Ted());
contaPoupanca.TransferirDinheiro(400.00M);

Console.ReadKey();



