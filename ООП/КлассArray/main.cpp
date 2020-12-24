#include "array.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	Array a(5);
	a.FillArr();
	a.Print();
	cout << endl;

	Array b(7);
	b.FillArr();
	//b.Print();
	//Array c = a++;	// ++
	//a.Print();
	//cout << endl;
	//c.Print();
	//cout << endl;
	//a[0] = 0;	// []
	//int c = a[0];
	//a.Print();

	a(15);	
	//a.Print();
	cout << a << endl;	
	cin >> a;
	cout << a << endl;




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