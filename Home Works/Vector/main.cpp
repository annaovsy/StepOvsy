#include <iostream>
#include <vector>
#include "Vector.h"
using namespace std;

int main()
{
	vector <RailwayStation> number;
	for (int i = 0; i < 10; i++)
	{
		RailwayStation temp(rand());
		number.push_back(temp);
	}
	ShowNumber(number);

	vector <RailwayStation> time;
	for (int i = 0; i < 10; i++)
	{
		RailwayStation temp(rand());
		time.push_back(temp);
	}
	ShowTime(time);

	vector <RailwayStation> station;
	for (int i = 0; i < 10; i++)
	{
		RailwayStation temp(rand());
		station.push_back(temp);
	}
	ShowStation(station);

//не поняла ошибку, как нужно добавлять элементы для double и string

}
