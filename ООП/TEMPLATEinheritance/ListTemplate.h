#pragma once
#include <iostream>
using namespace std;

template <class T>
struct Node
{
	T value;
	Node* next;
};

template <class T>
class ListTemplate
{
	Node<T>* head, * tail;

public:
	void Push(T val);
	T Pop();

};

template <class T>
class Stack : public ListTemplate<T>
{

public:
	T Pop();
};

template <class T>
class Queue :public ListTemplate<T>
{

};
