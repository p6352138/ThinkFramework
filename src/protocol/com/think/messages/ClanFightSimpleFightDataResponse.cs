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
  public partial class ClanFightSimpleFightDataResponse : TBase
  {
    private ClanFightSeatResponse _fightSeat;
    private int _attackerId;
    private string _attackerName;
    private int _defendId;
    private string _defendIdName;
    private byte _winner;
    private short _winnerKillNum;
    private int _attackerMaxHp;
    private int _attackerStartHp;
    private int _attackerEndHp;
    private int _defendMaxHp;
    private int _defendStartHp;
    private int _defendEndHp;

    public ClanFightSeatResponse FightSeat
    {
      get
      {
        return _fightSeat;
      }
      set
      {
        __isset.fightSeat = true;
        this._fightSeat = value;
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

    public int DefendId
    {
      get
      {
        return _defendId;
      }
      set
      {
        __isset.defendId = true;
        this._defendId = value;
      }
    }

    public string DefendIdName
    {
      get
      {
        return _defendIdName;
      }
      set
      {
        __isset.defendIdName = true;
        this._defendIdName = value;
      }
    }

    public byte Winner
    {
      get
      {
        return _winner;
      }
      set
      {
        __isset.winner = true;
        this._winner = value;
      }
    }

    public short WinnerKillNum
    {
      get
      {
        return _winnerKillNum;
      }
      set
      {
        __isset.winnerKillNum = true;
        this._winnerKillNum = value;
      }
    }

    public int AttackerMaxHp
    {
      get
      {
        return _attackerMaxHp;
      }
      set
      {
        __isset.attackerMaxHp = true;
        this._attackerMaxHp = value;
      }
    }

    public int AttackerStartHp
    {
      get
      {
        return _attackerStartHp;
      }
      set
      {
        __isset.attackerStartHp = true;
        this._attackerStartHp = value;
      }
    }

    public int AttackerEndHp
    {
      get
      {
        return _attackerEndHp;
      }
      set
      {
        __isset.attackerEndHp = true;
        this._attackerEndHp = value;
      }
    }

    public int DefendMaxHp
    {
      get
      {
        return _defendMaxHp;
      }
      set
      {
        __isset.defendMaxHp = true;
        this._defendMaxHp = value;
      }
    }

    public int DefendStartHp
    {
      get
      {
        return _defendStartHp;
      }
      set
      {
        __isset.defendStartHp = true;
        this._defendStartHp = value;
      }
    }

    public int DefendEndHp
    {
      get
      {
        return _defendEndHp;
      }
      set
      {
        __isset.defendEndHp = true;
        this._defendEndHp = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool fightSeat;
      public bool attackerId;
      public bool attackerName;
      public bool defendId;
      public bool defendIdName;
      public bool winner;
      public bool winnerKillNum;
      public bool attackerMaxHp;
      public bool attackerStartHp;
      public bool attackerEndHp;
      public bool defendMaxHp;
      public bool defendStartHp;
      public bool defendEndHp;
    }

    public ClanFightSimpleFightDataResponse() {
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
            if (field.Type == TType.Struct) {
              FightSeat = new ClanFightSeatResponse();
              FightSeat.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              AttackerId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              AttackerName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              DefendId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              DefendIdName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Byte) {
              Winner = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I16) {
              WinnerKillNum = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              AttackerMaxHp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              AttackerStartHp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              AttackerEndHp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              DefendMaxHp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I32) {
              DefendStartHp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.I32) {
              DefendEndHp = iprot.ReadI32();
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
      TStruct struc = new TStruct("ClanFightSimpleFightDataResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (FightSeat != null && __isset.fightSeat) {
        field.Name = "fightSeat";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        FightSeat.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerId) {
        field.Name = "attackerId";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackerId);
        oprot.WriteFieldEnd();
      }
      if (AttackerName != null && __isset.attackerName) {
        field.Name = "attackerName";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(AttackerName);
        oprot.WriteFieldEnd();
      }
      if (__isset.defendId) {
        field.Name = "defendId";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DefendId);
        oprot.WriteFieldEnd();
      }
      if (DefendIdName != null && __isset.defendIdName) {
        field.Name = "defendIdName";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DefendIdName);
        oprot.WriteFieldEnd();
      }
      if (__isset.winner) {
        field.Name = "winner";
        field.Type = TType.Byte;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Winner);
        oprot.WriteFieldEnd();
      }
      if (__isset.winnerKillNum) {
        field.Name = "winnerKillNum";
        field.Type = TType.I16;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(WinnerKillNum);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerMaxHp) {
        field.Name = "attackerMaxHp";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackerMaxHp);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerStartHp) {
        field.Name = "attackerStartHp";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackerStartHp);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerEndHp) {
        field.Name = "attackerEndHp";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackerEndHp);
        oprot.WriteFieldEnd();
      }
      if (__isset.defendMaxHp) {
        field.Name = "defendMaxHp";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DefendMaxHp);
        oprot.WriteFieldEnd();
      }
      if (__isset.defendStartHp) {
        field.Name = "defendStartHp";
        field.Type = TType.I32;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DefendStartHp);
        oprot.WriteFieldEnd();
      }
      if (__isset.defendEndHp) {
        field.Name = "defendEndHp";
        field.Type = TType.I32;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DefendEndHp);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanFightSimpleFightDataResponse(");
      sb.Append("FightSeat: ");
      sb.Append(FightSeat== null ? "<null>" : FightSeat.ToString());
      sb.Append(",AttackerId: ");
      sb.Append(AttackerId);
      sb.Append(",AttackerName: ");
      sb.Append(AttackerName);
      sb.Append(",DefendId: ");
      sb.Append(DefendId);
      sb.Append(",DefendIdName: ");
      sb.Append(DefendIdName);
      sb.Append(",Winner: ");
      sb.Append(Winner);
      sb.Append(",WinnerKillNum: ");
      sb.Append(WinnerKillNum);
      sb.Append(",AttackerMaxHp: ");
      sb.Append(AttackerMaxHp);
      sb.Append(",AttackerStartHp: ");
      sb.Append(AttackerStartHp);
      sb.Append(",AttackerEndHp: ");
      sb.Append(AttackerEndHp);
      sb.Append(",DefendMaxHp: ");
      sb.Append(DefendMaxHp);
      sb.Append(",DefendStartHp: ");
      sb.Append(DefendStartHp);
      sb.Append(",DefendEndHp: ");
      sb.Append(DefendEndHp);
      sb.Append(")");
      return sb.ToString();
    }

  }

}