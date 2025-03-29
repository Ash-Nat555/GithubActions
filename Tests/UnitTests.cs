namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
	
	[TestMethod]
	public void Subtract_Valid()
	{
		Assert.AreEqual(-1, Program.Subtract("1", "2"));
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(-2, Program.Subtract("5", "7"));
	}

	[TestMethod]
	public void Subtract_Invalid()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
	}

	[TestMethod]
	public void Subtract_Null()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
	}

	[TestMethod]
	public void Multiply_Valid()
	{
		Assert.AreEqual(2, Program.Multiply("1", "2"));
		Assert.AreEqual(6, Program.Multiply("3", "2"));
		Assert.AreEqual(35, Program.Multiply("5", "7"));
	}

	[TestMethod]
	public void Multiply_Invalid()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
	}

	[TestMethod]
	public void Multiply_Null()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
	}

	[TestMethod]
	public void Divide_Valid()
	{
		Assert.AreEqual(3, Program.Divide("6", "2"));
		Assert.AreEqual(5, Program.Divide("10", "2"));
		Assert.AreEqual(12, Program.Divide("84", "7"));
	}

	[TestMethod]
	public void Divide_Invalid()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
	}

	[TestMethod]
	public void Divide_Null()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
	}

	[TestMethod]
	public void Power_Valid()
	{
		Assert.AreEqual(1, Program.Power("1", "2"));
		Assert.AreEqual(9, Program.Power("3", "2"));
		Assert.AreEqual(25, Program.Power("5", "2"));
	}

	[TestMethod]
	public void Power_Invalid()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
	}

	[TestMethod]
	public void Power_Null()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
	}

}
