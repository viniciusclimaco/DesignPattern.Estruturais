using Adapter;
using Adapter.Domain;

Cooffe cooffe = new Cooffe() {  Id = 1, Nome = "Café com leite", Tamanho = "Pequeno"};


//ICafeteiraTresCoracoes cafeteira = new CafeteiraTresCoracoes();
ICafeteiraTresCoracoes cafeteira = new CafeteiraNespressoAdapter();

cafeteira.LigarTresCoracoes();
cafeteira.AquecerTresCoracoes();
cafeteira.CafeProntoTresCoracoes(cooffe);
cafeteira.DesligarTresCoracoes();

Console.ReadLine();
