#include "string.h"
#include <iostream>
using namespace std;

String::String(char* _str)
{
	size = strlen(_str) + 1;
	str = new char[size];
	strcpy(str, _str);
}

String::String(int _size)
{
	size = _size;
	str = new char[_size];
}

void String::Print()
{
	cout << str << endl;
}

String::~String()
{
}

void String::Set()
{
	cout << "String: ";
	cin >> str;
}


