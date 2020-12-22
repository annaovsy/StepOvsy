#pragma once
#include <iostream>
using namespace std;

class Array
{
private:
	int* arr;
	int size;

public:
	static int counter;

	Array(int _size = 10);
	Array(const Array& copyArr);
	
	Array operator+(const Array& b);
	Array operator-(const Array& b);
	Array operator/(const Array& b);
	Array operator*(const Array& b);

	Array operator++();	//���������� �����
	Array operator++(int k);	//�����������
	int& operator[](int indx); //�������� ������� 
	void operator()(int newSize);//������ set (��� ��������� ��������)

	friend istream& operator>>(istream&, Array&);
	friend ostream& operator<<(ostream&, const Array&); //����� ����� �� ������ ��������, �� ��� �������� ������

	operator int();	//�������� ���������� �����
	operator int* ();


	void Print();
	//void Sortr();
	//void SetSize();
	//int GetSize();
	void FillArr();
	//int Min();
	//int Max();
	~Array();
};