#pragma once
#include <iostream>
#include <fstream>
using namespace std;

class Shape
{
public:
	virtual void Show() = 0;
	virtual	void Save(const char* filename) = 0;
};

class Square : public Shape 
{
	double a;
public:
	Square(double _a) : a(_a){};

	void Show()
	{
		cout << "Square S = " << a * a << endl;
	}
	void Save(const char* filename)
	{
		ofstream fileOut(filename, ios::out); 
		fileOut << "Square S = " << a * a << endl;
		fileOut.close();
	}
};

class Rectangle : public Shape
{
	double a, b;
public:
	Rectangle(double _a, double _b) : a(_a), b(_b) {};

	void Show()
	{
		cout << "Rectangle S = " << a * b << endl;
	}
	void Save(const char* filename)
	{
		ofstream fileOut(filename, ios::out);
		fileOut << "Rectangle S = " << a * b << endl;
		fileOut.close();
	}
};

class Circle : public Shape
{
	double pi = 3.14;
	double r;

public:
	Circle(double _r) : r(_r) {};

	void Show()
	{
		cout << "Circle S = " << pi * r * r << endl;
	}
	void Save(const char* filename)
	{
		ofstream fileOut(filename, ios::out);
		fileOut << "Circle S = " << pi * r * r << endl;
		fileOut.close();
	}
};

class Ellipse : public Shape
{
	double pi = 3.14;
	double a, b;

public:
	Ellipse(double _a, double _b) : a(_a), b(_b) {};

	void Show()
	{
		cout << "Ellipse S = " << pi * a * b << endl;
	}
	void Save(const char* filename)
	{
		ofstream fileOut(filename, ios::out);
		fileOut << "Ellipse S = " << pi * a * b << endl;
		fileOut.close();
	}
};
