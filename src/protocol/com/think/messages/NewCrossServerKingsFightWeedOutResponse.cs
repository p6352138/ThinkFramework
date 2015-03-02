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
  public partial class NewCrossServerKingsFightWeedOutResponse : TBase
  {
    private int _score;
    private int _ranking;
    private int _war_zone;
    private List<NewCrossWeedOutPlayerResponse> _playerList;
    private int _surplusNum;
    private int _freeFightNum;

    public int Score
    {
      get
      {
        return _score;
      }
      set
      {
        __isset.score = true;
        this._score = value;
      }
    }

    public int Ranking
    {
      get
      {
        return _ranking;
      }
      set
      {
        __isset.ranking = true;
        this._ranking = value;
      }
    }

    public int War_zone
    {
      get
      {
        return _war_zone;
      }
      set
      {
        __isset.war_zone = true;
        this._war_zone = value;
      }
    }

    public List<NewCrossWeedOutPlayerResponse> PlayerList
    {
      get
      {
        return _playerList;
      }
      set
      {
        __isset.playerList = true;
        this._playerList = value;
      }
    }

    public int SurplusNum
    {
      get
      {
        return _surplusNum;
      }
      set
      {
        __isset.surplusNum = true;
        this._surplusNum = value;
      }
    }

    public int FreeFightNum
    {
      get
      {
        return _freeFightNum;
      }
      set
      {
        __isset.freeFightNum = true;
        this._freeFightNum = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool score;
      public bool ranking;
      public bool war_zone;
      public bool playerList;
      public bool surplusNum;
      public bool freeFightNum;
    }

    public NewCrossServerKingsFightWeedOutResponse() {
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
              Score = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Ranking = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              War_zone = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                PlayerList = new List<NewCrossWeedOutPlayerResponse>();
                TList _list889 = iprot.ReadListBegin();
                for( int _i890 = 0; _i890 < _list889.Count; ++_i890)
                {
                  NewCrossWeedOutPlayerResponse _elem891 = new NewCrossWeedOutPlayerResponse();
                  _elem891 = new NewCrossWeedOutPlayerResponse();
                  _elem891.Read(iprot);
                  PlayerList.Add(_elem891);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              SurplusNum = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              FreeFightNum = iprot.ReadI32();
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
      TStruct struc = new TStruct("NewCrossServerKingsFightWeedOutResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.score) {
        field.Name = "score";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Score);
        oprot.WriteFieldEnd();
      }
      if (__isset.ranking) {
        field.Name = "ranking";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Ranking);
        oprot.WriteFieldEnd();
      }
      if (__isset.war_zone) {
        field.Name = "war_zone";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(War_zone);
        oprot.WriteFieldEnd();
      }
      if (PlayerList != null && __isset.playerList) {
        field.Name = "playerList";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, PlayerList.Count));
          foreach (NewCrossWeedOutPlayerResponse _iter892 in PlayerList)
          {
            _iter892.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.surplusNum) {
        field.Name = "surplusNum";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SurplusNum);
        oprot.WriteFieldEnd();
      }
      if (__isset.freeFightNum) {
        field.Name = "freeFightNum";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(FreeFightNum);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("NewCrossServerKingsFightWeedOutResponse(");
      sb.Append("Score: ");
      sb.Append(Score);
      sb.Append(",Ranking: ");
      sb.Append(Ranking);
      sb.Append(",War_zone: ");
      sb.Append(War_zone);
      sb.Append(",PlayerList: ");
      sb.Append(PlayerList);
      sb.Append(",SurplusNum: ");
      sb.Append(SurplusNum);
      sb.Append(",FreeFightNum: ");
      sb.Append(FreeFightNum);
      sb.Append(")");
      return sb.ToString();
    }

  }

}