#pragma once
#include <iostream>
using namespace std;

class Coord
{
	int x, y;
public:
	Coord() { x = 0; y = 0; }
	Coord(int _x, int _y)
	{
		x = _x;
		y = _y;
	}
	void GetXY(int& _x, int& _y) const
	{
		_x = x;
		_y = y;
	}
	void SetXY(int _x, int _y)
	{
		x = _x;
		y = _y;
	}

	Coord operator+(const Coord& ob)
	{
		Coord temp;
		temp.x = x + ob.x;
		temp.y = y + ob.y;

		return temp;
	}

	Coord operator=(const Coord& ob)
	{
		x = ob.x;
		y = ob.y;

		return *this;
	}
};

class Quard :public Coord
{
	int quadrant;
public:
	Quard() { quadrant = 0; }
	Quard(int x, int y) :Coord(x, y)
	{
		if (x >= 0 && y >= 0)
			quadrant = 1;
		else if (x < 0 && y >= 0)
			quadrant = 2;
		else if (x < 0 && y < 0)
			quadrant = 3;
		else quadrant = 4;
	}
	void Show()
	{
		cout << "Точка в квадрате " << quadrant << endl;
	}
	Quard operator = (const Coord ob)
	{
		int x, y;
		ob.GetXY(x, y);
		SetXY(x, y);

		if (x >= 0 && y >= 0)
			quadrant = 1;
		else if (x < 0 && y >= 0)
			quadrant = 2;
		else if (x < 0 && y < 0)
			quadrant = 3;
		else quadrant = 4;

		return *this;
	}

};

