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
  public partial class WashStoneShopResponse : TBase
  {
    private StoreResponse _storeResponse;
    private int _priceBy1;
    private int _priceBy10;
    private int _priceBy100;

    public StoreResponse StoreResponse
    {
      get
      {
        return _storeResponse;
      }
      set
      {
        __isset.storeResponse = true;
        this._storeResponse = value;
      }
    }

    public int PriceBy1
    {
      get
      {
        return _priceBy1;
      }
      set
      {
        __isset.priceBy1 = true;
        this._priceBy1 = value;
      }
    }

    public int PriceBy10
    {
      get
      {
        return _priceBy10;
      }
      set
      {
        __isset.priceBy10 = true;
        this._priceBy10 = value;
      }
    }

    public int PriceBy100
    {
      get
      {
        return _priceBy100;
      }
      set
      {
        __isset.priceBy100 = true;
        this._priceBy100 = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool storeResponse;
      public bool priceBy1;
      public bool priceBy10;
      public bool priceBy100;
    }

    public WashStoneShopResponse() {
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
            if (field.Type == TType.Struct) {
              StoreResponse = new StoreResponse();
              StoreResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              PriceBy1 = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              PriceBy10 = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              PriceBy100 = iprot.ReadI32();
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
      TStruct struc = new TStruct("WashStoneShopResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (StoreResponse != null && __isset.storeResponse) {
        field.Name = "storeResponse";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        StoreResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.priceBy1) {
        field.Name = "priceBy1";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(PriceBy1);
        oprot.WriteFieldEnd();
      }
      if (__isset.priceBy10) {
        field.Name = "priceBy10";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(PriceBy10);
        oprot.WriteFieldEnd();
      }
      if (__isset.priceBy100) {
        field.Name = "priceBy100";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(PriceBy100);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("WashStoneShopResponse(");
      sb.Append("StoreResponse: ");
      sb.Append(StoreResponse== null ? "<null>" : StoreResponse.ToString());
      sb.Append(",PriceBy1: ");
      sb.Append(PriceBy1);
      sb.Append(",PriceBy10: ");
      sb.Append(PriceBy10);
      sb.Append(",PriceBy100: ");
      sb.Append(PriceBy100);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
