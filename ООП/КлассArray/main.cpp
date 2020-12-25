#include "array.h"
#include <iostream>
#include <stdarg.h> //для контроля разных типов аргументов
using namespace std;

template <typename T>
T summa(T k, ...) //функция с неопределенным кол-вом параметров
{
	T* pk = &k;
	T sm = 0;
	for (; k != 0; k--)
		sm += *(++pk);

	return sm;
}

template <typename T>
T summa2(T k, ...) //функция с неопределенным кол-вом параметров
{
	T* pk = &k;
	T sm = 0;
	
	while(*pk)
		sm += *(pk++);

	return sm;
}

void summaAnyType(int count, bool typeof, ...)
{
	int sumi = 0;
	double sumd = 0.0;

	va_list arg_ptr;
	va_start(arg_ptr, count);
	va_arg(arg_ptr, bool);

	while (count--)
	{
		(typeof) ? sumi += va_arg(arg_ptr, int) :
				   sumd += va_arg(arg_ptr, double);
	}
	va_end(arg_ptr);
	cout << sumi << endl;
	cout << sumd << endl;
}

int main()
{
	setlocale(LC_ALL, "rus");

	int a = 1;
	int b = 2;
	int c = 3;

	summaAnyType(3, false, 1.0, 2.0, 3.0);

	//cout << summa(1, a) << endl;
	//cout << summa(2, a, b) << endl;
	//cout << summa((double)3, 1.0, 2.0, 3.0) << endl << endl;

	//cout << summa2(a,0) << endl;
	//cout << summa2(a, b, 0) << endl;
	//cout << summa2(1.0, 2.0, 3.0, (double)0) << endl;

	//Array a(5);
	//a.FillArr();
	//a.Print();
	//cout << endl;

	//Array b(7);
	//b.FillArr();
	//b.Print();
	//Array c = a++;	// ++
	//a.Print();
	//cout << endl;
	//c.Print();
	//cout << endl;
	//a[0] = 0;	// []
	//int c = a[0];
	//a.Print();

	//a(15);	
	////a.Print();
	//cout << a << endl;	
	//cin >> a;
	//cout << a << endl;




	//Array arr;
	//
	//arr.GetSize();
	//arr.FillArr();
	//arr.Print();

	////arr.SetSize();
	////arr.Print();

	//cout << "Отсортированный массив: " << endl;
	//arr.Sortr();
	//arr.Print();

	//int min = arr.Min();
	//cout << "\nМинимальный элемент: " << min << endl;

	//int max = arr.Max();
	//cout << "\nМаксимальный элемент: " << max << endl;

	////Array* matrix = new Array[5];
	////for (int i = 0; i < 5; i++)
	////{
	////	matrix[i].Print();
	////}
	//Array* matrix = new Array[5]
	//{
	//	{5},
	//	{4},
	//	{3},
	//	{2},
	//	{1}
	//};
	//for (int i = 0; i < 5; i++)
	//{
	//	matrix[i].Print();
	//}


	


}