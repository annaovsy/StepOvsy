#include "BidirectionalLists.h"
#include <iostream>
using namespace std;

Node* BidirectionalList::CreateNode(int value)
{
	Node* newNode = new Node; //¬ыдел€ем пам€ть под новый узел
	newNode->value = value;
	newNode->next = NULL;	//ссылка на следующий узел пока NULL
	newNode->prev = NULL;
	return newNode;
}

BidirectionalList::BidirectionalList(const BidirectionalList& CopyList)
{
	count = 0;
	head = NULL;
	tail = NULL;
	if (CopyList.head == NULL)
	{
		return;
	}
	
	Node* temp = CopyList.head; //копируем указатель на голову
	for (int i = 0; i < CopyList.count; i++)
	{
		AddToTail(temp->value);
		temp = temp->next;
	}
}

void BidirectionalList::AddToHead(int value)
{
	Node* newNode = CreateNode(value);
	count++;

	if (head == NULL)
	{
		head = tail = newNode;
		return;
	}

	newNode->next = head;
	head->prev = newNode;
	head = newNode;
}

void BidirectionalList::AddToTail(int value)
{
	Node* newNode = CreateNode(value);
	count++;

	if (head == NULL)
	{
		head = tail = newNode;
		return;
	}

	newNode->prev = tail;
	tail->next = newNode;
	tail = newNode;
}

Node* BidirectionalList::operator[](int index)
{
	if (index < 0 || index >= count)
	{
		return NULL;
	}
	int middle = count / 2;
	
	Node* temp;
	if (index < middle)
	{
		temp = head;
		for (int i = 0; i < index; i++)
		{
			temp = temp->next;
		}
		return temp;
	}
	temp = tail;
	for (int i = 0; i < count - index - 1; i++)
	{
		temp = temp->prev;
	}
	return temp;
}

ostream& operator<<(ostream& out, const BidirectionalList& list)
{
	Node* temp = list.head;
	while (temp != NULL)
	{
		out << temp->value << "\t";
		temp = temp->next;	
	}
	out << endl;
	return out;
}
