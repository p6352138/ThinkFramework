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
  public partial class SchemeSynthesizeMaterialResponse : TBase
  {
    private SchemeDetailResponse _schemeDetail;
    private List<MaterialResponse> _materialList;

    public SchemeDetailResponse SchemeDetail
    {
      get
      {
        return _schemeDetail;
      }
      set
      {
        __isset.schemeDetail = true;
        this._schemeDetail = value;
      }
    }

    public List<MaterialResponse> MaterialList
    {
      get
      {
        return _materialList;
      }
      set
      {
        __isset.materialList = true;
        this._materialList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool schemeDetail;
      public bool materialList;
    }

    public SchemeSynthesizeMaterialResponse() {
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
            if (field.Type == TType.Struct) {
              SchemeDetail = new SchemeDetailResponse();
              SchemeDetail.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                MaterialList = new List<MaterialResponse>();
                TList _list628 = iprot.ReadListBegin();
                for( int _i629 = 0; _i629 < _list628.Count; ++_i629)
                {
                  MaterialResponse _elem630 = new MaterialResponse();
                  _elem630 = new MaterialResponse();
                  _elem630.Read(iprot);
                  MaterialList.Add(_elem630);
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
      TStruct struc = new TStruct("SchemeSynthesizeMaterialResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (SchemeDetail != null && __isset.schemeDetail) {
        field.Name = "schemeDetail";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        SchemeDetail.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (MaterialList != null && __isset.materialList) {
        field.Name = "materialList";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, MaterialList.Count));
          foreach (MaterialResponse _iter631 in MaterialList)
          {
            _iter631.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SchemeSynthesizeMaterialResponse(");
      sb.Append("SchemeDetail: ");
      sb.Append(SchemeDetail== null ? "<null>" : SchemeDetail.ToString());
      sb.Append(",MaterialList: ");
      sb.Append(MaterialList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
