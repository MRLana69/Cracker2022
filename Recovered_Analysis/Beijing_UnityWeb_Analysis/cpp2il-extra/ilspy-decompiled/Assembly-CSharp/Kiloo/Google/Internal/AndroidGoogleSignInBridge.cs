using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Google.Internal;

internal sealed class AndroidGoogleSignInBridge : GoogleSignInBridge
{
	private bool PluginInit()
	{
		//IL_0007: Expected I4, but got Obj
		return (byte)(int)base._pendingSignInRequest != 0;
	}

	protected override bool PluginIsConnected()
	{
		return false;
	}

	protected override void PluginConnect()
	{
	}

	protected override bool PluginSignIn(bool silent)
	{
		//IL_0037: Expected Obj, but got I4
		if ((nint)this == (silent ? 1 : 0))
		{
			return true;
		}
		bool flag = (object)this == null;
		bool flag2 = !silent;
		object obj = flag | flag2;
		if (obj != null)
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		string text = default;
		string text2 = default;
		if (text != text2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string text3 = default;
			string text4 = default;
			if (text3 != text4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				string text5 = default;
				string text6 = default;
				if (text5 != text6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					string text7 = default;
					string text8 = default;
					return text7 != text8;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	protected override bool PluginSignOut()
	{
		return false;
	}

	public static bool IsSupported()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A068");
		object obj = default;
		return obj != null;
	}

	public static GoogleSignInBridge Create()
	{
		//IL_001d: Expected Obj, but got I4
		string dataPath = Application.dataPath;
		bool flag = (nint)dataPath == 11;
		return (GoogleSignInBridge)flag;
	}

	public AndroidGoogleSignInBridge()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}
}
