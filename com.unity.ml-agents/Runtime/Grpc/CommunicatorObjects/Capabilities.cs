// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents_envs/communicator_objects/capabilities.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Unity.MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents_envs/communicator_objects/capabilities.proto</summary>
  internal static partial class CapabilitiesReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents_envs/communicator_objects/capabilities.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CapabilitiesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVtbGFnZW50c19lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL2NhcGFiaWxp",
            "dGllcy5wcm90bxIUY29tbXVuaWNhdG9yX29iamVjdHMiNgoYVW5pdHlSTENh",
            "cGFiaWxpdGllc1Byb3RvEhoKEmJhc2VSTENhcGFiaWxpdGllcxgBIAEoCEIl",
            "qgIiVW5pdHkuTUxBZ2VudHMuQ29tbXVuaWNhdG9yT2JqZWN0c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Unity.MLAgents.CommunicatorObjects.UnityRLCapabilitiesProto), global::Unity.MLAgents.CommunicatorObjects.UnityRLCapabilitiesProto.Parser, new[]{ "BaseRLCapabilities" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  /// A Capabilities message that will communicate both C# and Python
  /// what features are available to both.
  /// </summary>
  internal sealed partial class UnityRLCapabilitiesProto : pb::IMessage<UnityRLCapabilitiesProto> {
    private static readonly pb::MessageParser<UnityRLCapabilitiesProto> _parser = new pb::MessageParser<UnityRLCapabilitiesProto>(() => new UnityRLCapabilitiesProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnityRLCapabilitiesProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Unity.MLAgents.CommunicatorObjects.CapabilitiesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLCapabilitiesProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLCapabilitiesProto(UnityRLCapabilitiesProto other) : this() {
      baseRLCapabilities_ = other.baseRLCapabilities_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLCapabilitiesProto Clone() {
      return new UnityRLCapabilitiesProto(this);
    }

    /// <summary>Field number for the "baseRLCapabilities" field.</summary>
    public const int BaseRLCapabilitiesFieldNumber = 1;
    private bool baseRLCapabilities_;
    /// <summary>
    /// These are the 1.0 capabilities.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool BaseRLCapabilities {
      get { return baseRLCapabilities_; }
      set {
        baseRLCapabilities_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnityRLCapabilitiesProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnityRLCapabilitiesProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BaseRLCapabilities != other.BaseRLCapabilities) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BaseRLCapabilities != false) hash ^= BaseRLCapabilities.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BaseRLCapabilities != false) {
        output.WriteRawTag(8);
        output.WriteBool(BaseRLCapabilities);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BaseRLCapabilities != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnityRLCapabilitiesProto other) {
      if (other == null) {
        return;
      }
      if (other.BaseRLCapabilities != false) {
        BaseRLCapabilities = other.BaseRLCapabilities;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            BaseRLCapabilities = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
