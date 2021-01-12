#pragma once
#include <iostream>
using namespace std;

class Steck
{
private:
	enum{Empty = -1, Full = 20}; //нижняя и верхняя границы стека

	int st[Full + 1];  //массив для хранения данных

	int top;  // указатель на вершину стека

public:
	Steck();

	void Push(char c); // добавление элемента
	char Pop();  //извлечение элемента
	void Clear();  // очистка стека
	bool IsEmpty();  // проверка существования элементов в стеке
	bool IsFull();
	int GetCount();  //количество элементов в стеке




};
