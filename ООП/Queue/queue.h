#pragma once
#include <iostream>
using namespace std;

class QueueRing	//кольцевая очередь
{
private:
	int* wait;  //очередь
	int MaxQueueLength;  // максимальный размер очереди
	int QueueLength = 0;  //текущий размер очереди

public:
	QueueRing(int size = 5);
	~QueueRing();

	void Push(int value); //добавление
	bool Pop();	//извлечение
	void Clear();
	bool IsEmpty();
	bool IsFull();
	int GetCount(); //количество элементов
	
	friend ostream& operator <<(ostream&, const QueueRing&);

};

class Game
{
private:
	int countWaits = 3;
	QueueRing* waits;

	void FillWaits();
public:
	Game(int);
	~Game();

	void StartGame();

	friend ostream& operator <<(ostream&, const Game&);
};
