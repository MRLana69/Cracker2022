using UnityEngine;

namespace NaughtyAttributes;

public class DrawConditionAttribute : NaughtyAttribute
{
	public DrawConditionAttribute()
	{
		((ParticleSystem)(object)this).Emit(1);
	}
}
