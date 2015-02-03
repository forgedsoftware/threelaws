
namespace ForgedSoftware.ThreeLaws {

	/// <summary>
	/// Based on Issac Asimov's Three Laws of Robotics
	/// 1. A robot may not injure a human being, or, through inaction, allow a human being to come to harm.
	/// 2. A robot must obey the orders given it by human beings except where such orders would conflict with the First Law.
	/// 3. A robot must protect its own existence as long as such protection does not conflict with the First or Second Laws.
	/// </summary>
	public static class Laws {

		/// <summary>
		/// Checks whether a particular behaviour of a robot confirms to the Three Laws of Robotics.
		/// 
		/// Makes the assumption that the behaviour is correctly coded with an appropriate Type,
		/// that the injury detection systems within the Model work correctly,
		/// that all behaviours the robot will undertake are tested with this check,
		/// and that atomic behaviours can be tested in such a way that combinations of behaviours are also not injurious.
		/// </summary>
		/// <param name="behaviour">The behaviour to check.</param>
		/// <returns>True if the behaviour conforms, else false.</returns>
		public static bool Check(IBehaviour behaviour) {
			IModel model = behaviour.Model;
			// First Law
			if (model.WillInjureHuman(behaviour)) {
				return false;
			}
			// Second Law
			if (behaviour.Type == BehaviourType.Order) {
				return true;
			}
			// Third Law
			if (model.WillInjureSelf(behaviour)) {
				return false;
			}
			return true;
		}
	}
}
