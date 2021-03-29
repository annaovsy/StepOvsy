#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <io.h> 
#include <fstream>
using namespace std;

void RenameFile(const char* oldName, const char* newName)
{
	if (rename(oldName, newName) != 0)
	{
		string message = "Error!!! Невозможно переименовать файл ";
		message += oldName;
		throw message;
	}
}
int main()
{
	RenameFile("Text.txt","new.txt");




}
