using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class QualityManager : SingletonMonoBehaviour<QualityManager>
{
	private List<QualityFeature> _prewarmParticleSystems;

	private IQualityPlatformSupport _platformSupport;

	protected override void SubclassInitialize()
	{
	}

	public bool IsSupported(QualityFeature feature)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 16;
		obj2 = feature;
		return flag;
	}

	public bool PrewarmParticleSystems(QualityFeature feature)
	{
		if (feature != QualityFeature.None)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			bool result = default;
			return result;
		}
		return true;
	}

	public QualityManager()
	{
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		string dataPath = Application.dataPath;
		QualityToggle qualityToggle2;
		if ((nint)dataPath > 11)
		{
			if ((nint)dataPath != 17)
			{
				object obj = dataPath - 18;
				if ((nint)obj > 2)
				{
					goto IL_019a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				QualityToggle qualityToggle = default;
				qualityToggle.Awake();
				qualityToggle2 = qualityToggle;
				goto IL_01e0;
			}
		}
		else if (dataPath != null)
		{
			object obj2 = dataPath - 7;
			if ((nint)dataPath != 7)
			{
				if ((nint)obj2 != 1)
				{
					if ((nint)obj2 == 2 || (nint)obj2 == 3 || (nint)obj2 != 4)
					{
						goto IL_019a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					QualityPlatformSupportEditor qualityPlatformSupportEditor = default;
					qualityPlatformSupportEditor.Initialize();
					qualityToggle2 = (QualityToggle)(object)qualityPlatformSupportEditor;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					QualityPlatformSupportWSA qualityPlatformSupportWSA = default;
					qualityPlatformSupportWSA.Initialize();
					qualityToggle2 = (QualityToggle)(object)qualityPlatformSupportWSA;
				}
				goto IL_01e0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		QualityToggle qualityToggle3 = default;
		qualityToggle2 = qualityToggle3;
		goto IL_01e0;
		IL_019a:
		string dataPath2 = Application.dataPath;
		object obj3 = dataPath2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text = default;
		string msg = "Undefined platform quality settings for " + text;
		SDebug.LogFormat(msg, null);
		return;
		IL_01e0:
		object obj4 = this + 20;
		obj4 = qualityToggle2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
	}
}
