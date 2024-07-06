// --- main  
//    расстановка скобок  
#include <cmath>
#include <memory.h>
#include <chrono>
#include <iostream>
#include "MultiMatrix.h"   // умножение матриц 

#define N 6
int main()
{

	int Mc[N + 1] = { 8,11,19,22,29,39,50 }, Ms[N][N], r = 0, rd = 0;
	auto t1 = std::chrono::system_clock::now();
	memset(Ms, 0, sizeof(int) * N * N);
	r = OptimalM(1, N, N, Mc, OPTIMALM_PARM(Ms));
	auto t2 = std::chrono::system_clock::now();
	setlocale(LC_ALL, "rus");
	std::cout << std::endl;
	std::cout << std::endl << "-- расстановка скобок (рекурсивное решение) "
		<< std::endl;
	std::cout << std::endl << "размерности матриц: ";
	for (int i = 1; i <= N; i++) std::cout << "(" << Mc[i - 1] << "," << Mc[i] << ") ";
	std::cout << std::endl << "минимальное количество операций умножения: " << r;
	std::cout << std::endl << std::endl << "матрица S" << std::endl;
	for (int i = 0; i < N; i++)
	{
		std::cout << std::endl;
		for (int j = 0; j < N; j++)  std::cout << Ms[i][j] << "  ";
	}
	std::cout << std::endl;
	std::chrono::duration<double> elapsed = t2 - t1;
	std::cout << "Время выполнения: " << elapsed.count() * 1000000 << "мкс." << std::endl;

	t1 = std::chrono::system_clock::now();
	memset(Ms, 0, sizeof(int) * N * N);
	rd = OptimalMD(N, Mc, OPTIMALM_PARM(Ms));
	t2 = std::chrono::system_clock::now();
	std::cout << std::endl
		<< "-- расстановка скобок (динамичеое программирование) " << std::endl;
	std::cout << std::endl << "размерности матриц: ";
	for (int i = 1; i <= N; i++)
		std::cout << "(" << Mc[i - 1] << "," << Mc[i] << ") ";
	std::cout << std::endl << "минимальное количество операций умножения: "
		<< rd;
	std::cout << std::endl << std::endl << "матрица S" << std::endl;
	for (int i = 0; i < N; i++)
	{
		std::cout << std::endl;
		for (int j = 0; j < N; j++)  std::cout << Ms[i][j] << "  ";
	}
	std::cout << std::endl << std::endl;
	elapsed = t2 - t1;
	std::cout << "Время выполнения: " << elapsed.count() * 1000000 << "мкс." << std::endl;
	system("pause");

	return 0;
}
