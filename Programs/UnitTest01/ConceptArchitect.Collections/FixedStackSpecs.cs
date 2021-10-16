using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace ConceptArchitect.Collections
{
    [TestFixture]
    public class FixedStackSpecs
    {
        FixedStack stack;

        [SetUp]
        public void BeforeEach()
        {
            stack = new FixedStack(3);
        }

       //[Ignore("Not Yet Implemented")]
       [Test]
       public void StackShouldBeAnObjectOfTypeFixedStack()
        {
           

            //Assert.IsInstanceOf<FixedStack>(stack); //MSTEST+NUNIT
            //Assert.That(stack, Is.TypeOf<FixedStack>()); //NUnit Only

            stack.Should().BeOfType<FixedStack>();  //FluentApi MSTEST+NUNIT
        }


        //[Ignore("Not Yet Implemented")]
        [Test]
        public void StackShouldHaveInitially_IsEmpty_True()
        {
           

            stack.IsEmpty.Should().BeTrue();
        }

        //[Ignore("Not Yet Implemented")]
        [Test]
        public void StackShouldHaveInitiallyBe_IsFull_False()
        {
            stack.IsFull.Should().BeFalse();
        }

       // [Ignore("Not Yet Implemented")]
        [Test]
        public void Push_ToAnStackMakes_ItEmpty_False()
        {
            stack.Push(1);

            stack.IsEmpty.Should().BeFalse();
        }

        //[Ignore("Not Yet Implemented")]
        [Test]
        public void Push_ToAnStackUptoItsSizeMakes_IsFull_True()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.IsFull.Should().Be(true);
        }

      

        //[Ignore("Not Yet Implemented")]
        [Test]
        public void Push_ToFullStackCasues_StackOverFlow_Exception_Verbose()
        {
            //ARRANGE
            MakeStackFull();
            try
            {
                stack.Push(4); //should throw StackOverflowException
                Assert.Fail("Expected Exception Not thrown");
            }catch(StackOverflowException ex)
            {

            }
            

        }

        [Test]
        public void Push_ToFullStackCasues_StackOverFlow_Exception()
        {
            //ARRANGE
            MakeStackFull();

            Assert.Throws<StackOverflowException>(() => stack.Push(4));

        }

        private void MakeStackFull()
        {
            for (int i = 0; i < stack.Size; i++)
                stack.Push(1);

            Assume.That(stack.IsFull, Is.True);
        }

        //[Ignore("Not Yet Implemented")]
        [Test]
        public void Push_IncreasesItem_Count()
        {
            stack.Push(1);
            stack.Push(2);

            stack.Count.Should().Be(2);
        }

        //[Ignore("Not Yet Implemented")]
        [Test]
        public void Pop_Decreases_ItemCount()
        {
            //Arrange
            stack.Push(1);
            stack.Push(2);
            Assume.That(stack.Count, Is.EqualTo(2));

            //ACT
            stack.Pop();

            stack.Count.Should().Be(1);

        }

        //[Ignore("Not Yet Implemented")]
        [Test]
        public void Pop_FromEmptyStack_Causes_StackUnderFlow_Exception()
        {
            Assert.Throws<StackUnderflowException>(() => stack.Pop());
        }

        //[Ignore("Not Yet Implemented")]
        [Test]
        public void Pop_FromAStackReturnsLastPushedItem()
        {
            //Arrange
            stack.Push(1);
            stack.Push(4);

            //ACT+Assert
            stack.Pop().Should().Be(4);
        }

        //[Ignore("Not Yet Implemented")]
        [Test]
        public void Pop_FromAFullStackMakes_IsFull_False()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assume.That(stack.IsFull, Is.True);

            stack.Pop();

            stack.IsFull.Should().Be(false);
        }
        //[Ignore("Not Yet Implemented")]
        [Test]
        public void Pop_OnlyItemFromTheStackMakes_IsEmpty_True()
        {
            //Arrange
            stack.Push(1);
            Assume.That(stack.IsEmpty, Is.False);

            //ACT
            stack.Pop();

            //Assert
            stack.IsEmpty.Should().BeTrue();
        }
        //[Ignore("Not Yet Implemented")]
        [Test]
        public void Peek_ReturnsTheLastPushedItem()
        {
            stack.Push(1);
            stack.Push(2);

            //Act
            var item = stack.Peek();
            //Assert
            item.Should().Be(2);
        }

        //[Ignore("Not Yet Implemented")]
        [Test]
        public void Peek_DoesntRemoveTheItem()
        {
            stack.Push(1);
            stack.Push(2);

            var lastCount = stack.Count;

            stack.Peek();

            stack.Count.Should().Be(lastCount);
        }


       // [Ignore("Not Yet Implemented")]
        [Test]
        public void Peek_CalledMultipleTimesReturnsSameValue()
        {
            stack.Push(1);
            stack.Push(2);

            for (int i = 0; i < 5; i++)
                stack.Peek().Should().Be(2);
        }


        [Test]
        public void StackOverflowException_ShouldContaniTheValueThatCausedException()
        {
            MakeStackFull();
            var item = 4;
            var ex = Assert.Throws<StackOverflowException>(() => stack.Push(item));
            ex.Value.Should().Be(item);
        }


        [Test]
        public void StackOverflowException_ShouldBeAStackException()
        {
            typeof(StackOverflowException).Should().BeDerivedFrom<StackException>();
        }


        [Test]
        public void StackUnderflowException_ShouldBeAStackException()
        {
            typeof(StackOverflowException).Should().BeDerivedFrom<StackException>();
        }


    }
}
