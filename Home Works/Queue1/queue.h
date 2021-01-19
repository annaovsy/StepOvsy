#pragma once
#include <iostream>
using namespace std;

class Queue
{
private:
	int* queue�lient;
	int* hour;
	int* minuts;
	int* priority;
	int maxQueueLength;
	int queueLength;
public:
	Queue(int maxSize = 6);
	~Queue();

	void Clear();
	void Push(int _queue�lient, int _priority, int _hour, int _minuts);	//����������
	bool Pop(int&, int&);		
	bool IsEmpty();
	bool IsFull();
	int GetCount();

	friend ostream& operator << (ostream&, const Queue&);




};
