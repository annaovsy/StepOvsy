#pragma once
#include <iostream>
using namespace std;

void Menu();
int Debit();
int Credit();
void ChoiceCard();
//int ChoiceCards();

//class Card
//{
//public:
//	int sumTotal;
//	virtual void Menu() = 0;
//	virtual void SetRefill() = 0;
//	virtual void SetExpenses() = 0;
//	virtual bool ExpenseReportFile(const char* filename) = 0;
//};

class DebitCard
{
	int productCategory;
	int entertainmentCategory;
	int travelCategory;

public:
	int sumTotal;
	DebitCard(int _sumTotal = 10);
	void SetRefill();
	void SetExpenses();
	bool ExpenseReportFile(const char* filename);
	//void Menu();
};

class CreditCard : public DebitCard
{
	int interestRate;
public:
	CreditCard(int _sumTotal = 1000, int _interestRate = 10);
	//void Menu();
};

