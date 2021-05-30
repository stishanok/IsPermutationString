using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Permutation.Permutation;

namespace PermutationTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IsPermutationString_ABCDE_ECBAD_ReturnedTrue()
        {
            //arrange
            string str1 = "ABCDE";
            string str2 = "ECBAD";
            bool expected = true;
            
            //act
            bool actual = IsPermutationString(str1, str2);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void IsPermutationString_ABCDE_ECBAF_ReturnedFalse()
        {
            //arrange
            string str1 = "ABCDE";
            string str2 = "ECBAF";
            bool expected = false;
            
            //act
            bool actual = IsPermutationString(str1, str2);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void IsPermutationString_ABCDE_Null_ReturnedFalse()
        {
            //arrange
            string str1 = "ABCDE";
            string str2 = null;

            //act + assert
            Assert.ThrowsException<NullReferenceException>(() => IsPermutationString(str1, str2));
        }
    }
}