#include "overcoat.h"
#include <iostream>
using namespace std;

Overcoat::Overcoat(const char* _type, int _coast) : coast(_coast)
{
	size = strlen(_type) + 1;
	type = new char[size];
	strcpy_s(type, size, _type);
}

void Overcoat::SetType(const char* _type)
{
	if (_type == NULL)
		return;

	strcpy_s(type, size, _type);
}

Overcoat Overcoat::operator==(const Overcoat& ob2)
{
	if (type == ob2.type)
		return *this;
}

Overcoat Overcoat::operator>(const Overcoat& ob2)
{
	if (coast > ob2.coast)
		return *this;
}

//Overcoat& Overcoat::operator>(Overcoat& ob2)
//{
//	if (coast > ob2.coast)
//		return coast > ob2.coast;
//}

Overcoat& Overcoat::operator=(Overcoat& ob2)
{
	if (type != nullptr)
	{
		delete[]type;
	}
	type = new char[strlen(type) + 1];
	strcpy_s(type, strlen(type) + 1, type);

	type = ob2.type;
	coast = ob2.coast;
	return *this;
}

void Overcoat::Print()
{
	cout << "Тип : " << type << endl;
	cout << "Стоимость : " << coast << endl;
}

Overcoat::~Overcoat()
{
	if (type)
		delete[]type;
}