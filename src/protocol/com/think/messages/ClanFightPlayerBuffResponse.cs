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
  public partial class ClanFightPlayerBuffResponse : TBase
  {
    private byte _re_type;
    private int _id;
    private string _buffName;
    private int _icon;
    private int _remainingTime;
    private int _energy;
    private byte _consume_type;
    private int _consume_num;
    private int _maxTime;
    private string _detail;
    private string _occupy_detail;

    public byte Re_type
    {
      get
      {
        return _re_type;
      }
      set
      {
        __isset.re_type = true;
        this._re_type = value;
      }
    }

    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public string BuffName
    {
      get
      {
        return _buffName;
      }
      set
      {
        __isset.buffName = true;
        this._buffName = value;
      }
    }

    public int Icon
    {
      get
      {
        return _icon;
      }
      set
      {
        __isset.icon = true;
        this._icon = value;
      }
    }

    public int RemainingTime
    {
      get
      {
        return _remainingTime;
      }
      set
      {
        __isset.remainingTime = true;
        this._remainingTime = value;
      }
    }

    public int Energy
    {
      get
      {
        return _energy;
      }
      set
      {
        __isset.energy = true;
        this._energy = value;
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

    public int Consume_num
    {
      get
      {
        return _consume_num;
      }
      set
      {
        __isset.consume_num = true;
        this._consume_num = value;
      }
    }

    public int MaxTime
    {
      get
      {
        return _maxTime;
      }
      set
      {
        __isset.maxTime = true;
        this._maxTime = value;
      }
    }

    public string Detail
    {
      get
      {
        return _detail;
      }
      set
      {
        __isset.detail = true;
        this._detail = value;
      }
    }

    public string Occupy_detail
    {
      get
      {
        return _occupy_detail;
      }
      set
      {
        __isset.occupy_detail = true;
        this._occupy_detail = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool re_type;
      public bool id;
      public bool buffName;
      public bool icon;
      public bool remainingTime;
      public bool energy;
      public bool consume_type;
      public bool consume_num;
      public bool maxTime;
      public bool detail;
      public bool occupy_detail;
    }

    public ClanFightPlayerBuffResponse() {
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
              Re_type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              BuffName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              RemainingTime = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Energy = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Byte) {
              Consume_type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              Consume_num = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              MaxTime = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              Detail = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.String) {
              Occupy_detail = iprot.ReadString();
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
      TStruct struc = new TStruct("ClanFightPlayerBuffResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.re_type) {
        field.Name = "re_type";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Re_type);
        oprot.WriteFieldEnd();
      }
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
        oprot.WriteFieldEnd();
      }
      if (BuffName != null && __isset.buffName) {
        field.Name = "buffName";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(BuffName);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.remainingTime) {
        field.Name = "remainingTime";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(RemainingTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.energy) {
        field.Name = "energy";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Energy);
        oprot.WriteFieldEnd();
      }
      if (__isset.consume_type) {
        field.Name = "consume_type";
        field.Type = TType.Byte;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Consume_type);
        oprot.WriteFieldEnd();
      }
      if (__isset.consume_num) {
        field.Name = "consume_num";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Consume_num);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxTime) {
        field.Name = "maxTime";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxTime);
        oprot.WriteFieldEnd();
      }
      if (Detail != null && __isset.detail) {
        field.Name = "detail";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Detail);
        oprot.WriteFieldEnd();
      }
      if (Occupy_detail != null && __isset.occupy_detail) {
        field.Name = "occupy_detail";
        field.Type = TType.String;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Occupy_detail);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanFightPlayerBuffResponse(");
      sb.Append("Re_type: ");
      sb.Append(Re_type);
      sb.Append(",Id: ");
      sb.Append(Id);
      sb.Append(",BuffName: ");
      sb.Append(BuffName);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",RemainingTime: ");
      sb.Append(RemainingTime);
      sb.Append(",Energy: ");
      sb.Append(Energy);
      sb.Append(",Consume_type: ");
      sb.Append(Consume_type);
      sb.Append(",Consume_num: ");
      sb.Append(Consume_num);
      sb.Append(",MaxTime: ");
      sb.Append(MaxTime);
      sb.Append(",Detail: ");
      sb.Append(Detail);
      sb.Append(",Occupy_detail: ");
      sb.Append(Occupy_detail);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
