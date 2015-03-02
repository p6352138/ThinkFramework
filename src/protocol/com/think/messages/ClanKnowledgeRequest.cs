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
  public partial class ClanKnowledgeRequest : TBase
  {
    private byte _reqType;
    private int _knowLedgeType;
    private byte _speedType;

    public byte ReqType
    {
      get
      {
        return _reqType;
      }
      set
      {
        __isset.reqType = true;
        this._reqType = value;
      }
    }

    public int KnowLedgeType
    {
      get
      {
        return _knowLedgeType;
      }
      set
      {
        __isset.knowLedgeType = true;
        this._knowLedgeType = value;
      }
    }

    public byte SpeedType
    {
      get
      {
        return _speedType;
      }
      set
      {
        __isset.speedType = true;
        this._speedType = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool reqType;
      public bool knowLedgeType;
      public bool speedType;
    }

    public ClanKnowledgeRequest() {
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
              ReqType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              KnowLedgeType = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              SpeedType = iprot.ReadByte();
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
      TStruct struc = new TStruct("ClanKnowledgeRequest");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.reqType) {
        field.Name = "reqType";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(ReqType);
        oprot.WriteFieldEnd();
      }
      if (__isset.knowLedgeType) {
        field.Name = "knowLedgeType";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(KnowLedgeType);
        oprot.WriteFieldEnd();
      }
      if (__isset.speedType) {
        field.Name = "speedType";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(SpeedType);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanKnowledgeRequest(");
      sb.Append("ReqType: ");
      sb.Append(ReqType);
      sb.Append(",KnowLedgeType: ");
      sb.Append(KnowLedgeType);
      sb.Append(",SpeedType: ");
      sb.Append(SpeedType);
      sb.Append(")");
      return sb.ToString();
    }

  }

}