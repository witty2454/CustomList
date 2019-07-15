using System;
using CustomListClassProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class CustomListClassProject
    {
        [TestMethod]
        public void Add_OneObject_ToList()
        {
            //Arrange
            MyList<int> list = new MyList<int>();
            //Act
            list.Add(1);
            //Assert
            Assert.AreEqual(list.size, 1);
        }
        [TestMethod]
        public void Add_MultipleObjects_ToList()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            //Act
            list.Add("hi");
            list.Add("bye");
            list.Add("hello");
            //Assert
            Assert.AreEqual(list.size, 3);
        }
        [TestMethod]
        public void Add_Objects_ToCorrectIndex()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            //Act
            list.Add("hi");
            list.Add("bye");
            list.Add("hello");
            //Assert
            Assert.AreEqual( list.objects[1] , "bye");
        }
        [TestMethod]
        public void Remove_Object_FromList()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            list.Add("hi");
            list.Add("bye");
            list.Add("hello");
            //Act
            list.Remove("hello");
            //Assert
            Assert.AreEqual(list.size, 2);
        }
      
       