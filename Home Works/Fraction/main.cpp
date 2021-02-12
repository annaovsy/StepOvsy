#include "Fraction.h"
#include <iostream>
using namespace std;

int main()
{
	Fraction fr1(1, 3, 8);
	Fraction fr2(1, 3, 8);
	Fraction res = fr1 + fr2;
	res.Print();




}