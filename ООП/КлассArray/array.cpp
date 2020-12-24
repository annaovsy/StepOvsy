#include "array.h"
#include <iostream>
#include <cmath>
using namespace std;

int Array::counter = 0;

Array::Array(int _size) :size{ _size }	//упрощенная запись
{/*
	size = _size;*/						//вместо этого
	arr = new int[size] {0};

	counter++;
}

Array::Array(const Array& copyArr)
{
	size = copyArr.size;
	arr = new int[size];
	for (int i = 0; i < size; i++)
	{
		arr[i] = copyArr.arr[i];
	}
}

Array Array::operator+(const Array& b)
{
	int maxSize = fmax(size, b.size);	//выбираем больший массив
	int minSize = fmin(size, b.size);	//выбираем меньший массив
	Array* c = new Array(maxSize);	//создаем новый массив с максимальным размером для сложения элементов
	for (int i = 0; i < maxSize; i++)
	{
		if (i < b.size)
			c->arr[i] += b.arr[i];
		if (i<this->size)
			c->arr[i] += this->arr[i];
	}
	return *c;
}

Array Array::operator-(const Array& b)
{
	int maxSize = fmax(size, b.size);	//выбираем больший массив
	int minSize = fmin(size, b.size);	//выбираем меньший массив
	Array* c = new Array(maxSize);	//создаем новый массив с максимальным размером для сложения элементов
	for (int i = 0; i < maxSize; i++)
	{
		if (i < this->size)
			c->arr[i] += this->arr[i];

		if (i < b.size)
			c->arr[i] -= b.arr[i];
	}
	return *c;
}

Array Array::operator/(const Array& b)
{
	int maxSize = fmax(size, b.size);	//выбираем больший массив
	int minSize = fmin(size, b.size);	//выбираем меньший массив
	Array* c = new Array(maxSize);		//создаем новый массив с максимальным размером для сложения элементов
	for (int i = 0; i < maxSize; i++)
	{
		if (i < this->size && i < b.size && b.arr[i] != 0)
		{
			c->arr[i] = this->arr[i] / b.arr[i];
			continue;
		}
		if (i < this->size && i < b.size && b.arr[i] == 0)
		{
			c->arr[i] = 0;
			continue;
		}
		if (i < this->size)
		{
			c->arr[i] = this->arr[i];
			continue;
		}
		c->arr[i] = 0;
	}
	return *c;
}

Array Array::operator*(const Array& b)
{
	int maxSize = fmax(size, b.size);	//выбираем больший массив
	int minSize = fmin(size, b.size);	//выбираем меньший массив
	Array* c = new Array(maxSize);	//создаем новый массив с максимальным размером для сложения элементов
	for (int i = 0; i < maxSize; i++)
	{
		c->arr[i] = 1;
		if (i < b.size)
			c->arr[i] *= b.arr[i];
		if (i < this->size)
			c->arr[i] *= this->arr[i];
	}
	return *c;
}

Array Array::operator++()
{
	for (int i = 0; i < size; i++)
	{
		this->arr[i]++;
	}
	return *this;//возвращаем объект, который изменяем /*срабатывает конструктор копирования*/
}

Array Array::operator++(int k)
{
	Array c(*this);	//вызвали конструктор копирования
	++(*this);		//на основе префикса сделали постфикс

	return c;
}

int& Array::operator[](int indx)
{
	return this->arr[indx];
}

void Array::operator()(int newSize)
{
	int* newArr = new int[newSize] {0};
	for (int i = 0; i < newSize; i++)
	{
		if (i < size)
		{
			newArr[i] = arr[i];
		}
	}
	size = newSize;
	delete[]arr;
	arr = newArr;
}

//void Array::Sortr()
//{
//	int buff;
//	for (int i = 0; i < size - 1; i++)
//	{
//		for (int j = 0; j < size - i - 1; j++)
//		{
//			if (arr[j] > arr[j + 1])
//			{
//				buff = arr[j];
//				arr[j] = arr[j + 1];
//				arr[j + 1] = buff;
//			}
//		}
//	}
//}
//
//void Array::SetSize()
//{
//	cout << "Введите размер массива: " << endl;
//	int _newSize;
//	cin >> _newSize;
//
//	int* arr2 = new int[_newSize];
//	for (int i = 0; i < _newSize; i++)
//	{
//		if (i >= size)
//		{
//			arr2[i] = 0;
//		}
//		else
//		{
//			arr2[i] = arr[i];
//		}
//	}
//	arr = arr2;
//	size = _newSize;
//}
//
//int Array::GetSize()
//{
//	return size;
//}

void Array::FillArr()
{
	for (int i = 0; i < size; i++)
	{
		arr[i] = rand() % 10;
	}
}

//int Array::Min()
//{
//	int min = 11;
//	for (int i = 0; i < size; i++)
//	{
//		if (arr[i] < min)
//		{
//			min = arr[i];
//		}
//	}
//	return min;
//}
//
//int Array::Max()
//{
//	int max = 0;
//	for (int i = 0; i < size; i++)
//	{
//		if (arr[i] > max)
//		{
//			max = arr[i];
//		}
//	}
//	return max;
//}

Array::operator int()
{
	return size;
}

Array::operator int* ()
{
	return arr;
}

void Array::Print()
{
	for (int i = 0; i < size; i++)
	{
		cout << arr[i] << "\t";
	}
	cout << endl;
}

Array::~Array()
{
	delete[]arr;

	counter--;
}

istream& operator>>(istream& os, Array& a) 
{
	cin >> a.size;
	a(a.size);
	return os;
}

ostream& operator<<(ostream& is, const Array& a)	//для вывода через cout экземпляров класса
{
	for (int i = 0; i < a.size; i++)
	{
		cout << a.arr[i] << "\t";
	}
	cout << endl;
	return is;
}
