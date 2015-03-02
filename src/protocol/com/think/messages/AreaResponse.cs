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
  public partial class AreaResponse : TBase
  {
    private int _areaId;
    private string _name;
    private byte _areaType;
    private int _totalAreaNum;
    private int _prosperity;
    private int _specialFeature;
    private int _prices;
    private int _occupancy;

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

    public int TotalAreaNum
    {
      get
      {
        return _totalAreaNum;
      }
      set
      {
        __isset.totalAreaNum = true;
        this._totalAreaNum = value;
      }
    }

    public int Prosperity
    {
      get
      {
        return _prosperity;
      }
      set
      {
        __isset.prosperity = true;
        this._prosperity = value;
      }
    }

    public int SpecialFeature
    {
      get
      {
        return _specialFeature;
      }
      set
      {
        __isset.specialFeature = true;
        this._specialFeature = value;
      }
    }

    public int Prices
    {
      get
      {
        return _prices;
      }
      set
      {
        __isset.prices = true;
        this._prices = value;
      }
    }

    public int Occupancy
    {
      get
      {
        return _occupancy;
      }
      set
      {
        __isset.occupancy = true;
        this._occupancy = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool areaId;
      public bool name;
      public bool areaType;
      public bool totalAreaNum;
      public bool prosperity;
      public bool specialFeature;
      public bool prices;
      public bool occupancy;
    }

    public AreaResponse() {
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
              AreaId = iprot.ReadI32();
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
            if (field.Type == TType.Byte) {
              AreaType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              TotalAreaNum = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Prosperity = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              SpecialFeature = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              Prices = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              Occupancy = iprot.ReadI32();
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
      TStruct struc = new TStruct("AreaResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.areaId) {
        field.Name = "areaId";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AreaId);
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
      if (__isset.areaType) {
        field.Name = "areaType";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(AreaType);
        oprot.WriteFieldEnd();
      }
      if (__isset.totalAreaNum) {
        field.Name = "totalAreaNum";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TotalAreaNum);
        oprot.WriteFieldEnd();
      }
      if (__isset.prosperity) {
        field.Name = "prosperity";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Prosperity);
        oprot.WriteFieldEnd();
      }
      if (__isset.specialFeature) {
        field.Name = "specialFeature";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SpecialFeature);
        oprot.WriteFieldEnd();
      }
      if (__isset.prices) {
        field.Name = "prices";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Prices);
        oprot.WriteFieldEnd();
      }
      if (__isset.occupancy) {
        field.Name = "occupancy";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Occupancy);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("AreaResponse(");
      sb.Append("AreaId: ");
      sb.Append(AreaId);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",AreaType: ");
      sb.Append(AreaType);
      sb.Append(",TotalAreaNum: ");
      sb.Append(TotalAreaNum);
      sb.Append(",Prosperity: ");
      sb.Append(Prosperity);
      sb.Append(",SpecialFeature: ");
      sb.Append(SpecialFeature);
      sb.Append(",Prices: ");
      sb.Append(Prices);
      sb.Append(",Occupancy: ");
      sb.Append(Occupancy);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
