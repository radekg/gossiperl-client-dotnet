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
  public partial class DigestSubscribe : TBase
  {

    public string Name { get; set; }

    public long Heartbeat { get; set; }

    public string Id { get; set; }

    public List<string> Event_types { get; set; }

    public string Secret { get; set; }

    public DigestSubscribe() {
    }

    public DigestSubscribe(string name, long heartbeat, string id, List<string> event_types, string secret) : this() {
      this.Name = name;
      this.Heartbeat = heartbeat;
      this.Id = id;
      this.Event_types = event_types;
      this.Secret = secret;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_name = false;
      bool isset_heartbeat = false;
      bool isset_id = false;
      bool isset_event_types = false;
      bool isset_secret = false;
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
            if (field.Type == TType.String) {
              Id = iprot.ReadString();
              isset_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                Event_types = new List<string>();
                TList _list8 = iprot.ReadListBegin();
                for( int _i9 = 0; _i9 < _list8.Count; ++_i9)
                {
                  string _elem10 = null;
                  _elem10 = iprot.ReadString();
                  Event_types.Add(_elem10);
                }
                iprot.ReadListEnd();
              }
              isset_event_types = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              Secret = iprot.ReadString();
              isset_secret = true;
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
      if (!isset_id)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_event_types)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_secret)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("DigestSubscribe");
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
      field.Name = "id";
      field.Type = TType.String;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Id);
      oprot.WriteFieldEnd();
      field.Name = "event_types";
      field.Type = TType.List;
      field.ID = 4;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.String, Event_types.Count));
        foreach (string _iter11 in Event_types)
        {
          oprot.WriteString(_iter11);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
      field.Name = "secret";
      field.Type = TType.String;
      field.ID = 5;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Secret);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("DigestSubscribe(");
      sb.Append("Name: ");
      sb.Append(Name);
      sb.Append(",Heartbeat: ");
      sb.Append(Heartbeat);
      sb.Append(",Id: ");
      sb.Append(Id);
      sb.Append(",Event_types: ");
      sb.Append(Event_types);
      sb.Append(",Secret: ");
      sb.Append(Secret);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
