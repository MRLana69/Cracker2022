using System;
using Cpp2ILInjected;
using UnityEngine;

public class UI2DSpriteAnimation : MonoBehaviour
{
	protected int framerate = 20;

	public bool ignoreTimeScale = true;

	public bool loop;

	public Sprite[] frames;

	private SpriteRenderer mUnitySprite;

	private UI2DSprite mNguiSprite;

	private int mIndex;

	private float mUpdate;

	public bool isPlaying => enabled;

	public int framesPerSecond
	{
		get
		{
			return framerate;
		}
		set
		{
			framerate = value;
		}
	}

	public void Play()
	{
		//IL_0080: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		Sprite[] array = frames;
		if (frames == null || array.Length == 0)
		{
			return;
		}
		if (!enabled && !loop)
		{
			object obj = mIndex + 1;
			object obj2 = mIndex - 1;
			if (framerate < 1)
			{
				obj = obj2;
			}
			if ((nint)obj >= 0)
			{
				Sprite[] array2 = frames;
				if ((nint)obj < array2.Length)
				{
					goto IL_0142;
				}
			}
			int num;
			if (framerate <= -1)
			{
				Sprite[] array3 = frames;
				num = array3.Length - 1;
			}
			else
			{
				num = 0;
			}
			mIndex = num;
		}
		goto IL_0142;
		IL_0142:
		enabled = true;
		UpdateSprite();
	}

	public void Pause()
	{
		enabled = false;
	}

	public void ResetToBeginning()
	{
		int num;
		if (framerate <= -1)
		{
			Sprite[] array = frames;
			num = array.Length - 1;
		}
		else
		{
			num = 0;
		}
		mIndex = num;
		UpdateSprite();
	}

	private void Start()
	{
		Play();
	}

	private void Update()
	{
		Sprite[] array = frames;
		if (frames == null || array.Length == 0)
		{
			enabled = false;
			return;
		}
		if (framerate == 0)
		{
			return;
		}
		float num = ((~(ignoreTimeScale ? 1u : 0u) != 0) ? Time.time : Time.unscaledTime);
		if (!(num > mUpdate))
		{
			return;
		}
		mUpdate = num;
		int num2 = mIndex + 1;
		int num3 = mIndex - 1;
		if (framerate < 1)
		{
			num2 = num3;
		}
		int max;
		if (~(loop ? 1u : 0u) == 0)
		{
			Sprite[] array2 = frames;
			max = array2.Length;
			goto IL_01a2;
		}
		if (num2 >= 0)
		{
			Sprite[] array3 = frames;
			bool flag = num2 < array3.Length;
			max = array3.Length;
			if (flag)
			{
				goto IL_01a2;
			}
		}
		enabled = false;
		return;
		IL_01a2:
		int num4 = NGUIMath.RepeatIndex(num2, max);
		mIndex = num4;
		UpdateSprite();
	}

	private void UpdateSprite()
	{
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01fc: Expected Obj, but got I
		object obj = this + 24;
		if (mUnitySprite == null && mNguiSprite == null)
		{
			SpriteRenderer component = GetComponent<SpriteRenderer>();
			mUnitySprite = component;
			UI2DSprite component2 = GetComponent<UI2DSprite>();
			mNguiSprite = component2;
			if (mUnitySprite == null && mNguiSprite == null)
			{
				enabled = false;
				return;
			}
		}
		float num = ((~(ignoreTimeScale ? 1u : 0u) != 0) ? Time.time : Time.unscaledTime);
		if (framerate != 0)
		{
			float value = 1f / (float)framerate;
			float num2 = Math.Abs(value);
			float num3 = num + num2;
			mUpdate = num3;
		}
		if ((UnityEngine.Object)obj != null)
		{
			int num4 = mIndex << 2;
			object obj2 = frames + num4;
			SpriteRenderer spriteRenderer = mUnitySprite;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v15+10]");
			spriteRenderer.sprite = (Sprite)0;
		}
		else if (mNguiSprite != null)
		{
			UI2DSprite uI2DSprite = mNguiSprite;
			int num5 = mIndex << 2;
			object obj3 = frames + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v11+10]");
			uI2DSprite.nextSprite = (Sprite)0;
		}
	}
}
