#include "QueuePr.h"
#include <iostream>
using namespace std;

QueuePriority::QueuePriority(int maxSize):
	maxQueueLength(maxSize), 
	queueLength(0),
	queue(new int[maxSize]), 
	priority(new int[maxSize])
{}

QueuePriority::~QueuePriority()
{
	if(queue)
		delete[]queue;

	if (priority)
		delete[]priority;
}

void QueuePriority::Clear()
{
	queueLength = 0;
}

void QueuePriority::Push(int _queue, int _priority)
{
	if (IsFull())
		return;

	queue[queueLength] = _queue;
	priority[queueLength] = _priority;
	queueLength++;
}

bool QueuePriority::Pop(int& value, int& _priority)
{
	if (IsEmpty())
		return false;

	int maxPri = priority[0];
	int posMaxPri = 0;
	//находим индекс и позицию первого макс приоритета
	for (int i = 1; i < queueLength; i++)
	{
		if (maxPri < priority[i])
		{
			maxPri = priority[i];
			posMaxPri = i;
		}
	}
	//вытаскиваем приоритетный элемент
	value = queue[posMaxPri];
	_priority = priority[posMaxPri];

	for (int i = posMaxPri; i < queueLength - 1; i++)
	{
		queue[i] = queue[i + 1];
		priority[i] = priority[i + 1];
	}
	queueLength--;
	return true;
}

bool QueuePriority::IsEmpty()
{
	return queueLength == 0;
}

bool QueuePriority::IsFull()
{
	return queueLength == maxQueueLength;
}

int QueuePriority::GetCount()
{
	return queueLength;
}

ostream& operator<<(ostream& out, const QueuePriority& queue)
{
	out << "Max size queue = " << queue.maxQueueLength << endl;
	for (int i = 0; i < queue.queueLength; i++)
	{
		out << queue.queue[i] << " [ " << queue.priority[i] << " ] " << endl;
	}
	return out;
}
