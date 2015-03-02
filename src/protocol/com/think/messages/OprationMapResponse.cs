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
  public partial class OprationMapResponse : TBase
  {
    private Dictionary<int, byte> _mapResponse;

    public Dictionary<int, byte> MapResponse
    {
      get
      {
        return _mapResponse;
      }
      set
      {
        __isset.mapResponse = true;
        this._mapResponse = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool mapResponse;
    }

    public OprationMapResponse() {
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
            if (field.Type == TType.Map) {
              {
                MapResponse = new Dictionary<int, byte>();
                TMap _map402 = iprot.ReadMapBegin();
                for( int _i403 = 0; _i403 < _map402.Count; ++_i403)
                {
                  int _key404;
                  byte _val405;
                  _key404 = iprot.ReadI32();
                  _val405 = iprot.ReadByte();
                  MapResponse[_key404] = _val405;
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
      TStruct struc = new TStruct("OprationMapResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (MapResponse != null && __isset.mapResponse) {
        field.Name = "mapResponse";
        field.Type = TType.Map;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.I32, TType.Byte, MapResponse.Count));
          foreach (int _iter406 in MapResponse.Keys)
          {
            oprot.WriteI32(_iter406);
            oprot.WriteByte(MapResponse[_iter406]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("OprationMapResponse(");
      sb.Append("MapResponse: ");
      sb.Append(MapResponse);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
