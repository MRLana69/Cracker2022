using Cpp2ILInjected;
using UnityEngine;

public class UILocalize : MonoBehaviour
{
	public string key;

	private bool mStarted;

	public string value
	{
		set
		{
			//IL_002a: Expected Obj, but got I4
			//IL_000e: Expected Obj, but got I4
			//IL_01f8: Expected I, but got Obj
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Expected Obj, but got Unknown
			object obj;
			if (value != null)
			{
				obj = 0;
				if (value._stringLength != 0)
				{
					goto IL_0232;
				}
			}
			obj = 1;
			goto IL_0232;
			IL_0232:
			if (obj != null)
			{
				return;
			}
			UIWidget component = GetComponent<UIWidget>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			Object obj2 = default;
			if (obj2 != null)
			{
				GameObject go = ((Component)obj2).gameObject;
				UIInput uIInput = NGUITools.FindInParents<UIInput>(go);
				if (uIInput != null && uIInput.label == obj2)
				{
					uIInput.defaultText = value;
				}
				else
				{
					((UILabel)obj2).text = value;
				}
			}
			else
			{
				Object obj3 = default;
				if (!(obj3 != null))
				{
					return;
				}
				GameObject go2 = ((Component)obj3).gameObject;
				UIButton uIButton = NGUITools.FindInParents<UIButton>(go2);
				if (uIButton != null)
				{
					GameObject gameObject = ((Component)obj3).gameObject;
					if (uIButton.tweenTarget == gameObject)
					{
						uIButton.normalSprite = value;
					}
				}
				((UISprite)obj3).spriteName = value;
				nint num = (nint)obj3;
				object obj4 = obj3 + 296;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+1E4] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnEnable()
	{
		if (~(mStarted ? 1u : 0u) == 0)
		{
			OnLocalize();
		}
	}

	private void Start()
	{
		mStarted = true;
		OnLocalize();
	}

	private void OnLocalize()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		object obj = this + 12;
		string text = key;
		object obj2;
		if (key != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_00fc;
			}
		}
		obj2 = 1;
		goto IL_00fc;
		IL_013e:
		object obj3;
		if (obj3 == null)
		{
			string text2 = Localization.Get(key);
			value = text2;
		}
		return;
		IL_00fc:
		if (obj2 != null)
		{
			UILabel component = GetComponent<UILabel>();
			if (component != null)
			{
				obj = component.mText;
			}
		}
		object obj4 = obj;
		if (obj != null)
		{
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v13+8]");
			if ((nint)0 != 0)
			{
				goto IL_013e;
			}
		}
		obj3 = 1;
		goto IL_013e;
	}
}
