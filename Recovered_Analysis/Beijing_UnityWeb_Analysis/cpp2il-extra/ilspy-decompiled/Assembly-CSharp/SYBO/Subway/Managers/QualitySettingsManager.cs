using System;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Hoverboards;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level;
using UnityEngine;

namespace SYBO.Subway.Managers;

public class QualitySettingsManager : SingletonMonoBehaviour<QualitySettingsManager>
{
	public class QualityTypeChangedEventArgs : EventArgs
	{
		public QualityType QualityType
		{
			get
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs)+C]");
				return QualityType.Default;
			}
			internal set
			{
				field = value;
			}
		}

		public QualityTypeChangedEventArgs(QualityType qualityType)
		{
			QualityType__BackingField = qualityType;
		}
	}

	private const string _QUALITY_LEVEL_NAME_GOOD = "Good";

	private const string _QUALITY_LEVEL_NAME_DEMO_VIDEO_MODE = "Demo Video Mode";

	private EventHandler<QualityTypeChangedEventArgs> m_OnQualityTypeChanged;

	public event EventHandler<QualityTypeChangedEventArgs> OnQualityTypeChanged
	{
		add
		{
			//IL_01ef: Expected I, but got Obj
			//IL_0205: Expected Obj, but got I
			//IL_023c: Expected Obj, but got I
			//IL_0063: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0086: Expected Obj, but got I
			//IL_00a9: Expected Obj, but got I
			//IL_00cc: Expected Obj, but got I
			//IL_00ef: Expected Obj, but got I
			//IL_0112: Expected Obj, but got I
			//IL_0135: Expected Obj, but got I
			//IL_0158: Expected Obj, but got I
			//IL_017b: Expected Obj, but got I
			//IL_019e: Expected Obj, but got I
			//IL_01c1: Expected Obj, but got I
			string obj = ((Component)(object)value).tag;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+4]");
			string obj3 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+8]");
			string obj4 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+C]");
			string obj5 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+10]");
			string obj6 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+14]");
			string obj7 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+18]");
			string obj8 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+1C]");
			string obj9 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj9);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+20]");
			string obj10 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj10);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+24]");
			string obj11 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+28]");
			string obj12 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+2C]");
			string obj13 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+30]");
			string obj14 = ((Component)0).tag;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj14);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnQualityTypeChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	protected override void SubclassInitialize()
	{
	}

	public void SetQualityType(QualityType qualityType)
	{
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnQualityTypeChanged;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)qualityType);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 16;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private int GetQualityLevelIntFromName(string qualityLevelName)
	{
		//IL_1ea3: Expected I, but got Obj
		//IL_1eb9: Expected Obj, but got I
		//IL_1edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee4: Expected Obj, but got Unknown
		//IL_1eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef2: Expected Obj, but got Unknown
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0380: Expected I, but got Obj
		//IL_0396: Expected Obj, but got I
		//IL_01e6: Expected I, but got Obj
		//IL_056b: Expected I, but got Obj
		//IL_0581: Expected Obj, but got I
		//IL_03c1: Expected I, but got Obj
		//IL_0756: Expected I, but got Obj
		//IL_076c: Expected Obj, but got I
		//IL_05ac: Expected I, but got Obj
		//IL_0941: Expected I, but got Obj
		//IL_0957: Expected Obj, but got I
		//IL_0797: Expected I, but got Obj
		//IL_0b24: Expected I, but got Obj
		//IL_0b3a: Expected Obj, but got I
		//IL_0982: Expected I, but got Obj
		//IL_0d0f: Expected I, but got Obj
		//IL_0d25: Expected Obj, but got I
		//IL_0b65: Expected I, but got Obj
		//IL_0efa: Expected I, but got Obj
		//IL_0f10: Expected Obj, but got I
		//IL_0d50: Expected I, but got Obj
		//IL_10cb: Expected I, but got Obj
		//IL_10e1: Expected Obj, but got I
		//IL_0f3b: Expected I, but got Obj
		//IL_129c: Expected I, but got Obj
		//IL_12b2: Expected Obj, but got I
		//IL_110c: Expected I, but got Obj
		//IL_146d: Expected I, but got Obj
		//IL_1483: Expected Obj, but got I
		//IL_12dd: Expected I, but got Obj
		//IL_163e: Expected I, but got Obj
		//IL_1654: Expected Obj, but got I
		//IL_14ae: Expected I, but got Obj
		//IL_180f: Expected I, but got Obj
		//IL_1825: Expected Obj, but got I
		//IL_167f: Expected I, but got Obj
		//IL_19e0: Expected I, but got Obj
		//IL_19f6: Expected Obj, but got I
		//IL_1850: Expected I, but got Obj
		//IL_1bb1: Expected I, but got Obj
		//IL_1bc7: Expected Obj, but got I
		//IL_1a21: Expected I, but got Obj
		//IL_1c9b: Expected I, but got Obj
		//IL_1cb1: Expected Obj, but got I
		//IL_1cce: Expected I, but got Obj
		//IL_1bf2: Expected I, but got Obj
		//IL_21bd: Expected Obj, but got I
		//IL_1daf: Expected I, but got Obj
		//IL_1dc5: Expected Obj, but got I
		//IL_1cea: Expected I, but got Obj
		//IL_1cf8: Expected I, but got Obj
		//IL_1df0: Expected I, but got Obj
		//IL_1d26: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v717 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 104;
		object obj4 = obj3 + 52;
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks0)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num3 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v26 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v681 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks1)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num5 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v33 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v645 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks1ShadowMid)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num7 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v40 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S0_v609 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks1ShortShadowStart)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num9 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v47 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S0_v573 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks1ShortShadowEnd)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num11 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S0_v54 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num12 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S0_v537 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks2)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num13 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ S0_v61 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num14 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ S0_v501 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks2ShadowMid)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num15 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S0_v68 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num16 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ S0_v465 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks2ShortShadowStart)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num17 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ S0_v75 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num18 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ S0_v430 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks2ShortShadowEnd)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num19 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ S0_v82 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num20 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ S0_v395 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks3)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num21 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ S0_v89 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num22 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1188 @ S0_v360 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks3ShadowStart)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num23 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1256 @ S0_v96 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num24 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ S0_v325 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks3ShadowMid)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num25 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ S0_v103 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num26 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ S0_v290 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks3ShadowEnd)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num27 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1460 @ S0_v110 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num28 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ S0_v255 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks3ShortShadowStart)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num29 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1562 @ S0_v117 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num30 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ S0_v220 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks3ShortShadowEnd)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num31 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1664 @ S0_v124 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num32 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1698 @ S0_v185 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks3Gates)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num33 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1765 @ S0_v131 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		bool flag = obj20 == null;
		nint num34 = (nint)typeof(EnvironmentBaseInfo);
		if (!flag)
		{
			nint num35 = (nint)typeof(EnvironmentBaseInfo);
			num34 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1773 @ S0_v170 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num34 = (nint)typeof(EnvironmentBaseInfo);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ L2_v35 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj21 = -(-64);
		if ((EnvironmentBaseInfo)(object)qualityLevelName != (EnvironmentBaseInfo)obj21)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		nint num36 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1812 @ S0_v138 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num37 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1819 @ S0_v155 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((EnvironmentBaseInfo)(object)qualityLevelName != EnvironmentBaseInfo.Tracks3Special)
		{
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+8]");
			_ = 0;
			_ = this.m_OnQualityTypeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.QualitySettingsManager)+30]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		int result = default;
		return result;
	}

	private bool HasQualityLevelIntFromName(string qualityLevelName)
	{
		//IL_0017: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		ColorSpace activeColorSpace = QualitySettings.activeColorSpace;
		object obj = activeColorSpace + 12;
		bool flag = false;
		while (true)
		{
			if ((flag ? 1 : 0) >= (nint)obj)
			{
				flag = true;
				break;
			}
			object obj2 = activeColorSpace + 16;
			object obj3 = (flag ? 1u : 0u) << 2;
			object obj4 = obj2 + obj3;
			if ((string)obj4 != qualityLevelName)
			{
				break;
			}
			bool flag2 = (byte)((flag ? 1u : 0u) + 1u) != 0;
			flag = flag2;
		}
		return flag;
	}

	private void SetQualityLevel(int qualityLevel)
	{
		switch (qualityLevel)
		{
		case 0:
			DebugLogQualitySettings("Good");
			break;
		case 1:
			DebugLogQualitySettings("Demo Video Mode");
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LightningEffectTrigger._003CDelayedDisable_003Ed__8 obj = default;
		obj._002Ector(qualityLevel);
		((SceneViewWindowManager)(object)this).Character = (Character)(object)obj;
	}

	private void SetQualityLevel(string qualityLevelName)
	{
		//IL_000f: Expected Obj, but got I4
		Bounds bounds = ((Renderer)1).bounds;
		((QualitySettingsManager)null).RaiseOnQualityLevelChanged((QualityTypeChangedEventArgs)null);
	}

	private void DebugLogQualitySettings(string callingMethodName)
	{
		//IL_0035: Expected I4, but got Obj
		//IL_001d: Expected Obj, but got I4
		if (((InputManager)null).AnalyzeSwipe((Swipe)(object)callingMethodName) != SwipeDir.Up)
		{
			bool flag = ((QualitySettingsManager)null).HasQualityLevelIntFromName(callingMethodName);
			SetQualityLevel((string)flag);
		}
		else
		{
			string msg = string.ConcatArray((string[])(object)"No qualityLevelInt available for qualityLevelName: ", (int)callingMethodName);
			SDebug.LogFormat(msg, null);
		}
	}

	private void RaiseOnQualityLevelChanged(QualityTypeChangedEventArgs e)
	{
		string[] names = QualitySettings.names;
	}

	public QualitySettingsManager()
	{
		//IL_001d: Expected VT, but got I4
		GameObject childTransform = gameObject;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.DynamicManagers, (Vector3)0);
		Character instance = Character.Instance;
	}
}
