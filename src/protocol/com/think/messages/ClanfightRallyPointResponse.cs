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
  public partial class ClanfightRallyPointResponse : TBase
  {
    private byte _rally_type;
    private short _targetPointId;
    private string _details;

    public byte Rally_type
    {
      get
      {
        return _rally_type;
      }
      set
      {
        __isset.rally_type = true;
        this._rally_type = value;
      }
    }

    public short TargetPointId
    {
      get
      {
        return _targetPointId;
      }
      set
      {
        __isset.targetPointId = true;
        this._targetPointId = value;
      }
    }

    public string Details
    {
      get
      {
        return _details;
      }
      set
      {
        __isset.details = true;
        this._details = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool rally_type;
      public bool targetPointId;
      public bool details;
    }

    public ClanfightRallyPointResponse() {
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
              Rally_type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I16) {
              TargetPointId = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Details = iprot.ReadString();
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
      TStruct struc = new TStruct("ClanfightRallyPointResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.rally_type) {
        field.Name = "rally_type";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Rally_type);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetPointId) {
        field.Name = "targetPointId";
        field.Type = TType.I16;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(TargetPointId);
        oprot.WriteFieldEnd();
      }
      if (Details != null && __isset.details) {
        field.Name = "details";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Details);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanfightRallyPointResponse(");
      sb.Append("Rally_type: ");
      sb.Append(Rally_type);
      sb.Append(",TargetPointId: ");
      sb.Append(TargetPointId);
      sb.Append(",Details: ");
      sb.Append(Details);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
