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
  public partial class DigestSubscribeAck : TBase
  {

    public long Heartbeat { get; set; }

    public string Reply_id { get; set; }

    public List<string> Event_types { get; set; }

    public DigestSubscribeAck() {
    }

    public DigestSubscribeAck(long heartbeat, string reply_id, List<string> event_types) : this() {
      this.Heartbeat = heartbeat;
      this.Reply_id = reply_id;
      this.Event_types = event_types;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_heartbeat = false;
      bool isset_reply_id = false;
      bool isset_event_types = false;
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
            if (field.Type == TType.I64) {
              Heartbeat = iprot.ReadI64();
              isset_heartbeat = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Reply_id = iprot.ReadString();
              isset_reply_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                Event_types = new List<string>();
                TList _list16 = iprot.ReadListBegin();
                for( int _i17 = 0; _i17 < _list16.Count; ++_i17)
                {
                  string _elem18 = null;
                  _elem18 = iprot.ReadString();
                  Event_types.Add(_elem18);
                }
                iprot.ReadListEnd();
              }
              isset_event_types = true;
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
      if (!isset_heartbeat)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_reply_id)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_event_types)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("DigestSubscribeAck");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "heartbeat";
      field.Type = TType.I64;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteI64(Heartbeat);
      oprot.WriteFieldEnd();
      field.Name = "reply_id";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Reply_id);
      oprot.WriteFieldEnd();
      field.Name = "event_types";
      field.Type = TType.List;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.String, Event_types.Count));
        foreach (string _iter19 in Event_types)
        {
          oprot.WriteString(_iter19);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("DigestSubscribeAck(");
      sb.Append("Heartbeat: ");
      sb.Append(Heartbeat);
      sb.Append(",Reply_id: ");
      sb.Append(Reply_id);
      sb.Append(",Event_types: ");
      sb.Append(Event_types);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
