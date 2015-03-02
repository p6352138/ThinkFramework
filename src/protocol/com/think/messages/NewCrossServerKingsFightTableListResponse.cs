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
  public partial class NewCrossServerKingsFightTableListResponse : TBase
  {
    private string _title;
    private string _content;
    private string _fight_times;
    private List<NewCrossServerKingsFightTableResponse> _listTable;
    private List<NewCrossServerFightKonckoutMatchResponse> _konckoutMatch;
    private NewCrossWeedOutPlayerResponse _kingUser;
    private int _activityNum;
    private long _nextActiviTime;
    private List<NewCrossServerKingsFightLogResponse> _championListFightLog;
    private string _nextGameMsg;
    private long _nextGameTime;

    public string Title
    {
      get
      {
        return _title;
      }
      set
      {
        __isset.title = true;
        this._title = value;
      }
    }

    public string Content
    {
      get
      {
        return _content;
      }
      set
      {
        __isset.content = true;
        this._content = value;
      }
    }

    public string Fight_times
    {
      get
      {
        return _fight_times;
      }
      set
      {
        __isset.fight_times = true;
        this._fight_times = value;
      }
    }

    public List<NewCrossServerKingsFightTableResponse> ListTable
    {
      get
      {
        return _listTable;
      }
      set
      {
        __isset.listTable = true;
        this._listTable = value;
      }
    }

    public List<NewCrossServerFightKonckoutMatchResponse> KonckoutMatch
    {
      get
      {
        return _konckoutMatch;
      }
      set
      {
        __isset.konckoutMatch = true;
        this._konckoutMatch = value;
      }
    }

    public NewCrossWeedOutPlayerResponse KingUser
    {
      get
      {
        return _kingUser;
      }
      set
      {
        __isset.kingUser = true;
        this._kingUser = value;
      }
    }

    public int ActivityNum
    {
      get
      {
        return _activityNum;
      }
      set
      {
        __isset.activityNum = true;
        this._activityNum = value;
      }
    }

    public long NextActiviTime
    {
      get
      {
        return _nextActiviTime;
      }
      set
      {
        __isset.nextActiviTime = true;
        this._nextActiviTime = value;
      }
    }

    public List<NewCrossServerKingsFightLogResponse> ChampionListFightLog
    {
      get
      {
        return _championListFightLog;
      }
      set
      {
        __isset.championListFightLog = true;
        this._championListFightLog = value;
      }
    }

    public string NextGameMsg
    {
      get
      {
        return _nextGameMsg;
      }
      set
      {
        __isset.nextGameMsg = true;
        this._nextGameMsg = value;
      }
    }

    public long NextGameTime
    {
      get
      {
        return _nextGameTime;
      }
      set
      {
        __isset.nextGameTime = true;
        this._nextGameTime = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool title;
      public bool content;
      public bool fight_times;
      public bool listTable;
      public bool konckoutMatch;
      public bool kingUser;
      public bool activityNum;
      public bool nextActiviTime;
      public bool championListFightLog;
      public bool nextGameMsg;
      public bool nextGameTime;
    }

    public NewCrossServerKingsFightTableListResponse() {
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
              Title = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Content = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Fight_times = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                ListTable = new List<NewCrossServerKingsFightTableResponse>();
                TList _list877 = iprot.ReadListBegin();
                for( int _i878 = 0; _i878 < _list877.Count; ++_i878)
                {
                  NewCrossServerKingsFightTableResponse _elem879 = new NewCrossServerKingsFightTableResponse();
                  _elem879 = new NewCrossServerKingsFightTableResponse();
                  _elem879.Read(iprot);
                  ListTable.Add(_elem879);
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
                KonckoutMatch = new List<NewCrossServerFightKonckoutMatchResponse>();
                TList _list880 = iprot.ReadListBegin();
                for( int _i881 = 0; _i881 < _list880.Count; ++_i881)
                {
                  NewCrossServerFightKonckoutMatchResponse _elem882 = new NewCrossServerFightKonckoutMatchResponse();
                  _elem882 = new NewCrossServerFightKonckoutMatchResponse();
                  _elem882.Read(iprot);
                  KonckoutMatch.Add(_elem882);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Struct) {
              KingUser = new NewCrossWeedOutPlayerResponse();
              KingUser.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              ActivityNum = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I64) {
              NextActiviTime = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.List) {
              {
                ChampionListFightLog = new List<NewCrossServerKingsFightLogResponse>();
                TList _list883 = iprot.ReadListBegin();
                for( int _i884 = 0; _i884 < _list883.Count; ++_i884)
                {
                  NewCrossServerKingsFightLogResponse _elem885 = new NewCrossServerKingsFightLogResponse();
                  _elem885 = new NewCrossServerKingsFightLogResponse();
                  _elem885.Read(iprot);
                  ChampionListFightLog.Add(_elem885);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              NextGameMsg = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I64) {
              NextGameTime = iprot.ReadI64();
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
      TStruct struc = new TStruct("NewCrossServerKingsFightTableListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Title != null && __isset.title) {
        field.Name = "title";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Title);
        oprot.WriteFieldEnd();
      }
      if (Content != null && __isset.content) {
        field.Name = "content";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Content);
        oprot.WriteFieldEnd();
      }
      if (Fight_times != null && __isset.fight_times) {
        field.Name = "fight_times";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Fight_times);
        oprot.WriteFieldEnd();
      }
      if (ListTable != null && __isset.listTable) {
        field.Name = "listTable";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ListTable.Count));
          foreach (NewCrossServerKingsFightTableResponse _iter886 in ListTable)
          {
            _iter886.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (KonckoutMatch != null && __isset.konckoutMatch) {
        field.Name = "konckoutMatch";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, KonckoutMatch.Count));
          foreach (NewCrossServerFightKonckoutMatchResponse _iter887 in KonckoutMatch)
          {
            _iter887.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (KingUser != null && __isset.kingUser) {
        field.Name = "kingUser";
        field.Type = TType.Struct;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        KingUser.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.activityNum) {
        field.Name = "activityNum";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ActivityNum);
        oprot.WriteFieldEnd();
      }
      if (__isset.nextActiviTime) {
        field.Name = "nextActiviTime";
        field.Type = TType.I64;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(NextActiviTime);
        oprot.WriteFieldEnd();
      }
      if (ChampionListFightLog != null && __isset.championListFightLog) {
        field.Name = "championListFightLog";
        field.Type = TType.List;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ChampionListFightLog.Count));
          foreach (NewCrossServerKingsFightLogResponse _iter888 in ChampionListFightLog)
          {
            _iter888.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (NextGameMsg != null && __isset.nextGameMsg) {
        field.Name = "nextGameMsg";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(NextGameMsg);
        oprot.WriteFieldEnd();
      }
      if (__isset.nextGameTime) {
        field.Name = "nextGameTime";
        field.Type = TType.I64;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(NextGameTime);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("NewCrossServerKingsFightTableListResponse(");
      sb.Append("Title: ");
      sb.Append(Title);
      sb.Append(",Content: ");
      sb.Append(Content);
      sb.Append(",Fight_times: ");
      sb.Append(Fight_times);
      sb.Append(",ListTable: ");
      sb.Append(ListTable);
      sb.Append(",KonckoutMatch: ");
      sb.Append(KonckoutMatch);
      sb.Append(",KingUser: ");
      sb.Append(KingUser== null ? "<null>" : KingUser.ToString());
      sb.Append(",ActivityNum: ");
      sb.Append(ActivityNum);
      sb.Append(",NextActiviTime: ");
      sb.Append(NextActiviTime);
      sb.Append(",ChampionListFightLog: ");
      sb.Append(ChampionListFightLog);
      sb.Append(",NextGameMsg: ");
      sb.Append(NextGameMsg);
      sb.Append(",NextGameTime: ");
      sb.Append(NextGameTime);
      sb.Append(")");
      return sb.ToString();
    }

  }

}