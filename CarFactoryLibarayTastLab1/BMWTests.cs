using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibarayTastLab1
{
    public class BMWTests
    {
        [Fact]
        public void Accelerate_IncreasesVelocityBy15()
        {
            // Arrange
            var bmw = new BMW();

            // Act
            bmw.Accelerate();

            // Assert
            Assert.Equal(15, bmw.velocity);
        }

        [Fact]
        public void Accelerate_ChangesDrivingModeToForward()
        {
            // Arrange
            var bmw = new BMW();

            // Act
            bmw.Accelerate();

            // Assert
            Assert.Equal(DrivingMode.Forward, bmw.drivingMode);
        }

        [Fact]
        public void Stop_SetsVelocityToZero()
        {
            // Arrange
            var bmw = new BMW();
            bmw.velocity = 30; 

            // Act
            bmw.Stop();

            // Assert
            Assert.Equal(0, bmw.velocity);
        }

        [Fact]
        public void Stop_ChangesDrivingModeToStopped()
        {
            // Arrange
            var bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward; 

            // Act
            bmw.Stop();

            // Assert
            Assert.Equal(DrivingMode.Stopped, bmw.drivingMode);
        }

        [Fact]
        public void TimeToCoverDistance_ReturnsCorrectTime_WhenVelocityIsNonZero()
        {
            // Arrange
            var bmw = new BMW();
            bmw.velocity = 10; 
            double distance = 100; 

            // Act
            double expectedTime = distance / bmw.velocity;
            double actualTime = bmw.TimeToCoverDistance(distance);

            // Assert
            Assert.Equal(expectedTime, actualTime);
        }

        [Fact]
        public void TimeToCoverDistance_ReturnsInfinity_WhenVelocityIsZero()
        {
            // Arrange
            var bmw = new BMW();
            bmw.velocity = 0; 
            double distance = 100; 

            // Act
            double actualTime = bmw.TimeToCoverDistance(distance);

            // Assert
            Assert.Equal(double.PositiveInfinity, actualTime);
        }

        [Fact]
        public void TimeToCoverDistance_ReturnsZero_WhenDistanceIsZero()
        {
            // Arrange
            var bmw = new BMW();
            double distance = 0; 

            // Act
            double actualTime = bmw.TimeToCoverDistance(distance);

            // Assert
            Assert.Equal(0, actualTime);
        }

        
    }
}
