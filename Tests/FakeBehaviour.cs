
namespace ForgedSoftware.ThreeLaws.Tests {

	public class FakeBehaviour : IBehaviour {

		private IModel _model;

		public IModel Model {
			get {
				return _model ?? (_model = new FakeModel());
			}
			set {
				_model = value;
			}
		}

		public BehaviourType Type { get; set; }
	}
}
