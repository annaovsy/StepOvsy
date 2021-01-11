#pragma once
#include <iostream>
using namespace std;

class Time
{
private:
	const int maxHours = 24;
	const int maxSecMinuts = 60;
	int seconds;
	int minuts;
	int hours;

public:
	Time(int _seconds = 0, int _minuts = 0, int _hours = 0);
	Time operator ++();
	friend ostream& operator<<(ostream&, const Time&);
	void CorrectTime();

	void Print();
};
