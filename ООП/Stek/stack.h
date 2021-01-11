#pragma once
#include <iostream>
using namespace std;

class Steck
{
private:
	enum{Empty = -1, Full = 20}; //������ � ������� ������� �����

	int st[Full + 1];  //������ ��� �������� ������

	int top;  // ��������� �� ������� �����

public:
	Steck();

	void Push(char c); // ���������� ��������
	char Pop();  //���������� ��������
	void Clear();  // ������� �����
	bool IsEmpty();  // �������� ������������� ��������� � �����
	bool IsFull();
	int GetCount();  //���������� ��������� � �����




};
