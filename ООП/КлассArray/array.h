#pragma once
#include <iostream>
using namespace std;

class Array
{
private:
	int* arr;
	int size;
public:
	Array(int _size = 10);
	Array(const Array& copyArr);

	void Sortr();
	void SetSize();
	int GetSize();
	void FillArr();
	int Min();
	int Max();
	void Print();
	

	~Array();
};
