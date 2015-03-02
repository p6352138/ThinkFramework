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
  public partial class ExpeditionResponse : TBase
  {
    private string _name;
    private int _icon;
    private int _hp;
    private int _max_hp;
    private int _fight_surplus_time;
    private int _resurrection_cd;
    private int _consume;
    private byte _effect;
    private int _player_hp;
    private int _consumeGold;

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

    public int Hp
    {
      get
      {
        return _hp;
      }
      set
      {
        __isset.hp = true;
        this._hp = value;
      }
    }

    public int Max_hp
    {
      get
      {
        return _max_hp;
      }
      set
      {
        __isset.max_hp = true;
        this._max_hp = value;
      }
    }

    public int Fight_surplus_time
    {
      get
      {
        return _fight_surplus_time;
      }
      set
      {
        __isset.fight_surplus_time = true;
        this._fight_surplus_time = value;
      }
    }

    public int Resurrection_cd
    {
      get
      {
        return _resurrection_cd;
      }
      set
      {
        __isset.resurrection_cd = true;
        this._resurrection_cd = value;
      }
    }

    public int Consume
    {
      get
      {
        return _consume;
      }
      set
      {
        __isset.consume = true;
        this._consume = value;
      }
    }

    public byte Effect
    {
      get
      {
        return _effect;
      }
      set
      {
        __isset.effect = true;
        this._effect = value;
      }
    }

    public int Player_hp
    {
      get
      {
        return _player_hp;
      }
      set
      {
        __isset.player_hp = true;
        this._player_hp = value;
      }
    }

    public int ConsumeGold
    {
      get
      {
        return _consumeGold;
      }
      set
      {
        __isset.consumeGold = true;
        this._consumeGold = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool name;
      public bool icon;
      public bool hp;
      public bool max_hp;
      public bool fight_surplus_time;
      public bool resurrection_cd;
      public bool consume;
      public bool effect;
      public bool player_hp;
      public bool consumeGold;
    }

    public ExpeditionResponse() {
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
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
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
            if (field.Type == TType.I32) {
              Hp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Max_hp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Fight_surplus_time = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Resurrection_cd = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              Consume = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Byte) {
              Effect = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              Player_hp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              ConsumeGold = iprot.ReadI32();
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
      TStruct struc = new TStruct("ExpeditionResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
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
      if (__isset.hp) {
        field.Name = "hp";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Hp);
        oprot.WriteFieldEnd();
      }
      if (__isset.max_hp) {
        field.Name = "max_hp";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Max_hp);
        oprot.WriteFieldEnd();
      }
      if (__isset.fight_surplus_time) {
        field.Name = "fight_surplus_time";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fight_surplus_time);
        oprot.WriteFieldEnd();
      }
      if (__isset.resurrection_cd) {
        field.Name = "resurrection_cd";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Resurrection_cd);
        oprot.WriteFieldEnd();
      }
      if (__isset.consume) {
        field.Name = "consume";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Consume);
        oprot.WriteFieldEnd();
      }
      if (__isset.effect) {
        field.Name = "effect";
        field.Type = TType.Byte;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Effect);
        oprot.WriteFieldEnd();
      }
      if (__isset.player_hp) {
        field.Name = "player_hp";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Player_hp);
        oprot.WriteFieldEnd();
      }
      if (__isset.consumeGold) {
        field.Name = "consumeGold";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ConsumeGold);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ExpeditionResponse(");
      sb.Append("Name: ");
      sb.Append(Name);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",Hp: ");
      sb.Append(Hp);
      sb.Append(",Max_hp: ");
      sb.Append(Max_hp);
      sb.Append(",Fight_surplus_time: ");
      sb.Append(Fight_surplus_time);
      sb.Append(",Resurrection_cd: ");
      sb.Append(Resurrection_cd);
      sb.Append(",Consume: ");
      sb.Append(Consume);
      sb.Append(",Effect: ");
      sb.Append(Effect);
      sb.Append(",Player_hp: ");
      sb.Append(Player_hp);
      sb.Append(",ConsumeGold: ");
      sb.Append(ConsumeGold);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
