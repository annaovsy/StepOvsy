#pragma once
#include <iostream>
using namespace std;

struct Node
{
	int value;
	Node* prev;
	Node* next;	
};

class BidirectionalList
{
private:
	Node* head = NULL;
	Node* tail = NULL;
	int count = 0;

	Node* CreateNode(int);

public:
	BidirectionalList() {}; 
	BidirectionalList(const BidirectionalList&); //конструктор копирования
	void AddToHead(int);
	void AddToTail(int);
	//void RemoveFromHead();
	//void RemoveFromTail();	

	//int FindFirstByValue(int); //функция поиска
	//void Sort();			  //функция для сортировки списка
	//BidirectionalList operator - ();		 //функция для инвертирования списка

	Node* operator [] (int);
	friend ostream& operator << (ostream&, const BidirectionalList&);
	
	//~BidirectionalList();
};