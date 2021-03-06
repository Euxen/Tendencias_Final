using NUnit.Framework;
using tendencias_lab_final.Class;


namespace tendencias_lab_final
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_Positive_2_to_the_power_of_2()
        {   //Can do basic exponent examples
            Assert.AreEqual(Class.Calculator.Potencia(2,2), 4); 
        }

        [Test]
        public void Test2_Positive_4_to_the_power_of_4()
        {   //Can return big numbers
            Assert.AreEqual(Class.Calculator.Potencia(4,4), 256); 
        }

        [Test]
        public void Test3_Negative_2_to_the_power_of_2()
        {
            //Can take negative bases
            Assert.AreEqual(Class.Calculator.Potencia(-2,2), 4); 
        }

        [Test]
        public void Test4_Negative_2_to_the_power_of_3()
        {
            //Can take negative bases and should return negative number
            Assert.AreEqual(Class.Calculator.Potencia(-2,3), -8); 
        }

        [Test]
        public void Test1N_Cannot_take_negative_exponent()
        {
            
            Assert.AreEqual(Class.Calculator.Potencia(2,-2), 10); 
        }

        [Test]
        public void Test2N_Cannot_take_a_base_over_int_max_value()
        {
            //Cannot overflow
            int max = int.MaxValue;
            Assert.AreEqual(Class.Calculator.Potencia(max + 1, 2), 20); 
        }

        [Test]
        public void Test3N_Avoid_overflow_as_result_of_exponent_that_is_too_big()
        {
            //Cannot overflow
            int max = int.MaxValue;
            Assert.AreEqual(Class.Calculator.Potencia(2,max + 1), 30); 
        }

        [Test]
        public void Test4N_Cannot_take_strings()
        {
            //Cannot take more or less than 2 arguments
            Assert.AreEqual(Class.Calculator.Potencia("string",0), 40); 
        }
    }
}
