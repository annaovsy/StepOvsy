#pragma once
#include <iostream>
#include <string>
#include <fstream>
#include <time.h>
using namespace std;

class Logger
{
private:
	ofstream* fObj;
	Logger(const char* filename)
	{
		fObj = new ofstream("logsingleton.txt");
	};
	~Logger()
	{
		fObj->close();
		if (instance)
			delete[]instance;
	}
	static Logger* instance;
public:
	static Logger* getInstance()
	{
		if (instance == nullptr)
			instance = new Logger("logsingleton.txt");

		return instance;
	}
	void PutMsg(string message)
	{
		const time_t timer = time(NULL);
		//ofstream fObj("logsingleton.txt", ios::app);
		if (!(*fObj)) {
			cout << "\nError with file\n";
			exit(EXIT_FAILURE);
		}
		*fObj << message.c_str() << "\t" << ctime(&timer) << endl;
		
	}


};