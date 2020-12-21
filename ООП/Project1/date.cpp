#include "date.h"
#include <iostream>
using namespace std;

Date::Date()
{
	_day = 1;
	_month = 1;
	_year = 2005;
}

Date::Date(int day, int month, int year)
{
	_day = day;
	_month = month;
	_year = year;
}

Date Date::operator-(const Date& d)
{
	Date temp;
	temp._day = _day - d._day;
	temp._month = _month - d._month;
	temp._year = _year - d._year;
	return temp;
}

Date Date::operator*(const Date& c)
{
	Date temp;
	temp._day = _day * c._day;
	temp._month = _month * c._month;
	temp._year = _year * c._year;
	return temp;
}

Date Date::operator+(int a)
{
	int years = _year + a / 365;
	int month = _month + (a % 365) / 30;
	int days = _day + (a % 365) % 30;

	return Date(days, month, years);
}

void Date::Print()
{
	cout <<"Day : "<< _day << endl;
	cout << "Month : " << _month << endl;
	cout << "Year : " << _year << endl;
}
