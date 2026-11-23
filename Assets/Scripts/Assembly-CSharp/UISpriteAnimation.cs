using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UISpriteAnimation : MonoBehaviour
{
	protected int mFPS = 30;

	protected string mPrefix = string.Empty;

	protected bool mLoop = true;

	protected bool mSnap;

	protected UISprite mSprite;

	protected float mDelta;

	protected int mIndex;

	protected bool mActive = true;

	protected List<string> mSpriteNames;

	public int frames
	{
		get
		{
			List<string> list = mSpriteNames;
			return list._size;
		}
	}

	public int framesPerSecond
	{
		get
		{
			return mFPS;
		}
		set
		{
			mFPS = value;
		}
	}

	public string namePrefix
	{
		get
		{
			return mPrefix;
		}
		set
		{
			if (mPrefix != value)
			{
				mPrefix = value;
				RebuildSpriteList();
			}
		}
	}

	public bool loop
	{
		get
		{
			return mLoop;
		}
		set
		{
			mLoop = value;
		}
	}

	public bool isPlaying => mActive;

	protected virtual void Start()
	{
		RebuildSpriteList();
	}

	protected virtual void Update()
	{
		//IL_0192: Expected I, but got Obj
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		if (~(mActive ? 1u : 0u) != 0)
		{
			return;
		}
		List<string> list = mSpriteNames;
		if (list._size < 2 || !Application.isPlaying || mFPS < 1)
		{
			return;
		}
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		float num = (mDelta += unscaledDeltaTime);
		float num2 = 1f / (float)mFPS;
		if (!(num2 < num))
		{
			return;
		}
		float num3 = num - num2;
		if (!(num2 > 0f))
		{
			num3 = 0f;
		}
		mDelta = num3;
		int num4 = ++mIndex;
		List<string> list2 = mSpriteNames;
		bool flag;
		if (num4 < list2._size)
		{
			flag = mActive;
		}
		else
		{
			mIndex = 0;
			mActive = mLoop;
			flag = mLoop;
		}
		if (flag)
		{
			string spriteName = mSpriteNames.get_Item(mIndex);
			mSprite.spriteName = spriteName;
			if (~(mSnap ? 1u : 0u) == 0)
			{
				UISprite uISprite = mSprite;
				nint num5 = (nint)uISprite;
				object obj = uISprite + 296;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v121 @ S1_v25 (Il2CppClass<UISprite>)+1E4] (should have been resolved before IL gen)");
			}
		}
	}

	public void RebuildSpriteList()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		object obj = this + 24;
		if (mSprite == null)
		{
			UISprite component = GetComponent<UISprite>();
			mSprite = component;
		}
		((List<T>)(object)mSpriteNames).Clear();
		if (!(mSprite != null))
		{
			return;
		}
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v25+160]");
		if (!((Object)0 != null))
		{
			return;
		}
		UISprite uISprite = mSprite;
		List<UISpriteData> spriteList = uISprite.mAtlas.spriteList;
		int num = 0;
		while (num < spriteList._size)
		{
			UISpriteData uISpriteData = spriteList.get_Item(num);
			string text = mPrefix;
			object obj3;
			if (mPrefix != null)
			{
				obj3 = 0;
				if (text._stringLength != 0)
				{
					goto IL_01cb;
				}
			}
			obj3 = 1;
			goto IL_01cb;
			IL_01cb:
			if (obj3 != null || uISpriteData.name.StartsWith(mPrefix))
			{
				mSpriteNames.Add(uISpriteData.name);
			}
			int num2 = num + 1;
			num = num2;
		}
		mSpriteNames.Sort();
	}

	public void Play()
	{
		mActive = true;
	}

	public void Pause()
	{
		mActive = false;
	}

	public void ResetToBeginning()
	{
		//IL_0085: Expected I, but got Obj
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		mIndex = 0;
		mActive = true;
		if (!(mSprite != null))
		{
			return;
		}
		List<string> list = mSpriteNames;
		if (list._size >= 1)
		{
			string spriteName = mSpriteNames.get_Item(mIndex);
			mSprite.spriteName = spriteName;
			if (~(mSnap ? 1u : 0u) == 0)
			{
				UISprite uISprite = mSprite;
				nint num = (nint)uISprite;
				object obj = uISprite + 296;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ S1_v11 (Il2CppClass<UISprite>)+1E4] (should have been resolved before IL gen)");
			}
		}
	}

	public UISpriteAnimation()
	{
		List<string> list = default;
		list._002Ector();
		mSpriteNames = list;
		base._002Ector();
	}
}
