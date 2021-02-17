#pragma once
#include <iostream>
#include <vector>
using namespace std;

class RailwayStation
{
	int number;
	double time;
	string station;

public:
	RailwayStation(int _number)
	{
		number = _number;
	}
	RailwayStation(double _time)
	{
		time = _time;
	}
	RailwayStation(string _station)
	{
		station = _station;
	}

	int GetNumber()const { return number; }
	double GetTime()const { return time; }
	string GetStation()const { return station; }
};

void ShowNumber(const vector<RailwayStation>& vect)
{
	cout << "ShowNumber" << endl;
	vector<RailwayStation>::const_iterator ptr = vect.begin();
	while (ptr != vect.end()) 
	{
		cout << ptr->GetNumber() << " ";
		++ptr;
	}
	cout << endl;
}
void ShowTime(const vector<RailwayStation>& vect)
{
	cout << "ShowTime" << endl;
	vector<RailwayStation>::const_iterator ptr = vect.begin();
	while (ptr != vect.end())
	{
		cout << ptr->GetTime() << " ";
		++ptr;
	}
	cout << endl;
}
void ShowStation(const vector<RailwayStation>& vect)
{
	cout << "ShowStation" << endl;
	vector<RailwayStation>::const_iterator ptr = vect.begin();
	while (ptr != vect.end())
	{
		cout << ptr->GetStation() << " ";
		++ptr;
	}
	cout << endl;
}

