/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Gossiperl.Client.Thrift
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class DigestEnvelope : TBase
  {

    public string Payload_type { get; set; }

    public string Bin_payload { get; set; }

    public string Id { get; set; }

    public DigestEnvelope() {
    }

    public DigestEnvelope(string payload_type, string bin_payload, string id) : this() {
      this.Payload_type = payload_type;
      this.Bin_payload = bin_payload;
      this.Id = id;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_payload_type = false;
      bool isset_bin_payload = false;
      bool isset_id = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              Payload_type = iprot.ReadString();
              isset_payload_type = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Bin_payload = iprot.ReadString();
              isset_bin_payload = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Id = iprot.ReadString();
              isset_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_payload_type)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_bin_payload)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_id)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("DigestEnvelope");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "payload_type";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Payload_type);
      oprot.WriteFieldEnd();
      field.Name = "bin_payload";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Bin_payload);
      oprot.WriteFieldEnd();
      field.Name = "id";
      field.Type = TType.String;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Id);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("DigestEnvelope(");
      sb.Append("Payload_type: ");
      sb.Append(Payload_type);
      sb.Append(",Bin_payload: ");
      sb.Append(Bin_payload);
      sb.Append(",Id: ");
      sb.Append(Id);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
