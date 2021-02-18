#define _CRT_SECURE_NO_WARNINGS
#include "FileManager.h"
#include <iostream>
#include <io.h> 
#include <fstream>
using namespace std;

FileManager::FileManager(string _fullName, string _position, int _id):
	fullName(_fullName),
	position(_position),
	id(_id)
{}

bool FileManager::SaveToFile(const char* filename)
{
	ofstream fileOut(filename, ios::out); //вывод в файл
	if (!fileOut.is_open())
		return false;
	fileOut << "ФИО\t\t\t" << "Должность:\t" << "ID:" << endl;
	fileOut << fullName <<"\t"<< position << "\t" << id << endl;
	fileOut.close();
	cout << "Файл создан!" << endl << endl;
	return true;
}

bool FileManager::ReadToFile(const char* filename)
{
	ifstream fileIn(filename, ios::in);
	if (!fileIn.is_open())
		return false;
	char header[1000];
	fileIn.getline(header, 1000, '\n');
	fileIn.getline(header, 1000, '\n');
	fileIn >> fullName >> position >> id;
	fileIn.close();
	cout << "Read file!" << endl;
	return true;
}

void FileManager::RenameFile(const char* oldName, const char* newName)
{
	if (rename(oldName, newName) != 0)
	{
		string message = "Error!!! Невозможно переименовать файл ";
		message += oldName;
		throw message;
	}
	else
		cout << "Файл переименован!" << endl << endl;
}

void FileManager::RemoveFile(const char* filename)
{
	if (remove(filename) != 0)
	{
		string message = "Error!!! Невозможно удалить файл ";
		message += filename;
		throw message;
	}
	else
		cout << "Файл удален!" << endl << endl;
}

void FileManager::DirFile()
{
	char mask[10];
	cout << "Введите маску (.txt / .docx  ...)" << endl;
	cin >> mask;
	char path[100];
	cout << "Введите путь: " << endl;
	cin >> path;	
	strcat(path, mask);
	_finddata_t* fileinfo = new _finddata_t;
	long done = _findfirst(path, fileinfo);
	int mayWeWork = done;
	int count = 0;   
	while (mayWeWork != -1)
	{          
		cout << fileinfo->name << endl << endl;
		mayWeWork = _findnext(done, fileinfo);
		count++;
	}    
	cout << "\nВ папке " << path<< " найдено " << count << " файлов." << endl; 
	_findclose(done);   
	delete fileinfo; 
}

void FileManager::Copy(const char* source, const char* destanation)
{
	ReadToFile(source);
	SaveToFile(destanation);
}

void FileManager::Show()
{
	cout << "ФИО: " << fullName << endl;
	cout << "Должность: " << position << endl;
	cout << "ID: " << id << endl;
}
