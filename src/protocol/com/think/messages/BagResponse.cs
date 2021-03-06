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
  public partial class BagResponse : TBase
  {
    private int _instanceID;
    private int _ownerUserID;
    private int _itemId;
    private byte _type;
    private short _nums;
    private short _index;
    private byte _containerType;
    private ItemDetailResponse _itemDetail;
    private int _generalID;

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

    public int OwnerUserID
    {
      get
      {
        return _ownerUserID;
      }
      set
      {
        __isset.ownerUserID = true;
        this._ownerUserID = value;
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

    public byte ContainerType
    {
      get
      {
        return _containerType;
      }
      set
      {
        __isset.containerType = true;
        this._containerType = value;
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

    public int GeneralID
    {
      get
      {
        return _generalID;
      }
      set
      {
        __isset.generalID = true;
        this._generalID = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool instanceID;
      public bool ownerUserID;
      public bool itemId;
      public bool type;
      public bool nums;
      public bool index;
      public bool containerType;
      public bool itemDetail;
      public bool generalID;
    }

    public BagResponse() {
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
              OwnerUserID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              ItemId = iprot.ReadI32();
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
              Nums = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I16) {
              Index = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Byte) {
              ContainerType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Struct) {
              ItemDetail = new ItemDetailResponse();
              ItemDetail.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              GeneralID = iprot.ReadI32();
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
      TStruct struc = new TStruct("BagResponse");
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
      if (__isset.ownerUserID) {
        field.Name = "ownerUserID";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(OwnerUserID);
        oprot.WriteFieldEnd();
      }
      if (__isset.itemId) {
        field.Name = "itemId";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ItemId);
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
      if (__isset.nums) {
        field.Name = "nums";
        field.Type = TType.I16;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Nums);
        oprot.WriteFieldEnd();
      }
      if (__isset.index) {
        field.Name = "index";
        field.Type = TType.I16;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Index);
        oprot.WriteFieldEnd();
      }
      if (__isset.containerType) {
        field.Name = "containerType";
        field.Type = TType.Byte;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(ContainerType);
        oprot.WriteFieldEnd();
      }
      if (ItemDetail != null && __isset.itemDetail) {
        field.Name = "itemDetail";
        field.Type = TType.Struct;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        ItemDetail.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.generalID) {
        field.Name = "generalID";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(GeneralID);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("BagResponse(");
      sb.Append("InstanceID: ");
      sb.Append(InstanceID);
      sb.Append(",OwnerUserID: ");
      sb.Append(OwnerUserID);
      sb.Append(",ItemId: ");
      sb.Append(ItemId);
      sb.Append(",Type: ");
      sb.Append(Type);
      sb.Append(",Nums: ");
      sb.Append(Nums);
      sb.Append(",Index: ");
      sb.Append(Index);
      sb.Append(",ContainerType: ");
      sb.Append(ContainerType);
      sb.Append(",ItemDetail: ");
      sb.Append(ItemDetail== null ? "<null>" : ItemDetail.ToString());
      sb.Append(",GeneralID: ");
      sb.Append(GeneralID);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
