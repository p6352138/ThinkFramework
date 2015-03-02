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
  public partial class ClanVoteListResponse : TBase
  {
    private List<ClanOfficerResponse> _officerList;
    private bool _isVote;

    public List<ClanOfficerResponse> OfficerList
    {
      get
      {
        return _officerList;
      }
      set
      {
        __isset.officerList = true;
        this._officerList = value;
      }
    }

    public bool IsVote
    {
      get
      {
        return _isVote;
      }
      set
      {
        __isset.isVote = true;
        this._isVote = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool officerList;
      public bool isVote;
    }

    public ClanVoteListResponse() {
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
                OfficerList = new List<ClanOfficerResponse>();
                TList _list773 = iprot.ReadListBegin();
                for( int _i774 = 0; _i774 < _list773.Count; ++_i774)
                {
                  ClanOfficerResponse _elem775 = new ClanOfficerResponse();
                  _elem775 = new ClanOfficerResponse();
                  _elem775.Read(iprot);
                  OfficerList.Add(_elem775);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Bool) {
              IsVote = iprot.ReadBool();
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
      TStruct struc = new TStruct("ClanVoteListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (OfficerList != null && __isset.officerList) {
        field.Name = "officerList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, OfficerList.Count));
          foreach (ClanOfficerResponse _iter776 in OfficerList)
          {
            _iter776.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.isVote) {
        field.Name = "isVote";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsVote);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanVoteListResponse(");
      sb.Append("OfficerList: ");
      sb.Append(OfficerList);
      sb.Append(",IsVote: ");
      sb.Append(IsVote);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
