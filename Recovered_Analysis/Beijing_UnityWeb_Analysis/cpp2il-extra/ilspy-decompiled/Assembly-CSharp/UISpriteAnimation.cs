using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UISpriteAnimation : MonoBehaviour
{
	public int frameIndex = 0;

	protected int mFPS;

	protected string mPrefix;

	protected bool mLoop;

	protected bool mSnap;

	protected UISprite mSprite;

	protected float mDelta;

	protected bool mActive = true;

	protected List<string> mSpriteNames;

	public int frames
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0019: Expected Obj, but got I4
			//IL_002c: Expected I, but got Obj
			//IL_0042: Expected Obj, but got I
			//IL_0378: Expected Obj, but got I
			//IL_006d: Expected I, but got Obj
			//IL_00bc: Expected Obj, but got I
			//IL_0128: Expected Obj, but got I
			//IL_0128: Expected Obj, but got I
			//IL_0188: Expected Obj, but got I
			//IL_015c: Expected I4, but got Obj
			//IL_01c2: Expected Obj, but got I
			//IL_0204: Expected I4, but got Obj
			//IL_026a: Expected Obj, but got I
			//IL_027c: Expected I4, but got Obj
			//IL_0293: Expected I, but got Obj
			//IL_02a9: Expected Obj, but got I
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Expected Obj, but got Unknown
			//IL_0244: Expected Obj, but got I
			//IL_0254: Expected Obj, but got I
			//IL_02d4: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+19C]");
			if ((nint)0 == 0)
			{
				object obj = this + 408;
				obj = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+198]");
			int result;
			if ((nint)0 == 0)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+18C]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+190]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+190]");
					bool flag;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v20+8]");
						flag = (nint)0 == 0;
					}
					else
					{
						flag = true;
					}
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+18C]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+190]");
						string randomSprite = ((UIAtlas)num3).GetRandomSprite((string)0);
						bool flag2 = randomSprite == null;
						result = 0;
						if (flag2)
						{
							goto IL_03bd;
						}
						framesPerSecond = (int)randomSprite;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+198]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+18C]");
						Texture texture = ((UIAtlas)0).texture;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v28 (UnityEngine.Texture)+C]");
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+18C]");
							Texture texture2 = ((UIAtlas)0).texture;
							UISpriteData uISpriteData = ((List<UISpriteData>)(object)texture2).get_Item(0);
							if (uISpriteData != null)
							{
								framesPerSecond = (int)uISpriteData;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+198]");
								if ((nint)0 != 0)
								{
									object obj4 = this + 400;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+198]");
									object obj5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v35+8]");
									obj4 = 0;
									goto IL_0321;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+18C]");
								UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
								string exception = string.ConcatArray((string[])(object)values, (int)" seems to have a null sprite!");
								nint num4 = (nint)typeof(Debug);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v24 (Il2CppClass<UnityEngine.Debug>)+BA]");
								object obj6 = (nint)0 & (nint)0x200;
								if (obj6 != null)
								{
									nint num5 = (nint)typeof(Debug);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v29 (Il2CppClass<UnityEngine.Debug>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Debug.LogException((Exception)(object)exception);
							}
							result = 0;
							goto IL_03bd;
						}
					}
				}
			}
			goto IL_0321;
			IL_03bd:
			return result;
			IL_0321:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+198]");
			result = 0;
			goto IL_03bd;
		}
	}

	public int framesPerSecond
	{
		get
		{
			List<string> list = mSpriteNames;
			return list._size;
		}
		set
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got I4
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			//IL_0033: Expected Obj, but got I
			//IL_0043: Expected Obj, but got I
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected Obj, but got Unknown
			//IL_00f1: Expected Obj, but got I4
			//IL_0088: Expected Obj, but got I
			//IL_0098: Expected Obj, but got I
			_ = 1;
			_ = 1;
			if (value != 0)
			{
				object obj = this + 408;
				obj = value;
				object obj2 = this + 400;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+198]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v20+8]");
				obj2 = 0;
				return;
			}
			object obj4 = this + 400;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+198]");
			object obj6;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISpriteAnimation)+198]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v14+8]");
				obj6 = 0;
			}
			else
			{
				obj6 = "";
			}
			obj4 = obj6;
			object obj7 = this + 408;
			obj7 = 0;
		}
	}

	public string namePrefix
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)mFPS;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			mFPS = (int)value;
		}
	}

	public bool loop
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)mPrefix != 0;
		}
		set
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected Obj, but got Unknown
			//IL_0043: Expected Obj, but got I4
			if (mPrefix.get_Chars(value ? 1 : 0) != '\0')
			{
				object obj = this + 20;
				obj = value;
				Play();
			}
		}
	}

	public bool isPlaying => mLoop;

	protected virtual void Start()
	{
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		_ = 1;
		nint num = (nint)typeof(UIBasicSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UIBasicSprite>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v12 (Il2CppClass<UIBasicSprite>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UIDrawCall)this).CreateMaterial();
	}

	protected virtual void Update()
	{
		Play();
	}

	public void RebuildSpriteList()
	{
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_00e4: Expected I, but got Obj
		//IL_01cd: Expected I4, but got Obj
		if (~(mActive ? 1u : 0u) != 0)
		{
			return;
		}
		List<string> list = mSpriteNames;
		if (list._size <= 1 || Application.platform == RuntimePlatform.OSXEditor || mFPS <= 0)
		{
			return;
		}
		float fixedDeltaTime = Time.fixedDeltaTime;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v24 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v53 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = ((!(1f < fixedDeltaTime)) ? fixedDeltaTime : 1f);
		float num4 = mDelta + num3;
		mDelta = num4;
		float num5 = 1f / (float)mFPS;
		bool flag = num5 > 0f;
		while (num5 < mDelta)
		{
			float num6 = ((!flag) ? 0f : (mDelta - num5));
			mDelta = num6;
			int num7 = ++frameIndex;
			List<string> list2 = mSpriteNames;
			if (num7 >= list2._size)
			{
				frameIndex = 0;
				bool flag2 = mLoop;
				mActive = flag2;
			}
			if (~(mActive ? 1u : 0u) == 0)
			{
				string text = mSpriteNames.get_Item(frameIndex);
				mSprite.fillCenter = (byte)(int)text != 0;
				if (~(mSnap ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
			}
		}
	}

	public void Play()
	{
		//IL_0260: Expected I, but got Obj
		//IL_0276: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v50 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mSprite != null)
		{
			object obj2 = this + 28;
			UISprite component = GetComponent<UISprite>();
			obj2 = component;
		}
		throw new IndexOutOfRangeException();
	}

	public void Pause()
	{
		mActive = true;
	}

	public void ResetToBeginning()
	{
		mActive = false;
	}

	public UISpriteAnimation()
	{
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mSprite).FindKernel((string)null) == 0)
		{
			return;
		}
		List<string> list = mSpriteNames;
		if (list._size > 0)
		{
			string text = mSpriteNames.get_Item(frameIndex);
			mSprite.fillCenter = (byte)(int)text != 0;
			if (~(mSnap ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}
}
