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
	BidirectionalList(const BidirectionalList&); //����������� �����������
	void AddToHead(int);
	void AddToTail(int);
	//void RemoveFromHead();
	//void RemoveFromTail();	

	//int FindFirstByValue(int); //������� ������
	//void Sort();			  //������� ��� ���������� ������
	//BidirectionalList operator - ();		 //������� ��� �������������� ������

	Node* operator [] (int);
	friend ostream& operator << (ostream&, const BidirectionalList&);
	
	//~BidirectionalList();
};