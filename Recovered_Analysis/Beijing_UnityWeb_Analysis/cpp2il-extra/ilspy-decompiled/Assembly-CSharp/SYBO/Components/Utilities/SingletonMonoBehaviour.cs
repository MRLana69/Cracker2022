using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using SYBO.Components.Native;
using UnityEngine;
using UnityEngine.Experimental.Playables;
using UnityEngine.Playables;

namespace SYBO.Components.Utilities;

public abstract class SingletonMonoBehaviour : MonoBehaviour
{
	public static string LogCategoryName;

	private bool IsDestroyed__BackingField;

	public int ID
	{
		get
		{
			//IL_008d: Expected I, but got Obj
			//IL_00a3: Expected Obj, but got I
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected I4, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<System.Type>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(IsDestroyed__BackingField ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				int result = default;
				return result;
			}
			object obj2 = (object)this >> 2;
			return obj2 * -1640531535;
		}
	}

	public bool IsDestroyed
	{
		get
		{
			//IL_0025: Expected Obj, but got I4
			string text = tag;
			int layer = ((GameObject)(object)text).layer;
			return (byte)((UnityEngine.Object)layer).GetHashCode() != 0;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 12;
			obj = value;
		}
	}

	public virtual bool IsSavedInHierarchy
	{
		get
		{
			return IsDestroyed__BackingField;
		}
		set
		{
			IsDestroyed__BackingField = value;
		}
	}

	public static bool IsShuttingDown => false;

	public abstract SingletonMonoBehaviour GetInstance();

	public static GameObject InstantiateGameObjectFromPath(string path)
	{
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		string text = ((Component)(object)path).tag;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)text != null)
		{
			return null;
		}
		string type = ((Component)(object)path).tag;
		UnityEngine.Object obj2 = UnityEngine.Object.FindObjectOfType((Type)(object)type);
		object obj3 = obj2 & 0x3D;
		bool flag = (nint)obj3 != 61;
		return (GameObject)flag;
	}

	public static void LogFormat(int level, string format, object[] args)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		NormalizationForm normalizationForm = default;
		object obj = normalizationForm + 16;
		obj = 47;
		object obj2 = level + 8;
		string text = format.Normalize(normalizationForm);
		obj2 = text;
		object obj3 = level + 12;
		obj3 = args;
	}

	public static void LogWarningFormat(string format, object[] args)
	{
		//IL_0045: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		string text = ((Component)(object)format).tag;
		if (args != null)
		{
			UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType((Type)(object)text);
			string message = (string)(obj & -62);
			UnityEngine.Object.CheckNullArgument((object)text, message);
		}
		else
		{
			UnityEngine.Object.CheckNullArgument((object)text, (string)61);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = default;
		object obj2 = obj3 + 4;
		object obj4 = args & 1;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	public unsafe static void LogErrorFormat(string format, object[] args)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PlayableHandle handle = ((CameraPlayable*)args)->GetHandle();
	}

	protected SingletonMonoBehaviour()
	{
		//IL_009b: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(IsDestroyed__BackingField ? 1u : 0u) == 0)
		{
			object obj2 = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj3 = default;
			obj2 = obj3;
		}
		else
		{
			object obj4 = this + 8;
			obj4 = 0;
		}
	}
}
public abstract class SingletonMonoBehaviour<T> : SingletonMonoBehaviour where T : SingletonMonoBehaviour<T>
{
	private bool _isSingletonInitialized;

	private bool _isSingletonInitializing;

	private static PrefabPathAttribute _attribute;

	private static T _instance;

	internal bool IsInitialized
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected Obj, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x1FFF;
			object obj4 = obj3 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S3_v4 (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got I4
			//IL_0032: Expected Obj, but got I
			//IL_0042: Expected Obj, but got I
			//IL_0052: Expected Obj, but got I
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6+4]");
			object obj4 = 0;
			object obj6 = default;
			object obj5 = obj6 + 16;
			obj5 = this;
			object obj7 = this + 12;
			obj7 = obj6;
		}
	}

	public static T Instance
	{
		get
		{
			//IL_02d4: Expected Obj, but got I
			//IL_02ee: Expected Obj, but got I
			//IL_0308: Expected Obj, but got I
			//IL_0316: Expected I, but got Obj
			//IL_032c: Expected Obj, but got I
			//IL_038a: Expected Obj, but got I
			//IL_03a4: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006c: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I
			//IL_009b: Expected Obj, but got I
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected Obj, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			//IL_00db: Expected Obj, but got I
			//IL_00eb: Expected Obj, but got I
			//IL_010a: Expected Obj, but got I
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected Obj, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected Obj, but got Unknown
			//IL_014a: Expected Obj, but got I
			//IL_0169: Expected Obj, but got I
			//IL_018b: Expected Obj, but got I
			//IL_01aa: Expected Obj, but got I
			//IL_01b8: Expected I, but got Obj
			//IL_01ce: Expected Obj, but got I
			//IL_01f9: Expected I, but got Obj
			//IL_0246: Expected I, but got Obj
			//IL_025c: Expected Obj, but got I
			//IL_0287: Expected I, but got Obj
			nint num = default;
			object obj = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+5C]");
			object obj3 = 0;
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v26+60]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v27+C]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v32+60]");
				object obj7 = 0;
				object obj8 = obj6 & 0xFFF;
				object obj9 = obj8 + 1797;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v84 @ S1_v12 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v15+60]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v16+10]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v21+60]");
				object obj12 = 0;
				object obj13 = obj11 & 0x3FFF;
				object obj14 = obj13 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v102 @ S2_v8 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v39+60]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v42+5C]");
				object obj16 = 0;
				object obj17 = default;
				obj16 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v46+60]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v49+5C]");
				object obj19 = 0;
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((UnityEngine.Object)obj19 != null)
				{
					nint num6 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v54 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num7 = (nint)typeof(Log);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v61 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Log.Utilities.LogException((Exception)(object)"Unable to find AssetLoader object, this should never happen. It should have been generated editor-time.");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v18+60]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v21+5C]");
			return (T)0;
		}
		protected set
		{
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected Obj, but got Unknown
			//IL_00e7: Expected Obj, but got I
			//IL_0105: Expected Obj, but got I
			//IL_0131: Expected Obj, but got I
			//IL_0141: Expected Obj, but got I
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected Obj, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected Obj, but got Unknown
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Expected Obj, but got Unknown
			//IL_0195: Expected Obj, but got I
			//IL_0027: Expected Obj, but got I
			//IL_0037: Expected Obj, but got I
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected Obj, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected Obj, but got Unknown
			//IL_008b: Expected Obj, but got I
			//IL_009b: Expected Obj, but got I
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected Obj, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			object obj = value + 48;
			obj = "There are {0} keys and {1} values after deserialization. Make surethat both key and value types are serializable.";
			nint num = default;
			object obj2 = num + 12;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+60]");
			object obj4 = -(-64);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v8+60]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9+44]");
			object obj7 = 0;
			object obj8 = obj7 & 0x3FFF;
			object obj9 = obj8 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S2_v4 (should have been resolved before IL gen)");
			object obj10 = value + 52;
			object obj11 = default;
			obj10 = obj11;
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v14+60]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v15+4C]");
			object obj16 = 0;
			object obj17 = obj16 & 0x3FFF;
			object obj18 = obj17 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v63 @ S2_v8 (should have been resolved before IL gen)");
			object obj19 = value + 56;
			object obj20 = default;
			obj19 = obj20;
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v20+60]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v21+50]");
			object obj23 = 0;
			object obj24 = obj23 & 0x3FFF;
			object obj25 = obj24 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v80 @ S2_v12 (should have been resolved before IL gen)");
		}
	}

	public override SingletonMonoBehaviour GetInstance()
	{
		//IL_001f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.SingletonMonoBehaviour`1<T>)+D]");
		bool flag = (nint)0 != 0;
		return (SingletonMonoBehaviour)flag;
	}

	public unsafe static T Instantiate()
	{
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f30: Expected I, but got Unknown
		//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected Obj, but got Unknown
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4c: Expected Obj, but got Unknown
		//IL_0f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5a: Expected Obj, but got Unknown
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected Obj, but got Unknown
		//IL_0f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f76: Expected Obj, but got Unknown
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Expected Obj, but got Unknown
		//IL_0f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Expected Obj, but got Unknown
		//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Expected Obj, but got Unknown
		//IL_0fa9: Expected Obj, but got I4
		//IL_0fb7: Expected Obj, but got I
		//IL_0fd1: Expected Obj, but got I
		//IL_0fe1: Expected Obj, but got I
		//IL_0ffb: Expected Obj, but got I
		//IL_1004: Unknown result type (might be due to invalid IL or missing references)
		//IL_1009: Expected Obj, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_025f: Expected Obj, but got I
		//IL_1111: Expected Obj, but got I
		//IL_112b: Expected Obj, but got I
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Expected Obj, but got Unknown
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_1147: Expected Obj, but got Unknown
		//IL_116b: Expected Obj, but got I
		//IL_002e: Expected Obj, but got I
		//IL_003c: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_082e: Expected Obj, but got I
		//IL_0850: Expected Obj, but got I
		//IL_0295: Expected I, but got Obj
		//IL_02ab: Expected Obj, but got I
		//IL_104e: Expected Obj, but got I
		//IL_105b: Expected I, but got Obj
		//IL_086f: Expected Obj, but got I
		//IL_0885: Expected I, but got Obj
		//IL_089b: Expected Obj, but got I
		//IL_118a: Expected Obj, but got I
		//IL_1197: Expected I, but got Obj
		//IL_007d: Expected I, but got Obj
		//IL_137e: Expected Obj, but got I
		//IL_1390: Expected I, but got Obj
		//IL_13a6: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I
		//IL_034c: Expected I, but got Obj
		//IL_02d6: Expected I, but got Obj
		//IL_08c6: Expected I, but got Obj
		//IL_0acf: Expected Obj, but got I
		//IL_0913: Expected I, but got Obj
		//IL_0aee: Expected Obj, but got I
		//IL_0afc: Expected I, but got Obj
		//IL_0b12: Expected Obj, but got I
		//IL_1472: Expected Obj, but got I
		//IL_097b: Expected Obj, but got I
		//IL_0989: Expected I, but got Obj
		//IL_099f: Expected Obj, but got I
		//IL_0b8c: Expected Obj, but got I
		//IL_0b9a: Expected I, but got Obj
		//IL_0bb0: Expected Obj, but got I
		//IL_0b3d: Expected I, but got Obj
		//IL_13fa: Expected Obj, but got I
		//IL_1407: Expected I, but got Obj
		//IL_09ca: Expected I, but got Obj
		//IL_1515: Expected Obj, but got I
		//IL_1522: Expected I, but got Obj
		//IL_0d27: Expected I, but got Obj
		//IL_149f: Expected Obj, but got I
		//IL_14ac: Expected I, but got Obj
		//IL_0c0a: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 36);
		object obj2 = obj + 32;
		object obj3 = obj + 28;
		object obj4 = obj + 24;
		object obj5 = obj + 20;
		object obj6 = obj + 16;
		object obj7 = obj + 12;
		object obj8 = obj + 4;
		object obj9 = obj + 8;
		obj9 = 0;
		nint num2 = default;
		object obj10 = num2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v29+60]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v30+30]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v35+60]");
		object obj13 = 0;
		object obj14 = obj12 & 0xFFF;
		object obj15 = obj14 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v74 @ S1_v16 (should have been resolved before IL gen)");
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v309+60]");
			object obj17 = 0;
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v313 (Il2CppClass<System.Type>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v349 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v310+3C]");
			obj = 0;
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type type = Type.internal_from_handle((IntPtr)num);
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v42+60]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v43+34]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v48+60]");
		object obj21 = 0;
		object obj22 = obj20 & 0xFFF;
		object obj23 = obj22 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v21 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v24+60]");
		object obj24 = 0;
		object obj25 = default;
		if (obj25 == null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v213 (Il2CppClass<System.Type>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v300 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v25+3C]");
			obj5 = 0;
			((IntPtr*)num)->m_value = (void*)(nint)obj5;
			Type pathA = Type.internal_from_handle((IntPtr)num);
			string text = FileUtility.CombinePaths((string)(object)pathA, "Construct", fixSlashesToMatchSystem: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S2_v28+60]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S2_v29+3C]");
			obj6 = 0;
			((IntPtr*)num)->m_value = (void*)(nint)obj6;
			Type type2 = Type.internal_from_handle((IntPtr)num);
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v25+38]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v58+60]");
		object obj29 = 0;
		object obj30 = obj28 & 0xFFF;
		object obj31 = obj30 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S1_v28 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v64+60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v67+5C]");
		object obj33 = 0;
		object obj34 = default;
		obj33 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v71+60]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v74+5C]");
		object obj36 = 0;
		object obj37 = obj36;
		nint num7 = (nint)typeof(SingletonMonoBehaviour);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v79 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+BA]");
		object obj38 = (nint)0 & (nint)0x200;
		if (obj38 != null)
		{
			nint num8 = (nint)typeof(SingletonMonoBehaviour);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v206 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v76+8]");
		string path = ((PrefabPathAttribute)0).Path;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj39 = (nint)0 & (nint)0x200;
		if (obj39 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S1_v121 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)path != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v172+60]");
			object obj40 = 0;
			nint num11 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v176 (Il2CppClass<System.Type>)+BA]");
			object obj41 = (nint)0 & (nint)0x200;
			if (obj41 != null)
			{
				nint num12 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v202 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v173+3C]");
			obj2 = 0;
			((IntPtr*)num)->m_value = (void*)(nint)obj2;
			Type type3 = Type.internal_from_handle((IntPtr)num);
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S0_v88+60]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S0_v91+5C]");
		object obj43 = 0;
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj44 = (nint)0 & (nint)0x200;
		if (obj44 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S1_v102 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S0_v92+4]");
		bool flag = (UnityEngine.Object)0 != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S1_v49+60]");
		object obj45 = 0;
		nint num15 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S1_v53 (Il2CppClass<System.Type>)+BA]");
		object obj46 = (nint)0 & (nint)0x200;
		bool flag2 = obj46 == null;
		if (flag)
		{
			if (!flag2)
			{
				nint num16 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v163 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S1_v50+3C]");
			obj3 = 0;
			((IntPtr*)num)->m_value = (void*)(nint)obj3;
			Type type4 = Type.internal_from_handle((IntPtr)num);
			throw new ArrayTypeMismatchException();
		}
		if (!flag2)
		{
			nint num17 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v134 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S1_v50+3C]");
		obj4 = 0;
		((IntPtr*)num)->m_value = (void*)(nint)obj4;
		Type type5 = Type.internal_from_handle((IntPtr)num);
		throw new ArrayTypeMismatchException();
	}

	protected void Awake()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	protected T BaseInitialization()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0xFFF;
		object obj5 = obj4 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v11 @ S1_v4 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	private void Initialization()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v3+C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S2_v4 (should have been resolved before IL gen)");
	}

	protected virtual void SubclassInitialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public static T InstantiateFromPath(string path)
	{
		//IL_00e1: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [path @ L0 (System.String)+E]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [path @ L0 (System.String)+D]");
			if ((nint)0 == 0)
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v4+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v5+10]");
				object obj3 = 0;
				object obj4 = obj3 & 0x3FFF;
				object obj5 = obj4 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S2_v5 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				_ = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v6+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v9+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v10+4]");
		return (T)0;
	}

	public void DestroyNewMeOrOldInstance(SingletonMonoBehaviour<T> newSingleton, SingletonMonoBehaviour<T> oldSingleton)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = newSingleton;
		object obj2 = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78BA");
		object obj3 = default;
		obj2 = obj3;
	}

	protected virtual void OnDestroy()
	{
	}

	protected static object Construct(Type type)
	{
		//IL_0246: Expected Obj, but got I4
		//IL_0254: Expected I, but got Obj
		//IL_026a: Expected Obj, but got I
		//IL_0309: Expected I, but got Obj
		//IL_031f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_012a: Expected I, but got Obj
		//IL_0140: Expected Obj, but got I
		//IL_016b: Expected I, but got Obj
		//IL_01c4: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		object result = 0;
		nint num = (nint)typeof(SingletonMonoBehaviour);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SingletonMonoBehaviour);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v62 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string path = ((PrefabPathAttribute)(object)type).Path;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v58 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)path).FindKernel((string)null) != 0)
		{
			nint num5 = default;
			object obj3 = num5 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v32+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v33+24]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v13+60]");
			object obj6 = 0;
			object obj7 = obj5 & 0x3FFF;
			object obj8 = obj7 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v83 @ S2_v5 (should have been resolved before IL gen)");
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object obj10 = default;
			bool flag = obj10 != null;
			bool flag2 = !flag;
			UnityEngine.Object result2 = obj10;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v48+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v49+28]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v21+60]");
				object obj13 = 0;
				object obj14 = obj12 & 0x3FFF;
				object obj15 = obj14 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v127 @ S2_v10 (should have been resolved before IL gen)");
				UnityEngine.Object obj16 = default;
				result2 = obj16;
			}
			return result2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		return result;
	}

	public static bool IsInstantiated()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v10+60]");
		object obj4 = 0;
		object obj5 = obj3 & 0xFFF;
		object obj6 = obj5 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S1_v4 (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public static bool HasExecuteInEditModeAttribute()
	{
		//IL_0433: Expected Obj, but got I
		//IL_044d: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I
		//IL_0475: Expected I, but got Obj
		//IL_048b: Expected Obj, but got I
		//IL_04ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_01ee: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I
		//IL_0513: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I
		//IL_053d: Expected Obj, but got I
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_022f: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02c6: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_033a: Expected Obj, but got I4
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected Obj, but got Unknown
		//IL_03cb: Expected Obj, but got I
		//IL_03db: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05d1: Expected Obj, but got I
		//IL_05e1: Expected Obj, but got I
		//IL_05fb: Expected Obj, but got I
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected Obj, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+5C]");
		object obj3 = 0;
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v12+4]");
		if (((ComputeShader)0).FindKernel(null) == 0)
		{
			string iSOThreeLetterLanguageCode = Locale.GetISOThreeLetterLanguageCode();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v9+60]");
			object obj5 = -(-64);
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v16+60]");
			object obj7 = -(-64);
			object obj8 = obj6 & 0x3FFF;
			object obj9 = obj8 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v125 @ S2_v8 (should have been resolved before IL gen)");
			object obj10 = default;
			if (obj10 != null)
			{
				string iSOThreeLetterLanguageCode2 = Locale.GetISOThreeLetterLanguageCode();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v72+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v73+44]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v78+60]");
				object obj13 = 0;
				object obj14 = obj12 & 0x3FFF;
				object obj15 = obj14 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v169 @ S2_v27 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v83+60]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v84+2C]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v89+60]");
				object obj18 = 0;
				object obj19 = obj17 & 0x3FFF;
				object obj20 = obj19 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v86 @ S2_v30 (should have been resolved before IL gen)");
				return true;
			}
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v70 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v35+60]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v36+48]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v41+60]");
			object obj24 = 0;
			object obj25 = obj23 & 0xFFF;
			object obj26 = obj25 + 1797;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v179 @ S1_v23 (should have been resolved before IL gen)");
			object obj28 = default;
			object obj27 = obj28 + 12;
			if (obj27 == null)
			{
				return false;
			}
			if ((nint)obj27 == 1)
			{
				object obj29 = obj28 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v28+60]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v29+2C]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v34+60]");
				object obj32 = 0;
				object obj33 = obj31 & 0x3FFF;
				object obj34 = obj33 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88 @ S2_v13 (should have been resolved before IL gen)");
				return true;
			}
			object obj35 = obj27;
			object obj36 = 1;
			object obj40 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35))
			{
				object obj37 = obj28 + 16;
				object obj38 = obj36 << 2;
				object obj39 = obj37 + obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				if (obj40 == null)
				{
					object obj41 = obj36 + 1;
					obj35 = obj27;
					obj36 = obj41;
					continue;
				}
				object obj42 = obj28 + 16;
				object obj43 = obj36 << 2;
				object obj44 = obj42 + obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v60+60]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S1_v61+2C]");
				object obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v66+60]");
				object obj47 = 0;
				object obj48 = obj46 & 0x3FFF;
				object obj49 = obj48 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v89 @ S2_v24 (should have been resolved before IL gen)");
				return true;
			}
			object obj50 = obj28 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v42+60]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v43+2C]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v48+60]");
			object obj53 = 0;
			object obj54 = obj52 & 0x3FFF;
			object obj55 = obj54 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S2_v17 (should have been resolved before IL gen)");
		}
		return true;
	}

	public static ExecuteInEditMode GetExecuteInEditModeAttributes()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		nint num = default;
		object obj = num + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v5+4C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v10+60]");
		object obj4 = 0;
		object obj5 = obj3 & 0xFFF;
		object obj6 = obj5 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S1_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		bool flag = obj7 != null;
		return (ExecuteInEditMode)flag;
	}

	public unsafe static bool HasPrefabPathAttribute()
	{
		//IL_007b: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I, but got Unknown
		//IL_00f5: Expected I, but got Obj
		//IL_011d: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10+60]");
		object obj = 0;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v26 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+3C]");
		obj3 = 0;
		nint num3 = (nint)(obj4 + 8);
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Type type = Type.internal_from_handle((IntPtr)num3);
		obj4 = typeof(ExecuteInEditMode);
		((IntPtr*)num3)->m_value = (void*)(nint)obj4;
		Type type2 = Type.internal_from_handle((IntPtr)num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8582");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		bool result = default;
		return result;
	}

	public static PrefabPathAttribute GetPrefabPathAttribute()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		nint num = default;
		object obj = num + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v5+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v10+60]");
		object obj4 = 0;
		object obj5 = obj3 & 0xFFF;
		object obj6 = obj5 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S1_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		bool flag = obj7 != null;
		return (PrefabPathAttribute)flag;
	}

	public override string ToString()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public override bool Equals(object obj)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_00d8: Expected I4, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		object obj2 = 0;
		nint num = default;
		object obj3 = num + 12;
		object obj9 = default;
		object obj10 = default;
		string text = default;
		object obj16 = default;
		bool result = default;
		while (true)
		{
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S2_v3+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v4+8]");
			object obj6 = 0;
			object obj7 = obj6 & 0x3FFF;
			object obj8 = obj7 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S3_v5 (should have been resolved before IL gen)");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
			{
				break;
			}
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S4_v6+60]");
			object obj12 = 0;
			object obj13 = obj12;
			object obj14 = obj13 & 0x1FFF;
			object obj15 = obj14 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S5_v6 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			if (!(text != (string)obj))
			{
				obj9 = obj16 + 1;
				continue;
			}
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		return (byte)(int)obj2 != 0;
	}

	public override int GetHashCode()
	{
		//IL_03c0: Expected I, but got Obj
		//IL_03d6: Expected Obj, but got I
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_0380: Expected Obj, but got I4
		//IL_03a8: Expected I4, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_033b: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v74 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		if (this == null)
		{
			string text = tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)text == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.SingletonMonoBehaviour`1<T>)+C]");
				if ((nint)0 == 0)
				{
					nint num5 = default;
					object obj5 = num5 + 12;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v35+60]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v38+5C]");
					object obj8 = 0;
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					bool isDestroyed = IsDestroyed;
					obj3 = isDestroyed;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj10 = default;
					object obj9 = obj10 & 1;
					obj2 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					string format = default;
					object arg = default;
					object arg2 = default;
					string text2 = string.Format((IFormatProvider)(object)"[{0} (ID={1}, IsSavedInHierarchy={2})]", format, arg, arg2);
					return (int)text2;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.SingletonMonoBehaviour`1<T>)+C]");
		bool flag = (nint)0 != 0;
		obj3 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format2 = default;
		object arg3 = default;
		string text3 = string.Format((IFormatProvider)(object)"[{0} (IsDestroyed={1})]", format2, arg3);
		return (int)text3;
	}

	protected SingletonMonoBehaviour()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
