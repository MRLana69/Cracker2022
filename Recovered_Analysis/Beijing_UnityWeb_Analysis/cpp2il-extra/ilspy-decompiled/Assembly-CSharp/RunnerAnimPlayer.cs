using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

public class RunnerAnimPlayer : AnimationSoundPlayer
{
	private Game game;

	public AudioClipInfo run__LeftFoot;

	public AudioClipInfo run__RightFoot;

	public AudioClipInfo superRun__LeftFoot;

	public AudioClipInfo superRun__RightFoot;

	public AudioClipInfo groundLeft;

	public AudioClipInfo groundRight;

	public AudioClipInfo groundLeft_super;

	public AudioClipInfo groundRight_super;

	public AudioClipInfo jump;

	public AudioClipInfo roll;

	public AudioClipInfo landing;

	public AudioClipInfo h_jump;

	public AudioClipInfo h_roll;

	public AudioClipInfo h_kick;

	public AudioClipInfo h_miniKick;

	public AudioClipInfo h_long;

	public AudioClipInfo h_mid;

	public AudioClipInfo h_short;

	public AudioClipInfo h_landingGrind;

	public AudioClipInfo superJump;

	public AudioClipInfo idlePaintSpray;

	public AudioClipInfo idlePaintSprayHigh;

	public AudioClipInfo idlePaintShake;

	public AudioClipInfo deathMovingTrain;

	public AudioClipInfo deathBodyfall;

	public AudioStateLoop audioStateLoop;

	public bool playPaintSound;

	public void Initialize()
	{
		CancelInvoke();
	}

	public void InitializeHoverboardClips()
	{
		//IL_19b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b5: Expected Obj, but got Unknown
		//IL_19d5: Expected Obj, but got I
		//IL_19e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19eb: Expected Obj, but got Unknown
		//IL_19f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f9: Expected Obj, but got Unknown
		//IL_1a2b: Expected Obj, but got I
		//IL_1a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a41: Expected Obj, but got Unknown
		//IL_1a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4f: Expected Obj, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0028: Expected I, but got Obj
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_005b: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_1a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a73: Expected Obj, but got Unknown
		//IL_1a84: Expected Obj, but got I4
		//IL_1aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aaa: Expected Obj, but got Unknown
		//IL_1abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac1: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_009c: Expected I, but got Obj
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected Obj, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected Obj, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected Obj, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected Obj, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected Obj, but got Unknown
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected Obj, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected Obj, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected Obj, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected Obj, but got Unknown
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected Obj, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected Obj, but got Unknown
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected Obj, but got Unknown
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected Obj, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected Obj, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Obj, but got Unknown
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected Obj, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected Obj, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected Obj, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected Obj, but got Unknown
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected Obj, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected Obj, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected Obj, but got Unknown
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected Obj, but got Unknown
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected Obj, but got Unknown
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected Obj, but got Unknown
		//IL_0b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Expected Obj, but got Unknown
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected Obj, but got Unknown
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Expected Obj, but got Unknown
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected Obj, but got Unknown
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Expected Obj, but got Unknown
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected Obj, but got Unknown
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected Obj, but got Unknown
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Expected Obj, but got Unknown
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Expected Obj, but got Unknown
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected Obj, but got Unknown
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd3: Expected Obj, but got Unknown
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected Obj, but got Unknown
		//IL_0d29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2e: Expected Obj, but got Unknown
		//IL_0d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d72: Expected Obj, but got Unknown
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected Obj, but got Unknown
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected Obj, but got Unknown
		//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc7: Expected Obj, but got Unknown
		//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dda: Expected Obj, but got Unknown
		//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1c: Expected Obj, but got Unknown
		//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e33: Expected Obj, but got Unknown
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Expected Obj, but got Unknown
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected Obj, but got Unknown
		//IL_0e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7f: Expected Obj, but got Unknown
		//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec1: Expected Obj, but got Unknown
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed8: Expected Obj, but got Unknown
		//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee3: Expected Obj, but got Unknown
		//IL_0f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f16: Expected Obj, but got Unknown
		//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Expected Obj, but got Unknown
		//IL_0f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6b: Expected Obj, but got Unknown
		//IL_0f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f82: Expected Obj, but got Unknown
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Expected Obj, but got Unknown
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbb: Expected Obj, but got Unknown
		//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fce: Expected Obj, but got Unknown
		//IL_100b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1010: Expected Obj, but got Unknown
		//IL_1022: Unknown result type (might be due to invalid IL or missing references)
		//IL_1027: Expected Obj, but got Unknown
		//IL_1066: Unknown result type (might be due to invalid IL or missing references)
		//IL_106b: Expected Obj, but got Unknown
		//IL_107d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1082: Expected Obj, but got Unknown
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected Obj, but got Unknown
		//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dd: Expected Obj, but got Unknown
		//IL_111c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1121: Expected Obj, but got Unknown
		//IL_1133: Unknown result type (might be due to invalid IL or missing references)
		//IL_1138: Expected Obj, but got Unknown
		//IL_1177: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Expected Obj, but got Unknown
		//IL_118e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1193: Expected Obj, but got Unknown
		//IL_11d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d7: Expected Obj, but got Unknown
		//IL_11e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ee: Expected Obj, but got Unknown
		//IL_122d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1232: Expected Obj, but got Unknown
		//IL_1244: Unknown result type (might be due to invalid IL or missing references)
		//IL_1249: Expected Obj, but got Unknown
		//IL_1279: Unknown result type (might be due to invalid IL or missing references)
		//IL_127e: Expected Obj, but got Unknown
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1291: Expected Obj, but got Unknown
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d3: Expected Obj, but got Unknown
		//IL_12e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ea: Expected Obj, but got Unknown
		//IL_1315: Unknown result type (might be due to invalid IL or missing references)
		//IL_131a: Expected Obj, but got Unknown
		//IL_1328: Unknown result type (might be due to invalid IL or missing references)
		//IL_132d: Expected Obj, but got Unknown
		//IL_136a: Unknown result type (might be due to invalid IL or missing references)
		//IL_136f: Expected Obj, but got Unknown
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected Obj, but got Unknown
		//IL_13b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bb: Expected Obj, but got Unknown
		//IL_13c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ce: Expected Obj, but got Unknown
		//IL_140b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1410: Expected Obj, but got Unknown
		//IL_1422: Unknown result type (might be due to invalid IL or missing references)
		//IL_1427: Expected Obj, but got Unknown
		//IL_1452: Unknown result type (might be due to invalid IL or missing references)
		//IL_1457: Expected Obj, but got Unknown
		//IL_1465: Unknown result type (might be due to invalid IL or missing references)
		//IL_146a: Expected Obj, but got Unknown
		//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ac: Expected Obj, but got Unknown
		//IL_14be: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c3: Expected Obj, but got Unknown
		//IL_14f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f8: Expected Obj, but got Unknown
		//IL_1506: Unknown result type (might be due to invalid IL or missing references)
		//IL_150b: Expected Obj, but got Unknown
		//IL_1548: Unknown result type (might be due to invalid IL or missing references)
		//IL_154d: Expected Obj, but got Unknown
		//IL_155f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1564: Expected Obj, but got Unknown
		//IL_158f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1594: Expected Obj, but got Unknown
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a7: Expected Obj, but got Unknown
		//IL_15e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e9: Expected Obj, but got Unknown
		//IL_15fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1600: Expected Obj, but got Unknown
		//IL_1630: Unknown result type (might be due to invalid IL or missing references)
		//IL_1635: Expected Obj, but got Unknown
		//IL_1643: Unknown result type (might be due to invalid IL or missing references)
		//IL_1648: Expected Obj, but got Unknown
		//IL_1685: Unknown result type (might be due to invalid IL or missing references)
		//IL_168a: Expected Obj, but got Unknown
		//IL_169c: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a1: Expected Obj, but got Unknown
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Expected Obj, but got Unknown
		//IL_16df: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e4: Expected Obj, but got Unknown
		//IL_1721: Unknown result type (might be due to invalid IL or missing references)
		//IL_1726: Expected Obj, but got Unknown
		//IL_1738: Unknown result type (might be due to invalid IL or missing references)
		//IL_173d: Expected Obj, but got Unknown
		//IL_176d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1772: Expected Obj, but got Unknown
		//IL_1780: Unknown result type (might be due to invalid IL or missing references)
		//IL_1785: Expected Obj, but got Unknown
		//IL_17c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c7: Expected Obj, but got Unknown
		//IL_17d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17de: Expected Obj, but got Unknown
		//IL_1809: Unknown result type (might be due to invalid IL or missing references)
		//IL_180e: Expected Obj, but got Unknown
		//IL_181c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1821: Expected Obj, but got Unknown
		//IL_185e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1863: Expected Obj, but got Unknown
		//IL_1875: Unknown result type (might be due to invalid IL or missing references)
		//IL_187a: Expected Obj, but got Unknown
		//IL_18b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18be: Expected Obj, but got Unknown
		//IL_18d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d5: Expected Obj, but got Unknown
		//IL_1914: Unknown result type (might be due to invalid IL or missing references)
		//IL_1919: Expected Obj, but got Unknown
		//IL_192b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1930: Expected Obj, but got Unknown
		//IL_196f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1974: Expected Obj, but got Unknown
		//IL_1986: Unknown result type (might be due to invalid IL or missing references)
		//IL_198b: Expected Obj, but got Unknown
		object obj = this + 12;
		string text = tag;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v29 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		obj = obj6;
		string text2 = tag;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v4 (Il2CppMethodInfo)+18]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S3_v8 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		AnimationEventBroadcaster.SendPlayKeyframeAnimationDelegate sendPlayKeyframeAnimationDelegate = default;
		((Delegate)sendPlayKeyframeAnimationDelegate).method_ptr = (IntPtr)ex;
		((Delegate)sendPlayKeyframeAnimationDelegate).method = (IntPtr)ex;
		object obj11 = sendPlayKeyframeAnimationDelegate + 16;
		obj11 = this;
		AnimationEventBroadcaster animationEventBroadcaster = default;
		animationEventBroadcaster.SendPlayKeyframeAnimation -= sendPlayKeyframeAnimationDelegate;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v11 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v137 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj13 = this + 28;
		bool isInstantiated = Game.IsInstantiated;
		obj13 = isInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio = default;
		keyFrameAudio.KeyFrame = 1;
		object obj14 = keyFrameAudio + 8;
		obj14 = "run";
		object obj15 = keyFrameAudio + 24;
		obj15 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio2 = default;
		keyFrameAudio2.KeyFrame = 6;
		object obj16 = keyFrameAudio2 + 8;
		obj16 = "run";
		object obj17 = keyFrameAudio2 + 24;
		obj17 = run__RightFoot;
		AudioClips.Add(keyFrameAudio2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio3 = default;
		keyFrameAudio3.KeyFrame = 1;
		object obj18 = keyFrameAudio3 + 8;
		obj18 = "run2";
		object obj19 = keyFrameAudio3 + 24;
		obj19 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio4 = default;
		keyFrameAudio4.KeyFrame = 6;
		object obj20 = keyFrameAudio4 + 8;
		obj20 = "run2";
		object obj21 = keyFrameAudio4 + 24;
		obj21 = run__RightFoot;
		AudioClips.Add(keyFrameAudio4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio5 = default;
		keyFrameAudio5.KeyFrame = 1;
		object obj22 = keyFrameAudio5 + 8;
		obj22 = "run3";
		object obj23 = keyFrameAudio5 + 24;
		obj23 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio6 = default;
		keyFrameAudio6.KeyFrame = 6;
		object obj24 = keyFrameAudio6 + 8;
		obj24 = "run3";
		object obj25 = keyFrameAudio6 + 24;
		obj25 = run__RightFoot;
		AudioClips.Add(keyFrameAudio6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio7 = default;
		keyFrameAudio7.KeyFrame = 1;
		object obj26 = keyFrameAudio7 + 8;
		obj26 = "run4_long";
		object obj27 = keyFrameAudio7 + 24;
		obj27 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio8 = default;
		keyFrameAudio8.KeyFrame = 6;
		object obj28 = keyFrameAudio8 + 8;
		obj28 = "run4_long";
		object obj29 = keyFrameAudio8 + 24;
		obj29 = run__RightFoot;
		AudioClips.Add(keyFrameAudio8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio9 = default;
		keyFrameAudio9.KeyFrame = 10;
		object obj30 = keyFrameAudio9 + 8;
		obj30 = "run4_long";
		object obj31 = keyFrameAudio9 + 24;
		obj31 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio10 = default;
		keyFrameAudio10.KeyFrame = 15;
		object obj32 = keyFrameAudio10 + 8;
		obj32 = "run4_long";
		object obj33 = keyFrameAudio10 + 24;
		obj33 = run__RightFoot;
		AudioClips.Add(keyFrameAudio10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio11 = default;
		keyFrameAudio11.KeyFrame = 20;
		object obj34 = keyFrameAudio11 + 8;
		obj34 = "run4_long";
		object obj35 = keyFrameAudio11 + 24;
		obj35 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio12 = default;
		keyFrameAudio12.KeyFrame = 25;
		object obj36 = keyFrameAudio12 + 8;
		obj36 = "run4_long";
		object obj37 = keyFrameAudio12 + 24;
		obj37 = run__RightFoot;
		AudioClips.Add(keyFrameAudio12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio13 = default;
		keyFrameAudio13.KeyFrame = 30;
		object obj38 = keyFrameAudio13 + 8;
		obj38 = "run4_long";
		object obj39 = keyFrameAudio13 + 24;
		obj39 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio14 = default;
		keyFrameAudio14.KeyFrame = 35;
		object obj40 = keyFrameAudio14 + 8;
		obj40 = "run4_long";
		object obj41 = keyFrameAudio14 + 24;
		obj41 = run__RightFoot;
		AudioClips.Add(keyFrameAudio14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio15 = default;
		keyFrameAudio15.KeyFrame = 40;
		object obj42 = keyFrameAudio15 + 8;
		obj42 = "run4_long";
		object obj43 = keyFrameAudio15 + 24;
		obj43 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio16 = default;
		keyFrameAudio16.KeyFrame = 45;
		object obj44 = keyFrameAudio16 + 8;
		obj44 = "run4_long";
		object obj45 = keyFrameAudio16 + 24;
		obj45 = run__RightFoot;
		AudioClips.Add(keyFrameAudio16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio17 = default;
		keyFrameAudio17.KeyFrame = 50;
		object obj46 = keyFrameAudio17 + 8;
		obj46 = "run4_long";
		object obj47 = keyFrameAudio17 + 24;
		obj47 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio17);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio18 = default;
		keyFrameAudio18.KeyFrame = 55;
		object obj48 = keyFrameAudio18 + 8;
		obj48 = "run4_long";
		object obj49 = keyFrameAudio18 + 24;
		obj49 = run__RightFoot;
		AudioClips.Add(keyFrameAudio18);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio19 = default;
		keyFrameAudio19.KeyFrame = 60;
		object obj50 = keyFrameAudio19 + 8;
		obj50 = "run4_long";
		object obj51 = keyFrameAudio19 + 24;
		obj51 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio19);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio20 = default;
		keyFrameAudio20.KeyFrame = 65;
		object obj52 = keyFrameAudio20 + 8;
		obj52 = "run4_long";
		object obj53 = keyFrameAudio20 + 24;
		obj53 = run__RightFoot;
		AudioClips.Add(keyFrameAudio20);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio21 = default;
		keyFrameAudio21.KeyFrame = 70;
		object obj54 = keyFrameAudio21 + 8;
		obj54 = "run4_long";
		object obj55 = keyFrameAudio21 + 24;
		obj55 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio21);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio22 = default;
		keyFrameAudio22.KeyFrame = 75;
		object obj56 = keyFrameAudio22 + 8;
		obj56 = "run4_long";
		object obj57 = keyFrameAudio22 + 24;
		obj57 = run__RightFoot;
		AudioClips.Add(keyFrameAudio22);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio23 = default;
		keyFrameAudio23.KeyFrame = 80;
		object obj58 = keyFrameAudio23 + 8;
		obj58 = "run4_long";
		object obj59 = keyFrameAudio23 + 24;
		obj59 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio23);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio24 = default;
		keyFrameAudio24.KeyFrame = 85;
		object obj60 = keyFrameAudio24 + 8;
		obj60 = "run4_long";
		object obj61 = keyFrameAudio24 + 24;
		obj61 = run__RightFoot;
		AudioClips.Add(keyFrameAudio24);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio25 = default;
		keyFrameAudio25.KeyFrame = 90;
		object obj62 = keyFrameAudio25 + 8;
		obj62 = "run4_long";
		object obj63 = keyFrameAudio25 + 24;
		obj63 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio25);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio26 = default;
		keyFrameAudio26.KeyFrame = 95;
		object obj64 = keyFrameAudio26 + 8;
		obj64 = "run4_long";
		object obj65 = keyFrameAudio26 + 24;
		obj65 = run__RightFoot;
		AudioClips.Add(keyFrameAudio26);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio27 = default;
		keyFrameAudio27.KeyFrame = 100;
		object obj66 = keyFrameAudio27 + 8;
		obj66 = "run4_long";
		object obj67 = keyFrameAudio27 + 24;
		obj67 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio27);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio28 = default;
		keyFrameAudio28.KeyFrame = 105;
		object obj68 = keyFrameAudio28 + 8;
		obj68 = "run4_long";
		object obj69 = keyFrameAudio28 + 24;
		obj69 = run__RightFoot;
		AudioClips.Add(keyFrameAudio28);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio29 = default;
		keyFrameAudio29.KeyFrame = 110;
		object obj70 = keyFrameAudio29 + 8;
		obj70 = "run4_long";
		object obj71 = keyFrameAudio29 + 24;
		obj71 = run__LeftFoot;
		AudioClips.Add(keyFrameAudio29);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio30 = default;
		keyFrameAudio30.KeyFrame = 1;
		object obj72 = keyFrameAudio30 + 8;
		obj72 = "superRun";
		object obj73 = keyFrameAudio30 + 24;
		obj73 = superRun__RightFoot;
		AudioClips.Add(keyFrameAudio30);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio31 = default;
		keyFrameAudio31.KeyFrame = 10;
		object obj74 = keyFrameAudio31 + 8;
		obj74 = "superRun";
		object obj75 = keyFrameAudio31 + 24;
		obj75 = superRun__LeftFoot;
		AudioClips.Add(keyFrameAudio31);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio32 = default;
		keyFrameAudio32.KeyFrame = 0;
		object obj76 = keyFrameAudio32 + 8;
		obj76 = "dodgeLeft";
		object obj77 = keyFrameAudio32 + 24;
		obj77 = groundLeft;
		AudioClips.Add(keyFrameAudio32);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio33 = default;
		keyFrameAudio33.KeyFrame = 0;
		object obj78 = keyFrameAudio33 + 8;
		obj78 = "dodgeRight";
		object obj79 = keyFrameAudio33 + 24;
		obj79 = groundRight;
		AudioClips.Add(keyFrameAudio33);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio34 = default;
		keyFrameAudio34.KeyFrame = 8;
		object obj80 = keyFrameAudio34 + 8;
		obj80 = "dodgeLeft";
		object obj81 = keyFrameAudio34 + 24;
		obj81 = groundLeft;
		AudioClips.Add(keyFrameAudio34);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio35 = default;
		keyFrameAudio35.KeyFrame = 8;
		object obj82 = keyFrameAudio35 + 8;
		obj82 = "dodgeRight";
		object obj83 = keyFrameAudio35 + 24;
		obj83 = groundRight;
		AudioClips.Add(keyFrameAudio35);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio36 = default;
		keyFrameAudio36.KeyFrame = 1;
		object obj84 = keyFrameAudio36 + 8;
		obj84 = "landing";
		object obj85 = keyFrameAudio36 + 24;
		obj85 = landing;
		AudioClips.Add(keyFrameAudio36);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio37 = default;
		keyFrameAudio37.KeyFrame = 0;
		object obj86 = keyFrameAudio37 + 8;
		obj86 = "jump";
		object obj87 = keyFrameAudio37 + 24;
		object obj88 = this - -64;
		obj87 = obj88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj90 = default;
		object obj89 = obj90 + 16;
		obj89 = this;
		object obj91 = keyFrameAudio37 + 28;
		obj91 = obj90;
		AudioClips.Add(keyFrameAudio37);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio38 = default;
		keyFrameAudio38.KeyFrame = 0;
		object obj92 = keyFrameAudio38 + 8;
		obj92 = "jump_salto";
		object obj93 = keyFrameAudio38 + 24;
		object obj94 = this - -64;
		obj93 = obj94;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		object obj96 = default;
		object obj95 = obj96 + 16;
		obj95 = this;
		object obj97 = keyFrameAudio38 + 28;
		obj97 = obj96;
		AudioClips.Add(keyFrameAudio38);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio39 = default;
		keyFrameAudio39.KeyFrame = 0;
		object obj98 = keyFrameAudio39 + 8;
		obj98 = "jump2";
		object obj99 = keyFrameAudio39 + 24;
		object obj100 = this - -64;
		obj99 = obj100;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		object obj102 = default;
		object obj101 = obj102 + 16;
		obj101 = this;
		object obj103 = keyFrameAudio39 + 28;
		obj103 = obj102;
		AudioClips.Add(keyFrameAudio39);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio40 = default;
		keyFrameAudio40.KeyFrame = 0;
		object obj104 = keyFrameAudio40 + 8;
		obj104 = "jump3";
		object obj105 = keyFrameAudio40 + 24;
		object obj106 = this - -64;
		obj105 = obj106;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		object obj108 = default;
		object obj107 = obj108 + 16;
		obj107 = this;
		object obj109 = keyFrameAudio40 + 28;
		obj109 = obj108;
		AudioClips.Add(keyFrameAudio40);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio41 = default;
		keyFrameAudio41.KeyFrame = 0;
		object obj110 = keyFrameAudio41 + 8;
		obj110 = "jump";
		object obj111 = keyFrameAudio41 + 24;
		obj111 = groundLeft;
		AudioClips.Add(keyFrameAudio41);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio42 = default;
		keyFrameAudio42.KeyFrame = 0;
		object obj112 = keyFrameAudio42 + 8;
		obj112 = "jump_salto";
		object obj113 = keyFrameAudio42 + 24;
		obj113 = groundRight;
		AudioClips.Add(keyFrameAudio42);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio43 = default;
		keyFrameAudio43.KeyFrame = 0;
		object obj114 = keyFrameAudio43 + 8;
		obj114 = "jump2";
		object obj115 = keyFrameAudio43 + 24;
		obj115 = groundLeft;
		AudioClips.Add(keyFrameAudio43);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio44 = default;
		keyFrameAudio44.KeyFrame = 0;
		object obj116 = keyFrameAudio44 + 8;
		obj116 = "jump3";
		object obj117 = keyFrameAudio44 + 24;
		obj117 = groundLeft;
		AudioClips.Add(keyFrameAudio44);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio45 = default;
		keyFrameAudio45.KeyFrame = 1;
		object obj118 = keyFrameAudio45 + 8;
		obj118 = "roll";
		object obj119 = keyFrameAudio45 + 24;
		obj119 = roll;
		AudioClips.Add(keyFrameAudio45);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio46 = default;
		keyFrameAudio46.KeyFrame = 0;
		object obj120 = keyFrameAudio46 + 8;
		obj120 = "roll";
		object obj121 = keyFrameAudio46 + 24;
		obj121 = groundRight;
		AudioClips.Add(keyFrameAudio46);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio47 = default;
		keyFrameAudio47.KeyFrame = 5;
		object obj122 = keyFrameAudio47 + 8;
		obj122 = "idlePaint";
		object obj123 = keyFrameAudio47 + 24;
		obj123 = idlePaintSpray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		object obj125 = default;
		object obj124 = obj125 + 16;
		obj124 = this;
		object obj126 = keyFrameAudio47 + 28;
		obj126 = obj125;
		AudioClips.Add(keyFrameAudio47);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio48 = default;
		keyFrameAudio48.KeyFrame = 39;
		object obj127 = keyFrameAudio48 + 8;
		obj127 = "idlePaint";
		object obj128 = keyFrameAudio48 + 24;
		obj128 = idlePaintShake;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		_ = 0;
		object obj130 = default;
		object obj129 = obj130 + 16;
		obj129 = this;
		object obj131 = keyFrameAudio48 + 28;
		obj131 = obj130;
		AudioClips.Add(keyFrameAudio48);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio49 = default;
		keyFrameAudio49.KeyFrame = 114;
		object obj132 = keyFrameAudio49 + 8;
		obj132 = "idlePaint";
		object obj133 = keyFrameAudio49 + 24;
		obj133 = idlePaintSprayHigh;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		object obj135 = default;
		object obj134 = obj135 + 16;
		obj134 = this;
		object obj136 = keyFrameAudio49 + 28;
		obj136 = obj135;
		AudioClips.Add(keyFrameAudio49);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio50 = default;
		keyFrameAudio50.KeyFrame = 136;
		object obj137 = keyFrameAudio50 + 8;
		obj137 = "idlePaint";
		object obj138 = keyFrameAudio50 + 24;
		obj138 = idlePaintSprayHigh;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		_ = 0;
		object obj140 = default;
		object obj139 = obj140 + 16;
		obj139 = this;
		object obj141 = keyFrameAudio50 + 28;
		obj141 = obj140;
		AudioClips.Add(keyFrameAudio50);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio51 = default;
		keyFrameAudio51.KeyFrame = 165;
		object obj142 = keyFrameAudio51 + 8;
		obj142 = "idlePaint";
		object obj143 = keyFrameAudio51 + 24;
		obj143 = idlePaintShake;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		_ = 0;
		object obj145 = default;
		object obj144 = obj145 + 16;
		obj144 = this;
		object obj146 = keyFrameAudio51 + 28;
		obj146 = obj145;
		AudioClips.Add(keyFrameAudio51);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio52 = default;
		keyFrameAudio52.KeyFrame = 207;
		object obj147 = keyFrameAudio52 + 8;
		obj147 = "idlePaint";
		object obj148 = keyFrameAudio52 + 24;
		obj148 = idlePaintSpray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num14 = 0;
		_ = 0;
		object obj150 = default;
		object obj149 = obj150 + 16;
		obj149 = this;
		object obj151 = keyFrameAudio52 + 28;
		obj151 = obj150;
		AudioClips.Add(keyFrameAudio52);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio53 = default;
		keyFrameAudio53.KeyFrame = 271;
		object obj152 = keyFrameAudio53 + 8;
		obj152 = "idlePaint";
		object obj153 = keyFrameAudio53 + 24;
		obj153 = idlePaintSpray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num15 = 0;
		_ = 0;
		object obj155 = default;
		object obj154 = obj155 + 16;
		obj154 = this;
		object obj156 = keyFrameAudio53 + 28;
		obj156 = obj155;
		AudioClips.Add(keyFrameAudio53);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio54 = default;
		keyFrameAudio54.KeyFrame = 304;
		object obj157 = keyFrameAudio54 + 8;
		obj157 = "idlePaint";
		object obj158 = keyFrameAudio54 + 24;
		obj158 = idlePaintSpray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num16 = 0;
		_ = 0;
		object obj160 = default;
		object obj159 = obj160 + 16;
		obj159 = this;
		object obj161 = keyFrameAudio54 + 28;
		obj161 = obj160;
		AudioClips.Add(keyFrameAudio54);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio55 = default;
		keyFrameAudio55.KeyFrame = 322;
		object obj162 = keyFrameAudio55 + 8;
		obj162 = "idlePaint";
		object obj163 = keyFrameAudio55 + 24;
		obj163 = idlePaintShake;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num17 = 0;
		_ = 0;
		object obj165 = default;
		object obj164 = obj165 + 16;
		obj164 = this;
		object obj166 = keyFrameAudio55 + 28;
		obj166 = obj165;
		AudioClips.Add(keyFrameAudio55);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio56 = default;
		keyFrameAudio56.KeyFrame = 518;
		object obj167 = keyFrameAudio56 + 8;
		obj167 = "idlePaint";
		object obj168 = keyFrameAudio56 + 24;
		obj168 = idlePaintSpray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num18 = 0;
		_ = 0;
		object obj170 = default;
		object obj169 = obj170 + 16;
		obj169 = this;
		object obj171 = keyFrameAudio56 + 28;
		obj171 = obj170;
		AudioClips.Add(keyFrameAudio56);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio57 = default;
		keyFrameAudio57.KeyFrame = 13;
		object obj172 = keyFrameAudio57 + 8;
		obj172 = "death_movingTrain";
		object obj173 = keyFrameAudio57 + 24;
		obj173 = deathMovingTrain;
		AudioClips.Add(keyFrameAudio57);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio58 = default;
		keyFrameAudio58.KeyFrame = 8;
		object obj174 = keyFrameAudio58 + 8;
		obj174 = "death_lower";
		object obj175 = keyFrameAudio58 + 24;
		obj175 = deathBodyfall;
		AudioClips.Add(keyFrameAudio58);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio59 = default;
		keyFrameAudio59.KeyFrame = 11;
		object obj176 = keyFrameAudio59 + 8;
		obj176 = "death_bounce";
		object obj177 = keyFrameAudio59 + 24;
		obj177 = deathBodyfall;
		AudioClips.Add(keyFrameAudio59);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio60 = default;
		keyFrameAudio60.KeyFrame = 2;
		object obj178 = keyFrameAudio60 + 8;
		obj178 = "death_upper";
		object obj179 = keyFrameAudio60 + 24;
		obj179 = deathBodyfall;
		AudioClips.Add(keyFrameAudio60);
	}

	public void PlayOrMutePaintSound(bool doPlay)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_0146: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_0187: Expected I, but got Obj
		KeyFrameAction keyFrameAction = ((List<KeyFrameAction>)(object)base.AudioClipsInitialized).get_Item(doPlay ? 1 : 0);
		if (base.nextAudioClipIndex == 0)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)AudioClips != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Func<_0021_00210, bool> func = default;
		object obj2 = func + 16;
		obj2 = this;
		if (!Enumerable.All<TSource>((IEnumerable<TSource>)base.AudioClipsInitialized, (Func<TSource, bool>)(object)func))
		{
			return;
		}
		object obj3 = base.nextAudioClipIndex + 12;
		object obj4 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			object obj5 = base.nextAudioClipIndex + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)obj7 != null))
			{
				if (~(keyFrameAction.state ? 1u : 0u) == 0)
				{
					((ParticleSystem)obj7).Stop();
				}
				else
				{
					((ParticleSystem)obj7).Clear();
				}
			}
			object obj9 = obj4 + 1;
			obj4 = obj9;
		}
	}

	public void PlayIdlePaintSound(KeyFrameAudio info)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(info & 1) != 0;
		playPaintSound = flag;
	}

	public void PlayJumpSound(KeyFrameAudio info)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (~(playPaintSound ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<So>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)info.Audio, false);
	}

	public RunnerAnimPlayer()
	{
		//IL_11de: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e3: Expected Obj, but got Unknown
		//IL_11f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fa: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected Obj, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected Obj, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected Obj, but got Unknown
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected Obj, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected Obj, but got Unknown
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected Obj, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected Obj, but got Unknown
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected Obj, but got Unknown
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected Obj, but got Unknown
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected Obj, but got Unknown
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected Obj, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected Obj, but got Unknown
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected Obj, but got Unknown
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected Obj, but got Unknown
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected Obj, but got Unknown
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Expected Obj, but got Unknown
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected Obj, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected Obj, but got Unknown
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected Obj, but got Unknown
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected Obj, but got Unknown
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected Obj, but got Unknown
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected Obj, but got Unknown
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Expected Obj, but got Unknown
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Expected Obj, but got Unknown
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Expected Obj, but got Unknown
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected Obj, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Expected Obj, but got Unknown
		//IL_0b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected Obj, but got Unknown
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Expected Obj, but got Unknown
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Expected Obj, but got Unknown
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Expected Obj, but got Unknown
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected Obj, but got Unknown
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Expected Obj, but got Unknown
		//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected Obj, but got Unknown
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Expected Obj, but got Unknown
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Expected Obj, but got Unknown
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d48: Expected Obj, but got Unknown
		//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Expected Obj, but got Unknown
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Expected Obj, but got Unknown
		//IL_0db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dba: Expected Obj, but got Unknown
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Expected Obj, but got Unknown
		//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e15: Expected Obj, but got Unknown
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected Obj, but got Unknown
		//IL_0e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e70: Expected Obj, but got Unknown
		//IL_0eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected Obj, but got Unknown
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Expected Obj, but got Unknown
		//IL_0f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0f: Expected Obj, but got Unknown
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f26: Expected Obj, but got Unknown
		//IL_0f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6a: Expected Obj, but got Unknown
		//IL_0f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f81: Expected Obj, but got Unknown
		//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc5: Expected Obj, but got Unknown
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Expected Obj, but got Unknown
		//IL_101b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1020: Expected Obj, but got Unknown
		//IL_1032: Unknown result type (might be due to invalid IL or missing references)
		//IL_1037: Expected Obj, but got Unknown
		//IL_1076: Unknown result type (might be due to invalid IL or missing references)
		//IL_107b: Expected Obj, but got Unknown
		//IL_108d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1092: Expected Obj, but got Unknown
		//IL_10d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d6: Expected Obj, but got Unknown
		//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ed: Expected Obj, but got Unknown
		//IL_112c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1131: Expected Obj, but got Unknown
		//IL_1143: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Expected Obj, but got Unknown
		//IL_1187: Unknown result type (might be due to invalid IL or missing references)
		//IL_118c: Expected Obj, but got Unknown
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio = default;
		keyFrameAudio.KeyFrame = 0;
		object obj = keyFrameAudio + 8;
		obj = "h_landing";
		object obj2 = keyFrameAudio + 24;
		obj2 = h_kick;
		AudioClips.Add(keyFrameAudio);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio2 = default;
		keyFrameAudio2.KeyFrame = 0;
		object obj3 = keyFrameAudio2 + 8;
		obj3 = "h_roll";
		object obj4 = keyFrameAudio2 + 24;
		obj4 = h_roll;
		AudioClips.Add(keyFrameAudio2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio3 = default;
		keyFrameAudio3.KeyFrame = 4;
		object obj5 = keyFrameAudio3 + 8;
		obj5 = "h_roll";
		object obj6 = keyFrameAudio3 + 24;
		obj6 = h_miniKick;
		AudioClips.Add(keyFrameAudio3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio4 = default;
		keyFrameAudio4.KeyFrame = 1;
		object obj7 = keyFrameAudio4 + 8;
		obj7 = "h_jump";
		object obj8 = keyFrameAudio4 + 24;
		obj8 = h_kick;
		AudioClips.Add(keyFrameAudio4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio5 = default;
		keyFrameAudio5.KeyFrame = 2;
		object obj9 = keyFrameAudio5 + 8;
		obj9 = "h_jump";
		object obj10 = keyFrameAudio5 + 24;
		obj10 = h_long;
		AudioClips.Add(keyFrameAudio5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio6 = default;
		keyFrameAudio6.KeyFrame = 1;
		object obj11 = keyFrameAudio6 + 8;
		obj11 = "h_jump2_kickflip";
		object obj12 = keyFrameAudio6 + 24;
		obj12 = h_kick;
		AudioClips.Add(keyFrameAudio6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio7 = default;
		keyFrameAudio7.KeyFrame = 4;
		object obj13 = keyFrameAudio7 + 8;
		obj13 = "h_jump2_kickflip";
		object obj14 = keyFrameAudio7 + 24;
		obj14 = h_long;
		AudioClips.Add(keyFrameAudio7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio8 = default;
		keyFrameAudio8.KeyFrame = 21;
		object obj15 = keyFrameAudio8 + 8;
		obj15 = "h_jump2_kickflip";
		object obj16 = keyFrameAudio8 + 24;
		obj16 = h_short;
		AudioClips.Add(keyFrameAudio8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio9 = default;
		keyFrameAudio9.KeyFrame = 1;
		object obj17 = keyFrameAudio9 + 8;
		obj17 = "h_jump3_180";
		object obj18 = keyFrameAudio9 + 24;
		obj18 = h_kick;
		AudioClips.Add(keyFrameAudio9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio10 = default;
		keyFrameAudio10.KeyFrame = 2;
		object obj19 = keyFrameAudio10 + 8;
		obj19 = "h_jump3_180";
		object obj20 = keyFrameAudio10 + 24;
		obj20 = h_short;
		AudioClips.Add(keyFrameAudio10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio11 = default;
		keyFrameAudio11.KeyFrame = 8;
		object obj21 = keyFrameAudio11 + 8;
		obj21 = "h_jump3_180";
		object obj22 = keyFrameAudio11 + 24;
		obj22 = h_mid;
		AudioClips.Add(keyFrameAudio11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio12 = default;
		keyFrameAudio12.KeyFrame = 1;
		object obj23 = keyFrameAudio12 + 8;
		obj23 = "h_jump4_360flip";
		object obj24 = keyFrameAudio12 + 24;
		obj24 = h_kick;
		AudioClips.Add(keyFrameAudio12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio13 = default;
		keyFrameAudio13.KeyFrame = 2;
		object obj25 = keyFrameAudio13 + 8;
		obj25 = "h_jump4_360flip";
		object obj26 = keyFrameAudio13 + 24;
		obj26 = h_short;
		AudioClips.Add(keyFrameAudio13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio14 = default;
		keyFrameAudio14.KeyFrame = 8;
		object obj27 = keyFrameAudio14 + 8;
		obj27 = "h_jump4_360flip";
		object obj28 = keyFrameAudio14 + 24;
		obj28 = h_short;
		AudioClips.Add(keyFrameAudio14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio15 = default;
		keyFrameAudio15.KeyFrame = 13;
		object obj29 = keyFrameAudio15 + 8;
		obj29 = "h_jump4_360flip";
		object obj30 = keyFrameAudio15 + 24;
		obj30 = h_miniKick;
		AudioClips.Add(keyFrameAudio15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio16 = default;
		keyFrameAudio16.KeyFrame = 19;
		object obj31 = keyFrameAudio16 + 8;
		obj31 = "h_jump4_360flip";
		object obj32 = keyFrameAudio16 + 24;
		obj32 = h_mid;
		AudioClips.Add(keyFrameAudio16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio17 = default;
		keyFrameAudio17.KeyFrame = 1;
		object obj33 = keyFrameAudio17 + 8;
		obj33 = "h_jump5_Impossible";
		object obj34 = keyFrameAudio17 + 24;
		obj34 = h_kick;
		AudioClips.Add(keyFrameAudio17);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio18 = default;
		keyFrameAudio18.KeyFrame = 2;
		object obj35 = keyFrameAudio18 + 8;
		obj35 = "h_jump5_Impossible";
		object obj36 = keyFrameAudio18 + 24;
		obj36 = h_mid;
		AudioClips.Add(keyFrameAudio18);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio19 = default;
		keyFrameAudio19.KeyFrame = 8;
		object obj37 = keyFrameAudio19 + 8;
		obj37 = "h_jump5_Impossible";
		object obj38 = keyFrameAudio19 + 24;
		obj38 = h_short;
		AudioClips.Add(keyFrameAudio19);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio20 = default;
		keyFrameAudio20.KeyFrame = 11;
		object obj39 = keyFrameAudio20 + 8;
		obj39 = "h_jump5_Impossible";
		object obj40 = keyFrameAudio20 + 24;
		obj40 = h_miniKick;
		AudioClips.Add(keyFrameAudio20);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio21 = default;
		keyFrameAudio21.KeyFrame = 22;
		object obj41 = keyFrameAudio21 + 8;
		obj41 = "h_jump5_Impossible";
		object obj42 = keyFrameAudio21 + 24;
		obj42 = h_mid;
		AudioClips.Add(keyFrameAudio21);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio22 = default;
		keyFrameAudio22.KeyFrame = 1;
		object obj43 = keyFrameAudio22 + 8;
		obj43 = "h_jump6_nollie";
		object obj44 = keyFrameAudio22 + 24;
		obj44 = h_kick;
		AudioClips.Add(keyFrameAudio22);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio23 = default;
		keyFrameAudio23.KeyFrame = 2;
		object obj45 = keyFrameAudio23 + 8;
		obj45 = "h_jump6_nollie";
		object obj46 = keyFrameAudio23 + 24;
		obj46 = h_long;
		AudioClips.Add(keyFrameAudio23);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio24 = default;
		keyFrameAudio24.KeyFrame = 2;
		object obj47 = keyFrameAudio24 + 8;
		obj47 = "h_jump6_nollie";
		object obj48 = keyFrameAudio24 + 24;
		obj48 = h_short;
		AudioClips.Add(keyFrameAudio24);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio25 = default;
		keyFrameAudio25.KeyFrame = 21;
		object obj49 = keyFrameAudio25 + 8;
		obj49 = "h_jump6_nollie";
		object obj50 = keyFrameAudio25 + 24;
		obj50 = h_mid;
		AudioClips.Add(keyFrameAudio25);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio26 = default;
		keyFrameAudio26.KeyFrame = 3;
		object obj51 = keyFrameAudio26 + 8;
		obj51 = "h_jump7_heelflip";
		object obj52 = keyFrameAudio26 + 24;
		obj52 = h_kick;
		AudioClips.Add(keyFrameAudio26);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio27 = default;
		keyFrameAudio27.KeyFrame = 2;
		object obj53 = keyFrameAudio27 + 8;
		obj53 = "h_jump7_heelflip";
		object obj54 = keyFrameAudio27 + 24;
		obj54 = h_mid;
		AudioClips.Add(keyFrameAudio27);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio28 = default;
		keyFrameAudio28.KeyFrame = 8;
		object obj55 = keyFrameAudio28 + 8;
		obj55 = "h_jump7_heelflip";
		object obj56 = keyFrameAudio28 + 24;
		obj56 = h_short;
		AudioClips.Add(keyFrameAudio28);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio29 = default;
		keyFrameAudio29.KeyFrame = 13;
		object obj57 = keyFrameAudio29 + 8;
		obj57 = "h_jump7_heelflip";
		object obj58 = keyFrameAudio29 + 24;
		obj58 = h_miniKick;
		AudioClips.Add(keyFrameAudio29);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio30 = default;
		keyFrameAudio30.KeyFrame = 18;
		object obj59 = keyFrameAudio30 + 8;
		obj59 = "h_jump7_heelflip";
		object obj60 = keyFrameAudio30 + 24;
		obj60 = h_mid;
		AudioClips.Add(keyFrameAudio30);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio31 = default;
		keyFrameAudio31.KeyFrame = 1;
		object obj61 = keyFrameAudio31 + 8;
		obj61 = "h_jump8_pop shuvit";
		object obj62 = keyFrameAudio31 + 24;
		obj62 = h_kick;
		AudioClips.Add(keyFrameAudio31);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio32 = default;
		keyFrameAudio32.KeyFrame = 2;
		object obj63 = keyFrameAudio32 + 8;
		obj63 = "h_jump8_pop shuvit";
		object obj64 = keyFrameAudio32 + 24;
		obj64 = h_short;
		AudioClips.Add(keyFrameAudio32);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio33 = default;
		keyFrameAudio33.KeyFrame = 4;
		object obj65 = keyFrameAudio33 + 8;
		obj65 = "h_jump8_pop shuvit";
		object obj66 = keyFrameAudio33 + 24;
		obj66 = h_miniKick;
		AudioClips.Add(keyFrameAudio33);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio34 = default;
		keyFrameAudio34.KeyFrame = 10;
		object obj67 = keyFrameAudio34 + 8;
		obj67 = "h_jump8_pop shuvit";
		object obj68 = keyFrameAudio34 + 24;
		obj68 = h_mid;
		AudioClips.Add(keyFrameAudio34);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio35 = default;
		keyFrameAudio35.KeyFrame = 2;
		object obj69 = keyFrameAudio35 + 8;
		obj69 = "h_jump9_fs360";
		object obj70 = keyFrameAudio35 + 24;
		obj70 = h_kick;
		AudioClips.Add(keyFrameAudio35);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio36 = default;
		keyFrameAudio36.KeyFrame = 3;
		object obj71 = keyFrameAudio36 + 8;
		obj71 = "h_jump9_fs360";
		object obj72 = keyFrameAudio36 + 24;
		obj72 = h_short;
		AudioClips.Add(keyFrameAudio36);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio37 = default;
		keyFrameAudio37.KeyFrame = 10;
		object obj73 = keyFrameAudio37 + 8;
		obj73 = "h_jump9_fs360";
		object obj74 = keyFrameAudio37 + 24;
		obj74 = h_short;
		AudioClips.Add(keyFrameAudio37);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio38 = default;
		keyFrameAudio38.KeyFrame = 20;
		object obj75 = keyFrameAudio38 + 8;
		obj75 = "h_jump9_fs360";
		object obj76 = keyFrameAudio38 + 24;
		obj76 = h_mid;
		AudioClips.Add(keyFrameAudio38);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio39 = default;
		keyFrameAudio39.KeyFrame = 0;
		object obj77 = keyFrameAudio39 + 8;
		obj77 = "h_jump10_heel360";
		object obj78 = keyFrameAudio39 + 24;
		obj78 = h_miniKick;
		AudioClips.Add(keyFrameAudio39);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio40 = default;
		keyFrameAudio40.KeyFrame = 4;
		object obj79 = keyFrameAudio40 + 8;
		obj79 = "h_jump10_heel360";
		object obj80 = keyFrameAudio40 + 24;
		obj80 = h_kick;
		AudioClips.Add(keyFrameAudio40);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio41 = default;
		keyFrameAudio41.KeyFrame = 5;
		object obj81 = keyFrameAudio41 + 8;
		obj81 = "h_jump10_heel360";
		object obj82 = keyFrameAudio41 + 24;
		obj82 = h_short;
		AudioClips.Add(keyFrameAudio41);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio42 = default;
		keyFrameAudio42.KeyFrame = 8;
		object obj83 = keyFrameAudio42 + 8;
		obj83 = "h_jump10_heel360";
		object obj84 = keyFrameAudio42 + 24;
		obj84 = h_mid;
		AudioClips.Add(keyFrameAudio42);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio43 = default;
		keyFrameAudio43.KeyFrame = 11;
		object obj85 = keyFrameAudio43 + 8;
		obj85 = "h_jump10_heel360";
		object obj86 = keyFrameAudio43 + 24;
		obj86 = h_short;
		AudioClips.Add(keyFrameAudio43);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio44 = default;
		keyFrameAudio44.KeyFrame = 14;
		object obj87 = keyFrameAudio44 + 8;
		obj87 = "h_jump10_heel360";
		object obj88 = keyFrameAudio44 + 24;
		obj88 = h_miniKick;
		AudioClips.Add(keyFrameAudio44);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio45 = default;
		keyFrameAudio45.KeyFrame = 20;
		object obj89 = keyFrameAudio45 + 8;
		obj89 = "h_jump10_heel360";
		object obj90 = keyFrameAudio45 + 24;
		obj90 = h_mid;
		AudioClips.Add(keyFrameAudio45);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio46 = default;
		keyFrameAudio46.KeyFrame = 1;
		object obj91 = keyFrameAudio46 + 8;
		obj91 = "h_jump11_fs salto";
		object obj92 = keyFrameAudio46 + 24;
		obj92 = h_kick;
		AudioClips.Add(keyFrameAudio46);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio47 = default;
		keyFrameAudio47.KeyFrame = 2;
		object obj93 = keyFrameAudio47 + 8;
		obj93 = "h_jump11_fs salto";
		object obj94 = keyFrameAudio47 + 24;
		obj94 = h_long;
		AudioClips.Add(keyFrameAudio47);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio48 = default;
		keyFrameAudio48.KeyFrame = 8;
		object obj95 = keyFrameAudio48 + 8;
		obj95 = "h_jump11_fs salto";
		object obj96 = keyFrameAudio48 + 24;
		obj96 = h_short;
		AudioClips.Add(keyFrameAudio48);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio49 = default;
		keyFrameAudio49.KeyFrame = 1;
		object obj97 = keyFrameAudio49 + 8;
		obj97 = "h_Grind1_land";
		object obj98 = keyFrameAudio49 + 24;
		obj98 = h_landingGrind;
		AudioClips.Add(keyFrameAudio49);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio50 = default;
		keyFrameAudio50.KeyFrame = 1;
		object obj99 = keyFrameAudio50 + 8;
		obj99 = "h_Grind2_land";
		object obj100 = keyFrameAudio50 + 24;
		obj100 = h_landingGrind;
		AudioClips.Add(keyFrameAudio50);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KeyFrameAudio keyFrameAudio51 = default;
		keyFrameAudio51.KeyFrame = 1;
		object obj101 = keyFrameAudio51 + 8;
		obj101 = "h_Grind3_land";
		object obj102 = keyFrameAudio51 + 24;
		obj102 = h_landingGrind;
		AudioClips.Add(keyFrameAudio51);
	}
}
