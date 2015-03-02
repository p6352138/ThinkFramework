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
  public partial class Player_GVE_InfoListResponse : TBase
  {
    private int _id;
    private string _name;
    private int _icon;
    private byte _type;
    private short _lvl;
    private string _exploit;
    private byte _max_people;
    private byte _min_people;
    private byte _max_winningStreak;
    private int _itemId;
    private byte _trait;
    private int _image;
    private string _itemName;
    private byte _probability;
    private List<Player_GVE_InfoResponse> _player_GVE_InfoList;
    private byte _target_people;

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

    public short Lvl
    {
      get
      {
        return _lvl;
      }
      set
      {
        __isset.lvl = true;
        this._lvl = value;
      }
    }

    public string Exploit
    {
      get
      {
        return _exploit;
      }
      set
      {
        __isset.exploit = true;
        this._exploit = value;
      }
    }

    public byte Max_people
    {
      get
      {
        return _max_people;
      }
      set
      {
        __isset.max_people = true;
        this._max_people = value;
      }
    }

    public byte Min_people
    {
      get
      {
        return _min_people;
      }
      set
      {
        __isset.min_people = true;
        this._min_people = value;
      }
    }

    public byte Max_winningStreak
    {
      get
      {
        return _max_winningStreak;
      }
      set
      {
        __isset.max_winningStreak = true;
        this._max_winningStreak = value;
      }
    }

    public int ItemId
    {
      get
      {
        return _itemId;
      }
      set
      {
        __isset.itemId = true;
        this._itemId = value;
      }
    }

    public byte Trait
    {
      get
      {
        return _trait;
      }
      set
      {
        __isset.trait = true;
        this._trait = value;
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

    public string ItemName
    {
      get
      {
        return _itemName;
      }
      set
      {
        __isset.itemName = true;
        this._itemName = value;
      }
    }

    public byte Probability
    {
      get
      {
        return _probability;
      }
      set
      {
        __isset.probability = true;
        this._probability = value;
      }
    }

    public List<Player_GVE_InfoResponse> Player_GVE_InfoList
    {
      get
      {
        return _player_GVE_InfoList;
      }
      set
      {
        __isset.player_GVE_InfoList = true;
        this._player_GVE_InfoList = value;
      }
    }

    public byte Target_people
    {
      get
      {
        return _target_people;
      }
      set
      {
        __isset.target_people = true;
        this._target_people = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool id;
      public bool name;
      public bool icon;
      public bool type;
      public bool lvl;
      public bool exploit;
      public bool max_people;
      public bool min_people;
      public bool max_winningStreak;
      public bool itemId;
      public bool trait;
      public bool image;
      public bool itemName;
      public bool probability;
      public bool player_GVE_InfoList;
      public bool target_people;
    }

    public Player_GVE_InfoListResponse() {
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
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Byte) {
              Type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I16) {
              Lvl = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              Exploit = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Byte) {
              Max_people = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Byte) {
              Min_people = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Byte) {
              Max_winningStreak = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              ItemId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Byte) {
              Trait = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I32) {
              Image = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.String) {
              ItemName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.Byte) {
              Probability = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.List) {
              {
                Player_GVE_InfoList = new List<Player_GVE_InfoResponse>();
                TList _list307 = iprot.ReadListBegin();
                for( int _i308 = 0; _i308 < _list307.Count; ++_i308)
                {
                  Player_GVE_InfoResponse _elem309 = new Player_GVE_InfoResponse();
                  _elem309 = new Player_GVE_InfoResponse();
                  _elem309.Read(iprot);
                  Player_GVE_InfoList.Add(_elem309);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 16:
            if (field.Type == TType.Byte) {
              Target_people = iprot.ReadByte();
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
      TStruct struc = new TStruct("Player_GVE_InfoListResponse");
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
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.Byte;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Type);
        oprot.WriteFieldEnd();
      }
      if (__isset.lvl) {
        field.Name = "lvl";
        field.Type = TType.I16;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Lvl);
        oprot.WriteFieldEnd();
      }
      if (Exploit != null && __isset.exploit) {
        field.Name = "exploit";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Exploit);
        oprot.WriteFieldEnd();
      }
      if (__isset.max_people) {
        field.Name = "max_people";
        field.Type = TType.Byte;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Max_people);
        oprot.WriteFieldEnd();
      }
      if (__isset.min_people) {
        field.Name = "min_people";
        field.Type = TType.Byte;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Min_people);
        oprot.WriteFieldEnd();
      }
      if (__isset.max_winningStreak) {
        field.Name = "max_winningStreak";
        field.Type = TType.Byte;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Max_winningStreak);
        oprot.WriteFieldEnd();
      }
      if (__isset.itemId) {
        field.Name = "itemId";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ItemId);
        oprot.WriteFieldEnd();
      }
      if (__isset.trait) {
        field.Name = "trait";
        field.Type = TType.Byte;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Trait);
        oprot.WriteFieldEnd();
      }
      if (__isset.image) {
        field.Name = "image";
        field.Type = TType.I32;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Image);
        oprot.WriteFieldEnd();
      }
      if (ItemName != null && __isset.itemName) {
        field.Name = "itemName";
        field.Type = TType.String;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ItemName);
        oprot.WriteFieldEnd();
      }
      if (__isset.probability) {
        field.Name = "probability";
        field.Type = TType.Byte;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Probability);
        oprot.WriteFieldEnd();
      }
      if (Player_GVE_InfoList != null && __isset.player_GVE_InfoList) {
        field.Name = "player_GVE_InfoList";
        field.Type = TType.List;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Player_GVE_InfoList.Count));
          foreach (Player_GVE_InfoResponse _iter310 in Player_GVE_InfoList)
          {
            _iter310.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.target_people) {
        field.Name = "target_people";
        field.Type = TType.Byte;
        field.ID = 16;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Target_people);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Player_GVE_InfoListResponse(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",Type: ");
      sb.Append(Type);
      sb.Append(",Lvl: ");
      sb.Append(Lvl);
      sb.Append(",Exploit: ");
      sb.Append(Exploit);
      sb.Append(",Max_people: ");
      sb.Append(Max_people);
      sb.Append(",Min_people: ");
      sb.Append(Min_people);
      sb.Append(",Max_winningStreak: ");
      sb.Append(Max_winningStreak);
      sb.Append(",ItemId: ");
      sb.Append(ItemId);
      sb.Append(",Trait: ");
      sb.Append(Trait);
      sb.Append(",Image: ");
      sb.Append(Image);
      sb.Append(",ItemName: ");
      sb.Append(ItemName);
      sb.Append(",Probability: ");
      sb.Append(Probability);
      sb.Append(",Player_GVE_InfoList: ");
      sb.Append(Player_GVE_InfoList);
      sb.Append(",Target_people: ");
      sb.Append(Target_people);
      sb.Append(")");
      return sb.ToString();
    }

  }

}