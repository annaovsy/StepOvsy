#include "template.h"
#include <iostream>
using namespace std;

template<class T>
int Array<T>::GetSize()
{
	return size;
}

template<class T>
Array<T>::Array() :data(nullptr), size(0)
{
}

template<class T>
Array<T>::~Array()
{
	delete[]data;
}

template<class T>
void Array<T>::SetSize(int size, int grow)
{
	this->size = size;
	this->grow = grow;
	T* temp = new T[size];
	for (int i = 0; i < this->size; i++)
	{
		if (data == nullptr)
			break;
		temp[i] = data[i];
	}

	if (data)
		delete[]data;

	data = temp;
}

template<class T>
int Array<T>::GetUpperBound()
{
	return countElement - 1;
}

template<class T>
void Array<T>::Add(T value)
{
	if (countElement < size)
	{
		data[countElement] = value;
	}
	else
	{
		int newSize = size + grow;
		T* temp = new T[newSize];
		for (int i = 0; i < this->size; i++)
		{
			temp[i] = data[i];
		}
		temp[size] = value;
		delete[]data;
		data = temp;
		size = newSize;
	}
	++countElement;
}

template<class T>
void Array<T>::FreeExstra()
{
	int index = GetUpperBound();
	if (index > -1)
	{
		int tempSize = size - index;
		T* temp = new T[tempSize];
		for (int i = 0; i < tempSize; i++)
		{
			temp[i] = data[i];
		}
		delete[]data;
		data = temp;
		this->size = size;
	}
}

