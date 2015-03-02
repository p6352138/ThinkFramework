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
  public partial class PlayerWashPointResponse : TBase
  {
    private int _power;
    private int _maxPower;
    private int _changePower;
    private int _magic;
    private int _maxMagic;
    private int _changeMagic;
    private int _skill;
    private int _maxSkill;
    private int _changeSkill;
    private int _needExploit;
    private int _needGold1;
    private int _needGold3;
    private int _needGold5;
    private int _needGold6;
    private bool _isSave;

    public int Power
    {
      get
      {
        return _power;
      }
      set
      {
        __isset.power = true;
        this._power = value;
      }
    }

    public int MaxPower
    {
      get
      {
        return _maxPower;
      }
      set
      {
        __isset.maxPower = true;
        this._maxPower = value;
      }
    }

    public int ChangePower
    {
      get
      {
        return _changePower;
      }
      set
      {
        __isset.changePower = true;
        this._changePower = value;
      }
    }

    public int Magic
    {
      get
      {
        return _magic;
      }
      set
      {
        __isset.magic = true;
        this._magic = value;
      }
    }

    public int MaxMagic
    {
      get
      {
        return _maxMagic;
      }
      set
      {
        __isset.maxMagic = true;
        this._maxMagic = value;
      }
    }

    public int ChangeMagic
    {
      get
      {
        return _changeMagic;
      }
      set
      {
        __isset.changeMagic = true;
        this._changeMagic = value;
      }
    }

    public int Skill
    {
      get
      {
        return _skill;
      }
      set
      {
        __isset.skill = true;
        this._skill = value;
      }
    }

    public int MaxSkill
    {
      get
      {
        return _maxSkill;
      }
      set
      {
        __isset.maxSkill = true;
        this._maxSkill = value;
      }
    }

    public int ChangeSkill
    {
      get
      {
        return _changeSkill;
      }
      set
      {
        __isset.changeSkill = true;
        this._changeSkill = value;
      }
    }

    public int NeedExploit
    {
      get
      {
        return _needExploit;
      }
      set
      {
        __isset.needExploit = true;
        this._needExploit = value;
      }
    }

    public int NeedGold1
    {
      get
      {
        return _needGold1;
      }
      set
      {
        __isset.needGold1 = true;
        this._needGold1 = value;
      }
    }

    public int NeedGold3
    {
      get
      {
        return _needGold3;
      }
      set
      {
        __isset.needGold3 = true;
        this._needGold3 = value;
      }
    }

    public int NeedGold5
    {
      get
      {
        return _needGold5;
      }
      set
      {
        __isset.needGold5 = true;
        this._needGold5 = value;
      }
    }

    public int NeedGold6
    {
      get
      {
        return _needGold6;
      }
      set
      {
        __isset.needGold6 = true;
        this._needGold6 = value;
      }
    }

    public bool IsSave
    {
      get
      {
        return _isSave;
      }
      set
      {
        __isset.isSave = true;
        this._isSave = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool power;
      public bool maxPower;
      public bool changePower;
      public bool magic;
      public bool maxMagic;
      public bool changeMagic;
      public bool skill;
      public bool maxSkill;
      public bool changeSkill;
      public bool needExploit;
      public bool needGold1;
      public bool needGold3;
      public bool needGold5;
      public bool needGold6;
      public bool isSave;
    }

    public PlayerWashPointResponse() {
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
              Power = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              MaxPower = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              ChangePower = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Magic = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              MaxMagic = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              ChangeMagic = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              Skill = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              MaxSkill = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              ChangeSkill = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              NeedExploit = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              NeedGold1 = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I32) {
              NeedGold3 = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.I32) {
              NeedGold5 = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.I32) {
              NeedGold6 = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.Bool) {
              IsSave = iprot.ReadBool();
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
      TStruct struc = new TStruct("PlayerWashPointResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.power) {
        field.Name = "power";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Power);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxPower) {
        field.Name = "maxPower";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxPower);
        oprot.WriteFieldEnd();
      }
      if (__isset.changePower) {
        field.Name = "changePower";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ChangePower);
        oprot.WriteFieldEnd();
      }
      if (__isset.magic) {
        field.Name = "magic";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Magic);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxMagic) {
        field.Name = "maxMagic";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxMagic);
        oprot.WriteFieldEnd();
      }
      if (__isset.changeMagic) {
        field.Name = "changeMagic";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ChangeMagic);
        oprot.WriteFieldEnd();
      }
      if (__isset.skill) {
        field.Name = "skill";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Skill);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxSkill) {
        field.Name = "maxSkill";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxSkill);
        oprot.WriteFieldEnd();
      }
      if (__isset.changeSkill) {
        field.Name = "changeSkill";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ChangeSkill);
        oprot.WriteFieldEnd();
      }
      if (__isset.needExploit) {
        field.Name = "needExploit";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(NeedExploit);
        oprot.WriteFieldEnd();
      }
      if (__isset.needGold1) {
        field.Name = "needGold1";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(NeedGold1);
        oprot.WriteFieldEnd();
      }
      if (__isset.needGold3) {
        field.Name = "needGold3";
        field.Type = TType.I32;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(NeedGold3);
        oprot.WriteFieldEnd();
      }
      if (__isset.needGold5) {
        field.Name = "needGold5";
        field.Type = TType.I32;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(NeedGold5);
        oprot.WriteFieldEnd();
      }
      if (__isset.needGold6) {
        field.Name = "needGold6";
        field.Type = TType.I32;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(NeedGold6);
        oprot.WriteFieldEnd();
      }
      if (__isset.isSave) {
        field.Name = "isSave";
        field.Type = TType.Bool;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsSave);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerWashPointResponse(");
      sb.Append("Power: ");
      sb.Append(Power);
      sb.Append(",MaxPower: ");
      sb.Append(MaxPower);
      sb.Append(",ChangePower: ");
      sb.Append(ChangePower);
      sb.Append(",Magic: ");
      sb.Append(Magic);
      sb.Append(",MaxMagic: ");
      sb.Append(MaxMagic);
      sb.Append(",ChangeMagic: ");
      sb.Append(ChangeMagic);
      sb.Append(",Skill: ");
      sb.Append(Skill);
      sb.Append(",MaxSkill: ");
      sb.Append(MaxSkill);
      sb.Append(",ChangeSkill: ");
      sb.Append(ChangeSkill);
      sb.Append(",NeedExploit: ");
      sb.Append(NeedExploit);
      sb.Append(",NeedGold1: ");
      sb.Append(NeedGold1);
      sb.Append(",NeedGold3: ");
      sb.Append(NeedGold3);
      sb.Append(",NeedGold5: ");
      sb.Append(NeedGold5);
      sb.Append(",NeedGold6: ");
      sb.Append(NeedGold6);
      sb.Append(",IsSave: ");
      sb.Append(IsSave);
      sb.Append(")");
      return sb.ToString();
    }

  }

}