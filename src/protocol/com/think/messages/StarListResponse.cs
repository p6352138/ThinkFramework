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
  public partial class StarListResponse : TBase
  {
    private List<StarDetailResponse> _starDetailList;

    public List<StarDetailResponse> StarDetailList
    {
      get
      {
        return _starDetailList;
      }
      set
      {
        __isset.starDetailList = true;
        this._starDetailList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool starDetailList;
    }

    public StarListResponse() {
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
                StarDetailList = new List<StarDetailResponse>();
                TList _list700 = iprot.ReadListBegin();
                for( int _i701 = 0; _i701 < _list700.Count; ++_i701)
                {
                  StarDetailResponse _elem702 = new StarDetailResponse();
                  _elem702 = new StarDetailResponse();
                  _elem702.Read(iprot);
                  StarDetailList.Add(_elem702);
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
      TStruct struc = new TStruct("StarListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (StarDetailList != null && __isset.starDetailList) {
        field.Name = "starDetailList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, StarDetailList.Count));
          foreach (StarDetailResponse _iter703 in StarDetailList)
          {
            _iter703.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("StarListResponse(");
      sb.Append("StarDetailList: ");
      sb.Append(StarDetailList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
