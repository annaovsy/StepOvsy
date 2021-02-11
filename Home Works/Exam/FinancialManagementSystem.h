#pragma once
#include <iostream>
using namespace std;

class DebitCard
{
	int sumTotal;
	int productCategory;
	int entertainmentCategory;
	int travelCategory;

public:
	DebitCard(int _sumTotal = 10);
	
	void SetRefill();
	void SetExpenses();
	bool ExpenseReportFile(const char* filename);


	void Show();


};

