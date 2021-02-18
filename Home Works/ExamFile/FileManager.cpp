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
	ofstream fileOut(filename, ios::out); //����� � ����
	if (!fileOut.is_open())
		return false;
	fileOut << "���\t\t\t" << "���������:\t" << "ID:" << endl;
	fileOut << fullName <<"\t"<< position << "\t" << id << endl;
	fileOut.close();
	cout << "���� ������!" << endl << endl;
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
		string message = "Error!!! ���������� ������������� ���� ";
		message += oldName;
		throw message;
	}
	else
		cout << "���� ������������!" << endl << endl;
}

void FileManager::RemoveFile(const char* filename)
{
	if (remove(filename) != 0)
	{
		string message = "Error!!! ���������� ������� ���� ";
		message += filename;
		throw message;
	}
	else
		cout << "���� ������!" << endl << endl;
}

void FileManager::DirFile()
{
	char mask[10];
	cout << "������� ����� (.txt / .docx  ...)" << endl;
	cin >> mask;
	char path[100];
	cout << "������� ����: " << endl;
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
	cout << "\n� ����� " << path<< " ������� " << count << " ������." << endl; 
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
	cout << "���: " << fullName << endl;
	cout << "���������: " << position << endl;
	cout << "ID: " << id << endl;
}
