#pragma once
#include <iostream>
using namespace std;

class FileManager
{
public:
	static void RenameFile(const char* oldName, const char* newName)
	{
		if (rename(oldName, newName) != 0)
		{
			string message = "Cannot rename file ";
			message += oldName;
			throw message;
		}
	}

	static void RemoveFile(const char* name)
	{
		if (remove(name) != 0)
		{
			string message = "Cannot rename file ";
			message += name;
			throw message;
		}
	}

	static void Copy(const char* source, const char* destanation)
	{
		FILE* fSrc, * fDst;
		fSrc = fopen(source, "rb");
		if (!fSrc)
		{
			string message = "Cannot open file ";
			message += source;
			throw message;
		}
		fDst = fopen(destanation, "wb");
		if (!fDst)
		{
			string message = "Cannot open file ";
			message += destanation;
			fclose(fSrc);
			throw message;
		}

		struct stat fSt;
		stat(source, &fSt);
		char* data = new char[fSt.st_size];

		fread(data, fSt.st_size, 1, fSrc);
		fwrite(data, fSt.st_size, 1, fDst);

		fclose(fSrc);
		fclose(fDst);

		delete[] data;
	}

	static void Move(const char* source, const char* destanation)
	{
		Copy(source, destanation);
		RemoveFile(source);
	}

};
