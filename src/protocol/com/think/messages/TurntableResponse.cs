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
  public partial class TurntableResponse : TBase
  {
    private byte _respType;
    private List<string> _awardList;
    private int _resualt;
    private int _times;
    private int _maxTimes;

    public byte RespType
    {
      get
      {
        return _respType;
      }
      set
      {
        __isset.respType = true;
        this._respType = value;
      }
    }

    public List<string> AwardList
    {
      get
      {
        return _awardList;
      }
      set
      {
        __isset.awardList = true;
        this._awardList = value;
      }
    }

    public int Resualt
    {
      get
      {
        return _resualt;
      }
      set
      {
        __isset.resualt = true;
        this._resualt = value;
      }
    }

    public int Times
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

    public int MaxTimes
    {
      get
      {
        return _maxTimes;
      }
      set
      {
        __isset.maxTimes = true;
        this._maxTimes = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool respType;
      public bool awardList;
      public bool resualt;
      public bool times;
      public bool maxTimes;
    }

    public TurntableResponse() {
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
              RespType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                AwardList = new List<string>();
                TList _list753 = iprot.ReadListBegin();
                for( int _i754 = 0; _i754 < _list753.Count; ++_i754)
                {
                  string _elem755 = null;
                  _elem755 = iprot.ReadString();
                  AwardList.Add(_elem755);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Resualt = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Times = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              MaxTimes = iprot.ReadI32();
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
      TStruct struc = new TStruct("TurntableResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.respType) {
        field.Name = "respType";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(RespType);
        oprot.WriteFieldEnd();
      }
      if (AwardList != null && __isset.awardList) {
        field.Name = "awardList";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, AwardList.Count));
          foreach (string _iter756 in AwardList)
          {
            oprot.WriteString(_iter756);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.resualt) {
        field.Name = "resualt";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Resualt);
        oprot.WriteFieldEnd();
      }
      if (__isset.times) {
        field.Name = "times";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Times);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxTimes) {
        field.Name = "maxTimes";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxTimes);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TurntableResponse(");
      sb.Append("RespType: ");
      sb.Append(RespType);
      sb.Append(",AwardList: ");
      sb.Append(AwardList);
      sb.Append(",Resualt: ");
      sb.Append(Resualt);
      sb.Append(",Times: ");
      sb.Append(Times);
      sb.Append(",MaxTimes: ");
      sb.Append(MaxTimes);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
