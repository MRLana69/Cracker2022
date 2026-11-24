using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Automation.Steps;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using UnityEngine;
using UnityEngine.UI;

public class TutorialEvent : MonoBehaviour
{
	public enum TutorialText
	{
		None,
		FreshMoves,
		DoubleTap,
		YouRock
	}

	private sealed class _003CShowArrow_003Ed__20(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEvent _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_1a00: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a05: Expected VT, but got Unknown
				//IL_1a0e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a13: Expected VT, but got Unknown
				//IL_1a1c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a21: Expected Obj, but got Unknown
				//IL_1a2a: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a2f: Expected Obj, but got Unknown
				//IL_1a38: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a3d: Expected Obj, but got Unknown
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected Obj, but got Unknown
				//IL_0080: Expected Obj, but got I4
				//IL_008f: Expected Obj, but got F4
				//IL_00a9: Expected I, but got Obj
				//IL_00bf: Expected Obj, but got I
				//IL_1a73: Expected F4, but got Obj
				//IL_1a6e: Expected native int or pointer, but got VT
				//IL_1abb: Expected F4, but got Obj
				//IL_1ab6: Expected native int or pointer, but got VT
				//IL_1ad0: Expected F4, but got I
				//IL_1acb: Expected native int or pointer, but got VT
				//IL_1add: Expected F4, but got Obj
				//IL_1ad8: Expected native int or pointer, but got VT
				//IL_0136: Expected F4, but got Obj
				//IL_0131: Expected native int or pointer, but got VT
				//IL_014c: Expected Obj, but got VT
				//IL_00ea: Expected I, but got Obj
				//IL_0172: Expected Obj, but got I4
				//IL_0194: Expected Obj, but got I4
				//IL_01ff: Expected F4, but got I4
				//IL_1b06: Invalid comparison between F4 and I4
				//IL_023d: Expected F4, but got I4
				//IL_0e1e: Invalid comparison between F4 and I4
				//IL_027b: Expected F4, but got I4
				//IL_1877: Expected I, but got Obj
				//IL_188d: Expected Obj, but got I
				//IL_0299: Invalid comparison between F4 and I4
				//IL_0e3b: Invalid comparison between F4 and I4
				//IL_0cf2: Expected I, but got Obj
				//IL_0d08: Expected Obj, but got I
				//IL_1b4b: Expected native int or pointer, but got VT
				//IL_1b59: Expected native int or pointer, but got VT
				//IL_1b67: Expected native int or pointer, but got VT
				//IL_1b75: Expected native int or pointer, but got VT
				//IL_1b83: Expected native int or pointer, but got VT
				//IL_1b95: Expected native int or pointer, but got VT
				//IL_1bad: Unknown result type (might be due to invalid IL or missing references)
				//IL_1bb2: Expected Obj, but got Unknown
				//IL_1bbf: Expected Obj, but got F4
				//IL_1bed: Unknown result type (might be due to invalid IL or missing references)
				//IL_1bf2: Expected Obj, but got Unknown
				//IL_1c00: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c05: Expected Obj, but got Unknown
				//IL_18b8: Expected I, but got Obj
				//IL_02b6: Invalid comparison between F4 and I4
				//IL_19a1: Expected Obj, but got I4
				//IL_0e58: Invalid comparison between F4 and I4
				//IL_0d33: Expected I, but got Obj
				//IL_02d3: Invalid comparison between F4 and I4
				//IL_0e75: Invalid comparison between F4 and I4
				//IL_02f0: Invalid comparison between F4 and I4
				//IL_0e92: Invalid comparison between F4 and I4
				//IL_030d: Invalid comparison between F4 and I4
				//IL_0eaf: Invalid comparison between F4 and I4
				//IL_032a: Invalid comparison between F4 and I4
				//IL_0ecc: Invalid comparison between F4 and I4
				//IL_0347: Invalid comparison between F4 and I4
				//IL_0ee9: Invalid comparison between F4 and I4
				//IL_0364: Invalid comparison between F4 and I4
				//IL_0f06: Invalid comparison between F4 and I4
				//IL_0381: Invalid comparison between F4 and I4
				//IL_0f23: Invalid comparison between F4 and I4
				//IL_039e: Invalid comparison between F4 and I4
				//IL_0f40: Invalid comparison between F4 and I4
				//IL_03bb: Invalid comparison between F4 and I4
				//IL_0f5d: Invalid comparison between F4 and I4
				//IL_03d8: Invalid comparison between F4 and I4
				//IL_0f7a: Invalid comparison between F4 and I4
				//IL_03f5: Invalid comparison between F4 and I4
				//IL_0f97: Invalid comparison between F4 and I4
				//IL_0412: Invalid comparison between F4 and I4
				//IL_0fb4: Invalid comparison between F4 and I4
				//IL_042f: Invalid comparison between F4 and I4
				//IL_0fd1: Invalid comparison between F4 and I4
				//IL_044c: Invalid comparison between F4 and I4
				//IL_0fee: Invalid comparison between F4 and I4
				//IL_0469: Invalid comparison between F4 and I4
				//IL_100b: Invalid comparison between F4 and I4
				//IL_0486: Invalid comparison between F4 and I4
				//IL_1028: Invalid comparison between F4 and I4
				//IL_04a3: Invalid comparison between F4 and I4
				//IL_1045: Invalid comparison between F4 and I4
				//IL_04c0: Invalid comparison between F4 and I4
				//IL_1062: Invalid comparison between F4 and I4
				//IL_04dd: Invalid comparison between F4 and I4
				//IL_107f: Invalid comparison between F4 and I4
				//IL_04fa: Invalid comparison between F4 and I4
				//IL_109c: Invalid comparison between F4 and I4
				//IL_0517: Invalid comparison between F4 and I4
				//IL_10b9: Invalid comparison between F4 and I4
				//IL_0534: Invalid comparison between F4 and I4
				//IL_10d6: Invalid comparison between F4 and I4
				//IL_0551: Invalid comparison between F4 and I4
				//IL_10f3: Invalid comparison between F4 and I4
				//IL_056e: Invalid comparison between F4 and I4
				//IL_1110: Invalid comparison between F4 and I4
				//IL_058b: Invalid comparison between F4 and I4
				//IL_112d: Invalid comparison between F4 and I4
				//IL_05a8: Invalid comparison between F4 and I4
				//IL_114a: Invalid comparison between F4 and I4
				//IL_05c5: Invalid comparison between F4 and I4
				//IL_1167: Invalid comparison between F4 and I4
				//IL_05e2: Invalid comparison between F4 and I4
				//IL_1184: Invalid comparison between F4 and I4
				//IL_05ff: Invalid comparison between F4 and I4
				//IL_11a1: Invalid comparison between F4 and I4
				//IL_061c: Invalid comparison between F4 and I4
				//IL_11be: Invalid comparison between F4 and I4
				//IL_0639: Invalid comparison between F4 and I4
				//IL_11db: Invalid comparison between F4 and I4
				//IL_0656: Invalid comparison between F4 and I4
				//IL_11f8: Invalid comparison between F4 and I4
				//IL_0673: Invalid comparison between F4 and I4
				//IL_1215: Invalid comparison between F4 and I4
				//IL_0690: Invalid comparison between F4 and I4
				//IL_1232: Invalid comparison between F4 and I4
				//IL_06ad: Invalid comparison between F4 and I4
				//IL_124f: Invalid comparison between F4 and I4
				//IL_06ca: Invalid comparison between F4 and I4
				//IL_126c: Invalid comparison between F4 and I4
				//IL_06e7: Invalid comparison between F4 and I4
				//IL_1289: Invalid comparison between F4 and I4
				//IL_0704: Invalid comparison between F4 and I4
				//IL_12a6: Invalid comparison between F4 and I4
				//IL_0721: Invalid comparison between F4 and I4
				//IL_12c3: Invalid comparison between F4 and I4
				//IL_073e: Invalid comparison between F4 and I4
				//IL_12e0: Invalid comparison between F4 and I4
				//IL_075b: Invalid comparison between F4 and I4
				//IL_12fd: Invalid comparison between F4 and I4
				//IL_0778: Invalid comparison between F4 and I4
				//IL_131a: Invalid comparison between F4 and I4
				//IL_0795: Invalid comparison between F4 and I4
				//IL_1337: Invalid comparison between F4 and I4
				//IL_07b2: Invalid comparison between F4 and I4
				//IL_1354: Invalid comparison between F4 and I4
				//IL_07cf: Invalid comparison between F4 and I4
				//IL_1371: Invalid comparison between F4 and I4
				//IL_07ec: Invalid comparison between F4 and I4
				//IL_138e: Invalid comparison between F4 and I4
				//IL_0809: Invalid comparison between F4 and I4
				//IL_13ab: Invalid comparison between F4 and I4
				//IL_0826: Invalid comparison between F4 and I4
				//IL_13c8: Invalid comparison between F4 and I4
				//IL_0843: Invalid comparison between F4 and I4
				//IL_13e5: Invalid comparison between F4 and I4
				//IL_0860: Invalid comparison between F4 and I4
				//IL_1402: Invalid comparison between F4 and I4
				//IL_087d: Invalid comparison between F4 and I4
				//IL_141f: Invalid comparison between F4 and I4
				//IL_089a: Invalid comparison between F4 and I4
				//IL_143c: Invalid comparison between F4 and I4
				//IL_08b7: Invalid comparison between F4 and I4
				//IL_1459: Invalid comparison between F4 and I4
				//IL_08d4: Invalid comparison between F4 and I4
				//IL_1476: Invalid comparison between F4 and I4
				//IL_08f1: Invalid comparison between F4 and I4
				//IL_1493: Invalid comparison between F4 and I4
				//IL_090e: Invalid comparison between F4 and I4
				//IL_14b0: Invalid comparison between F4 and I4
				//IL_092b: Invalid comparison between F4 and I4
				//IL_14cd: Invalid comparison between F4 and I4
				//IL_0948: Invalid comparison between F4 and I4
				//IL_14ea: Invalid comparison between F4 and I4
				//IL_0965: Invalid comparison between F4 and I4
				//IL_1507: Invalid comparison between F4 and I4
				//IL_0982: Invalid comparison between F4 and I4
				//IL_1524: Invalid comparison between F4 and I4
				//IL_099f: Invalid comparison between F4 and I4
				//IL_1541: Invalid comparison between F4 and I4
				//IL_09bc: Invalid comparison between F4 and I4
				//IL_155e: Invalid comparison between F4 and I4
				//IL_09d9: Invalid comparison between F4 and I4
				//IL_157b: Invalid comparison between F4 and I4
				//IL_09f6: Invalid comparison between F4 and I4
				//IL_1598: Invalid comparison between F4 and I4
				//IL_0a13: Invalid comparison between F4 and I4
				//IL_15b5: Invalid comparison between F4 and I4
				//IL_0a30: Invalid comparison between F4 and I4
				//IL_15d2: Invalid comparison between F4 and I4
				//IL_0a4d: Invalid comparison between F4 and I4
				//IL_15ef: Invalid comparison between F4 and I4
				//IL_0a6a: Invalid comparison between F4 and I4
				//IL_160c: Invalid comparison between F4 and I4
				//IL_0a87: Invalid comparison between F4 and I4
				//IL_1629: Invalid comparison between F4 and I4
				//IL_0aa4: Invalid comparison between F4 and I4
				//IL_1646: Invalid comparison between F4 and I4
				//IL_0ac1: Invalid comparison between F4 and I4
				//IL_1663: Invalid comparison between F4 and I4
				//IL_0ade: Invalid comparison between F4 and I4
				//IL_1680: Invalid comparison between F4 and I4
				//IL_0afb: Invalid comparison between F4 and I4
				//IL_169d: Invalid comparison between F4 and I4
				//IL_0b18: Invalid comparison between F4 and I4
				//IL_16ba: Invalid comparison between F4 and I4
				//IL_0b35: Invalid comparison between F4 and I4
				//IL_16d7: Invalid comparison between F4 and I4
				//IL_0b52: Invalid comparison between F4 and I4
				//IL_16f4: Invalid comparison between F4 and I4
				//IL_0b6f: Invalid comparison between F4 and I4
				//IL_1711: Invalid comparison between F4 and I4
				//IL_0b8c: Invalid comparison between F4 and I4
				//IL_172e: Invalid comparison between F4 and I4
				//IL_0ba9: Invalid comparison between F4 and I4
				//IL_174b: Invalid comparison between F4 and I4
				//IL_0bc6: Invalid comparison between F4 and I4
				//IL_1768: Invalid comparison between F4 and I4
				//IL_0be3: Invalid comparison between F4 and I4
				//IL_1785: Invalid comparison between F4 and I4
				//IL_0c00: Invalid comparison between F4 and I4
				//IL_17a2: Invalid comparison between F4 and I4
				//IL_0c1d: Invalid comparison between F4 and I4
				//IL_17bf: Invalid comparison between F4 and I4
				//IL_0c3a: Invalid comparison between F4 and I4
				//IL_17dc: Invalid comparison between F4 and I4
				//IL_0c57: Invalid comparison between F4 and I4
				//IL_17f9: Invalid comparison between F4 and I4
				//IL_0c74: Invalid comparison between F4 and I4
				//IL_1816: Invalid comparison between F4 and I4
				//IL_0c91: Invalid comparison between F4 and I4
				//IL_1833: Invalid comparison between F4 and I4
				//IL_0cae: Invalid comparison between F4 and I4
				//IL_1850: Invalid comparison between F4 and I4
				//IL_1905: Expected I, but got Obj
				//IL_191b: Expected Obj, but got I
				//IL_0ccb: Invalid comparison between F4 and I4
				//IL_0d80: Expected I, but got Obj
				//IL_0d96: Expected Obj, but got I
				//IL_1946: Expected I, but got Obj
				//IL_0dc1: Expected I, but got Obj
				object obj = default;
				Vector2 vector = (Vector2)(obj + 80);
				Quaternion quaternion = (Quaternion)(obj - -64);
				object obj2 = obj + 48;
				object obj3 = obj + 32;
				Transform transform = (Transform)(obj + 16);
				TutorialEvent tutorialEvent = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						IEnumerator enumerator = _003C_003E4__this.ShowArrow();
						((GameObject)(object)enumerator).tag = null;
						Coroutine coroutine = _003C_003E4__this.StartCoroutine((IEnumerator)(object)"FadeOutArrowsText");
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj5 = default;
				object obj4 = obj5 + 8;
				obj4 = _003C_003E4__this;
				IEnumerator enumerator2 = _003C_003E4__this.ShowArrow();
				int layer = ((GameObject)(object)enumerator2).layer;
				obj2 = 0;
				_ = 0;
				obj2 = 0f;
				_ = 0f;
				_ = 1f;
				nint num = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v24 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v88 (Il2CppClass<UnityEngine.Quaternion>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector2*)(nint)vector)->x = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				Vector2 vector2 = tutorialEvent.direction * vector;
				transform.Rotate(0f, 180f, 0f);
				((Quaternion*)(nint)quaternion)->x = (float)obj3;
				Quaternion quaternion2 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Quaternion*)(nint)quaternion2)->z = 0f;
				((Vector2*)(nint)vector)->x = (float)transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				Vector3 vector3 = quaternion * vector;
				((Vector2*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Quaternion localRotation = ((Transform)vector).localRotation;
				IEnumerator enumerator3 = _003C_003E4__this.ShowArrow();
				((GameObject)(object)enumerator3).tag = (string)1;
				GameObject mesh = _003C_003E4__this.mesh;
				mesh.tag = (string)1;
				GameObject mesh2 = _003C_003E4__this.mesh;
				Text component = mesh2.GetComponent<Text>();
				float num3 = tutorialEvent.direction;
				if (tutorialEvent.direction != tutorialEvent.direction)
				{
					num3 = -2.1474836E+09f;
				}
				else if (!(tutorialEvent.direction < 2.1474836E+09f))
				{
					num3 = -2.1474836E+09f;
				}
				else if (!(tutorialEvent.direction > -2.1474836E+09f))
				{
					num3 = -2.1474836E+09f;
				}
				if (num3 > 0f)
				{
					float num4 = num3 - 90f;
					if (num3 != 90f)
					{
						if (num4 != 1f && num4 != 2f && num4 != 3f && num4 != 4f && num4 != 5f && num4 != 6f && num4 != 7f && num4 != 8f && num4 != 9f && num4 != 10f && num4 != 11f && num4 != 12f && num4 != 13f && num4 != 14f && num4 != 15f && num4 != 16f && num4 != 17f && num4 != 18f && num4 != 19f && num4 != 20f && num4 != 21f && num4 != 22f && num4 != 23f && num4 != 24f && num4 != 25f && num4 != 26f && num4 != 27f && num4 != 28f && num4 != 29f && num4 != 30f && num4 != 31f && num4 != 32f && num4 != 33f && num4 != 34f && num4 != 35f && num4 != 36f && num4 != 37f && num4 != 38f && num4 != 39f && num4 != 40f && num4 != 41f && num4 != 42f && num4 != 43f && num4 != 44f && num4 != 45f && num4 != 46f && num4 != 47f && num4 != 48f && num4 != 49f && num4 != 50f && num4 != 51f && num4 != 52f && num4 != 53f && num4 != 54f && num4 != 55f && num4 != 56f && num4 != 57f && num4 != 58f && num4 != 59f && num4 != 60f && num4 != 61f && num4 != 62f && num4 != 63f && num4 != 64f && num4 != 65f && num4 != 66f && num4 != 67f && num4 != 68f && num4 != 69f && num4 != 70f && num4 != 71f && num4 != 72f && num4 != 73f && num4 != 74f && num4 != 75f && num4 != 76f && num4 != 77f && num4 != 78f && num4 != 79f && num4 != 80f && num4 != 81f && num4 != 82f && num4 != 83f && num4 != 84f && num4 != 85f && num4 != 86f && num4 != 87f && num4 != 88f && num4 != 89f && num4 == 90f)
						{
							nint num5 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S0_v105 (Il2CppClass<Strings>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num6 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v110 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string text = Strings.GetDefault("TUTORIAL_ARROW_KEY_DOWN");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						}
					}
					else
					{
						nint num7 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v94 (Il2CppClass<Strings>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num8 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v99 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text2 = Strings.GetDefault("TUTORIAL_ARROW_KEY_LEFT");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
					}
				}
				else
				{
					float num9 = num3 - -90f;
					if (num3 != -90f)
					{
						if (num9 != 1f && num9 != 2f && num9 != 3f && num9 != 4f && num9 != 5f && num9 != 6f && num9 != 7f && num9 != 8f && num9 != 9f && num9 != 10f && num9 != 11f && num9 != 12f && num9 != 13f && num9 != 14f && num9 != 15f && num9 != 16f && num9 != 17f && num9 != 18f && num9 != 19f && num9 != 20f && num9 != 21f && num9 != 22f && num9 != 23f && num9 != 24f && num9 != 25f && num9 != 26f && num9 != 27f && num9 != 28f && num9 != 29f && num9 != 30f && num9 != 31f && num9 != 32f && num9 != 33f && num9 != 34f && num9 != 35f && num9 != 36f && num9 != 37f && num9 != 38f && num9 != 39f && num9 != 40f && num9 != 41f && num9 != 42f && num9 != 43f && num9 != 44f && num9 != 45f && num9 != 46f && num9 != 47f && num9 != 48f && num9 != 49f && num9 != 50f && num9 != 51f && num9 != 52f && num9 != 53f && num9 != 54f && num9 != 55f && num9 != 56f && num9 != 57f && num9 != 58f && num9 != 59f && num9 != 60f && num9 != 61f && num9 != 62f && num9 != 63f && num9 != 64f && num9 != 65f && num9 != 66f && num9 != 67f && num9 != 68f && num9 != 69f && num9 != 70f && num9 != 71f && num9 != 72f && num9 != 73f && num9 != 74f && num9 != 75f && num9 != 76f && num9 != 77f && num9 != 78f && num9 != 79f && num9 != 80f && num9 != 81f && num9 != 82f && num9 != 83f && num9 != 84f && num9 != 85f && num9 != 86f && num9 != 87f && num9 != 88f && num9 != 89f && num9 == 90f)
						{
							nint num10 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v82 (Il2CppClass<Strings>)+BA]");
							object obj9 = (nint)0 & (nint)0x200;
							if (obj9 != null)
							{
								nint num11 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v87 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string text3 = Strings.GetDefault("TUTORIAL_ARROW_KEY_UP");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						}
					}
					else
					{
						nint num12 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v72 (Il2CppClass<Strings>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num13 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v77 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text4 = Strings.GetDefault("TUTORIAL_ARROW_KEY_RIGHT");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
					}
				}
				((Quaternion*)(nint)quaternion)->x = 0f;
				((Quaternion*)(nint)quaternion)->z = 0f;
				((Quaternion*)(nint)quaternion)->x = 0f;
				((Quaternion*)(nint)quaternion)->y = 0f;
				((Quaternion*)(nint)quaternion)->z = 20f;
				((Vector2*)(nint)vector)->x = quaternion.x;
				_ = quaternion.z;
				object obj11 = obj5 + 12;
				obj11 = vector.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector2)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num14 = 0;
				_ = 0;
				object obj13 = default;
				object obj12 = obj13 + 16;
				obj12 = obj5;
				object obj14 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
				IEnumerator routine = default;
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto(routine);
				obj14 = coroutine2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CFadeOutArrowsText_003Ed__21(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEvent _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private float _003CfadeTime_003E5__3;

		private Vector3 _003CscaleFrom_003E5__4;

		private Vector3 _003CscaleTo_003E5__5;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b9: Expected Obj, but got Unknown
				//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c7: Expected Obj, but got Unknown
				//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d5: Expected Obj, but got Unknown
				//IL_03de: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e3: Expected Obj, but got Unknown
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Expected Obj, but got Unknown
				//IL_009e: Expected Obj, but got I4
				//IL_00f0: Expected VT, but got I4
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Expected Obj, but got Unknown
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Expected Obj, but got Unknown
				//IL_0138: Unknown result type (might be due to invalid IL or missing references)
				//IL_013d: Expected Obj, but got Unknown
				//IL_0146: Expected Obj, but got I4
				//IL_018a: Unknown result type (might be due to invalid IL or missing references)
				//IL_018f: Expected Obj, but got Unknown
				//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e8: Expected Obj, but got Unknown
				//IL_0303: Unknown result type (might be due to invalid IL or missing references)
				//IL_0308: Expected Obj, but got Unknown
				//IL_032b: Expected I, but got Obj
				//IL_0341: Expected Obj, but got I
				//IL_045e: Expected VT, but got Obj
				//IL_045e: Expected VT, but got Obj
				//IL_048c: Expected Obj, but got I4
				//IL_0492: Unknown result type (might be due to invalid IL or missing references)
				//IL_0497: Expected Obj, but got Unknown
				//IL_04a0: Expected Obj, but got I4
				//IL_04b4: Expected Obj, but got I4
				//IL_021a: Unknown result type (might be due to invalid IL or missing references)
				//IL_021f: Expected Obj, but got Unknown
				//IL_0263: Expected Obj, but got I4
				//IL_036c: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 48);
				Transform transform2 = (Transform)(obj + 36);
				object obj2 = obj + 24;
				object obj3 = obj + 12;
				TutorialEvent tutorialEvent = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						_003Cduration_003E5__2 = 0.2f;
						_003CfadeTime_003E5__3 = 0f;
						GameObject mesh = tutorialEvent.mesh;
						int layer = mesh.layer;
						transform2.localScale = (Vector3)layer;
						transform = transform2;
						((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
						object obj4 = this + 28;
						obj4 = transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
						object obj5 = this + 28;
						object obj6 = this + 28;
						obj2 = 0;
						_ = 0;
						obj2 = obj5;
						_ = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v63+8]");
						_ = 0;
						transform = (Transform)obj2;
						Transform transform3 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
						object obj7 = this + 40;
						obj7 = transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
					}
					if (!(_003CfadeTime_003E5__3 < 0.2f))
					{
						GameObject mesh2 = tutorialEvent.mesh;
						int layer2 = mesh2.layer;
						object obj8 = this + 28;
						transform2 = (Transform)obj8;
						Transform transform4 = transform2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S2_v33+8]");
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						transform = transform2;
						((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
						((Transform)layer2).parent = transform;
						GameObject mesh3 = tutorialEvent.mesh;
						mesh3.tag = null;
						return null;
					}
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime / _003Cduration_003E5__2;
					float num2 = _003CfadeTime_003E5__3 + num;
					_003CfadeTime_003E5__3 = num2;
					GameObject mesh4 = tutorialEvent.mesh;
					int layer3 = mesh4.layer;
					object obj9 = this + 28;
					obj2 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S2_v8+8]");
					_ = 0;
					object obj10 = this + 40;
					obj3 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S2_v13+8]");
					_ = 0;
					nint num3 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v29 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num4 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v44 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform2 = (Transform)obj2;
					Transform transform5 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					transform = (Transform)obj3;
					Transform transform6 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
					Vector3 vector = Vector3.LerpUnclamped((Vector3)transform2, (Vector3)transform, _003CfadeTime_003E5__3);
					transform = (Transform)obj;
					Transform transform7 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
					((Transform)layer3).parent = transform;
					object obj12 = this + 12;
					obj12 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				float num5 = tutorialEvent.time * 0.5f;
				object obj13 = this + 12;
				object obj14 = default;
				obj13 = obj14;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private Game game;

	private bool displayText;

	private TutorialText tutorialText;

	private bool displayMesh;

	private float direction;

	private float time;

	private bool endTutorial;

	private bool allowHoverboard;

	private Hoverboard hoverboard;

	private Character character;

	private bool _initialized;

	private GameObject _mesh;

	private GameObject _label;

	private GameObject label
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = endTutorial;
			return (GameObject)flag;
		}
	}

	private GameObject mesh
	{
		get
		{
			//IL_0086: Expected I, but got Obj
			//IL_009c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_label != null)
			{
				object obj2 = this + 56;
				GameObject gameObject = ((GameObject)(object)"worldtext").gameObject;
				obj2 = gameObject;
			}
			return _label;
		}
	}

	private void Awake()
	{
		CancelInvoke();
	}

	private void Start()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 12;
		bool isInstantiated = Game.IsInstantiated;
		obj2 = isInstantiated;
		nint num3 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<Hoverboard>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 40;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		obj4 = characterModifier;
	}

	private IEnumerator ShowArrow()
	{
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_mesh != null)
		{
			object obj2 = this + 52;
			Camera current = Camera.current;
			string text = current.tag;
			int layer = ((GameObject)(object)text).layer;
			bool flag = ((Transform)layer).IsChildOf((Transform)(object)"arrow");
			string text2 = ((Component)flag).tag;
			obj2 = text2;
		}
		return (IEnumerator)(object)_mesh;
	}

	private IEnumerator FadeOutArrowsText()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void OnDisable()
	{
		//IL_00f9: Expected I, but got Obj
		//IL_010f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(this.game != null))
		{
			if (~(_initialized ? 1u : 0u) != 0)
			{
				object obj2 = this + 44;
				Game game = this.game;
				obj2 = game._character;
				_initialized = true;
			}
			object obj3 = this + 56;
			Camera current = Camera.current;
			string text = current.tag;
			int layer = ((GameObject)(object)text).layer;
			bool flag = ((Transform)layer).IsChildOf((Transform)(object)"Canvas");
			bool flag2 = ((Transform)flag).IsChildOf((Transform)(object)"worldtext");
			string text2 = ((Component)flag2).tag;
			obj3 = text2;
		}
	}

	private void OnTriggerExit(Collider collider)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00db: Expected F4, but got Obj
		//IL_00db: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		Component component = ((GameObject)(object)collider).GetComponent((Type)(object)"Player");
		if ((object)component == null)
		{
			return;
		}
		nint num = (nint)typeof(CharacterCamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		((OpenCloseUIElementStep)selectedBenchmarkIndex).Update((float)game);
	}

	private string GetStringForTutorial()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = this;
		return text;
	}

	public TutorialEvent()
	{
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_mesh).FindKernel((string)null) != 0)
		{
			_mesh.tag = null;
			GameObject gameObject = mesh;
			gameObject.tag = null;
		}
	}
}
