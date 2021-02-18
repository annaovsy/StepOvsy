#pragma once
#include <iostream>
using namespace std;

void Menu();

class FileManager
{
	string fullName;
	string position;
	int id;

public:
	FileManager();
	void SetFile(string _fullName, string _position, int _id);
	bool SaveToFile(const char* filename);
	bool ReadToFile(const char* filename);
	static void RenameFile(const char* oldName, const char* newName);
	static void RemoveFile(const char* filename);
	static void DirFile();
	void Copy(const char* source, const char* destanation);	
	void Show();
};
