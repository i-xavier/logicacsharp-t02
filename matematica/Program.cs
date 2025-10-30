// Declarando constantes

const int valor1 = 10;
const int valor2 = 5;
const float valor3 = 3.0F;

// Soma
float total = valor1 + valor2;

Console.WriteLine($"{valor1} + {valor2} = {total}");

// Subtração
total = valor1 - valor2;

Console.WriteLine($"{valor1} - {valor2} = {total}");

// Multiplicação
total = valor1 * valor2;

Console.WriteLine($"{valor1} * {valor2} = {total}");

// Divisão
total = valor1 / valor3;

Console.WriteLine($"{valor1} / {valor3} = {total}");

// Resto da divisão
total = valor1 % valor2;

Console.WriteLine($"{valor1} % {valor2} = {total}");

// Potência
double potencia = Math.Pow(valor1, valor2);

Console.WriteLine($"{valor1} ^ {valor2} = {potencia}");

// Exemplo 1: Sem parênteses
int resultado1 = 3 + 5 * 2; //Multiplicação tem prioridade
Console.WriteLine($"Resultado 1 (sem parenteses): 3 + 5 * 2 = {resultado1}");

// Exemplo 1: Com parênteses
resultado1 = (3 + 5) * 2; // Parenteses alteram a ordem
Console.WriteLine($"Resultado 2 (com parenteses): 3 + 5 * 2 = {resultado1}");

// Exemplo 2: Sem parênteses
resultado1 = 8 / 4 + 3; // Divisão tem prioridade
Console.WriteLine($"Resultado 3 (sem parenteses): 3 + 5 * 2 = {resultado1}");

// Exemplo 2: Com parênteses
double resultado2 = 8.0 / (4 + 3) ; //Parenteses alteram a ordem
Console.WriteLine($"Resultado 4 (com parenteses): 3 + 5 * 2 = {resultado2}");