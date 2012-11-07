﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBagSystem;

namespace StoreBagSystemTest
{
    [TestClass]
    public class RobotTest
    {
        [TestMethod]
        [ExpectedException(typeof (CabinetException), "No available box exception!")]
        public void ShouldShowErrorMessageWhenNoBoxAvailableInAnyCabinet()
        {
            var cabinet = new Cabinet(1);
            var cabinets = new List<Cabinet> {cabinet};
            cabinet.Store(new Bag());

            var robot = new Robot(cabinets);

            robot.Store(new Bag());
        }

        [TestMethod]
        public void ShouldStoreBagSuccessfullyInFirstAvailableBox()
        {
            var cabinet1 = new Cabinet(1);
            var cabinet2 = new Cabinet(1);
            var cabinets = new List<Cabinet> {cabinet1, cabinet2};

            var robot = new Robot(cabinets);
            var ticket = robot.Store(new Bag());

            Assert.IsNotNull(ticket);
        }
    }
}