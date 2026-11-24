using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class OutfitKeyframeBehaviour : MonoBehaviour
{
	private bool _initialized;

	private Animation _targetAnimation;

	public ParticleSystem[] TargetObjects;

	public List<KeyFrameAction> Actions;

	private void Start()
	{
		CancelInvoke();
	}

	private void Initialize()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			this._002Ector();
		}
	}

	private Animation GetAnimationInAncestors(Transform transform)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Animation animation = default;
		((UnityEngine.Object)animation).m_CachedPtr = (IntPtr)0;
		object obj = animation + 16;
		obj = this;
		return animation;
	}

	private void DoKeyframeAnimation(int soundIndex)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_001e: Expected Obj, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		KeyFrameAction keyFrameAction = ((List<KeyFrameAction>)(object)TargetObjects).get_Item(soundIndex);
		if ((object)_targetAnimation == null)
		{
			return;
		}
		object obj = _targetAnimation + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _targetAnimation + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			if (~(keyFrameAction.state ? 1u : 0u) == 0)
			{
				((ParticleSystem)obj5).Stop();
			}
			else
			{
				((ParticleSystem)obj5).Clear();
			}
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}

	public unsafe OutfitKeyframeBehaviour()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected Obj, but got Unknown
		//IL_07d0: Expected Obj, but got I4
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Expected Obj, but got Unknown
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected Obj, but got Unknown
		//IL_0828: Expected Obj, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected Obj, but got Unknown
		//IL_070f: Expected Obj, but got I
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected Obj, but got Unknown
		//IL_0879: Expected I, but got Obj
		//IL_088f: Expected Obj, but got I
		//IL_08d5: Expected I4, but got Obj
		//IL_08d5: Expected Obj, but got I4
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected Obj, but got Unknown
		//IL_026e: Expected I, but got Obj
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Unknown
		//IL_0687: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		_initialized = true;
		object obj5 = this + 16;
		GameObject a = gameObject;
		bool flag = _003CDoKeyframeAnimation_003Eb__7_0((KeyFrameAction)(object)a);
		obj5 = flag;
		string text = _targetAnimation.tag;
		AnimationEventBroadcaster component = ((GameObject)(object)text).GetComponent<AnimationEventBroadcaster>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		AnimationEventBroadcaster.SendDoKeyframeAnimationDelegate sendDoKeyframeAnimationDelegate = default;
		((Delegate)sendDoKeyframeAnimationDelegate).method_ptr = method_ptr;
		((Delegate)sendDoKeyframeAnimationDelegate).method = (nint)__ldftn(OutfitKeyframeBehaviour.DoKeyframeAnimation);
		object obj6 = sendDoKeyframeAnimationDelegate + 16;
		obj6 = this;
		component.SendDoKeyframeAnimation -= sendDoKeyframeAnimationDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj13 = default;
		object obj16 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj9 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v80+C]");
					object obj10 = 0 / obj11;
				}
				object obj12 = obj13 + 12;
				obj12 = "DoKeyframeAnimation";
				nint num = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v131 (Il2CppClass<Globals>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num2 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v141 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				((OutfitKeyframeBehaviour)130).DoKeyframeAnimation((int)_targetAnimation);
			}
			object obj15 = obj16 + 1;
		}
		object obj17 = 35;
		object obj18 = obj17 - 8;
		if ((nint)obj17 != 8 && (nint)obj18 != 1 && (nint)obj18 != 2)
		{
			if ((nint)obj18 != 3 && (nint)obj18 != 4 && (nint)obj18 != 5 && (nint)obj18 != 6 && (nint)obj18 != 7)
			{
				if ((nint)obj18 == 8 || (nint)obj18 == 9 || (nint)obj18 == 10)
				{
					goto IL_068c;
				}
				if ((nint)obj18 != 11 && (nint)obj18 != 12 && (nint)obj18 != 13 && (nint)obj18 != 14 && (nint)obj18 != 15 && (nint)obj18 != 16 && (nint)obj18 != 17)
				{
					if ((nint)obj18 == 18 || (nint)obj18 == 19 || (nint)obj18 == 20 || (nint)obj18 == 21)
					{
						goto IL_068c;
					}
					if ((nint)obj18 != 22 && (nint)obj18 != 23 && (nint)obj18 != 24 && (nint)obj18 != 25)
					{
						if ((nint)obj18 == 26)
						{
							goto IL_068c;
						}
						if ((nint)obj18 == 27)
						{
							object obj19 = obj4 + 4;
							object obj20 = obj19 + 1;
							obj19 = obj20;
							object obj21 = obj20 << 2;
							object obj22 = obj4 + obj21;
							obj22 = 258;
						}
					}
				}
			}
			goto IL_08db;
		}
		goto IL_068c;
		IL_068c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj23 = default;
		object obj24 = default;
		if (obj23 == obj24)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_08db;
		IL_08db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj25 = (nint)0 << 2;
			object obj26 = obj4 + obj25;
			if ((nint)obj26 == 258)
			{
				object obj27 = obj4 + 4;
				if ((nint)obj27 > -1)
				{
					object obj28 = obj27 + -1;
					obj27 = obj28;
				}
				return;
			}
		}
		object obj29 = default;
		if (obj29 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private bool _003CDoKeyframeAnimation_003Eb__7_0(KeyFrameAction a)
	{
		//IL_000e: Expected I, but got Obj
		//IL_0169: Expected I4, but got Obj
		//IL_0068: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		Animation component = default;
		Transform parentInternal = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
			while (true)
			{
				int num2 = ((ComputeShader)(object)component).FindKernel((string)null);
				Animation animation = component;
				if (num2 == 0)
				{
					parentInternal = parentInternal.parentInternal;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
					{
						component = parentInternal.GetComponent<Animation>();
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							break;
						}
						continue;
					}
					animation = null;
				}
				return (byte)(int)animation != 0;
			}
		}
	}
}
