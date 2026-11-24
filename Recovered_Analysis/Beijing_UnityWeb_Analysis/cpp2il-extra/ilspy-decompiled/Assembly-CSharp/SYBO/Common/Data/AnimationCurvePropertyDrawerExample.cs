using System;
using Cpp2ILInjected;
using SYBO.Common.Events;
using UnityEngine;

namespace SYBO.Common.Data;

public class AnimationCurvePropertyDrawerExample : MonoBehaviour
{
	private AnimationCurve _test1AnimationCurve;

	private AnimationCurve _test2AnimationCurve;

	public AnimationCurvePropertyDrawerExample()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GatedValue gatedValue = default;
		gatedValue.OnValueChanged += (EventHandler<ValueChangedEventArgs>)(object)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}
}
