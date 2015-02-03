
namespace ForgedSoftware.ThreeLaws {

	/// <summary>
	/// Defines an top level interface for a Model that provides sensory perception and
	/// future prediction for a robot.
	/// </summary>
	public interface IModel {

		/// <summary>
		/// Determines, given the model, if a behaviour will directly or indirectly injure a human.
		/// </summary>
		/// <param name="behaviour">The behaviour to test.</param>
		/// <returns>True if injurious to humans, else false.</returns>
		bool WillInjureHuman(IBehaviour behaviour);

		/// <summary>
		/// Determines, given the model, if a behaviour will directly or indirectly injure the robot itself.
		/// </summary>
		/// <param name="behaviour">The behaviour to test.</param>
		/// <returns>True if injurious to self, else false.</returns>
		bool WillInjureSelf(IBehaviour behaviour);
	}
}
