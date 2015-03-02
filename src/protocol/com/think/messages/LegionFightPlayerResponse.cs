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
  public partial class LegionFightPlayerResponse : TBase
  {
    private int _role_instance_id;
    private string _role_name;
    private int _icon;
    private short _category;
    private int _maxHp;
    private byte _maxWinningStreak;
    private byte _winningStreak;
    private short _role_lvl;
    private string _award;

    public int Role_instance_id
    {
      get
      {
        return _role_instance_id;
      }
      set
      {
        __isset.role_instance_id = true;
        this._role_instance_id = value;
      }
    }

    public string Role_name
    {
      get
      {
        return _role_name;
      }
      set
      {
        __isset.role_name = true;
        this._role_name = value;
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

    public short Category
    {
      get
      {
        return _category;
      }
      set
      {
        __isset.category = true;
        this._category = value;
      }
    }

    public int MaxHp
    {
      get
      {
        return _maxHp;
      }
      set
      {
        __isset.maxHp = true;
        this._maxHp = value;
      }
    }

    public byte MaxWinningStreak
    {
      get
      {
        return _maxWinningStreak;
      }
      set
      {
        __isset.maxWinningStreak = true;
        this._maxWinningStreak = value;
      }
    }

    public byte WinningStreak
    {
      get
      {
        return _winningStreak;
      }
      set
      {
        __isset.winningStreak = true;
        this._winningStreak = value;
      }
    }

    public short Role_lvl
    {
      get
      {
        return _role_lvl;
      }
      set
      {
        __isset.role_lvl = true;
        this._role_lvl = value;
      }
    }

    public string Award
    {
      get
      {
        return _award;
      }
      set
      {
        __isset.award = true;
        this._award = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool role_instance_id;
      public bool role_name;
      public bool icon;
      public bool category;
      public bool maxHp;
      public bool maxWinningStreak;
      public bool winningStreak;
      public bool role_lvl;
      public bool award;
    }

    public LegionFightPlayerResponse() {
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
              Role_instance_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Role_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I16) {
              Category = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              MaxHp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Byte) {
              MaxWinningStreak = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Byte) {
              WinningStreak = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I16) {
              Role_lvl = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              Award = iprot.ReadString();
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
      TStruct struc = new TStruct("LegionFightPlayerResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.role_instance_id) {
        field.Name = "role_instance_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Role_instance_id);
        oprot.WriteFieldEnd();
      }
      if (Role_name != null && __isset.role_name) {
        field.Name = "role_name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Role_name);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.category) {
        field.Name = "category";
        field.Type = TType.I16;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Category);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxHp) {
        field.Name = "maxHp";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxHp);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxWinningStreak) {
        field.Name = "maxWinningStreak";
        field.Type = TType.Byte;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(MaxWinningStreak);
        oprot.WriteFieldEnd();
      }
      if (__isset.winningStreak) {
        field.Name = "winningStreak";
        field.Type = TType.Byte;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(WinningStreak);
        oprot.WriteFieldEnd();
      }
      if (__isset.role_lvl) {
        field.Name = "role_lvl";
        field.Type = TType.I16;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Role_lvl);
        oprot.WriteFieldEnd();
      }
      if (Award != null && __isset.award) {
        field.Name = "award";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Award);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("LegionFightPlayerResponse(");
      sb.Append("Role_instance_id: ");
      sb.Append(Role_instance_id);
      sb.Append(",Role_name: ");
      sb.Append(Role_name);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",Category: ");
      sb.Append(Category);
      sb.Append(",MaxHp: ");
      sb.Append(MaxHp);
      sb.Append(",MaxWinningStreak: ");
      sb.Append(MaxWinningStreak);
      sb.Append(",WinningStreak: ");
      sb.Append(WinningStreak);
      sb.Append(",Role_lvl: ");
      sb.Append(Role_lvl);
      sb.Append(",Award: ");
      sb.Append(Award);
      sb.Append(")");
      return sb.ToString();
    }

  }

}