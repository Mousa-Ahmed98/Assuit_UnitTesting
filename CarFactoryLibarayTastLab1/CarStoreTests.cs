using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibarayTastLab1
{
    public class CarStoreTests
    {
        [Fact]
        public void AddCar_AddsCarToStore()
        {
            // Arrange
            var carStore = new CarStore();
            var car = new BMW(); 

            // Act
            carStore.AddCar(car);

            // Assert
            Assert.Contains(car, carStore.cars);
        }

        [Fact]
        public void AddCars_AddsMultipleCarsToStore()
        {
            // Arrange
            var carStore = new CarStore();
            var carsGroup = new List<Car> { new BMW(), new BMW(), new BMW() }; 

            // Act
            carStore.AddCars(carsGroup);

            // Assert
            Assert.Equal(carsGroup.Count, carStore.cars.Count);
            foreach (var car in carsGroup)
            {
                Assert.Contains(car, carStore.cars);
            }
        }
    }

}
