#pragma once
#include <iostream>
using namespace std;

class Date
{
private:
	int _day;
	int _month;
	int _year;
public:
	Date();
	Date(int day, int month, int year);

	Date operator-(const Date& d);

	Date operator*(const Date& c);
	Date operator+(int a);
	void Print();

};