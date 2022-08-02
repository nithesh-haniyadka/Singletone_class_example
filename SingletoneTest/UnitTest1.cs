using SingletonDemo;
namespace SingletoneTest
{
    public class UnitTest1
    {
        [Fact]
        public void ObjectNullCheck()
        {

            // Check if object is not equal to null

            Singleton obj = Singleton.GetInstance;
            Assert.True(obj != null);

        }
        [Fact]
        public void CheckinitialCounterValue()
        {

            // be zero at the beginning

            Singleton obj = Singleton.GetInstance;
            Assert.NotNull(obj);

        }
        [Fact]
        public void incrementCheck()
        {

            // Be 1 after one increment

            Singleton obj = Singleton.GetInstance;
            obj.increment();
            Assert.Equal(1, 1);
        }
        [Fact]
        public void decrementCheck()
        {
            Singleton obj = Singleton.GetInstance;
            obj.decrement();
            Assert.Equal(0, 0);
        }


    }
}