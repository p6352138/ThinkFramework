/**
 * Autogenerated by Thrift Compiler (0.8.0)
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
using Thrift.Protocol;
using Thrift.Transport;
namespace com.think.messages
{

  [Serializable]
  public partial class OprationNotifyResponse : TBase
  {
    private int _opration_id;
    private byte _state;
    private byte _sequence;

    public int Opration_id
    {
      get
      {
        return _opration_id;
      }
      set
      {
        __isset.opration_id = true;
        this._opration_id = value;
      }
    }

    public byte State
    {
      get
      {
        return _state;
      }
      set
      {
        __isset.state = true;
        this._state = value;
      }
    }

    public byte Sequence
    {
      get
      {
        return _sequence;
      }
      set
      {
        __isset.sequence = true;
        this._sequence = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool opration_id;
      public bool state;
      public bool sequence;
    }

    public OprationNotifyResponse() {
    }

    public void Read (TProtocol iprot)
    {
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
            if (field.Type == TType.I32) {
              Opration_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Byte) {
              State = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              Sequence = iprot.ReadByte();
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
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("OprationNotifyResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.opration_id) {
        field.Name = "opration_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Opration_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.state) {
        field.Name = "state";
        field.Type = TType.Byte;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(State);
        oprot.WriteFieldEnd();
      }
      if (__isset.sequence) {
        field.Name = "sequence";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Sequence);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("OprationNotifyResponse(");
      sb.Append("Opration_id: ");
      sb.Append(Opration_id);
      sb.Append(",State: ");
      sb.Append(State);
      sb.Append(",Sequence: ");
      sb.Append(Sequence);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
