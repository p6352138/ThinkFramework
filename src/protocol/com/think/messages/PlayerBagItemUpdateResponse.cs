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
  public partial class PlayerBagItemUpdateResponse : TBase
  {
    private short _index;
    private short _nums;

    public short Index
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

    public short Nums
    {
      get
      {
        return _nums;
      }
      set
      {
        __isset.nums = true;
        this._nums = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool index;
      public bool nums;
    }

    public PlayerBagItemUpdateResponse() {
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
              Index = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I16) {
              Nums = iprot.ReadI16();
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
      TStruct struc = new TStruct("PlayerBagItemUpdateResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.index) {
        field.Name = "index";
        field.Type = TType.I16;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Index);
        oprot.WriteFieldEnd();
      }
      if (__isset.nums) {
        field.Name = "nums";
        field.Type = TType.I16;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Nums);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerBagItemUpdateResponse(");
      sb.Append("Index: ");
      sb.Append(Index);
      sb.Append(",Nums: ");
      sb.Append(Nums);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
