#include "Fraction.h"
#include <iostream>
using namespace std;

int main()
{
	Fraction fr1(5, 5, 8);
	Fraction fr2(4, 4, 8);
	Fraction res = fr1 + fr2;
	Fraction res2 = fr1 - fr2;
	Fraction res3 = fr1 * fr2;
	Fraction res4 = fr1 / fr2;
	res.Print();
	res2.Print();
	res3.Print();
	res4.Print();

}