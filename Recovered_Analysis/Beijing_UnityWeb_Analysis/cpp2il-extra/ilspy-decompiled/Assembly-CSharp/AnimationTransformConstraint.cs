using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class AnimationTransformConstraint : MonoBehaviour
{
	[Serializable]
	private class ConstraintRange
	{
		public int StartKeyframe;

		public int EndKeyframe;

		public ConstraintRange()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private string _animationName;

	private ConstraintRange _range;

	private string _targetTransformName;

	private Animation _animation;

	private Transform _targetTransform;

	private void Start()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72D5");
	}

	private unsafe Animation FindAnimationInParent(Transform current)
	{
		//IL_018a: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0165: Expected Obj, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 46;
		string text = ((string)(object)this).Substring(num);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num2 = default;
		object obj2 = num2 + 16;
		obj2 = 46;
		object obj3 = text + 12;
		string text2 = ((string)(object)current).Substring(num2);
		object obj4 = text2 + 12;
		object obj5 = 0;
		TypeCode typeCode2;
		TypeCode typeCode3;
		while (true)
		{
			object obj9;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj6 = text + 16;
				object obj7 = obj5 << 2;
				object obj8 = obj6 + obj7;
				TypeCode typeCode = ((int*)obj8)->GetTypeCode();
				obj9 = obj4;
				typeCode2 = typeCode;
			}
			else
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
				{
					return null;
				}
				obj9 = obj4;
				typeCode2 = TypeCode.Empty;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
			{
				object obj10 = text2 + 16;
				object obj11 = obj5 << 2;
				object obj12 = obj10 + obj11;
				typeCode3 = ((int*)obj12)->GetTypeCode();
			}
			else
			{
				typeCode3 = TypeCode.Empty;
			}
			if (typeCode2 != typeCode3)
			{
				break;
			}
			object obj13 = obj5 + 1;
			obj5 = obj13;
		}
		return (Animation)(typeCode2 - typeCode3);
	}

	private void LateUpdate()
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_013f: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I4
		//IL_01be: Expected I, but got Obj
		//IL_01d4: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_00a7: Expected I, but got Obj
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		object obj = this + 24;
		GameObject dataPoints = gameObject;
		IEnumerator enumerator = ((FPSLog)(object)this).Send2GoogleSheet((string)(object)dataPoints);
		obj = enumerator;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v4 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v6 (should have been resolved before IL gen)");
		object obj7 = default;
		object obj6 = obj7 + 12;
		object obj8 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			object obj9 = obj7 + 16;
			object obj10 = obj8 << 2;
			object obj11 = obj9 + obj10;
			UnityEngine.Object a = UnityEngine.Object.Instantiate((UnityEngine.Object)obj11);
			if (!string.Equals((string)(object)a, _targetTransformName))
			{
				object obj12 = obj8 + 1;
				obj8 = obj12;
				continue;
			}
			object obj13 = this + 28;
			obj13 = obj11;
			break;
		}
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_targetTransform != null)
		{
			SDebug.LogFormat("Null target transform.", (object[])(object)this);
			tag = null;
		}
	}

	public unsafe AnimationTransformConstraint()
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_0016: Expected I4, but got Obj
		//IL_0023: Expected Obj, but got I4
		//IL_003d: Expected I4, but got Obj
		//IL_004a: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_013b: Expected VT, but got Obj
		//IL_0183: Expected VT, but got Obj
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 32);
		Transform transform3 = (Transform)(transform2 + 16);
		AnimationState animationState = _animation.get_Item(_animationName);
		if ((object)animationState == null)
		{
			return;
		}
		bool flag = _animation.Play((PlayMode)_animationName);
		float normalizedTime = ((AnimationState)flag).normalizedTime;
		bool flag2 = _animation.Play((PlayMode)_animationName);
		string text = ((AnimationState)flag2).name;
		float normalizedTime2 = ((AnimatorStateInfo*)text)->normalizedTime;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float width = normalizedTime * normalizedTime2;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		ConstraintRange range = _range;
		if ((nint)gUILayoutOption > range.StartKeyframe)
		{
			ConstraintRange range2 = _range;
			if ((nint)gUILayoutOption < range2.EndKeyframe)
			{
				GameObject gameObject = base.gameObject;
				transform3.position = (Vector3)gameObject;
				transform = transform3;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
				Vector3 localPosition = transform.localPosition;
				GameObject gameObject2 = base.gameObject;
				transform2.rotation = (Quaternion)gameObject2;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				Quaternion localRotation = transform.localRotation;
			}
		}
	}
}
