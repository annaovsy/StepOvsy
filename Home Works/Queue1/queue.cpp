#include "queue.h"
#include <iostream>
using namespace std;

Queue::Queue(int maxSize) :
	maxQueueLength(maxSize),
	queueLength(0),
	queue—lient(new int[maxSize]),
	priority(new int[maxSize]),
	hour(new int[maxSize]),
	minuts(new int[maxSize])
{}

Queue::~Queue()
{
	if (queue—lient)
		delete[]queue—lient;

	if (priority)
		delete[]priority;

	if (hour)
		delete[]hour;

	if (minuts)
		delete[]minuts;
}

void Queue::Clear()
{
	queueLength = 0;
}

void Queue::Push(int _queue—lient, int _priority, int _hour, int _minuts)
{
	if (IsFull())
		return;

	queue—lient[queueLength] = _queue—lient;
	priority[queueLength] = _priority;
	hour[queueLength] = _hour;
	minuts[queueLength] = _minuts;
	queueLength++;
}

bool Queue::Pop(int& value, int& _priority)
{
	if(IsEmpty())
		return false;

	int maxPri = priority[0];
	int posMaxPri = 0;

	for (int i = 1; i < queueLength; i++)
	{
		if (maxPri < priority[i])
		{
			maxPri = priority[i];
			posMaxPri = i;
		}
	}
	
	value = queue—lient[posMaxPri];
	_priority = priority[posMaxPri];

	for (int i = posMaxPri; i < queueLength - 1; i++)
	{
		queue—lient[i] = queue—lient[i + 1];
		priority[i] = priority[i + 1];
	}
	queueLength--;
	return true;
}

bool Queue::IsEmpty()
{
	return queueLength == 0;
}

bool Queue::IsFull()
{
	return queueLength == maxQueueLength;
}

int Queue::GetCount()
{
	return queueLength;
}

ostream& operator<<(ostream& out, const Queue& queue)
{
	for (int i = 0; i < queue.queueLength; i++)
	{
		out << queue.queue—lient[i] << " [ " << queue.priority[i] << " ] "
			<< "  " << queue.hour[i] << " : " << queue.minuts[i] << endl;
	}
	out << endl;
	return out;
}
