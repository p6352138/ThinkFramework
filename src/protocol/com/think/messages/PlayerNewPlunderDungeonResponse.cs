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
  public partial class PlayerNewPlunderDungeonResponse : TBase
  {
    private int _dungeonId;
    private int _user_id;
    private string _name;
    private int _banner_name;
    private int _banner_icon;
    private int _fighting;
    private int _level;
    private int _image;
    private string _slogan;
    private string _plunder_log;
    private int _occupyCD;
    private PlayerFightDataResponse _playerFightData;

    public int DungeonId
    {
      get
      {
        return _dungeonId;
      }
      set
      {
        __isset.dungeonId = true;
        this._dungeonId = value;
      }
    }

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

    public int Banner_name
    {
      get
      {
        return _banner_name;
      }
      set
      {
        __isset.banner_name = true;
        this._banner_name = value;
      }
    }

    public int Banner_icon
    {
      get
      {
        return _banner_icon;
      }
      set
      {
        __isset.banner_icon = true;
        this._banner_icon = value;
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

    public int Image
    {
      get
      {
        return _image;
      }
      set
      {
        __isset.image = true;
        this._image = value;
      }
    }

    public string Slogan
    {
      get
      {
        return _slogan;
      }
      set
      {
        __isset.slogan = true;
        this._slogan = value;
      }
    }

    public string Plunder_log
    {
      get
      {
        return _plunder_log;
      }
      set
      {
        __isset.plunder_log = true;
        this._plunder_log = value;
      }
    }

    public int OccupyCD
    {
      get
      {
        return _occupyCD;
      }
      set
      {
        __isset.occupyCD = true;
        this._occupyCD = value;
      }
    }

    public PlayerFightDataResponse PlayerFightData
    {
      get
      {
        return _playerFightData;
      }
      set
      {
        __isset.playerFightData = true;
        this._playerFightData = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool dungeonId;
      public bool user_id;
      public bool name;
      public bool banner_name;
      public bool banner_icon;
      public bool fighting;
      public bool level;
      public bool image;
      public bool slogan;
      public bool plunder_log;
      public bool occupyCD;
      public bool playerFightData;
    }

    public PlayerNewPlunderDungeonResponse() {
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
              DungeonId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              User_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Banner_name = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Banner_icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Fighting = iprot.ReadI32();
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
            if (field.Type == TType.I32) {
              Image = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              Slogan = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              Plunder_log = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              OccupyCD = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.Struct) {
              PlayerFightData = new PlayerFightDataResponse();
              PlayerFightData.Read(iprot);
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
      TStruct struc = new TStruct("PlayerNewPlunderDungeonResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.dungeonId) {
        field.Name = "dungeonId";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DungeonId);
        oprot.WriteFieldEnd();
      }
      if (__isset.user_id) {
        field.Name = "user_id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(User_id);
        oprot.WriteFieldEnd();
      }
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (__isset.banner_name) {
        field.Name = "banner_name";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Banner_name);
        oprot.WriteFieldEnd();
      }
      if (__isset.banner_icon) {
        field.Name = "banner_icon";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Banner_icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.fighting) {
        field.Name = "fighting";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fighting);
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
      if (__isset.image) {
        field.Name = "image";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Image);
        oprot.WriteFieldEnd();
      }
      if (Slogan != null && __isset.slogan) {
        field.Name = "slogan";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Slogan);
        oprot.WriteFieldEnd();
      }
      if (Plunder_log != null && __isset.plunder_log) {
        field.Name = "plunder_log";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Plunder_log);
        oprot.WriteFieldEnd();
      }
      if (__isset.occupyCD) {
        field.Name = "occupyCD";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(OccupyCD);
        oprot.WriteFieldEnd();
      }
      if (PlayerFightData != null && __isset.playerFightData) {
        field.Name = "playerFightData";
        field.Type = TType.Struct;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        PlayerFightData.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerNewPlunderDungeonResponse(");
      sb.Append("DungeonId: ");
      sb.Append(DungeonId);
      sb.Append(",User_id: ");
      sb.Append(User_id);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",Banner_name: ");
      sb.Append(Banner_name);
      sb.Append(",Banner_icon: ");
      sb.Append(Banner_icon);
      sb.Append(",Fighting: ");
      sb.Append(Fighting);
      sb.Append(",Level: ");
      sb.Append(Level);
      sb.Append(",Image: ");
      sb.Append(Image);
      sb.Append(",Slogan: ");
      sb.Append(Slogan);
      sb.Append(",Plunder_log: ");
      sb.Append(Plunder_log);
      sb.Append(",OccupyCD: ");
      sb.Append(OccupyCD);
      sb.Append(",PlayerFightData: ");
      sb.Append(PlayerFightData== null ? "<null>" : PlayerFightData.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}