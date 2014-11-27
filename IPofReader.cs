﻿using System;
using System.Collections.Generic;

namespace Dargon.PortableObjects
{
   public interface IPofReader
   {
      sbyte ReadS8(int slot);
      byte ReadU8(int slot);
      short ReadS16(int slot);
      ushort ReadU16(int slot);
      int ReadS32(int slot);
      uint ReadU32(int slot);
      long ReadS64(int slot);
      ulong ReadU64(int slot);
      float ReadFloat(int slot);
      double ReadDouble(int slot);
      char ReadChar(int slot);
      string ReadString(int slot);
      bool ReadBoolean(int slot);
      Guid ReadGuid(int slot);
      object ReadObject(int slot);
      T ReadObject<T>(int slot);
      T[] ReadArray<T>(int slot, bool elementsCovariant = false);
      TCollection ReadCollection<T, TCollection>(int slot, bool elementsCovariant = false) where TCollection : class, ICollection<T>, new();
      TCollection ReadCollection<T, TCollection>(int slot, TCollection collection, bool elementsCovariant = false) where TCollection : class, ICollection<T>;
      IDictionary<TKey, TValue> ReadMap<TKey, TValue>(int slot, bool keysCovariant = false, bool valuesCovariant = false, IDictionary<TKey, TValue> dict = null);
   }
}