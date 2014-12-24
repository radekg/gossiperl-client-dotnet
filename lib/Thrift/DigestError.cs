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
  public partial class DigestError : TBase
  {

    public string Name { get; set; }

    public long Heartbeat { get; set; }

    public int Error_code { get; set; }

    public string Error_entity { get; set; }

    public string Error_entity_name { get; set; }

    public string Error_message { get; set; }

    public string Reply_id { get; set; }

    public DigestError() {
    }

    public DigestError(string name, long heartbeat, int error_code, string error_entity, string error_entity_name, string error_message, string reply_id) : this() {
      this.Name = name;
      this.Heartbeat = heartbeat;
      this.Error_code = error_code;
      this.Error_entity = error_entity;
      this.Error_entity_name = error_entity_name;
      this.Error_message = error_message;
      this.Reply_id = reply_id;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_name = false;
      bool isset_heartbeat = false;
      bool isset_error_code = false;
      bool isset_error_entity = false;
      bool isset_error_entity_name = false;
      bool isset_error_message = false;
      bool isset_reply_id = false;
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
              Name = iprot.ReadString();
              isset_name = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I64) {
              Heartbeat = iprot.ReadI64();
              isset_heartbeat = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Error_code = iprot.ReadI32();
              isset_error_code = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Error_entity = iprot.ReadString();
              isset_error_entity = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              Error_entity_name = iprot.ReadString();
              isset_error_entity_name = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              Error_message = iprot.ReadString();
              isset_error_message = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              Reply_id = iprot.ReadString();
              isset_reply_id = true;
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
      if (!isset_name)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_heartbeat)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_error_code)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_error_entity)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_error_entity_name)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_error_message)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_reply_id)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("DigestError");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "name";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Name);
      oprot.WriteFieldEnd();
      field.Name = "heartbeat";
      field.Type = TType.I64;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteI64(Heartbeat);
      oprot.WriteFieldEnd();
      field.Name = "error_code";
      field.Type = TType.I32;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32(Error_code);
      oprot.WriteFieldEnd();
      field.Name = "error_entity";
      field.Type = TType.String;
      field.ID = 4;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Error_entity);
      oprot.WriteFieldEnd();
      field.Name = "error_entity_name";
      field.Type = TType.String;
      field.ID = 5;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Error_entity_name);
      oprot.WriteFieldEnd();
      field.Name = "error_message";
      field.Type = TType.String;
      field.ID = 6;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Error_message);
      oprot.WriteFieldEnd();
      field.Name = "reply_id";
      field.Type = TType.String;
      field.ID = 7;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Reply_id);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("DigestError(");
      sb.Append("Name: ");
      sb.Append(Name);
      sb.Append(",Heartbeat: ");
      sb.Append(Heartbeat);
      sb.Append(",Error_code: ");
      sb.Append(Error_code);
      sb.Append(",Error_entity: ");
      sb.Append(Error_entity);
      sb.Append(",Error_entity_name: ");
      sb.Append(Error_entity_name);
      sb.Append(",Error_message: ");
      sb.Append(Error_message);
      sb.Append(",Reply_id: ");
      sb.Append(Reply_id);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
