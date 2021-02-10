#define _CRT_SECURE_NO_WARNINGS
#include "file.h"
#include <iostream>
using std::string;
using namespace std;

class Student //на С
{
	string name;
	int age;
	double averMark;

public:
	Student() {};
	Student(string _name, int _age, double _averMark)
	{
		name = _name;
		age = _age;
		averMark = _averMark;
	}
	bool SaveStudentToFile(const char* filename, bool isBinaty = false)
	{
		if (!isBinaty)
		{
			FILE* file = fopen(filename, "w"); //открываем файл
			if (!file)
				return false;
			fprintf(file, "Имя\tВозраст\tСредний бал\n");  //запись ьекста в файл
			fprintf(file, "%s\t%d\t%.2lf\n", name.c_str(), age, averMark);

			fclose(file); //закрываем файл

			return true;
		}
		else
		{
			FILE* file = fopen(filename, "wb"); //открываем файл
			if (!file)
				return false;
			int countBytes = name.size();
			fwrite(&countBytes, sizeof(int), 1, file);
			fwrite(name.c_str(), name.size(), 1, file); //что записать, сколько записать, в каком количестве, куда
			fwrite(&age, sizeof(age), 1, file);
			fwrite(&averMark, sizeof(averMark), 1, file);
			fclose(file);
			return true;
		}
	}

	bool ReadFile(const char* filename, bool isBinaty = false)
	{
		if (!isBinaty)
		{
			FILE* file = fopen(filename, "r"); //открываем файл
			if (!file)
				return false;
			char str[256];
			fgets(str, 256, file);

			fscanf(file, "%s%d%lf", str, &age, &averMark);
			name = str;

			fclose(file);
			return true;
		}
		else
		{

			FILE* file = fopen(filename, "rb"); //открываем файл
			if (!file)
				return false;
			char str[256];
			int countBytes;
			fread(&countBytes, sizeof(countBytes), 1, file);
			fread(str, countBytes, 1, file);
			str[countBytes] = 0;
			name = str;
			fread(&age, sizeof(age), 1, file);
			fread(&averMark, sizeof(averMark), 1, file);

			fclose(file);
			return true;
		}

	}

	void Print()
	{
		std::cout << "Имя\tВозраст\tСредний бал\n\n";
		std::cout << name << "\t" << age << "\t" << averMark;
	}

};

int main(int argc, char* argv[])   //argc - количество аргументов командной строки
{
	setlocale(LC_ALL, "rus");
	Student st("Petrov", 22, 7.4545);
	//st.SaveStudentToFile("Test.txt"); //текстовый файл
	st.SaveStudentToFile("Test2", true); //бинарный файл
	Student st2;
	st2.ReadFile("Test2", true);
	st2.Print();
	//if (argc != 3)
	//{
	//	cout << "неправильный формат записи" << endl;
	//	return 0;
	//}

	//try
	//{
	//	//FileManager::RenameFile("Test2", "Test123");
	//	//FileManager::RemoveFile("Test123");
	//	//FileManager::Copy("Test.txt", "TestCopy.txt");
	//	FileManager::Move(argv[1], argv[2]);
	//}
	//catch (string msg)
	//{
	//	cout << msg << endl;
	//}

	return 0;
}
