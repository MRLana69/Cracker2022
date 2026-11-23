using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIAtlas : MonoBehaviour
{
	[Serializable]
	private class Sprite
	{
		public string name;

		public Rect outer;

		public Rect inner;

		public bool rotated;

		public float paddingLeft;

		public float paddingRight;

		public float paddingTop;

		public float paddingBottom;

		public bool hasPadding
		{
			get
			{
				bool flag = paddingLeft != 0f;
				bool result = true;
				if (!flag)
				{
					bool flag2 = paddingRight != 0f;
					result = true;
					if (!flag2)
					{
						bool flag3 = paddingTop != 0f;
						result = true;
						if (!flag3)
						{
							bool flag4 = paddingBottom != 0f;
							result = flag4;
						}
					}
				}
				return result;
			}
		}

		public Sprite()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0061: Expected VT, but got I
			//IL_0070: Expected Obj, but got I4
			//IL_008b: Expected Obj, but got F4
			//IL_00a2: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 - 32;
			name = "Unity Bug";
			_ = 0;
			_ = 0;
			_ = 1f;
			_ = 1f;
			_ = 0f;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			outer = (Rect)0;
			_ = 0;
			obj = 0;
			_ = 1f;
			_ = 1f;
			_ = 0f;
			obj = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			inner = (Rect)obj;
		}
	}

	private enum Coordinates
	{
		Pixels,
		TexCoords
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UISpriteData> _003C_003E9__29_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal int _003CSortAlphabetically_003Eb__29_0(UISpriteData s1, UISpriteData s2)
		{
			return s1.name.CompareTo(s2.name);
		}
	}

	private Material material;

	private List<UISpriteData> mSprites;

	private float mPixelSize;

	private UIAtlas mReplacement;

	private Coordinates mCoordinates;

	private List<Sprite> sprites;

	private int mPMA;

	private Dictionary<string, int> mSpriteIndices;

	public Material spriteMaterial
	{
		get
		{
			UIAtlas uIAtlas = default;
			while (uIAtlas.mReplacement != null)
			{
				uIAtlas = mReplacement;
			}
			return uIAtlas.material;
		}
		set
		{
			UIAtlas uIAtlas = default;
			while (uIAtlas.mReplacement != null)
			{
				uIAtlas = mReplacement;
			}
			if (uIAtlas.material == null)
			{
				uIAtlas.material = value;
				uIAtlas.mPMA = 0;
				return;
			}
			uIAtlas.MarkAsChanged();
			uIAtlas.material = value;
			uIAtlas.mPMA = -1;
			uIAtlas.MarkAsChanged();
		}
	}

	public bool premultipliedAlpha
	{
		get
		{
			UIAtlas uIAtlas = default;
			while (uIAtlas.mReplacement != null)
			{
				uIAtlas = mReplacement;
			}
			bool flag = uIAtlas.mPMA == -1;
			bool flag2 = !flag;
			bool flag3 = (byte)uIAtlas.mPMA != 0;
			if (!flag2)
			{
				Material material = uIAtlas.spriteMaterial;
				bool flag4 = material != null;
				bool flag5 = !flag4;
				bool flag6 = false;
				if (!flag5)
				{
					Shader shader = material.shader;
					bool flag7 = shader != null;
					bool flag8 = !flag7;
					flag6 = false;
					if (!flag8)
					{
						Shader shader2 = material.shader;
						string text = shader2.name;
						flag6 = text.Contains("Premultiplied");
					}
				}
				uIAtlas.mPMA = (flag6 ? 1 : 0);
				flag3 = flag6;
			}
			return flag3;
		}
	}

	public List<UISpriteData> spriteList
	{
		get
		{
			UIAtlas uIAtlas = default;
			while (uIAtlas.mReplacement != null)
			{
				uIAtlas = mReplacement;
			}
			List<UISpriteData> list = uIAtlas.mSprites;
			if (list._size == 0)
			{
				bool flag = uIAtlas.Upgrade();
			}
			return uIAtlas.mSprites;
		}
		set
		{
			UIAtlas uIAtlas = default;
			while (uIAtlas.mReplacement != null)
			{
				uIAtlas = mReplacement;
			}
			uIAtlas.mSprites = value;
		}
	}

	public Texture texture
	{
		get
		{
			UIAtlas uIAtlas = default;
			while (uIAtlas.mReplacement != null)
			{
				uIAtlas = mReplacement;
			}
			if (uIAtlas.material != null)
			{
				return uIAtlas.material.mainTexture;
			}
			return null;
		}
	}

	public float pixelSize
	{
		get
		{
			UIAtlas uIAtlas = default;
			while (uIAtlas.mReplacement != null)
			{
				uIAtlas = mReplacement;
			}
			return uIAtlas.mPixelSize;
		}
		set
		{
			UIAtlas uIAtlas = default;
			while (uIAtlas.mReplacement != null)
			{
				uIAtlas = mReplacement;
			}
			float num = Math.Min(value, 4f);
			bool flag = value < 0.25f;
			float num2 = 0.25f;
			if (!flag)
			{
				num2 = num;
			}
			if (num2 != uIAtlas.mPixelSize)
			{
				uIAtlas.mPixelSize = num2;
				uIAtlas.MarkAsChanged();
			}
		}
	}

	public UIAtlas replacement
	{
		get
		{
			return mReplacement;
		}
		set
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected Obj, but got Unknown
			//IL_006e: Expected Obj, but got I
			bool flag = value != this;
			UnityEngine.Object obj = null;
			if (flag)
			{
				obj = value;
			}
			if (!(mReplacement != obj))
			{
				return;
			}
			object obj2 = this + 24;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v4 (UnityEngine.Object)+18]");
				if ((UnityEngine.Object)0 == this)
				{
					((UIAtlas)obj).replacement = null;
				}
			}
			if ((UnityEngine.Object)obj2 != null)
			{
				MarkAsChanged();
			}
			obj2 = obj;
			if (obj != null)
			{
				material = null;
			}
			MarkAsChanged();
		}
	}

	public unsafe UISpriteData GetSprite(string name)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Ref, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Ref, but got Unknown
		//IL_0312: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		UISpriteData result;
		if (mReplacement != null)
		{
			UISpriteData sprite = mReplacement.GetSprite(name);
			result = sprite;
			goto IL_03ad;
		}
		object obj3;
		if (name != null)
		{
			obj3 = 0;
			if (name._stringLength != 0)
			{
				goto IL_03b2;
			}
		}
		obj3 = 1;
		goto IL_03b2;
		IL_03b2:
		result = null;
		if (obj3 == null)
		{
			List<UISpriteData> list = mSprites;
			if (list._size == 0)
			{
				bool flag = Upgrade();
			}
			List<UISpriteData> list2 = mSprites;
			bool flag2 = list2._size == 0;
			result = null;
			if (!flag2)
			{
				List<UISpriteData> list3 = mSprites;
				Dictionary<string, int> dictionary = mSpriteIndices;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v10 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v10 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+18]");
				object obj4 = num - 0;
				if (list3._size != (nint)obj4)
				{
					MarkSpriteListAsChanged();
				}
				if (mSpriteIndices.TryGetValue(name, out *(int*)(obj + 12)))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					if ((nint)0 >= (nint)0)
					{
						List<UISpriteData> list4 = mSprites;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						if ((nint)0 < (nint)list4._size)
						{
							List<UISpriteData> list5 = mSprites;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
							UISpriteData uISpriteData = list5.get_Item(0);
							result = uISpriteData;
							goto IL_03ad;
						}
					}
					MarkSpriteListAsChanged();
					bool flag3 = mSpriteIndices.TryGetValue(name, out *(int*)(obj + 12));
					bool flag4 = !flag3;
					result = null;
					if (!flag4)
					{
						List<UISpriteData> list6 = mSprites;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						UISpriteData uISpriteData2 = list6.get_Item(0);
						result = uISpriteData2;
					}
				}
				else
				{
					List<UISpriteData> list7 = mSprites;
					int num2 = 0;
					while (true)
					{
						UISpriteData uISpriteData3;
						object obj5;
						if (num2 < list7._size)
						{
							uISpriteData3 = mSprites.get_Item(num2);
							string text = uISpriteData3.name;
							if (uISpriteData3.name != null)
							{
								obj5 = 0;
								if (text._stringLength != 0)
								{
									goto IL_03c5;
								}
							}
							obj5 = 1;
							goto IL_03c5;
						}
						result = null;
						break;
						IL_03c5:
						if (obj5 == null && name == uISpriteData3.name)
						{
							MarkSpriteListAsChanged();
							result = uISpriteData3;
							break;
						}
						int num3 = num2 + 1;
						num2 = num3;
					}
				}
			}
		}
		goto IL_03ad;
		IL_03ad:
		return result;
	}

	public string GetRandomSprite(string startsWith)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		string result = default;
		UISpriteData sprite = GetSprite(result);
		if (sprite == null)
		{
			List<UISpriteData> list = spriteList;
			List<string> list2 = default;
			list2._002Ector();
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = default;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			object obj12 = default;
			object obj13 = default;
			string result2 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj6 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj7 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj8 == null)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj9 != obj10;
				object obj11 = obj12;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj11 = obj13;
				}
				_ = 0;
				object obj14 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return result2;
			}
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A36A");
			bool flag2 = list2._size <= 0;
			result = null;
			if (!flag2)
			{
				int index = UnityEngine.Random.Range(0, list2._size);
				string text = list2.get_Item(index);
				result = text;
			}
		}
		return result;
	}

	public void MarkSpriteListAsChanged()
	{
		throw new IndexOutOfRangeException();
	}

	public void SortAlphabetically()
	{
		bool flag = _003C_003Ec._003C_003E9__29_0 == null;
		bool flag2 = !flag;
		Comparison<UISpriteData> comparison = _003C_003Ec._003C_003E9__29_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		mSprites.Sort(comparison);
	}

	public BetterList<string> GetListOfSprites()
	{
		//IL_0102: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		UIAtlas uIAtlas = default;
		while (uIAtlas.mReplacement != null)
		{
			uIAtlas = mReplacement;
		}
		List<UISpriteData> list = uIAtlas.mSprites;
		if (list._size == 0)
		{
			bool flag = uIAtlas.Upgrade();
		}
		List<UISpriteData> list2 = uIAtlas.mSprites;
		int num2;
		BetterList<string> betterList = default;
		for (int num = 0; num < list2._size; num2 = num + 1, num = num2)
		{
			UISpriteData uISpriteData = uIAtlas.mSprites.get_Item(num);
			if (uISpriteData == null)
			{
				continue;
			}
			string text = uISpriteData.name;
			object obj;
			if (uISpriteData.name != null)
			{
				obj = 0;
				if (text._stringLength != 0)
				{
					goto IL_016a;
				}
			}
			obj = 1;
			goto IL_016a;
			IL_016a:
			if (obj == null)
			{
				betterList.Add(uISpriteData.name);
			}
		}
		return betterList;
	}

	public BetterList<string> GetListOfSprites(string match)
	{
		//IL_0056: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I4
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_0397: Expected Obj, but got I
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		UIAtlas uIAtlas = default;
		while ((bool)uIAtlas.mReplacement)
		{
			uIAtlas = mReplacement;
		}
		object obj;
		string text = default;
		if (text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_0439;
			}
		}
		obj = 1;
		goto IL_0439;
		IL_0439:
		if (obj != null)
		{
			return uIAtlas.GetListOfSprites();
		}
		List<UISpriteData> list = uIAtlas.mSprites;
		if (list._size == 0)
		{
			bool flag = uIAtlas.Upgrade();
		}
		List<UISpriteData> list2 = uIAtlas.mSprites;
		int num2;
		BetterList<string> betterList = default;
		for (int num = 0; num < list2._size; num2 = num + 1, num = num2)
		{
			UISpriteData uISpriteData = uIAtlas.mSprites.get_Item(num);
			if (uISpriteData == null)
			{
				continue;
			}
			string text2 = uISpriteData.name;
			object obj2;
			if (uISpriteData.name != null)
			{
				obj2 = 0;
				if (text2._stringLength != 0)
				{
					goto IL_0456;
				}
			}
			obj2 = 1;
			goto IL_0456;
			IL_0456:
			if (obj2 == null && string.Equals(text, uISpriteData.name, StringComparison.OrdinalIgnoreCase))
			{
				betterList.Add(uISpriteData.name);
				return betterList;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		char[] array = default;
		array[0] = ' ';
		string[] array2 = text.Split(array, StringSplitOptions.RemoveEmptyEntries);
		object obj3 = 0;
		if (array2.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)array2 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v32+10]");
			string text3 = ((string)0).ToLower();
			throw new ArrayTypeMismatchException();
		}
		List<UISpriteData> list3 = uIAtlas.mSprites;
		int num4;
		for (int num3 = 0; num3 < list3._size; num4 = num3 + 1, num3 = num4)
		{
			UISpriteData uISpriteData2 = uIAtlas.mSprites.get_Item(num3);
			if (uISpriteData2 == null)
			{
				continue;
			}
			string text4 = uISpriteData2.name;
			object obj6;
			if (uISpriteData2.name != null)
			{
				obj6 = 0;
				if (text4._stringLength != 0)
				{
					goto IL_04b9;
				}
			}
			obj6 = 1;
			goto IL_04b9;
			IL_04b9:
			text = uISpriteData2.name;
			if (obj6 != null)
			{
				continue;
			}
			string text5 = uISpriteData2.name.ToLower();
			text = null;
			obj3 = 0;
			while (array2.Length > (nint)obj3)
			{
				string text6 = text + 1;
				object obj7 = obj3 << 2;
				object obj8 = (object)array2 + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S3_v8+10]");
				if (!text5.Contains((string)0))
				{
					text6 = text;
				}
				object obj9 = obj3 + 1;
				text = text6;
				obj3 = obj9;
			}
			if ((nint)text == array2.Length)
			{
				betterList.Add(uISpriteData2.name);
			}
		}
		return betterList;
	}

	private bool References(UIAtlas atlas)
	{
		bool result;
		UIAtlas uIAtlas = default;
		while (true)
		{
			bool flag = atlas != null;
			result = false;
			if (flag)
			{
				if (atlas == mReplacement)
				{
					result = true;
					break;
				}
				bool flag2 = uIAtlas.mReplacement != null;
				bool flag3 = !flag2;
				result = false;
				if (flag3)
				{
					break;
				}
				uIAtlas = mReplacement;
				continue;
			}
			break;
		}
		return result;
	}

	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		bool flag = a != null;
		bool result = false;
		if (flag)
		{
			bool flag2 = b != null;
			result = false;
			if (flag2)
			{
				bool flag3 = a != b;
				result = true;
				if (flag3)
				{
					bool flag4 = a.References(b);
					result = true;
					if (!flag4)
					{
						bool flag5 = b.References(a);
						result = flag5;
					}
				}
			}
		}
		return result;
	}

	public void MarkAsChanged()
	{
		//IL_002c: Expected Obj, but got I4
		//IL_00d3: Expected VT, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_020a: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		if (mReplacement != null)
		{
			mReplacement.MarkAsChanged();
		}
		_0021_00210[] array = (_0021_00210[])(object)NGUITools.FindActive<T>();
		object obj = 0;
		while ((nint)obj < array.Length)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v34+10]");
			UISprite uISprite = (UISprite)0;
			if (CheckIfRelated(this, uISprite.mAtlas))
			{
				uISprite.atlas = null;
				uISprite.atlas = uISprite.mAtlas;
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(UIFont));
		UnityEngine.Object[] array2 = Resources.FindObjectsOfTypeAll(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj5 = 0;
		object obj9 = default;
		while (true)
		{
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v29+C]");
			if ((nint)obj6 >= 0)
			{
				break;
			}
			object obj7 = obj5 << 2;
			object obj8 = obj9 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v25+10]");
			UIAtlas atlas = ((UIFont)0).atlas;
			if (CheckIfRelated(this, atlas))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v25+10]");
				UIAtlas atlas2 = ((UIFont)0).atlas;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v25+10]");
				((UIFont)0).atlas = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v25+10]");
				((UIFont)0).atlas = atlas2;
			}
			object obj10 = obj5 + 1;
			obj5 = obj10;
		}
		_0021_00210[] array3 = (_0021_00210[])(object)NGUITools.FindActive<T>();
		object obj11 = 0;
		while ((nint)obj11 < array3.Length)
		{
			object obj12 = obj11 << 2;
			object obj13 = (object)array3 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v46+10]");
			UILabel uILabel = (UILabel)0;
			if (uILabel.mFont != null)
			{
				UIAtlas atlas3 = uILabel.mFont.atlas;
				if (CheckIfRelated(this, atlas3))
				{
					uILabel.bitmapFont = null;
					uILabel.bitmapFont = uILabel.mFont;
				}
			}
			object obj14 = obj11 + 1;
			obj11 = obj14;
		}
	}

	private unsafe bool Upgrade()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0104: Expected I, but got Obj
		//IL_0123: Expected I, but got Obj
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected VT, but got Unknown
		//IL_01fc: Expected F4, but got I
		//IL_01f7: Expected native int or pointer, but got VT
		//IL_0211: Expected F4, but got I
		//IL_020c: Expected native int or pointer, but got VT
		//IL_029f: Expected F8, but got I4
		//IL_0610: Expected I4, but got F8
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected Obj, but got Unknown
		//IL_02de: Expected F8, but got I4
		//IL_0630: Expected I4, but got F8
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected Obj, but got Unknown
		//IL_031d: Expected F8, but got I4
		//IL_0650: Expected I4, but got F8
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got Unknown
		//IL_035c: Expected F8, but got I4
		//IL_0670: Expected I4, but got F8
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected Obj, but got Unknown
		//IL_039b: Expected F8, but got I4
		//IL_06ac: Expected I4, but got F8
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_03da: Expected F8, but got I4
		//IL_06e8: Expected I4, but got F8
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected Obj, but got Unknown
		//IL_0419: Expected F8, but got I4
		//IL_0724: Expected I4, but got F8
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected Obj, but got Unknown
		//IL_0458: Expected F8, but got I4
		//IL_0760: Expected I4, but got F8
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_0497: Expected F8, but got I4
		//IL_0795: Expected I4, but got F8
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected Obj, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got Unknown
		//IL_07d5: Expected Obj, but got I
		//IL_04d6: Expected F8, but got I4
		//IL_07f4: Expected I4, but got F8
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_081f: Expected Obj, but got I
		//IL_083c: Expected Obj, but got I
		//IL_0515: Expected F8, but got I4
		//IL_085b: Expected I4, but got F8
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected Obj, but got Unknown
		//IL_0886: Expected Obj, but got I
		//IL_0554: Expected F8, but got I4
		//IL_0898: Expected I4, but got F8
		object obj = default;
		Rect rect = (Rect)(obj - 80);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool result;
		if ((bool)mReplacement)
		{
			result = mReplacement.Upgrade();
		}
		else
		{
			List<UISpriteData> list = mSprites;
			result = false;
			if (list._size == 0)
			{
				List<Sprite> list2 = sprites;
				bool flag = list2._size < 1;
				result = false;
				if (!flag)
				{
					bool flag2 = material;
					bool flag3 = !flag2;
					result = false;
					if (!flag3)
					{
						Texture mainTexture = material.mainTexture;
						bool flag4 = mainTexture != null;
						bool flag5 = !flag4;
						int width = 512;
						if (!flag5)
						{
							nint num = (nint)mainTexture;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ S1_v202 (Il2CppClass<UnityEngine.Texture>)+DC] (should have been resolved before IL gen)");
							int num2 = default;
							width = num2;
						}
						bool flag6 = mainTexture != null;
						bool flag7 = !flag6;
						int height = 512;
						if (!flag7)
						{
							nint num3 = (nint)mainTexture;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ S1_v199 (Il2CppClass<UnityEngine.Texture>)+EC] (should have been resolved before IL gen)");
							int num4 = default;
							height = num4;
						}
						int num5 = default;
						UISpriteData uISpriteData = default;
						double num7 = default;
						double num9 = default;
						double num11 = default;
						double num13 = default;
						double num17 = default;
						double num21 = default;
						double num25 = default;
						double num29 = default;
						double num31 = default;
						double num34 = default;
						double num38 = default;
						double num41 = default;
						int num42 = default;
						while (true)
						{
							List<Sprite> list3 = sprites;
							if (list3._size <= num5)
							{
								break;
							}
							Sprite sprite = sprites.get_Item(num5);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v58 (UIAtlas+Sprite)+14]");
							_ = 0;
							_ = sprite.outer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v58 (UIAtlas+Sprite)+24]");
							_ = 0;
							_ = sprite.inner;
							if (mCoordinates == Coordinates.TexCoords)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
								_ = 0;
								Rect rect2 = (Rect)(rect + 16);
								Rect rect3 = NGUIMath.ConvertToPixels(rect2, width, height, round: true);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
								((Rect*)(nint)rect)->m_Width = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
								((Rect*)(nint)rect)->m_XMin = 0f;
								Rect rect4 = NGUIMath.ConvertToPixels(rect, width, height, round: true);
							}
							uISpriteData._002Ector();
							uISpriteData.name = sprite.name;
							object obj2 = rect - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num6 = Math.Abs(num7);
							if (!(num6 < 2147483648.0))
							{
								num7 = -2147483648.0;
							}
							uISpriteData.x = (int)num7;
							object obj3 = rect - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num8 = Math.Abs(num9);
							if (!(num8 < 2147483648.0))
							{
								num9 = -2147483648.0;
							}
							uISpriteData.y = (int)num9;
							object obj4 = rect - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num10 = Math.Abs(num11);
							if (!(num10 < 2147483648.0))
							{
								num11 = -2147483648.0;
							}
							uISpriteData.width = (int)num11;
							object obj5 = rect - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num12 = Math.Abs(num13);
							if (!(num12 < 2147483648.0))
							{
								num13 = -2147483648.0;
							}
							uISpriteData.height = (int)num13;
							object obj6 = rect - -64;
							float num14 = sprite.paddingLeft;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S1_v70+8]");
							float num15 = num14 * 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num16 = Math.Abs(num17);
							if (!(num16 < 2147483648.0))
							{
								num17 = -2147483648.0;
							}
							uISpriteData.paddingLeft = (int)num17;
							object obj7 = rect - -64;
							float num18 = sprite.paddingRight;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S1_v79+8]");
							float num19 = num18 * 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num20 = Math.Abs(num21);
							if (!(num20 < 2147483648.0))
							{
								num21 = -2147483648.0;
							}
							uISpriteData.paddingRight = (int)num21;
							object obj8 = rect - -64;
							float num22 = sprite.paddingBottom;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S1_v88+C]");
							float num23 = num22 * 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num24 = Math.Abs(num25);
							if (!(num24 < 2147483648.0))
							{
								num25 = -2147483648.0;
							}
							uISpriteData.paddingBottom = (int)num25;
							object obj9 = rect - -64;
							float num26 = sprite.paddingTop;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S1_v97+C]");
							float num27 = num26 * 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num28 = Math.Abs(num29);
							if (!(num28 < 2147483648.0))
							{
								num29 = -2147483648.0;
							}
							uISpriteData.paddingTop = (int)num29;
							object obj10 = rect - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
							object obj11 = 0 - obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num30 = Math.Abs(num31);
							if (!(num30 < 2147483648.0))
							{
								num31 = -2147483648.0;
							}
							uISpriteData.borderLeft = (int)num31;
							object obj12 = rect - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ S0_v163+8]");
							object obj13 = 0 + obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
							nint num32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
							object obj14 = num32 + 0;
							object obj15 = obj13 - obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num33 = Math.Abs(num34);
							if (!(num33 < 2147483648.0))
							{
								num34 = -2147483648.0;
							}
							uISpriteData.borderRight = (int)num34;
							object obj16 = rect - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v175+C]");
							nint num35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v175+4]");
							object obj17 = num35 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+3C]");
							nint num36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
							object obj18 = num36 + 0;
							object obj19 = obj17 - obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num37 = Math.Abs(num38);
							if (!(num37 < 2147483648.0))
							{
								num38 = -2147483648.0;
							}
							uISpriteData.borderBottom = (int)num38;
							object obj20 = rect - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
							nint num39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S1_v139+4]");
							object obj21 = num39 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num40 = Math.Abs(num41);
							if (!(num40 < 2147483648.0))
							{
								num41 = -2147483648.0;
							}
							uISpriteData.borderTop = (int)num41;
							mSprites.Add(uISpriteData);
							num5 = num42 + 1;
						}
						((List<T>)(object)sprites).Clear();
						result = true;
					}
				}
			}
		}
		return result;
	}

	public UIAtlas()
	{
		List<UISpriteData> list = default;
		list._002Ector();
		mSprites = list;
		mPixelSize = 1f;
		List<Sprite> list2 = default;
		list2._002Ector();
		sprites = list2;
		mPMA = -1;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, int> dictionary = default;
		mSpriteIndices = dictionary;
		base._002Ector();
	}
}
