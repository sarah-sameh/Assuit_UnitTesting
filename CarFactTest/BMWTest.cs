using CarFactoryLibrary;

namespace CarFactTestLab1
{
    public class BMWTest
    {

        //bool
        [Fact]
        public void IsStopped_velocityNotZero_false()
        {

            BMW bmw = new BMW();
            bmw.velocity = 10;


            bool result = bmw.IsStopped();


            Assert.False(result);
        }



        //boolean
        [Fact]
        public void IsStopped_velocity0_true()
        {
            BMW bMW = new BMW();
            bMW.velocity = 0;
            bool result = bMW.IsStopped();
            Assert.True(result);
        }



        //numeric InRange

        [Fact]
        public void IncreaseVelocity_valocityInRange_15_20()
        {

            BMW bMW = new BMW();
            bMW.velocity = 5;
            double AddedVelocitoy = 15;
            bMW.IncreaseVelocity(AddedVelocitoy);
            Assert.InRange(bMW.velocity, 15, 25);

        }

        //numeric 
        [Fact]
        public void IncreaseVelocity_valocity5Add15_20()
        {

            BMW bMW = new BMW();
            bMW.velocity = 5;
            double AddedVelocitoy = 15;
            bMW.IncreaseVelocity(AddedVelocitoy);

            Assert.False(bMW.velocity < 5);
        }



        //numeric

        [Fact]
        public void IncreaseVelocity_VelocityIncreasedBySpecificAmount_Velocity()
        {
            // Arrange
            BMW bmw = new BMW();
            double initialVelocity = 10;
            double addedVelocity = 15;
            double expectedVelocity = initialVelocity + addedVelocity;
            bmw.velocity = initialVelocity;

            // Act
            bmw.IncreaseVelocity(addedVelocity);

            // Assert
            Assert.Equal(expectedVelocity, bmw.velocity);
        }


        //string


        [Fact]
        public void GetDirection_DirectionStopped_Stopped()
        {

            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Stopped;
            string result = bmw.GetDirection();

            Assert.Equal(DrivingMode.Stopped.ToString(), result);
        }

        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {

            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.Equal(DrivingMode.Forward.ToString(), result);

        }

        //string start with F
        [Fact]
        public void GetDirection_DirectionForward_F()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.StartsWith("F", result);
        }

        //string end with erd
        [Fact]
        public void GetDirection_DirectionForward_ard()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.EndsWith("ard", result);
        }

        //string contains rw
        [Fact]
        public void GetDirection_DirectionForward_rw()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.Contains("rw", result);
        }

        //string not contains yy
        [Fact]
        public void GetDirection_DirectionForward_notContain_yy()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.DoesNotContain("yy", result);
        }

        // reference 
        [Fact]
        public void GetMyCar_callMyMethod_TheSameCar()
        {

            BMW bmw1 = new BMW();
            BMW bmw2 = new BMW();
            Car car = bmw1.GetMyCar();
            Assert.Same(bmw1, car);
            Assert.NotSame(bmw2, car);
        }

    }
}
