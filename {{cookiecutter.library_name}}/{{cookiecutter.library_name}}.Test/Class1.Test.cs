using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace {{cookiecutter.library_name}}.Test
{
	[TestFixture]
    public class Class1Test
    {
		[Test]
		public void Greeting()
		{
			Assert.AreEqual("Hello, World!", Class1.Greeting);
		}
    }
}
