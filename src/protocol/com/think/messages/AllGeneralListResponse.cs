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
  public partial class AllGeneralListResponse : TBase
  {
    private short _generalVersion;
    private List<GeneralResponse> _generalList;

    public short GeneralVersion
    {
      get
      {
        return _generalVersion;
      }
      set
      {
        __isset.generalVersion = true;
        this._generalVersion = value;
      }
    }

    public List<GeneralResponse> GeneralList
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
      public bool generalVersion;
      public bool generalList;
    }

    public AllGeneralListResponse() {
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
            if (field.Type == TType.I16) {
              GeneralVersion = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                GeneralList = new List<GeneralResponse>();
                TList _list52 = iprot.ReadListBegin();
                for( int _i53 = 0; _i53 < _list52.Count; ++_i53)
                {
                  GeneralResponse _elem54 = new GeneralResponse();
                  _elem54 = new GeneralResponse();
                  _elem54.Read(iprot);
                  GeneralList.Add(_elem54);
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
      TStruct struc = new TStruct("AllGeneralListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.generalVersion) {
        field.Name = "generalVersion";
        field.Type = TType.I16;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(GeneralVersion);
        oprot.WriteFieldEnd();
      }
      if (GeneralList != null && __isset.generalList) {
        field.Name = "generalList";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, GeneralList.Count));
          foreach (GeneralResponse _iter55 in GeneralList)
          {
            _iter55.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("AllGeneralListResponse(");
      sb.Append("GeneralVersion: ");
      sb.Append(GeneralVersion);
      sb.Append(",GeneralList: ");
      sb.Append(GeneralList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
