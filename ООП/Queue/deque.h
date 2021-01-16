#pragma once
#include <iostream>
using namespace std;

class Deque
{
private:
	int* deque;
	int maxQueueLength; 
	int queueLength;
	
public:
	Deque(int size = 10);
	~Deque();

	void PushBack(int);
	int PopBack();
	void PushFront(int);
	int PopFront();

	int Front();
	int Back();

	bool IsEmpty();
	bool IsFull();

	int Size();
	void Clear();

	friend ostream& operator <<(ostream&, const Deque&);
};
