#include "queue.h"
#include <iostream>
using namespace std;

QueueRing::QueueRing(int size) : MaxQueueLength(size), wait(new int[size])
{}

QueueRing::~QueueRing()
{
	if (wait)
		delete[]wait;
	QueueLength = 0;
}

ostream& operator<<(ostream& out, const QueueRing& queue)
{
	for (int i = 0; i < queue.QueueLength; i++)
	{
		out << queue.wait[i] << " | ";
	}
	out << endl;
	return out;
}

ostream& operator<<(ostream& out, const Game& game)
{
	out << "_______________________" << endl;
	for (int i = 0; i < game.countWaits; i++)
	{
		out << game.waits[i] << endl;
	}
	out << "_______________________" << endl;
	return out;
}

void QueueRing::Push(int value)
{
	if (!IsFull())
		wait[QueueLength++] = value;
}

bool QueueRing::Pop()
{
	if(IsEmpty())
		return false;

	int help = wait[0];
	for (int i = 1; i < QueueLength; i++)
	{
		wait[i - 1] = wait[i];
	}
	wait[QueueLength - 1] = help;	
}

void QueueRing::Clear()
{
	QueueLength = 0;
}

bool QueueRing::IsEmpty()
{
	return QueueLength == 0;
}

bool QueueRing::IsFull()
{
	return QueueLength == MaxQueueLength;
}

int QueueRing::GetCount()
{
	return QueueLength;
}

void Game::FillWaits()
{
	for (int i = 0; i < countWaits; i++)
	{
		int k = 0;
		while (!waits[i].IsFull())
			waits[i].Push(k++);
	}
}

Game::Game(int count) : countWaits(count), waits(new QueueRing[count])
{
	FillWaits();
}

Game::~Game()
{
	delete[]waits;
}

void Game::StartGame()
{
	cout << "Start game!" << endl;
	for (int i = 0; i < countWaits; i++)
	{
		int randomShift = rand() % 100;
		for (int j = 0; j < randomShift; j++)
		{
			waits[i].Pop();
		}
	}
	cout << *this;
	
}
