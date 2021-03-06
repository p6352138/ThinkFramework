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
  public partial class CtiyAreaResponse : TBase
  {
    private AreaResponse _areaResponse;
    private List<PositionResponse> _positionResponseList;

    public AreaResponse AreaResponse
    {
      get
      {
        return _areaResponse;
      }
      set
      {
        __isset.areaResponse = true;
        this._areaResponse = value;
      }
    }

    public List<PositionResponse> PositionResponseList
    {
      get
      {
        return _positionResponseList;
      }
      set
      {
        __isset.positionResponseList = true;
        this._positionResponseList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool areaResponse;
      public bool positionResponseList;
    }

    public CtiyAreaResponse() {
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
            if (field.Type == TType.Struct) {
              AreaResponse = new AreaResponse();
              AreaResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                PositionResponseList = new List<PositionResponse>();
                TList _list230 = iprot.ReadListBegin();
                for( int _i231 = 0; _i231 < _list230.Count; ++_i231)
                {
                  PositionResponse _elem232 = new PositionResponse();
                  _elem232 = new PositionResponse();
                  _elem232.Read(iprot);
                  PositionResponseList.Add(_elem232);
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
      TStruct struc = new TStruct("CtiyAreaResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (AreaResponse != null && __isset.areaResponse) {
        field.Name = "areaResponse";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        AreaResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (PositionResponseList != null && __isset.positionResponseList) {
        field.Name = "positionResponseList";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, PositionResponseList.Count));
          foreach (PositionResponse _iter233 in PositionResponseList)
          {
            _iter233.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CtiyAreaResponse(");
      sb.Append("AreaResponse: ");
      sb.Append(AreaResponse== null ? "<null>" : AreaResponse.ToString());
      sb.Append(",PositionResponseList: ");
      sb.Append(PositionResponseList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
