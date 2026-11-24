using System;
using Cpp2ILInjected;
using UnityEngine;

public abstract class TrackEventTrigger : MonoBehaviour
{
	protected TrackEventTrigger()
	{
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_0255: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		nint num = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Layers>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RandomizeOffset.RandomOffsetsData randomOffsets = ((RandomizeOffset)(object)"Default").RandomOffsets;
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)randomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets2 = ((RandomizeOffset)(object)"Hit").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets3 = ((RandomizeOffset)(object)"Unremovable").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets4 = ((RandomizeOffset)(object)"Character").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets5 = ((RandomizeOffset)(object)"Guard").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets6 = ((RandomizeOffset)(object)"Pickup").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets7 = ((RandomizeOffset)(object)"Coin").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets8 = ((RandomizeOffset)(object)"Background").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets9 = ((RandomizeOffset)(object)"TutorialTrigger").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets10 = ((RandomizeOffset)(object)"TrackEvent").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets11 = ((RandomizeOffset)(object)"TrackEventTrigger").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets12 = ((RandomizeOffset)(object)"SkateparkSetPiece").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets13 = ((RandomizeOffset)(object)"Ramp").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets14 = ((RandomizeOffset)(object)"LoadScreenLayer").RandomOffsets;
		object obj2 = this - -64;
		RandomizeOffset.RandomOffsetsData randomOffsets15 = ((RandomizeOffset)(object)"3DGUI").RandomOffsets;
		obj2 = randomOffsets15;
		RandomizeOffset.RandomOffsetsData randomOffsets16 = ((RandomizeOffset)(object)"3DCLIP").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets17 = ((RandomizeOffset)(object)"RENDERTEXTURE").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets18 = ((RandomizeOffset)(object)"CELEBRATION").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets19 = ((RandomizeOffset)(object)"2DGUI").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets20 = ((RandomizeOffset)(object)"2DOVERLAY").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets21 = ((RandomizeOffset)(object)"2DOVERLAYCLIP").RandomOffsets;
		RandomizeOffset.RandomOffsetsData randomOffsets22 = ((RandomizeOffset)(object)"3DOverlay").RandomOffsets;
	}
}
