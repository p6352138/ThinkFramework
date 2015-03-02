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
  public partial class IconListResponse : TBase
  {
    private List<IconResponse> _iconList;

    public List<IconResponse> IconList
    {
      get
      {
        return _iconList;
      }
      set
      {
        __isset.iconList = true;
        this._iconList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool iconList;
    }

    public IconListResponse() {
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
                IconList = new List<IconResponse>();
                TList _list516 = iprot.ReadListBegin();
                for( int _i517 = 0; _i517 < _list516.Count; ++_i517)
                {
                  IconResponse _elem518 = new IconResponse();
                  _elem518 = new IconResponse();
                  _elem518.Read(iprot);
                  IconList.Add(_elem518);
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
      TStruct struc = new TStruct("IconListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (IconList != null && __isset.iconList) {
        field.Name = "iconList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, IconList.Count));
          foreach (IconResponse _iter519 in IconList)
          {
            _iter519.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("IconListResponse(");
      sb.Append("IconList: ");
      sb.Append(IconList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}