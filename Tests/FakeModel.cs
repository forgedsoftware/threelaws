
namespace ForgedSoftware.ThreeLaws.Tests {
	
	public class FakeModel : IModel {

		public bool InjuresHuman { get; set; }

		public bool WillInjureHuman(IBehaviour behaviour) {
			return InjuresHuman;
		}

		public bool InjuresSelf { get; set; }

		public bool WillInjureSelf(IBehaviour behaviour) {
			return InjuresSelf;
		}
	}
}
