using System;
using Cpp2ILInjected;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Cameras;
using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
	private const float MinCameraSpeedDelta = 0.15f;

	public Vector3 vector;

	public float MaxMagnitude;

	public float Speed;

	public Transform model;

	private CharacterCamera characterCamera;

	private float _speedMultiplier;

	private float _lastCameraSpeed;

	private Vector3 _startLocal;

	public unsafe float SpeedMultiplier
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			//IL_0040: Expected VT, but got I
			//IL_005a: Expected VT, but got I
			//IL_0071: Expected Obj, but got I
			BoxCollider boxCollider = default;
			Transform transform = (Transform)(boxCollider + 24);
			transform.position = vector;
			BoxCollider boxCollider2 = (BoxCollider)(boxCollider + 12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (MoveGameObject)+10]");
			boxCollider2.center = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (MoveGameObject)+10]");
			boxCollider.size = (Vector3)0;
			object obj = (nint)((UnityEngine.Object)transform).m_CachedPtr + (nint)((UnityEngine.Object)boxCollider2).m_CachedPtr;
			float num = 0.5f * (float)(nint)((UnityEngine.Object)boxCollider).m_CachedPtr;
			return (float)obj + num;
		}
		set
		{
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected Obj, but got Unknown
			//IL_014b: Expected Obj, but got I4
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected Obj, but got Unknown
			//IL_0168: Expected Obj, but got I4
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected Obj, but got Unknown
			//IL_0189: Expected Obj, but got I4
			//IL_019a: Expected VT, but got Obj
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			//IL_003c: Expected Obj, but got F4
			//IL_004f: Expected Obj, but got I4
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected Obj, but got Unknown
			//IL_009e: Expected I, but got Obj
			//IL_00b4: Expected Obj, but got I
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected Obj, but got Unknown
			//IL_01d5: Expected Obj, but got I
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected Obj, but got Unknown
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected VT, but got Unknown
			//IL_0206: Expected F4, but got Obj
			//IL_0201: Expected native int or pointer, but got VT
			//IL_021b: Expected VT, but got Obj
			//IL_0133: Expected Obj, but got I4
			//IL_00df: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 44;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 16;
			obj3 = 0;
			Transform transform = (Transform)(obj2 + 32);
			bool isExpanded = ((TableElementAlwaysVisible)this).IsExpanded;
			GameObject gameObject = ((Component)isExpanded).gameObject;
			transform.localPosition = (Vector3)gameObject;
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj4 = obj + 4;
			float num = (float)obj4 + value;
			obj4 = num;
			bool isExpanded2 = ((TableElementAlwaysVisible)this).IsExpanded;
			GameObject gameObject2 = ((Component)isExpanded2).gameObject;
			Transform transform2 = (Transform)(obj2 - -64);
			transform2 = (Transform)obj;
			Transform transform3 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform2.eulerAngles;
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v23 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num3 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v40 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 one = Vector2.one;
			object obj6 = obj2 + 24;
			bool isExpanded3 = ((TableElementAlwaysVisible)this).IsExpanded;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v31 (System.Boolean)+104]");
			obj6 = 0;
			object obj7 = obj2 + 8;
			obj7 = obj3;
			Vector2 vector = (Vector2)(obj2 + 56);
			((Vector2*)(nint)vector)->x = (float)obj6;
			transform2 = (Transform)obj7;
			Vector2 vector2 = vector * (Vector2)transform2;
			transform2 = (Transform)obj2;
			((UIPanel)isExpanded3).clipTexture = (Texture2D)(object)transform2;
		}
	}

	public void UpdatePosition(Vector3 localPos)
	{
		//IL_00c6: Expected Obj, but got VT
		//IL_0038: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		Component component = ((GameObject)localPos).GetComponent((Type)(object)"Player");
		if ((object)component == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (MoveGameObject)+14]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num = (nint)typeof(EventArgs);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v6 (Il2CppClass<System.EventArgs>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v11 (Il2CppClass<System.EventArgs>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
	}

	public void Update()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public unsafe MoveGameObject()
	{
		//IL_02c4: Expected I, but got Obj
		//IL_02da: Expected Obj, but got I
		//IL_030f: Expected I, but got Obj
		//IL_0325: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected VT, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I4
		//IL_015d: Expected VT, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_016f: Expected F4, but got Obj
		//IL_016a: Expected native int or pointer, but got VT
		//IL_0181: Expected F4, but got I
		//IL_017c: Expected native int or pointer, but got VT
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got F4
		//IL_01fa: Expected VT, but got Obj
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0236: Expected I, but got Obj
		//IL_024c: Expected Obj, but got I
		//IL_03ea: Expected F4, but got Obj
		//IL_03e5: Expected native int or pointer, but got VT
		//IL_03ff: Expected F4, but got I
		//IL_03fa: Expected native int or pointer, but got VT
		//IL_0459: Expected F4, but got Obj
		//IL_0454: Expected native int or pointer, but got VT
		//IL_046e: Expected F4, but got I
		//IL_0469: Expected native int or pointer, but got VT
		//IL_047b: Expected VT, but got Obj
		//IL_048c: Expected F4, but got Obj
		//IL_0487: Expected native int or pointer, but got VT
		//IL_04a1: Expected F4, but got I
		//IL_049c: Expected native int or pointer, but got VT
		//IL_04aa: Expected Obj, but got VT
		//IL_0277: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (this.characterCamera != null)
		{
			nint num3 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v72 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CharacterCamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v78 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = this + 36;
			int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
			obj3 = selectedBenchmarkIndex;
		}
		CharacterCamera characterCamera = this.characterCamera;
		nint num5 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S2_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v24 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		Vector3 vector = (Vector3)(obj5 + 60);
		Transform transform = (Transform)(obj5 + 48);
		float value = _lastCameraSpeed - characterCamera._speed;
		float num7 = Math.Abs(value);
		if (num7 > 0.15f)
		{
			CharacterCamera characterCamera2 = this.characterCamera;
			_lastCameraSpeed = characterCamera2._speed;
			GameObject gameObject = base.gameObject;
			transform.localPosition = (Vector3)gameObject;
			((Vector3*)(nint)vector)->x = (float)transform;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			object obj6 = this + 48;
			obj6 = vector.x;
			_ = vector.z;
		}
		Transform transform2 = (Transform)(obj5 + 36);
		object obj7 = obj5 + 24;
		object obj8 = obj5 + 12;
		CharacterCamera characterCamera3 = this.characterCamera;
		Speed = characterCamera3._speed;
		CharacterCamera characterCamera4 = this.characterCamera;
		if (!(characterCamera4._speed > 0f))
		{
			return;
		}
		object obj9 = _lastCameraSpeed & 0x7FFFFFFF;
		if ((nint)obj9 == 2139095040)
		{
			return;
		}
		GameObject gameObject2 = base.gameObject;
		transform2.localPosition = (Vector3)gameObject2;
		float unscaledTime = Time.unscaledTime;
		object obj10 = this + 12;
		obj7 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v28+8]");
		_ = 0;
		nint num8 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v45 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num9 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj7;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v21+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		float num10 = _lastCameraSpeed * _speedMultiplier;
		float angle = num10 * unscaledTime;
		Quaternion quaternion = Quaternion.AngleAxis(angle, vector);
		transform = transform2;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v23+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = (Vector3)transform - vector;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
	}
}
