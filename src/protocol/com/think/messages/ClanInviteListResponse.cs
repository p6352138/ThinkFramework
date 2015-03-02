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
  public partial class ClanInviteListResponse : TBase
  {
    private List<ClanInviteResponse> _listClan;

    public List<ClanInviteResponse> ListClan
    {
      get
      {
        return _listClan;
      }
      set
      {
        __isset.listClan = true;
        this._listClan = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool listClan;
    }

    public ClanInviteListResponse() {
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
                ListClan = new List<ClanInviteResponse>();
                TList _list765 = iprot.ReadListBegin();
                for( int _i766 = 0; _i766 < _list765.Count; ++_i766)
                {
                  ClanInviteResponse _elem767 = new ClanInviteResponse();
                  _elem767 = new ClanInviteResponse();
                  _elem767.Read(iprot);
                  ListClan.Add(_elem767);
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
      TStruct struc = new TStruct("ClanInviteListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ListClan != null && __isset.listClan) {
        field.Name = "listClan";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ListClan.Count));
          foreach (ClanInviteResponse _iter768 in ListClan)
          {
            _iter768.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanInviteListResponse(");
      sb.Append("ListClan: ");
      sb.Append(ListClan);
      sb.Append(")");
      return sb.ToString();
    }

  }

}