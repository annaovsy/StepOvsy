#pragma once
#include <iostream>
using namespace std;

template<class T>
class Array
{
private:
	T* data;
	int size;
	int grow;
	int countElement;

public:
	Array();
	~Array();
	int GetSize();
	void SetSize(int size, int grow = 1);
	int GetUpperBound();
	void Add(T value);
	void FreeExstra(); 
};

