using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class EventDelegate
{
	[Serializable]
	public class Parameter
	{
		public UnityEngine.Object obj;

		public string field;

		[NonSerialized]
		private object mValue;

		[NonSerialized]
		public Type expectedType;

		[NonSerialized]
		public bool cached;

		[NonSerialized]
		public PropertyInfo propInfo;

		[NonSerialized]
		public FieldInfo fieldInfo;

		public object value
		{
			get
			{
				//IL_0135: Expected I, but got Obj
				//IL_017d: Expected I, but got Obj
				//IL_00aa: Expected Obj, but got I4
				//IL_01f2: Expected I, but got Obj
				//IL_008e: Expected Obj, but got I4
				//IL_010a: Expected I, but got Obj
				object result = mValue;
				object obj;
				if (mValue == null)
				{
					if (!cached)
					{
						this.fieldInfo = null;
						cached = true;
						propInfo = null;
						if (this.obj != null)
						{
							string text = this.field;
							if (this.field != null)
							{
								obj = 0;
								if (text._stringLength != 0)
								{
									goto IL_0272;
								}
							}
							obj = 1;
							goto IL_0272;
						}
					}
					goto IL_024b;
				}
				goto IL_0280;
				IL_0280:
				return result;
				IL_024b:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
				object obj2 = default;
				if (obj2 != null)
				{
					PropertyInfo propertyInfo = propInfo;
					nint num = (nint)propertyInfo;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ S3_v6 (Il2CppClass<System.Reflection.PropertyInfo>)+18C] (should have been resolved before IL gen)");
					object result2 = default;
					return result2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
				object obj3 = default;
				if (obj3 != null)
				{
					FieldInfo fieldInfo = this.fieldInfo;
					nint num2 = (nint)fieldInfo;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v144 @ S2_v11 (Il2CppClass<System.Reflection.FieldInfo>)+184] (should have been resolved before IL gen)");
					object result3 = default;
					return result3;
				}
				if (this.obj != null)
				{
					return this.obj;
				}
				if ((object)expectedType != null)
				{
					Type type = expectedType;
					nint num3 = (nint)type;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ S1_v10 (Il2CppClass<System.Type>)+31C] (should have been resolved before IL gen)");
					result = null;
					object obj4 = default;
					if (obj4 != null)
					{
						goto IL_0280;
					}
				}
				object obj5 = Convert.ChangeType(null, expectedType);
				result = obj5;
				goto IL_0280;
				IL_0272:
				if (obj == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
					Type type2 = default;
					PropertyInfo property = type2.GetProperty(this.field);
					propInfo = property;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
					object obj6 = default;
					if (obj6 != null)
					{
						nint num4 = (nint)type2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ S4_v6 (Il2CppClass<System.Type>)+36C] (should have been resolved before IL gen)");
						FieldInfo fieldInfo2 = default;
						this.fieldInfo = fieldInfo2;
					}
				}
				goto IL_024b;
			}
			set
			{
				mValue = value;
			}
		}

		public Type type
		{
			get
			{
				//IL_0051: Expected VT, but got Obj
				if (mValue != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
					Type result = default;
					return result;
				}
				if (obj == null)
				{
					return Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(void));
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
				Type result2 = default;
				return result2;
			}
		}

		public Parameter()
		{
			//IL_0014: Expected VT, but got Obj
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(void));
			expectedType = typeFromHandle;
		}

		public Parameter(UnityEngine.Object obj, string field)
		{
			//IL_0014: Expected VT, but got Obj
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(void));
			expectedType = typeFromHandle;
			this.obj = obj;
			this.field = field;
		}

		public Parameter(object val)
		{
			//IL_0014: Expected VT, but got Obj
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(void));
			expectedType = typeFromHandle;
			mValue = val;
		}
	}

	public delegate void Callback();

	private MonoBehaviour mTarget;

	private string mMethodName;

	private Parameter[] mParameters;

	public bool oneShot;

	[NonSerialized]
	private Callback mCachedCallback;

	[NonSerialized]
	private bool mRawDelegate;

	[NonSerialized]
	private bool mCached;

	[NonSerialized]
	private MethodInfo mMethod;

	[NonSerialized]
	private ParameterInfo[] mParameterInfos;

	[NonSerialized]
	private object[] mArgs;

	private static int s_Hash;

	public MonoBehaviour target
	{
		get
		{
			return mTarget;
		}
		set
		{
			mTarget = value;
			mCachedCallback = null;
			mMethod = null;
			mRawDelegate = false;
			mParameterInfos = null;
			mParameters = null;
		}
	}

	public string methodName
	{
		get
		{
			return mMethodName;
		}
		set
		{
			mMethodName = value;
			mCachedCallback = null;
			mMethod = null;
			mRawDelegate = false;
			mParameterInfos = null;
			mParameters = null;
		}
	}

	public Parameter[] parameters
	{
		get
		{
			if (~(mCached ? 1u : 0u) != 0)
			{
				Cache();
			}
			return mParameters;
		}
	}

	public bool isValid
	{
		get
		{
			//IL_00c7: Expected Obj, but got I4
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected I4, but got Unknown
			//IL_00ab: Expected Obj, but got I4
			if (~(mCached ? 1u : 0u) != 0)
			{
				Cache();
			}
			bool result;
			if (~(mRawDelegate ? 1u : 0u) == 0)
			{
				result = true;
				if (mCachedCallback != null)
				{
					goto IL_00f0;
				}
			}
			bool flag = mTarget != null;
			bool flag2 = !flag;
			result = false;
			if (flag2)
			{
				goto IL_00f0;
			}
			string text = mMethodName;
			object obj;
			if (mMethodName != null)
			{
				obj = 0;
				if (text._stringLength != 0)
				{
					goto IL_00f5;
				}
			}
			obj = 1;
			goto IL_00f5;
			IL_00f5:
			result = (byte)(obj ^ 1) != 0;
			goto IL_00f0;
			IL_00f0:
			return result;
		}
	}

	public bool isEnabled
	{
		get
		{
			if (~(mCached ? 1u : 0u) != 0)
			{
				Cache();
			}
			bool result;
			if (~(mRawDelegate ? 1u : 0u) == 0)
			{
				result = true;
				if (mCachedCallback != null)
				{
					goto IL_00ae;
				}
			}
			bool flag = mTarget != null;
			result = false;
			if (flag)
			{
				bool flag2 = mTarget != null;
				result = true;
				if (flag2)
				{
					result = mTarget.enabled;
				}
			}
			goto IL_00ae;
			IL_00ae:
			return result;
		}
	}

	public EventDelegate()
	{
	}

	public EventDelegate(Callback call)
	{
		Set(call);
	}

	public EventDelegate(MonoBehaviour target, string methodName)
	{
		Set(target, methodName);
	}

	private static string GetMethodName(Callback callback)
	{
		//IL_0008: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		nint num = (nint)callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<EventDelegate+Callback>)+F4] (should have been resolved before IL gen)");
		object obj2 = default;
		object obj = obj2 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v6+BC] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private static bool IsValid(Callback callback)
	{
		//IL_0036: Expected I, but got Obj
		if (callback == null)
		{
			return false;
		}
		nint num = (nint)callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v2 (Il2CppClass<EventDelegate+Callback>)+F4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		bool result = default;
		return result;
	}

	public override bool Equals(object obj)
	{
		//IL_0251: Expected I, but got Obj
		//IL_01b9: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I
		//IL_0124: Expected I, but got Obj
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		if (obj == null)
		{
			bool flag = isValid;
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		bool flag2 = obj == null;
		object obj2 = null;
		if (!flag2)
		{
			bool flag3 = (object)obj.GetType() == typeof(Callback);
			obj2 = obj;
			if (!flag3)
			{
				obj2 = null;
			}
		}
		bool result;
		if (obj2 != null)
		{
			bool flag4 = obj == null;
			object obj3 = null;
			if (!flag4)
			{
				bool flag5 = (object)obj.GetType() == typeof(Callback);
				obj3 = obj;
				if (!flag5)
				{
					obj3 = null;
				}
			}
			nint num = (nint)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ S3_v6 (Il2CppClass<System.Object>)+BC] (should have been resolved before IL gen)");
			result = true;
			object obj4 = default;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				UnityEngine.Object obj5 = default;
				bool flag6 = mTarget == obj5;
				bool flag7 = !flag6;
				result = false;
				if (!flag7)
				{
					nint num2 = (nint)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S2_v14 (Il2CppClass<System.Object>)+F4] (should have been resolved before IL gen)");
					object obj7 = default;
					object obj6 = obj7 - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ S2_v18+BC] (should have been resolved before IL gen)");
					string b = default;
					return string.Equals(mMethodName, b);
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			object obj8 = default;
			bool flag8 = obj8 == null;
			result = false;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				MonoBehaviour monoBehaviour = mTarget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v14+8]");
				bool flag9 = monoBehaviour == (UnityEngine.Object)0;
				bool flag10 = !flag9;
				result = false;
				if (!flag10)
				{
					string a = mMethodName;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v14+C]");
					result = string.Equals(a, (string)0);
				}
			}
		}
		return result;
	}

	public override int GetHashCode()
	{
		return s_Hash;
	}

	private void Set(Callback call)
	{
		//IL_00a6: Expected I, but got Obj
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		Clear();
		if (call != null && IsValid(call))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			MonoBehaviour monoBehaviour = default;
			mTarget = monoBehaviour;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			if (mTarget == null)
			{
				mCachedCallback = call;
				mRawDelegate = true;
				mMethodName = null;
				return;
			}
			nint num = (nint)call;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S2_v6 (Il2CppClass<EventDelegate+Callback>)+F4] (should have been resolved before IL gen)");
			object obj2 = default;
			object obj = obj2 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S2_v10+BC] (should have been resolved before IL gen)");
			string text = default;
			mMethodName = text;
			mRawDelegate = false;
		}
	}

	public void Set(MonoBehaviour target, string methodName)
	{
		Clear();
		mTarget = target;
		mMethodName = methodName;
	}

	private void Cache()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected Obj, but got Unknown
		//IL_007e: Expected I, but got Obj
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_04b4: Expected I, but got Obj
		//IL_04cd: Expected VT, but got Obj
		//IL_055a: Expected I, but got Obj
		//IL_0679: Expected Obj, but got I4
		//IL_0683: Expected Obj, but got I4
		//IL_05b1: Expected VT, but got Obj
		//IL_08d3: Expected Obj, but got I4
		//IL_0658: Expected Obj, but got I4
		//IL_06b8: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected Obj, but got Unknown
		//IL_0754: Expected Obj, but got I
		//IL_0781: Expected Obj, but got I
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected Obj, but got Unknown
		//IL_0722: Expected Obj, but got I4
		//IL_0879: Expected Obj, but got I
		//IL_03c8: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I
		//IL_0342: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		mCached = true;
		if (mRawDelegate)
		{
			return;
		}
		Callback callback = mCachedCallback;
		if (mCachedCallback != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			UnityEngine.Object obj4 = default;
			if (obj4 == mTarget)
			{
				Callback callback2 = mCachedCallback;
				nint num = (nint)callback2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ S1_v123 (Il2CppClass<EventDelegate+Callback>)+F4] (should have been resolved before IL gen)");
				object obj6 = default;
				object obj5 = obj6 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ S1_v127+BC] (should have been resolved before IL gen)");
				string text = default;
				if (!(text != mMethodName))
				{
					return;
				}
			}
		}
		if (!(mTarget != null))
		{
			return;
		}
		string text2 = mMethodName;
		object obj7;
		if (mMethodName != null)
		{
			obj7 = 0;
			if (text2._stringLength != 0)
			{
				goto IL_07f1;
			}
		}
		obj7 = 1;
		goto IL_07f1;
		IL_08ca:
		object obj8 = 0;
		object obj9;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
		{
			object obj10 = obj8 << 2;
			object obj11 = (object)mParameters + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S0_v70+10]");
			object obj12 = 0;
			object obj13 = obj8 << 2;
			object obj14 = (object)mParameterInfos + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S1_v31+10]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v546 @ S2_v18+114] (should have been resolved before IL gen)");
			object obj17 = obj8 + 1;
			obj8 = obj17;
		}
		return;
		IL_07f1:
		if (obj7 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		mMethod = null;
		object obj19 = default;
		object obj34;
		object obj35 = default;
		MethodInfo methodInfo = default;
		object obj20 = default;
		object obj21 = default;
		object obj22 = default;
		object obj24 = default;
		object obj26 = default;
		object obj27 = default;
		object obj33 = default;
		for (object obj18 = obj19; obj18 != null; obj34 = obj18 + 896, Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v364 @ S1_v71+BC] (should have been resolved before IL gen)"), obj18 = obj35)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				mMethod = methodInfo;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj20 != null)
					{
						break;
					}
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj21 == obj22;
			bool flag2 = !flag;
			object obj23 = obj24;
			bool flag4;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				EventDelegate eventDelegate;
				if ((nint)0 != 1)
				{
					object obj25 = obj26;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						flag2 = obj27 == null;
						if (!flag2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
							object obj28 = (nint)0 << 2;
							object obj29 = obj3 + obj28;
							obj29 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
							object obj30 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
							object obj31 = -1;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj32 = obj26;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 != 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						eventDelegate = (EventDelegate)0;
						flag4 = flag2;
						if (flag3)
						{
							goto IL_07b3;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				eventDelegate = (EventDelegate)0;
				obj23 = obj33;
				if (flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					eventDelegate = (EventDelegate)0;
					flag4 = flag2;
					goto IL_07b3;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
			IL_07b3:
			flag2 = flag4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
		object obj36 = default;
		if (obj36 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj37 = default;
			string text3 = default;
			if (obj37 != null)
			{
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v309 @ S4_v9+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text3 = null;
			}
			string text4 = "Could not find method '" + mMethodName + "' on " + text3;
			return;
		}
		MethodInfo methodInfo2 = mMethod;
		nint num2 = (nint)methodInfo2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ S1_v16 (Il2CppClass<System.Reflection.MethodInfo>)+204] (should have been resolved before IL gen)");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(void));
		object obj39 = default;
		if (typeFromHandle != obj39)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj40 = default;
			string text5 = default;
			if (obj40 != null)
			{
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v404 @ S1_v61+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text5 = null;
			}
			string text6 = text5 + "." + mMethodName + " must have a 'void' return type.";
			return;
		}
		MethodInfo methodInfo3 = mMethod;
		nint num3 = (nint)methodInfo3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v331 @ S2_v10 (Il2CppClass<System.Reflection.MethodInfo>)+13C] (should have been resolved before IL gen)");
		ParameterInfo[] array = default;
		mParameterInfos = array;
		ParameterInfo[] array2 = mParameterInfos;
		if (array2.Length == 0)
		{
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Callback));
			Delegate obj42 = Delegate.CreateDelegate(typeFromHandle2, mTarget, mMethodName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			Callback callback3 = default;
			mCachedCallback = callback3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			mArgs = null;
			mParameters = null;
			return;
		}
		mCachedCallback = null;
		ParameterInfo[] array3 = mParameterInfos;
		Parameter[] array4 = mParameters;
		if (mParameters == null)
		{
			object obj43 = array3.Length;
		}
		else
		{
			bool flag6 = array4.Length == array3.Length;
			object obj43 = array3.Length;
			obj9 = array4.Length;
			if (flag6)
			{
				goto IL_08ca;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Parameter[] array5 = default;
		mParameters = array5;
		Parameter[] array6 = mParameters;
		object obj44 = 0;
		if ((nint)obj44 < array6.Length)
		{
			Parameter parameter = default;
			parameter._002Ector();
			throw new ArrayTypeMismatchException();
		}
		Parameter[] array7 = mParameters;
		obj9 = array7.Length;
		goto IL_08ca;
	}

	public bool Execute()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected Obj, but got Unknown
		//IL_00d1: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I4
		//IL_09f1: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_0a33: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I
		//IL_083d: Expected Obj, but got I
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected Obj, but got Unknown
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected Obj, but got Unknown
		//IL_093c: Expected Obj, but got I
		//IL_08bb: Expected Obj, but got I
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected Obj, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected Obj, but got Unknown
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a82: Expected Obj, but got Unknown
		//IL_02d3: Expected Obj, but got I
		//IL_051c: Expected Obj, but got I
		//IL_032e: Expected Obj, but got I
		//IL_0b16: Expected Obj, but got I4
		//IL_0667: Expected I, but got Obj
		//IL_04cd: Expected Obj, but got I
		//IL_0377: Expected Obj, but got I
		//IL_03a2: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected Obj, but got Unknown
		//IL_06ad: Expected Obj, but got I
		//IL_0bd6: Expected Obj, but got I4
		//IL_076f: Expected I, but got Obj
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected Obj, but got Unknown
		//IL_0baa: Expected Obj, but got I
		//IL_07b4: Expected Obj, but got I
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected Obj, but got Unknown
		//IL_07e2: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		if (~(mCached ? 1u : 0u) != 0)
		{
			Cache();
		}
		Callback callback = mCachedCallback;
		bool result;
		object obj5;
		if (mCachedCallback != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
			object obj4 = default;
			bool flag = obj4 == null;
			result = false;
			if (flag)
			{
				goto IL_09e3;
			}
			Parameter[] array = mParameters;
			if (mParameters != null && array.Length != 0)
			{
				object[] array2 = mArgs;
				if (mArgs != null)
				{
					bool flag2 = array2.Length == array.Length;
					obj5 = array.Length;
					if (flag2)
					{
						goto IL_09e8;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				object[] array3 = default;
				mArgs = array3;
				Parameter[] array4 = mParameters;
				obj5 = array4.Length;
				goto IL_09e8;
			}
			MethodInfo methodInfo = mMethod;
			nint num = (nint)methodInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v158 @ S6_v4 (Il2CppClass<System.Reflection.MethodInfo>)+1BC] (should have been resolved before IL gen)");
		}
		goto IL_09d5;
		IL_0a38:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		object obj6 = default;
		bool flag3 = obj6 == null;
		MonoBehaviour monoBehaviour;
		string text = (string)(object)monoBehaviour;
		if (!flag3)
		{
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v448 @ S1_v63+D4] (should have been resolved before IL gen)");
			string text2 = default;
			text = text2;
		}
		EventDelegate eventDelegate = default;
		MethodInfo methodInfo2 = eventDelegate.mMethod;
		object obj8 = methodInfo2 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v465 @ S1_v59+BC] (should have been resolved before IL gen)");
		string text4;
		string text5 = default;
		string text3 = text4 + text + "." + text5;
		goto IL_0586;
		IL_09e8:
		object obj9 = 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			object obj10 = obj9 << 2;
			object obj11 = (object)mParameters + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v165+10]");
			object value = ((Parameter)0).value;
			throw new ArrayTypeMismatchException();
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			goto IL_0a1d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj12 = default;
		object obj13 = default;
		bool flag4 = obj12 == obj13;
		bool flag5 = !flag4;
		MethodInfo methodInfo3 = mMethod;
		monoBehaviour = mTarget;
		object obj15 = default;
		object obj14 = obj15;
		bool flag10 = default;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			methodInfo3 = (MethodInfo)0;
			MonoBehaviour monoBehaviour2 = default;
			monoBehaviour = monoBehaviour2;
			if (!flag6)
			{
				object obj17 = default;
				object obj16 = obj17;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag7 = (nint)0 == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				methodInfo3 = (MethodInfo)0;
				MonoBehaviour monoBehaviour3 = default;
				monoBehaviour = monoBehaviour3;
				if (!flag7)
				{
					if ((object)monoBehaviour3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj18 = (nint)0 << 2;
						object obj19 = obj3 + obj18;
						obj19 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj20 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj21 = (nint)0 << 2;
						object obj22 = obj21 + obj3;
						object obj23 = obj22 - 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						bool flag8 = mTarget == null;
						bool flag9 = !flag8;
						text4 = "Error calling ";
						monoBehaviour = null;
						obj14 = obj23;
						if (!flag9)
						{
							MethodInfo methodInfo4 = mMethod;
							object obj24 = methodInfo4 - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v592 @ S2_v81+BC] (should have been resolved before IL gen)");
							string text6 = default;
							text3 = "Error calling " + text6;
							obj14 = obj23;
							goto IL_0586;
						}
						goto IL_0a38;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj25 = obj17;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					flag10 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					methodInfo3 = (MethodInfo)0;
					monoBehaviour = monoBehaviour3;
					if (flag10)
					{
						goto IL_0997;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			eventDelegate = (EventDelegate)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag11 = (nint)0 == 1;
			object obj26 = default;
			obj14 = obj26;
			if (flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				goto IL_0997;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		text4 = (string)(object)methodInfo3;
		goto IL_0a38;
		IL_0a1d:
		object[] array5 = eventDelegate.mArgs;
		object obj27 = 0;
		if ((nint)obj27 >= array5.Length)
		{
			goto IL_09d5;
		}
		object obj28 = obj27 << 2;
		object obj29 = (object)eventDelegate.mParameterInfos + obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v61+10]");
		object obj30 = 0;
		object obj31 = obj30 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ S1_v29+BC] (should have been resolved before IL gen)");
		object obj33 = default;
		object obj32 = obj33 & 1;
		if (obj32 == null)
		{
			object obj34 = obj27 << 2;
			object obj35 = (object)eventDelegate.mParameterInfos + obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v80+10]");
			object obj36 = 0;
			object obj37 = obj36 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ S1_v49+BC] (should have been resolved before IL gen)");
			object obj39 = default;
			object obj38 = obj39 & 2;
			object obj40 = obj38 >> 1;
			if (obj40 == null)
			{
				goto IL_0c42;
			}
		}
		object obj41 = obj27 << 2;
		object obj42 = (object)eventDelegate.mParameters + obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v76+10]");
		object obj43 = 0;
		object obj44 = obj27 << 2;
		object obj45 = (object)eventDelegate.mArgs + obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S1_v43+10]");
		_ = 0;
		goto IL_0c42;
		IL_0586:
		object obj46 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v520 @ S1_v67+E4] (should have been resolved before IL gen)");
		string text8 = default;
		string text7 = text3 + ": " + text8;
		string text9 = text7 + "\n  Expected: ";
		ParameterInfo[] array6 = eventDelegate.mParameterInfos;
		string text11;
		if (array6.Length == 0)
		{
			string text10 = text9 + "no arguments";
			text11 = text10;
		}
		else
		{
			ParameterInfo parameterInfo = array6[0];
			string text12 = default;
			if (array6[0] != null)
			{
				nint num2 = (nint)parameterInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v599 @ S2_v68 (Il2CppClass<System.Reflection.ParameterInfo>)+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text12 = null;
			}
			string text13 = text9 + text12;
			text11 = text13;
			object obj47 = 1;
			object obj52 = default;
			string text15 = default;
			while (true)
			{
				ParameterInfo[] array7 = eventDelegate.mParameterInfos;
				if ((nint)obj47 >= array7.Length)
				{
					break;
				}
				object obj48 = obj47 << 2;
				object obj49 = (object)array7 + obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S0_v158+10]");
				object obj50 = 0;
				object obj51 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v669 @ S1_v116+114] (should have been resolved before IL gen)");
				string text14;
				if (obj52 != null)
				{
					object obj53 = obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v708 @ S1_v122+D4] (should have been resolved before IL gen)");
					text14 = ", ";
				}
				else
				{
					text14 = ", ";
					text15 = null;
				}
				string text16 = text11 + text14 + text15;
				object obj54 = obj47 + 1;
				text11 = text16;
				obj47 = obj54;
			}
		}
		string text17 = text11 + "\n  Received: ";
		Parameter[] array8 = eventDelegate.mParameters;
		string text19;
		if (array8.Length == 0)
		{
			string text18 = text17 + "no arguments";
			text19 = text18;
		}
		else
		{
			Type type = array8[0].type;
			string text20 = default;
			if ((object)type != null)
			{
				nint num3 = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v698 @ S2_v54 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text20 = null;
			}
			string text21 = text17 + text20;
			text19 = text21;
			object obj55 = 1;
			string text23 = default;
			while (true)
			{
				Parameter[] array9 = eventDelegate.mParameters;
				if ((nint)obj55 >= array9.Length)
				{
					break;
				}
				object obj56 = obj55 << 2;
				object obj57 = (object)array9 + obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ S0_v133+10]");
				Type type2 = ((Parameter)0).type;
				string text22;
				if ((object)type2 != null)
				{
					nint num4 = (nint)type2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v791 @ S1_v99 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
					text22 = ", ";
				}
				else
				{
					text22 = ", ";
					text23 = null;
				}
				string text24 = text19 + text22 + text23;
				object obj58 = obj55 + 1;
				text19 = text24;
				obj55 = obj58;
			}
		}
		string text25 = text19 + "\n";
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj59 = -1;
		goto IL_0a1d;
		IL_09e3:
		return result;
		IL_0c42:
		throw new ArrayTypeMismatchException();
		IL_0997:
		return flag10;
		IL_09d5:
		result = true;
		goto IL_09e3;
	}

	public void Clear()
	{
		mTarget = null;
		mMethodName = null;
		mCachedCallback = null;
		mRawDelegate = false;
		mParameters = null;
		mMethod = null;
		mCached = false;
		mParameterInfos = null;
		mArgs = null;
	}

	public override string ToString()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		string text2;
		object obj4;
		if (mTarget != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj2 = default;
			object obj = obj2;
			object obj3 = obj2 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S1_v5+D4] (should have been resolved before IL gen)");
			string text = default;
			int num = text.LastIndexOf('.');
			bool flag = num >= 1;
			bool flag2 = !flag;
			text2 = text;
			if (!flag2)
			{
				int startIndex = num + 1;
				string text3 = text.Substring(startIndex);
				text2 = text3;
			}
			string text4 = mMethodName;
			if (mMethodName != null)
			{
				obj4 = 0;
				if (text4._stringLength != 0)
				{
					goto IL_0178;
				}
			}
			obj4 = 1;
			goto IL_0178;
		}
		string result = "[delegate]";
		if (!mRawDelegate)
		{
			result = null;
		}
		return result;
		IL_0178:
		if (obj4 == null)
		{
			return text2 + "/" + mMethodName;
		}
		return text2 + "/[delegate]";
	}

	public static void Execute(List<EventDelegate> list)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_04db: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_026a: Expected Obj, but got I
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [5316D1]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		object obj3 = obj + 8;
		_ = 0;
		List<EventDelegate> list2 = default;
		bool flag3 = list2 == null;
		int num = 0;
		if (flag3)
		{
			return;
		}
		List<EventDelegate> list3 = default;
		object obj4 = default;
		object obj5 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		object obj22 = default;
		while (num < list3._size)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			EventDelegate eventDelegate = ((List<EventDelegate>)0).get_Item(num);
			if (eventDelegate == null)
			{
				goto IL_03fc;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_047c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag4 = obj4 == obj5;
			flag2 = !flag4;
			object obj6 = obj7;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj8 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj10 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
							object obj11 = (nint)0 << 2;
							object obj12 = obj3 + obj11;
							obj12 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
							object obj13 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
							object obj14 = (nint)0 << 2;
							object obj15 = obj14 + obj3;
							object obj16 = obj15 - 4;
							object obj17 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v113+14]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v113+14]");
							bool flag5 = (nint)0 == 0;
							obj6 = obj17;
							if (flag5)
							{
								goto IL_04a0;
							}
							object obj19 = obj18;
							object obj20 = obj18 + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ S1_v67+E4] (should have been resolved before IL gen)");
							goto IL_04c5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj21 = obj9;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							break;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				list3 = (List<EventDelegate>)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 == 1;
				obj6 = obj22;
				if (flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_04a0;
			IL_03fc:
			int num2 = num + 1;
			num = num2;
			continue;
			IL_047c:
			if (num < list3._size)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				EventDelegate eventDelegate2 = ((List<EventDelegate>)0).get_Item(num);
				if (eventDelegate2 != eventDelegate)
				{
					continue;
				}
				if (~(eventDelegate.oneShot ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					((List<EventDelegate>)0).RemoveAt(num);
					continue;
				}
				goto IL_03fc;
			}
			break;
			IL_04a0:
			object obj23 = obj6;
			object obj24 = obj6 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ S1_v33+E4] (should have been resolved before IL gen)");
			goto IL_04c5;
			IL_04c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			object obj25 = -1;
			goto IL_047c;
		}
	}

	public static bool IsValid(List<EventDelegate> list)
	{
		bool result = default;
		if (list != null)
		{
			int num = 0;
			while (true)
			{
				bool flag = num < list._size;
				bool flag2 = !flag;
				result = flag;
				if (flag2)
				{
					break;
				}
				EventDelegate eventDelegate = list.get_Item(num);
				if (eventDelegate != null)
				{
					bool flag3 = eventDelegate.isValid;
					result = flag;
					if (flag3)
					{
						break;
					}
				}
				int num2 = num + 1;
				num = num2;
			}
		}
		return result;
	}

	public static EventDelegate Set(List<EventDelegate> list, Callback callback)
	{
		bool flag = list == null;
		EventDelegate result = null;
		if (!flag)
		{
			EventDelegate eventDelegate = default;
			eventDelegate._002Ector(callback);
			((List<T>)(object)list).Clear();
			list.Add(eventDelegate);
			result = eventDelegate;
		}
		return result;
	}

	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
		if (list != null)
		{
			((List<T>)(object)list).Clear();
			list.Add(del);
		}
	}

	public static EventDelegate Add(List<EventDelegate> list, Callback callback)
	{
		return Add(list, callback, oneShot: false);
	}

	public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
		//IL_003b: Expected I, but got Obj
		bool flag = list == null;
		EventDelegate result = null;
		if (!flag)
		{
			int num = default;
			object obj = default;
			int num3 = default;
			EventDelegate eventDelegate2 = default;
			while (true)
			{
				if (num < list._size)
				{
					EventDelegate eventDelegate = list.get_Item(num);
					if (eventDelegate != null)
					{
						nint num2 = (nint)eventDelegate;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S2_v10 (Il2CppClass<EventDelegate>)+BC] (should have been resolved before IL gen)");
						result = eventDelegate;
						if (obj != null)
						{
							break;
						}
					}
					num = num3 + 1;
					continue;
				}
				eventDelegate2._002Ector(callback);
				eventDelegate2.oneShot = oneShot;
				list.Add(eventDelegate2);
				result = eventDelegate2;
				break;
			}
		}
		return result;
	}

	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
		Add(list, ev, ev.oneShot);
	}

	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
		//IL_007f: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0105: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I4
		if (ev.mRawDelegate || !(ev.mTarget != null))
		{
			goto IL_0084;
		}
		string text = ev.mMethodName;
		object obj;
		if (ev.mMethodName != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_0255;
			}
		}
		obj = 1;
		goto IL_0255;
		IL_0084:
		EventDelegate eventDelegate = Add(list, ev.mCachedCallback, oneShot);
		return;
		IL_0255:
		if (obj == null)
		{
			if (list == null)
			{
				return;
			}
			int num = 0;
			object obj2 = default;
			EventDelegate eventDelegate3 = default;
			Parameter[] array2 = default;
			while (true)
			{
				if (num < list._size)
				{
					EventDelegate eventDelegate2 = list.get_Item(num);
					if (eventDelegate2 != null)
					{
						nint num2 = (nint)eventDelegate2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ S2_v19 (Il2CppClass<EventDelegate>)+BC] (should have been resolved before IL gen)");
						if (obj2 != null)
						{
							break;
						}
					}
					int num3 = num + 1;
					num = num3;
					continue;
				}
				eventDelegate3._002Ector(ev.mTarget, ev.mMethodName);
				eventDelegate3.oneShot = oneShot;
				Parameter[] array = ev.mParameters;
				if (ev.mParameters != null && array.Length != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					eventDelegate3.mParameters = array2;
					object obj3 = 0;
					Parameter[] array3 = ev.mParameters;
					if ((nint)obj3 < array3.Length)
					{
						object obj4 = obj3 << 2;
						object obj5 = (object)array3 + obj4;
						throw new ArrayTypeMismatchException();
					}
				}
				list.Add(eventDelegate3);
				break;
			}
			return;
		}
		goto IL_0084;
	}

	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		//IL_0049: Expected I, but got Obj
		if (list != null)
		{
			int num = 0;
			object obj = default;
			while (num < list._size)
			{
				EventDelegate eventDelegate = list.get_Item(num);
				if (eventDelegate != null)
				{
					nint num2 = (nint)eventDelegate;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S2_v7 (Il2CppClass<EventDelegate>)+BC] (should have been resolved before IL gen)");
					if (obj != null)
					{
						list.RemoveAt(num);
						return true;
					}
				}
				int num3 = num + 1;
				num = num3;
			}
		}
		return false;
	}

	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		//IL_0049: Expected I, but got Obj
		if (list != null)
		{
			int num = 0;
			object obj = default;
			while (num < list._size)
			{
				EventDelegate eventDelegate = list.get_Item(num);
				if (eventDelegate != null)
				{
					nint num2 = (nint)eventDelegate;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S2_v7 (Il2CppClass<EventDelegate>)+BC] (should have been resolved before IL gen)");
					if (obj != null)
					{
						list.RemoveAt(num);
						return true;
					}
				}
				int num3 = num + 1;
				num = num3;
			}
		}
		return false;
	}

	static EventDelegate()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = "EventDelegate";
		object obj2 = obj;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S1_v3+CC] (should have been resolved before IL gen)");
		int num = default;
		s_Hash = num;
	}
}
