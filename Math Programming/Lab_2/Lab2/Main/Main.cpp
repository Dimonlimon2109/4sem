//#include <tchar.h>
//#include <iostream>
//#include <iomanip> 
//#include "Boat.h"
//#define NN (sizeof(v)/sizeof(int))
//#define MM 5
//
////4, 8, 12, 16) об оптимальной загрузке судна с условием центровки (веса контейнеров сгенерировать случайным образом:
////  количество мест на судне для контейнеров – 5, количество контейнеров 8, веса контейнеров 100 – 200 кг., 
//// доход от перевозки 10 – 100 у.е.; минимальный вес контейнера для каждого места 50 – 120 кг, 
//// максимальный вес контейнера для каждого места 150 – 850 кг); 
//int _tmain(int argc, _TCHAR* argv[])
//{
//    setlocale(LC_ALL, "rus");
//    int v[] = { 100,  120, 140, 160, 180, 200, 150, 130 }; // вес
//    int c[] = { 30, 10,  40, 25, 50, 80, 45, 90 }; // доход 
//    int minv[] = { 50,  100, 60, 120, 80 };    // минимальный  вес 
//    int maxv[] = { 850,  500,  150, 300, 600 };    // максимальный вес
//    short r[MM];
//    int cc = boat_с(
//        MM,    // [in]  количество мест для контейнеров
//        minv,  // [in]  максимальный вес контейнера на каждом  месте 
//        maxv,  // [in]  минимальный вес контейнера на каждом  месте  
//        NN,    // [in]  всего контейнеров  
//        v,     // [in]  вес каждого контейнера  
//        c,     // [in]  доход от перевозки каждого контейнера   
//        r      // [out] номера  выбранных контейнеров  
//    );
//    std::cout << std::endl << "- Задача о размещении контейнеров на судне -";
//    std::cout << std::endl << "- общее количество контейнеров   : " << NN;
//    std::cout << std::endl << "- количество мест для контейнеров  : " << MM;
//    std::cout << std::endl << "- минимальный  вес контейнера  : ";
//    for (int i = 0; i < MM; i++) std::cout << std::setw(3) << minv[i] << " ";
//    std::cout << std::endl << "- максимальный вес контейнера  : ";
//    for (int i = 0; i < MM; i++) std::cout << std::setw(3) << maxv[i] << " ";
//    std::cout << std::endl << "- вес контейнеров      : ";
//    for (int i = 0; i < NN; i++) std::cout << std::setw(3) << v[i] << " ";
//    std::cout << std::endl << "- доход от перевозки     : ";
//    for (int i = 0; i < NN; i++) std::cout << std::setw(3) << c[i] << " ";
//    std::cout << std::endl << "- выбраны контейнеры (0,1,...,m-1) : ";
//    for (int i = 0; i < MM; i++) std::cout << r[i] << " ";
//    std::cout << std::endl << "- доход от перевозки     : " << cc;
//    std::cout << std::endl << std::endl;
//    system("pause");
//    return 0;
//}

#include <iostream>
#include <iomanip> 
#include <time.h>
#include "D:\study\4_sem\Math Programming\Lab1\Lab1\Auxil.h"
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

