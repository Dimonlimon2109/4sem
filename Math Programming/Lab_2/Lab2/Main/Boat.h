#pragma once
#include "D:\study\4_sem\Math Programming\Lab_2\Accommodations\Combi.h"
#include "D:\study\4_sem\Math Programming\Lab1\Lab1\Auxil.h"
// -- решение  задачи об оптимальном  размещении контейнеров 
//  функция возвращает доход  от перевозки выбранных контейнеров
int boat_с(
    short m,      // [in]  количество мест для контейнеров
    int minv[],   // [in]  минимальный вес контейнера на каждом  месте 
    int maxv[],   // [in]  максимальный вес контейнера на  каждом месте  
    short n,      // [in]  всего контейнеров  
    const int v[],// [in]  вес каждого контейнера  
    const int c[],// [in]  доход от перевозки каждого контейнера   
    short r[]     // [out] номера  выбранных контейнеров  
);
