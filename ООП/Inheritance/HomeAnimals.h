#pragma once
#include <iostream> 
using namespace std;

class Animal
{
private:
	string name;

public:
	Animal(string _name) : name(_name) {}
	void ShowName() { cout << "Name : " << name << endl; }
};

class Dog : public Animal
{
	string type;

public:
	Dog(string _name, string _type) :Animal(_name), type{ _type } {}

	void ShowDog()
	{
		ShowName();
		cout << " Type : " << type << endl << endl;
	}

};

class Cat : public Animal
{
	string color;
public:
	Cat(string _name, string _color) :Animal(_name), color{ _color } {}
	void ShowCat()
	{
		ShowName();
		cout << " Color : " << color << endl << endl;
	}

};

class Parrot : public Animal
{
	bool canSpeak;
public:
	Parrot(string _name, bool _canSpeak) :Animal(_name), canSpeak{ _canSpeak } {}
	void ShowParrot()
	{
		ShowName();
		cout << " Parrot can speak? Is " << canSpeak << endl << endl;
	}
};
