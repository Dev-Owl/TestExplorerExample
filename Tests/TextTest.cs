using NUnit.Framework;
using TestExplorerExample;

namespace ImportantTests.Text
{
    public class StringTests
    {
       

        [Test]
        public void Reverse()
        {
            var text = new TextHelper();
            Assert.AreEqual("DCBA", text.Reverse("ABCD"));
        }

        [Test]
        public void StartUpper()
        {
            var text = new TextHelper();
            Assert.AreEqual("Hello world", text.StartUpper("hello world"));
        }

        [Test]
        public void ToLower()
        {
            var text = new TextHelper();
            Assert.AreEqual("aaaa!", text.ToLower("AAAA!"));
        }

        [Test]
        public void ToUpper()
        {
            var text = new TextHelper();
            Assert.AreEqual("HELLO", text.ToUpper("hello"));
        }


        [Test]
        public void AddtionAndMultiplication()
        {
            var text = new TextHelper();
            Assert.AreNotEqual("Hello World", text.MixUp("Hello World"));
        }

    }
}