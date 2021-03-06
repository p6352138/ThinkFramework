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
  public partial class TurnplateResponse : TBase
  {
    private int _moeny_pond;
    private int _gold_pond;
    private int _id;
    private List<TurnplateResourceResponse> _award;
    private TurnplateRankingListResponse _turnplate_ranking;
    private TurnplateRankingResponse _money_award;
    private int _money_consume;
    private int _gold_consume;

    public int Moeny_pond
    {
      get
      {
        return _moeny_pond;
      }
      set
      {
        __isset.moeny_pond = true;
        this._moeny_pond = value;
      }
    }

    public int Gold_pond
    {
      get
      {
        return _gold_pond;
      }
      set
      {
        __isset.gold_pond = true;
        this._gold_pond = value;
      }
    }

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

    public List<TurnplateResourceResponse> Award
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

    public TurnplateRankingListResponse Turnplate_ranking
    {
      get
      {
        return _turnplate_ranking;
      }
      set
      {
        __isset.turnplate_ranking = true;
        this._turnplate_ranking = value;
      }
    }

    public TurnplateRankingResponse Money_award
    {
      get
      {
        return _money_award;
      }
      set
      {
        __isset.money_award = true;
        this._money_award = value;
      }
    }

    public int Money_consume
    {
      get
      {
        return _money_consume;
      }
      set
      {
        __isset.money_consume = true;
        this._money_consume = value;
      }
    }

    public int Gold_consume
    {
      get
      {
        return _gold_consume;
      }
      set
      {
        __isset.gold_consume = true;
        this._gold_consume = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool moeny_pond;
      public bool gold_pond;
      public bool id;
      public bool award;
      public bool turnplate_ranking;
      public bool money_award;
      public bool money_consume;
      public bool gold_consume;
    }

    public TurnplateResponse() {
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
              Moeny_pond = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Gold_pond = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                Award = new List<TurnplateResourceResponse>();
                TList _list600 = iprot.ReadListBegin();
                for( int _i601 = 0; _i601 < _list600.Count; ++_i601)
                {
                  TurnplateResourceResponse _elem602 = new TurnplateResourceResponse();
                  _elem602 = new TurnplateResourceResponse();
                  _elem602.Read(iprot);
                  Award.Add(_elem602);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Struct) {
              Turnplate_ranking = new TurnplateRankingListResponse();
              Turnplate_ranking.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Struct) {
              Money_award = new TurnplateRankingResponse();
              Money_award.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              Money_consume = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              Gold_consume = iprot.ReadI32();
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
      TStruct struc = new TStruct("TurnplateResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.moeny_pond) {
        field.Name = "moeny_pond";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Moeny_pond);
        oprot.WriteFieldEnd();
      }
      if (__isset.gold_pond) {
        field.Name = "gold_pond";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Gold_pond);
        oprot.WriteFieldEnd();
      }
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
        oprot.WriteFieldEnd();
      }
      if (Award != null && __isset.award) {
        field.Name = "award";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Award.Count));
          foreach (TurnplateResourceResponse _iter603 in Award)
          {
            _iter603.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Turnplate_ranking != null && __isset.turnplate_ranking) {
        field.Name = "turnplate_ranking";
        field.Type = TType.Struct;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        Turnplate_ranking.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Money_award != null && __isset.money_award) {
        field.Name = "money_award";
        field.Type = TType.Struct;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        Money_award.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.money_consume) {
        field.Name = "money_consume";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Money_consume);
        oprot.WriteFieldEnd();
      }
      if (__isset.gold_consume) {
        field.Name = "gold_consume";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Gold_consume);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TurnplateResponse(");
      sb.Append("Moeny_pond: ");
      sb.Append(Moeny_pond);
      sb.Append(",Gold_pond: ");
      sb.Append(Gold_pond);
      sb.Append(",Id: ");
      sb.Append(Id);
      sb.Append(",Award: ");
      sb.Append(Award);
      sb.Append(",Turnplate_ranking: ");
      sb.Append(Turnplate_ranking== null ? "<null>" : Turnplate_ranking.ToString());
      sb.Append(",Money_award: ");
      sb.Append(Money_award== null ? "<null>" : Money_award.ToString());
      sb.Append(",Money_consume: ");
      sb.Append(Money_consume);
      sb.Append(",Gold_consume: ");
      sb.Append(Gold_consume);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
