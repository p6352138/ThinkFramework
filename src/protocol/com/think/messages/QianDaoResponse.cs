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
  public partial class QianDaoResponse : TBase
  {
    private byte _type;
    private byte _currentDay;
    private byte _times;
    private byte _number;
    private Dictionary<byte, byte> _dayStateMap;
    private Dictionary<byte, QianDaoAwardResponse> _qianDaoAwardMap;

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

    public byte CurrentDay
    {
      get
      {
        return _currentDay;
      }
      set
      {
        __isset.currentDay = true;
        this._currentDay = value;
      }
    }

    public byte Times
    {
      get
      {
        return _times;
      }
      set
      {
        __isset.times = true;
        this._times = value;
      }
    }

    public byte Number
    {
      get
      {
        return _number;
      }
      set
      {
        __isset.number = true;
        this._number = value;
      }
    }

    public Dictionary<byte, byte> DayStateMap
    {
      get
      {
        return _dayStateMap;
      }
      set
      {
        __isset.dayStateMap = true;
        this._dayStateMap = value;
      }
    }

    public Dictionary<byte, QianDaoAwardResponse> QianDaoAwardMap
    {
      get
      {
        return _qianDaoAwardMap;
      }
      set
      {
        __isset.qianDaoAwardMap = true;
        this._qianDaoAwardMap = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool type;
      public bool currentDay;
      public bool times;
      public bool number;
      public bool dayStateMap;
      public bool qianDaoAwardMap;
    }

    public QianDaoResponse() {
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
              CurrentDay = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              Times = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Byte) {
              Number = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Map) {
              {
                DayStateMap = new Dictionary<byte, byte>();
                TMap _map454 = iprot.ReadMapBegin();
                for( int _i455 = 0; _i455 < _map454.Count; ++_i455)
                {
                  byte _key456;
                  byte _val457;
                  _key456 = iprot.ReadByte();
                  _val457 = iprot.ReadByte();
                  DayStateMap[_key456] = _val457;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Map) {
              {
                QianDaoAwardMap = new Dictionary<byte, QianDaoAwardResponse>();
                TMap _map458 = iprot.ReadMapBegin();
                for( int _i459 = 0; _i459 < _map458.Count; ++_i459)
                {
                  byte _key460;
                  QianDaoAwardResponse _val461;
                  _key460 = iprot.ReadByte();
                  _val461 = new QianDaoAwardResponse();
                  _val461.Read(iprot);
                  QianDaoAwardMap[_key460] = _val461;
                }
                iprot.ReadMapEnd();
              }
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
      TStruct struc = new TStruct("QianDaoResponse");
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
      if (__isset.currentDay) {
        field.Name = "currentDay";
        field.Type = TType.Byte;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(CurrentDay);
        oprot.WriteFieldEnd();
      }
      if (__isset.times) {
        field.Name = "times";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Times);
        oprot.WriteFieldEnd();
      }
      if (__isset.number) {
        field.Name = "number";
        field.Type = TType.Byte;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Number);
        oprot.WriteFieldEnd();
      }
      if (DayStateMap != null && __isset.dayStateMap) {
        field.Name = "dayStateMap";
        field.Type = TType.Map;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Byte, TType.Byte, DayStateMap.Count));
          foreach (byte _iter462 in DayStateMap.Keys)
          {
            oprot.WriteByte(_iter462);
            oprot.WriteByte(DayStateMap[_iter462]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (QianDaoAwardMap != null && __isset.qianDaoAwardMap) {
        field.Name = "qianDaoAwardMap";
        field.Type = TType.Map;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Byte, TType.Struct, QianDaoAwardMap.Count));
          foreach (byte _iter463 in QianDaoAwardMap.Keys)
          {
            oprot.WriteByte(_iter463);
            QianDaoAwardMap[_iter463].Write(oprot);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("QianDaoResponse(");
      sb.Append("Type: ");
      sb.Append(Type);
      sb.Append(",CurrentDay: ");
      sb.Append(CurrentDay);
      sb.Append(",Times: ");
      sb.Append(Times);
      sb.Append(",Number: ");
      sb.Append(Number);
      sb.Append(",DayStateMap: ");
      sb.Append(DayStateMap);
      sb.Append(",QianDaoAwardMap: ");
      sb.Append(QianDaoAwardMap);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
