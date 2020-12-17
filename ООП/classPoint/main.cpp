#include "point.h"
#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	//Точка

	ifstream file("points.txt");
	if (!file.is_open())
	{
		cout << "Файл не открыт" << endl;
		return -1;
	}

	int countStr = 0;
	char* buffer = new char[256];
	string str;
	while (getline(file, str))
	{
		countStr++;
	}
	cout << countStr << endl;
	file.close();

	int* digits = new int[countStr];
	string str;
	int i = 0;
	file.open("points.txt");
	while (getline(file, str))
	{
		digits[i] = atoi(str.c_str());
	}
	cout << countStr << endl;
	file.close();


	//point.Print();
	//point.SetX(1);
	//point.GetX();
	//point.Print();

}