#include "point.h"

Point::Point(double _x, double _y, double _z)
{
	x = _x;
	y = _y;
	z = _z;
	cout << "\nPoint was created" << endl;
}

void Point::Print()
{
	cout << "Point: ( " << x << " , " << y << " , " << z << " )" << endl;
}

void Point::SaveToFile(ofstream& file)
{
	file << x << " " << y << " " << z << endl;
}

Point::~Point()
{
	cout << "\nPoint was destructed" << endl;
}
