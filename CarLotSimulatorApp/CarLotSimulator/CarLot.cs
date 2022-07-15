﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot : Car
    {
        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console

        public List<CarLot> ParkingSpots { get; set; } = new List<Car>();

        public static int numberOfCars = 0;
        foreach (Car car in ParkingSpots) {
            numberOfCars += 1;

    }
}

