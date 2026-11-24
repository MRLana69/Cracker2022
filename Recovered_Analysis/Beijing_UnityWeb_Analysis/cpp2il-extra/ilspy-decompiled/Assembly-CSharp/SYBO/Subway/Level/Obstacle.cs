using UnityEngine;

namespace SYBO.Subway.Level;

public abstract class Obstacle : MonoBehaviour
{
	protected Obstacle()
	{
		_ = -1;
		((RandomizerTargetWeightedHold)this).Initialize();
	}
}
