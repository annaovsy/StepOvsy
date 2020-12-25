#include "airplane.h"
#include <iostream>

Airplane::Airplane(string _model, int _number, int _passengerCount, double _fuel, int _team)
	: model{ _model }, number{ _number }, passengerCount{ _passengerCount }, fuel{ _fuel }, team{ _team }
{};

Airplane::Airplane(int _passengerCount) :
	Airplane("Boeing", 747, _passengerCount, 300.0, 6)
{}

Airplane::Airplane(string _model) : model{_model}
{}

bool Airplane::operator==(const Airplane& plane)
{
	return this->model == plane.model && this->number == plane.number;
}

bool Airplane::operator>(const Airplane& plane)
{
	return passengerCount > plane.passengerCount;
}

bool Airplane::operator<(const Airplane& plane)
{
	return !(*this > plane);
}

Airplane Airplane::operator++()
{
	passengerCount++;
	return *this;
}

Airplane Airplane::operator--()
{
	passengerCount--;
	return *this;
}

Airplane Airplane::operator++(int)
{
	Airplane copy = *this;
	passengerCount++;
	return copy;
}

Airplane Airplane::operator--(int)
{
	Airplane copy = *this;
	passengerCount--;
	return copy;
}

var::var(int value)
{
	tip = t_int;
	integ = value;
}

var::var(double value)
{
	tip = t_double;
	doub = value;
}

var::var(string value)
{
	tip = t_string;
	stroka = value;
}

void var::Show()
{
	tip == t_int ? cout << integ << endl :
		tip == t_double ? cout << doub << endl :
		cout << stroka << endl;
}

var::~var()
{}
