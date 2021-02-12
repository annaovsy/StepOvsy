#include "Fraction.h"
#include <iostream>
#include <iomanip>
using namespace std;

void Fraction::GetMixedView()
{
	Cancellation();
    GetIntPart();
}

void Fraction::Cancellation()
{
    if (numerator != 0)
    {
        int m = denominator;
        int n = numerator;
        int ost = m % n;
        while (ost != 0)
        {
            m = n; 
            n = ost;
            ost = m % n;
        }
        int nod = n;
        if (nod != 1)
        {
            numerator /= nod; denominator /= nod;
        }
    }
}

void Fraction::GetIntPart()
{
	if (numerator >= denominator)
	{
		intPart += (numerator / denominator);
		numerator %= denominator;
	}
}

Fraction::Fraction(int _intPart, int _numerator, int _denominator):
	intPart(_intPart),
	numerator(_numerator),
	denominator(_denominator)
{
	GetMixedView();
}

void Fraction::Print()
{
    cout << setw(4) << numerator << endl;
    cout << setw(2) << intPart << " - " << endl;
    cout << setw(4) << denominator << endl;
}

Fraction Fraction::operator+(Fraction a)
{
    Fraction result;
    result.numerator = (intPart * denominator + numerator) * a.denominator + (a.intPart * a.denominator + a.numerator) * denominator;
    result.denominator = denominator * a.denominator;
    if (result.numerator < 0)
    {
        result.numerator *= -1;
    }
    result.GetMixedView();
    return result;
}

Fraction Fraction::operator-(Fraction)
{
    return Fraction();
}
