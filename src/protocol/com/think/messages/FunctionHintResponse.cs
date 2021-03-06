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
  public partial class FunctionHintResponse : TBase
  {
    private int _function_id;
    private byte _function_type;
    private string _u_id;
    private string _hint_info;
    private int _icon;
    private string _hint_name;

    public int Function_id
    {
      get
      {
        return _function_id;
      }
      set
      {
        __isset.function_id = true;
        this._function_id = value;
      }
    }

    public byte Function_type
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

    public string U_id
    {
      get
      {
        return _u_id;
      }
      set
      {
        __isset.u_id = true;
        this._u_id = value;
      }
    }

    public string Hint_info
    {
      get
      {
        return _hint_info;
      }
      set
      {
        __isset.hint_info = true;
        this._hint_info = value;
      }
    }

    public int Icon
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

    public string Hint_name
    {
      get
      {
        return _hint_name;
      }
      set
      {
        __isset.hint_name = true;
        this._hint_name = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool function_id;
      public bool function_type;
      public bool u_id;
      public bool hint_info;
      public bool icon;
      public bool hint_name;
    }

    public FunctionHintResponse() {
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
              Function_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Byte) {
              Function_type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              U_id = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Hint_info = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              Hint_name = iprot.ReadString();
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
      TStruct struc = new TStruct("FunctionHintResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.function_id) {
        field.Name = "function_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Function_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.function_type) {
        field.Name = "function_type";
        field.Type = TType.Byte;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Function_type);
        oprot.WriteFieldEnd();
      }
      if (U_id != null && __isset.u_id) {
        field.Name = "u_id";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(U_id);
        oprot.WriteFieldEnd();
      }
      if (Hint_info != null && __isset.hint_info) {
        field.Name = "hint_info";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Hint_info);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Icon);
        oprot.WriteFieldEnd();
      }
      if (Hint_name != null && __isset.hint_name) {
        field.Name = "hint_name";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Hint_name);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("FunctionHintResponse(");
      sb.Append("Function_id: ");
      sb.Append(Function_id);
      sb.Append(",Function_type: ");
      sb.Append(Function_type);
      sb.Append(",U_id: ");
      sb.Append(U_id);
      sb.Append(",Hint_info: ");
      sb.Append(Hint_info);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",Hint_name: ");
      sb.Append(Hint_name);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
