#pragma once
#include <iostream>
using namespace std;

struct Node
{
	int data;
	Node* Next;
};

class StackList
{
private:
	Node* head;
	Node* tail; 
	int count;	

	Node* CreateNode(int);

	enum { Empty = -1, Full = 20 }; 
	int st[Full + 1];  
	int top;

public:
	StackList();

	void PushS(char value); 
	//char PopS();  
	//void ClearS();  
	bool IsEmptyS();  
	bool IsFullS();
	//int GetCountS();  

	void PrintList();
};
