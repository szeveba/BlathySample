using LibrarySample;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSample
{
    public class ChainedListTests
    {
        [Test]
        public void InstantiationWithoutParameter()
        {
            
        }

        [TestCase(0)]
        [TestCase(10)]
        [TestCase(100)]
        [Test]
        public void InstantiationWithParameter(int itemCount)
        {
            try
            {
                var list = new ChainedList<int>(Enumerable.Range(0, itemCount));
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        [TestCase(0)]
        [TestCase(10)]
        [TestCase(100)]
        public void AddOneNewItem(int itemCount)
        {
            var list = new ChainedList<int>(Enumerable.Range(0, itemCount));
            list.Add(itemCount);
            Assert.That(list.Count, Is.EqualTo(itemCount + 1));
        }
        [Test]
        [TestCase(2)]
        [TestCase(10)]
        [TestCase(100)]
        public void AddItemsCorrectOrder(int itemCount)
        {
            var items = Enumerable.Range(0, itemCount).ToArray();
            var list = new ChainedList<int>();
            foreach (var item in items)
            {
                list.Add(item);
            }
            int idx = 0;
            foreach (var item in list)
            {
                if (idx++ != item)
                {
                    Assert.Fail();
                }
            }
            Assert.Pass();
        }
    }
}
