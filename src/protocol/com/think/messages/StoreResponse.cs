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
  public partial class StoreResponse : TBase
  {
    private int _instanceID;
    private int _nums;
    private byte _consume_type;
    private int _consume;
    private ItemDetailResponse _itemDetail;
    private bool _sale;
    private bool _limit;
    private bool _down;
    private int _sale_consume;
    private int _limit_time;

    public int InstanceID
    {
      get
      {
        return _instanceID;
      }
      set
      {
        __isset.instanceID = true;
        this._instanceID = value;
      }
    }

    public int Nums
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

    public byte Consume_type
    {
      get
      {
        return _consume_type;
      }
      set
      {
        __isset.consume_type = true;
        this._consume_type = value;
      }
    }

    public int Consume
    {
      get
      {
        return _consume;
      }
      set
      {
        __isset.consume = true;
        this._consume = value;
      }
    }

    public ItemDetailResponse ItemDetail
    {
      get
      {
        return _itemDetail;
      }
      set
      {
        __isset.itemDetail = true;
        this._itemDetail = value;
      }
    }

    public bool Sale
    {
      get
      {
        return _sale;
      }
      set
      {
        __isset.sale = true;
        this._sale = value;
      }
    }

    public bool Limit
    {
      get
      {
        return _limit;
      }
      set
      {
        __isset.limit = true;
        this._limit = value;
      }
    }

    public bool Down
    {
      get
      {
        return _down;
      }
      set
      {
        __isset.down = true;
        this._down = value;
      }
    }

    public int Sale_consume
    {
      get
      {
        return _sale_consume;
      }
      set
      {
        __isset.sale_consume = true;
        this._sale_consume = value;
      }
    }

    public int Limit_time
    {
      get
      {
        return _limit_time;
      }
      set
      {
        __isset.limit_time = true;
        this._limit_time = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool instanceID;
      public bool nums;
      public bool consume_type;
      public bool consume;
      public bool itemDetail;
      public bool sale;
      public bool limit;
      public bool down;
      public bool sale_consume;
      public bool limit_time;
    }

    public StoreResponse() {
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
              InstanceID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Nums = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              Consume_type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Consume = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Struct) {
              ItemDetail = new ItemDetailResponse();
              ItemDetail.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Bool) {
              Sale = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Bool) {
              Limit = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Bool) {
              Down = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              Sale_consume = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              Limit_time = iprot.ReadI32();
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
      TStruct struc = new TStruct("StoreResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.instanceID) {
        field.Name = "instanceID";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(InstanceID);
        oprot.WriteFieldEnd();
      }
      if (__isset.nums) {
        field.Name = "nums";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Nums);
        oprot.WriteFieldEnd();
      }
      if (__isset.consume_type) {
        field.Name = "consume_type";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Consume_type);
        oprot.WriteFieldEnd();
      }
      if (__isset.consume) {
        field.Name = "consume";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Consume);
        oprot.WriteFieldEnd();
      }
      if (ItemDetail != null && __isset.itemDetail) {
        field.Name = "itemDetail";
        field.Type = TType.Struct;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        ItemDetail.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.sale) {
        field.Name = "sale";
        field.Type = TType.Bool;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Sale);
        oprot.WriteFieldEnd();
      }
      if (__isset.limit) {
        field.Name = "limit";
        field.Type = TType.Bool;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Limit);
        oprot.WriteFieldEnd();
      }
      if (__isset.down) {
        field.Name = "down";
        field.Type = TType.Bool;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Down);
        oprot.WriteFieldEnd();
      }
      if (__isset.sale_consume) {
        field.Name = "sale_consume";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Sale_consume);
        oprot.WriteFieldEnd();
      }
      if (__isset.limit_time) {
        field.Name = "limit_time";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Limit_time);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("StoreResponse(");
      sb.Append("InstanceID: ");
      sb.Append(InstanceID);
      sb.Append(",Nums: ");
      sb.Append(Nums);
      sb.Append(",Consume_type: ");
      sb.Append(Consume_type);
      sb.Append(",Consume: ");
      sb.Append(Consume);
      sb.Append(",ItemDetail: ");
      sb.Append(ItemDetail== null ? "<null>" : ItemDetail.ToString());
      sb.Append(",Sale: ");
      sb.Append(Sale);
      sb.Append(",Limit: ");
      sb.Append(Limit);
      sb.Append(",Down: ");
      sb.Append(Down);
      sb.Append(",Sale_consume: ");
      sb.Append(Sale_consume);
      sb.Append(",Limit_time: ");
      sb.Append(Limit_time);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
