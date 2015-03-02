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
  public partial class GeneralInheritAttributeResponse : TBase
  {
    private string _peirasmos;
    private long _exp;
    private short _level;
    private int _power;
    private int _magic;
    private int _skill;

    public string Peirasmos
    {
      get
      {
        return _peirasmos;
      }
      set
      {
        __isset.peirasmos = true;
        this._peirasmos = value;
      }
    }

    public long Exp
    {
      get
      {
        return _exp;
      }
      set
      {
        __isset.exp = true;
        this._exp = value;
      }
    }

    public short Level
    {
      get
      {
        return _level;
      }
      set
      {
        __isset.level = true;
        this._level = value;
      }
    }

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


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool peirasmos;
      public bool exp;
      public bool level;
      public bool power;
      public bool magic;
      public bool skill;
    }

    public GeneralInheritAttributeResponse() {
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
              Peirasmos = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I64) {
              Exp = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I16) {
              Level = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Power = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Magic = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Skill = iprot.ReadI32();
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
      TStruct struc = new TStruct("GeneralInheritAttributeResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Peirasmos != null && __isset.peirasmos) {
        field.Name = "peirasmos";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Peirasmos);
        oprot.WriteFieldEnd();
      }
      if (__isset.exp) {
        field.Name = "exp";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Exp);
        oprot.WriteFieldEnd();
      }
      if (__isset.level) {
        field.Name = "level";
        field.Type = TType.I16;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Level);
        oprot.WriteFieldEnd();
      }
      if (__isset.power) {
        field.Name = "power";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Power);
        oprot.WriteFieldEnd();
      }
      if (__isset.magic) {
        field.Name = "magic";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Magic);
        oprot.WriteFieldEnd();
      }
      if (__isset.skill) {
        field.Name = "skill";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Skill);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("GeneralInheritAttributeResponse(");
      sb.Append("Peirasmos: ");
      sb.Append(Peirasmos);
      sb.Append(",Exp: ");
      sb.Append(Exp);
      sb.Append(",Level: ");
      sb.Append(Level);
      sb.Append(",Power: ");
      sb.Append(Power);
      sb.Append(",Magic: ");
      sb.Append(Magic);
      sb.Append(",Skill: ");
      sb.Append(Skill);
      sb.Append(")");
      return sb.ToString();
    }

  }

}