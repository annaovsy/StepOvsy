#pragma once
#include <iostream>
using namespace std;

void Menu();

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
};

class CreditCard : public DebitCard
{
	int interestRate;
public:
	CreditCard(int _sumTotal = 1000, int _interestRate = 10);
};

