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
  public partial class WarningResponse : TBase
  {
    private byte _type;
    private string _warningContent;
    private string _icon;
    private short _function_type;
    private bool _self_closing;

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

    public string WarningContent
    {
      get
      {
        return _warningContent;
      }
      set
      {
        __isset.warningContent = true;
        this._warningContent = value;
      }
    }

    public string Icon
    {
      get
      {
        return _icon;
      }
      set
      {
        __isset.icon = true;
        this._icon = value;
      }
    }

    public short Function_type
    {
      get
      {
        return _function_type;
      }
      set
      {
        __isset.function_type = true;
        this._function_type = value;
      }
    }

    public bool Self_closing
    {
      get
      {
        return _self_closing;
      }
      set
      {
        __isset.self_closing = true;
        this._self_closing = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool type;
      public bool warningContent;
      public bool icon;
      public bool function_type;
      public bool self_closing;
    }

    public WarningResponse() {
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
            if (field.Type == TType.String) {
              WarningContent = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Icon = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I16) {
              Function_type = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Bool) {
              Self_closing = iprot.ReadBool();
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
      TStruct struc = new TStruct("WarningResponse");
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
      if (WarningContent != null && __isset.warningContent) {
        field.Name = "warningContent";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(WarningContent);
        oprot.WriteFieldEnd();
      }
      if (Icon != null && __isset.icon) {
        field.Name = "icon";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.function_type) {
        field.Name = "function_type";
        field.Type = TType.I16;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Function_type);
        oprot.WriteFieldEnd();
      }
      if (__isset.self_closing) {
        field.Name = "self_closing";
        field.Type = TType.Bool;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Self_closing);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("WarningResponse(");
      sb.Append("Type: ");
      sb.Append(Type);
      sb.Append(",WarningContent: ");
      sb.Append(WarningContent);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",Function_type: ");
      sb.Append(Function_type);
      sb.Append(",Self_closing: ");
      sb.Append(Self_closing);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
