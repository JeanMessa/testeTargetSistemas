double fatSP = 67836.43, fatRJ = 36678.66, fatMG = 29229.88, fatES = 27165.48, fatOutros = 19849.53;

double total = fatSP + fatRJ + fatMG + fatES + fatOutros;


Console.WriteLine($"Porcentagem do faturamento SP: {fatSP/total*100}%");
Console.WriteLine($"Porcentagem do faturamento RJ: {fatRJ / total * 100}%");
Console.WriteLine($"Porcentagem do faturamento MG: {fatMG / total * 100}%");
Console.WriteLine($"Porcentagem do faturamento ES: {fatES / total * 100}%");
Console.WriteLine($"Porcentagem do faturamento Outros: {fatOutros / total * 100}%");

