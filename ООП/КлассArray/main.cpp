#include "array.h"
#include "singleton.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	Temp* main_ptr = new Temp;
	main_ptr->TempFunction();

	MyPtr pTemp(main_ptr);
	pTemp->TempFunction();

	Temp* arr = new Temp[3];
	for (int i = 0; i < 3; i++)
	{
		arr[i].TempSet(i);
	}
	MyPtr arr_temp = arr;
	arr_temp++;
	arr_temp->TempFunction();

	delete main_ptr;
	delete[]arr;



	//Singleton* p = Singleton::GetReference();

	//cout << p->GetValue() << endl;
	//p->SetValue(5);
	//cout << p->GetValue() << endl;

	//Singleton* p1 = Singleton::GetReference();
	//cout << p1->GetValue() << endl;
	//p1->SetValue(15);
	//cout << p1->GetValue() << endl;


	//cout << Array::counter << endl;
	//Array* a = new Array[10];
	//cout << Array::counter << endl;
	//delete[]a;
	//cout << Array::counter << endl;

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
	//cout << a << endl;	
	//cin >> a;
	//cout << a << endl;

	//int size = a;	//приводим к типу int
	//cout << size << endl;



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