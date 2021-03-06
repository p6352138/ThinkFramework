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
  public partial class PositionResponse : TBase
  {
    private int _index;
    private int _ownerId;
    private string _signal;
    private string _name;
    private int _image_id;
    private int _attackTimes;
    private int _beAttackTimes;
    private bool _isSelf;
    private int _clan;
    private int _type;
    private int _state;
    private string _details;
    private int _production;
    private int _times;
    private bool _isDouble;
    private int _sumTime;
    private short _lvl;
    private int _areaId;
    private byte _areaType;

    public int Index
    {
      get
      {
        return _index;
      }
      set
      {
        __isset.index = true;
        this._index = value;
      }
    }

    public int OwnerId
    {
      get
      {
        return _ownerId;
      }
      set
      {
        __isset.ownerId = true;
        this._ownerId = value;
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

    public int Image_id
    {
      get
      {
        return _image_id;
      }
      set
      {
        __isset.image_id = true;
        this._image_id = value;
      }
    }

    public int AttackTimes
    {
      get
      {
        return _attackTimes;
      }
      set
      {
        __isset.attackTimes = true;
        this._attackTimes = value;
      }
    }

    public int BeAttackTimes
    {
      get
      {
        return _beAttackTimes;
      }
      set
      {
        __isset.beAttackTimes = true;
        this._beAttackTimes = value;
      }
    }

    public bool IsSelf
    {
      get
      {
        return _isSelf;
      }
      set
      {
        __isset.isSelf = true;
        this._isSelf = value;
      }
    }

    public int Clan
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

    public int Type
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

    public int State
    {
      get
      {
        return _state;
      }
      set
      {
        __isset.state = true;
        this._state = value;
      }
    }

    public string Details
    {
      get
      {
        return _details;
      }
      set
      {
        __isset.details = true;
        this._details = value;
      }
    }

    public int Production
    {
      get
      {
        return _production;
      }
      set
      {
        __isset.production = true;
        this._production = value;
      }
    }

    public int Times
    {
      get
      {
        return _times;
      }
      set
      {
        __isset.times = true;
        this._times = value;
      }
    }

    public bool IsDouble
    {
      get
      {
        return _isDouble;
      }
      set
      {
        __isset.isDouble = true;
        this._isDouble = value;
      }
    }

    public int SumTime
    {
      get
      {
        return _sumTime;
      }
      set
      {
        __isset.sumTime = true;
        this._sumTime = value;
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

    public int AreaId
    {
      get
      {
        return _areaId;
      }
      set
      {
        __isset.areaId = true;
        this._areaId = value;
      }
    }

    public byte AreaType
    {
      get
      {
        return _areaType;
      }
      set
      {
        __isset.areaType = true;
        this._areaType = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool index;
      public bool ownerId;
      public bool signal;
      public bool name;
      public bool image_id;
      public bool attackTimes;
      public bool beAttackTimes;
      public bool isSelf;
      public bool clan;
      public bool type;
      public bool state;
      public bool details;
      public bool production;
      public bool times;
      public bool isDouble;
      public bool sumTime;
      public bool lvl;
      public bool areaId;
      public bool areaType;
    }

    public PositionResponse() {
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
              Index = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              OwnerId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Signal = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Image_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              AttackTimes = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              BeAttackTimes = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Bool) {
              IsSelf = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              Clan = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              Type = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              State = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.String) {
              Details = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.I32) {
              Production = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.I32) {
              Times = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.Bool) {
              IsDouble = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 16:
            if (field.Type == TType.I32) {
              SumTime = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 17:
            if (field.Type == TType.I16) {
              Lvl = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 18:
            if (field.Type == TType.I32) {
              AreaId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 19:
            if (field.Type == TType.Byte) {
              AreaType = iprot.ReadByte();
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
      TStruct struc = new TStruct("PositionResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.index) {
        field.Name = "index";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Index);
        oprot.WriteFieldEnd();
      }
      if (__isset.ownerId) {
        field.Name = "ownerId";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(OwnerId);
        oprot.WriteFieldEnd();
      }
      if (Signal != null && __isset.signal) {
        field.Name = "signal";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Signal);
        oprot.WriteFieldEnd();
      }
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (__isset.image_id) {
        field.Name = "image_id";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Image_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackTimes) {
        field.Name = "attackTimes";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackTimes);
        oprot.WriteFieldEnd();
      }
      if (__isset.beAttackTimes) {
        field.Name = "beAttackTimes";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(BeAttackTimes);
        oprot.WriteFieldEnd();
      }
      if (__isset.isSelf) {
        field.Name = "isSelf";
        field.Type = TType.Bool;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsSelf);
        oprot.WriteFieldEnd();
      }
      if (__isset.clan) {
        field.Name = "clan";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Clan);
        oprot.WriteFieldEnd();
      }
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Type);
        oprot.WriteFieldEnd();
      }
      if (__isset.state) {
        field.Name = "state";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(State);
        oprot.WriteFieldEnd();
      }
      if (Details != null && __isset.details) {
        field.Name = "details";
        field.Type = TType.String;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Details);
        oprot.WriteFieldEnd();
      }
      if (__isset.production) {
        field.Name = "production";
        field.Type = TType.I32;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Production);
        oprot.WriteFieldEnd();
      }
      if (__isset.times) {
        field.Name = "times";
        field.Type = TType.I32;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Times);
        oprot.WriteFieldEnd();
      }
      if (__isset.isDouble) {
        field.Name = "isDouble";
        field.Type = TType.Bool;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsDouble);
        oprot.WriteFieldEnd();
      }
      if (__isset.sumTime) {
        field.Name = "sumTime";
        field.Type = TType.I32;
        field.ID = 16;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SumTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.lvl) {
        field.Name = "lvl";
        field.Type = TType.I16;
        field.ID = 17;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Lvl);
        oprot.WriteFieldEnd();
      }
      if (__isset.areaId) {
        field.Name = "areaId";
        field.Type = TType.I32;
        field.ID = 18;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AreaId);
        oprot.WriteFieldEnd();
      }
      if (__isset.areaType) {
        field.Name = "areaType";
        field.Type = TType.Byte;
        field.ID = 19;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(AreaType);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PositionResponse(");
      sb.Append("Index: ");
      sb.Append(Index);
      sb.Append(",OwnerId: ");
      sb.Append(OwnerId);
      sb.Append(",Signal: ");
      sb.Append(Signal);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",Image_id: ");
      sb.Append(Image_id);
      sb.Append(",AttackTimes: ");
      sb.Append(AttackTimes);
      sb.Append(",BeAttackTimes: ");
      sb.Append(BeAttackTimes);
      sb.Append(",IsSelf: ");
      sb.Append(IsSelf);
      sb.Append(",Clan: ");
      sb.Append(Clan);
      sb.Append(",Type: ");
      sb.Append(Type);
      sb.Append(",State: ");
      sb.Append(State);
      sb.Append(",Details: ");
      sb.Append(Details);
      sb.Append(",Production: ");
      sb.Append(Production);
      sb.Append(",Times: ");
      sb.Append(Times);
      sb.Append(",IsDouble: ");
      sb.Append(IsDouble);
      sb.Append(",SumTime: ");
      sb.Append(SumTime);
      sb.Append(",Lvl: ");
      sb.Append(Lvl);
      sb.Append(",AreaId: ");
      sb.Append(AreaId);
      sb.Append(",AreaType: ");
      sb.Append(AreaType);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
