using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class PropBlendShapeController : MonoBehaviour
{
	[Serializable]
	private class BlendShapeLink
	{
		public int BlendShapeIndex;

		public int BlendShapeControllerIndex;

		public BlendShapeLink()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private BlendShapeLink[] _blendShapeLinks;

	private SkinnedMeshRenderer _renderer;

	private AvatarAnimations _avatarAnimations;

	private void Start()
	{
		CancelInvoke();
	}

	private void Update()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got VT
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		object obj = this + 16;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj = componentInChildren;
		object obj2 = this + 20;
		GameObject gameObject = base.gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		int num = StorageSizeLogging.LogOverallUsage((string)(object)this, (List<string>)(object)parentInternal);
		obj2 = num;
	}

	private AvatarAnimations GetAvatarAnimationsInAncestors(Transform transform)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		object obj = this + 8;
		object obj2 = transform & 0x1F;
		object obj3 = 1 << (int)obj2;
		object obj4 = obj & obj3;
		bool flag = obj4 != null;
		return (AvatarAnimations)flag;
	}

	public PropBlendShapeController()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_00a3: Expected VT, but got I
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		object obj = _blendShapeLinks + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _blendShapeLinks + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			object obj6 = obj5;
			AvatarAnimations avatarAnimations = _avatarAnimations;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v8+C]");
			float correspondingAlphaValue = ((IngameScreen)(object)avatarAnimations).GetCorrespondingAlphaValue(IngameScreen.SpeedometerState.inactive);
			float num = PlanarRealtimeReflection.sgn(correspondingAlphaValue);
			float num2 = num * 100f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v8+8]");
			Color color = (Color)0 * num2;
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
	}
}
