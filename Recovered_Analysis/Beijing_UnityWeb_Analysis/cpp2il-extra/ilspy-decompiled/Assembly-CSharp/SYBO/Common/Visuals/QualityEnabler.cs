using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class QualityEnabler : MonoBehaviour
{
	private QualityFeature _feature;

	public QualityFeature Feature
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Visuals.QualityEnabler)+1C]");
			return ((nint)0 != 0) ? ((QualityFeature)1) : QualityFeature.None;
		}
	}

	private void OnEnable()
	{
		CancelInvoke();
	}

	public void ApplyQuality()
	{
		this._002Ector();
	}

	public unsafe QualityEnabler()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I4
		//IL_016f: Expected VT, but got Obj
		//IL_017e: Expected Obj, but got VT
		//IL_002d: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I4
		//IL_0088: Expected VT, but got Obj
		//IL_0097: Expected Obj, but got VT
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = 0;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		bool flag = ((QualityManager)val).PrewarmParticleSystems(_feature);
		string text = tag;
		bool activeInHierarchy = ((GameObject)(object)text).activeInHierarchy;
		object obj3 = flag ^ activeInHierarchy;
		if (obj3 != null)
		{
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)flag;
		}
		if (!flag)
		{
			return;
		}
		_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		if (((QualityPlatformSupportAndroid)val2).IsSupported(_feature))
		{
			_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>(true);
			object obj4 = componentsInParent + 12;
			object obj5 = 0;
			float startSizeMultiplier = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				object obj6 = componentsInParent + 16;
				object obj7 = obj5 << 2;
				object obj8 = obj6 + obj7;
				obj = 0;
				obj = obj8;
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11751");
				((ParticleSystem.MainModule*)obj8)->startSizeMultiplier = startSizeMultiplier;
				object obj9 = obj5 + 1;
				obj5 = obj9;
			}
		}
	}
}
