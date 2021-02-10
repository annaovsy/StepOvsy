#pragma once
#include "Student.h"

class FileStudents
{
public:
	static bool Save(const char* filename, Student* studs, int count)
	{
		ofstream fileOut(filename, ios::out | ios::binary);
		if (!fileOut.is_open())
			return false;
		fileOut.write((char*)&studs, sizeof(studs));
		fileOut.close();
		return true;
	}

	static bool Read(const char* filename, Student* studs, int& count)
	{
		ifstream fileIn(filename, ios::in | ios::binary);
		if (!fileIn.is_open())
			return false;
		fileIn.read((char*)&studs, sizeof(studs));
		fileIn.close();
		return true;
	}

};