using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

namespace UI.Screens.CharacterScreenInternal;

public class CharacterModelRequest
{
	public enum RequestState
	{
		None,
		RequestingBundles,
		BuildingCharacter,
		Finished,
		Cancelled
	}

	public class CharacterBundleRequest
	{
		public readonly Characters.CharacterId characterId;

		public readonly int Theme;

		public readonly string[] AssetBundleNames;

		private int _loadedBundleCount;

		private List<CharacterModelRequest> _requests;

		public CharacterBundleRequest(Characters.CharacterId characterId, int theme)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			//IL_006c: Expected Obj, but got I4
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = this + 16;
			obj6 = theme;
		}

		public void RegisterModelRequest(CharacterModelRequest modelRequest)
		{
			//IL_000a: Expected I4, but got Obj
			characterId = (Characters.CharacterId)modelRequest;
		}

		public bool RemoveModelRequest(CharacterModelRequest modelRequest)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a7: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v2 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v6 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int[] values = (int[])(modelRequest._characterId - Theme);
			return (byte)Mathf.Min(values) != 0;
		}

		public int GetPriority()
		{
			return Theme;
		}

		public void OnBundleLoaded(AssetBundle bundle)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		}
	}

	private const string CHARACTER_MODEL_REQUEST_DEBUG_LOG_TAG = "CharacterModelRequest: ";

	private readonly CharacterListManager _listManager;

	private readonly Characters.CharacterId _characterId;

	private readonly int _theme;

	private readonly int _scrollIndex;

	private readonly bool _synchronous;

	private RequestState _state;

	private int _priority;

	public Characters.CharacterId characterId => (Characters.CharacterId)((Array)(object)_listManager).InternalArray__ICollection_get_Count();

	public RequestState State => (RequestState)_characterId;

	public unsafe CharacterModelRequest(Characters.CharacterId charId, int theme, int scrollIndex, CharacterListManager listManager, bool synchronous = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_0670: Expected I, but got Obj
		//IL_0686: Expected Obj, but got I
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected VT, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_00d3: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_0029: Expected I, but got Obj
		//IL_0075: Expected F4, but got I4
		//IL_0070: Expected native int or pointer, but got VT
		//IL_0114: Expected I, but got Obj
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		//IL_0186: Expected Obj, but got I
		//IL_01b1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		obj = charId;
		CharacterScrollListSlot characterScrollListSlot = ((CharacterListManager)this).get_Item((Characters.CharacterId)scrollIndex);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v157 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 52);
		object obj4 = obj2 + 36;
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 12;
		if ((UnityEngine.Object)(object)listManager != null)
		{
			((Vector3*)(nint)vector)->x = (float)charId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string text = "Error loading model. Model for character " + text2 + " is null.";
			((CharacterModelRequest)(object)text).SetPriority(0);
			object obj7 = characterScrollListSlot + 32;
			obj7 = 0;
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v144 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (characterScrollListSlot != null)
		{
			((CharacterModelRequest)(object)"Error loading model. The character slot is  null.").SetPriority(0);
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v135 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v140 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)listManager);
			return;
		}
		if (characterScrollListSlot.characterId != charId)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public void SetPriority(int priority)
	{
		//IL_0010: Expected I4, but got Obj
		//IL_0021: Expected Obj, but got I4
		string msg = string.ConcatArray((string[])(object)"Character List manager: ", (int)this);
		SDebug.LogFormat(msg, (object[])priority);
	}

	public void CancelRequest()
	{
		_scrollIndex = 1;
		int theme = _theme;
		_ = 1;
	}

	private void OnCharacterBundlesLoaded()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		_state = RequestState.Cancelled;
		nint num = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v13 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string assetBundlesCachePath = AssetBundleManager.GetAssetBundlesCachePath();
		((AssetBundleManager)(object)assetBundlesCachePath).CharacterBundleRequestCompleted((CharacterBundleRequest)(object)this);
	}

	private void HandleCompletedRequest(GameObject characterModel)
	{
		//IL_000a: Expected I4, but got Obj
		_priority = (int)characterModel;
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_00ea: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+1C]");
		if ((nint)0 == 4)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(context);
		}
		else
		{
			_ = 3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+18]");
			bool synchronous = (nint)0 != 0;
			int stringLength = msg.m_stringLength;
			char firstChar = msg.m_firstChar;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+10]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+14]");
			((CharacterModelRequest)stringLength)._002Ector((Characters.CharacterId)firstChar, (int)num3, 0, (CharacterListManager)(object)context, synchronous);
		}
	}
}
