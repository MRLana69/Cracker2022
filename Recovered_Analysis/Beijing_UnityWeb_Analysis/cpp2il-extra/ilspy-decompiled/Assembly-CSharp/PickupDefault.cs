using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Pickups;
using SYBO.Subway.UI;
using UnityEngine;
using UnityEngine.Rendering;

public class PickupDefault : MonoBehaviour
{
	public delegate void ActivateDelegate();

	public MeshRenderer meshRenderer;

	public Glow glow;

	public MeshRenderer[] rings;

	public bool ShouldSpawnParticles;

	private Collider parentCollider;

	public ActivateDelegate ActivatePickup;

	private bool IsActive__BackingField;

	public bool IsVisible => (object)glow != null;

	public bool IsActive
	{
		get
		{
			//IL_008a: Expected I, but got Obj
			//IL_00a0: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0069: Expected I4, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)meshRenderer).FindKernel((string)null) != 0)
			{
				string sortingLayerName = meshRenderer.sortingLayerName;
				return (byte)(int)sortingLayerName != 0;
			}
			return false;
		}
		private set
		{
			//IL_007f: Expected I, but got Obj
			//IL_0095: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006b: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)meshRenderer).FindKernel((string)null) != 0)
			{
				meshRenderer.shadowCastingMode = (value ? ShadowCastingMode.On : ShadowCastingMode.Off);
				tag = (string)value;
			}
		}
	}

	private void Awake()
	{
		CancelInvoke();
	}

	public static PickupType ConvertSubclassInstanceToPickupType(PickupDefault pickupDefault)
	{
		return pickupDefault.IsActive__BackingField ? PickupType.Key : ((PickupType)0);
	}

	private Collider FindParentCollider(Transform current)
	{
		//IL_0009: Expected Obj, but got I4
		Transform transform = (Transform)0;
		return null;
	}

	private void SetVisible(bool isVisible)
	{
		IsActive__BackingField = isVisible;
	}

	private unsafe void OnActivate()
	{
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_00eb: Expected I, but got Obj
		//IL_0138: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I
		//IL_0179: Expected I, but got Obj
		TrackObject component = GetComponent<TrackObject>();
		bool flag = (object)component == null;
		bool flag2 = !flag;
		TrackObject trackObject = component;
		if (!flag2)
		{
			string text = tag;
			TrackObject trackObject2 = ((GameObject)(object)text).AddComponent<TrackObject>();
			trackObject = trackObject2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(PickupDefault.OnActivate);
		object obj = action + 16;
		obj = this;
		trackObject.OnActivate -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(PickupDefault.OnDeactivate);
		object obj2 = action2 + 16;
		obj2 = this;
		trackObject.OnDeactivate -= action2;
		object obj3 = this + 28;
		GameObject gameObject = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CA1");
		object obj4 = default;
		obj3 = obj4;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (parentCollider != null)
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v31 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v37 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = MergeLevelStartHelp.IsValidLoadedLevelNameForGameplay();
		}
		((AndroidIncomingCallBridge)this).onPhoneStateChanged += null;
	}

	private void OnDeactivate()
	{
		//IL_0049: Expected Obj, but got I4
		parentCollider.isTrigger = true;
		if (ActivatePickup != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		((AndroidIncomingCallBridge)this).onPhoneStateChanged += (AndroidIncomingCallBridge.IncomingCallEvent)1;
	}

	private void OnValidate()
	{
		((AndroidIncomingCallBridge)this).onPhoneStateChanged += null;
	}

	public void Activate()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_008a: Expected I, but got Obj
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>(true);
		object obj = componentsInParent + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = componentsInParent + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			Mesh mesh = ((MeshFilter)obj5).mesh;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = mesh != null;
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
	}

	public void Deactivate()
	{
		//IL_00db: Expected Obj, but got I4
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I4
		//IL_0063: Expected I, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		if (ActivatePickup != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)parentCollider).FindKernel((string)null) != 0)
		{
			parentCollider.isTrigger = true;
		}
		((AndroidIncomingCallBridge)this).onPhoneStateChanged += (AndroidIncomingCallBridge.IncomingCallEvent)1;
	}

	public PickupDefault()
	{
		string text = tag;
		((GameObject)(object)text).tag = null;
		((AndroidIncomingCallBridge)this).onPhoneStateChanged += null;
	}
}
