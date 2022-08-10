using LeetCodeСhallenge.LeetCode;
using NUnit.Framework;

namespace LeetCodeСhallenge;

[TestFixture]
public class MainClassForTests
{
    private IntegerToRomanTask _integerToRomanTask = new();

    [Test]
    public void IntegerToRoman3()
    {
        var num = 3;
        var expected = "III";
        var result = _integerToRomanTask.IntToRoman(num);
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void IntegerToRoman58()
    {
        var num = 58;
        var expected = "LVIII";
        var result = _integerToRomanTask.IntToRoman(num);
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void IntegerToRoman1994()
    {
        var num = 1994;
        var expected = "MCMXCIV";
        var result = _integerToRomanTask.IntToRoman(num);
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void IntegerToRoman3030()
    {
        var num = 3030;
        var expected = "MMMXXX";
        var result = _integerToRomanTask.IntToRoman(num);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void FirstBadVersion1()
    {
        FirstBadVersionTask versionTask = new FirstBadVersionTask(new[] {true});
        var result = versionTask.FirstBadVersion(1);
        var expected = 1;
         
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void FirstBadVersion5()
    {
        FirstBadVersionTask versionTask = new FirstBadVersionTask(new[] {false, false, false, true, true});
        var result = versionTask.FirstBadVersion(5);
        var expected = 4;
         
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void FirstBadVersion7()
    {
        FirstBadVersionTask versionTask = new FirstBadVersionTask(new[] {false, false, false, false, false, true, 
            true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
        var result = versionTask.FirstBadVersion(27);
        var expected = 6;
         
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void FirstBadVersion2126753390()
    {
        FirstBadVersionTask versionTask = new FirstBadVersionTask(2126753390, 1702766719);
        var result = versionTask.FirstBadVersion(2126753390);
        var expected = 1702766719;
         
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void PivotIndexTest3()
    {
        int[] nums = {1, 7, 3, 6, 5, 6};
        var result = PivotIndexTask.PivotIndex(nums);
        
        Assert.AreEqual(3, result);
    }
    
    [Test]
    public void PivotIndexTestMinus1()
    {
        int[] nums = {1,2,3};
        var result = PivotIndexTask.PivotIndex(nums);
        
        Assert.AreEqual(-1, result);
    }
    
    [Test]
    public void PivotIndexTest0()
    {
        int[] nums = {2,1,-1};
        var result = PivotIndexTask.PivotIndex(nums);
        
        Assert.AreEqual(0, result);
    }
}