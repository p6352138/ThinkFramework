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
  public partial class NewCrossWeedOutPlayerResponse : TBase
  {
    private long _user_id;
    private int _icon;
    private string _userName;
    private int _fighting_capacity;

    public long User_id
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

    public string UserName
    {
      get
      {
        return _userName;
      }
      set
      {
        __isset.userName = true;
        this._userName = value;
      }
    }

    public int Fighting_capacity
    {
      get
      {
        return _fighting_capacity;
      }
      set
      {
        __isset.fighting_capacity = true;
        this._fighting_capacity = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool user_id;
      public bool icon;
      public bool userName;
      public bool fighting_capacity;
    }

    public NewCrossWeedOutPlayerResponse() {
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
            if (field.Type == TType.I64) {
              User_id = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              UserName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Fighting_capacity = iprot.ReadI32();
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
      TStruct struc = new TStruct("NewCrossWeedOutPlayerResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.user_id) {
        field.Name = "user_id";
        field.Type = TType.I64;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(User_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Icon);
        oprot.WriteFieldEnd();
      }
      if (UserName != null && __isset.userName) {
        field.Name = "userName";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(UserName);
        oprot.WriteFieldEnd();
      }
      if (__isset.fighting_capacity) {
        field.Name = "fighting_capacity";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fighting_capacity);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("NewCrossWeedOutPlayerResponse(");
      sb.Append("User_id: ");
      sb.Append(User_id);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",UserName: ");
      sb.Append(UserName);
      sb.Append(",Fighting_capacity: ");
      sb.Append(Fighting_capacity);
      sb.Append(")");
      return sb.ToString();
    }

  }

}