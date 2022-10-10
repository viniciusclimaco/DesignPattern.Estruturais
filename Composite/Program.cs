using Composite.Composite;
using Composite.Leaf;

var edificio = new Edificio(" Edificio DotNet ");
var apartamento101 = new Apartamento("101");
var apartamento102 = new Apartamento("102");
var apartamento103 = new Apartamento("103");
var apartamento201 = new Apartamento("201");
var apartamento202 = new Apartamento("202");
var apartamento203 = new Apartamento("203");

edificio.Adicionar(apartamento101);
edificio.Adicionar(apartamento102);
edificio.Adicionar(apartamento103);
edificio.Adicionar(apartamento201);
edificio.Adicionar(apartamento202);
edificio.Adicionar(apartamento203);

var morador101_1 = new Morador("João");
var morador101_2 = new Morador("Maria");
var morador102_1 = new Morador("Pinocchio");
var morador103_1 = new Morador("Bill Gates");
var morador201_1 = new Morador("Barack Obama");
var morador201_2 = new Morador("Michelle Obama");
var morador202_1 = new Morador("Zezinho");
var morador202_2 = new Morador("Luizinho");
var morador202_3 = new Morador("Huguinho");
var morador203_1 = new Morador("Steve Jobs");

apartamento101.Adicionar(morador101_1);
apartamento101.Adicionar(morador101_2);
apartamento102.Adicionar(morador102_1);
apartamento103.Adicionar(morador103_1);
apartamento201.Adicionar(morador201_1);
apartamento201.Adicionar(morador201_2);
apartamento202.Adicionar(morador202_1);
apartamento202.Adicionar(morador202_2);
apartamento202.Adicionar(morador202_3);
apartamento203.Adicionar(morador203_1);

edificio.Exibir();
Console.ReadKey();
