// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyDescription.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/CompanyDescription.proto</summary>
  public static partial class CompanyDescriptionReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/CompanyDescription.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyDescriptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Qcm90b3MvQ29tcGFueURlc2NyaXB0aW9uLnByb3RvEhBDYXJlZXJDbG91",
            "ZC5nUlBDGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8iKQobQ29tcGFu",
            "eURlc2NyaXB0aW9uSWRSZXF1ZXN0EgoKAklkGAEgASgJInwKGUNvbXBhbnlE",
            "ZXNjcmlwdGlvblBheWxvYWQSCgoCSWQYASABKAkSDwoHQ29tcGFueRgCIAEo",
            "CRISCgpMYW5ndWFnZUlkGAMgASgJEhIKCkNvbWFueU5hbWUYBCABKAkSGgoS",
            "Q29tcGFueURlc2NyaXB0aW9uGAUgASgJMq0DChJDb21wYW55RGVzY3JpcHRp",
            "b24SdAoWUmVhZENvbXBhbnlEZXNjcmlwdGlvbhItLkNhcmVlckNsb3VkLmdS",
            "UEMuQ29tcGFueURlc2NyaXB0aW9uSWRSZXF1ZXN0GisuQ2FyZWVyQ2xvdWQu",
            "Z1JQQy5Db21wYW55RGVzY3JpcHRpb25QYXlsb2FkEl8KGENyZWF0ZUNvbXBh",
            "bnlEZXNjcmlwdGlvbhIrLkNhcmVlckNsb3VkLmdSUEMuQ29tcGFueURlc2Ny",
            "aXB0aW9uUGF5bG9hZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRJfChhVcGRh",
            "dGVDb21wYW55RGVzY3JpcHRpb24SKy5DYXJlZXJDbG91ZC5nUlBDLkNvbXBh",
            "bnlEZXNjcmlwdGlvblBheWxvYWQaFi5nb29nbGUucHJvdG9idWYuRW1wdHkS",
            "XwoYRGVsZXRlQ29tcGFueURlc2NyaXB0aW9uEisuQ2FyZWVyQ2xvdWQuZ1JQ",
            "Qy5Db21wYW55RGVzY3JpcHRpb25QYXlsb2FkGhYuZ29vZ2xlLnByb3RvYnVm",
            "LkVtcHR5QhqqAhdDYXJlZXJDbG91ZC5nUlBDLlByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyDescriptionIdRequest), global::CareerCloud.gRPC.Protos.CompanyDescriptionIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload), global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload.Parser, new[]{ "Id", "Company", "LanguageId", "ComanyName", "CompanyDescription" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompanyDescriptionIdRequest : pb::IMessage<CompanyDescriptionIdRequest> {
    private static readonly pb::MessageParser<CompanyDescriptionIdRequest> _parser = new pb::MessageParser<CompanyDescriptionIdRequest>(() => new CompanyDescriptionIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyDescriptionIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyDescriptionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptionIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptionIdRequest(CompanyDescriptionIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptionIdRequest Clone() {
      return new CompanyDescriptionIdRequest(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyDescriptionIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyDescriptionIdRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyDescriptionIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
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
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CompanyDescriptionPayload : pb::IMessage<CompanyDescriptionPayload> {
    private static readonly pb::MessageParser<CompanyDescriptionPayload> _parser = new pb::MessageParser<CompanyDescriptionPayload>(() => new CompanyDescriptionPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyDescriptionPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyDescriptionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptionPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptionPayload(CompanyDescriptionPayload other) : this() {
      id_ = other.id_;
      company_ = other.company_;
      languageId_ = other.languageId_;
      comanyName_ = other.comanyName_;
      companyDescription_ = other.companyDescription_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptionPayload Clone() {
      return new CompanyDescriptionPayload(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Company" field.</summary>
    public const int CompanyFieldNumber = 2;
    private string company_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Company {
      get { return company_; }
      set {
        company_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LanguageId" field.</summary>
    public const int LanguageIdFieldNumber = 3;
    private string languageId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LanguageId {
      get { return languageId_; }
      set {
        languageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ComanyName" field.</summary>
    public const int ComanyNameFieldNumber = 4;
    private string comanyName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ComanyName {
      get { return comanyName_; }
      set {
        comanyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CompanyDescription" field.</summary>
    public const int CompanyDescriptionFieldNumber = 5;
    private string companyDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CompanyDescription {
      get { return companyDescription_; }
      set {
        companyDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyDescriptionPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyDescriptionPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Company != other.Company) return false;
      if (LanguageId != other.LanguageId) return false;
      if (ComanyName != other.ComanyName) return false;
      if (CompanyDescription != other.CompanyDescription) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Company.Length != 0) hash ^= Company.GetHashCode();
      if (LanguageId.Length != 0) hash ^= LanguageId.GetHashCode();
      if (ComanyName.Length != 0) hash ^= ComanyName.GetHashCode();
      if (CompanyDescription.Length != 0) hash ^= CompanyDescription.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Company.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Company);
      }
      if (LanguageId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LanguageId);
      }
      if (ComanyName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ComanyName);
      }
      if (CompanyDescription.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CompanyDescription);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Company.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Company);
      }
      if (LanguageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageId);
      }
      if (ComanyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ComanyName);
      }
      if (CompanyDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CompanyDescription);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyDescriptionPayload other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Company.Length != 0) {
        Company = other.Company;
      }
      if (other.LanguageId.Length != 0) {
        LanguageId = other.LanguageId;
      }
      if (other.ComanyName.Length != 0) {
        ComanyName = other.ComanyName;
      }
      if (other.CompanyDescription.Length != 0) {
        CompanyDescription = other.CompanyDescription;
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
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Company = input.ReadString();
            break;
          }
          case 26: {
            LanguageId = input.ReadString();
            break;
          }
          case 34: {
            ComanyName = input.ReadString();
            break;
          }
          case 42: {
            CompanyDescription = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code