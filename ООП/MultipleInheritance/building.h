#pragma once
#include <iostream>
using namespace std;

class Building
{
	int floors;
	int rooms;
	int areaOf​Rooms;

public:
	Building(int _floors, int _rooms, int _areaOf​Rooms) :
		floors(_floors), rooms(_rooms), areaOf​Rooms(_areaOf​Rooms)
	{}
	void ShowBuilding()
	{
		cout << "floors = " << floors << endl;
		cout << "rooms = " << rooms << endl;
		cout << "area of rooms = " << areaOf​Rooms << endl;
	}
};

class House : public Building
{
	int bathroom;
	int bedroom;

public:
	House(int _floors, int _rooms, int _areaOf​Rooms, int _bathroom, int _bedroom) :
		Building(_floors, _rooms, _areaOf​Rooms), bathroom(_bathroom), bedroom(_bedroom) {}

	void ShowHouse()
	{
		ShowBuilding();
		cout << "bathroom = " << bathroom << endl;
		cout << "bedroom = " << bedroom << endl << endl;
	}
};

class Office :public Building
{
	int fireExenguisher;
	int	telephone;

public:
	Office(int _floors, int _rooms, int _areaOf​Rooms, int _fireExenguisher, int	_telephone) :
		Building(_floors, _rooms, _areaOf​Rooms), fireExenguisher(_fireExenguisher), telephone(_telephone) {}

	void ShowOffice()
	{
		ShowBuilding();
		cout << "fire Exenguisher = " << fireExenguisher << endl;
		cout << "telephone = " << telephone << endl << endl;
	}

};
