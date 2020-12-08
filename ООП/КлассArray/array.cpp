#include "array.h"
#include <iostream>
using namespace std;

Array::Array(int _size) :size{ _size }	//упрощенна€ запись
{/*
	size = _size;*/						//вместо этого
	arr = new int[size] {0};
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

void Array::Sortr()
{
	int buff;
	for (int i = 0; i < size - 1; i++)
	{
		for (int j = 0; j < size - i - 1; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				buff = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = buff;
			}
		}
	}
}

void Array::SetSize()
{
	cout << "¬ведите размер массива: " << endl;
	int _newSize;
	cin >> _newSize;

	int* arr2 = new int[_newSize];
	for (int i = 0; i < _newSize; i++)
	{
		if (i >= size)
		{
			arr2[i] = 0;
		}
		else
		{
			arr2[i] = arr[i];
		}
	}
	arr = arr2;
	size = _newSize;
}

int Array::GetSize()
{
	return size;
}

void Array::FillArr()
{
	for (int i = 0; i < size; i++)
	{
		arr[i] = rand() % 10;
	}
}

int Array::Min()
{
	int min = 11;
	for (int i = 0; i < size; i++)
	{
		if (arr[i] < min)
		{
			min = arr[i];
		}
	}
	return min;
}

int Array::Max()
{
	int max = 0;
	for (int i = 0; i < size; i++)
	{
		if (arr[i] > max)
		{
			max = arr[i];
		}
	}
	return max;
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
}
