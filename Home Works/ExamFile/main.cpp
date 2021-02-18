#define _CRT_SECURE_NO_WARNINGS
#include "FileManager.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	FileManager w1("Иванов Иван Иванович", "программист", 546482);
	FileManager w2("Петров Иван Иванович", "программист", 546482);
	w1.Show();
	w1.SaveToFile("w1.txt");
	w2.SaveToFile("w2.txt");
	//w1.ReadToFile("w2.txt");
	try
	{
		//FileManager::RenameFile("w1.txt", "www.txt");
		//FileManager::RemoveFile("w.txt");
		w2.Copy("w2.txt", "www.txt");
		//FileManager::DirFile();
	}
	catch (string message)
	{
		cout << message << endl;
	}


}