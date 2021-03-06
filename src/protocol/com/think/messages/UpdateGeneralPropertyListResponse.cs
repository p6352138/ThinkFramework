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
  public partial class UpdateGeneralPropertyListResponse : TBase
  {
    private List<UpdateGeneralPropertyResponse> _generalList;

    public List<UpdateGeneralPropertyResponse> GeneralList
    {
      get
      {
        return _generalList;
      }
      set
      {
        __isset.generalList = true;
        this._generalList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool generalList;
    }

    public UpdateGeneralPropertyListResponse() {
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
                GeneralList = new List<UpdateGeneralPropertyResponse>();
                TList _list450 = iprot.ReadListBegin();
                for( int _i451 = 0; _i451 < _list450.Count; ++_i451)
                {
                  UpdateGeneralPropertyResponse _elem452 = new UpdateGeneralPropertyResponse();
                  _elem452 = new UpdateGeneralPropertyResponse();
                  _elem452.Read(iprot);
                  GeneralList.Add(_elem452);
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
      TStruct struc = new TStruct("UpdateGeneralPropertyListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (GeneralList != null && __isset.generalList) {
        field.Name = "generalList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, GeneralList.Count));
          foreach (UpdateGeneralPropertyResponse _iter453 in GeneralList)
          {
            _iter453.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("UpdateGeneralPropertyListResponse(");
      sb.Append("GeneralList: ");
      sb.Append(GeneralList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
