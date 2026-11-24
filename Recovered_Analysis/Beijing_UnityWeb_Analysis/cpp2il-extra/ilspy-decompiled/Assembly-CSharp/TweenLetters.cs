using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class TweenLetters : UITweener
{
	public enum AnimationLetterOrder
	{
		Forward,
		Reverse,
		Random
	}

	private class LetterProperties
	{
		public float start;

		public float duration;

		public Vector2 offset;

		public LetterProperties()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_0287: Invalid comparison between F4 and I4
			//IL_02b1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenLetters+LetterProperties)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenLetters+LetterProperties)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenLetters+LetterProperties)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && duration != 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
						object obj19 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj19 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
							}
						}
						else if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}
	}

	[Serializable]
	public class AnimationProperties
	{
		public AnimationLetterOrder animationOrder;

		public float overlap;

		public bool randomDurations;

		public Vector2 randomness;

		public Vector2 offsetRange;

		public Vector3 pos;

		public Vector3 rot;

		public Vector3 scale;

		public float alpha;
	}

	public AnimationProperties hoverOver;

	public AnimationProperties hoverOut;

	private UILabel mLabel;

	private int mVertexCount;

	private int[] mLetterOrder;

	private LetterProperties[] mLetter;

	private AnimationProperties mCurrent;

	private void OnEnable()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		hoverOver = (AnimationProperties)100;
		hoverOut = (AnimationProperties)100;
		((UI2DSprite)(object)this).OnUpdate();
	}

	private unsafe void OnDisable()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		mVertexCount = -1;
		UILabel uILabel = mLabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(TweenLetters.OnPostFill);
		object obj2 = obj + 16;
		obj2 = this;
		object obj3 = mLabel + 120;
		Delegate obj4 = ((Delegate)uILabel.onPostFill).CombineImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj5 = default;
		obj3 = obj5;
	}

	private unsafe void Awake()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		UILabel uILabel = mLabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(TweenLetters.OnPostFill);
		object obj2 = obj + 16;
		obj2 = this;
		object obj3 = mLabel + 120;
		Delegate obj4 = ((Delegate)uILabel.onPostFill).RemoveImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj5 = default;
		obj3 = obj5;
	}

	public override void Play(bool forward)
	{
		//IL_0013: Expected Obj, but got I4
		int height = ((TweenHeight)this).height;
		Color color = ((UIWidget)forward).color;
	}

	private void OnPostFill(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((((ComputeShader)(object)widget).FindKernel((string)null) != 0) ? ((GameObject)(object)widget).layer : 0);
		object obj2 = base.method + 8;
		obj2 = num3;
		object obj3 = base.style + 8;
		obj3 = num3;
		object obj4 = (ignoreTimeScale ? 1 : 0) + 8;
		obj4 = num3;
		object obj5 = base.animationCurve + 8;
		obj5 = num3;
		Method method = base.method;
		_ = 0f;
		Style style = base.style;
		_ = 1f;
		AnimationCurve animationCurve = base.animationCurve;
		_ = 0f;
		bool flag = ignoreTimeScale;
		_ = 1f;
		Method method2 = base.method;
		Style style2 = base.style;
		AnimationCurve animationCurve2 = base.animationCurve;
		bool flag2 = ignoreTimeScale;
		((UIRect)(object)this).ResetAndUpdateAnchors();
		((UIRect)(object)this).ResetAnchors();
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_0333: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_027e: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_0186: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v41 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = 1f - factor;
		float num4 = (float)hoverOver * num3;
		float num5 = (float)hoverOut * factor;
		float width = num4 + num5;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		Play((byte)(int)gUILayoutOption != 0);
		if ((object)mLabel == null)
		{
			return;
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)mLetterOrder != null)
		{
			string go = tag;
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v27 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num9 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v37 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = this + 104;
			UITable uITable = NGUITools.FindInParents<UITable>((GameObject)(object)go);
			obj4 = uITable;
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)mLetterOrder != null)
			{
				mLabel = null;
				return;
			}
		}
		((UITable)(object)mLetterOrder).Sort((List<Transform>)1);
	}

	private void SetLetterOrder(int letterCount)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I4
		object obj = this + 112;
		AnimationProperties animationProperties = ((letterCount == 0) ? hoverOut : hoverOver);
		obj = animationProperties;
		((UI2DSprite)(object)this).sprite2D = (Sprite)letterCount;
	}

	private void GetLetterDuration(int letterCount)
	{
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02c7: Expected Obj, but got I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02db: Expected Obj, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I4
		//IL_01e8: Expected Obj, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		int num = default;
		if (num != 0)
		{
			object obj4 = this + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj5 = default;
			obj4 = obj5;
			object obj6 = this + 108;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj7 = default;
			obj6 = obj7;
			object obj8 = default;
			if ((nint)obj8 < num)
			{
				object obj9 = mLetterOrder + 16;
				object obj10 = obj8 << 2;
				object obj11 = obj9 + obj10;
				AnimationProperties animationProperties = mCurrent;
				object obj13;
				if (animationProperties.animationOrder == AnimationLetterOrder.Reverse)
				{
					object obj12 = num - 1;
					obj13 = obj12 - obj8;
				}
				else
				{
					obj13 = obj8;
				}
				obj11 = obj13;
				object obj14 = mLetterOrder + 16;
				object obj15 = obj8 << 2;
				object obj16 = obj14 + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				throw new ArrayTypeMismatchException();
			}
			AnimationProperties animationProperties2 = mCurrent;
			if (animationProperties2.animationOrder == AnimationLetterOrder.Random)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				RankException ex = default;
				ex._002Ector();
				int num2 = default;
				object obj20 = default;
				while (num2 >= 2)
				{
					num2 = num - 1;
					object obj17 = num2 + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					object obj18 = mLetterOrder + 16;
					object obj19 = obj20 << 2;
					object obj21 = obj18 + obj19;
					object obj22 = mLetterOrder + 16;
					object obj23 = obj20 << 2;
					object obj24 = obj22 + obj23;
					object obj25 = mLetterOrder + 16;
					int num3 = num2 << 2;
					object obj26 = obj25 + num3;
					obj24 = obj26;
					object obj27 = mLetterOrder + 16;
					int num4 = num2 << 2;
					object obj28 = obj27 + num4;
					obj28 = obj21;
				}
			}
		}
		else
		{
			object obj29 = this + 108;
			obj29 = 0;
			object obj30 = this + 104;
			obj30 = 0;
		}
	}

	private float ScaleRange(float value, float baseMax, float limitMax)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	private static Vector3 GetCenter(List<Vector3> verts, int firstVert, int length)
	{
		Vector3 result = default;
		return result;
	}

	public TweenLetters()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		object obj = this + 96;
		UILabel component = GetComponent<UILabel>();
		obj = component;
		object obj2 = this + 112;
		obj2 = hoverOver;
	}
}
