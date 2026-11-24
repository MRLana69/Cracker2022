using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationOrTween;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI.ModelCamera;
using UI.Screens;
using UnityEngine;

public class ActiveAnimation : MonoBehaviour
{
	public static ActiveAnimation current;

	public List<EventDelegate> onFinished;

	public GameObject eventReceiver;

	public string callWhenFinished;

	private Animation mAnim;

	private Direction mLastDirection;

	private Direction mDisableDirection;

	private bool mNotify;

	private Animator mAnimator;

	private string mClip;

	private float playbackTime => ((UIProgressBar)this).alpha;

	public bool isPlaying
	{
		get
		{
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Expected Obj, but got Unknown
			//IL_0186: Expected I, but got Obj
			//IL_019c: Expected Obj, but got I
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Expected Obj, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected Obj, but got Unknown
			//IL_0209: Expected I, but got Obj
			//IL_021f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			object obj = this + 36;
			GameObject gameObject = base.gameObject;
			obj = gameObject;
			string go = tag;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v46 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = this + 40;
			UIPanel uIPanel = NGUITools.FindInParents<UIPanel>((GameObject)(object)go);
			obj3 = uIPanel;
			object obj4 = this + 44;
			UIScrollView component = mAnimator.GetComponent<UIScrollView>();
			obj4 = component;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)mClip != null)
			{
				return false;
			}
			string text = mClip;
			if (text.m_firstChar == '\0')
			{
				_ = 1;
				return true;
			}
			string text2 = mClip;
			if (text2.m_firstChar == '\u0001')
			{
				_ = 0;
				return true;
			}
			return false;
		}
	}

	public void Finish()
	{
		//IL_0011: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		onFinished = (List<EventDelegate>)100;
		eventReceiver = (GameObject)1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Transform> list = default;
		list._002Ector();
		object obj = this + 52;
		obj = list;
		CancelInvoke();
	}

	public void Reset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0386: Expected I, but got Obj
		//IL_039c: Expected Obj, but got I
		//IL_02a4: Expected I, but got Obj
		//IL_02ba: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_02e5: Expected I, but got Obj
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_0401: Expected Obj, but got I4
		//IL_0458: Expected I4, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v77 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mAnim).FindKernel((string)null) != 0)
		{
			int stateCount = mAnim.GetStateCount();
			object obj4 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj4 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (mLastDirection == Direction.Forward)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
				}
				else if (mLastDirection == Direction.Reverse)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
				}
			}
			object obj5 = obj2 + 4;
			object obj6 = obj5 + 1;
			obj5 = obj6;
			object obj7 = obj6 << 2;
			object obj8 = obj2 + obj7;
			obj8 = 110;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj9 = default;
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj2 + obj10;
				if ((nint)obj11 == 110)
				{
					object obj12 = obj2 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					goto IL_04c0;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_04c0;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mAnimator).FindKernel((string)null) != 0)
		{
			float normalizedTime = ((mLastDirection != Direction.Forward) ? 0f : 1f);
			mAnimator.Play((int)mClip, 0, normalizedTime);
		}
		return;
		IL_04c0:
		Animation.INTERNAL_CALL_Sample(mAnim);
	}

	private void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_037f: Expected I, but got Obj
		//IL_0395: Expected Obj, but got I
		//IL_029d: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_02de: Expected I, but got Obj
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03fa: Expected Obj, but got I4
		//IL_046e: Expected I4, but got Obj
		//IL_01fa: Expected Obj, but got I
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v115 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mAnim).FindKernel((string)null) != 0)
		{
			int stateCount = mAnim.GetStateCount();
			object obj4 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj4 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (mLastDirection == Direction.Reverse)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
				}
				else if (mLastDirection == Direction.Forward)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
				}
			}
			object obj5 = obj2 + 4;
			object obj6 = obj5 + 1;
			obj5 = obj6;
			object obj7 = obj6 << 2;
			object obj8 = obj2 + obj7;
			obj8 = 163;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj9 = default;
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj2 + obj10;
				if ((nint)obj11 == 163)
				{
					object obj12 = obj2 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				return;
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mAnimator).FindKernel((string)null) != 0)
		{
			float normalizedTime = ((mLastDirection != Direction.Reverse) ? 0f : 1f);
			mAnimator.Play((int)mClip, 0, normalizedTime);
		}
	}

	private void Update()
	{
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got I4
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
		if (((ComputeShader)(object)eventReceiver).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<EventDelegate>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v19 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Localization.LoadAndSelect((string)(object)onFinished))
		{
			object obj3 = this + 16;
			obj3 = 0;
			object obj4 = this + 20;
			obj4 = 0;
		}
	}

	private void Play(string clipName, Direction playDirection)
	{
		//IL_006b: Expected VT, but got Obj
		//IL_0073: Expected I, but got Obj
		//IL_00f3: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I
		//IL_0049: Expected VT, but got Obj
		//IL_0086: Expected I, but got Obj
		if (mDisableDirection == Direction.Toggle)
		{
			return;
		}
		string text = mClip;
		Transform transform = default;
		nint num;
		if (text.m_firstChar == '\u0001')
		{
			transform.localPosition = (Vector3)clipName;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			num = 0;
		}
		else
		{
			transform.localPosition = (Vector3)clipName;
			num = (nint)transform;
		}
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v10 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float width = (float)num / (float)onFinished;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		string text2 = ((Component)(object)clipName).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
	}

	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_041a: Expected Obj, but got I4
		//IL_044f: Expected I, but got Obj
		//IL_0465: Expected Obj, but got I
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected Obj, but got Unknown
		//IL_055f: Expected Obj, but got I4
		//IL_0579: Expected Obj, but got I
		//IL_0589: Expected Obj, but got I
		//IL_0599: Expected Obj, but got I
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected Obj, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I4
		//IL_02df: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got I
		//IL_01f0: Expected I, but got Obj
		//IL_0030: Expected Obj, but got I4
		//IL_04c2: Expected Obj, but got I
		//IL_04d4: Expected I, but got Obj
		//IL_04ea: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_053b: Expected I4, but got Obj
		//IL_053b: Expected I4, but got Obj
		//IL_0320: Expected I, but got Obj
		//IL_03c1: Expected Obj, but got I4
		//IL_03c1: Expected Obj, but got I4
		//IL_036d: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I4
		//IL_03fa: Expected I4, but got Obj
		//IL_02ba: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		IngameScreen ingameScreen = ((UIPowerupHelper)null).ingameScreen;
		if ((object)ingameScreen != null)
		{
			((UIPowerupHandler)(object)anim).DisablePowerupSlot((UIPowerupHelper)null);
			((UIPowerupHandler)(object)anim).DisablePowerupSlot((UIPowerupHelper)4);
			((UIPowerupHandler)(object)anim).DisablePowerupSlot((UIPowerupHelper)13);
			switch (enableBeforePlay)
			{
			default:
				((UIPowerupHandler)(object)anim).DisablePowerupSlot((UIPowerupHelper)enableBeforePlay);
				break;
			case EnableCondition.DoNothing:
			case (EnableCondition)4:
			case (EnableCondition)13:
				break;
			}
		}
		nint num = (nint)typeof(ModelScreenSetups);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v14 (Il2CppClass<UI.ModelCamera.ModelScreenSetups>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ModelScreenSetups);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v67 (Il2CppClass<UI.ModelCamera.ModelScreenSetups>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AsyncCallback asyncCallback = (AsyncCallback)(obj2 + 16);
		bool isActive = ((RenderTextureCamera)enableBeforePlay).isActive;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v3 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S2_v4+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S2_v5+44]");
		object obj6 = 0;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v84 @ S3_v4 (should have been resolved before IL gen)");
		object obj9 = default;
		CharacterScreenManager characterScreenManager;
		if ((nint)obj9 > -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [anim @ L0 (UnityEngine.Animation)+58]");
			ModelScreenData modelScreenData = ((Dictionary<UIModelController.ModelScreen, ModelScreenData>)0).get_Item((UIModelController.ModelScreen)enableBeforePlay);
			if (modelScreenData != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [anim @ L0 (UnityEngine.Animation)+58]");
				ModelScreenData modelScreenData2 = ((Dictionary<UIModelController.ModelScreen, ModelScreenData>)0).get_Item((UIModelController.ModelScreen)enableBeforePlay);
				if ((nint)modelScreenData2.characterId__BackingField != (nint)clipName)
				{
					modelScreenData2.characterId__BackingField = (Characters.CharacterId)clipName;
				}
				if (modelScreenData2.themeVersion__BackingField != (int)playDirection)
				{
					modelScreenData2.themeVersion__BackingField = (int)playDirection;
				}
				characterScreenManager = (CharacterScreenManager)(object)modelScreenData2;
				goto IL_03ac;
			}
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [anim @ L0 (UnityEngine.Animation)+44]");
		GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)0);
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v37 (Il2CppClass<UIScreenController>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v47 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v42 (System.Boolean)+20]");
		CharacterScreenManager characterScreenManager2 = default;
		characterScreenManager2.PurchaseCharacter((CharacterScreenManager.CharacterPurchaseInitiator)gameObject, Characters.CharacterId.slick, (int)clipName, (int)playDirection);
		characterScreenManager = characterScreenManager2;
		goto IL_03ac;
		IL_03ac:
		((UIPopupList)(object)anim).AddItem((string)enableBeforePlay, (object)isActive, (Action)(object)characterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		asyncCallback = (AsyncCallback)obj2;
		return (ActiveAnimation)((UIWidget.OnPostFillCallback)(object)anim).BeginInvoke((UIWidget)(object)characterScreenManager, (int)clipName, (List<Vector3>)playDirection, (List<Vector2>)enableBeforePlay, (List<Color>)disableCondition, asyncCallback, (object)null);
	}

	public unsafe static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected Obj, but got Unknown
		//IL_0618: Expected Obj, but got I4
		//IL_06ed: Expected Obj, but got I4
		//IL_0375: Expected I, but got Obj
		//IL_038b: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_044c: Expected I, but got Obj
		//IL_0462: Expected Obj, but got I
		//IL_03b6: Expected I, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_048d: Expected I, but got Obj
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_018f: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I
		//IL_00eb: Expected I, but got Obj
		//IL_01d0: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 20;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 4;
		object obj6 = obj2 + 8;
		obj6 = obj;
		_ = -1;
		string text = (string)0;
		((Direction*)(int)playDirection)->value__ = 4;
		if ((object)anim != null && ((UnityEngine.Object)anim).m_CachedPtr != (IntPtr)0)
		{
			object obj14 = default;
			if (((string)(object)anim).EndsWith("+"))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				int num = default;
				object obj7 = num + 16;
				obj7 = 43;
				string text2 = ((string)(object)anim).Substring(num);
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v136 (Il2CppClass<System.Type>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num3 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v247 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj4 = typeof(UIKeyBinding.Modifier);
				obj3 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj9 = text2 + 16;
				nint num4 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v180 (Il2CppClass<System.Enum>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num5 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v234 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj12 = default;
				object obj11 = obj12;
				object obj13 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj15 = default;
				if (obj13 == obj15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj17 = default;
					object obj16 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj18 = default;
					obj11 = obj18;
				}
			}
			else
			{
				((Direction*)(int)playDirection)->value__ = 4;
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v42 (Il2CppClass<System.Type>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num7 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v117 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj2 = typeof(KeyCode);
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num8 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v82 (Il2CppClass<System.Enum>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num9 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v104 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj21 = default;
				object obj11 = obj21;
				object obj22 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj23 = default;
				if (obj22 == obj23)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj25 = default;
					object obj24 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj26 = default;
					obj11 = obj26;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		return (ActiveAnimation)1;
	}

	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		//IL_0017: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I4
		return (ActiveAnimation)(object)NGUITools.AddSprite((GameObject)(object)anim, (UIAtlas)playDirection, (string)1, 1);
	}

	public static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		//IL_034a: Expected I, but got Obj
		//IL_0360: Expected Obj, but got I
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_01be: Expected I, but got Obj
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_040a: Expected Obj, but got I4
		//IL_00d6: Expected I, but got Obj
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		string fileName = anim.tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v69 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load(fileName);
		if (array == null)
		{
			if (enableBeforePlay != EnableCondition.EnableThenPlay)
			{
				return null;
			}
			string go = anim.tag;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v46 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v60 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.SetActiveChildren((GameObject)(object)go, state: true);
			string text = anim.tag;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S2_v13 (Il2CppMethodInfo)+18]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v7 (should have been resolved before IL gen)");
			object obj7 = 0;
			object obj10 = default;
			while (true)
			{
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v57+C]");
				if ((nint)obj8 >= 0)
				{
					break;
				}
				object obj9 = obj10 + 16;
				object obj11 = obj7 << 2;
				object obj12 = obj9 + obj11;
				((UIPanel)obj12)._002Ector();
				object obj13 = obj7 + 1;
				obj7 = obj13;
			}
		}
		ActiveAnimation component = anim.GetComponent<ActiveAnimation>();
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = component != null;
		bool flag2 = !flag;
		ActiveAnimation activeAnimation = component;
		if (!flag2)
		{
			string text2 = anim.tag;
			ActiveAnimation activeAnimation2 = ((GameObject)(object)text2).AddComponent<ActiveAnimation>();
			activeAnimation = activeAnimation2;
		}
		object obj15 = activeAnimation + 24;
		obj15 = anim;
		activeAnimation.mDisableDirection = (Direction)disableCondition;
		throw new IndexOutOfRangeException();
	}

	public unsafe ActiveAnimation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_014e: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I4
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_096d: Expected I, but got Obj
		//IL_0983: Expected Obj, but got I
		//IL_09ae: Expected I, but got Obj
		//IL_0a01: Expected I, but got Obj
		//IL_0a17: Expected Obj, but got I
		//IL_0d3a: Expected I, but got Obj
		//IL_0d50: Expected Obj, but got I
		//IL_0a42: Expected I, but got Obj
		//IL_0b7c: Expected I, but got Obj
		//IL_0b92: Expected Obj, but got I
		//IL_0a8f: Expected I, but got Obj
		//IL_088a: Expected Obj, but got I
		//IL_0bbd: Expected I, but got Obj
		//IL_0345: Invalid comparison between Obj and F4
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected Obj, but got Unknown
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected Obj, but got Unknown
		//IL_0b34: Expected I4, but got Obj
		//IL_0b2f: Expected native int or pointer, but got Obj
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected Obj, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_07ce: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		float fixedDeltaTime = Time.fixedDeltaTime;
		if (fixedDeltaTime == 0f)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v169 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mAnimator).FindKernel((string)null) != 0)
		{
			float num3 = 0f - fixedDeltaTime;
			float time = ((mLastDirection != Direction.Reverse) ? fixedDeltaTime : num3);
			((AnimationEvent)(object)mAnimator).time = time;
			if (((BMFont)(object)this).isValid)
			{
				return;
			}
			mAnimator.tag = null;
			tag = null;
			if (~(mNotify ? 1u : 0u) != 0)
			{
				return;
			}
			mNotify = false;
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (current != null)
			{
				current = this;
				nint num6 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S1_v39 (Il2CppClass<EventDelegate>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num7 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S1_v58 (Il2CppClass<EventDelegate>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Localization.dictionary = (Dictionary<string, string[]>)(object)onFinished;
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num9 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)eventReceiver).FindKernel((string)null) != 0)
				{
					string text = callWhenFinished;
					if (callWhenFinished != null && text.m_stringLength != 0)
					{
						*(RangeInt*)(nint)eventReceiver = new RangeInt((int)callWhenFinished, 1);
					}
				}
				current = null;
			}
			if (mDisableDirection == Direction.Toggle || mLastDirection != mDisableDirection)
			{
				return;
			}
			string go = tag;
			nint num10 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S1_v28 (Il2CppClass<NGUITools>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num11 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ S1_v33 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.SetActiveChildren((GameObject)(object)go, state: false);
			return;
		}
		nint num12 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v157 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mAnim).FindKernel((string)null) == 0)
		{
			tag = null;
			return;
		}
		int stateCount = mAnim.GetStateCount();
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		object obj14 = default;
		object obj15 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj10 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			float num14 = (float)obj11 * fixedDeltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			float num15 = (float)obj12 + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
			if (num14 < 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
			}
		}
		object obj16 = 49;
		object obj17 = obj16 - 22;
		if ((nint)obj16 != 22 && (nint)obj17 != 1 && (nint)obj17 != 2)
		{
			if ((nint)obj17 != 3 && (nint)obj17 != 4 && (nint)obj17 != 5 && (nint)obj17 != 6)
			{
				if ((nint)obj17 == 7 || (nint)obj17 == 8 || (nint)obj17 == 9)
				{
					goto IL_07d3;
				}
				if ((nint)obj17 != 10 && (nint)obj17 != 11)
				{
					if ((nint)obj17 == 12)
					{
						goto IL_07d3;
					}
					if ((nint)obj17 != 13)
					{
						if ((nint)obj17 == 14)
						{
							goto IL_07d3;
						}
						if ((nint)obj17 != 15 && (nint)obj17 != 16 && (nint)obj17 != 17)
						{
							if ((nint)obj17 == 18 || (nint)obj17 == 19)
							{
								goto IL_07d3;
							}
							if ((nint)obj17 != 20 && (nint)obj17 != 21 && (nint)obj17 != 22 && (nint)obj17 != 23 && (nint)obj17 != 24)
							{
								if ((nint)obj17 == 25 || (nint)obj17 == 26)
								{
									goto IL_07d3;
								}
								if ((nint)obj17 == 27)
								{
									object obj18 = obj2 + 4;
									object obj19 = obj18 + 1;
									obj18 = obj19;
									object obj20 = obj19 << 2;
									object obj21 = obj2 + obj20;
									obj21 = 278;
								}
							}
						}
					}
				}
			}
			goto IL_0deb;
		}
		goto IL_07d3;
		IL_0deb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj22 = default;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj2 + obj23;
			if ((nint)obj24 == 278)
			{
				object obj25 = obj2 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				goto IL_0e12;
			}
		}
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0e12;
		IL_07d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj28 = default;
		object obj29 = default;
		if (obj28 == obj29)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0deb;
		IL_0e12:
		Animation.INTERNAL_CALL_Sample(mAnim);
	}
}
