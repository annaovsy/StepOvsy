#include "list.h"
#include <iostream>
using namespace std;

Node* StackList::CreateNode(int value)
{
	Node* newNode = new Node;
	newNode->data = value;
	newNode->Next = NULL;	
	count++;
	return newNode;
}

StackList::StackList():top(Empty), tail(NULL), count(0), head(NULL)
{}

void StackList::PushS(char value)
{
	Node* newNode = CreateNode(value);

	if (head == NULL)
	{
		head = tail = newNode;
		return;
	}
	tail->Next = newNode;
	tail = newNode;
}

bool StackList::IsEmptyS()
{
	return top == Empty;
}

bool StackList::IsFullS()
{
	return top == Full;
}

void StackList::PrintList()
{
	Node* temp = head;
	
	while (temp != NULL)
	{
		cout << temp->data << "\t";
		temp = temp->Next;	
	}
	cout << endl;
}
