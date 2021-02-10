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
		fileOut.write((char*)&count, sizeof(count));
		fileOut.close();
		for (int i = 0; i < count; i++)
		{
			studs[i].SaveToFile(filename, true);
		}
		return true;
	}

	static bool Read(const char* filename, Student* studs, int& count)
	{
		ifstream fileIn(filename, ios::in | ios::binary);
		if (!fileIn.is_open())
			return false;
	
		fileIn.read((char*)&count, sizeof(count));
		for (int i = 0; i < count; i++)
		{
			// studs[i].ReadToFile(filename, true);
			int countBytes ;
			fileIn.read((char*)&countBytes, sizeof(countBytes));
			char str[256];
			fileIn.read(str, countBytes);
			str[countBytes] = 0;
			studs[i].name = str;
			fileIn.read((char*)&studs[i].age, sizeof(studs[i].age));
			fileIn.read((char*)&studs[i].averMark, sizeof(studs[i].averMark));
		}
		fileIn.close();
		return true;
	}

};