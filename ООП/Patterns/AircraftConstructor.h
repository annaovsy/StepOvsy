#pragma once
#include "AircraftBuilder.h"

class AircraftConstructor
{
public:
	AircraftConstructor();
	virtual ~AircraftConstructor();
	void Construct(AircraftBuilder* aircraftBuilder);
};

AircraftConstructor::AircraftConstructor()
{
}

AircraftConstructor::~AircraftConstructor()
{
}

void AircraftConstructor::Construct(AircraftBuilder* aircraftBuilder)
{
	aircraftBuilder->BuildFrame();
	aircraftBuilder->BuildEngine();
	aircraftBuilder->BuildWheels();
	aircraftBuilder->BuildDoors();
}
