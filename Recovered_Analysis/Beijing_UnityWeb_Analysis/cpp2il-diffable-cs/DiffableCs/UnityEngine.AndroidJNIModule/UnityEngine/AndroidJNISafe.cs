namespace UnityEngine;

internal class AndroidJNISafe
{

	public static bool CallBooleanMethod(nint obj, nint methodID, jvalue[] args) { }

	public static char CallCharMethod(nint obj, nint methodID, jvalue[] args) { }

	public static double CallDoubleMethod(nint obj, nint methodID, jvalue[] args) { }

	public static float CallFloatMethod(nint obj, nint methodID, jvalue[] args) { }

	public static int CallIntMethod(nint obj, nint methodID, jvalue[] args) { }

	public static long CallLongMethod(nint obj, nint methodID, jvalue[] args) { }

	public static nint CallObjectMethod(nint obj, nint methodID, jvalue[] args) { }

	public static sbyte CallSByteMethod(nint obj, nint methodID, jvalue[] args) { }

	public static short CallShortMethod(nint obj, nint methodID, jvalue[] args) { }

	public static bool CallStaticBooleanMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static char CallStaticCharMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static double CallStaticDoubleMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static float CallStaticFloatMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static int CallStaticIntMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static long CallStaticLongMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static nint CallStaticObjectMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static sbyte CallStaticSByteMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static short CallStaticShortMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static string CallStaticStringMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static void CallStaticVoidMethod(nint clazz, nint methodID, jvalue[] args) { }

	public static string CallStringMethod(nint obj, nint methodID, jvalue[] args) { }

	public static void CheckException() { }

	public static void DeleteGlobalRef(nint globalref) { }

	public static void DeleteLocalRef(nint localref) { }

	public static void DeleteWeakGlobalRef(nint globalref) { }

	public static nint FindClass(string name) { }

	public static bool[] FromBooleanArray(nint array) { }

	public static byte[] FromByteArray(nint array) { }

	public static char[] FromCharArray(nint array) { }

	public static double[] FromDoubleArray(nint array) { }

	public static float[] FromFloatArray(nint array) { }

	public static int[] FromIntArray(nint array) { }

	public static long[] FromLongArray(nint array) { }

	public static nint FromReflectedMethod(nint refMethod) { }

	public static sbyte[] FromSByteArray(nint array) { }

	public static short[] FromShortArray(nint array) { }

	public static int GetArrayLength(nint array) { }

	public static nint GetMethodID(nint obj, string name, string sig) { }

	public static nint GetObjectArrayElement(nint array, int index) { }

	public static nint GetObjectClass(nint ptr) { }

	public static nint GetStaticMethodID(nint clazz, string name, string sig) { }

	public static string GetStringChars(nint str) { }

	public static nint NewObject(nint clazz, nint methodID, jvalue[] args) { }

	public static nint NewString(string chars) { }

	public static nint ToBooleanArray(bool[] array) { }

	public static nint ToByteArray(byte[] array) { }

	public static nint ToCharArray(char[] array) { }

	public static nint ToDoubleArray(double[] array) { }

	public static nint ToFloatArray(float[] array) { }

	public static nint ToIntArray(int[] array) { }

	public static nint ToLongArray(long[] array) { }

	public static nint ToObjectArray(nint[] array, nint type) { }

	public static nint ToSByteArray(sbyte[] array) { }

	public static nint ToShortArray(short[] array) { }

}

