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
  public partial class MapAreaResponse : TBase
  {
    private List<CityResponse> _cityResponseList;

    public List<CityResponse> CityResponseList
    {
      get
      {
        return _cityResponseList;
      }
      set
      {
        __isset.cityResponseList = true;
        this._cityResponseList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool cityResponseList;
    }

    public MapAreaResponse() {
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
                CityResponseList = new List<CityResponse>();
                TList _list226 = iprot.ReadListBegin();
                for( int _i227 = 0; _i227 < _list226.Count; ++_i227)
                {
                  CityResponse _elem228 = new CityResponse();
                  _elem228 = new CityResponse();
                  _elem228.Read(iprot);
                  CityResponseList.Add(_elem228);
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
      TStruct struc = new TStruct("MapAreaResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (CityResponseList != null && __isset.cityResponseList) {
        field.Name = "cityResponseList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, CityResponseList.Count));
          foreach (CityResponse _iter229 in CityResponseList)
          {
            _iter229.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("MapAreaResponse(");
      sb.Append("CityResponseList: ");
      sb.Append(CityResponseList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}