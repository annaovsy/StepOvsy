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
	Array();// { data = nullptr, size = 0 };
	~Array();
	int GetSize();
	void SetSize(int size, int grow = 1);
	int GetUpperBound();
	bool IsEmpty();
	void Add(T value);
	void FreeExstra(); //удаление лишней памяти
	void RemoveAll();
	T GetAt(int index); //получение определенного элемента
	void SetAt(T value, int index); //добавление определенного элемента
	T& operator [](int index);





};

