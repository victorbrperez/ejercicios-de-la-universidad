#include <esconu.h>
#include "src/milibreria.h"
#include <ctime>
#include <unistd.h>

int main()
{
    char opcion;
    bool seguir = true;
    int dado1;
    int dado2;

    pantalla_mensaje(NEGRO,'i');
    do
    {
        enmarcar(VERDE,VERDE);
        srand(time(0));
        seguir = true;

        do
        {
            dado1 = rand() % 6 + 1;
            dibuja_dado(23,6,dado1);//Dibuja el primer dado.

            dado2 = rand() % 6 + 1;
            dibuja_dado(35,12,dado1);//Dibuja el segundo dado.
            Sleep(150);

            if (dado1 == 6 && dado2 == 6) seguir = false;

        }while(seguir);

        CoordenadaXY(74,18);
        cin.get();
        opcion = pantalla_mensaje(VERDE,'x');

    }while (opcion != 'x');

    ColorFondoTexto(PREESTABLECIDO);
    ColorTexto(PREESTABLECIDO);
    BorraPantalla();
}



