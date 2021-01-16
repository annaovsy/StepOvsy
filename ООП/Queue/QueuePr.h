#pragma once
#include <iostream>
using namespace std;

class QueuePriority
{
private:
	int* queue;
	int* priority;
	int maxQueueLength;
	int queueLength;

public:
	QueuePriority(int maxSize = 10);	
	~QueuePriority();
	void Clear();
	void Push(int, int);	//добавление
	bool Pop(int&, int&);		//удаление
	bool IsEmpty();
	bool IsFull();
	int GetCount();	// количество элементов в очереди

	friend ostream& operator << (ostream&, const QueuePriority&);
};