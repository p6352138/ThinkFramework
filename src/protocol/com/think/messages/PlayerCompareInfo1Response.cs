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
  public partial class PlayerCompareInfo1Response : TBase
  {
    private int _user_id;
    private string _name;
    private int _fighting_capacity;
    private int _initiative;
    private int _icon;
    private long _user_id_long;

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

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
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

    public int Initiative
    {
      get
      {
        return _initiative;
      }
      set
      {
        __isset.initiative = true;
        this._initiative = value;
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
      public bool user_id;
      public bool name;
      public bool fighting_capacity;
      public bool initiative;
      public bool icon;
      public bool user_id_long;
    }

    public PlayerCompareInfo1Response() {
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
              User_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Fighting_capacity = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Initiative = iprot.ReadI32();
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
      TStruct struc = new TStruct("PlayerCompareInfo1Response");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.user_id) {
        field.Name = "user_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(User_id);
        oprot.WriteFieldEnd();
      }
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (__isset.fighting_capacity) {
        field.Name = "fighting_capacity";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fighting_capacity);
        oprot.WriteFieldEnd();
      }
      if (__isset.initiative) {
        field.Name = "initiative";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Initiative);
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
      if (__isset.user_id_long) {
        field.Name = "user_id_long";
        field.Type = TType.I64;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(User_id_long);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerCompareInfo1Response(");
      sb.Append("User_id: ");
      sb.Append(User_id);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",Fighting_capacity: ");
      sb.Append(Fighting_capacity);
      sb.Append(",Initiative: ");
      sb.Append(Initiative);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",User_id_long: ");
      sb.Append(User_id_long);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
