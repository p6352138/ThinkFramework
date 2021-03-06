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
  public partial class DeletePlayerOrdnanceResponse : TBase
  {
    private byte _containerType;
    private int _instanceId;
    private short _index;
    private bool _isPickup;

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

    public bool IsPickup
    {
      get
      {
        return _isPickup;
      }
      set
      {
        __isset.isPickup = true;
        this._isPickup = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool containerType;
      public bool instanceId;
      public bool index;
      public bool isPickup;
    }

    public DeletePlayerOrdnanceResponse() {
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
            if (field.Type == TType.Byte) {
              ContainerType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              InstanceId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I16) {
              Index = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Bool) {
              IsPickup = iprot.ReadBool();
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
      TStruct struc = new TStruct("DeletePlayerOrdnanceResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.containerType) {
        field.Name = "containerType";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(ContainerType);
        oprot.WriteFieldEnd();
      }
      if (__isset.instanceId) {
        field.Name = "instanceId";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(InstanceId);
        oprot.WriteFieldEnd();
      }
      if (__isset.index) {
        field.Name = "index";
        field.Type = TType.I16;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Index);
        oprot.WriteFieldEnd();
      }
      if (__isset.isPickup) {
        field.Name = "isPickup";
        field.Type = TType.Bool;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsPickup);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("DeletePlayerOrdnanceResponse(");
      sb.Append("ContainerType: ");
      sb.Append(ContainerType);
      sb.Append(",InstanceId: ");
      sb.Append(InstanceId);
      sb.Append(",Index: ");
      sb.Append(Index);
      sb.Append(",IsPickup: ");
      sb.Append(IsPickup);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
