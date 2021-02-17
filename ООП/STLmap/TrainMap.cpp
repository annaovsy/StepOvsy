#include <iostream>
#include <vector>
#include <time.h>
#include <algorithm>
#include <map>
#include <fstream>
using namespace std;

class Train
{
	int number;
	double time;
	string station;
public:
	Train() {};
	Train(int _number, double _time, string _station)
	{
		number = _number;
		time = _time;
		station = _station;
	}
	int GetNumber() const { return number; }
	string GetStation() { return station; }
	double GetTime() { return time; }

	bool operator==(int _number)
	{
		return number == _number;
	}
};

class RailwayStation
{
	map<int, Train> trains;
public:
	void Add(const Train& train)
	{
		trains.insert(make_pair(train.GetNumber(), train));
	}
	void Show()
	{
		auto ptr = trains.begin();
		while (ptr != trains.end())
		{
			Train* train = &ptr->second;
			cout << "Number: " << train->GetNumber() << "Station: " << train->GetStation() << endl;
		}
		
	}
	bool Find(int number, Train& outTrain)
	{
		auto ptrTrain = find(trains.begin(), trains.end(), number); //алгоритм find
		if (ptrTrain != trains.end())
		{
			outTrain = *ptrTrain;
			return true;
		}
		return false;
		/*vector<Train>::iterator ptrTrain = trains.begin();
		while (ptrTrain != trains.end())
		{
			if (number == ptrTrain->GetNumber())
			{
				outTrain = *ptrTrain;
				return true;
			}
			++ptrTrain;
		}
		return false;*/
	}
	bool SaveFile(const char* filename)
	{
		ofstream fileOut(filename, ios::out); //вывод в файл
		if (!fileOut.is_open())
			return false;
		vector<Train>::iterator ptrTrain = trains.begin();
		while (ptrTrain != trains.end())
		{
			fileOut << ptrTrain->GetNumber()
				<< ptrTrain->GetStation()
				<< ptrTrain->GetTime() << endl;
			++ptrTrain;
		}
		fileOut.close();
		return true;
	}
	bool ReadFile(const char* filename)
	{
		ifstream fileIn(filename, ios::in);
		if (!fileIn.is_open())
			return false;
		trains.clear();
		while (!fileIn.eof()) //eof возвращает когда конец файла 
		{
			int number;
			double time;
			string station;
			fileIn >> number >> time;
			fileIn >> station;
			if (number != 0)
			{
				Train temp(number, time, station);
				trains.push_back(temp);
			}
		}
		fileIn.close();
		return true;
	}
};

int main()
{
	

}
