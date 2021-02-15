#include <iostream>
#include <vector>
#include <time.h>
#include <algorithm>
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
	int GetNumber() { return number; }
	string GetStation() { return station; }
	double GetTime() { return time; }
};

class RailwayStation
{
	vector<Train> trains;

public:
	void Add(const Train& train)
	{
		trains.push_back(train);
	}
	void Show()
	{
		vector<Train>::iterator ptrTrain = trains.begin();
		while (ptrTrain != trains.end())
		{
			cout << "Number: " << ptrTrain->GetNumber() 
				 <<" Station: " << ptrTrain->GetStation() << endl;
			++ptrTrain;
		}
		cout << endl;
	}
	bool Find(int number, Train& outTrain)
	{
		vector<Train>::iterator ptrTrain = trains.begin();
		while (ptrTrain != trains.end())
		{
			if (number == ptrTrain->GetNumber())
			{
				outTrain = *ptrTrain;
				return true;
			}
			++ptrTrain;
		}
		return false;
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
	RailwayStation station;
	Train train1(1, 12345.678, "Rostov");
	Train train2(2, 1234.6, "Moscow");
	Train train3(3, 12.998, "Volgograd");
	station.Add(train1);
	station.Add(train2);
	station.Add(train3);
	station.Show();
	Train temp;
	if (station.Find(3, temp))
	{
		cout << "Number " << temp.GetNumber()
			<< " Station " << temp.GetStation()
			<< " Time " << temp.GetTime() << endl;
	}

	station.SaveFile("Station.txt");

	RailwayStation station2;
	if (station2.ReadFile("Station.txt"))
	{
		cout << "Read ok" << endl;
		station2.Show();
	}

}
