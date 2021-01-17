#pragma once
#include <iostream>
using namespace std;

class Overcoat
{
private:
	char* type;
	int size;
	int coast;

public:
	Overcoat(const char* _type = NULL, int _coast = 5);
	void SetType(const char* _type);
	const char* GetType() { return type; };
	Overcoat operator==(const Overcoat& ob2);
	Overcoat operator>(const Overcoat& ob2);
	Overcoat& operator=(Overcoat& ob2);

	void Print();
	~Overcoat();
};

