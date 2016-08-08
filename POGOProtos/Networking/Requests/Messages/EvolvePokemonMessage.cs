// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/Messages/EvolvePokemonMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/EvolvePokemonMessage.proto</summary>
  public static partial class EvolvePokemonMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/EvolvePokemonMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvolvePokemonMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvRXZv",
            "bHZlUG9rZW1vbk1lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29ya2lu",
            "Zy5SZXF1ZXN0cy5NZXNzYWdlcyIqChRFdm9sdmVQb2tlbW9uTWVzc2FnZRIS",
            "Cgpwb2tlbW9uX2lkGAEgASgGYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.EvolvePokemonMessage), global::POGOProtos.Networking.Requests.Messages.EvolvePokemonMessage.Parser, new[]{ "PokemonId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvolvePokemonMessage : pb::IMessage<EvolvePokemonMessage> {
    private static readonly pb::MessageParser<EvolvePokemonMessage> _parser = new pb::MessageParser<EvolvePokemonMessage>(() => new EvolvePokemonMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EvolvePokemonMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.EvolvePokemonMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EvolvePokemonMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EvolvePokemonMessage(EvolvePokemonMessage other) : this() {
      pokemonId_ = other.pokemonId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EvolvePokemonMessage Clone() {
      return new EvolvePokemonMessage(this);
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 1;
    private ulong pokemonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EvolvePokemonMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EvolvePokemonMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PokemonId != other.PokemonId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PokemonId != 0UL) hash ^= PokemonId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PokemonId != 0UL) {
        output.WriteRawTag(9);
        output.WriteFixed64(PokemonId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PokemonId != 0UL) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EvolvePokemonMessage other) {
      if (other == null) {
        return;
      }
      if (other.PokemonId != 0UL) {
        PokemonId = other.PokemonId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 9: {
            PokemonId = input.ReadFixed64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
