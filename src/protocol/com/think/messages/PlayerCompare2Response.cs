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
  public partial class PlayerCompare2Response : TBase
  {
    private List<GeneralResponse> _sourceList;
    private List<GeneralResponse> _targetList;

    public List<GeneralResponse> SourceList
    {
      get
      {
        return _sourceList;
      }
      set
      {
        __isset.sourceList = true;
        this._sourceList = value;
      }
    }

    public List<GeneralResponse> TargetList
    {
      get
      {
        return _targetList;
      }
      set
      {
        __isset.targetList = true;
        this._targetList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool sourceList;
      public bool targetList;
    }

    public PlayerCompare2Response() {
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
            if (field.Type == TType.List) {
              {
                SourceList = new List<GeneralResponse>();
                TList _list544 = iprot.ReadListBegin();
                for( int _i545 = 0; _i545 < _list544.Count; ++_i545)
                {
                  GeneralResponse _elem546 = new GeneralResponse();
                  _elem546 = new GeneralResponse();
                  _elem546.Read(iprot);
                  SourceList.Add(_elem546);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                TargetList = new List<GeneralResponse>();
                TList _list547 = iprot.ReadListBegin();
                for( int _i548 = 0; _i548 < _list547.Count; ++_i548)
                {
                  GeneralResponse _elem549 = new GeneralResponse();
                  _elem549 = new GeneralResponse();
                  _elem549.Read(iprot);
                  TargetList.Add(_elem549);
                }
                iprot.ReadListEnd();
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
      TStruct struc = new TStruct("PlayerCompare2Response");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (SourceList != null && __isset.sourceList) {
        field.Name = "sourceList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, SourceList.Count));
          foreach (GeneralResponse _iter550 in SourceList)
          {
            _iter550.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (TargetList != null && __isset.targetList) {
        field.Name = "targetList";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, TargetList.Count));
          foreach (GeneralResponse _iter551 in TargetList)
          {
            _iter551.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerCompare2Response(");
      sb.Append("SourceList: ");
      sb.Append(SourceList);
      sb.Append(",TargetList: ");
      sb.Append(TargetList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
