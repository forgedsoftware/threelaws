
namespace ForgedSoftware.ThreeLaws {

	/// <summary>
	/// Defines an atomic behaviour of a robot.
	/// </summary>
	public interface IBehaviour {
		/// <summary>
		/// The model of reality to which the behaviour is associated.
		/// </summary>
		IModel Model { get; }

		/// <summary>
		/// The type/origin of the behaviour.
		/// </summary>
		BehaviourType Type { get; }
	}
}
