#pragma once
#include <iostream>
using namespace std;


class Flat
{
private:
	int area;
	int coast;
public:
	Flat(int _area = 30, int _coast = 1500000);
	Flat operator==(const Flat& ob2);
	Flat operator>(const Flat& ob2);
	Flat& operator=(Flat& ob2);
	void Print();
};
