using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class BubbleEvent : CharacterCustomizationProp
{
	private sealed class _003CBlowBubbles_003Ed__4(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BubbleEvent _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0051: Expected F4, but got I
			//IL_0051: Expected F4, but got I
			//IL_0096: Expected Obj, but got I
			BubbleEvent bubbleEvent = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (BubbleEvent)+C]");
					bool flag = ((Animation)0).Play();
					IEnumerator routine = bubbleEvent.BlowBubbles();
					Coroutine coroutine = bubbleEvent.StartCoroutine(routine);
				}
				return false;
			}
			_003C_003E1__state = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (BubbleEvent)+14]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (BubbleEvent)+10]");
			float num2 = UnityEngine.Random.Range(num, 0f);
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private Animation _animation;

	private float randomMax = 5f;

	private float randomMin;

	public unsafe override void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected VT, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected VT, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected VT, but got Unknown
		//IL_014f: Expected I, but got Obj
		//IL_0174: Expected F4, but got I
		//IL_016f: Expected native int or pointer, but got VT
		//IL_0182: Expected F4, but got VT
		//IL_017d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		Transform transform = base.transform;
		transform.parent = characterRig.headJoint;
		Transform transform2 = base.transform;
		_ = -1079194419;
		_ = -1079194419;
		_ = 4464688525043826688L;
		_ = 4464688525043826688L;
		Vector3 localPosition = vector + 48;
		transform2.localPosition = localPosition;
		Transform transform3 = base.transform;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		_ = -(float)Math.PI;
		_ = -0.060039327f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Vector3 euler = vector + 32;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		transform3.localRotation = localRotation;
		Transform transform4 = base.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v35 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v36 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform4.localScale = vector;
		Animation component = GetComponent<Animation>();
		_animation = component;
		IEnumerator routine = BlowBubbles();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator BlowBubbles()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
