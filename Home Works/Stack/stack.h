#pragma once
#include <iostream>
using namespace std;

class Stack
{
private:
	enum { Empty = -1, Full = 20 }; 
	char* stack;  
	int top;
public:
	Stack(char* _stack, int _top = -1);

	void Push(char ch); 
	char Pop(); 
	void Clear();  
	bool IsEmpty();
	bool IsFull();
	int GetCount();

	~Stack();

};

