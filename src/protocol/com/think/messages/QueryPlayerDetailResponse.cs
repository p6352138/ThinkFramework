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
  public partial class QueryPlayerDetailResponse : TBase
  {
    private int _user_id;
    private string _name;
    private int _fighting;
    private int _ranking;
    private int _friend_size;
    private int _icon;
    private int _level;
    private string _guanzhi;
    private List<QueryPlayerGeneralDetailResponse> _generalList;
    private string _clan_name;
    private string _clan_ranking_name;
    private long _user_id_long;

    public int User_id
    {
      get
      {
        return _user_id;
      }
      set
      {
        __isset.user_id = true;
        this._user_id = value;
      }
    }

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

    public int Fighting
    {
      get
      {
        return _fighting;
      }
      set
      {
        __isset.fighting = true;
        this._fighting = value;
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

    public int Friend_size
    {
      get
      {
        return _friend_size;
      }
      set
      {
        __isset.friend_size = true;
        this._friend_size = value;
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

    public int Level
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

    public string Guanzhi
    {
      get
      {
        return _guanzhi;
      }
      set
      {
        __isset.guanzhi = true;
        this._guanzhi = value;
      }
    }

    public List<QueryPlayerGeneralDetailResponse> GeneralList
    {
      get
      {
        return _generalList;
      }
      set
      {
        __isset.generalList = true;
        this._generalList = value;
      }
    }

    public string Clan_name
    {
      get
      {
        return _clan_name;
      }
      set
      {
        __isset.clan_name = true;
        this._clan_name = value;
      }
    }

    public string Clan_ranking_name
    {
      get
      {
        return _clan_ranking_name;
      }
      set
      {
        __isset.clan_ranking_name = true;
        this._clan_ranking_name = value;
      }
    }

    public long User_id_long
    {
      get
      {
        return _user_id_long;
      }
      set
      {
        __isset.user_id_long = true;
        this._user_id_long = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool user_id;
      public bool name;
      public bool fighting;
      public bool ranking;
      public bool friend_size;
      public bool icon;
      public bool level;
      public bool guanzhi;
      public bool generalList;
      public bool clan_name;
      public bool clan_ranking_name;
      public bool user_id_long;
    }

    public QueryPlayerDetailResponse() {
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
              User_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Fighting = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Ranking = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Friend_size = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              Level = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.String) {
              Guanzhi = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.List) {
              {
                GeneralList = new List<QueryPlayerGeneralDetailResponse>();
                TList _list560 = iprot.ReadListBegin();
                for( int _i561 = 0; _i561 < _list560.Count; ++_i561)
                {
                  QueryPlayerGeneralDetailResponse _elem562 = new QueryPlayerGeneralDetailResponse();
                  _elem562 = new QueryPlayerGeneralDetailResponse();
                  _elem562.Read(iprot);
                  GeneralList.Add(_elem562);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              Clan_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.String) {
              Clan_ranking_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I64) {
              User_id_long = iprot.ReadI64();
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
      TStruct struc = new TStruct("QueryPlayerDetailResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.user_id) {
        field.Name = "user_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(User_id);
        oprot.WriteFieldEnd();
      }
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (__isset.fighting) {
        field.Name = "fighting";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fighting);
        oprot.WriteFieldEnd();
      }
      if (__isset.ranking) {
        field.Name = "ranking";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Ranking);
        oprot.WriteFieldEnd();
      }
      if (__isset.friend_size) {
        field.Name = "friend_size";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Friend_size);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.level) {
        field.Name = "level";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Level);
        oprot.WriteFieldEnd();
      }
      if (Guanzhi != null && __isset.guanzhi) {
        field.Name = "guanzhi";
        field.Type = TType.String;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Guanzhi);
        oprot.WriteFieldEnd();
      }
      if (GeneralList != null && __isset.generalList) {
        field.Name = "generalList";
        field.Type = TType.List;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, GeneralList.Count));
          foreach (QueryPlayerGeneralDetailResponse _iter563 in GeneralList)
          {
            _iter563.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Clan_name != null && __isset.clan_name) {
        field.Name = "clan_name";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Clan_name);
        oprot.WriteFieldEnd();
      }
      if (Clan_ranking_name != null && __isset.clan_ranking_name) {
        field.Name = "clan_ranking_name";
        field.Type = TType.String;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Clan_ranking_name);
        oprot.WriteFieldEnd();
      }
      if (__isset.user_id_long) {
        field.Name = "user_id_long";
        field.Type = TType.I64;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(User_id_long);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("QueryPlayerDetailResponse(");
      sb.Append("User_id: ");
      sb.Append(User_id);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",Fighting: ");
      sb.Append(Fighting);
      sb.Append(",Ranking: ");
      sb.Append(Ranking);
      sb.Append(",Friend_size: ");
      sb.Append(Friend_size);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",Level: ");
      sb.Append(Level);
      sb.Append(",Guanzhi: ");
      sb.Append(Guanzhi);
      sb.Append(",GeneralList: ");
      sb.Append(GeneralList);
      sb.Append(",Clan_name: ");
      sb.Append(Clan_name);
      sb.Append(",Clan_ranking_name: ");
      sb.Append(Clan_ranking_name);
      sb.Append(",User_id_long: ");
      sb.Append(User_id_long);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
