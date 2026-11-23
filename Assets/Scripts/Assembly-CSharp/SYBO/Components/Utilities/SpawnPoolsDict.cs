using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class SpawnPoolsDict : IDictionary<string, SpawnPool>, ICollection<KeyValuePair<string, SpawnPool>>, IEnumerable<KeyValuePair<string, SpawnPool>>, IEnumerable
{
	private Dictionary<string, SpawnPool> _pools;

	bool ICollection<KeyValuePair<string, SpawnPool>>.IsReadOnly => true;

	public int Count
	{
		get
		{
			Dictionary<string, SpawnPool> pools = _pools;
			return pools._count - pools._freeCount;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public SpawnPool get_Item(string key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_031d: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_035f: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag = (nint)0 == 1;
		bool flag2 = !flag;
		SpawnPool spawnPool = default;
		SpawnPool result = spawnPool;
		if (flag2)
		{
			goto IL_0302;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag3 = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		SpawnPoolsDict spawnPoolsDict = default;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 == 1;
			SpawnPool spawnPool3 = default;
			SpawnPool spawnPool2 = spawnPool3;
			if (!flag4)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 == 1;
				SpawnPool spawnPool4 = default;
				spawnPool2 = spawnPool4;
				if (!flag5)
				{
					obj6 = obj9;
					if ((object)spawnPool4 != null)
					{
						goto IL_0307;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj10 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					spawnPool2 = spawnPool4;
					result = spawnPool4;
					if (flag6)
					{
						goto IL_0302;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			spawnPoolsDict = (SpawnPoolsDict)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 != 1;
			object obj11 = default;
			obj6 = obj11;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				result = spawnPool2;
				goto IL_0302;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0307;
		IL_0307:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj12 = (nint)0 << 2;
		object obj13 = obj3 + obj12;
		obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj14 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
		nint num = (nint)spawnPoolsDict;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ S1_v25 (Il2CppClass<SYBO.Components.Utilities.SpawnPoolsDict>)+D4] (should have been resolved before IL gen)");
		string text = default;
		string message = "A Pool with the name '" + key + "' not found. \nPools=" + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		KeyNotFoundException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj15 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (SpawnPool)(object)ex;
		IL_0302:
		return result;
	}

	public void set_Item(string key, SpawnPool value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Cannot set PoolManager.Pools[key] directly. SpawnPools add themselves to PoolManager.Pools when created, so there is no need to set them explicitly. Create pools using PoolManager.Pools.Create() or add a SpawnPool component to a GameObject.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public ICollection<string> Keys
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotImplementedException ex = default;
			ex._002Ector("If you need this, please request it.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			return (ICollection<string>)ex;
		}
	}

	public ICollection<SpawnPool> Values
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotImplementedException ex = default;
			ex._002Ector("If you need this, please request it.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			return (ICollection<SpawnPool>)ex;
		}
	}

	private bool IsReadOnly => true;

	public SpawnPool Create(string poolName)
	{
		string name = poolName + "Pool";
		GameObject gameObject = default;
		gameObject._002Ector(name);
		return gameObject.AddComponent<SpawnPool>();
	}

	public SpawnPool Create(string poolName, GameObject owner)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		SpawnPool result = default;
		if (assertValidPoolName(poolName))
		{
			string name = owner.name;
			object obj3 = obj + 24;
			object obj4 = obj + 28;
			obj = obj4;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 != 1;
					SpawnPool spawnPool = default;
					result = spawnPool;
					if (flag)
					{
						goto IL_01df;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj5 = default;
			object obj6 = default;
			bool flag2 = obj5 != obj6;
			object obj8 = default;
			object obj7 = obj8;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag3 = (nint)0 == 1;
				result = null;
				if (!flag3)
				{
					goto IL_01df;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj9 = default;
				obj7 = obj9;
			}
			_ = 0;
			object obj10 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			SpawnPool result2 = default;
			return result2;
		}
		goto IL_01fc;
		IL_01fc:
		return result;
		IL_01df:
		object obj11 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A57C");
		goto IL_01fc;
	}

	private bool assertValidPoolName(string poolName)
	{
		string text = poolName.Replace("Pool", string.Empty);
		if (text != poolName)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		bool flag = ContainsKey(poolName);
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public override string ToString()
	{
		//IL_0054: Expected Obj, but got I4
		Dictionary<string, SpawnPool> pools = _pools;
		object obj = pools._count - pools._freeCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Dictionary<string, SpawnPool>.KeyCollection keys = _pools.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5436");
		string[] value = default;
		string arg = string.Join(", ", value);
		return $"[{arg}]";
	}

	public unsafe bool Destroy(string poolName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Ref, but got Unknown
		//IL_0043: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = _pools.TryGetValue(poolName, out *(SpawnPool*)(obj + 12));
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		GameObject gameObject = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(gameObject);
		return flag;
	}

	public void DestroyAll()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 == obj8;
			bool flag2 = !flag;
			object obj9 = obj10;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj13 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A57B");
		throw new IndexOutOfRangeException();
	}

	internal void Add(SpawnPool spawnPool)
	{
		//IL_0053: Expected Obj, but got I
		if (ContainsKey(spawnPool.poolName))
		{
			GameObject gameObject = spawnPool.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, SYBO.Components.Utilities.SpawnPool>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S5_v4+4] (should have been resolved before IL gen)");
		PoolManager.TriggerPoolBalancing(spawnPool);
	}

	public void Add(string key, SpawnPool value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("SpawnPools add themselves to PoolManager.Pools when created, so there is no need to Add() them explicitly. Create pools using PoolManager.Pools.Create() or add a SpawnPool component to a GameObject.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	internal bool Remove(SpawnPool spawnPool)
	{
		//IL_0083: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		bool flag = ContainsKey(spawnPool.poolName);
		bool isPlaying = Application.isPlaying;
		object obj = (flag ? 1 : 0) ^ 1;
		object obj2 = isPlaying & obj;
		if ((nint)obj2 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		bool flag2 = _pools.Remove(spawnPool.poolName);
		return (byte)(obj2 ^ 1) != 0;
	}

	public bool Remove(string poolName)
	{
		//IL_0041: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("SpawnPools can only be destroyed, not removed and kept alive outside of PoolManager. There are only 2 legal ways to destroy a SpawnPool: Destroy the GameObject directly, if you have a reference, or use PoolManager.Destroy(string poolName).");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	public bool ContainsKey(string poolName)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, SYBO.Components.Utilities.SpawnPool>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public bool TryGetValue(string poolName, out SpawnPool spawnPool)
	{
		return _pools.TryGetValue(poolName, out spawnPool);
	}

	public bool Contains(KeyValuePair<string, SpawnPool> item)
	{
		//IL_0041: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Use PoolManager.Pools.Contains(string poolName) instead.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	public void Add(KeyValuePair<string, SpawnPool> item)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("SpawnPools add themselves to PoolManager.Pools when created, so there is no need to Add() them explicitly. Create pools using PoolManager.Pools.Create() or add a SpawnPool component to a GameObject.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public void Clear()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Use PoolManager.Pools.DestroyAll() instead.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("PoolManager.Pools cannot be copied");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	void ICollection<KeyValuePair<string, SpawnPool>>.CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("PoolManager.Pools cannot be copied");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public bool Remove(KeyValuePair<string, SpawnPool> item)
	{
		//IL_0041: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("SpawnPools can only be destroyed, not removed and kept alive outside of PoolManager. There are only 2 legal ways to destroy a SpawnPool: Destroy the GameObject directly, if you have a reference, or use PoolManager.Destroy(string poolName).");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		obj = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		IEnumerator<KeyValuePair<string, SpawnPool>> result = default;
		return result;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		obj = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		IEnumerator result = default;
		return result;
	}

	public SpawnPoolsDict()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, SYBO.Components.Utilities.SpawnPool>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, SpawnPool> pools = default;
		_pools = pools;
	}
}
