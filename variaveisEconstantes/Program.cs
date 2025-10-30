//Variáveis
char letra = 'C';
string nome = "João";
float temperatura = 25.7F;
double salario = 12578.89;
bool estaChovendo = true;
var list = new List<string> { "Eu", "Me", "Remexo", "Muito" };

//Alterando as variáveis
letra = 'X';
nome = "Maria";
temperatura = 39.7F;
salario = 1.99;
estaChovendo = false;

//Constantes
const char simbolo = '$';
const string saudacao = "Receba na caixa dos seios";
const float pi = 3.14159F;
const double altura = 1.78;
const bool ehVerdade = true;
const int numero = 14;


//Exibindo os valores os valores originais por interpolação
Console.WriteLine("Valores originais");
Console.WriteLine($"Letra: {letra}");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Temperatura: {temperatura}");
Console.WriteLine($"Salario: {salario}");
Console.WriteLine($"Está chovendo? {estaChovendo}");

//Exibindo os valores por concatenação 

Console.WriteLine("\nConstantes");
Console.WriteLine("Simbolo: " + simbolo);
Console.WriteLine("Saudação: " + saudacao);
Console.WriteLine("Valor de pi: " + pi);
Console.WriteLine("Altura: " + altura);
Console.WriteLine("É verdade? " + ehVerdade);
Console.WriteLine("Numero? " + numero);