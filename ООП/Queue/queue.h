#pragma once
#include <iostream>
using namespace std;

class QueueRing	//��������� �������
{
private:
	int* wait;  //�������
	int MaxQueueLength;  // ������������ ������ �������
	int QueueLength = 0;  //������� ������ �������

public:
	QueueRing(int size = 5);
	~QueueRing();

	void Push(int value); //����������
	bool Pop();	//����������
	void Clear();
	bool IsEmpty();
	bool IsFull();
	int GetCount(); //���������� ���������
	
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
