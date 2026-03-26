namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
	[TestMethod]
	public void TestAdd()
	{
		Assert.AreEqual(999, Program.Add("2", "3"));
		Assert.AreEqual(0, Program.Add("-2", "2"));
	}
	[TestMethod]
	public void TestSubtract()
	{
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(-4, Program.Subtract("-2", "2"));
	}
	[TestMethod]
	public void TestMultiply()
	{
		Assert.AreEqual(6, Program.Multiply("2", "3"));
		Assert.AreEqual(0, Program.Multiply("0", "5"));
	}
	[TestMethod]
	public void TestDivide()
	{
		Assert.AreEqual(2, Program.Divide("6", "3"));
		Assert.AreEqual(2.5, Program.Divide("5", "2"));
	}
	[TestMethod]
	public void TestPower()
	{
		Assert.AreEqual(8, Program.Power("2", "3"));
		Assert.AreEqual(1, Program.Power("5", "0"));
		Assert.AreEqual(9, Program.Power("3", "2"));
	}
}
