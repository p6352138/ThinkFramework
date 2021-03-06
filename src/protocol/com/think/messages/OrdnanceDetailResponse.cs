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
  public partial class OrdnanceDetailResponse : TBase
  {
    private int _instanceId;
    private int _ordnanceId;
    private string _name;
    private byte _trait;
    private int _iconId;
    private int _imageId;
    private int _price;
    private string _description;
    private Dictionary<byte, int> _attributeMap;
    private short _level;
    private int _initial_exp;
    private int _upgrade_exp;
    private List<int> _exclusive_general;

    public int InstanceId
    {
      get
      {
        return _instanceId;
      }
      set
      {
        __isset.instanceId = true;
        this._instanceId = value;
      }
    }

    public int OrdnanceId
    {
      get
      {
        return _ordnanceId;
      }
      set
      {
        __isset.ordnanceId = true;
        this._ordnanceId = value;
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

    public int IconId
    {
      get
      {
        return _iconId;
      }
      set
      {
        __isset.iconId = true;
        this._iconId = value;
      }
    }

    public int ImageId
    {
      get
      {
        return _imageId;
      }
      set
      {
        __isset.imageId = true;
        this._imageId = value;
      }
    }

    public int Price
    {
      get
      {
        return _price;
      }
      set
      {
        __isset.price = true;
        this._price = value;
      }
    }

    public string Description
    {
      get
      {
        return _description;
      }
      set
      {
        __isset.description = true;
        this._description = value;
      }
    }

    public Dictionary<byte, int> AttributeMap
    {
      get
      {
        return _attributeMap;
      }
      set
      {
        __isset.attributeMap = true;
        this._attributeMap = value;
      }
    }

    public short Level
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

    public int Initial_exp
    {
      get
      {
        return _initial_exp;
      }
      set
      {
        __isset.initial_exp = true;
        this._initial_exp = value;
      }
    }

    public int Upgrade_exp
    {
      get
      {
        return _upgrade_exp;
      }
      set
      {
        __isset.upgrade_exp = true;
        this._upgrade_exp = value;
      }
    }

    public List<int> Exclusive_general
    {
      get
      {
        return _exclusive_general;
      }
      set
      {
        __isset.exclusive_general = true;
        this._exclusive_general = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool instanceId;
      public bool ordnanceId;
      public bool name;
      public bool trait;
      public bool iconId;
      public bool imageId;
      public bool price;
      public bool description;
      public bool attributeMap;
      public bool level;
      public bool initial_exp;
      public bool upgrade_exp;
      public bool exclusive_general;
    }

    public OrdnanceDetailResponse() {
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
              InstanceId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              OrdnanceId = iprot.ReadI32();
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
            if (field.Type == TType.Byte) {
              Trait = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              IconId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              ImageId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              Price = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.String) {
              Description = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Map) {
              {
                AttributeMap = new Dictionary<byte, int>();
                TMap _map335 = iprot.ReadMapBegin();
                for( int _i336 = 0; _i336 < _map335.Count; ++_i336)
                {
                  byte _key337;
                  int _val338;
                  _key337 = iprot.ReadByte();
                  _val338 = iprot.ReadI32();
                  AttributeMap[_key337] = _val338;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I16) {
              Level = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              Initial_exp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I32) {
              Upgrade_exp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.List) {
              {
                Exclusive_general = new List<int>();
                TList _list339 = iprot.ReadListBegin();
                for( int _i340 = 0; _i340 < _list339.Count; ++_i340)
                {
                  int _elem341 = 0;
                  _elem341 = iprot.ReadI32();
                  Exclusive_general.Add(_elem341);
                }
                iprot.ReadListEnd();
              }
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
      TStruct struc = new TStruct("OrdnanceDetailResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.instanceId) {
        field.Name = "instanceId";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(InstanceId);
        oprot.WriteFieldEnd();
      }
      if (__isset.ordnanceId) {
        field.Name = "ordnanceId";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(OrdnanceId);
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
      if (__isset.trait) {
        field.Name = "trait";
        field.Type = TType.Byte;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Trait);
        oprot.WriteFieldEnd();
      }
      if (__isset.iconId) {
        field.Name = "iconId";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(IconId);
        oprot.WriteFieldEnd();
      }
      if (__isset.imageId) {
        field.Name = "imageId";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ImageId);
        oprot.WriteFieldEnd();
      }
      if (__isset.price) {
        field.Name = "price";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Price);
        oprot.WriteFieldEnd();
      }
      if (Description != null && __isset.description) {
        field.Name = "description";
        field.Type = TType.String;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Description);
        oprot.WriteFieldEnd();
      }
      if (AttributeMap != null && __isset.attributeMap) {
        field.Name = "attributeMap";
        field.Type = TType.Map;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Byte, TType.I32, AttributeMap.Count));
          foreach (byte _iter342 in AttributeMap.Keys)
          {
            oprot.WriteByte(_iter342);
            oprot.WriteI32(AttributeMap[_iter342]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.level) {
        field.Name = "level";
        field.Type = TType.I16;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Level);
        oprot.WriteFieldEnd();
      }
      if (__isset.initial_exp) {
        field.Name = "initial_exp";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Initial_exp);
        oprot.WriteFieldEnd();
      }
      if (__isset.upgrade_exp) {
        field.Name = "upgrade_exp";
        field.Type = TType.I32;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Upgrade_exp);
        oprot.WriteFieldEnd();
      }
      if (Exclusive_general != null && __isset.exclusive_general) {
        field.Name = "exclusive_general";
        field.Type = TType.List;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I32, Exclusive_general.Count));
          foreach (int _iter343 in Exclusive_general)
          {
            oprot.WriteI32(_iter343);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("OrdnanceDetailResponse(");
      sb.Append("InstanceId: ");
      sb.Append(InstanceId);
      sb.Append(",OrdnanceId: ");
      sb.Append(OrdnanceId);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",Trait: ");
      sb.Append(Trait);
      sb.Append(",IconId: ");
      sb.Append(IconId);
      sb.Append(",ImageId: ");
      sb.Append(ImageId);
      sb.Append(",Price: ");
      sb.Append(Price);
      sb.Append(",Description: ");
      sb.Append(Description);
      sb.Append(",AttributeMap: ");
      sb.Append(AttributeMap);
      sb.Append(",Level: ");
      sb.Append(Level);
      sb.Append(",Initial_exp: ");
      sb.Append(Initial_exp);
      sb.Append(",Upgrade_exp: ");
      sb.Append(Upgrade_exp);
      sb.Append(",Exclusive_general: ");
      sb.Append(Exclusive_general);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
