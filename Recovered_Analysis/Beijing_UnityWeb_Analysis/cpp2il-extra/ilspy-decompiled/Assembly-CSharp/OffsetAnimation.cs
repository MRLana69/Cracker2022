using Cpp2ILInjected;
using UnityEngine;

public class OffsetAnimation : MonoBehaviour
{
	private Animation _anim;

	private float _time;

	private void Start()
	{
		//IL_0021: Expected Obj, but got I4
		//IL_022b: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0055: Expected I, but got Obj
		//IL_006b: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_0286: Expected I, but got Obj
		//IL_029c: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I
		//IL_0096: Expected I, but got Obj
		//IL_00e3: Expected I, but got Obj
		//IL_012b: Expected F4, but got I4
		//IL_031e: Expected I4, but got F4
		//IL_0340: Expected Obj, but got I
		//IL_0164: Expected F4, but got I4
		//IL_019d: Expected F4, but got I4
		//IL_01ab: Expected F4, but got I4
		//IL_0383: Expected I4, but got F4
		//IL_01e4: Expected F4, but got I4
		//IL_021d: Expected F4, but got I4
		bool flag = IOSViewController.IsSimulator();
		int num = IOSViewController._GetBottomInsetInPoints();
		bool flag2 = num > 0;
		int num2 = IOSViewController._GetDeviceHeightInPoints();
		bool flag3 = num2 > 0;
		object obj = flag2 | flag3;
		if (obj != null)
		{
			OffsetAnimation offsetAnimation = (OffsetAnimation)1;
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v39 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v20 (System.Boolean)+3C]");
			object obj3 = 0;
			nint num5 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v24 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v33 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num7 = num / (flag ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21+14]");
			object obj5 = (nint)0 * (nint)num7;
			float num8 = (float)obj5 - 11f;
			if (num8 != num8)
			{
				num8 = -2.1474836E+09f;
			}
			else if (!(num8 < 2.1474836E+09f))
			{
				num8 = -2.1474836E+09f;
			}
			else if (!(num8 > -2.1474836E+09f))
			{
				num8 = -2.1474836E+09f;
			}
			IPhoneXSupport.OFFSET_TOP = (int)num8;
			int num9 = num2 / (flag ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21+14]");
			object obj6 = (nint)0 * (nint)num9;
			float num10 = (float)obj6 - 11f;
			if (num10 != num10)
			{
				num10 = -2.1474836E+09f;
			}
			else if (!(num10 < 2.1474836E+09f))
			{
				num10 = -2.1474836E+09f;
			}
			else if (!(num10 > -2.1474836E+09f))
			{
				num10 = -2.1474836E+09f;
			}
			IPhoneXSupport.OFFSET_BOTTOM = (int)num10;
		}
		else
		{
			OffsetAnimation offsetAnimation = (OffsetAnimation)0;
		}
	}

	public OffsetAnimation()
	{
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I4
		//IL_00f4: Expected I4, but got Obj
		//IL_010c: Expected Obj, but got I4
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_anim != null)
		{
			object obj2 = this + 12;
			string text = tag;
			Animation component = ((GameObject)(object)text).GetComponent<Animation>();
			obj2 = component;
			float time = Time.time;
			bool isPlaying = _anim.isPlaying;
			float frameRate = ((AnimationClip)isPlaying).frameRate;
			float time2 = time * frameRate;
			_time = time2;
			bool isPlaying2 = _anim.isPlaying;
			Object obj3 = Object.Instantiate((Object)isPlaying2);
			bool flag = _anim.Play((PlayMode)obj3);
			((AnimationState)flag).normalizedTime = _time;
		}
	}
}
