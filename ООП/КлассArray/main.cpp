#include "array.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	Array arr;
	
	arr.GetSize();
	arr.FillArr();
	arr.Print();

	//arr.SetSize();
	//arr.Print();

	cout << "��������������� ������: " << endl;
	arr.Sortr();
	arr.Print();

	int min = arr.Min();
	cout << "\n����������� �������: " << min << endl;

	int max = arr.Max();
	cout << "\n������������ �������: " << max << endl;

	//Array* matrix = new Array[5];
	//for (int i = 0; i < 5; i++)
	//{
	//	matrix[i].Print();
	//}
	Array* matrix = new Array[5]
	{
		{5},
		{4},
		{3},
		{2},
		{1}
	};
	for (int i = 0; i < 5; i++)
	{
		matrix[i].Print();
	}


	


}