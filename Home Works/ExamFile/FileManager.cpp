#define _CRT_SECURE_NO_WARNINGS
#include "FileManager.h"
#include <iostream>
#include <io.h> 
#include <fstream>
using namespace std;

FileManager::FileManager(){}

void FileManager::SetFile(string _fullName, string _position, int _id)
{
	fullName = _fullName;
	position = _position;
	id = _id;
}

bool FileManager::SaveToFile(const char* filename)
{
	ofstream fileOut(filename, ios::out); //вывод в файл
	if (!fileOut.is_open())
		return false;
	fileOut << "ФИО\t\t\t" << "Должность:\t" << "ID:" << endl;
	fileOut << fullName <<"\t"<< position << "\t" << id << endl;
	fileOut.close();
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

void Menu()
{
	FileManager file1;
	file1.SetFile("Иванов Иван Иванович", "менеджер", 546482);
	FileManager file2;
	file2.SetFile("Петров Петр Петрович", "директор", 364829);
	cout << "\n\tДобро пожаловать в файловый менеджер!\n\n";
	cout << "\tИнформация о работниках :" << endl;
	file1.Show();
	file2.Show();
	cout << "  Выберите действие:\n\t1 - Записать информацию в файл" << endl;
	cout << "\t2 - Удалить файл" << endl;
	cout << "\t3 - Показать содержимое файла" << endl;
	cout << "\t4 - Переименовать файл" << endl;
	cout << "\t5 - Скопировать файл" << endl;
	cout << "\t6 - Вычислить размер файла" << endl;
	cout << "\t7 - Поиск файла" << endl;
	cout << "\t8 - Выход" << endl;
	while (true)
	{
		int choice;
		cin >> choice;
		try
		{
			if (choice == 1)
			{
				if (file1.SaveToFile("worker1.txt"))
					cout << "Файл worker1.txt создан!" << endl;
				if (file2.SaveToFile("worker2.txt"))
					cout << "Файл worker2.txt создан!" << endl;
			}
			else if (choice == 2)
			{
				cout << "1 - удалить файл worker1.txt\n2 - удалить файл worker2.txt\n";
				int choiceDel;
				cin >> choiceDel;
				if (choiceDel == 1)
					FileManager::RemoveFile("worker1.txt");
				else
					FileManager::RemoveFile("worker2.txt");
			}
			else if (choice == 3)
			{
				cout << "1 - прочитать файл worker1.txt\n2 - прочитать файл worker2.txt\n";
				int choiceRead;
				cin >> choiceRead;
				if (choiceRead == 1)
				{
					file1.ReadToFile("worker1.txt");
					file1.Show();
				}
				else
				{
					file2.ReadToFile("worker2.txt");
					file2.Show();
				}					
			}
			else if (choice == 4)
			{
				cout << "1 - переименовать файл worker1.txt\n2 - переименовать файл worker2.txt\n";
				int choiceRename;
				cin >> choiceRename;
				if (choiceRename == 1)
				{
					FileManager::RenameFile("worker1.txt", "WORKER1.txt");
					cout << "Файл переименован на WORKER1.txt" << endl;
				}
				else
				{
					FileManager::RenameFile("worker2.txt", "WORKER2.txt");
					cout << "Файл переименован на WORKER2.txt" << endl;
				}
			}
			else if (choice == 5)
			{
				file1.Copy("worker1.txt", "new1.txt");
				cout << "Файл скопирован из worker1.txt в new1.txt" << endl;
				file2.Copy("worker2.txt", "new2.txt");
				cout << "Файл скопирован из worker2.txt в new2.txt" << endl;
			}
			else if (choice == 7)
				FileManager::DirFile();
			else if (choice == 8)
			{
				cout << "*****************************" << endl;
				cout << "\tБлагодарим за использование файлового менеджера!\n\tДо свидания!" << endl;
				break;
			}
		}
		catch (string message)
		{
			cout << message << endl;
		}
	}
}

void FileManager::Show()
{
	cout << "ФИО: " << fullName << endl;
	cout << "Должность: " << position << endl;
	cout << "ID: " << id << endl << endl;
}
