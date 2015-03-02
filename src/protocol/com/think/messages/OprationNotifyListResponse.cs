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
  public partial class OprationNotifyListResponse : TBase
  {
    private List<OprationNotifyResponse> _oprationNotifyList;

    public List<OprationNotifyResponse> OprationNotifyList
    {
      get
      {
        return _oprationNotifyList;
      }
      set
      {
        __isset.oprationNotifyList = true;
        this._oprationNotifyList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool oprationNotifyList;
    }

    public OprationNotifyListResponse() {
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
                OprationNotifyList = new List<OprationNotifyResponse>();
                TList _list508 = iprot.ReadListBegin();
                for( int _i509 = 0; _i509 < _list508.Count; ++_i509)
                {
                  OprationNotifyResponse _elem510 = new OprationNotifyResponse();
                  _elem510 = new OprationNotifyResponse();
                  _elem510.Read(iprot);
                  OprationNotifyList.Add(_elem510);
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
      TStruct struc = new TStruct("OprationNotifyListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (OprationNotifyList != null && __isset.oprationNotifyList) {
        field.Name = "oprationNotifyList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, OprationNotifyList.Count));
          foreach (OprationNotifyResponse _iter511 in OprationNotifyList)
          {
            _iter511.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("OprationNotifyListResponse(");
      sb.Append("OprationNotifyList: ");
      sb.Append(OprationNotifyList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}