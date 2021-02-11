#pragma once
#include <iostream>
#include <fstream>
using namespace std;

class Student //С++
{
public:
	string name;
	int age;
	double averMark;

	Student() {};
	Student(string _name, int _age, double _averMark)
	{
		name = _name;
		age = _age;
		averMark = _averMark;
	}

	bool SaveToFile(const char* filename, bool isBinary = false)
	{
		if (!isBinary)
		{
			ofstream fileOut(filename, ios::out); //вывод в файл
			if (!fileOut.is_open())
				return false;
			fileOut << "Имя\tВозраст\tСредний бал" << endl;
			fileOut << name << "\t" << age << "\t" << averMark << endl;
			fileOut.close();
			return true;
		}
		else
		{
			ofstream fileOut(filename, ios::binary | ios::app); //для бинарных файлов
			if (!fileOut.is_open())
				return false;
			int countBytes = name.size(); //сколько места занимает имя
			fileOut.write((char*)&countBytes, sizeof(countBytes));
			fileOut.write(name.c_str(), name.size());
			fileOut.write((char*)&age, sizeof(age));
			fileOut.write((char*)&averMark, sizeof(averMark));
			fileOut.close();
			return true;
		}

	}

	bool ReadToFile(const char* filename, bool isBinary = false)
	{
		if (!isBinary)
		{
			ifstream fileIn(filename, ios::in);
			if (!fileIn.is_open())
				return false;
			char header[256];
			fileIn.getline(header, 256, '\n');
			fileIn >> name >> age >> averMark;
			fileIn.close();
			return true;
		}
		else
		{
			ifstream fileIn(filename, ios::in | ios::binary);
			if (!fileIn.is_open())
				return false;
			int countBytes = name.size();
			fileIn.read((char*)&countBytes, sizeof(countBytes));
			char str[256];
			fileIn.read(str, countBytes);
			str[countBytes] = 0;
			name = str;
			fileIn.read((char*)&age, sizeof(age));
			fileIn.read((char*)&averMark, sizeof(averMark));
			fileIn.close();
			return true;
		}
	}
	 
	void Print()
	{
		cout << "Имя\tВозраст\tСредний бал" << endl;
		cout << name << "\t" << age << "\t" << averMark << endl;
	}
};
