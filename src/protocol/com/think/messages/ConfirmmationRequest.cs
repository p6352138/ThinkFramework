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
  public partial class ConfirmmationRequest : TBase
  {
    private byte _type;
    private bool _ischecked;
    private int _targetID;

    public byte Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public bool Ischecked
    {
      get
      {
        return _ischecked;
      }
      set
      {
        __isset.ischecked = true;
        this._ischecked = value;
      }
    }

    public int TargetID
    {
      get
      {
        return _targetID;
      }
      set
      {
        __isset.targetID = true;
        this._targetID = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool type;
      public bool ischecked;
      public bool targetID;
    }

    public ConfirmmationRequest() {
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
            if (field.Type == TType.Byte) {
              Type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Bool) {
              Ischecked = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              TargetID = iprot.ReadI32();
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
      TStruct struc = new TStruct("ConfirmmationRequest");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Type);
        oprot.WriteFieldEnd();
      }
      if (__isset.ischecked) {
        field.Name = "ischecked";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Ischecked);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetID) {
        field.Name = "targetID";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TargetID);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ConfirmmationRequest(");
      sb.Append("Type: ");
      sb.Append(Type);
      sb.Append(",Ischecked: ");
      sb.Append(Ischecked);
      sb.Append(",TargetID: ");
      sb.Append(TargetID);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
