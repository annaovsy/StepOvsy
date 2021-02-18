#pragma once
#include <iostream>
using namespace std;

class FileManager
{
	string fullName;
	string position;
	int id;
public:
	FileManager(string _fullName, string _position, int _id);	
	bool SaveToFile(const char* filename);
	bool ReadToFile(const char* filename);
	static void RenameFile(const char* oldName, const char* newName);
	static void RemoveFile(const char* filename);
	static void DirFile();
	void Copy(const char* source, const char* destanation);

	void Show();
};
//■ показывать содержимое дисков;				
//■ создавать папки / файлы;					есть	
//■ удалять папки / файлы;						есть
//■ переименовывать папки / файлы;				есть
//■ копировать / переносить папки / файлы;		есть
//■ вычислять размер папки / файла;
//■ производить поиск по маске					есть
