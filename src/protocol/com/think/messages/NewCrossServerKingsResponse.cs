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
  public partial class NewCrossServerKingsResponse : TBase
  {
    private byte _type;
    private NewCrossServerKingsFightResponse _newCrossServerKingsFightResponse;
    private NewCrossServerKingsFightTableListResponse _newCrossServerKingsFightTableResponse;
    private List<NewCrossServerKingsFightLogResponse> _listFightLog;
    private List<NewCrossServerKingsFightLogResponse> _listAgainst;
    private NewCrossServerKingsFightWeedOutResponse _fightWeedOut;
    private NewCrossServerKingsFightWeedOutResultResponse _weeOutResult;
    private NewCrossScoreRankResponse _scoreRankResponse;
    private NewCrossFightResultConfirmResponse _fightResultConfirmResponse;
    private NewCrossRefreshFoeResponse _refreshFoeResponse;

    public byte Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public NewCrossServerKingsFightResponse NewCrossServerKingsFightResponse
    {
      get
      {
        return _newCrossServerKingsFightResponse;
      }
      set
      {
        __isset.newCrossServerKingsFightResponse = true;
        this._newCrossServerKingsFightResponse = value;
      }
    }

    public NewCrossServerKingsFightTableListResponse NewCrossServerKingsFightTableResponse
    {
      get
      {
        return _newCrossServerKingsFightTableResponse;
      }
      set
      {
        __isset.newCrossServerKingsFightTableResponse = true;
        this._newCrossServerKingsFightTableResponse = value;
      }
    }

    public List<NewCrossServerKingsFightLogResponse> ListFightLog
    {
      get
      {
        return _listFightLog;
      }
      set
      {
        __isset.listFightLog = true;
        this._listFightLog = value;
      }
    }

    public List<NewCrossServerKingsFightLogResponse> ListAgainst
    {
      get
      {
        return _listAgainst;
      }
      set
      {
        __isset.listAgainst = true;
        this._listAgainst = value;
      }
    }

    public NewCrossServerKingsFightWeedOutResponse FightWeedOut
    {
      get
      {
        return _fightWeedOut;
      }
      set
      {
        __isset.fightWeedOut = true;
        this._fightWeedOut = value;
      }
    }

    public NewCrossServerKingsFightWeedOutResultResponse WeeOutResult
    {
      get
      {
        return _weeOutResult;
      }
      set
      {
        __isset.weeOutResult = true;
        this._weeOutResult = value;
      }
    }

    public NewCrossScoreRankResponse ScoreRankResponse
    {
      get
      {
        return _scoreRankResponse;
      }
      set
      {
        __isset.scoreRankResponse = true;
        this._scoreRankResponse = value;
      }
    }

    public NewCrossFightResultConfirmResponse FightResultConfirmResponse
    {
      get
      {
        return _fightResultConfirmResponse;
      }
      set
      {
        __isset.fightResultConfirmResponse = true;
        this._fightResultConfirmResponse = value;
      }
    }

    public NewCrossRefreshFoeResponse RefreshFoeResponse
    {
      get
      {
        return _refreshFoeResponse;
      }
      set
      {
        __isset.refreshFoeResponse = true;
        this._refreshFoeResponse = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool type;
      public bool newCrossServerKingsFightResponse;
      public bool newCrossServerKingsFightTableResponse;
      public bool listFightLog;
      public bool listAgainst;
      public bool fightWeedOut;
      public bool weeOutResult;
      public bool scoreRankResponse;
      public bool fightResultConfirmResponse;
      public bool refreshFoeResponse;
    }

    public NewCrossServerKingsResponse() {
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
            if (field.Type == TType.Byte) {
              Type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              NewCrossServerKingsFightResponse = new NewCrossServerKingsFightResponse();
              NewCrossServerKingsFightResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              NewCrossServerKingsFightTableResponse = new NewCrossServerKingsFightTableListResponse();
              NewCrossServerKingsFightTableResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                ListFightLog = new List<NewCrossServerKingsFightLogResponse>();
                TList _list909 = iprot.ReadListBegin();
                for( int _i910 = 0; _i910 < _list909.Count; ++_i910)
                {
                  NewCrossServerKingsFightLogResponse _elem911 = new NewCrossServerKingsFightLogResponse();
                  _elem911 = new NewCrossServerKingsFightLogResponse();
                  _elem911.Read(iprot);
                  ListFightLog.Add(_elem911);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                ListAgainst = new List<NewCrossServerKingsFightLogResponse>();
                TList _list912 = iprot.ReadListBegin();
                for( int _i913 = 0; _i913 < _list912.Count; ++_i913)
                {
                  NewCrossServerKingsFightLogResponse _elem914 = new NewCrossServerKingsFightLogResponse();
                  _elem914 = new NewCrossServerKingsFightLogResponse();
                  _elem914.Read(iprot);
                  ListAgainst.Add(_elem914);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Struct) {
              FightWeedOut = new NewCrossServerKingsFightWeedOutResponse();
              FightWeedOut.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Struct) {
              WeeOutResult = new NewCrossServerKingsFightWeedOutResultResponse();
              WeeOutResult.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Struct) {
              ScoreRankResponse = new NewCrossScoreRankResponse();
              ScoreRankResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Struct) {
              FightResultConfirmResponse = new NewCrossFightResultConfirmResponse();
              FightResultConfirmResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Struct) {
              RefreshFoeResponse = new NewCrossRefreshFoeResponse();
              RefreshFoeResponse.Read(iprot);
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
      TStruct struc = new TStruct("NewCrossServerKingsResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Type);
        oprot.WriteFieldEnd();
      }
      if (NewCrossServerKingsFightResponse != null && __isset.newCrossServerKingsFightResponse) {
        field.Name = "newCrossServerKingsFightResponse";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        NewCrossServerKingsFightResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (NewCrossServerKingsFightTableResponse != null && __isset.newCrossServerKingsFightTableResponse) {
        field.Name = "newCrossServerKingsFightTableResponse";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        NewCrossServerKingsFightTableResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (ListFightLog != null && __isset.listFightLog) {
        field.Name = "listFightLog";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ListFightLog.Count));
          foreach (NewCrossServerKingsFightLogResponse _iter915 in ListFightLog)
          {
            _iter915.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (ListAgainst != null && __isset.listAgainst) {
        field.Name = "listAgainst";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ListAgainst.Count));
          foreach (NewCrossServerKingsFightLogResponse _iter916 in ListAgainst)
          {
            _iter916.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (FightWeedOut != null && __isset.fightWeedOut) {
        field.Name = "fightWeedOut";
        field.Type = TType.Struct;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        FightWeedOut.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (WeeOutResult != null && __isset.weeOutResult) {
        field.Name = "weeOutResult";
        field.Type = TType.Struct;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        WeeOutResult.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (ScoreRankResponse != null && __isset.scoreRankResponse) {
        field.Name = "scoreRankResponse";
        field.Type = TType.Struct;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        ScoreRankResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (FightResultConfirmResponse != null && __isset.fightResultConfirmResponse) {
        field.Name = "fightResultConfirmResponse";
        field.Type = TType.Struct;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        FightResultConfirmResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (RefreshFoeResponse != null && __isset.refreshFoeResponse) {
        field.Name = "refreshFoeResponse";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        RefreshFoeResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("NewCrossServerKingsResponse(");
      sb.Append("Type: ");
      sb.Append(Type);
      sb.Append(",NewCrossServerKingsFightResponse: ");
      sb.Append(NewCrossServerKingsFightResponse== null ? "<null>" : NewCrossServerKingsFightResponse.ToString());
      sb.Append(",NewCrossServerKingsFightTableResponse: ");
      sb.Append(NewCrossServerKingsFightTableResponse== null ? "<null>" : NewCrossServerKingsFightTableResponse.ToString());
      sb.Append(",ListFightLog: ");
      sb.Append(ListFightLog);
      sb.Append(",ListAgainst: ");
      sb.Append(ListAgainst);
      sb.Append(",FightWeedOut: ");
      sb.Append(FightWeedOut== null ? "<null>" : FightWeedOut.ToString());
      sb.Append(",WeeOutResult: ");
      sb.Append(WeeOutResult== null ? "<null>" : WeeOutResult.ToString());
      sb.Append(",ScoreRankResponse: ");
      sb.Append(ScoreRankResponse== null ? "<null>" : ScoreRankResponse.ToString());
      sb.Append(",FightResultConfirmResponse: ");
      sb.Append(FightResultConfirmResponse== null ? "<null>" : FightResultConfirmResponse.ToString());
      sb.Append(",RefreshFoeResponse: ");
      sb.Append(RefreshFoeResponse== null ? "<null>" : RefreshFoeResponse.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
