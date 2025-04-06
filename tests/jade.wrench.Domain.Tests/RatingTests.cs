﻿using jade.wrench.Domain;
using jade.wrench.Domain.Catalog;
namespace jade.wrench.Domain.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        // Arrange
        var rating = new Rating(1, "Mike", "Great fit!");
        // Act (empty)
        
        // Assert
        Assert.AreEqual(1, rating.Stars);
        Assert.AreEqual("Mike", rating.UserName);
        Assert.AreEqual("Great fit!", rating.Review);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Rating_With_Invalid_Stars()
    {
        // Arrange
        var rating = new Rating(0, "Mike", "Great fit!");
    }
}
