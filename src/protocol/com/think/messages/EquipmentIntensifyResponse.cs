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
  public partial class EquipmentIntensifyResponse : TBase
  {
    private BagResponse _bagResponse;
    private long _money;
    private bool _isCrit;

    public BagResponse BagResponse
    {
      get
      {
        return _bagResponse;
      }
      set
      {
        __isset.bagResponse = true;
        this._bagResponse = value;
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

    public bool IsCrit
    {
      get
      {
        return _isCrit;
      }
      set
      {
        __isset.isCrit = true;
        this._isCrit = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool bagResponse;
      public bool money;
      public bool isCrit;
    }

    public EquipmentIntensifyResponse() {
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
              BagResponse = new BagResponse();
              BagResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I64) {
              Money = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Bool) {
              IsCrit = iprot.ReadBool();
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
      TStruct struc = new TStruct("EquipmentIntensifyResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (BagResponse != null && __isset.bagResponse) {
        field.Name = "bagResponse";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        BagResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.money) {
        field.Name = "money";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Money);
        oprot.WriteFieldEnd();
      }
      if (__isset.isCrit) {
        field.Name = "isCrit";
        field.Type = TType.Bool;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsCrit);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("EquipmentIntensifyResponse(");
      sb.Append("BagResponse: ");
      sb.Append(BagResponse== null ? "<null>" : BagResponse.ToString());
      sb.Append(",Money: ");
      sb.Append(Money);
      sb.Append(",IsCrit: ");
      sb.Append(IsCrit);
      sb.Append(")");
      return sb.ToString();
    }

  }

}