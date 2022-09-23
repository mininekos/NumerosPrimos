// See https://aka.ms/new-console-template for more information

int[] primos=new int[5];
int numPrimo = 0,cont;
for (int i = 1; numPrimo < 5; i++) {
    cont = 0;
	for (int j = 1; j <= i; j++)
	{
		if (i % j == 0) {
			cont++;

        }
		
	}
	if (cont == 2)
	{
        
        primos[numPrimo] = i;
		numPrimo++;
	}
}
foreach (int i in primos) {
    Console.WriteLine(i);
}

