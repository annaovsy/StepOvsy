#pragma once

class Component
{
public:
	void Execute() {};
};

class Leaf
{
public:
	void Execute() {};
};

class Composite: public Component
{
private:
	Component* children;
public:
	Component* add();
	Component* remove();
	Component* getChildren();
	void Execute() {};
};