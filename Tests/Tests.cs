using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForgedSoftware.ThreeLaws.Tests {

	[TestClass]
	public class Tests {

		[TestMethod]
		public void TestCreation() {
			var behaviour = new FakeBehaviour {Type = BehaviourType.Order};
			Assert.IsTrue(Laws.Check(behaviour));
		}

		[TestMethod]
		public void TestCatchesBreakingLaw1() {
			var behaviour = new FakeBehaviour { Type = BehaviourType.Order };
			((FakeModel) behaviour.Model).InjuresHuman = true;
			Assert.IsFalse(Laws.Check(behaviour));
		}

		[TestMethod]
		public void TestPassingLaw2() {
			var behaviour = new FakeBehaviour { Type = BehaviourType.Order };
			Assert.IsTrue(Laws.Check(behaviour));
		}

		[TestMethod]
		public void TestCatchesBreakingLaw3() {
			var behaviour = new FakeBehaviour { Type = BehaviourType.GeneratedBehaviour };
			((FakeModel)behaviour.Model).InjuresSelf = true;
			Assert.IsFalse(Laws.Check(behaviour));
		}

		[TestMethod]
		public void TestPassingLaw3() {
			var behaviour = new FakeBehaviour { Type = BehaviourType.GeneratedBehaviour };
			Assert.IsTrue(Laws.Check(behaviour));
		}
	}
}
