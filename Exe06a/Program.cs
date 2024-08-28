//crear vetor
//percorrer o vetor com um laço
//gerar un valor aleatorio em c#
//ordenar o vetor usando o bubble Sort
int tamanho = 100;
int[] vetor = new int[tamanho];
Random random = new Random();
for (int i = 0 ; i < vetor.Length; i++){

vetor[i]  = random.Next(1000);

}

for (int i = 0 ; i < vetor.Length; i++)
{
Console.Write(vetor[i] + " ");
}

bool troca = false;

do{
    
    troca = false;

for (int i = 0 ; i < vetor.Length - 1; i++)
{
     
    if (vetor[i] > vetor[i+1])
        {
            troca = true;
            int aux = vetor[i];
            vetor[i]=vetor[i+1];
            vetor[i+1]= aux;
        }
}
}while(troca == true);

Console.WriteLine("\n");

for (int i = 0 ; i < vetor.Length; i++)
{
Console.Write(vetor[i] + " ");
}
