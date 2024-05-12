using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibarayTastLab3
{
    public class ToyotaTests
    {
        [Fact]
        public void Accelerate_IncreasesVelocityBy5()
        {
            // Arrange
            var toyota = new Toyota();
            double initialVelocity = toyota.velocity;

            // Act
            toyota.Accelerate();

            // Assert
            Assert.Equal(initialVelocity + 5, toyota.velocity);
        }

        [Fact]
        public void Stop_SetsVelocityToZero()
        {
            // Arrange
            var toyota = new Toyota();
            toyota.velocity = 30; // Set some initial velocity

            // Act
            toyota.Stop();

            // Assert
            Assert.Equal(0, toyota.velocity);
        }

        [Fact]
        public void Stop_ChangesDrivingModeToStopped()
        {
            // Arrange
            var toyota = new Toyota();
            toyota.drivingMode = DrivingMode.Forward; // Set some initial driving mode

            // Act
            toyota.Stop();

            // Assert
            Assert.Equal(DrivingMode.Stopped, toyota.drivingMode);
        }

        [Fact]
        public void TimeToCoverDistance_ReturnsCorrectTime()
        {
            // Arrange
            var toyota = new Toyota();
            toyota.velocity = 10; // Set velocity to 10 m/s
            double distance = 100; // Distance to cover

            // Act
            double expectedTime = distance / toyota.velocity;
            double actualTime = toyota.TimeToCoverDistance(distance);

            // Assert
            Assert.Equal(expectedTime, actualTime);
        }

        [Fact]
        public void IsStopped_ReturnsTrueWhenVelocityIsZero()
        {
            // Arrange
            var toyota = new Toyota();
            toyota.velocity = 0; // Set velocity to 0

            // Act
            var result = toyota.IsStopped();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsStopped_ReturnsFalseWhenVelocityIsNonZero()
        {
            // Arrange
            var toyota = new Toyota();
            toyota.velocity = 10; // Set some non-zero velocity

            // Act
            var result = toyota.IsStopped();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GetDirection_ReturnsCorrectDrivingMode()
        {
            // Arrange
            var toyota = new Toyota();
            toyota.drivingMode = DrivingMode.Backward; // Set some driving mode

            // Act
            var direction = toyota.GetDirection();

            // Assert
            Assert.Equal("Reverse", direction);
        }
    }
}
