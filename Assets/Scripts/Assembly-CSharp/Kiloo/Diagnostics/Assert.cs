using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Diagnostics;

public static class Assert
{
	public class AssertFailedException : Exception
	{
	}

	private static void FailAssert()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Debug.Break();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		AssertFailedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public static void IsNotNull(object obj, string paramName, UnityEngine.Object context)
	{
		if (obj == null)
		{
			string text = "Assert failed: " + paramName + " is null!";
			FailAssert();
		}
	}

	public static void IsNotNull(object obj, string paramName)
	{
		if (obj == null)
		{
			string text = "Assert failed: " + paramName + " is null!";
			FailAssert();
		}
	}

	public static void IsTrue(bool condition, string message, UnityEngine.Object context)
	{
		if (!condition)
		{
			string text = "Assert failed: " + message;
			FailAssert();
		}
	}

	public static void IsFalse(bool condition, string message, UnityEngine.Object context)
	{
		if (condition)
		{
			string text = "Assert failed: " + message;
			FailAssert();
		}
	}

	public static void IsTrue(bool condition)
	{
		if (!condition)
		{
			FailAssert();
		}
	}

	public static void IsFalse(bool condition)
	{
		if (condition)
		{
			FailAssert();
		}
	}

	public static void IsTrue(bool condition, string message)
	{
		if (!condition)
		{
			string text = "Assert failed: " + message;
			FailAssert();
		}
	}

	public static void IsFalse(bool condition, string message)
	{
		if (condition)
		{
			string text = "Assert failed: " + message;
			FailAssert();
		}
	}
}
