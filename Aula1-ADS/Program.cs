using System;
namespace Aula1_ADS
{
    class Program
    {
        static void Main(string[] args)

        {
            int[,] mat = new int[3,3];
            int i, j, soma=0;

            Console.WriteLine("Informe 9 numeros para matriz: ");
            for(i=0; i<3; i++)
            {
                for(j=0; j<3; j++)
                {
                    Console.WriteLine("Informe o valor do indice "+i+" , "+j);
                    mat[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("A matriz informada é: ");

            for(i = 0; i<3; i++)
            {
                for(j = 0; j<3; j++)
                {
                    
                    if (i==j)
                    {
                        soma += mat[i,j];
                    }
                }
            }

            Console.WriteLine("A soma dos elementos na diagonal principal é: " + soma);






            //int[] Vet = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Informe um valor");
            //    Vet[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    if (Vet[i] %2 == 0)
            //    {
            //        Console.WriteLine("valor Par: "+ Vet[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("valor Impar: " + Vet[i]);
            //    }

            //}

            //----------------------------------------------------------------

            //int[] Vet = new int[3];

            //for(int i =0; i<3; i++)
            //{
            //    Console.WriteLine("Informe 1 valor");
            //    Vet[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 2; i >= 0; i--){
            //    Console.WriteLine(Vet[i]);
            //}


            //----------------------------------------------------------------


            /*
            int Nmenor=0, Nmaior=0, soma=0,num ,i = 0;
            double media;

            while(i < 7) {
                Console.WriteLine("Informe o valor");
                num = Convert.ToInt32(Console.ReadLine());

                if(i == 0) {
                    Nmenor = num;
                    Nmaior = num;
                }
                if(Nmenor > num)
                {
                  Nmenor= num;
                }
                if(Nmaior < num)
                {
                    Nmaior = num;
                }
                soma = soma + num; 
                i++;
            }

            media = soma / 20;

            Console.WriteLine("Maior: " + Nmaior);
            Console.WriteLine("Menor: " + Nmenor);
            Console.WriteLine("media: " + media);
            */

            //----------------------------------------------------------------

            /*
            double n1,n2,n3, mediaEx, mediaAp;
            Console.WriteLine("Informe a nota 1");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota 2");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota 3");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a media dos exrcicios");
            mediaEx = Convert.ToDouble(Console.ReadLine());

            mediaAp = ((n1 + n2 * 2 + n3 * 3 + mediaEx) / 7);


            if (mediaAp >= 9) {
                Console.WriteLine("Conceito A");
            }else if(mediaAp >= 7.5 && mediaAp < 9.0)
            {
                Console.WriteLine("Conceito B");
            }else if( mediaAp >= 6.0 && mediaAp < 7.5)
            {
                Console.WriteLine("Conceito C");
            }else if(mediaAp < 6.0)
            {
                Console.WriteLine("conceito D");
            }

            */

        }
    }
}