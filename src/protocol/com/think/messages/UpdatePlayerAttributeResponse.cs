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
  public partial class UpdatePlayerAttributeResponse : TBase
  {
    private byte _attribute_id;
    private int _attribute_value;
    private long _attribute_value_long;
    private string _attribute_str;

    public byte Attribute_id
    {
      get
      {
        return _attribute_id;
      }
      set
      {
        __isset.attribute_id = true;
        this._attribute_id = value;
      }
    }

    public int Attribute_value
    {
      get
      {
        return _attribute_value;
      }
      set
      {
        __isset.attribute_value = true;
        this._attribute_value = value;
      }
    }

    public long Attribute_value_long
    {
      get
      {
        return _attribute_value_long;
      }
      set
      {
        __isset.attribute_value_long = true;
        this._attribute_value_long = value;
      }
    }

    public string Attribute_str
    {
      get
      {
        return _attribute_str;
      }
      set
      {
        __isset.attribute_str = true;
        this._attribute_str = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool attribute_id;
      public bool attribute_value;
      public bool attribute_value_long;
      public bool attribute_str;
    }

    public UpdatePlayerAttributeResponse() {
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
              Attribute_id = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Attribute_value = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I64) {
              Attribute_value_long = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Attribute_str = iprot.ReadString();
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
      TStruct struc = new TStruct("UpdatePlayerAttributeResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.attribute_id) {
        field.Name = "attribute_id";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Attribute_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.attribute_value) {
        field.Name = "attribute_value";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Attribute_value);
        oprot.WriteFieldEnd();
      }
      if (__isset.attribute_value_long) {
        field.Name = "attribute_value_long";
        field.Type = TType.I64;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Attribute_value_long);
        oprot.WriteFieldEnd();
      }
      if (Attribute_str != null && __isset.attribute_str) {
        field.Name = "attribute_str";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Attribute_str);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("UpdatePlayerAttributeResponse(");
      sb.Append("Attribute_id: ");
      sb.Append(Attribute_id);
      sb.Append(",Attribute_value: ");
      sb.Append(Attribute_value);
      sb.Append(",Attribute_value_long: ");
      sb.Append(Attribute_value_long);
      sb.Append(",Attribute_str: ");
      sb.Append(Attribute_str);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
