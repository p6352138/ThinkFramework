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
  public partial class PlayerResponse : TBase
  {
    private int _user_id;
    private int _nameColor;
    private string _userName;
    private string _signal;
    private long _money;
    private int _gold;
    private byte _vipLvl;
    private byte _token;
    private string _serverName;
    private byte _sex;
    private int _account_id;
    private int _where_id;
    private int _knowledge_value;
    private byte _freeAddPotential;
    private int _playerLevel;
    private byte _clan;
    private PlayerResourcesResponse _playerResources;
    private PlayerAttributeResponse _playerAttribute;
    private int _expandConsume_gold;
    private int _ranking_id;
    private byte _challenge_num;
    private int _exp;
    private int _expNextLevel;
    private int _icon;
    private int _map_id;
    private string _game_year;
    private int _fighting_capacity;
    private int _adam_war;
    private int _technique;
    private int _map_persent;
    private int _direction;
    private byte _official_level;
    private string _population;
    private string _area;
    private byte _guanzhi_level;
    private List<UpdatePlayerAttributeResponse> _attributeList;
    private long _user_long_id;

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

    public int NameColor
    {
      get
      {
        return _nameColor;
      }
      set
      {
        __isset.nameColor = true;
        this._nameColor = value;
      }
    }

    public string UserName
    {
      get
      {
        return _userName;
      }
      set
      {
        __isset.userName = true;
        this._userName = value;
      }
    }

    public string Signal
    {
      get
      {
        return _signal;
      }
      set
      {
        __isset.signal = true;
        this._signal = value;
      }
    }

    public long Money
    {
      get
      {
        return _money;
      }
      set
      {
        __isset.money = true;
        this._money = value;
      }
    }

    public int Gold
    {
      get
      {
        return _gold;
      }
      set
      {
        __isset.gold = true;
        this._gold = value;
      }
    }

    public byte VipLvl
    {
      get
      {
        return _vipLvl;
      }
      set
      {
        __isset.vipLvl = true;
        this._vipLvl = value;
      }
    }

    public byte Token
    {
      get
      {
        return _token;
      }
      set
      {
        __isset.token = true;
        this._token = value;
      }
    }

    public string ServerName
    {
      get
      {
        return _serverName;
      }
      set
      {
        __isset.serverName = true;
        this._serverName = value;
      }
    }

    public byte Sex
    {
      get
      {
        return _sex;
      }
      set
      {
        __isset.sex = true;
        this._sex = value;
      }
    }

    public int Account_id
    {
      get
      {
        return _account_id;
      }
      set
      {
        __isset.account_id = true;
        this._account_id = value;
      }
    }

    public int Where_id
    {
      get
      {
        return _where_id;
      }
      set
      {
        __isset.where_id = true;
        this._where_id = value;
      }
    }

    public int Knowledge_value
    {
      get
      {
        return _knowledge_value;
      }
      set
      {
        __isset.knowledge_value = true;
        this._knowledge_value = value;
      }
    }

    public byte FreeAddPotential
    {
      get
      {
        return _freeAddPotential;
      }
      set
      {
        __isset.freeAddPotential = true;
        this._freeAddPotential = value;
      }
    }

    public int PlayerLevel
    {
      get
      {
        return _playerLevel;
      }
      set
      {
        __isset.playerLevel = true;
        this._playerLevel = value;
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

    public PlayerResourcesResponse PlayerResources
    {
      get
      {
        return _playerResources;
      }
      set
      {
        __isset.playerResources = true;
        this._playerResources = value;
      }
    }

    public PlayerAttributeResponse PlayerAttribute
    {
      get
      {
        return _playerAttribute;
      }
      set
      {
        __isset.playerAttribute = true;
        this._playerAttribute = value;
      }
    }

    public int ExpandConsume_gold
    {
      get
      {
        return _expandConsume_gold;
      }
      set
      {
        __isset.expandConsume_gold = true;
        this._expandConsume_gold = value;
      }
    }

    public int Ranking_id
    {
      get
      {
        return _ranking_id;
      }
      set
      {
        __isset.ranking_id = true;
        this._ranking_id = value;
      }
    }

    public byte Challenge_num
    {
      get
      {
        return _challenge_num;
      }
      set
      {
        __isset.challenge_num = true;
        this._challenge_num = value;
      }
    }

    public int Exp
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

    public int ExpNextLevel
    {
      get
      {
        return _expNextLevel;
      }
      set
      {
        __isset.expNextLevel = true;
        this._expNextLevel = value;
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

    public int Map_id
    {
      get
      {
        return _map_id;
      }
      set
      {
        __isset.map_id = true;
        this._map_id = value;
      }
    }

    public string Game_year
    {
      get
      {
        return _game_year;
      }
      set
      {
        __isset.game_year = true;
        this._game_year = value;
      }
    }

    public int Fighting_capacity
    {
      get
      {
        return _fighting_capacity;
      }
      set
      {
        __isset.fighting_capacity = true;
        this._fighting_capacity = value;
      }
    }

    public int Adam_war
    {
      get
      {
        return _adam_war;
      }
      set
      {
        __isset.adam_war = true;
        this._adam_war = value;
      }
    }

    public int Technique
    {
      get
      {
        return _technique;
      }
      set
      {
        __isset.technique = true;
        this._technique = value;
      }
    }

    public int Map_persent
    {
      get
      {
        return _map_persent;
      }
      set
      {
        __isset.map_persent = true;
        this._map_persent = value;
      }
    }

    public int Direction
    {
      get
      {
        return _direction;
      }
      set
      {
        __isset.direction = true;
        this._direction = value;
      }
    }

    public byte Official_level
    {
      get
      {
        return _official_level;
      }
      set
      {
        __isset.official_level = true;
        this._official_level = value;
      }
    }

    public string Population
    {
      get
      {
        return _population;
      }
      set
      {
        __isset.population = true;
        this._population = value;
      }
    }

    public string Area
    {
      get
      {
        return _area;
      }
      set
      {
        __isset.area = true;
        this._area = value;
      }
    }

    public byte Guanzhi_level
    {
      get
      {
        return _guanzhi_level;
      }
      set
      {
        __isset.guanzhi_level = true;
        this._guanzhi_level = value;
      }
    }

    public List<UpdatePlayerAttributeResponse> AttributeList
    {
      get
      {
        return _attributeList;
      }
      set
      {
        __isset.attributeList = true;
        this._attributeList = value;
      }
    }

    public long User_long_id
    {
      get
      {
        return _user_long_id;
      }
      set
      {
        __isset.user_long_id = true;
        this._user_long_id = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool user_id;
      public bool nameColor;
      public bool userName;
      public bool signal;
      public bool money;
      public bool gold;
      public bool vipLvl;
      public bool token;
      public bool serverName;
      public bool sex;
      public bool account_id;
      public bool where_id;
      public bool knowledge_value;
      public bool freeAddPotential;
      public bool playerLevel;
      public bool clan;
      public bool playerResources;
      public bool playerAttribute;
      public bool expandConsume_gold;
      public bool ranking_id;
      public bool challenge_num;
      public bool exp;
      public bool expNextLevel;
      public bool icon;
      public bool map_id;
      public bool game_year;
      public bool fighting_capacity;
      public bool adam_war;
      public bool technique;
      public bool map_persent;
      public bool direction;
      public bool official_level;
      public bool population;
      public bool area;
      public bool guanzhi_level;
      public bool attributeList;
      public bool user_long_id;
    }

    public PlayerResponse() {
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
            if (field.Type == TType.I32) {
              NameColor = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              UserName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Signal = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I64) {
              Money = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Gold = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Byte) {
              VipLvl = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Byte) {
              Token = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              ServerName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Byte) {
              Sex = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              Account_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I32) {
              Where_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.I32) {
              Knowledge_value = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.Byte) {
              FreeAddPotential = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.I32) {
              PlayerLevel = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 16:
            if (field.Type == TType.Byte) {
              Clan = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 17:
            if (field.Type == TType.Struct) {
              PlayerResources = new PlayerResourcesResponse();
              PlayerResources.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 18:
            if (field.Type == TType.Struct) {
              PlayerAttribute = new PlayerAttributeResponse();
              PlayerAttribute.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 19:
            if (field.Type == TType.I32) {
              ExpandConsume_gold = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I32) {
              Ranking_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 21:
            if (field.Type == TType.Byte) {
              Challenge_num = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 22:
            if (field.Type == TType.I32) {
              Exp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 23:
            if (field.Type == TType.I32) {
              ExpNextLevel = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 24:
            if (field.Type == TType.I32) {
              Icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 25:
            if (field.Type == TType.I32) {
              Map_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 26:
            if (field.Type == TType.String) {
              Game_year = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 27:
            if (field.Type == TType.I32) {
              Fighting_capacity = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 28:
            if (field.Type == TType.I32) {
              Adam_war = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 29:
            if (field.Type == TType.I32) {
              Technique = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.I32) {
              Map_persent = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 31:
            if (field.Type == TType.I32) {
              Direction = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 32:
            if (field.Type == TType.Byte) {
              Official_level = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 33:
            if (field.Type == TType.String) {
              Population = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 34:
            if (field.Type == TType.String) {
              Area = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 35:
            if (field.Type == TType.Byte) {
              Guanzhi_level = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 36:
            if (field.Type == TType.List) {
              {
                AttributeList = new List<UpdatePlayerAttributeResponse>();
                TList _list60 = iprot.ReadListBegin();
                for( int _i61 = 0; _i61 < _list60.Count; ++_i61)
                {
                  UpdatePlayerAttributeResponse _elem62 = new UpdatePlayerAttributeResponse();
                  _elem62 = new UpdatePlayerAttributeResponse();
                  _elem62.Read(iprot);
                  AttributeList.Add(_elem62);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 37:
            if (field.Type == TType.I64) {
              User_long_id = iprot.ReadI64();
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
      TStruct struc = new TStruct("PlayerResponse");
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
      if (__isset.nameColor) {
        field.Name = "nameColor";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(NameColor);
        oprot.WriteFieldEnd();
      }
      if (UserName != null && __isset.userName) {
        field.Name = "userName";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(UserName);
        oprot.WriteFieldEnd();
      }
      if (Signal != null && __isset.signal) {
        field.Name = "signal";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Signal);
        oprot.WriteFieldEnd();
      }
      if (__isset.money) {
        field.Name = "money";
        field.Type = TType.I64;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Money);
        oprot.WriteFieldEnd();
      }
      if (__isset.gold) {
        field.Name = "gold";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Gold);
        oprot.WriteFieldEnd();
      }
      if (__isset.vipLvl) {
        field.Name = "vipLvl";
        field.Type = TType.Byte;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(VipLvl);
        oprot.WriteFieldEnd();
      }
      if (__isset.token) {
        field.Name = "token";
        field.Type = TType.Byte;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Token);
        oprot.WriteFieldEnd();
      }
      if (ServerName != null && __isset.serverName) {
        field.Name = "serverName";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ServerName);
        oprot.WriteFieldEnd();
      }
      if (__isset.sex) {
        field.Name = "sex";
        field.Type = TType.Byte;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Sex);
        oprot.WriteFieldEnd();
      }
      if (__isset.account_id) {
        field.Name = "account_id";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Account_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.where_id) {
        field.Name = "where_id";
        field.Type = TType.I32;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Where_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.knowledge_value) {
        field.Name = "knowledge_value";
        field.Type = TType.I32;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Knowledge_value);
        oprot.WriteFieldEnd();
      }
      if (__isset.freeAddPotential) {
        field.Name = "freeAddPotential";
        field.Type = TType.Byte;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(FreeAddPotential);
        oprot.WriteFieldEnd();
      }
      if (__isset.playerLevel) {
        field.Name = "playerLevel";
        field.Type = TType.I32;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(PlayerLevel);
        oprot.WriteFieldEnd();
      }
      if (__isset.clan) {
        field.Name = "clan";
        field.Type = TType.Byte;
        field.ID = 16;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Clan);
        oprot.WriteFieldEnd();
      }
      if (PlayerResources != null && __isset.playerResources) {
        field.Name = "playerResources";
        field.Type = TType.Struct;
        field.ID = 17;
        oprot.WriteFieldBegin(field);
        PlayerResources.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (PlayerAttribute != null && __isset.playerAttribute) {
        field.Name = "playerAttribute";
        field.Type = TType.Struct;
        field.ID = 18;
        oprot.WriteFieldBegin(field);
        PlayerAttribute.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.expandConsume_gold) {
        field.Name = "expandConsume_gold";
        field.Type = TType.I32;
        field.ID = 19;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ExpandConsume_gold);
        oprot.WriteFieldEnd();
      }
      if (__isset.ranking_id) {
        field.Name = "ranking_id";
        field.Type = TType.I32;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Ranking_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.challenge_num) {
        field.Name = "challenge_num";
        field.Type = TType.Byte;
        field.ID = 21;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Challenge_num);
        oprot.WriteFieldEnd();
      }
      if (__isset.exp) {
        field.Name = "exp";
        field.Type = TType.I32;
        field.ID = 22;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Exp);
        oprot.WriteFieldEnd();
      }
      if (__isset.expNextLevel) {
        field.Name = "expNextLevel";
        field.Type = TType.I32;
        field.ID = 23;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ExpNextLevel);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I32;
        field.ID = 24;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.map_id) {
        field.Name = "map_id";
        field.Type = TType.I32;
        field.ID = 25;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Map_id);
        oprot.WriteFieldEnd();
      }
      if (Game_year != null && __isset.game_year) {
        field.Name = "game_year";
        field.Type = TType.String;
        field.ID = 26;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Game_year);
        oprot.WriteFieldEnd();
      }
      if (__isset.fighting_capacity) {
        field.Name = "fighting_capacity";
        field.Type = TType.I32;
        field.ID = 27;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fighting_capacity);
        oprot.WriteFieldEnd();
      }
      if (__isset.adam_war) {
        field.Name = "adam_war";
        field.Type = TType.I32;
        field.ID = 28;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Adam_war);
        oprot.WriteFieldEnd();
      }
      if (__isset.technique) {
        field.Name = "technique";
        field.Type = TType.I32;
        field.ID = 29;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Technique);
        oprot.WriteFieldEnd();
      }
      if (__isset.map_persent) {
        field.Name = "map_persent";
        field.Type = TType.I32;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Map_persent);
        oprot.WriteFieldEnd();
      }
      if (__isset.direction) {
        field.Name = "direction";
        field.Type = TType.I32;
        field.ID = 31;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Direction);
        oprot.WriteFieldEnd();
      }
      if (__isset.official_level) {
        field.Name = "official_level";
        field.Type = TType.Byte;
        field.ID = 32;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Official_level);
        oprot.WriteFieldEnd();
      }
      if (Population != null && __isset.population) {
        field.Name = "population";
        field.Type = TType.String;
        field.ID = 33;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Population);
        oprot.WriteFieldEnd();
      }
      if (Area != null && __isset.area) {
        field.Name = "area";
        field.Type = TType.String;
        field.ID = 34;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Area);
        oprot.WriteFieldEnd();
      }
      if (__isset.guanzhi_level) {
        field.Name = "guanzhi_level";
        field.Type = TType.Byte;
        field.ID = 35;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Guanzhi_level);
        oprot.WriteFieldEnd();
      }
      if (AttributeList != null && __isset.attributeList) {
        field.Name = "attributeList";
        field.Type = TType.List;
        field.ID = 36;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, AttributeList.Count));
          foreach (UpdatePlayerAttributeResponse _iter63 in AttributeList)
          {
            _iter63.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.user_long_id) {
        field.Name = "user_long_id";
        field.Type = TType.I64;
        field.ID = 37;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(User_long_id);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerResponse(");
      sb.Append("User_id: ");
      sb.Append(User_id);
      sb.Append(",NameColor: ");
      sb.Append(NameColor);
      sb.Append(",UserName: ");
      sb.Append(UserName);
      sb.Append(",Signal: ");
      sb.Append(Signal);
      sb.Append(",Money: ");
      sb.Append(Money);
      sb.Append(",Gold: ");
      sb.Append(Gold);
      sb.Append(",VipLvl: ");
      sb.Append(VipLvl);
      sb.Append(",Token: ");
      sb.Append(Token);
      sb.Append(",ServerName: ");
      sb.Append(ServerName);
      sb.Append(",Sex: ");
      sb.Append(Sex);
      sb.Append(",Account_id: ");
      sb.Append(Account_id);
      sb.Append(",Where_id: ");
      sb.Append(Where_id);
      sb.Append(",Knowledge_value: ");
      sb.Append(Knowledge_value);
      sb.Append(",FreeAddPotential: ");
      sb.Append(FreeAddPotential);
      sb.Append(",PlayerLevel: ");
      sb.Append(PlayerLevel);
      sb.Append(",Clan: ");
      sb.Append(Clan);
      sb.Append(",PlayerResources: ");
      sb.Append(PlayerResources== null ? "<null>" : PlayerResources.ToString());
      sb.Append(",PlayerAttribute: ");
      sb.Append(PlayerAttribute== null ? "<null>" : PlayerAttribute.ToString());
      sb.Append(",ExpandConsume_gold: ");
      sb.Append(ExpandConsume_gold);
      sb.Append(",Ranking_id: ");
      sb.Append(Ranking_id);
      sb.Append(",Challenge_num: ");
      sb.Append(Challenge_num);
      sb.Append(",Exp: ");
      sb.Append(Exp);
      sb.Append(",ExpNextLevel: ");
      sb.Append(ExpNextLevel);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",Map_id: ");
      sb.Append(Map_id);
      sb.Append(",Game_year: ");
      sb.Append(Game_year);
      sb.Append(",Fighting_capacity: ");
      sb.Append(Fighting_capacity);
      sb.Append(",Adam_war: ");
      sb.Append(Adam_war);
      sb.Append(",Technique: ");
      sb.Append(Technique);
      sb.Append(",Map_persent: ");
      sb.Append(Map_persent);
      sb.Append(",Direction: ");
      sb.Append(Direction);
      sb.Append(",Official_level: ");
      sb.Append(Official_level);
      sb.Append(",Population: ");
      sb.Append(Population);
      sb.Append(",Area: ");
      sb.Append(Area);
      sb.Append(",Guanzhi_level: ");
      sb.Append(Guanzhi_level);
      sb.Append(",AttributeList: ");
      sb.Append(AttributeList);
      sb.Append(",User_long_id: ");
      sb.Append(User_long_id);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
