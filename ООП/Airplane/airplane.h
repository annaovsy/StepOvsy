#pragma once
#include <iostream>
#include <string.h>
using namespace std;

class var
{
private:
	enum { t_int, t_double, t_string }tip;
	union
	{
		int integ;
		double doub;
		string stroka;
	};
public:
	var(int = 0);
	var(double);
	var(string);
	void Show();

	~var();



};

class Airplane
{
public:
	string model = "Boeing";
	int number = 747;
	int passengerCount = 100;
	double fuel = 300.0;
	int team = 6;

public:
	Airplane(string _model, int _number, int  , double _fuel, int _team);
	Airplane(int _passengerCount = 100);
	Airplane(string _model);

	bool operator==(const Airplane&);
	bool operator>(const Airplane&);
	bool operator<(const Airplane&);
	Airplane operator++();
	Airplane operator--();
	Airplane operator++(int);
	Airplane operator--(int);




};
