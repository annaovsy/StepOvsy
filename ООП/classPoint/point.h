#pragma once
#include <iostream>
#include <fstream>
using namespace std;

class Point
{
private:
	double x = 0;
	double y = 0;
	double z = 0;

public:
	Point(double _x = 0, double _y = 0, double _z = 0);

	double GetX() { return x; }
	double GetY() { return y; }
	double GetZ() { return z; }

	void SetX(double _x)
	{
		if (x == _x)
			return;
		x = _x;
	}
	void SetY(double _y)
	{
		if (y == _y)
			return;
		y = _y;
	}
	void SetZ(double _z)
	{
		if (z == _z)
			return;
		z = _z;
	}

	void Print();
	void SaveToFile(ofstream& file);


	~Point();
};