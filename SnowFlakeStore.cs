using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace UnityTools
{
    // public class SnowFlakeStore<T> 
    //
    // {
    // private const int SlotCount = 22, //4M cocurrent Items
    //     ReuseCount = 10; //1024 repetions
    //
    // private object[] _arr = new object[1 << SlotCount];
    // private ushort[] currentIter = new ushort[1 << SlotCount];
    // private const int alivenessBit = 15, DeadBit = 10;
    // private List<uint> Recycle = new List<uint>();
    // public void Clear()
    // {
    //     _arr = new object[1 << SlotCount];
    //     currentIter = new ushort[1 << SlotCount];
    //     Recycle = new List<uint>();
    // }
    //
    // public bool Contains(uint key) => GetSlotLive(getSlot(key));  
    //
    // public void Remove(uint key)
    // {
    //     currentIter[getSlot(key)]++;
    //     if (!GetSlotDead(getSlot(key)))
    //     {
    //         Recycle.Add(getSlot(key));
    //         currentIter[getSlot(key)] &= 0b0111111111111111;
    //         _arr[getSlot(key)] = null;
    //     }
    //     else
    //     {
    //         currentIter[getSlot(key)] =  0b0111111111111111;
    //         
    //     }
    // }
    //
    //
    // public uint Put(T item)
    // {
    //     throw new NotImplementedException();
    // }
    //
    // public T this[uint index]
    // {
    //     get
    //     {
    //         if (getIter(index) == GetSlotIter(getSlot(index))&&GetSlotLive(getSlot(index)))
    //             return (T) _arr[index & (uint.MaxValue >> ReuseCount)];
    //         throw new Exception("Key Outdated");
    //     }
    //     set
    //     {
    //         if (GetSlotLive(getSlot(index)))
    //         {
    //             _arr[getSlot(index)] = value;
    //         }
    //
    //         throw new Exception("Key Not Initialized");
    //     }
    // }
    //
    //
    // [MethodImpl(MethodImplOptions.AggressiveInlining)][Pure] uint getSlot(uint key) => (key & (uint.MaxValue >> ReuseCount));
    // [MethodImpl(MethodImplOptions.AggressiveInlining)][Pure] uint getIter(uint key) => (key >> SlotCount);
    //
    // [MethodImpl(MethodImplOptions.AggressiveInlining)][Pure] ushort GetSlotIter(uint slot) => (ushort)((currentIter[slot] << 1) >> 1);
    // [MethodImpl(MethodImplOptions.AggressiveInlining)][Pure] bool GetSlotLive(uint slot) => 1==(currentIter[slot]>>15);
    // [MethodImpl(MethodImplOptions.AggressiveInlining)][Pure] bool GetSlotDead(uint slot) => 0!=(currentIter[slot]&1<<DeadBit);
    //
    //
    // }
    //
    //
    //
    // public class EntityManager
    // {
    //     List<byte> _generation;
    //     Queue<uint> _free_indices;
    //
    //
    //     
    //     public Entity create()
    //     {
    //         uint idx;
    //         if (_free_indices.Count > MINIMUM_FREE_INDICES) {
    //             idx = _free_indices.Peek();
    //             _free_indices.Dequeue();
    //         } else {
    //             _generation.Add(0);
    //             idx = (uint)_generation.Count - 1;
    //             if (idx < (1 << (int) ENTITY_INDEX_BITS))
    //             {
    //                 throw new IndexOutOfRangeException();
    //             }
    //         }
    //         return make_entity(idx, _generation[(int)idx]);
    //     }
    //
    //     private Entity make_entity(uint index, byte gen)
    //     {
    //         return new Entity() {id = (uint) (gen << ENTITY_INDEX_BITS) + (index)};
    //     }
    //
    //     private const uint MINIMUM_FREE_INDICES = 1024;
    //
    //     public bool alive(Entity e) 
    //     {
    //         return _generation[(int)e.index()] == e.generation();
    //     }
    //
    //     public void destroy(Entity e)
    //     {
    //          uint idx = e.index();
    //         ++_generation[(int)idx];
    //         _free_indices.Enqueue(idx);
    //     }
    //     
    //     const int ENTITY_INDEX_BITS = 22;
    //     const uint ENTITY_INDEX_MASK = (uint)(1<<(int)ENTITY_INDEX_BITS)-1;
    //
    //     const int ENTITY_GENERATION_BITS = 8;
    //     const uint ENTITY_GENERATION_MASK = (1<<(int)ENTITY_GENERATION_BITS)-1;
    //
    //     public struct Entity
    //     {
    //         public uint id;
    //
    //         public uint index() => id & ENTITY_INDEX_MASK;
    //         public uint generation() => (id >> (int)ENTITY_INDEX_BITS) & ENTITY_GENERATION_MASK;
    //     };
    // }
    //
    
    
}