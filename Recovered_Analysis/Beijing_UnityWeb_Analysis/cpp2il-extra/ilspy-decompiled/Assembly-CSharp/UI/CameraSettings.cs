using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class CameraSettings
{
	private Dictionary<Type, object> _defaultValues;

	private int layer__BackingField;

	private CameraClearFlags clearFlags__BackingField;

	private float nearClipPlane__BackingField;

	private float farClipPlane__BackingField;

	private static CameraSettings _renderTextureCameraSettings;

	public int layer
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_036b: Expected Obj, but got Unknown
			//IL_0374: Expected Obj, but got I4
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03a4: Expected I, but got Obj
			//IL_03ba: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected Obj, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected Obj, but got Unknown
			//IL_0125: Expected Obj, but got I4
			//IL_01ad: Expected Obj, but got I
			//IL_04d3: Expected I, but got Obj
			//IL_04e9: Expected Obj, but got I
			//IL_0266: Expected Obj, but got I
			//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Expected Obj, but got Unknown
			//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f3: Expected Obj, but got Unknown
			//IL_041f: Expected Obj, but got I4
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected Obj, but got Unknown
			//IL_031e: Expected I, but got Obj
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected Obj, but got Unknown
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected Obj, but got Unknown
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			nint num = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<LeaderboardDummyData>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(LeaderboardDummyData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v125 (Il2CppClass<LeaderboardDummyData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			int num3 = 1;
			object obj6 = default;
			object obj7 = default;
			int result = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v111+C]");
					if (0 > (nint)obj7)
					{
						int num4 = num3 + 1;
						num3 = num4;
						continue;
					}
					object obj8 = obj4 + 4;
					object obj9 = obj8 + 1;
					obj8 = obj9;
					object obj10 = obj9 << 2;
					object obj11 = obj4 + obj10;
					obj11 = 82;
					result = num3;
					break;
				}
				object obj12 = obj4 + 4;
				object obj13 = obj12 + 1;
				obj12 = obj13;
				object obj14 = obj13 << 2;
				object obj15 = obj4 + obj14;
				obj15 = 69;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj16 = (nint)0 << 2;
				object obj17 = obj4 + obj16;
				if ((nint)obj17 == 82)
				{
					object obj18 = obj4 + 4;
					if ((nint)obj18 > -1)
					{
						object obj19 = obj18 + -1;
						obj18 = obj19;
					}
					goto IL_04c0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj20 = (nint)0 << 2;
				object obj21 = obj4 + obj20;
				if ((nint)obj21 == 69)
				{
					object obj22 = obj4 + 4;
					if ((nint)obj22 > -1)
					{
						object obj23 = obj22 + -1;
						obj22 = obj23;
					}
					goto IL_04c5;
				}
			}
			object obj24 = default;
			if (obj24 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_04c5;
			IL_04c0:
			return result;
			IL_04c5:
			nint num5 = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v47 (Il2CppClass<LeaderboardDummyData>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num6 = (nint)typeof(LeaderboardDummyData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v58 (Il2CppClass<LeaderboardDummyData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<LeaderboardDummyData.LeaderboardDummy> dummyData = LeaderboardDummyData.dummyData;
			int num7 = dummyData._size + 1;
			result = num7;
			goto IL_04c0;
		}
		set
		{
			((GameOverLeaderboardHandler)this).ScrollToMyPosition();
		}
	}

	public CameraClearFlags clearFlags
	{
		get
		{
			return (CameraClearFlags)layer__BackingField;
		}
		set
		{
			layer__BackingField = (int)value;
		}
	}

	public float nearClipPlane
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			float result = default;
			return result;
		}
		set
		{
			//IL_00b1: Expected I, but got Obj
			//IL_00c7: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (value < 0f)
			{
				float num3 = 0f;
			}
			else if (value > 1f)
			{
				float num3 = 1f;
			}
			else
			{
				float num3 = value;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		}
	}

	public float farClipPlane
	{
		get
		{
			return nearClipPlane__BackingField;
		}
		set
		{
			nearClipPlane__BackingField = value;
		}
	}

	public Color backgroundColor
	{
		get
		{
			Color result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected Obj, but got I
			object obj = value + 28;
			CameraSettings cameraSettings = (CameraSettings)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			_defaultValues = (Dictionary<Type, object>)0;
		}
	}

	public float depth
	{
		get
		{
			return farClipPlane__BackingField;
		}
		set
		{
			farClipPlane__BackingField = value;
		}
	}

	public unsafe int fieldOfView
	{
		get
		{
			return (int)clearFlags__BackingField;
		}
		set
		{
			//IL_000d: Expected Obj, but got I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			object obj = ((int*)value)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
			_ = 0;
			object obj2 = this + 28;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
	}

	public CameraSettings()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public void ApplySettingsToCamera(Camera camera, CameraSettings overrideCameraSettings)
	{
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected I4, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00fc: Expected I4, but got Obj
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0148: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.DUMMY_FRIEND;
		nint num = (nint)typeof(LeaderboardDummyData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v6 (Il2CppClass<LeaderboardDummyData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v15 (Il2CppClass<LeaderboardDummyData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = leaderboardGameoverCell + 16;
		int index = camera - 1;
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy = LeaderboardDummyData.dummyData.get_Item(index);
		obj2 = leaderboardDummy;
		object obj3 = overrideCameraSettings & 1;
		int rank = (int)(obj3 + (object)camera);
		leaderboardGameoverCell.rank = rank;
		object obj4 = camera & 1;
		bool useDarkColour = obj4 == null;
		leaderboardGameoverCell.useDarkColour = useDarkColour;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CameraSettings)+20]");
		((List<LeaderboardGameoverCell>)0).Add(leaderboardGameoverCell);
	}

	private T GetValue<T>(T overrideValue, T defaultCameraValue)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		}
		else
		{
			object obj2 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44 @ S3_v5 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	private T GetDefaultValue<T>()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0138: Expected VT, but got I4
		object obj2 = default;
		object obj = obj2 + 28;
		object obj3 = obj2 + 16;
		object obj4 = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CameraSettings)+4]");
		if ((nint)0 == -1)
		{
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9+8]");
			_ = 0;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			_ = 0;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9+C]");
			bool flag = (nint)0 != 0;
		}
		else
		{
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9+8]");
			_ = 0;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
		bool flag2 = (nint)0 != 0;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		return (T)flag2;
	}

	public static void ApplyRenderTextureCameraSettings(Camera camera, CameraSettings overrideCameraSettings = null)
	{
	}

	static CameraSettings()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00d1: Expected VT, but got Obj
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got F4
		//IL_0111: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v29 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 up = Vector2.up;
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = obj3;
		object obj4 = obj3 + 28;
		obj4 = obj2;
		DiscountButton.SHADOW_OFFSET = (Vector2)obj4;
		object obj5 = obj3 + 16;
		obj5 = 0;
		_ = 0;
		obj5 = 0f;
		_ = 6f;
		_ = 0f;
		nint num3 = (nint)typeof(DiscountButton);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24 (Il2CppClass<UI.DiscountButton>)+5C]");
		object obj6 = (nint)0 + (nint)8;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v8+8]");
		_ = 0;
	}
}
