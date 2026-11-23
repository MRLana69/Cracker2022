using System;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Subway.Managers;

public class QualitySettingsManager : SingletonMonobehavior<QualitySettingsManager>
{
	public class QualityTypeChangedEventArgs : EventArgs
	{
		public QualityType QualityType
		{
			get
			{
				return field;
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
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 12;
			Delegate obj2 = this.m_OnQualityTypeChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 12;
			Delegate obj2 = this.m_OnQualityTypeChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	protected override void Initialize()
	{
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.DynamicManagers);
	}

	protected void Awake()
	{
		bool isEnabled = DemoVideoModeManager.IsEnabled;
	}

	public void SetQualityType(QualityType qualityType)
	{
		bool flag = qualityType == QualityType.Default;
		object qualityLevel = "Good";
		if (!flag)
		{
			if (qualityType != QualityType.DemoVideoMode)
			{
				goto IL_0035;
			}
			qualityLevel = "Demo Video Mode";
		}
		SetQualityLevel((string)qualityLevel);
		goto IL_0035;
		IL_0035:
		QualityTypeChangedEventArgs e = default;
		e._002Ector(qualityType);
		EventHandler<QualityTypeChangedEventArgs> onQualityTypeChanged = this.m_OnQualityTypeChanged;
		if (this.m_OnQualityTypeChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S0_v14 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private int GetQualityLevelIntFromName(string qualityLevelName)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I
		string[] names = QualitySettings.names;
		int num = 0;
		while (true)
		{
			if (names.Length > num)
			{
				int num2 = num << 2;
				object obj = names + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
				if (!((string)0 != qualityLevelName))
				{
					break;
				}
				int num3 = num + 1;
				num = num3;
				continue;
			}
			num = -1;
			break;
		}
		return num;
	}

	private bool HasQualityLevelIntFromName(string qualityLevelName)
	{
		int qualityLevelIntFromName = ((QualitySettingsManager)(object)qualityLevelName).GetQualityLevelIntFromName(qualityLevelName);
		return qualityLevelIntFromName != -1;
	}

	private void SetQualityLevel(int qualityLevel)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		QualitySettings.SetQualityLevel(qualityLevel, applyExpensiveChanges: true);
		((QualitySettingsManager)qualityLevel).DebugLogQualitySettings((string)qualityLevel);
	}

	private void SetQualityLevel(string qualityLevelName)
	{
		if (((QualitySettingsManager)(object)qualityLevelName).HasQualityLevelIntFromName(qualityLevelName))
		{
			int qualityLevelIntFromName = ((QualitySettingsManager)(object)qualityLevelName).GetQualityLevelIntFromName(qualityLevelName);
			SetQualityLevel(qualityLevelIntFromName);
		}
		else
		{
			string text = "No qualityLevelInt available for qualityLevelName: " + qualityLevelName;
		}
	}

	private void DebugLogQualitySettings(string callingMethodName)
	{
		int qualityLevel = QualitySettings.GetQualityLevel();
	}

	private void RaiseOnQualityLevelChanged(QualityTypeChangedEventArgs e)
	{
		EventHandler<QualityTypeChangedEventArgs> onQualityTypeChanged = this.m_OnQualityTypeChanged;
		if (this.m_OnQualityTypeChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.EventHandler`1<SYBO.Subway.Managers.QualitySettingsManager+QualityTypeChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}
}
