using CarFactoryLibrary;

namespace Lab1_Mousa
{
        public class UnitTest1
        {
            [Fact]
            public void CarIsNotStopped()
            {
                ///AAA 

                //Arrange
                BMW bMW = new BMW();
                bMW.velocity = 10;
                //Act
                bool res = bMW.IsStopped();
                //Assert
                Assert.False(res);
            }

            [Fact]
            public void CarIsStopped()
            {
                ///AAA 

                //Arrange
                BMW bMW = new BMW();
                bMW.velocity = 0;
                //Act
                bool res = bMW.IsStopped();
                //Assert
                Assert.True(res);
            }

            [Fact]
            public void CarVelocityEquals21()
            {
                ///AAA 

                //Arrange
                BMW bMW = new BMW();
                bMW.velocity = 21;
                //Act
                double res = bMW.velocity;
                //Assert
                Assert.InRange(res, 21, 21);
            }

            [Fact]
            public void CarForwardDirection()
            {
                ///AAA 

                //Arrange
                BMW bMW = new BMW();
                bMW.IncreaseVelocity(1);
                //Act
                string res = bMW.GetDirection();
                //Assert
                Assert.StartsWith("F", res);
                Assert.EndsWith("d", res);
            }

            [Fact]
            public void NotEqualedObjs()
            {
                ///AAA 

                //Arrange
                BMW bMW = new BMW();
                BMW bMW2 = new BMW();

                //Act
                bool res = bMW == bMW2;
                //Assert
                Assert.False(res);
            }


            [Fact]
            public void HondaIsCar()
            {
                ///AAA 

                //Arrange
                Car? car = CarFactory.NewCar(CarTypes.Honda);

                //Act

                //Assert
                Assert.IsType<Honda>(car);
            }

            [Fact]
            public void AudiIsNotImplemented()
            {
                ///AAA 

                //Arrange


                //Act

                //Assert
                Assert.Throws<NotImplementedException>(() =>
                {
                    Car? car = CarFactory.NewCar(CarTypes.Ferrari);
                });
            }



        }
    }