// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace nd4j.graph
{

using global::System;
using global::FlatBuffers;

public struct UIEvent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static UIEvent GetRootAsUIEvent(ByteBuffer _bb) { return GetRootAsUIEvent(_bb, new UIEvent()); }
  public static UIEvent GetRootAsUIEvent(ByteBuffer _bb, UIEvent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public UIEvent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public UIEventType EventType { get { int o = __p.__offset(4); return o != 0 ? (UIEventType)__p.bb.GetSbyte(o + __p.bb_pos) : UIEventType.ADD_NAME; } }
  public UIEventSubtype EventSubType { get { int o = __p.__offset(6); return o != 0 ? (UIEventSubtype)__p.bb.GetSbyte(o + __p.bb_pos) : UIEventSubtype.NONE; } }
  public int NameIdx { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long Timestamp { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Iteration { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Epoch { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public short VariableId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public FrameIteration? FrameIter { get { int o = __p.__offset(18); return o != 0 ? (FrameIteration?)(new FrameIteration()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public ushort Plugin { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }

  public static Offset<UIEvent> CreateUIEvent(FlatBufferBuilder builder,
      UIEventType eventType = UIEventType.ADD_NAME,
      UIEventSubtype eventSubType = UIEventSubtype.NONE,
      int nameIdx = 0,
      long timestamp = 0,
      int iteration = 0,
      int epoch = 0,
      short variableId = 0,
      Offset<FrameIteration> frameIterOffset = default(Offset<FrameIteration>),
      ushort plugin = 0) {
    builder.StartObject(9);
    UIEvent.AddTimestamp(builder, timestamp);
    UIEvent.AddFrameIter(builder, frameIterOffset);
    UIEvent.AddEpoch(builder, epoch);
    UIEvent.AddIteration(builder, iteration);
    UIEvent.AddNameIdx(builder, nameIdx);
    UIEvent.AddPlugin(builder, plugin);
    UIEvent.AddVariableId(builder, variableId);
    UIEvent.AddEventSubType(builder, eventSubType);
    UIEvent.AddEventType(builder, eventType);
    return UIEvent.EndUIEvent(builder);
  }

  public static void StartUIEvent(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddEventType(FlatBufferBuilder builder, UIEventType eventType) { builder.AddSbyte(0, (sbyte)eventType, 0); }
  public static void AddEventSubType(FlatBufferBuilder builder, UIEventSubtype eventSubType) { builder.AddSbyte(1, (sbyte)eventSubType, 0); }
  public static void AddNameIdx(FlatBufferBuilder builder, int nameIdx) { builder.AddInt(2, nameIdx, 0); }
  public static void AddTimestamp(FlatBufferBuilder builder, long timestamp) { builder.AddLong(3, timestamp, 0); }
  public static void AddIteration(FlatBufferBuilder builder, int iteration) { builder.AddInt(4, iteration, 0); }
  public static void AddEpoch(FlatBufferBuilder builder, int epoch) { builder.AddInt(5, epoch, 0); }
  public static void AddVariableId(FlatBufferBuilder builder, short variableId) { builder.AddShort(6, variableId, 0); }
  public static void AddFrameIter(FlatBufferBuilder builder, Offset<FrameIteration> frameIterOffset) { builder.AddOffset(7, frameIterOffset.Value, 0); }
  public static void AddPlugin(FlatBufferBuilder builder, ushort plugin) { builder.AddUshort(8, plugin, 0); }
  public static Offset<UIEvent> EndUIEvent(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<UIEvent>(o);
  }
};


}
