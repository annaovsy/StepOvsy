#include "flat.h"
#include <iostream>
using namespace std;


Flat::Flat(int _area, int _coast) :area(_area), coast(_coast)
{}

Flat& Flat::operator=(Flat & ob2)
{
	area = ob2.area;
	coast = ob2.coast;
	return *this;
}

void Flat::Print()
{
	cout << "Площадь квартиры : " << area << endl;
	cout << "Стоимость квартиры : " << coast << endl; 
}
