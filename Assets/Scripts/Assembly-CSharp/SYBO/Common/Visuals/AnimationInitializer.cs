using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class AnimationInitializer : MonoBehaviour
{
	[Serializable]
	public struct Config
	{
		public float StartTimeMin;

		public float StartTimeMax;
	}

	private Config _config;

	private Animation _animation;

	private bool _initialized;

	private unsafe void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0023: Expected F4, but got VT
		//IL_001e: Expected native int or pointer, but got VT
		object obj = default;
		Config config = (Config)(obj - 16);
		Initialize();
		((Config*)(nint)config)->StartTimeMin = (float)_config;
		_ = _config;
		InitializeAnimation(config);
	}

	private void OnValidate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected VT, but got Unknown
		//IL_0068: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		Animation component = GetComponent<Animation>();
		_animation = component;
		_ = _config;
		_ = _config;
		Config config = (Config)(obj + 8);
		Config config2 = ClampToDefaultAnimationLength(config);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_config = (Config)0;
	}

	private void Initialize()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Animation component = GetComponent<Animation>();
			_animation = component;
			_initialized = true;
		}
	}

	public void InitializeAnimation(Config config)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected VT, but got Unknown
		//IL_008a: Expected VT, but got I
		//IL_009d: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 - 32;
		if (!(_animation != null))
		{
			return;
		}
		AnimationClip clip = _animation.clip;
		if (clip != null)
		{
			_ = config.StartTimeMin;
			_ = config.StartTimeMin;
			Config config2 = (Config)(obj + 8);
			Config config3 = ClampToDefaultAnimationLength(config2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_config = (Config)0;
			object obj3 = config.StartTimeMin >> 32;
			float num = (float)obj3 - config.StartTimeMin;
			float value = UnityEngine.Random.value;
			float num2 = num * value;
			float num3 = config.StartTimeMin + num2;
			AnimationClip clip2 = _animation.clip;
			string text = clip2.name;
			AnimationState animationState = _animation.get_Item(text);
			float length = animationState.length;
			AnimationClip clip3 = animationState.clip;
			string text2 = clip3.name;
			AnimationState animationState2 = _animation.get_Item(text2);
			bool flag = num3 > length;
			float num4 = length;
			if (!flag)
			{
				num4 = num3;
			}
			bool flag2 = num3 < 0f;
			float time = 0f;
			if (!flag2)
			{
				time = num4;
			}
			animationState2.time = time;
		}
	}

	public unsafe Config ClampToDefaultAnimationLength(Config config, bool validating = false)
	{
		//IL_0105: Expected native int or pointer, but got VT
		//IL_016d: Expected native int or pointer, but got VT
		//IL_01a8: Expected native int or pointer, but got VT
		if (_animation != null)
		{
			AnimationClip clip = _animation.clip;
			if (clip != null)
			{
				AnimationClip clip2 = _animation.clip;
				string text = clip2.name;
				AnimationState animationState = _animation.get_Item(text);
				float num = animationState.length;
				if (!(config.StartTimeMin > num))
				{
					num = config.StartTimeMin;
				}
				bool flag = config.StartTimeMin < 0f;
				float startTimeMin = 0f;
				if (!flag)
				{
					startTimeMin = num;
				}
				((Config*)(nint)config)->StartTimeMin = startTimeMin;
				float num2 = animationState.length;
				if (!(config.StartTimeMax > num2))
				{
					num2 = config.StartTimeMax;
				}
				bool flag2 = config.StartTimeMax < 0f;
				float startTimeMax = 0f;
				if (!flag2)
				{
					startTimeMax = num2;
				}
				((Config*)(nint)config)->StartTimeMax = startTimeMax;
			}
		}
		Config config2 = default;
		((Config*)(nint)config2)->StartTimeMin = config.StartTimeMin;
		return config2;
	}
}
