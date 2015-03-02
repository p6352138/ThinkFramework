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
  public partial class ClanFightPointPeopleListResponse : TBase
  {
    private List<ClanFightPointPeopleResponse> _peopleNumList;

    public List<ClanFightPointPeopleResponse> PeopleNumList
    {
      get
      {
        return _peopleNumList;
      }
      set
      {
        __isset.peopleNumList = true;
        this._peopleNumList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool peopleNumList;
    }

    public ClanFightPointPeopleListResponse() {
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
                PeopleNumList = new List<ClanFightPointPeopleResponse>();
                TList _list853 = iprot.ReadListBegin();
                for( int _i854 = 0; _i854 < _list853.Count; ++_i854)
                {
                  ClanFightPointPeopleResponse _elem855 = new ClanFightPointPeopleResponse();
                  _elem855 = new ClanFightPointPeopleResponse();
                  _elem855.Read(iprot);
                  PeopleNumList.Add(_elem855);
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
      TStruct struc = new TStruct("ClanFightPointPeopleListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PeopleNumList != null && __isset.peopleNumList) {
        field.Name = "peopleNumList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, PeopleNumList.Count));
          foreach (ClanFightPointPeopleResponse _iter856 in PeopleNumList)
          {
            _iter856.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanFightPointPeopleListResponse(");
      sb.Append("PeopleNumList: ");
      sb.Append(PeopleNumList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}