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
  public partial class PickPeachResponse : TBase
  {
    private int _id;
    private string _name;
    private int _requiredLevel;
    private int _award_exp;
    private int _surplus_num;
    private int _invite_consume;
    private int _strategy_icon;
    private int _next_award_exp;
    private int _invite_num;
    private byte _is_upgrade;

    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
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

    public int RequiredLevel
    {
      get
      {
        return _requiredLevel;
      }
      set
      {
        __isset.requiredLevel = true;
        this._requiredLevel = value;
      }
    }

    public int Award_exp
    {
      get
      {
        return _award_exp;
      }
      set
      {
        __isset.award_exp = true;
        this._award_exp = value;
      }
    }

    public int Surplus_num
    {
      get
      {
        return _surplus_num;
      }
      set
      {
        __isset.surplus_num = true;
        this._surplus_num = value;
      }
    }

    public int Invite_consume
    {
      get
      {
        return _invite_consume;
      }
      set
      {
        __isset.invite_consume = true;
        this._invite_consume = value;
      }
    }

    public int Strategy_icon
    {
      get
      {
        return _strategy_icon;
      }
      set
      {
        __isset.strategy_icon = true;
        this._strategy_icon = value;
      }
    }

    public int Next_award_exp
    {
      get
      {
        return _next_award_exp;
      }
      set
      {
        __isset.next_award_exp = true;
        this._next_award_exp = value;
      }
    }

    public int Invite_num
    {
      get
      {
        return _invite_num;
      }
      set
      {
        __isset.invite_num = true;
        this._invite_num = value;
      }
    }

    public byte Is_upgrade
    {
      get
      {
        return _is_upgrade;
      }
      set
      {
        __isset.is_upgrade = true;
        this._is_upgrade = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool id;
      public bool name;
      public bool requiredLevel;
      public bool award_exp;
      public bool surplus_num;
      public bool invite_consume;
      public bool strategy_icon;
      public bool next_award_exp;
      public bool invite_num;
      public bool is_upgrade;
    }

    public PickPeachResponse() {
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
              Id = iprot.ReadI32();
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
              RequiredLevel = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Award_exp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Surplus_num = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Invite_consume = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              Strategy_icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              Next_award_exp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              Invite_num = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Byte) {
              Is_upgrade = iprot.ReadByte();
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
      TStruct struc = new TStruct("PickPeachResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
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
      if (__isset.requiredLevel) {
        field.Name = "requiredLevel";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(RequiredLevel);
        oprot.WriteFieldEnd();
      }
      if (__isset.award_exp) {
        field.Name = "award_exp";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Award_exp);
        oprot.WriteFieldEnd();
      }
      if (__isset.surplus_num) {
        field.Name = "surplus_num";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Surplus_num);
        oprot.WriteFieldEnd();
      }
      if (__isset.invite_consume) {
        field.Name = "invite_consume";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Invite_consume);
        oprot.WriteFieldEnd();
      }
      if (__isset.strategy_icon) {
        field.Name = "strategy_icon";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Strategy_icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.next_award_exp) {
        field.Name = "next_award_exp";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Next_award_exp);
        oprot.WriteFieldEnd();
      }
      if (__isset.invite_num) {
        field.Name = "invite_num";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Invite_num);
        oprot.WriteFieldEnd();
      }
      if (__isset.is_upgrade) {
        field.Name = "is_upgrade";
        field.Type = TType.Byte;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Is_upgrade);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PickPeachResponse(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",RequiredLevel: ");
      sb.Append(RequiredLevel);
      sb.Append(",Award_exp: ");
      sb.Append(Award_exp);
      sb.Append(",Surplus_num: ");
      sb.Append(Surplus_num);
      sb.Append(",Invite_consume: ");
      sb.Append(Invite_consume);
      sb.Append(",Strategy_icon: ");
      sb.Append(Strategy_icon);
      sb.Append(",Next_award_exp: ");
      sb.Append(Next_award_exp);
      sb.Append(",Invite_num: ");
      sb.Append(Invite_num);
      sb.Append(",Is_upgrade: ");
      sb.Append(Is_upgrade);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
