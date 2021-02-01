#pragma once
#include<iostream>
using namespace std;

class Figure
{
//	double a, b;
//
//public:
//	//Figure(double _a, double _b) : a(_a), b(_b) {};
//	//void SetA(double _a) { a = _a; }
//	//void SetB(double _b) { b = _b; }
//	//double GetA() { return a; }
//	//double GetB() { return b; }

	virtual double GetArea()
	{
		cout << "!!!figure!!!";
		return 0.0;
	}
};

class Rectangle :public Figure
{
	double a, b;
public:
	Rectangle(double _a, double _b) : a(_a), b(_b) {};

	double GetArea()
	{
		cout << "a * b = " << a * b << endl;
	}
};

class Circle :public Figure
{
	double pi = 3.14;
	double r;

public:
	Circle(double _r) : r(_r) {};

	double GetArea()
	{
		cout << "Pi * r^2 = " << pi * r * r << endl;
	}
};

class Triangle :public Figure
{
	double h;
	double s;

public:
	Triangle(double _h, double _s) : h(_h), s(_s) {};

	double GetArea()
	{
		cout << "(h * s)/2 = " << (h * s) / 2 << endl;
	}
};
