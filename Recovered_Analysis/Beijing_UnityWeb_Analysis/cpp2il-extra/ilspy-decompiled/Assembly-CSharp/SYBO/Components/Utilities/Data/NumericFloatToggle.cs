using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Missions;
using SYBO.Components.Base.Interfaces;
using SYBO.Components.Utilities.Components;
using SYBO.Components.Utilities.Tickable;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Components.Utilities.Data;

[Serializable]
public class NumericFloatToggle : NumericToggle, IChangeable
{
	private float _value;

	private float _valueOriginal;

	public float Value
	{
		get
		{
			int dailyChallengesInRow = ((DailyChallengesInRowAward)(object)this).GetDailyChallengesInRow();
			int totalCompletedTiers = ((AwardsManager)null).GetTotalCompletedTiers();
			int num = dailyChallengesInRow / totalCompletedTiers;
			return (float)num * 100f;
		}
		set
		{
			//IL_0056: Expected Obj, but got I4
			//IL_00a1: Invalid comparison between F4 and I4
			bool showInspectorMessage = base._showInspectorMessage;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v13 (System.Boolean)+C]");
			int num = 0;
			while (true)
			{
				int num2 = num - 1;
				if (num2 < 0)
				{
					break;
				}
				bool showInspectorMessage2 = base._showInspectorMessage;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v22 (System.Boolean)+C]");
				if ((nint)0 > (nint)num2)
				{
					RuntimePlatform platform = Application.platform;
					ITickable tickable = ((List<ITickable>)base._showInspectorMessage).get_Item(num2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.Data.NumericFloatToggle)+19]");
					bool flag = (nint)0 != 0;
					if (platform != RuntimePlatform.OSXEditor)
					{
						bool flag2 = _value != 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8631");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8631");
						bool flag2 = false;
					}
				}
				num = num2;
			}
		}
	}

	public NumericFloatToggle()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NumericIntToggle numericIntToggle = default;
		int value = default;
		numericIntToggle.Value = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public unsafe NumericFloatToggle(float value, bool isEnabled = true, string inspectorMessage = "(Default)")
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected VT, but got Unknown
		//IL_0185: Expected F4, but got Obj
		//IL_0180: Expected native int or pointer, but got VT
		//IL_019a: Expected F4, but got I
		//IL_0195: Expected native int or pointer, but got VT
		//IL_005b: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got F4
		//IL_00e5: Expected F4, but got Obj
		//IL_00e0: Expected native int or pointer, but got VT
		//IL_00fa: Expected F4, but got I
		//IL_00f5: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = inspectorMessage;
		_ = inspectorMessage.m_stringLength;
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v35 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Rect rect = (Rect)(obj2 + 32);
		((Rect*)(nint)rect)->m_XMin = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Rect*)(nint)rect)->m_Width = 0f;
		Color backgroundColor = GUI.backgroundColor;
		int sleepTimeout = Screen.sleepTimeout;
		int height = Screen.height;
		obj2 = 0;
		_ = 0;
		obj2 = 10f;
		float num3 = (float)sleepTimeout - 20f;
		float num4 = num3 - 10f;
		float num5 = (float)(isEnabled ? 1 : 0) * 20f;
		float num6 = num4 - num5;
		float num7 = (float)height - 20f;
		float num8 = num7 * value;
		_ = 20f;
		((Rect*)(nint)rect)->m_XMin = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Rect*)(nint)rect)->m_Width = 0f;
		string text = GUI.TextField(rect, (string)(object)this);
	}

	private void Initialize(float value, bool isEnabled, string message)
	{
		//IL_0018: Expected I4, but got Obj
		((SetActiveComponent)(object)this).Awake();
		((RouteBuilder)(object)this).BuildChunks(value, isEnabled ? ChunkBuildMode.Normal : ChunkBuildMode.None, (ChunkBuildMode)message);
	}

	public void Reset()
	{
		//IL_0020: Expected I4, but got Obj
		((SetActiveComponent)(object)this).Awake();
		((RouteBuilder)(object)this).BuildChunks(-1f, ChunkBuildMode.None, (ChunkBuildMode)"(Default)");
	}

	public void SoftReset()
	{
		//IL_002a: Expected I4, but got Obj
		bool isEnabledOriginal = base._isEnabledOriginal;
		((RouteBuilder)(object)this).BuildChunks(_valueOriginal, isEnabledOriginal ? ChunkBuildMode.Normal : ChunkBuildMode.None, (ChunkBuildMode)base._inspectorMessageOriginal);
	}

	protected override bool IsOriginalValue()
	{
		return base._isEnabled;
	}
}
