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
	
	Array operator+(const Array& b);
	Array operator-(const Array& b);
	Array operator/(const Array& b);
	Array operator*(const Array& b);

	Array operator++();
	Array operator++(int k);
	int& operator[](int indx); //оператор доступа
	void operator()(int newSize);//вместо set (для изменения значений)

	friend istream& operator>>(istream&, Array&);
	friend ostream& operator<<(ostream&, const Array&); //конст чтобы не менять значения, тк это оператор вывода

	void Print();
	//void Sortr();
	//void SetSize();
	//int GetSize();
	void FillArr();
	//int Min();
	//int Max();
	~Array();
};