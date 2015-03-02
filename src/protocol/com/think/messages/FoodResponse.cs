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
  public partial class FoodResponse : TBase
  {
    private short _multiple;
    private int _tradeVolume;
    private int _maxTradeVolume;
    private int _applanet;
    private byte _market;

    public short Multiple
    {
      get
      {
        return _multiple;
      }
      set
      {
        __isset.multiple = true;
        this._multiple = value;
      }
    }

    public int TradeVolume
    {
      get
      {
        return _tradeVolume;
      }
      set
      {
        __isset.tradeVolume = true;
        this._tradeVolume = value;
      }
    }

    public int MaxTradeVolume
    {
      get
      {
        return _maxTradeVolume;
      }
      set
      {
        __isset.maxTradeVolume = true;
        this._maxTradeVolume = value;
      }
    }

    public int Applanet
    {
      get
      {
        return _applanet;
      }
      set
      {
        __isset.applanet = true;
        this._applanet = value;
      }
    }

    public byte Market
    {
      get
      {
        return _market;
      }
      set
      {
        __isset.market = true;
        this._market = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool multiple;
      public bool tradeVolume;
      public bool maxTradeVolume;
      public bool applanet;
      public bool market;
    }

    public FoodResponse() {
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
            if (field.Type == TType.I16) {
              Multiple = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              TradeVolume = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              MaxTradeVolume = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Applanet = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Byte) {
              Market = iprot.ReadByte();
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
      TStruct struc = new TStruct("FoodResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.multiple) {
        field.Name = "multiple";
        field.Type = TType.I16;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Multiple);
        oprot.WriteFieldEnd();
      }
      if (__isset.tradeVolume) {
        field.Name = "tradeVolume";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TradeVolume);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxTradeVolume) {
        field.Name = "maxTradeVolume";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxTradeVolume);
        oprot.WriteFieldEnd();
      }
      if (__isset.applanet) {
        field.Name = "applanet";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Applanet);
        oprot.WriteFieldEnd();
      }
      if (__isset.market) {
        field.Name = "market";
        field.Type = TType.Byte;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Market);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("FoodResponse(");
      sb.Append("Multiple: ");
      sb.Append(Multiple);
      sb.Append(",TradeVolume: ");
      sb.Append(TradeVolume);
      sb.Append(",MaxTradeVolume: ");
      sb.Append(MaxTradeVolume);
      sb.Append(",Applanet: ");
      sb.Append(Applanet);
      sb.Append(",Market: ");
      sb.Append(Market);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
