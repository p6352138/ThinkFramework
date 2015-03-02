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
  public partial class QueryPlayerDetailRequest : TBase
  {
    private byte _type;
    private int _user_id;
    private int _generalId;
    private long _user_id_long;

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

    public int User_id
    {
      get
      {
        return _user_id;
      }
      set
      {
        __isset.user_id = true;
        this._user_id = value;
      }
    }

    public int GeneralId
    {
      get
      {
        return _generalId;
      }
      set
      {
        __isset.generalId = true;
        this._generalId = value;
      }
    }

    public long User_id_long
    {
      get
      {
        return _user_id_long;
      }
      set
      {
        __isset.user_id_long = true;
        this._user_id_long = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool type;
      public bool user_id;
      public bool generalId;
      public bool user_id_long;
    }

    public QueryPlayerDetailRequest() {
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
            if (field.Type == TType.I32) {
              User_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              GeneralId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I64) {
              User_id_long = iprot.ReadI64();
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
      TStruct struc = new TStruct("QueryPlayerDetailRequest");
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
      if (__isset.user_id) {
        field.Name = "user_id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(User_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.generalId) {
        field.Name = "generalId";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(GeneralId);
        oprot.WriteFieldEnd();
      }
      if (__isset.user_id_long) {
        field.Name = "user_id_long";
        field.Type = TType.I64;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(User_id_long);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("QueryPlayerDetailRequest(");
      sb.Append("Type: ");
      sb.Append(Type);
      sb.Append(",User_id: ");
      sb.Append(User_id);
      sb.Append(",GeneralId: ");
      sb.Append(GeneralId);
      sb.Append(",User_id_long: ");
      sb.Append(User_id_long);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
