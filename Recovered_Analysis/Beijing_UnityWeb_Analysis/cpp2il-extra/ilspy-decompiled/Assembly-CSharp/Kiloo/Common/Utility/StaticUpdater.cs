using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Utility;

public class StaticUpdater : MonoBehaviour
{
	private static StaticUpdater _instance;

	private Action<float> m_onUpdate;

	private Action<float> m_onLateUpdate;

	public static StaticUpdater instance
	{
		get
		{
			bool flag = KRandom._internalRandom == null;
			bool flag2 = !flag;
			RankException result = (RankException)(object)KRandom._internalRandom;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				RankException ex = default;
				ex._002Ector();
				KRandom._internalRandom = (System.Random)(object)ex;
				result = ex;
			}
			return (StaticUpdater)(object)result;
		}
	}

	public event Action<float> onUpdate
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onUpdate;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action<float> onLateUpdate
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onUpdate;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onLateUpdate;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private unsafe void Update()
	{
		//IL_0186: Expected Obj, but got I4
		//IL_01b7: Expected I4, but got Obj
		//IL_01b7: Expected I4, but got Obj
		//IL_01b7: Expected I4, but got Obj
		//IL_01e7: Expected I4, but got Obj
		//IL_01e7: Expected I4, but got Obj
		//IL_01e7: Expected I4, but got Obj
		bool flag = Directory.IsRootDirectory((string)(object)this);
		FileAttributes attributes = File.GetAttributes((string)(object)this);
		object obj = (flag ? 1 : 0) | (int)attributes;
		if (obj == null)
		{
			return;
		}
		string dataPath = Application.dataPath;
		if (dataPath != null)
		{
			if ((nint)dataPath != 1 && (nint)dataPath != 2 && (nint)dataPath != 3 && (nint)dataPath != 4 && (nint)dataPath != 5 && (nint)dataPath != 6 && (nint)dataPath == 7)
			{
				string text = ((!flag) ? "/select," : string.Empty);
				int num = text.IndexOf((char)(int)"\"", (int)this, (int)"\"");
				bool flag2 = Process.ShellExecuteEx_internal((ProcessStartInfo)(object)"explorer.exe", ref *(Process.ProcInfo*)num);
			}
		}
		else
		{
			string text2 = ((!flag) ? "-R " : string.Empty);
			int num2 = text2.IndexOf((char)(int)"'", (int)this, (int)"'");
			bool flag3 = Process.ShellExecuteEx_internal((ProcessStartInfo)(object)"open", ref *(Process.ProcInfo*)num2);
		}
	}

	private void LateUpdate()
	{
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		float fixedDeltaTime = Time.fixedDeltaTime;
		if (this.m_onUpdate != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v2 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x1FF;
			object obj4 = obj3 + 79894;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	private void Debug()
	{
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		float fixedDeltaTime = Time.fixedDeltaTime;
		if (this.m_onLateUpdate != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v2 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x1FF;
			object obj4 = obj3 + 79894;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	public StaticUpdater()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		if (this.m_onUpdate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj2 = default;
			object obj = obj2 + 12;
			object obj3 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj4 = obj3 + 1;
				obj3 = obj4;
			}
		}
	}
}
