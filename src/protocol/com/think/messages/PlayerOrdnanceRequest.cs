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
  public partial class PlayerOrdnanceRequest : TBase
  {
    private byte _type;
    private byte _ordnanceBusinessman;
    private int _instanceId;
    private byte _index;
    private int _ordnanceId;
    private bool _automaticSynthesis;
    private byte _containerType;
    private int _generalId;

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

    public byte OrdnanceBusinessman
    {
      get
      {
        return _ordnanceBusinessman;
      }
      set
      {
        __isset.ordnanceBusinessman = true;
        this._ordnanceBusinessman = value;
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

    public byte Index
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

    public bool AutomaticSynthesis
    {
      get
      {
        return _automaticSynthesis;
      }
      set
      {
        __isset.automaticSynthesis = true;
        this._automaticSynthesis = value;
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

    public int GeneralId
    {
      get
      {
        return _generalId;
      }
      set
      {
        __isset.generalId = true;
        this._generalId = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool type;
      public bool ordnanceBusinessman;
      public bool instanceId;
      public bool index;
      public bool ordnanceId;
      public bool automaticSynthesis;
      public bool containerType;
      public bool generalId;
    }

    public PlayerOrdnanceRequest() {
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
              Type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Byte) {
              OrdnanceBusinessman = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              InstanceId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Byte) {
              Index = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              OrdnanceId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Bool) {
              AutomaticSynthesis = iprot.ReadBool();
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
            if (field.Type == TType.I32) {
              GeneralId = iprot.ReadI32();
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
      TStruct struc = new TStruct("PlayerOrdnanceRequest");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Type);
        oprot.WriteFieldEnd();
      }
      if (__isset.ordnanceBusinessman) {
        field.Name = "ordnanceBusinessman";
        field.Type = TType.Byte;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(OrdnanceBusinessman);
        oprot.WriteFieldEnd();
      }
      if (__isset.instanceId) {
        field.Name = "instanceId";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(InstanceId);
        oprot.WriteFieldEnd();
      }
      if (__isset.index) {
        field.Name = "index";
        field.Type = TType.Byte;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Index);
        oprot.WriteFieldEnd();
      }
      if (__isset.ordnanceId) {
        field.Name = "ordnanceId";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(OrdnanceId);
        oprot.WriteFieldEnd();
      }
      if (__isset.automaticSynthesis) {
        field.Name = "automaticSynthesis";
        field.Type = TType.Bool;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(AutomaticSynthesis);
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
      if (__isset.generalId) {
        field.Name = "generalId";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(GeneralId);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerOrdnanceRequest(");
      sb.Append("Type: ");
      sb.Append(Type);
      sb.Append(",OrdnanceBusinessman: ");
      sb.Append(OrdnanceBusinessman);
      sb.Append(",InstanceId: ");
      sb.Append(InstanceId);
      sb.Append(",Index: ");
      sb.Append(Index);
      sb.Append(",OrdnanceId: ");
      sb.Append(OrdnanceId);
      sb.Append(",AutomaticSynthesis: ");
      sb.Append(AutomaticSynthesis);
      sb.Append(",ContainerType: ");
      sb.Append(ContainerType);
      sb.Append(",GeneralId: ");
      sb.Append(GeneralId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
