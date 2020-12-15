#include "date.h"
#include <iostream>
using namespace std;

int main()
{
	Date date(15, 10, 2015)/*, date2(4, 6, 2012)*/;
	//date.Print();
	//Date result1 = date - date2;
	//result1.Print();
	//Date result2 = date * date2;
	//result2.Print();

	Date result3 = date + 365;
	result3.Print();
}