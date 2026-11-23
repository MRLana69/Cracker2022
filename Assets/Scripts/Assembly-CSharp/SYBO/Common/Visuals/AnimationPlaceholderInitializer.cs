using SYBO.Subway.Placeholders;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class AnimationPlaceholderInitializer : MonoBehaviour, IPlaceholderInitializer
{
	private AnimationInitializer.Config _config;

	public unsafe void Initialize(Placeholder parent, Transform spawnedObject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002f: Expected F4, but got VT
		//IL_002a: Expected native int or pointer, but got VT
		object obj = default;
		AnimationInitializer.Config config = (AnimationInitializer.Config)(obj - 16);
		AnimationInitializer component = spawnedObject.GetComponent<AnimationInitializer>();
		((AnimationInitializer.Config*)(nint)config)->StartTimeMin = (float)_config;
		_ = _config;
		component.InitializeAnimation(config);
	}
}
