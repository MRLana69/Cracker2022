using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class QualityManager : SingletonMonobehavior<QualityManager>
{
	private List<QualityFeature> _prewarmParticleSystems;

	protected override void Initialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.OSXEditor)
		{
			return;
		}
		object obj3 = platform - 7;
		if ((nint)obj3 <= 4)
		{
			object obj4 = 1 << (int)obj3;
			object obj5 = obj4 & 0x13;
			if (obj5 != null)
			{
				return;
			}
		}
		else
		{
			object obj6 = platform - 18;
			if ((nint)obj6 < 3)
			{
				return;
			}
		}
		RuntimePlatform platform2 = Application.platform;
		_ = -1;
		obj = (Enum)(object)typeof(RuntimePlatform);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		string text2 = "Undefined platform quality settings for " + text;
	}

	public bool IsSupported(QualityFeature feature)
	{
		return false;
	}

	public bool PrewarmParticleSystems(QualityFeature feature)
	{
		return _prewarmParticleSystems.Contains(feature);
	}

	public QualityManager()
	{
		List<QualityFeature> list = default;
		list._002Ector();
		_prewarmParticleSystems = list;
		base._002Ector();
	}
}
