// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Pack2/DefeatMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Pack2/DefeatMessage.proto</summary>
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
public static partial class DefeatMessageReflection {

  #region Descriptor
  /// <summary>File descriptor for Pack2/DefeatMessage.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DefeatMessageReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlQYWNrMi9EZWZlYXRNZXNzYWdlLnByb3RvGhdQYWNrMi9CYWNrTWVzc2Fn",
          "ZS5wcm90bxoXUGFjazIvQ2FsbE1lc3NhZ2UucHJvdG8iogEKDURlZmVhdE1l",
          "c3NhZ2USIQoEdHlwZRgBIAEoDjITLkRlZmVhdE1lc3NhZ2UuVHlwZRIhCgtj",
          "YWxsTWVzc2FnZRgCIAEoCzIMLkNhbGxNZXNzYWdlEiEKC2JhY2tNZXNzYWdl",
          "GAMgASgLMgwuQmFja01lc3NhZ2UiKAoEVHlwZRIPCgtDYWxsTWVzc2FnZRAA",
          "Eg8KC0JhY2tNZXNzYWdlEAFiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BackMessageReflection.Descriptor, global::CallMessageReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::DefeatMessage), global::DefeatMessage.Parser, new[]{ "Type", "CallMessage", "BackMessage" }, null, new[]{ typeof(global::DefeatMessage.Types.Type) }, null)
        }));
  }
  #endregion

}
#region Messages
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
public sealed partial class DefeatMessage : pb::IMessage<DefeatMessage> {
  private static readonly pb::MessageParser<DefeatMessage> _parser = new pb::MessageParser<DefeatMessage>(() => new DefeatMessage());
  public static pb::MessageParser<DefeatMessage> Parser { get { return _parser; } }

  public static pbr::MessageDescriptor Descriptor {
    get { return global::DefeatMessageReflection.Descriptor.MessageTypes[0]; }
  }

  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  public DefeatMessage() {
    OnConstruction();
  }

  partial void OnConstruction();

  public DefeatMessage(DefeatMessage other) : this() {
    type_ = other.type_;
    CallMessage = other.callMessage_ != null ? other.CallMessage.Clone() : null;
    BackMessage = other.backMessage_ != null ? other.BackMessage.Clone() : null;
  }

  public DefeatMessage Clone() {
    return new DefeatMessage(this);
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 1;
  private global::DefeatMessage.Types.Type type_ = 0;
  public global::DefeatMessage.Types.Type Type {
    get { return type_; }
    set {
      type_ = value;
    }
  }

  /// <summary>Field number for the "callMessage" field.</summary>
  public const int CallMessageFieldNumber = 2;
  private global::CallMessage callMessage_;
  public global::CallMessage CallMessage {
    get { return callMessage_; }
    set {
      callMessage_ = value;
    }
  }

  /// <summary>Field number for the "backMessage" field.</summary>
  public const int BackMessageFieldNumber = 3;
  private global::BackMessage backMessage_;
  public global::BackMessage BackMessage {
    get { return backMessage_; }
    set {
      backMessage_ = value;
    }
  }

  public override bool Equals(object other) {
    return Equals(other as DefeatMessage);
  }

  public bool Equals(DefeatMessage other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Type != other.Type) return false;
    if (!object.Equals(CallMessage, other.CallMessage)) return false;
    if (!object.Equals(BackMessage, other.BackMessage)) return false;
    return true;
  }

  public override int GetHashCode() {
    int hash = 1;
    if (Type != 0) hash ^= Type.GetHashCode();
    if (callMessage_ != null) hash ^= CallMessage.GetHashCode();
    if (backMessage_ != null) hash ^= BackMessage.GetHashCode();
    return hash;
  }

  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  public void WriteTo(pb::CodedOutputStream output) {
    if (Type != 0) {
      output.WriteRawTag(8);
      output.WriteEnum((int) Type);
    }
    if (callMessage_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(CallMessage);
    }
    if (backMessage_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(BackMessage);
    }
  }

  public int CalculateSize() {
    int size = 0;
    if (Type != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
    }
    if (callMessage_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(CallMessage);
    }
    if (backMessage_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(BackMessage);
    }
    return size;
  }

  public void MergeFrom(DefeatMessage other) {
    if (other == null) {
      return;
    }
    if (other.Type != 0) {
      Type = other.Type;
    }
    if (other.callMessage_ != null) {
      if (callMessage_ == null) {
        callMessage_ = new global::CallMessage();
      }
      CallMessage.MergeFrom(other.CallMessage);
    }
    if (other.backMessage_ != null) {
      if (backMessage_ == null) {
        backMessage_ = new global::BackMessage();
      }
      BackMessage.MergeFrom(other.BackMessage);
    }
  }

  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          type_ = (global::DefeatMessage.Types.Type) input.ReadEnum();
          break;
        }
        case 18: {
          if (callMessage_ == null) {
            callMessage_ = new global::CallMessage();
          }
          input.ReadMessage(callMessage_);
          break;
        }
        case 26: {
          if (backMessage_ == null) {
            backMessage_ = new global::BackMessage();
          }
          input.ReadMessage(backMessage_);
          break;
        }
      }
    }
  }

  #region Nested types
  /// <summary>Container for nested types declared in the DefeatMessage message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Types {
    public enum Type {
      [pbr::OriginalName("CallMessage")] CallMessage = 0,
      [pbr::OriginalName("BackMessage")] BackMessage = 1,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
