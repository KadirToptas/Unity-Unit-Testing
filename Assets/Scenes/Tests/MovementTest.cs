using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MovementTest
{
    [Test]

    public void HorizontalTest()
    {
        //Arrange

        var hero = new HeroController();
        //Act

        float x = hero.CalculateMovement(1, 0, 1, 1).x;
        //Assert
        
        Assert.AreEqual(1,x);
    }

    public void VerticalTest()
    {
        //Arrange

        var hero = new HeroController();
        //Act

        float z = hero.CalculateMovement(0, 1, 1, 1).z;
        //Assert
        
        Assert.AreEqual(1,z);
    }
}
