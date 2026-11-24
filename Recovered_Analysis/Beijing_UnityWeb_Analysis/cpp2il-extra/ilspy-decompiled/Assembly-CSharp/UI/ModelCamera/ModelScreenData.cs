using System;
using System.Collections;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;
using WordHunt;

namespace UI.ModelCamera;

public class ModelScreenData
{
	private Transform _modelTranform;

	private GameObject _modelGo;

	private CharacterModel characterModel__BackingField;

	private Camera camera__BackingField;

	private Characters.CharacterId characterId__BackingField;

	private int themeVersion__BackingField;

	public unsafe CharacterModel characterModel
	{
		get
		{
			//IL_0103: Expected Obj, but got I4
			//IL_0111: Expected I, but got Obj
			//IL_0127: Expected Obj, but got I
			//IL_01ac: Expected I, but got Obj
			//IL_01c2: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00da: Expected Obj, but got I4
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected Obj, but got Unknown
			WordHuntManager wordHuntManager = (WordHuntManager)0;
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v44 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = wordHuntManager.GetDailyWordOffline();
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v40 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)text < 0)
			{
				text = null;
			}
			else if ((nint)text > 5)
			{
				text = (string)5;
			}
			bool flag = wordHuntManager == null;
			string rigPrefab = text;
			if (!flag)
			{
				string text2 = (string)(text - 1);
				rigPrefab = text2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CharacterModel characterModel = default;
			characterModel._rigPrefab = (GameObject)(object)rigPrefab;
			bool flag2 = wordHuntManager != null;
			((UnityEngine.Object)characterModel).m_CachedPtr = (IntPtr)(flag2 ? 1 : 0);
			return characterModel;
		}
		private set
		{
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected I4, but got Unknown
			//IL_0461: Unknown result type (might be due to invalid IL or missing references)
			//IL_0466: Expected Obj, but got Unknown
			//IL_0471: Expected Obj, but got I4
			//IL_0490: Expected Obj, but got I
			//IL_0010: Expected Obj, but got I4
			//IL_003c: Expected Obj, but got I4
			//IL_0180: Expected I, but got Obj
			//IL_0196: Expected Obj, but got I
			//IL_0083: Expected I, but got Obj
			//IL_0099: Expected Obj, but got I
			//IL_05db: Expected Obj, but got I
			//IL_04c3: Expected I4, but got Obj
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Expected Obj, but got Unknown
			//IL_04f0: Expected I4, but got Obj
			//IL_0336: Expected I, but got Obj
			//IL_0578: Expected Obj, but got I
			//IL_00c4: Expected I, but got Obj
			//IL_01f0: Expected I, but got Obj
			//IL_0544: Expected Obj, but got I4
			object obj = default;
			UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 32);
			object obj2 = obj + 16;
			string tag = ((Component)characterId__BackingField).tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenData)+4C]");
			IEnumerator tag2 = ((CelebrationPopup)null).BoxIdleAnimCoroutine((Transform)0, (CelebrationReward)(object)value._rigPrefab);
			((GameObject)(object)tag).tag = (string)(object)tag2;
			string tag3 = ((Component)themeVersion__BackingField).tag;
			GameObject rigPrefab = value._rigPrefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenData)+4C]");
			bool flag = (object)rigPrefab == null;
			((GameObject)(object)tag3).tag = (string)flag;
			GameObject rigPrefab2 = value._rigPrefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenData)+4C]");
			if ((object)rigPrefab2 == null)
			{
				nint num = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v71 (Il2CppClass<Strings>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v92 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("DAILY_CHALLENGE_TODAY_2");
				((UILabel)(object)_modelGo).fontSize = (int)text;
				object obj4 = this + 32;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v43+8]");
				_ = 0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				((UIWidget)(object)_modelGo).rawPivot = pivot;
				GameObject gameObject = _modelGo;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v91 (UnityEngine.GameObject)+144]");
				if ((nint)0 != 1)
				{
					_ = 1;
					_ = 1;
					_ = 1;
				}
				string tag4 = camera__BackingField.tag;
				bool flag2 = ((UnityEngine.Object)value).m_CachedPtr != (IntPtr)0;
				((GameObject)(object)tag4).tag = (string)flag2;
				return;
			}
			GameObject rigPrefab3 = value._rigPrefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenData)+4C]");
			bool flag3 = (nint)rigPrefab3 < 0;
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v20 (Il2CppClass<Strings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			bool flag4 = obj5 == null;
			if (flag3)
			{
				if (!flag4)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v82 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = Strings.GetDefault("DAILY_CHALLENGE_DAY");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenData)+4C]");
				object obj6 = (nint)0 + (nint)1;
				obj2 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				throw new ArrayTypeMismatchException();
			}
			if (!flag4)
			{
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v52 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text3 = Strings.GetDefault("DAILY_CHALLENGE_DAY");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenData)+4C]");
			object obj7 = (nint)0 + (nint)1;
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
	}

	public Camera camera
	{
		get
		{
			return (Camera)(object)characterModel__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public Characters.CharacterId characterId
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (Characters.CharacterId)camera__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 20;
			obj = value;
		}
	}

	public int themeVersion
	{
		get
		{
			return (int)characterId__BackingField;
		}
		set
		{
			characterId__BackingField = (Characters.CharacterId)value;
		}
	}

	public Transform modelTranform
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (Transform)themeVersion__BackingField;
		}
	}

	public GameObject modelGo => (GameObject)(object)_modelTranform;

	public Transform cameraTransform => (Transform)(object)_modelGo;

	public bool isModelActive
	{
		get
		{
			//IL_000f: Expected I4, but got Obj
			return (byte)(int)camera__BackingField.gameObject != 0;
		}
	}

	public bool isCameraActive
	{
		get
		{
			string tag = _modelTranform.tag;
			return ((GameObject)(object)tag).activeInHierarchy;
		}
	}

	public int cameraLayer
	{
		get
		{
			//IL_009c: Expected I, but got Obj
			//IL_00b2: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)camera__BackingField).FindKernel((string)null) != 0)
			{
				string tag = camera__BackingField.tag;
				return ((GameObject)(object)tag).activeInHierarchy ? 1 : 0;
			}
			return 0;
		}
	}

	public ModelScreenData(GameObject modelGo, Camera camera, Characters.CharacterId characterId, int themeVersion)
	{
		//IL_000f: Expected I4, but got Obj
		//IL_001e: Expected I4, but got Obj
		//IL_0032: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		((UILabel)(object)characterModel__BackingField).fontSize = (int)modelGo;
		((UILabel)(object)_modelGo).fontSize = (int)camera;
		((UILabel)this.characterId__BackingField).fontSize = (int)characterId;
		((UILabel)this.themeVersion__BackingField).fontSize = themeVersion;
	}

	public void Deactivate()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public void Activate()
	{
		string tag = characterModel__BackingField.tag;
		((GameObject)(object)tag).tag = null;
	}

	public void UpdateCharacterDataIfNeeded(Characters.CharacterId charId, int currentlySelectedThemeVersion)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got VT
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got VT
		//IL_009b: Expected I4, but got Obj
		//IL_009b: Expected Obj, but got I
		object obj = this - -64;
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)obj).GetComponentInChildren<T>();
		if (currentlySelectedThemeVersion != 0)
		{
			float alpha = (float)charId / (float)currentlySelectedThemeVersion;
			((UIProgressBar)componentInChildren).alpha = alpha;
		}
		else
		{
			((UIProgressBar)componentInChildren).alpha = 1f;
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = charId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj3 = currentlySelectedThemeVersion;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format = default;
		object arg = default;
		string text = string.Format((IFormatProvider)(object)"{0} / {1}", format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenData)+4C]");
		((UILabel)0).fontSize = (int)text;
	}
}
