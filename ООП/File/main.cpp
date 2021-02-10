#define _CRT_SECURE_NO_WARNINGS
#include "file.h"
#include <iostream>
using std::string;
using namespace std;

class Student //�� �
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
			FILE* file = fopen(filename, "w"); //��������� ����
			if (!file)
				return false;
			fprintf(file, "���\t�������\t������� ���\n");  //������ ������ � ����
			fprintf(file, "%s\t%d\t%.2lf\n", name.c_str(), age, averMark);

			fclose(file); //��������� ����

			return true;
		}
		else
		{
			FILE* file = fopen(filename, "wb"); //��������� ����
			if (!file)
				return false;
			int countBytes = name.size();
			fwrite(&countBytes, sizeof(int), 1, file);
			fwrite(name.c_str(), name.size(), 1, file); //��� ��������, ������� ��������, � ����� ����������, ����
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
			FILE* file = fopen(filename, "r"); //��������� ����
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

			FILE* file = fopen(filename, "rb"); //��������� ����
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
		std::cout << "���\t�������\t������� ���\n\n";
		std::cout << name << "\t" << age << "\t" << averMark;
	}

};

int main(int argc, char* argv[])   //argc - ���������� ���������� ��������� ������
{
	setlocale(LC_ALL, "rus");
	Student st("Petrov", 22, 7.4545);
	//st.SaveStudentToFile("Test.txt"); //��������� ����
	st.SaveStudentToFile("Test2", true); //�������� ����
	Student st2;
	st2.ReadFile("Test2", true);
	st2.Print();
	//if (argc != 3)
	//{
	//	cout << "������������ ������ ������" << endl;
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
