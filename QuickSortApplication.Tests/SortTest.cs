using QuickSortApplication;

namespace QuickSortApplication.Tests;

[TestClass]
public class SortTest
{
    [TestMethod]
    public void TestFloats()
    {
        float[] ipArray = [5.4F,3.7F,1.6F,2.3F,4.8F];
        float[] opArray = [1.6F,2.3F,3.7F,4.8F,5.4F];
        Program.QuickSort(ipArray, 0, ipArray.Length - 1);
        CollectionAssert.AreEqual(ipArray, opArray);
    }

    [TestMethod]
    public void TestInts()
    {
        float[] ipArray = [5,3,1,2,4];
        float[] opArray = [1,2,3,4,5];
        Program.QuickSort(ipArray, 0, ipArray.Length - 1);
        CollectionAssert.AreEqual(ipArray, opArray);
    }

    [TestMethod]
    public void TestMixed()
    {
        float[] ipArray = [5.4F,3,1.2F,2,4.8F];
        float[] opArray = [1.2F,2,3,4.8F,5.4F];
        Program.QuickSort(ipArray, 0, ipArray.Length - 1);
        CollectionAssert.AreEqual(ipArray, opArray);
    }

    [TestMethod]
    public void TestDuplicateValues()
    {
        float[] ipArray = [5,3,1,2,4];
        float[] opArray = [1,2,3,4,5];
        Program.QuickSort(ipArray, 0, ipArray.Length - 1);
        CollectionAssert.AreEqual(ipArray, opArray);
    }

    [TestMethod]
    public void TestEmpty()
    {
        float[] ipArray = [];
        float[] opArray = [];
        Program.QuickSort(ipArray, 0, ipArray.Length - 1);
        CollectionAssert.AreEqual(ipArray, opArray);
    }

    [TestMethod]
    public void TestEvenNumberOfElements()
    {
        float[] ipArray = [5,3,1,2];
        float[] opArray = [1,2,3,5];
        Program.QuickSort(ipArray, 0, ipArray.Length - 1);
        CollectionAssert.AreEqual(ipArray, opArray);
    }

}