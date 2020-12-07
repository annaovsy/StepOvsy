#pragma once
#include <iostream>
using namespace std;

class String
{
private:
	char* str;
	int size;
public:
	String(char* _str);
	String(int _size = 80);
	String(const String& copyString)	//конструктор копирования(обязательно с конст и с сылкой)
	{
		size = copyString.size;
		str = new char[size + 1];
		strcpy(str, copyString.str);

	}

	void Set();

	void Print();

	~String();

};
