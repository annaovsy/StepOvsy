#pragma once
#include <iostream>
using namespace std;

template<typename T> //с помощью шаблона создаем контейнер
struct Node
{
	T data;	//информация
	Node* Next;	//указатель на след. элемент списка
};
template<class T>
class List
{
private:
	Node<T>* head;	//указатель на первый узел
	Node<T>* tail; // на последний узел
	int count;	//количество элементов в списке

	Node<T>* CreateNode(int);

public:
	List(); //конструктор создает пустой список 
	void AddToHead(int);
	void AddToTail(int);
	void RemoveFromHead();
	void RemoveFromTail();

	void AddToIndex(int, int); //добавление по индексу
	void RemoveByIndex(int); //удаляем по индексу

	void PrintList();

	//~List();

};
