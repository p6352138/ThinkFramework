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
  public partial class VipPayListResponse : TBase
  {
    private List<VipPayResponse> _listVip;

    public List<VipPayResponse> ListVip
    {
      get
      {
        return _listVip;
      }
      set
      {
        __isset.listVip = true;
        this._listVip = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool listVip;
    }

    public VipPayListResponse() {
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
                ListVip = new List<VipPayResponse>();
                TList _list454 = iprot.ReadListBegin();
                for( int _i455 = 0; _i455 < _list454.Count; ++_i455)
                {
                  VipPayResponse _elem456 = new VipPayResponse();
                  _elem456 = new VipPayResponse();
                  _elem456.Read(iprot);
                  ListVip.Add(_elem456);
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
      TStruct struc = new TStruct("VipPayListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ListVip != null && __isset.listVip) {
        field.Name = "listVip";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ListVip.Count));
          foreach (VipPayResponse _iter457 in ListVip)
          {
            _iter457.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("VipPayListResponse(");
      sb.Append("ListVip: ");
      sb.Append(ListVip);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
