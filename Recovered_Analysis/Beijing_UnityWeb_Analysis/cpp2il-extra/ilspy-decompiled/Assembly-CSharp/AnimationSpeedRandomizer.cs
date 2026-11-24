using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class AnimationSpeedRandomizer : MonoBehaviour
{
	private Animation _animation;

	private float _minAnimationSpeed;

	private float _maxAnimationSpeed;

	private void OnEnable()
	{
		CancelInvoke();
	}

	public AnimationSpeedRandomizer()
	{
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I4
		//IL_0082: Expected I4, but got Obj
		//IL_00ad: Expected Obj, but got I4
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_animation).FindKernel((string)null) != 0)
		{
			bool isPlaying = _animation.isPlaying;
			Object obj2 = Object.Instantiate((Object)isPlaying);
			bool flag = _animation.Play((PlayMode)obj2);
			float height = ScrollRect.RubberDelta(_minAnimationSpeed, _maxAnimationSpeed);
			((CharacterController)flag).height = height;
		}
	}
}
