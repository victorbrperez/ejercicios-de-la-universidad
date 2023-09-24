#include <cstdlib>
#include <cstdio>
//
int main()
{
    int contador_billetes = 0;
    int cont = 0;
    int monto_restante;
    printf("OBTIMOS - @Software\n-----------------------------\n");
    //
    while (monto_restante > 0)
    {
        printf("Introduzca monto: ");
        scanf("%d",&monto_restante);
        if (2000 <= monto_restante)
        {
            for (cont = 0 ; monto_restante >= (cont * 2000); cont++);cont--;
            monto_restante -= cont*2000;
            printf("Billetes de RD$2000: => %d\n",cont);
        }
        //
        if (1000 <= monto_restante)
        {
            for (cont = 0 ; monto_restante >= (cont * 1000); cont++);cont--;
            monto_restante -= cont*1000;
            printf("Billetes de RD$1000: => %d\n",cont);
        }
        //
        if (500 <= monto_restante)
        {
            for (cont = 0 ; monto_restante >= (cont * 500); cont++);cont--;
            monto_restante -= cont*500;
            printf("Billetes de RD$500: => %d\n",cont);
        }
        //
        if (200 <= monto_restante)
        {
            for (cont = 0 ; monto_restante >= (cont * 200); cont++);cont--;
            monto_restante -= cont*200;
            printf("Billetes de RD$200: => %d\n",cont);
        }
        //
        if (100 <= monto_restante)
        {
            for (cont = 0 ; monto_restante >= (cont * 100); cont++);cont--;
            monto_restante -= cont*100;
            printf("Billetes de 100: => %d\n",cont);
        }
        //
        if (50 <= monto_restante)
        {
            for (cont = 0 ; monto_restante >= (cont * 50); cont++);cont--;
            monto_restante -= cont*50;
            printf("Billetes de RD$50: => %d\n",cont);
        }
        //
        if (20 <= monto_restante)
        {
            for (cont = 0 ; monto_restante >= (cont * 20); cont++);cont--;
            monto_restante -= cont*20;
            printf("Billetes de RD$20: => %d\n",cont);
        }
        //
        if (10 <= monto_restante)
        {
            for (cont = 0 ; monto_restante >= (cont * 10); cont++);cont--;
            monto_restante -= cont*10;
            printf("Billetes de RD$10: => %d\n",cont);
        }
        //
        if (5 <= monto_restante)
        {
            for (cont = 0 ; monto_restante >= (cont * 5); cont++);cont--;
            monto_restante -= cont*5;
            printf("Billetes de RD$5: => %d\n",cont);
        }
        //
        if (1 <= monto_restante)
        {
            for (cont = 0 ; monto_restante >= (cont * 1); cont++);cont--;
            monto_restante -= cont*1;
            printf("Billetes de RD$1: => %d\n",cont);
        }
    }
}
