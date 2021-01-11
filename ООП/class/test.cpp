#include "test.h"
#include <iostream>
using namespace std;

Time::Time(int _seconds, int _minuts, int _hours)
{
	seconds = _seconds;
	minuts = _minuts;
	hours = _hours;
	CorrectTime();
}

Time Time::operator++()
{
	seconds++;
	CorrectTime();
	return *this;
}

void Time::CorrectTime()
{
	if (seconds >= maxSecMinuts)
	{
		seconds %= maxSecMinuts;
		minuts++;
	}
	if (minuts >= maxSecMinuts)
	{
		minuts %= maxSecMinuts;
		hours++;
	}
	if (hours >= maxHours)
	{
		hours %= maxHours;
	}
}

void Time::Print()
{
	cout << "Hours : " << hours << endl;
	cout << "Minuts : " << minuts << endl;
	cout << "Seconds : " << seconds << endl;
}

ostream& operator<<(ostream& out, const Time& time)
{
	out << time.hours << " - hours | "
		<< time.minuts << " - minuts | "
		<< time.seconds << " - seconds " << endl;
	return out;
}
