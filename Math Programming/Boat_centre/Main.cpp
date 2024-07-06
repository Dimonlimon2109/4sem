#include <iostream>
#include <iomanip> 
#include <time.h>
#include "Auxil.h"
#include <tchar.h>
#include "Boat.h"
#define SPACE(n) std::setw(n)<<" "
#define NN 11
int _tmain(int argc, _TCHAR* argv[])
{
    setlocale(LC_ALL, "rus");
    int v[NN + 1], c[NN + 1], minv[NN + 1], maxv[NN + 1];
    short r[NN];
    auxil::start();
    for (int i = 0; i <= NN; i++)
    {
        v[i] = auxil::iget(50, 500); c[i] = auxil::iget(10, 30);
        minv[i] = auxil::iget(50, 300); maxv[i] = auxil::iget(250, 750);
    }
    std::cout << std::endl << "-- Задача о размещении контейнеров -- ";
    std::cout << std::endl << "-- всего контейнеров: " << NN;
    std::cout << std::endl << "-- количество ------ продолжительность -- ";
    std::cout << std::endl << "  мест     вычисления  ";
    clock_t t1, t2;
    for (int i = 4; i <= 8; i++)
    {
        t1 = clock();
        boat_с(i, minv, maxv, NN, v, c, r);
        t2 = clock();
        std::cout << std::endl << SPACE(7) << std::setw(2) << i
            << SPACE(15) << std::setw(6) << (t2 - t1);
    }
    std::cout << std::endl; system("pause");
    return 0;
}

