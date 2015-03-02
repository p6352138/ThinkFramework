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
  public partial class ClanFightPlayerBuffListResponse : TBase
  {
    private List<ClanFightPlayerBuffResponse> _buffList;

    public List<ClanFightPlayerBuffResponse> BuffList
    {
      get
      {
        return _buffList;
      }
      set
      {
        __isset.buffList = true;
        this._buffList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool buffList;
    }

    public ClanFightPlayerBuffListResponse() {
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
                BuffList = new List<ClanFightPlayerBuffResponse>();
                TList _list809 = iprot.ReadListBegin();
                for( int _i810 = 0; _i810 < _list809.Count; ++_i810)
                {
                  ClanFightPlayerBuffResponse _elem811 = new ClanFightPlayerBuffResponse();
                  _elem811 = new ClanFightPlayerBuffResponse();
                  _elem811.Read(iprot);
                  BuffList.Add(_elem811);
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
      TStruct struc = new TStruct("ClanFightPlayerBuffListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (BuffList != null && __isset.buffList) {
        field.Name = "buffList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, BuffList.Count));
          foreach (ClanFightPlayerBuffResponse _iter812 in BuffList)
          {
            _iter812.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanFightPlayerBuffListResponse(");
      sb.Append("BuffList: ");
      sb.Append(BuffList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
