#include "deque.h"
#include <iostream>
using namespace std;

Deque::Deque(int size):maxQueueLength(size), queueLength(0), deque(new int[size])
{}

int Deque::Size()
{
	return queueLength;
}

void Deque::Clear()
{
	queueLength = 0;
}

Deque::~Deque()
{
	if (deque)
		delete[]deque;
}

void Deque::PushBack(int value)
{
	deque[queueLength++] = value;
}

int Deque::PopBack()
{
	int help = deque[0];
	for (int i = 1; i < queueLength; i++)
	{
		deque[i - 1] = deque[i];
	}
	deque[queueLength - 1] = help;
	return help;
}

void Deque::PushFront(int value)
{
	for (int i = 0; i < queueLength; i++)
	{
		deque[i] = deque[i + 1];
	}
	deque[queueLength++] = value;
}

int Deque::PopFront()
{
	return 0;
}

int Deque::Front()
{
	return 0;
}

int Deque::Back()
{
	return deque[queueLength-1];
}

bool Deque::IsEmpty()
{
	return queueLength == 0;
}

bool Deque::IsFull()
{
	return queueLength == maxQueueLength;
}

ostream& operator<<(ostream& out, const Deque& deque)
{
	for (int i = 0; i < deque.queueLength; i++)
	{
		out << deque.deque[i] << " | ";
	}
	out << endl;
	return out;
}
