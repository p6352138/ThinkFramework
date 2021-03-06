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
  public partial class FightLogResponse : TBase
  {
    private int _id;
    private bool _isSucc;
    private byte _clan;
    private int _attackerId;
    private string _attackerName;
    private short _attackertLvl;
    private int _targetId;
    private string _targetName;
    private short _targetLvl;
    private int _attackerLoss;
    private int _targetLoss;

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

    public bool IsSucc
    {
      get
      {
        return _isSucc;
      }
      set
      {
        __isset.isSucc = true;
        this._isSucc = value;
      }
    }

    public byte Clan
    {
      get
      {
        return _clan;
      }
      set
      {
        __isset.clan = true;
        this._clan = value;
      }
    }

    public int AttackerId
    {
      get
      {
        return _attackerId;
      }
      set
      {
        __isset.attackerId = true;
        this._attackerId = value;
      }
    }

    public string AttackerName
    {
      get
      {
        return _attackerName;
      }
      set
      {
        __isset.attackerName = true;
        this._attackerName = value;
      }
    }

    public short AttackertLvl
    {
      get
      {
        return _attackertLvl;
      }
      set
      {
        __isset.attackertLvl = true;
        this._attackertLvl = value;
      }
    }

    public int TargetId
    {
      get
      {
        return _targetId;
      }
      set
      {
        __isset.targetId = true;
        this._targetId = value;
      }
    }

    public string TargetName
    {
      get
      {
        return _targetName;
      }
      set
      {
        __isset.targetName = true;
        this._targetName = value;
      }
    }

    public short TargetLvl
    {
      get
      {
        return _targetLvl;
      }
      set
      {
        __isset.targetLvl = true;
        this._targetLvl = value;
      }
    }

    public int AttackerLoss
    {
      get
      {
        return _attackerLoss;
      }
      set
      {
        __isset.attackerLoss = true;
        this._attackerLoss = value;
      }
    }

    public int TargetLoss
    {
      get
      {
        return _targetLoss;
      }
      set
      {
        __isset.targetLoss = true;
        this._targetLoss = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool id;
      public bool isSucc;
      public bool clan;
      public bool attackerId;
      public bool attackerName;
      public bool attackertLvl;
      public bool targetId;
      public bool targetName;
      public bool targetLvl;
      public bool attackerLoss;
      public bool targetLoss;
    }

    public FightLogResponse() {
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
            if (field.Type == TType.Bool) {
              IsSucc = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              Clan = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              AttackerId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              AttackerName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I16) {
              AttackertLvl = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              TargetId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.String) {
              TargetName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I16) {
              TargetLvl = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              AttackerLoss = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              TargetLoss = iprot.ReadI32();
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
      TStruct struc = new TStruct("FightLogResponse");
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
      if (__isset.isSucc) {
        field.Name = "isSucc";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsSucc);
        oprot.WriteFieldEnd();
      }
      if (__isset.clan) {
        field.Name = "clan";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Clan);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerId) {
        field.Name = "attackerId";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackerId);
        oprot.WriteFieldEnd();
      }
      if (AttackerName != null && __isset.attackerName) {
        field.Name = "attackerName";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(AttackerName);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackertLvl) {
        field.Name = "attackertLvl";
        field.Type = TType.I16;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(AttackertLvl);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetId) {
        field.Name = "targetId";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TargetId);
        oprot.WriteFieldEnd();
      }
      if (TargetName != null && __isset.targetName) {
        field.Name = "targetName";
        field.Type = TType.String;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TargetName);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetLvl) {
        field.Name = "targetLvl";
        field.Type = TType.I16;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(TargetLvl);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerLoss) {
        field.Name = "attackerLoss";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackerLoss);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetLoss) {
        field.Name = "targetLoss";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TargetLoss);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("FightLogResponse(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",IsSucc: ");
      sb.Append(IsSucc);
      sb.Append(",Clan: ");
      sb.Append(Clan);
      sb.Append(",AttackerId: ");
      sb.Append(AttackerId);
      sb.Append(",AttackerName: ");
      sb.Append(AttackerName);
      sb.Append(",AttackertLvl: ");
      sb.Append(AttackertLvl);
      sb.Append(",TargetId: ");
      sb.Append(TargetId);
      sb.Append(",TargetName: ");
      sb.Append(TargetName);
      sb.Append(",TargetLvl: ");
      sb.Append(TargetLvl);
      sb.Append(",AttackerLoss: ");
      sb.Append(AttackerLoss);
      sb.Append(",TargetLoss: ");
      sb.Append(TargetLoss);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
