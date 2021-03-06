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
  public partial class MorrowAwardListResponse : TBase
  {
    private List<MorrowAwardResponse> _resourceList;
    private int _checkedNum;
    private string _description;

    public List<MorrowAwardResponse> ResourceList
    {
      get
      {
        return _resourceList;
      }
      set
      {
        __isset.resourceList = true;
        this._resourceList = value;
      }
    }

    public int CheckedNum
    {
      get
      {
        return _checkedNum;
      }
      set
      {
        __isset.checkedNum = true;
        this._checkedNum = value;
      }
    }

    public string Description
    {
      get
      {
        return _description;
      }
      set
      {
        __isset.description = true;
        this._description = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool resourceList;
      public bool checkedNum;
      public bool description;
    }

    public MorrowAwardListResponse() {
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
                ResourceList = new List<MorrowAwardResponse>();
                TList _list737 = iprot.ReadListBegin();
                for( int _i738 = 0; _i738 < _list737.Count; ++_i738)
                {
                  MorrowAwardResponse _elem739 = new MorrowAwardResponse();
                  _elem739 = new MorrowAwardResponse();
                  _elem739.Read(iprot);
                  ResourceList.Add(_elem739);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              CheckedNum = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Description = iprot.ReadString();
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
      TStruct struc = new TStruct("MorrowAwardListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ResourceList != null && __isset.resourceList) {
        field.Name = "resourceList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ResourceList.Count));
          foreach (MorrowAwardResponse _iter740 in ResourceList)
          {
            _iter740.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.checkedNum) {
        field.Name = "checkedNum";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(CheckedNum);
        oprot.WriteFieldEnd();
      }
      if (Description != null && __isset.description) {
        field.Name = "description";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Description);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("MorrowAwardListResponse(");
      sb.Append("ResourceList: ");
      sb.Append(ResourceList);
      sb.Append(",CheckedNum: ");
      sb.Append(CheckedNum);
      sb.Append(",Description: ");
      sb.Append(Description);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
