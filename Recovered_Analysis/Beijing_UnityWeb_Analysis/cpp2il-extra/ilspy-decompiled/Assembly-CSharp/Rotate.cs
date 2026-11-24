using System;
using Cpp2ILInjected;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	private Transform m_trans;

	public float Rotate_X;

	public float Rotate_Y;

	public float Rotate_Z;

	public bool PingPong;

	public float Rotate_X_To;

	public float Rotate_Y_To;

	public float Rotate_Z_To;

	public float Rotate_X_Time_Offset;

	public float Rotate_Y_Time_Offset;

	public float Rotate_Z_Time_Offset;

	public float Speed;

	private void Start()
	{
		CancelInvoke();
	}

	private void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 12;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
	}

	public Rotate()
	{
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got F4
		//IL_0055: Expected I, but got Obj
		//IL_006b: Expected Obj, but got I
		//IL_0096: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I4
		//IL_0411: Expected Obj, but got F4
		//IL_01e0: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		if (~(PingPong ? 1u : 0u) == 0)
		{
			float num;
			if (Rotate_X_To == Rotate_X)
			{
				num = 0f;
			}
			else
			{
				float timeSinceLevelLoad = Time.timeSinceLevelLoad;
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S2_v66 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S2_v72 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num4 = timeSinceLevelLoad * Speed;
				float current = num4 + Rotate_X_Time_Offset;
				float target = Rotate_X_To - Rotate_X;
				float num5 = Mathf.DeltaAngle(current, target);
				num = num5 + Rotate_X;
			}
			if (Rotate_Y_To == Rotate_Y)
			{
				float num6 = 0f;
			}
			else
			{
				float timeSinceLevelLoad2 = Time.timeSinceLevelLoad;
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S2_v49 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S2_v55 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num9 = timeSinceLevelLoad2 * Speed;
				float current2 = num9 + Rotate_Y_Time_Offset;
				float target2 = Rotate_Y_To - Rotate_Y;
				float num10 = Mathf.DeltaAngle(current2, target2);
				float num6 = num10 + Rotate_Y;
			}
			if (Rotate_Z_To == Rotate_Z)
			{
				float num11 = 0f;
			}
			else
			{
				float timeSinceLevelLoad3 = Time.timeSinceLevelLoad;
				nint num12 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S2_v32 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num13 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S2_v38 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num14 = timeSinceLevelLoad3 * Speed;
				float current3 = num14 + Rotate_Z_Time_Offset;
				float target3 = Rotate_Z_To - Rotate_Z;
				float num15 = Mathf.DeltaAngle(current3, target3);
				float num11 = num15 + Rotate_Z;
			}
			obj = 0;
			_ = 0;
			obj = num;
			transform = (Transform)obj;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 localEulerAngles = transform.localEulerAngles;
		}
		else
		{
			float unscaledTime = Time.unscaledTime;
			float num16 = Rotate_X * unscaledTime;
			float unscaledTime2 = Time.unscaledTime;
			float num17 = Rotate_Y * unscaledTime2;
			float unscaledTime3 = Time.unscaledTime;
			float num18 = Rotate_Z * unscaledTime3;
			obj = 0;
			_ = 0;
			obj = num16;
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			m_trans.LookAt(transform);
		}
	}
}
