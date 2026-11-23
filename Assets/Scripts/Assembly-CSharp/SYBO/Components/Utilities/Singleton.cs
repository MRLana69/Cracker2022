using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Settings;
using UnityEngine;

namespace SYBO.Components.Utilities;

public abstract class Singleton : MonoBehaviour
{
	public static string LogCategoryName = "Utilities";

	public int ID
	{
		get
		{
			GameObject gameObject = base.gameObject;
			Transform transform = gameObject.transform;
			return transform.GetInstanceID();
		}
	}

	public bool IsDestroyed
	{
		get
		{
			return field;
		}
		internal set
		{
			field = value;
		}
	}

	public bool IsSavedInHierarchy
	{
		get
		{
			//IL_0056: Expected Obj, but got I4
			GameObject gameObject = base.gameObject;
			if (gameObject == null)
			{
				return false;
			}
			GameObject gameObject2 = base.gameObject;
			HideFlags hideFlags = gameObject2.hideFlags;
			object obj = hideFlags & HideFlags.HideAndDontSave;
			return (nint)obj != 61;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			//IL_0107: Expected Obj, but got I4
			object obj = default;
			int num = obj - 16;
			GameObject gameObject = base.gameObject;
			HideFlags hideFlags2;
			if (value)
			{
				HideFlags hideFlags = gameObject.hideFlags;
				hideFlags2 = hideFlags & (HideFlags)(-62);
			}
			else
			{
				hideFlags2 = HideFlags.HideAndDontSave;
			}
			gameObject.hideFlags = hideFlags2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj2 = num + 15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
	}

	public static bool IsShuttingDown => false;

	public abstract Singleton GetInstance();

	public static GameObject InstantiateGameObjectFromPath(string path)
	{
		if (path.EndsWith(".prefab", StringComparison.OrdinalIgnoreCase))
		{
			int length = path._stringLength - 7;
			string text = path.Substring(0, length);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		GameObject gameObject = Resources.Load<GameObject>(path);
		if (gameObject != null)
		{
			return UnityEngine.Object.Instantiate(gameObject);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public static void LogFormat(int level, string format, object[] args)
	{
		int logLevel = StaticSettings.Log.GetLogLevel(LogCategoryName);
	}

	public static void LogWarningFormat(string format, object[] args)
	{
	}

	public static void LogErrorFormat(string format, object[] args)
	{
	}
}
public abstract class Singleton<T> : Singleton where T : Singleton<T>
{
	private bool _hasCalledAwake;

	private static PrefabPathAttribute _attribute;

	private static T _instance;

	internal bool HasCalledAwake
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.Singleton`1<T>)+D]");
			return false;
		}
		set
		{
		}
	}

	public static T Instance
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_08f8: Expected Obj, but got I
			//IL_091a: Expected Obj, but got I
			//IL_07c6: Expected Obj, but got I
			//IL_07d7: Expected VT, but got I
			//IL_002d: Expected Obj, but got I
			//IL_003d: Expected Obj, but got I
			//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ee: Expected Obj, but got Unknown
			//IL_005c: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I
			//IL_0478: Expected VT, but got I
			//IL_00ad: Expected Obj, but got I
			//IL_00c7: Expected Obj, but got I
			//IL_04c1: Expected Obj, but got I
			//IL_04d2: Expected VT, but got I
			//IL_00fa: Expected Obj, but got I
			//IL_0144: Expected Obj, but got I
			//IL_0162: Expected Obj, but got I
			//IL_0269: Expected Obj, but got I
			//IL_027b: Expected Obj, but got I
			//IL_01bb: Expected Obj, but got I
			//IL_01cc: Expected VT, but got I
			//IL_02ad: Expected Obj, but got I
			//IL_02be: Expected VT, but got I
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected Obj, but got Unknown
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10+60]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v16+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S0_v12+4] (should have been resolved before IL gen)");
			object obj6 = default;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v64+60]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v65+8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v70+60]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S0_v66+4] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v76+60]");
				object obj10 = 0;
				object obj11 = default;
				if (obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v77+C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v167+60]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S0_v163+4] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v175+5C]");
					object obj14 = 0;
					object obj15 = default;
					obj14 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v187+5C]");
					object obj16 = 0;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v189+8]");
					GameObject gameObject = Singleton.InstantiateGameObjectFromPath((string)0);
					if (gameObject == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v267+60]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v268+10]");
						Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
						object obj19 = typeFromHandle - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v361 @ S2_v37+BC] (should have been resolved before IL gen)");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v203+5C]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v204+4]");
					bool flag = (UnityEngine.Object)0 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v215+60]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v216+10]");
					Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
					object obj22 = typeFromHandle2 - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v416 @ S2_v29+BC] (should have been resolved before IL gen)");
					throw new ArrayTypeMismatchException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v77+10]");
				Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
				MethodInfo method = ReflectionWrapper.GetMethod(typeFromHandle3, "Construct", (BindingFlags)120);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v29+60]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v30+10]");
				Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v31+60]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v32+10]");
			Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			object obj25 = typeFromHandle5 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ S2_v5+BC] (should have been resolved before IL gen)");
			throw new ArrayTypeMismatchException();
		}
		protected set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
	}

	public override Singleton GetInstance()
	{
		//IL_001c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3 (Il2CppRgctx<SYBO.Components.Utilities.Singleton`1>)+24]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S1_v4+4] (should have been resolved before IL gen)");
		Singleton result = default;
		return result;
	}

	public static T Instantiate()
	{
		//IL_001a: Expected Obj, but got I
		//IL_002a: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v3+60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S0_v4+24]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S0_v9+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S0_v5+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	protected virtual void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private void CheckHasCalledAwake()
	{
		//IL_001c: Expected Obj, but got I
		//IL_0074: Expected VT, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S2_v3 (Il2CppRgctx<SYBO.Components.Utilities.Singleton`1>)+28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v4+4] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 == null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7 (Il2CppRgctx<SYBO.Components.Utilities.Singleton`1>)+10]");
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			object obj3 = typeFromHandle - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S1_v9+BC] (should have been resolved before IL gen)");
			string text = default;
			string message = "Singleton<" + text + ">.Instance Failed. Did you override Awake() and forget to call base.Awake()?";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			InvalidOverrideException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public static T InstantiateFromPath(string path)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		GameObject gameObject = Singleton.InstantiateGameObjectFromPath(path);
		UnityEngine.Object result;
		if (gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v26+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v27+34]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v12+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S0_v28+4] (should have been resolved before IL gen)");
			UnityEngine.Object obj6 = default;
			bool flag = obj6 == null;
			bool flag2 = !flag;
			result = obj6;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v39+60]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v40+38]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v18+60]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S0_v41+4] (should have been resolved before IL gen)");
				UnityEngine.Object obj10 = default;
				result = obj10;
			}
		}
		else
		{
			object obj11 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			result = (UnityEngine.Object)0;
		}
		return (T)result;
	}

	public void DestroyNewMeOrOldInstance(Singleton<T> newSingleton, Singleton<T> oldSingleton)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool isSavedInHierarchy = newSingleton.IsSavedInHierarchy;
		bool isSavedInHierarchy2 = oldSingleton.IsSavedInHierarchy;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	protected virtual void OnDestroy()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	protected static object Construct(Type type)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		object obj = type - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v4+BC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public static bool IsInstantiated()
	{
		//IL_02b1: Expected Obj, but got I
		//IL_0017: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I4
		//IL_0327: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v11+4]");
		bool flag = (UnityEngine.Object)0 == null;
		bool result = true;
		if (flag)
		{
			SingletonManager instance = SingletonManager.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v24+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v25+3C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v7+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S0_v26+4] (should have been resolved before IL gen)");
			object obj5 = default;
			if (obj5 != null)
			{
				SingletonManager instance2 = SingletonManager.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v77+60]");
				object obj6 = -(-64);
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v28+60]");
				object obj8 = -(-64);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S0_v80+4] (should have been resolved before IL gen)");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+60]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v44+44]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v50+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ S0_v45+4] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v53+C]");
				bool flag2 = (nint)0 == 0;
				result = false;
				if (flag2)
				{
					goto IL_02b6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v53+C]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v53+C]");
					object obj12 = 0;
					object obj13 = 1;
					object obj16 = default;
					while (true)
					{
						object obj19;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
						{
							object obj14 = obj13 << 2;
							object obj15 = obj16 + obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v63+10]");
							if (((Singleton)0).IsSavedInHierarchy)
							{
								object obj17 = obj13 << 2;
								object obj18 = obj16 + obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v71+10]");
								obj19 = 0;
								break;
							}
							object obj20 = obj13 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v53+C]");
							obj12 = 0;
							obj13 = obj20;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v53+10]");
						obj19 = 0;
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v53+10]");
					object obj19 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v33+60]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v34+20]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v13+60]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ S0_v35+4] (should have been resolved before IL gen)");
			result = true;
		}
		goto IL_02b6;
		IL_02b6:
		return result;
	}

	public static bool HasExecuteInEditModeAttribute()
	{
		//IL_001a: Expected Obj, but got I
		//IL_002a: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v3+60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S0_v4+48]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S0_v9+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S0_v5+4] (should have been resolved before IL gen)");
		object obj4 = default;
		return obj4 != null;
	}

	public static ExecuteInEditMode GetExecuteInEditModeAttributes()
	{
		//IL_0050: Expected Obj, but got I
		//IL_0061: Expected VT, but got I
		//IL_0014: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+10]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ExecuteInEditMode));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @165A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		ExecuteInEditMode result = default;
		return result;
	}

	public static bool HasPrefabPathAttribute()
	{
		//IL_001a: Expected Obj, but got I
		//IL_002a: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v3+60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S0_v4+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S0_v9+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S0_v5+4] (should have been resolved before IL gen)");
		object obj4 = default;
		return obj4 != null;
	}

	public static PrefabPathAttribute GetPrefabPathAttribute()
	{
		//IL_0050: Expected Obj, but got I
		//IL_0061: Expected VT, but got I
		//IL_0014: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+10]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(PrefabPathAttribute));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @165A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		PrefabPathAttribute result = default;
		return result;
	}

	public new string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		if (this != null)
		{
			GameObject gameObject = base.gameObject;
			if (gameObject != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.Singleton`1<T>)+C]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v38+5C]");
					object obj3 = 0;
					if (obj3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
						object obj5 = default;
						object obj4 = obj5 - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ S2_v20+BC] (should have been resolved before IL gen)");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
					object obj7 = default;
					object obj6 = obj7 - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S1_v21+BC] (should have been resolved before IL gen)");
					int iD = ID;
					object obj8 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					bool isSavedInHierarchy = IsSavedInHierarchy;
					object obj9 = obj + 15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object arg = default;
					object arg2 = default;
					object arg3 = default;
					return $"[{arg} (ID={arg2}, IsSavedInHierarchy={arg3})]";
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		object obj11 = default;
		object obj10 = obj11 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S1_v9+BC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.Singleton`1<T>)+C]");
		_ = 0;
		object obj12 = obj + 31;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg4 = default;
		object arg5 = default;
		return $"[{arg4} (IsDestroyed={arg5})]";
	}

	public new bool Equals(object obj)
	{
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			UnityEngine.Object obj2 = default;
			if (obj2 != null)
			{
				int iD = ((Singleton)obj2).ID;
				int iD2 = ID;
				return iD == iD2;
			}
		}
		bool result = default;
		return result;
	}

	public new int GetHashCode()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int iD = ID;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return 0;
	}
}
