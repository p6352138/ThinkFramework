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
  public partial class ClanFightMapResponse : TBase
  {
    private string _attackClan;
    private string _defendClan;
    private int _attackClanId;
    private int _defendClanId;
    private string _helpAttackClan;
    private byte _curFightIndex;
    private int _attackIntegral;
    private int _defendIntegral;
    private List<ClanFightPointResponse> _clanFightMapPointList;
    private List<ClanFightWaytResponse> _clanFightWayList;
    private ClanFightPlayerSelfResponse _clanFightPlayerSelfResponse;
    private int _attackEnergy;
    private int _defendEnergy;
    private short _attackRevivePoint;
    private short _defendRevivePoint;
    private int _inspire_gold;
    private int _revive_gold;
    private int _count_down;
    private byte _re_type;

    public string AttackClan
    {
      get
      {
        return _attackClan;
      }
      set
      {
        __isset.attackClan = true;
        this._attackClan = value;
      }
    }

    public string DefendClan
    {
      get
      {
        return _defendClan;
      }
      set
      {
        __isset.defendClan = true;
        this._defendClan = value;
      }
    }

    public int AttackClanId
    {
      get
      {
        return _attackClanId;
      }
      set
      {
        __isset.attackClanId = true;
        this._attackClanId = value;
      }
    }

    public int DefendClanId
    {
      get
      {
        return _defendClanId;
      }
      set
      {
        __isset.defendClanId = true;
        this._defendClanId = value;
      }
    }

    public string HelpAttackClan
    {
      get
      {
        return _helpAttackClan;
      }
      set
      {
        __isset.helpAttackClan = true;
        this._helpAttackClan = value;
      }
    }

    public byte CurFightIndex
    {
      get
      {
        return _curFightIndex;
      }
      set
      {
        __isset.curFightIndex = true;
        this._curFightIndex = value;
      }
    }

    public int AttackIntegral
    {
      get
      {
        return _attackIntegral;
      }
      set
      {
        __isset.attackIntegral = true;
        this._attackIntegral = value;
      }
    }

    public int DefendIntegral
    {
      get
      {
        return _defendIntegral;
      }
      set
      {
        __isset.defendIntegral = true;
        this._defendIntegral = value;
      }
    }

    public List<ClanFightPointResponse> ClanFightMapPointList
    {
      get
      {
        return _clanFightMapPointList;
      }
      set
      {
        __isset.clanFightMapPointList = true;
        this._clanFightMapPointList = value;
      }
    }

    public List<ClanFightWaytResponse> ClanFightWayList
    {
      get
      {
        return _clanFightWayList;
      }
      set
      {
        __isset.clanFightWayList = true;
        this._clanFightWayList = value;
      }
    }

    public ClanFightPlayerSelfResponse ClanFightPlayerSelfResponse
    {
      get
      {
        return _clanFightPlayerSelfResponse;
      }
      set
      {
        __isset.clanFightPlayerSelfResponse = true;
        this._clanFightPlayerSelfResponse = value;
      }
    }

    public int AttackEnergy
    {
      get
      {
        return _attackEnergy;
      }
      set
      {
        __isset.attackEnergy = true;
        this._attackEnergy = value;
      }
    }

    public int DefendEnergy
    {
      get
      {
        return _defendEnergy;
      }
      set
      {
        __isset.defendEnergy = true;
        this._defendEnergy = value;
      }
    }

    public short AttackRevivePoint
    {
      get
      {
        return _attackRevivePoint;
      }
      set
      {
        __isset.attackRevivePoint = true;
        this._attackRevivePoint = value;
      }
    }

    public short DefendRevivePoint
    {
      get
      {
        return _defendRevivePoint;
      }
      set
      {
        __isset.defendRevivePoint = true;
        this._defendRevivePoint = value;
      }
    }

    public int Inspire_gold
    {
      get
      {
        return _inspire_gold;
      }
      set
      {
        __isset.inspire_gold = true;
        this._inspire_gold = value;
      }
    }

    public int Revive_gold
    {
      get
      {
        return _revive_gold;
      }
      set
      {
        __isset.revive_gold = true;
        this._revive_gold = value;
      }
    }

    public int Count_down
    {
      get
      {
        return _count_down;
      }
      set
      {
        __isset.count_down = true;
        this._count_down = value;
      }
    }

    public byte Re_type
    {
      get
      {
        return _re_type;
      }
      set
      {
        __isset.re_type = true;
        this._re_type = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool attackClan;
      public bool defendClan;
      public bool attackClanId;
      public bool defendClanId;
      public bool helpAttackClan;
      public bool curFightIndex;
      public bool attackIntegral;
      public bool defendIntegral;
      public bool clanFightMapPointList;
      public bool clanFightWayList;
      public bool clanFightPlayerSelfResponse;
      public bool attackEnergy;
      public bool defendEnergy;
      public bool attackRevivePoint;
      public bool defendRevivePoint;
      public bool inspire_gold;
      public bool revive_gold;
      public bool count_down;
      public bool re_type;
    }

    public ClanFightMapResponse() {
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
              AttackClan = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              DefendClan = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              AttackClanId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              DefendClanId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              HelpAttackClan = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Byte) {
              CurFightIndex = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              AttackIntegral = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              DefendIntegral = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.List) {
              {
                ClanFightMapPointList = new List<ClanFightPointResponse>();
                TList _list829 = iprot.ReadListBegin();
                for( int _i830 = 0; _i830 < _list829.Count; ++_i830)
                {
                  ClanFightPointResponse _elem831 = new ClanFightPointResponse();
                  _elem831 = new ClanFightPointResponse();
                  _elem831.Read(iprot);
                  ClanFightMapPointList.Add(_elem831);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.List) {
              {
                ClanFightWayList = new List<ClanFightWaytResponse>();
                TList _list832 = iprot.ReadListBegin();
                for( int _i833 = 0; _i833 < _list832.Count; ++_i833)
                {
                  ClanFightWaytResponse _elem834 = new ClanFightWaytResponse();
                  _elem834 = new ClanFightWaytResponse();
                  _elem834.Read(iprot);
                  ClanFightWayList.Add(_elem834);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Struct) {
              ClanFightPlayerSelfResponse = new ClanFightPlayerSelfResponse();
              ClanFightPlayerSelfResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I32) {
              AttackEnergy = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.I32) {
              DefendEnergy = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.I16) {
              AttackRevivePoint = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.I16) {
              DefendRevivePoint = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 16:
            if (field.Type == TType.I32) {
              Inspire_gold = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 17:
            if (field.Type == TType.I32) {
              Revive_gold = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 18:
            if (field.Type == TType.I32) {
              Count_down = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 19:
            if (field.Type == TType.Byte) {
              Re_type = iprot.ReadByte();
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
      TStruct struc = new TStruct("ClanFightMapResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (AttackClan != null && __isset.attackClan) {
        field.Name = "attackClan";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(AttackClan);
        oprot.WriteFieldEnd();
      }
      if (DefendClan != null && __isset.defendClan) {
        field.Name = "defendClan";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DefendClan);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackClanId) {
        field.Name = "attackClanId";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackClanId);
        oprot.WriteFieldEnd();
      }
      if (__isset.defendClanId) {
        field.Name = "defendClanId";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DefendClanId);
        oprot.WriteFieldEnd();
      }
      if (HelpAttackClan != null && __isset.helpAttackClan) {
        field.Name = "helpAttackClan";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(HelpAttackClan);
        oprot.WriteFieldEnd();
      }
      if (__isset.curFightIndex) {
        field.Name = "curFightIndex";
        field.Type = TType.Byte;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(CurFightIndex);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackIntegral) {
        field.Name = "attackIntegral";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackIntegral);
        oprot.WriteFieldEnd();
      }
      if (__isset.defendIntegral) {
        field.Name = "defendIntegral";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DefendIntegral);
        oprot.WriteFieldEnd();
      }
      if (ClanFightMapPointList != null && __isset.clanFightMapPointList) {
        field.Name = "clanFightMapPointList";
        field.Type = TType.List;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ClanFightMapPointList.Count));
          foreach (ClanFightPointResponse _iter835 in ClanFightMapPointList)
          {
            _iter835.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (ClanFightWayList != null && __isset.clanFightWayList) {
        field.Name = "clanFightWayList";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ClanFightWayList.Count));
          foreach (ClanFightWaytResponse _iter836 in ClanFightWayList)
          {
            _iter836.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (ClanFightPlayerSelfResponse != null && __isset.clanFightPlayerSelfResponse) {
        field.Name = "clanFightPlayerSelfResponse";
        field.Type = TType.Struct;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        ClanFightPlayerSelfResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackEnergy) {
        field.Name = "attackEnergy";
        field.Type = TType.I32;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackEnergy);
        oprot.WriteFieldEnd();
      }
      if (__isset.defendEnergy) {
        field.Name = "defendEnergy";
        field.Type = TType.I32;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DefendEnergy);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackRevivePoint) {
        field.Name = "attackRevivePoint";
        field.Type = TType.I16;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(AttackRevivePoint);
        oprot.WriteFieldEnd();
      }
      if (__isset.defendRevivePoint) {
        field.Name = "defendRevivePoint";
        field.Type = TType.I16;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(DefendRevivePoint);
        oprot.WriteFieldEnd();
      }
      if (__isset.inspire_gold) {
        field.Name = "inspire_gold";
        field.Type = TType.I32;
        field.ID = 16;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Inspire_gold);
        oprot.WriteFieldEnd();
      }
      if (__isset.revive_gold) {
        field.Name = "revive_gold";
        field.Type = TType.I32;
        field.ID = 17;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Revive_gold);
        oprot.WriteFieldEnd();
      }
      if (__isset.count_down) {
        field.Name = "count_down";
        field.Type = TType.I32;
        field.ID = 18;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Count_down);
        oprot.WriteFieldEnd();
      }
      if (__isset.re_type) {
        field.Name = "re_type";
        field.Type = TType.Byte;
        field.ID = 19;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Re_type);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanFightMapResponse(");
      sb.Append("AttackClan: ");
      sb.Append(AttackClan);
      sb.Append(",DefendClan: ");
      sb.Append(DefendClan);
      sb.Append(",AttackClanId: ");
      sb.Append(AttackClanId);
      sb.Append(",DefendClanId: ");
      sb.Append(DefendClanId);
      sb.Append(",HelpAttackClan: ");
      sb.Append(HelpAttackClan);
      sb.Append(",CurFightIndex: ");
      sb.Append(CurFightIndex);
      sb.Append(",AttackIntegral: ");
      sb.Append(AttackIntegral);
      sb.Append(",DefendIntegral: ");
      sb.Append(DefendIntegral);
      sb.Append(",ClanFightMapPointList: ");
      sb.Append(ClanFightMapPointList);
      sb.Append(",ClanFightWayList: ");
      sb.Append(ClanFightWayList);
      sb.Append(",ClanFightPlayerSelfResponse: ");
      sb.Append(ClanFightPlayerSelfResponse== null ? "<null>" : ClanFightPlayerSelfResponse.ToString());
      sb.Append(",AttackEnergy: ");
      sb.Append(AttackEnergy);
      sb.Append(",DefendEnergy: ");
      sb.Append(DefendEnergy);
      sb.Append(",AttackRevivePoint: ");
      sb.Append(AttackRevivePoint);
      sb.Append(",DefendRevivePoint: ");
      sb.Append(DefendRevivePoint);
      sb.Append(",Inspire_gold: ");
      sb.Append(Inspire_gold);
      sb.Append(",Revive_gold: ");
      sb.Append(Revive_gold);
      sb.Append(",Count_down: ");
      sb.Append(Count_down);
      sb.Append(",Re_type: ");
      sb.Append(Re_type);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
