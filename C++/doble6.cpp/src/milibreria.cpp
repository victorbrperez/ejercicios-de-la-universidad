#include <esconu.h>

//----------------------------------------------------------------------------------------------
//Funcion que dibula el marco.
void enmarcar(int v_color,int v_color_fondo)
{

    int i;

    char char_v = ' ';
    char char_h = ' ';

    BorraPantalla();

    //Traza marco superior horizontal
    CoordenadaXY(3,2);
    ColorTexto(BLANCO);
    ColorFondoTexto(v_color);
    for (i = 0; i < 76; i++ )
    {
        cout << char_h;
    }
    ColorFondoTexto(v_color_fondo);

    //Traza marco inferior horizontal
    ColorFondoTexto(v_color);
    CoordenadaXY(3,22);
    for (i = 0; i < 76; i++ )
    {
        cout << char_h;
    }
    ColorFondoTexto(v_color_fondo);

    //Traza marco izquierdo vertical
    ColorFondoTexto(v_color);
    for (i = 3; i < 22 ; i++ )
    {
        CoordenadaXY(2,i);
        cout << char_v << char_v;
    }
    ColorFondoTexto(v_color_fondo);

    //Traza marco derecho vertical
    ColorFondoTexto(v_color);
    for (i = 3; i < 22 ; i++ )
    {
        CoordenadaXY(78,i);
        cout << char_v << char_v;
    }
    ColorFondoTexto(v_color_fondo);
}
//----------------------------------------------------------------------------------------------
//Funcion que permite centrar un texto.
void centrar(string v_cadena,int v_y,int v_margen)
{
    int i = 0;
    do
    {
        i++;
    }while(v_cadena[i] != NULL);
    int margen = ((80 - i) / 2) - 1;
    CoordenadaXY(margen + (v_margen / 2),v_y);
    cout << v_cadena;
}
//----------------------------------------------------------------------------------------------
//Funcion que dibua losdados.
void dibuja_dado(int valor_x, int valor_y, int valor_cara)
{
    //CoordenadaXY(5,8);
    ColorTexto(ROJO);
    ColorFondoTexto(BLANCOCLARO);

    for (int i = valor_x ; i < valor_x + 11; i++)
        for (int j = valor_y; j < valor_y + 5; j++)
        {
            CoordenadaXY(i,j);
            if (valor_cara == 1 || valor_cara == 5 || valor_cara == 3)
            {
                //Imprime el punto del centro del dado.
                if (i == valor_x + 5 && j == valor_y + 2) cout << "*";
            }
            if (valor_cara == 4 || valor_cara == 5 || valor_cara == 6)
            {
                //Imprime el punto izquierdo superior del dado.
                if (i == valor_x + 2 && j == valor_y + 1) cout << "*";
            }
            if (valor_cara == 4 || valor_cara == 5 || valor_cara == 6 || valor_cara == 3 || valor_cara == 2)
            {
                //Imprime el punto superior derecho del dado.
                if (i == valor_x + 8 && j == valor_y + 1) cout << "*";
            }
            if(valor_cara == 6)
            {
                //Imprime el punto central izquierdo del dado.
                if (i == valor_x + 2 && j == valor_y + 2) cout << "*";
            }
            if (valor_cara == 6)
            {
                //Imprime el punto central derecho del daddo.
                if (i == valor_x + 8 && j == valor_y + 2) cout << "*";
            }
            if(valor_cara == 4 || valor_cara == 5 || valor_cara == 6 || valor_cara == 3 || valor_cara == 2)
            {
                //Imprime el punto inferior izquierdo del dado.
                if (i == valor_x + 2 && j == valor_y + 3) cout << "*";
            }
            if (valor_cara == 4 || valor_cara == 5 || valor_cara == 6)
            {
                //Imprime el punto inferior derecho del dado.
                if (i == valor_x + 8 && j == valor_y + 3) cout << "*";
            }
            cout << " ";
        }
}
//---------------------------------------------------------------------------------------------------------------
//
char pantalla_mensaje(int v_color, char v_accion)
{
    char opcion = 'c';
    for (int x = 1; x <= 80; x++)
        for (int y = 1; y <= 24; y++)
        {
            CoordenadaXY(x,y);
            ColorFondoTexto(v_color);
            ColorTexto(BLANCO);
            cout << " ";
        }
    if (v_accion == 'i')
    {
        centrar("JUEGO DE DADOS",10,1);
        centrar("Presione [ENTER] para lanzar",12,1);
        cin.get();
    }
    else
    {
         centrar("Salir [X]",10,1);
         centrar("Lanzar de nuevo [ENTER]",12,1);
         opcion = LeeCaracter();
    }
    return opcion;
}
