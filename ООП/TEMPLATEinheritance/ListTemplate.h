#pragma once
#include <iostream>
using namespace std;

//template <class T>
struct Node
{
	int value;
	Node* next;
	Node* prev;
};

//template <class T>
class ListTemplate
{
protected:
	Node* head, * tail;

public:
	virtual void Push(int val);
	virtual bool Pop(int &val) = 0;

};

//template <class T>
class Stack : public ListTemplate
{

public:
	bool Pop(int& val)
	{
		if (!head)
			return false;
		Node* temp = head;
		head = head->next;
		head->prev = nullptr;
		int tempVal = temp->value;
		delete temp;
		val = tempVal;
		return true;
	}
};

//template <class T>
class Queue :public ListTemplate
{
public:
	bool Pop(int& val)
	{
		if (!head)
			return false;
		Node* temp = tail;
		tail = tail->prev;
		tail->next = nullptr;
		int tempVal = temp->value;
		delete temp;
		val = tempVal;
		return true;
	}
};

